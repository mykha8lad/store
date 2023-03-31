namespace Store.Devices
{
    internal class Tablet : Device
    {
        private string nameTablet;
        protected string operatingSystem;
        protected double screenSize;

        public string NameTablet
        {
            get { return nameTablet; }
            set
            {
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value)) { throw new Exception(); }
                nameTablet = value;                
            }
        }
        public string OperatingSystem
        {
            get { return operatingSystem; }
            set
            {
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value)) { throw new Exception(); }
                operatingSystem = value;
            }
        }
        public double ScreenSize
        {
            get { return screenSize; }
            set
            {
                if (value < 0) { throw new Exception(); }
                screenSize = value;
            }
        }

        public Tablet(string manufacturer, string model, int quantity, double price, string color, string nameTablet, string operatingSystem, double screenSize)
            : base(manufacturer, model, quantity, price, color)
        {
            NameTablet = nameTablet;
            OperatingSystem = operatingSystem;
            ScreenSize = screenSize;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Tablet \"{NameTablet}\"\n" + $"Manufacturer: {Manufacturer}\n" + $"Model: {Model}\n" + $"Quantity: {Quantity}\n" + $"Price: {Price}\n" + $"Color: {Color}\n" + $"Operating system: {OperatingSystem}\n" + $"Screen size: {ScreenSize}\n" + $"");
        }        
    }   
}
