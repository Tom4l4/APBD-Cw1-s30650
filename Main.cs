using APBD_Cw1_s30650.Services;
using APBD_Cw1_s30650.Models.Equipments;
using APBD_Cw1_s30650.Enums;

class Program
{
    static void Main(string[] args)
    {
        UserService userService = new UserService();
        EquipmentService equipmentService = new EquipmentService();
        RentalService rentalService = new RentalService();
        ReportService reportService = new ReportService(equipmentService, rentalService);

        Laptop laptop1 = new Laptop("Dell", "XPS", 512, 16, "i7", OS.Windows, 100);
        Laptop laptop2 = new Laptop("HP", "EliteBook", 256, 8, "i5", OS.Linux, 50);
        Laptop laptop3 = new Laptop("Lenovo", "ThinkPad", 512, 16, "i7", OS.Windows, 200);
        Laptop laptop4 = new Laptop("Apple", "MacBook Pro", 512, 16, "M2", OS.MacOS, 250);
        Laptop laptop5 = new Laptop("Asus", "ZenBook", 256, 8, "i5", OS.Linux, 50);
        Laptop laptop6 = new Laptop("Acer", "Swift", 512, 16, "i7", OS.Windows, 4000);
        
        equipmentService.AddEquipment(laptop1);
        equipmentService.AddEquipment(laptop2);
        equipmentService.AddEquipment(laptop3);
        equipmentService.AddEquipment(laptop4);
        equipmentService.AddEquipment(laptop5);
        equipmentService.AddEquipment(laptop6);
    }
}