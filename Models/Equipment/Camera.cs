namespace APBD_Cw1_s30650.Models.Equipment;

public class Camera(string brand, string model, string resolution, int opticalZoom, int frameRate, decimal price) : Equipment(brand, model, price)
{
    public string Resolution { get; } = resolution;
    public int OpticalZoom { get; } = opticalZoom;
    public int FrameRate { get; } = frameRate;
}