using System.Text.Json;
using APBD_Cw1_s30650.Data;

namespace APBD_Cw1_s30650.Services;

public class DataService
{
    private const string FilePath = "data.json";

    public void Save(
        UserService userService,
        EquipmentService equipmentService,
        RentalService rentalService)
    {
        var data = new DataApp
        {
            Users = userService.GetAllUsers(),
            Equipments = equipmentService.GetAllEquipments(),
            Rentals = rentalService.GetAllRentals()
        };

        string json = JsonSerializer.Serialize(data, new JsonSerializerOptions
        {
            WriteIndented = true
        });

        File.WriteAllText(FilePath, json);
    }
}