namespace APBD_Cw1_s30650.Models.Equipment;

public class Laptop(string brand, string model, int diskspace, int memory, string processor, OperatingSystem system ,decimal price) : Equipment(brand, model, price)
{
    public int DiskSpace { get; set; } = diskspace;
    public int Memory { get; set; } = memory;
    public string Processor { get; set; } = processor;
    public OperatingSystem System { get; set; } = system;
}