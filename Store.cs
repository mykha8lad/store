using Store.Devices;
using System.Diagnostics;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace Store;

internal class Store
{
    List<Device> _devices;
    public List<Device> Devices
    {
        get => _devices;
        set
        {
            if (value == null) { throw new NullReferenceException(); }
            _devices = value;
        }
    }

    public Store()
    {
        Devices = new List<Device>();
    }

    public void AddDeviceInStore(Device device)
    {
        if (device == null) { throw new NullReferenceException(); }
        Devices.Add(device);
        Console.Clear();
    }
    public void DeleteDevice(string series)
    {
        if (String.IsNullOrEmpty(series) || String.IsNullOrWhiteSpace(series)) { throw new NullReferenceException(); }

        List<Device> resultDevices = Devices.FindAll(device => device.Series == series);
        if (resultDevices.Count == 0) { Console.WriteLine("There are no devices matching the search criteria"); }
        else
        {
            foreach (var device in resultDevices)
            {
                Console.WriteLine($"Found {device.Quantity} device(s):");
                Console.WriteLine($"{device.Manufacturer} {device.Model} {device.Color} - {device.Price}");
                Devices.Remove(device);
                Console.WriteLine("Delete...");
            }
        }
        Console.Clear();
    }
    public void DisplayStore()
    {
        int height = 0;
        for (int i = 0; i < Devices.Count; ++i)
        {
            Devices[i].DisplayInfo(height);
            height += 11;
        }
    }
    public void FindDevice(string series)
    {
        if (String.IsNullOrEmpty(series) || String.IsNullOrWhiteSpace(series)) { throw new NullReferenceException(); }

        List<Device> resultDevices = Devices.FindAll(device => device.Series == series);
        if (resultDevices.Count == 0) { Console.WriteLine("There are no devices matching the search criteria"); }
        else
        {
            foreach (var device in resultDevices)
            {
                Console.WriteLine($"Found {device.Quantity} device(s):");
                Console.WriteLine($"{device.Manufacturer} {device.Model} {device.Color} - {device.Price}");
            }
        }
    }

    public Device this[string series]
    {
        get => Devices.Find(device => device.Series == series);
        set
        {
            if (String.IsNullOrEmpty(series) || String.IsNullOrWhiteSpace(series)) { throw new Exception(); }
            int index = Devices.FindIndex(device => device.Series == series);
            if (index != -1)
            {
                if (value == null) { throw new NullReferenceException(); }
                Devices[index] = value;
            }
            else
            {
                if (value == null) { throw new NullReferenceException(); }
                Devices.Add(value);
            }
        }
    }

    public string GetListDevices() { return string.Join("\n", Devices); }
    public override string ToString() => $"{GetListDevices()}\n";    
}