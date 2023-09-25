using System;

class HDD : Storage
{
    public double totalCapacity;
    public double usbSpeed;
    public int partitionCount;
    double isOccupied;
    public double[] partitionSizes;

    public HDD(string name, string model, double totalCapacity, double usbSpeed, int partitionCount,double isOccupied, double[] partitionSizes)
        : base(name, model)
    {
        this.totalCapacity = totalCapacity;
        this.usbSpeed = usbSpeed;
        this.partitionCount = partitionCount;
        this.partitionSizes = partitionSizes;
        this.isOccupied = isOccupied;
    }

    public override double GetStorageCapacity() => totalCapacity;

    public override void CopyData()
    {
        Console.WriteLine($"Copying data to HDD at USB {usbSpeed} speed.");
    }

    public override double GetAvailableStorage()
    {
    
        return totalCapacity - isOccupied;
    }

    public override string GetDeviceInfo()
    {
        string partitions = string.Join(", ", partitionSizes);
        return $"HDD Drive - Name: {Name}, Model: {Model}, Total Capacity: {totalCapacity} GB, USB Speed: USB {usbSpeed}, Partition Count: {partitionCount}, Partition Sizes: {partitions}";
    }
}