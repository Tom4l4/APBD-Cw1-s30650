using APBD_Cw1_s30650.Models.Users;

namespace APBD_Cw1_s30650.Services;

public class UserService
{
    private List<User> users = new();

    public void AddUser(User user)
    {
        users.Add(user);
    }

    public List<User> GetAllUsers()
    {
        return users;
    }
}