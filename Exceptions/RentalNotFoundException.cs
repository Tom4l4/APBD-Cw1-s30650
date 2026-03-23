namespace APBD_Cw1_s30650.Exceptions;

public class RentalNotFoundException(int userId, int equipmentId) : Exception($"Rental not found for user {userId} and equipment {equipmentId}");