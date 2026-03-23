namespace APBD_Cw1_s30650.Models.Equipment;

public class Rotuer(string brand, string model, string wifiStandard, int maxSpeed, int numberPorts, decimal price) : Equipment(brand, model, price)
{
    public string WifiStandard { get; } = wifiStandard;
    public int MaxSpeed { get; } = maxSpeed;
    public int NumberPorts { get; } = numberPorts;
}