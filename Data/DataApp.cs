using APBD_Cw1_s30650.Models.Users;
using APBD_Cw1_s30650.Models.Equipments;
using APBD_Cw1_s30650.Models.Rentals;

namespace APBD_Cw1_s30650.Data;

public class DataApp
{
    public List<User> Users { get; set; }
    public List<Equipment> Equipments { get; set; }
    public List<Rental> Rentals { get; set; }
}