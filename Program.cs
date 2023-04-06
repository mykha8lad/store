using Store.Devices;

namespace Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tablet tablet = new Tablet("Apple", "iPad 2021", 13, 16.999, "Space Gray", "Apple iPad 10.2 2021 Space Gray", "iPadOS", 10.2);
            Laptop laptop = new Laptop("Xiaomi", "Pro 14", 30, 29.999, "Silver", "Xiaomi Laptop Pro 14 Silver", "Intel Core i5-11320H", 16);
            MobilePhone mobilePhone = new MobilePhone("Samsung", "Galaxy M33", 19, 8.499, "Green", "Samsung Galaxy M33 5G 6/128GB Green", "TFT", 128);

            Store store = new Store();

            store.AddDeviceInStore(tablet);
            store.AddDeviceInStore(laptop);
            store.AddDeviceInStore(mobilePhone);

            store.DisplayStore();

            /*string series = Console.ReadLine();
            store.DeleteDevice(series);

            Console.Clear();
            store.DisplayStore();*/
        }
    }
}