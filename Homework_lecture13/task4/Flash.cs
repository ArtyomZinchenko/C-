
using System;

class Flash : Storage
{
    public double memorySize;
    public double usbSpeed;
    public double isOccupied;

    public Flash(string name, string model, double memorySize, double usbSpeed, double isOccupied)
        : base(name, model)
    {
        this.memorySize = memorySize;
        this.usbSpeed = usbSpeed;
        this.isOccupied = isOccupied;
    }

    public override double GetStorageCapacity()
    {
        return memorySize;
    }

    public override void CopyData()
    {
        Console.WriteLine($"Copying data to Flash drive at USB {usbSpeed} speed.");
    }

    public override double GetAvailableStorage()
    {
        return memorySize - isOccupied;
    }

    public override string GetDeviceInfo()
    {
        return $"Flash Drive - Name: {Name}, Model: {Model}, Capacity: {memorySize} GB, USB Speed: USB {usbSpeed}";
    }
}

