using APBD_Cw1_s30650.Models.Rentals;
using APBD_Cw1_s30650.Models.Users;
using APBD_Cw1_s30650.Models.Equipments;
using APBD_Cw1_s30650.Enums;
using APBD_Cw1_s30650.Exceptions;

namespace APBD_Cw1_s30650.Services;

public class RentalService
{
    private List<Rental> rentals = new();
    
    public void RentEquipment(User user, Equipment equipment, int days)
    {
        if (equipment.Status != EquipmentStatus.Available)
        {
            throw new EquipmentNotAvailableException(equipment.Id);
        }
        
        int activeRentals = rentals.Count(r => r.User == user && r.ReturnDate == null);
        int limit = user is Student ? 2 : 5;
        
        if (activeRentals >= limit)
        {
            throw new TooManyRentalsException(user.Id);
        }

        Rental rental = new Rental(user, equipment, DateTime.Now, DateTime.Now.AddDays(days));
        rentals.Add(rental);
        equipment.Status = EquipmentStatus.Borrowed;
    }

    public void ReturnEquipment(User user, Equipment equipment)
    {
        Rental rental = rentals.FirstOrDefault(r => r.User == user && r.Equipment == equipment && r.ReturnDate == null);

        if (rental == null)
        {
            throw new RentalNotFoundException(user.Id, equipment.Id);
        }
        
        rental.ReturnDate = DateTime.Now;
        equipment.Status = EquipmentStatus.Available;

        if (rental.ReturnDate > rental.EndDate)
        {
            int lateDays = (rental.ReturnDate.Value - rental.EndDate).Days;
            rental.Penalty = lateDays * 10m;
        }
    }

    public List<Rental> GetActiveRentals(User user)
    {
        return rentals.Where(r => r.User == user && r.ReturnDate == null).ToList();
    }

    public List<Rental> GetOverdueRentals(User user)
    {
        return rentals.Where(r => r.User == user && r.ReturnDate == null && r.EndDate < DateTime.Now).ToList();
    }
}

