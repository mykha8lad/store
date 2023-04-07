namespace Store.Devices;

public class MobilePhone : Device
{
    protected string? _nameMobilePhone;
    protected string? _networkType;
    protected int _storageCapacity;

    public string NameMobilePhone
    {
        get => _nameMobilePhone;
        set
        {
            if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value)) { throw new NullReferenceException(); }
            _nameMobilePhone = value;
        }
    }
    public string NetworkType
    {
        get => _networkType;
        set
        {
            if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value)) { throw new NullReferenceException(); }
            _networkType = value;
        }
    }
    public int StorageCapacity
    {
        get => _storageCapacity;
        set
        {
            if (value < 0) { throw new ArgumentOutOfRangeException(); }
            _storageCapacity = value;
        }
    }

    public MobilePhone(string manufacturer, string model, int quantity, double price, string color, string nameMobilePhone, string networkType, int storageCapacity)
        : base(manufacturer, model, quantity, price, color)
    {
        NameMobilePhone = nameMobilePhone;
        NetworkType = networkType;
        StorageCapacity = storageCapacity;
    }
    public MobilePhone() : base("MobilePhone Manufacturer", "MobilePhone model", 0, 0, "MobilePhone color")
    {
        NameMobilePhone = "MobilePhone";
        NetworkType = "MobilePhone NetworkType";
        StorageCapacity = 0;
        Series = "None";
    }

    public override void DisplayInfo(int y)
    {
        string baseInfo = $"\nMobile phone <{NameMobilePhone}>\nManufacturer: {Manufacturer}\nModel: {Model}\nQuantity: {Quantity}\nPrice: {Price}\nColor: {Color}\n";
        string anotherInfo = $"\nNetwork type: {NetworkType}\nStorage capacity: {StorageCapacity + y}\n";

        DisplayContainer(baseInfo, anotherInfo, y);
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Mobile phone\n{NameMobilePhone}\n{Manufacturer}\n{Model}\n{Quantity}\n{Price}\n{Color}\n{NetworkType}\n{StorageCapacity}\n");
    }
    public override string ToString()
    {
        return $"{NameMobilePhone}\n{Manufacturer}\n{Model}\n{Quantity}\n{Price}\n{Color}\n{NetworkType}\n{StorageCapacity}\n";
    }
}