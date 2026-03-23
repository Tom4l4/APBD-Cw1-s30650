namespace APBD_Cw1_s30650.Exceptions;

public class EquipmentNotAvailableException(int equimpentId) : Exception($"Equipment with id {equimpentId} is not available");
