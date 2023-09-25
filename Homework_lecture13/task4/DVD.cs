
using System;

class DVD : Storage
{
    public double capacity;
    public double readSpeed;
    public double writeSpeed;
    public bool isDoubleLayer;
    public double isOccupied;

    public DVD(string name, string model, double capacity, double readSpeed, double writeSpeed, bool isDoubleLayer, double isOccupied)
        : base(name, model)
    {
        this.capacity = capacity;
        this.readSpeed = readSpeed;
        this.writeSpeed = writeSpeed;
        this.isDoubleLayer = isDoubleLayer;
        this.isOccupied = isOccupied;
    }

    public override double GetStorageCapacity()
    {
        return capacity;
    }

    public override void CopyData()
    {
        Console.WriteLine($"Copying data to DVD{(isDoubleLayer ? " (Double Layer)" : "")} at {writeSpeed}x speed.");
    }

    public override double GetAvailableStorage()
    {
        // You can implement this based on how much data is already written to the DVD.
        return capacity - isOccupied;
    }

    public override string GetDeviceInfo()
    {
        return $"DVD Drive - Name: {Name}, Model: {Model}, Capacity: {capacity} GB, Read Speed: {readSpeed}x, Write Speed: {writeSpeed}x, {(isDoubleLayer ? "Double Layer" : "Single Layer")}";
    }
}