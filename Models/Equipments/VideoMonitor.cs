namespace APBD_Cw1_s30650.Models.Equipments;

public class VideoMonitor(string brand, string model, int screenSize, string resolution, int refreshRate, string panelType, decimal price) : Equipment(brand, model, price)
{
    public int ScreenSize { get; } = screenSize;
    public string Resolution { get; } = resolution;
    public int RefreshRate { get; } = refreshRate;
    public string PanelType { get; } = panelType;
}