namespace APBD_Cw1_s30650.Exceptions;

public class EquipmentNotFoundException(int equipmentId) : Exception($"Equipment with id {equipmentId} not found");