using Store.Devices;

namespace Store.StrategyPattern.RemoveDevice;

public class RemoveSeries : IRemoveStrategy
{
    public void RemoveAlgorithm(List<Device> result, Store store)
    {        
        foreach (Device device in result)
        {
            Console.WriteLine($"Found {device.Quantity} device(s):");
            Console.WriteLine($"{device.Manufacturer} {device.Model} {device.Color} - {device.Price}");
            store.Devices.Remove(device);
            Console.WriteLine("Deleting Series");
        }
    }
}
