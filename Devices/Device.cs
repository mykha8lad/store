namespace Store.Devices;

public abstract class Device
{
    protected string? _series;
    protected string? _manufacturer;
    protected string? _model;
    protected int _quantity;
    protected double _price;
    protected string? _color;

    public string Series
    {
        get => _series;
        set
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value)) { throw new NullReferenceException(); }
            _series = value;
        }
    }
    public string Manufacturer
    {
        get => _manufacturer;
        set
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value)) { throw new NullReferenceException(); }
            _manufacturer = value;
        }
    }
    public string Model
    {
        get => _model;
        set
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value)) { throw new NullReferenceException(); }
            _model = value;
        }
    }
    public int Quantity
    {
        get => _quantity;
        set
        {
            if (value < 0) { throw new ArgumentOutOfRangeException(); }
            _quantity = value;
        }
    }
    public double Price
    {
        get => _price;
        set
        {
            if (value < 0) { throw new ArgumentOutOfRangeException(); }
            _price = value;
        }
    }
    public string Color
    {
        get => _color;
        set
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value)) { throw new NullReferenceException(); }
            _color = value;
        }
    }

    protected Device(string manufacturer, string model, int quantity, double price, string color)
    {
        Manufacturer = manufacturer;
        Model = model;
        Quantity = quantity;
        Price = price;
        Color = color;
        GenerateSeries();
    }

    public abstract void DisplayInfo(int y);
    void GenerateSeries()
    {
        Random rnd = new();
        for (int s = 1; s <= 8; ++s)
        {
            Series += (char)rnd.Next(65, 90);
            if (s == 5)
            {
                for (int n = 1; n <= 3; ++n)
                {
                    Series += Convert.ToString(rnd.Next(0, 9));
                }
            }
        }
        Series = Series.ToUpper();
    }

    public void DisplayContainer(string baseInfo, string anotherInfo, int y)
    {
        string horizontal = "─";
        string vertical = "│";
        string ul_corner = "┌";
        string ur_corner = "┐";
        string ll_corner = "└";
        string lr_corner = "┘";

        Console.SetCursorPosition(0, y);
        Console.Write(ul_corner);
        Console.SetCursorPosition(70, y);
        Console.Write(ur_corner);
        Console.SetCursorPosition(0, y + 10);
        Console.Write(ll_corner);
        Console.SetCursorPosition(70, y + 10);
        Console.Write(lr_corner);
        Console.SetCursorPosition(1, y);
        Console.Write(string.Concat(Enumerable.Repeat(horizontal, 69)));
        Console.SetCursorPosition(1, y + 10);
        Console.Write(string.Concat(Enumerable.Repeat(horizontal, 69)));
        Console.SetCursorPosition(71, y + 1);
        Console.Write($"({Series})");

        var baseInfoByLine = baseInfo.Split('\n');
        var anotherInfoByLine = anotherInfo.Split('\n');

        for (int i = y; i < y + 9; i++)
        {
            Console.SetCursorPosition(0, i + 1);
            Console.Write(vertical);
            Console.SetCursorPosition(70, i + 1);
            Console.Write(vertical);
        }
        for (int i = 1; i < baseInfoByLine.Length; ++i, ++y)
        {
            Console.SetCursorPosition(2, y + 1);
            Console.Write(baseInfoByLine[i]);
            if (i == baseInfoByLine.Length - 1)
            {
                Console.SetCursorPosition(1, y);
                Console.Write(string.Concat(Enumerable.Repeat(horizontal, 69)));
            }
        }
        for (int i = baseInfoByLine.Length, k = 1; i < anotherInfoByLine.Length + baseInfoByLine.Length; ++i, ++k, ++y)
        {
            Console.SetCursorPosition(2, y);
            Console.WriteLine(anotherInfoByLine[k]);
            if (k == 2)
                break;
        }

        Console.WriteLine('\n');
    }
}
