using APBD_Cw1_s30650.Models.Users;
using APBD_Cw1_s30650.Models.Equipments;

namespace APBD_Cw1_s30650.Models.Rentals;

public class Rental(User user, Equipment equipment, DateTime startDate, DateTime endDate)
{
    public User User { get; } = user;
    public Equipment Equipment { get; } = equipment;
    public DateTime StartDate { get; } = startDate;
    public DateTime EndDate { get; } = endDate;
    public DateTime? ReturnDate { get; set; }
    public decimal Penalty { get; set; }
}