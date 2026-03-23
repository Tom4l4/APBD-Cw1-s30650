namespace APBD_Cw1_s30650.Services;

public class ReportService
{
    private readonly EquipmentService equipmentService;
    private readonly RentalService rentalService;

    public ReportService(EquipmentService equipmentService, RentalService rentalService)
    {
        this.equipmentService = equipmentService;
        this.rentalService = rentalService;
    }

    public string GenerateReport()
    {
        var allEquipments = equipmentService.GetAllEquipments();
        var availableEquipments = equipmentService.GetAvailableEquipments();
        var allRentals = rentalService.GetAllRentals();
        var overdueRentals = allRentals.Where(r => r.ReturnDate == null && r.EndDate < DateTime.Now).ToList();

        return $"Total equipment: {allEquipments.Count}\n" + $"Available equipment: {availableEquipments.Count}\n" + $"Total rentals: {allRentals.Count}\n" + $"Overdue rentals: {overdueRentals.Count}";
    }
}