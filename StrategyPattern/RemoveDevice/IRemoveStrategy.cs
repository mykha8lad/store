using Store.Devices;

namespace Store.StrategyPattern.RemoveDevice;

public interface IRemoveStrategy
{
    void RemoveAlgorithm(List<Device> result, Store store);
}

