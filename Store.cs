using Store.Devices;
using Store.StrategyPattern;
using Store.StrategyPattern.FindDevice;
using Store.StrategyPattern.RemoveDevice;

namespace Store;

public class Store
{
    private IRemoveStrategy? _removeStrategy;
    private IFindStrategy? _findStrategy;
    List<Device>? _devices;

    public IRemoveStrategy RemoveStrategy
    {
        get => _removeStrategy;
        set => _removeStrategy = value;
    }
    public IFindStrategy FindStrategy
    {
        get => _findStrategy;
        set => _findStrategy = value;
    }
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
    public void DeleteDevice(string key)
    {
        Console.Clear();
        List<Device> _result = GetResultListForRemove(key);
        try
        {
            _removeStrategy.RemoveAlgorithm(_result, this);
        }
        catch
        {
            Console.WriteLine("There are no devices matching the search criteria");
        }
        DisplayStore(3);
    }
    public void FindDevice(string key)
    {
        List<Device> _result = GetResultListForFind(key);
        try
        {
            _findStrategy?.FindAlgorithm(_result);
        }
        catch
        {
            Console.WriteLine("There are no devices matching the search criteria");
        }
    }
    public void DisplayStore(int height = 0)
    {
        for (int i = 0; i < Devices.Count; ++i)
        {
            Devices[i].DisplayInfo(height);
            height += 11;
        }
    }

    // Interoperable Methods for the Strategy Pattern 
    void SetStrategy(IRemoveStrategy removeStrategy) => RemoveStrategy = removeStrategy;
    void SetStrategy(IFindStrategy findStrategy) => FindStrategy = findStrategy;
    List<Device> GetResultListForRemove(string key)
    {
        List<Device> _result = new List<Device>();

        List<Device> _resultManufacturers = Devices.FindAll(device => device.Manufacturer == key);
        List<Device> _resultModels = Devices.FindAll(device => device.Model == key);
        List<Device> _resultSeries = Devices.FindAll(device => device.Series == key);

        if (_resultManufacturers.Count != 0)
        {
            SetStrategy(new RemoveManufacturer());
            _result = _resultManufacturers;
        }
        if (_resultModels.Count != 0)
        {
            SetStrategy(new RemoveModel());
            _result = _resultModels;
        }
        if (_resultSeries.Count != 0)
        {
            SetStrategy(new RemoveSeries());
            _result = _resultSeries;
        }

        return _result;
    }
    List<Device> GetResultListForFind(string key)
    {
        List<Device> _result = new List<Device>();

        List<Device> _resultManufacturers = Devices.FindAll(device => device.Manufacturer == key);
        List<Device> _resultModels = Devices.FindAll(device => device.Model == key);
        List<Device> _resultSeries = Devices.FindAll(device => device.Series == key);

        if (_resultManufacturers.Count != 0)
        {
            SetStrategy(new FindManufacturer());
            _result = _resultManufacturers;
        }
        if (_resultModels.Count != 0)
        {
            SetStrategy(new FindModel());
            _result = _resultModels;
        }
        if (_resultSeries.Count != 0)
        {
            SetStrategy(new FindSeries());
            _result = _resultSeries;
        }

        return _result;
    }

    public string GetListDevices() { return string.Join("\n", Devices); }
    public override string ToString() => $"{GetListDevices()}\n";
}