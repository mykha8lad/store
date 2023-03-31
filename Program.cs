using Store.ConcreteDeviceCreators;
using Store.Devices;

namespace Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Tablet tablet = new Tablet("Lenovo", "13X", 13, 4.500, "Red", "My tablet", "iOS", 14);
            Laptop laptop = new Laptop("HP", "6.0", 5, 13.200, "Grey", "My laptop", "Intel", 32);
            MobilePhone mobilePhone = new MobilePhone("Iphone", "14 Pro", 32, 42.000, "Green", "My MobilePhone", "Kyivstar", 64);
            tablet.DisplayInfo();
            laptop.DisplayInfo();
            mobilePhone.DisplayInfo();*/

            Client(new LaptopCreator());
        }   

        static void Client(Shop shop)
        {
            var device = shop.CreateDevice();
            device.DisplayInfo();
        }
    }
}