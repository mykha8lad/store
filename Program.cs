using Store.Devices;

namespace Store;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Store";
        Tablet tablet = new("Apple", "iPad 2021", 13, 16.999, "Space Gray", "Apple iPad 10.2 2021 Space Gray", "iPadOS", 10.2);
        Laptop laptop = new("Xiaomi", "Pro 14", 30, 29.999, "Silver", "Xiaomi Laptop Pro 14 Silver", "Intel Core i5-11320H", 16);
        MobilePhone mobilePhone = new("Samsung", "Galaxy M33", 19, 8.499, "Green", "Samsung Galaxy M33 5G 6/128GB Green", "TFT", 128);

        Store store = new();

        store.AddDeviceInStore(tablet);
        store.AddDeviceInStore(laptop);
        store.AddDeviceInStore(mobilePhone);

        store.DisplayStore();

        Console.WriteLine("Enter series key for remove device from this list");
        string key = Console.ReadLine();
        store.DeleteDevice(key);

        store.DisplayStore();

        Console.WriteLine("Enter series key for remove device from this list");
        key = Console.ReadLine();
        store.FindDevice(key);
        Console.Read();
    }
}