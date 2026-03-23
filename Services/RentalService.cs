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
    }
    
}

