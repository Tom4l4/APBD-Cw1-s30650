namespace APBD_Cw1_s30650.Models.Equipment;

public class Router(string brand, string model, string wifiStandard, int maxSpeed, int numberOfPorts, decimal price) : Equipment(brand, model, price)
{
    public string WifiStandard { get; } = wifiStandard;
    public int MaxSpeed { get; } = maxSpeed;
    public int NumberOfPorts { get; } = numberOfPorts;
}