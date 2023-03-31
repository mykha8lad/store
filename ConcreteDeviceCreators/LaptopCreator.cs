using Store.Devices;

namespace Store.ConcreteDeviceCreators
{
    internal class LaptopCreator : Shop
    {
        public override Device CreateDevice()
        {
            return new Laptop();
        }
    }
}
