using APBD_Cw1_s30650.Services;
using APBD_Cw1_s30650.Models.Equipments;
using APBD_Cw1_s30650.Models.Users;
using APBD_Cw1_s30650.Enums;

class Program
{
    static void Separator()
    {
        Console.WriteLine(new string('-', 40));
    }

    static void SuccessMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(message);
        Console.ResetColor();
        Separator();
    }

    static void ErrorMessage(string message = "Invalid value.")
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ResetColor();
        Separator();
    }

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

        Student student1 = new Student("Krzysztof", "Kamiński");
        Student student2 = new Student("Marek", "Nosek");
        Employee employee1 = new Employee("Sylwia", "Kacprzak");

        userService.AddUser(student1);
        userService.AddUser(student2);
        userService.AddUser(employee1);

        bool running = true;

        while (running)
        {
            Separator();
            Console.WriteLine("=== RENTAL SYSTEM ===");
            Separator();
            Console.WriteLine("1. Add user");
            Console.WriteLine("2. Add equipment");
            Console.WriteLine("3. Rent equipment");
            Console.WriteLine("4. Return of equipment");
            Console.WriteLine("5. View report");
            Console.WriteLine("0. Exit");
            Separator();
            Console.Write("Select an option: ");

            string choice = Console.ReadLine();


            switch (choice)
            {
                case "1":
                    Separator();
                    Console.WriteLine("Select user type:");
                    Separator();
                    Console.WriteLine("1. Student");
                    Console.WriteLine("2. Employee");
                    string userType = Console.ReadLine();

                    Separator();
                    Console.WriteLine("Enter your first name:");
                    string firstName = Console.ReadLine();

                    Separator();
                    Console.WriteLine("Enter your last name:");
                    string lastName = Console.ReadLine();

                    if (userType == "1")
                    {
                        Student student = new Student(firstName, lastName);
                        userService.AddUser(student);
                        Separator();
                        SuccessMessage("Student added.");
                    }
                    else if (userType == "2")
                    {
                        Employee employee = new Employee(firstName, lastName);
                        userService.AddUser(employee);
                        Separator();
                        SuccessMessage("Employee added.");
                    }
                    else
                    {
                        Separator();
                        ErrorMessage("Invalid user type.");
                    }
                    break;

                case "2":
                    Console.WriteLine("\n--- ADD EQUIPMENT ---");
                    Separator();
                    Console.WriteLine("1. Laptop");
                    Console.WriteLine("2. Projector");
                    Console.WriteLine("3. Camera");
                    Console.WriteLine("4. Monitor");
                    Console.WriteLine("5. Router");
                    Separator();
                    Console.Write("Wybierz typ sprzętu: ");
                    string equipmentType = Console.ReadLine() ?? "";

                    if (equipmentType != "1" &&
                        equipmentType != "2" &&
                        equipmentType != "3" &&
                        equipmentType != "4" &&
                        equipmentType != "5")
                    {
                        ErrorMessage("Incorrect hardware type.");
                        break;
                    }
    
                    Separator();
                    Console.Write("Enter the brand: ");
                    string brand = Console.ReadLine() ?? "";

                    Separator();
                    Console.Write("Enter the model: ");
                    string model = Console.ReadLine() ?? "";

                    Separator();
                    Console.Write("Provide a price (zł): ");
                    decimal price = decimal.Parse(Console.ReadLine());

                    if (equipmentType == "1")
                    {
                        Separator();
                        Console.Write("Disk (GB): ");
                        int disk = int.Parse(Console.ReadLine());

                        Separator();
                        Console.Write("RAM (GB): ");
                        int ram = int.Parse(Console.ReadLine());

                        Separator();
                        Console.Write("Processor: ");
                        string processor = Console.ReadLine();

                        Separator();
                        Console.WriteLine("Operating system:");
                        Console.WriteLine("1. Windows");
                        Console.WriteLine("2. Linux");
                        Console.WriteLine("3. MacOS");
                        Console.Write("Choose: ");
                        string osChoice = Console.ReadLine();

                        OS system = OS.Windows;
                        switch (osChoice)
                        {
                            case "1":
                                system = OS.Windows;
                                break;
                            case "2":
                                system = OS.Linux;
                                break;
                            case "3":
                                system = OS.MacOS;
                                break;
                            default:
                                Separator();
                                ErrorMessage("Incorrect operating system selection.");
                                break;
                        }

                        if (osChoice != "1" && osChoice != "2" && osChoice != "3")
                            break;

                        Laptop laptop = new Laptop(brand, model, disk, ram, processor, system, price);
                        equipmentService.AddEquipment(laptop);
                        Separator();
                        SuccessMessage("Laptop added.");
                    }
                    else if (equipmentType == "2")
                    {
                        Separator();
                        Console.WriteLine("Brightness:");
                        int brightness = int.Parse(Console.ReadLine());

                        Separator();
                        Console.WriteLine("Resolution:");
                        string resolution = Console.ReadLine() ?? "";

                        Separator();
                        Console.WriteLine("Contrast:");
                        int contrastRatio = int.Parse(Console.ReadLine() ?? "0");

                        Projector projector = new Projector(brand, model, brightness, resolution, contrastRatio, price);
                        equipmentService.AddEquipment(projector);

                        Separator();
                        SuccessMessage("Projector added.");
                    }
                    else if (equipmentType == "3")
                    {
                        Separator();
                        Console.WriteLine("Resolution:");
                        string resolution = Console.ReadLine() ?? "";

                        Separator();
                        Console.WriteLine("Optical zoom:");
                        int opticalZoom = int.Parse(Console.ReadLine() ?? "0");

                        Separator();
                        Console.WriteLine("Frame rate:");
                        int frameRate = int.Parse(Console.ReadLine() ?? "0");

                        Camera camera = new Camera(brand, model, resolution, opticalZoom, frameRate, price);
                        equipmentService.AddEquipment(camera);

                        Separator();
                        SuccessMessage("Camera added.");
                    }
                    else if (equipmentType == "4")
                    {
                        Separator();
                        Console.Write("Size  (cale): ");
                        int screensize = int.Parse(Console.ReadLine());

                        Separator();
                        Console.Write("Resolution: ");
                        string resolution = Console.ReadLine();

                        Separator();
                        Console.Write("Refreshing Rate (Hz): ");
                        int refreshRate = int.Parse(Console.ReadLine());

                        Separator();
                        Console.Write("Panel Type: ");
                        string panelType = Console.ReadLine();

                        VideoMonitor monitor = new VideoMonitor(brand, model, screensize, resolution, refreshRate, panelType, price);
                        equipmentService.AddEquipment(monitor);

                        Separator();
                        SuccessMessage("Monitor added.");
                    }
                    else if (equipmentType == "5")
                    {
                        Separator();
                        Console.WriteLine("WiFi standard:");
                        string wifiStandard = Console.ReadLine() ?? "";

                        Separator();
                        Console.WriteLine("Max speed (MB):");
                        int maxSpeed = int.Parse(Console.ReadLine() ?? "0");

                        Separator();
                        Console.WriteLine("Number of ports:");
                        int numberOfPorts = int.Parse(Console.ReadLine() ?? "0");

                        Router router = new Router(brand, model, wifiStandard, maxSpeed, numberOfPorts, price);
                        equipmentService.AddEquipment(router);

                        Separator();
                        SuccessMessage("Router added.");
                    }
                    else
                    {
                        Separator();
                        ErrorMessage("Nieprawidłowy typ sprzętu.");
                    }
                    break;

                case "3":
                    Separator();
                    Console.WriteLine("\n--- RENT EQUIPMENT ---");

                    Separator();
                    Console.Write("Enter user ID: ");
                    int userId = int.Parse(Console.ReadLine());

                    Separator();
                    Console.Write("Enter the hardware ID: ");
                    int equipmentId = int.Parse(Console.ReadLine());

                    Separator();
                    Console.Write("For how many days? ");
                    int days = int.Parse(Console.ReadLine());

                    User user = userService.GetAllUsers().First(u => u.Id == userId);
                    Equipment equipment = equipmentService.GetAllEquipments().First(e => e.Id == equipmentId);

                    try
                    {
                        rentalService.RentEquipment(user, equipment, days);
                        Separator();
                        SuccessMessage("The equipment was rented.");
                    }
                    catch (Exception ex)
                    {
                        Separator();
                        ErrorMessage($"error: {ex.Message}");
                    }
                    break;

                case "4":
                    Separator();
                    Console.WriteLine("\n--- RETURN OF EQUIPMENT ---");

                    Separator();
                    Console.Write("Enter user ID: ");
                    int returnUserId = int.Parse(Console.ReadLine() ?? "0");

                    Separator();
                    Console.Write("Enter the hardware ID: ");
                    int returnEquipmentId = int.Parse(Console.ReadLine() ?? "0");

                    User returnUser = userService.GetAllUsers().First(u => u.Id == returnUserId);
                    Equipment returnEquipment = equipmentService.GetAllEquipments().First(e => e.Id == returnEquipmentId);

                    try
                    {
                        rentalService.ReturnEquipment(returnUser, returnEquipment);
                        Separator();
                        SuccessMessage("Refund completed.");
                    }
                    catch (Exception ex)
                    {
                        Separator();
                        ErrorMessage($"Error: {ex.Message}");
                    }
                    break;

                case "5":
                    Separator();
                    Console.WriteLine("\n--- REPORT ---");
                    Console.WriteLine(reportService.GenerateReport());

                    break;

                case "0":
                    running = false;
                    Separator();
                    SuccessMessage("Program closed.");
                    break;

                default:
                    Separator();
                    ErrorMessage("Invalid option");
                    break;
            }
        }
    }
}