namespace Store.Devices
{
    abstract class Device
    {
        protected string manufacturer;
        protected string model;
        protected int quantity;
        protected double price;
        protected string color;

        public string Manufacturer
        {
            get { return manufacturer; }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value)) { throw new Exception(); }
                manufacturer = value;
            }
        }
        public string Model
        {
            get { return model; }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value)) { throw new Exception(); }
                model = value;
            }
        }
        public int Quantity
        {
            get { return quantity; }
            set
            {
                if (quantity < 0) { throw new Exception(); }
                quantity = value;
            }
        }
        public double Price
        {
            get { return price; }
            set
            {
                if (price < 0) { throw new Exception(); }
                price = value;
            }
        }
        public string Color
        {
            get { return color; }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value)) { throw new Exception(); }
                color = value;
            }
        }

        public Device(string manufacturer, string model, int quantity, double price, string color)
        {
            Manufacturer = manufacturer;
            Model = model;
            Quantity = quantity;
            Price = price;
            Color = color;
        }

        public abstract void DisplayInfo();
    }
}
