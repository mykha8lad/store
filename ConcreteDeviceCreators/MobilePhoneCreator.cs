using Store.Devices;

namespace Store.ConcreteDeviceCreators
{
    internal class MobilePhoneCreator : Shop
    {
        public override Device CreateDevice()
        {
            return new Laptop();
        }
    }
}
