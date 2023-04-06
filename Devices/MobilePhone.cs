namespace Store.Devices
{
    internal class MobilePhone : Device
    {
        protected string nameMobilePhone;
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
}
