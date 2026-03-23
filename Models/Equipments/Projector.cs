namespace APBD_Cw1_s30650.Models.Equipments;

public class Projector(string brand, string model, int brightness, string resolution, int contrastRatio, decimal price) : Equipment(brand, model, price)
{
    public int Brightness { get; } = brightness;
    public string Resolution { get; } = resolution;
    public int ContrastRatio { get; } = contrastRatio;
}