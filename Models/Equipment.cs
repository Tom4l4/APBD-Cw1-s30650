namespace APBD_Cw1_s30650.Models;

public class Equipment
{
    private static int _nextId = 1;

    public int Id { get; } = _nextId++;
    public string Brand { get; set; } = brand;
    public string Model { get; set; } = model;
    public  Status { get; set; } = status;
    
}