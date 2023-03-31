namespace Store.Devices
{
    internal class MobilePhone : Device
    {
        private string nameMobilePhone;
        protected string networkType;
        protected int storageCapacity;   
        
        public string NameMobilePhone
        {
            get { return nameMobilePhone; }
            set
            {
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value)) { throw new Exception(); }
                nameMobilePhone = value;
            }
        }        
        public string NetworkType
        {
            get { return networkType; }
            set
            {
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value)) { throw new Exception(); }
                networkType = value;
            }
        }
        public int StorageCapacity
        {
            get { return storageCapacity; }
            set
            {
                if (value < 0) { throw new Exception(); }
                storageCapacity = value;
            }
        }

        public MobilePhone(string manufacturer, string model, int quantity, double price, string color, string nameMobilePhone, string networkType, int storageCapacity)
            : base(manufacturer, model, quantity, price, color)
        {
            NameMobilePhone = nameMobilePhone;
            NetworkType = networkType;
            StorageCapacity = storageCapacity;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Tablet \"{NameMobilePhone}\"\n" + $"Manufacturer: {Manufacturer}\n" + $"Model: {Model}\n" + $"Quantity: {Quantity}\n" + $"Price: {Price}\n" + $"Color: {Color}\n" + $"Network type: {NetworkType}\n" + $"Storage capacity: {StorageCapacity}\n" + $"");
        }
    }
}
