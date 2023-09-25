
using System;

abstract class Storage
{
    public string name;
    public string model;

    public Storage(string name, string model)
    {
        this.name = name;
        this.model = model;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string Model
    {
        get { return model; }
        set { model = value; }
    }

    public abstract double GetStorageCapacity();

    public abstract void CopyData();

    public abstract double GetAvailableStorage();

    public abstract string GetDeviceInfo();
}


