using System.Diagnostics;
using System.Xml;

namespace Store.Devices
{
    internal class Laptop : Device
    {
        protected string nameLaptop;
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
        public Laptop() : base("Laptop Manufacturer", "Laptop model", 0, 0, "Laptop color")
        {
            NameLaptop = "Laptop";
            ProcessorType = "Laptop ProcessorType";
            RamSize = 0;
            Series = "None";
        }

        public override void DisplayInfo(int y)
        {
            string baseInfo = $"\nLaptop <{NameLaptop}>\nManufacturer: {Manufacturer}\nModel: {Model}\nQuantity: {Quantity}\nPrice: {Price}\nColor: {Color}\n";
            string anotherInfo = $"\nProcessor type: {ProcessorType}\nRam size: {RamSize}\n";

            DisplayContainer(baseInfo, anotherInfo, y);
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Laptop\n{NameLaptop}\n{Manufacturer}\n{Model}\n{Quantity}\n{Price}\n{Color}\n{ProcessorType}\n{RamSize}\n");
        }
        public override string ToString()
        {
            return $"Laptop\n{NameLaptop}\n{Manufacturer}\n{Model}\n{Quantity}\n{Price}\n{Color}\n{ProcessorType}\n{RamSize}\n";
        }
    }
}
