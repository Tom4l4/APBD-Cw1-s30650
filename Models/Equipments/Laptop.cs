using APBD_Cw1_s30650.Enums;

namespace APBD_Cw1_s30650.Models.Equipments;

public class Laptop(string brand, string model, int diskSpace, int memory, string processor, OS system ,decimal price) : Equipment(brand, model, price)
{
    public int DiskSpace { get; set; } = diskSpace;
    public int Memory { get; set; } = memory;
    public string Processor { get; set; } = processor;
    public OS System { get; set; } = system;
}