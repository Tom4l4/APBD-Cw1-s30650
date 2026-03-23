using APBD_Cw1_s30650.Enums;
using APBD_Cw1_s30650.Exceptions;
using APBD_Cw1_s30650.Models.Equipments;

namespace APBD_Cw1_s30650.Services;

public class EquipmentService
{
    private List<Equipment> equipments = new();

    public void AddEquipment(Equipment equipment)
    {
        equipments.Add(equipment);
    }

    public List<Equipment> GetAllEquipments()
    {
        return equipments;
    }

    public List<Equipment> GetAvailableEquipments()
    {
        return equipments.Where(e => e.Status == EquipmentStatus.Available).ToList();
    }

    public void SetEquipmentStatus(int equipmentId, EquipmentStatus status)
    {
        Equipment equipment = equipments.FirstOrDefault(e => e.Id == equipmentId);

        if (equipment == null)
        {
            throw new EquipmentNotFoundException(equipmentId);
        }

        equipment.Status = status;
    }
}