using APBD_Cw1_s30650.Enums;

namespace APBD_Cw1_s30650.Models.Users;

public abstract class User(string firstName, string lastName)
{
    private static int _nextId = 1;

    public int Id { get; } = _nextId++;
    public string FirstName { get; } = firstName;
    public string LastName { get; } = lastName;
}