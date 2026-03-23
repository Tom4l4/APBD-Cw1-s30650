namespace APBD_Cw1_s30650.Exceptions;

public class TooManyRentalsException(int userId) : Exception($"User with id {userId} has reached rental limit");
