using Store.Devices;

namespace Store.ConcreteDeviceCreators
{
    internal class TabletCreator : Shop
    {
        public override Device CreateDevice()
        {
            return new Laptop();
        }
    }
}
