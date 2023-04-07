using Store.Devices;

namespace Store.StrategyPattern.FindDevice;

public interface IFindStrategy
{
    void FindAlgorithm(List<Device> result);
}
