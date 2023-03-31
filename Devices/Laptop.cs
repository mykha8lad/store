namespace Store.Devices
{
    internal class Laptop : Device
    {        
        private string nameLaptop;
        protected string processorType;
        protected int ramSize;

        public string NameLaptop
        {
            get { return nameLaptop; }
            set
            {
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value)) { throw new Exception(); }
                nameLaptop = value;
            }
        }
        public string ProcessorType
        {
            get { return processorType; }
            set
            {
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value)) { throw new Exception(); }
                processorType = value;
            }
        }
        public int RamSize
        {
            get { return ramSize; }
            set
            {
                if (value < 0) { throw new Exception(); }
                ramSize = value;
            }
        }

        public Laptop(string manufacturer, string model, int quantity, double price, string color, string nameLaptop, string processorType, int ramSize)
            : base(manufacturer, model, quantity, price, color)
        {
            NameLaptop = nameLaptop;
            ProcessorType = processorType;
            RamSize = ramSize;
        }        
        public Laptop() : base("None", "None", 0, 0, "None")
        {
            NameLaptop = "None";
            ProcessorType = "None";
            RamSize = 0;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Tablet \"{NameLaptop}\"\n" + $"Manufacturer: {Manufacturer}\n" + $"Model: {Model}\n" + $"Quantity: {Quantity}\n" + $"Price: {Price}\n" + $"Color: {Color}\n" + $"Processor type: {ProcessorType}\n" + $"Ram size: {RamSize}\n" + $"");
        }
    }
}
