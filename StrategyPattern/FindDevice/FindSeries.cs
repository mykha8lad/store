using Store.Devices;

namespace Store.StrategyPattern.FindDevice;

public class FindSeries : IFindStrategy
{
    public void FindAlgorithm(List<Device> result)
    {
        foreach (Device device in result)
        {
            Console.WriteLine("Series find...");
            Console.WriteLine($"Found {device.Quantity} device(s):");
            Console.WriteLine($"{device.Manufacturer} {device.Model} - {device.Price}");
        }
    }
}
