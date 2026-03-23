using APBD_Cw1_s30650.Enums;

namespace APBD_Cw1_s30650.Models.Equipment;

public abstract class Equipment(string brand, string model, decimal price)
{
    private static int _nextId = 1;

    public int Id { get; } = _nextId++;
    public string Brand { get; } = brand;
    public string Model { get; } = model;
    public decimal Price { get; set; } = price;
    public EquipmentStatus Status { get; set; } = EquipmentStatus.Available;

}