using System.Runtime.CompilerServices;

namespace Store.Devices
{
    abstract class Device
    {
        protected string series;
        protected string manufacturer;
        protected string model;
        protected int quantity;
        protected double price;
        protected string color;

        public string Series
        {
            get { return series; }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value)) { throw new Exception(); }
                series = value;
            }
        }
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
            GenerateSeries();
        }

        public abstract void DisplayInfo(int y);
        void GenerateSeries()
        {
            Random rnd = new Random();
            for (int s = 1; s <= 8; ++s)
            {
                Series += (char)rnd.Next(65, 90);
                if (s == 5)
                {
                    for (int n = 1; n <= 3; ++n)
                    {
                        Series += Convert.ToString(rnd.Next(0, 9));
                    }
                }
            }
            Series = Series.ToUpper();
        }

        public void DisplayContainer(string baseInfo, string anotherInfo, int y)
        {
            string horizontal = "─";
            string vertical = "│";
            string ul_corner = "┌";
            string ur_corner = "┐";
            string ll_corner = "└";
            string lr_corner = "┘";

            Console.SetCursorPosition(0, y);
            Console.Write(ul_corner);
            Console.SetCursorPosition(70, y);
            Console.Write(ur_corner);
            Console.SetCursorPosition(0, y + 10);
            Console.Write(ll_corner);
            Console.SetCursorPosition(70, y + 10);
            Console.Write(lr_corner);
            Console.SetCursorPosition(1, y);
            Console.Write(string.Concat(Enumerable.Repeat(horizontal, 69)));
            Console.SetCursorPosition(1, y + 10);
            Console.Write(string.Concat(Enumerable.Repeat(horizontal, 69)));
            Console.SetCursorPosition(71, y + 1);
            Console.Write($"({Series})");

            var baseInfoByLine = baseInfo.Split('\n');
            var anotherInfoByLine = anotherInfo.Split('\n');

            for (int i = y; i < y + 9; i++)
            {
                Console.SetCursorPosition(0, i + 1);
                Console.Write(vertical);
                Console.SetCursorPosition(70, i + 1);
                Console.Write(vertical);
            }
            for (int i = 1; i < baseInfoByLine.Length; ++i, ++y)
            {
                Console.SetCursorPosition(2, y + 1);
                Console.Write(baseInfoByLine[i]);
                if (i == baseInfoByLine.Length - 1)
                {
                    Console.SetCursorPosition(1, y);
                    Console.Write(string.Concat(Enumerable.Repeat(horizontal, 69)));
                }
            }
            for (int i = baseInfoByLine.Length, k = 1; i < anotherInfoByLine.Length + baseInfoByLine.Length; ++i, ++k, ++y)
            {
                Console.SetCursorPosition(2, y);
                Console.WriteLine(anotherInfoByLine[k]);
                if (k == 2)
                    break;
            }



            Console.WriteLine('\n');
        }
    }
}
