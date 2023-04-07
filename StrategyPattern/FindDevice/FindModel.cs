using Store.Devices;

namespace Store.StrategyPattern.FindDevice;

public class FindModel : IFindStrategy
{
    public void FindAlgorithm(List<Device> result)
    {
        foreach (Device device in result)
        {
            Console.WriteLine("Model find...");
            Console.WriteLine($"Found {device.Quantity} device(s):");
            Console.WriteLine($"{device.Manufacturer} {device.Model} - {device.Price}");
        }
    }
}
