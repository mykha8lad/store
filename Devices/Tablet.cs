namespace Store.Devices;

public class Tablet : Device
{
    protected string? _nameTablet;
    protected string? _operatingSystem;
    protected double _screenSize;

    public string NameTablet
    {
        get => _nameTablet;
        set
        {
            if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value)) { throw new NullReferenceException(); }
            _nameTablet = value;
        }
    }
    public string OperatingSystem
    {
        get => _operatingSystem;
        set
        {
            if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value)) { throw new NullReferenceException(); }
            _operatingSystem = value;
        }
    }
    public double ScreenSize
    {
        get => _screenSize;
        set
        {
            if (value < 0) { throw new ArgumentOutOfRangeException(); }
            _screenSize = value;
        }
    }

    public Tablet(string manufacturer, string model, int quantity, double price, string color, string nameTablet, string operatingSystem, double screenSize)
        : base(manufacturer, model, quantity, price, color)
    {
        NameTablet = nameTablet;
        OperatingSystem = operatingSystem;
        ScreenSize = screenSize;
    }
    public Tablet() : base("Tablet Manufacturer", "Tablet model", 0, 0, "Tablet color")
    {
        NameTablet = "Tablet";
        OperatingSystem = "Tablet OperatingSystem";
        ScreenSize = 0;
        Series = "None";
    }

    public override void DisplayInfo(int y)
    {
        string baseInfo = $"\nTablet <{NameTablet}>\nManufacturer: {Manufacturer}\nModel: {Model}\nQuantity: {Quantity}\nPrice: {Price}\nColor: {Color}\n";
        string anotherInfo = $"\nOperating system: {OperatingSystem}\nScreen size: {ScreenSize}\n";

        DisplayContainer(baseInfo, anotherInfo, y);
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Tablet\n{NameTablet}\n{Manufacturer}\n{Model}\n{Quantity}\n{Price}\n{Color}\n{OperatingSystem}\n{ScreenSize}\n");
    }
    public override string ToString()
    {
        return $"{NameTablet}\n{Manufacturer}\n{Model}\n{Quantity}\n{Price}\n{Color}\n{OperatingSystem}\n{ScreenSize}\n";
    }
}