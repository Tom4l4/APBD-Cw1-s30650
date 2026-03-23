namespace APBD_Cw1_s30650.Models.Equipment;

public class Laptop(string brand, string model, int diskSpace, int memory, string processor, OperatingSystem system ,decimal price) : Equipment(brand, model, price)
{
    public int DiskSpace { get; set; } = diskSpace;
    public int Memory { get; set; } = memory;
    public string Processor { get; set; } = processor;
    public OperatingSystem System { get; set; } = system;
}