namespace MobilePhone
{
    using System;
    using System.Collections.Generic;

    public class GSM
    {
        private string model;
        private string manufacturer;
        private decimal? price;
        private string ownerName;
        private Battery battery;
        private Display display;
        private static GSM iPhone4S;

        static GSM()
        {
            IPhone4S = new GSM("4S", "Apple", 500, "Georgi",
                new Battery("good"), new Display());
        }

        public GSM(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = null;
            this.OwnerName = null;
            this.Battery = null;
            this.Display = null;
            this.CallHistory = new List<Call>();
        }

        public GSM(string model, string manufacturer, decimal price, string ownerName, Battery battery, Display display)
            : this(model, manufacturer)
        {
            this.Price = price;
            this.OwnerName = ownerName;
            this.Battery = battery;
            this.Display = display;
            this.CallHistory = new List<Call>();
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException();
                }
                this.model = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException();
                }
                this.manufacturer = value;
            }
        }

        public decimal? Price
        {
            get
            {
                return this.price;
            }
            set
            {
                this.price = value;
            }
        }

        public string OwnerName
        {
            get
            {
                return this.ownerName;
            }
            set
            {
                this.ownerName = value;
            }
        }

        public Battery Battery
        {
            get
            {
                return this.battery;
            }
            set
            {
                this.battery = value;
            }
        }

        public Display Display
        {
            get
            {
                return this.display;
            }
            set
            {
                this.display = value;
            }
        }

        public static GSM IPhone4S
        {
            get { return iPhone4S; }
            set { iPhone4S = value; }
        }

        public List<Call> CallHistory
        {
            get;
            set;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4} {5}",
                this.model, this.manufacturer, this.price.ToString(), this.ownerName, this.battery, this.display);
        }

        public void PerformCall(string phoneNumber, int duration)
        {
            Call call = new Call(phoneNumber, DateTime.Now.Date, DateTime.Now.TimeOfDay, duration);
            this.CallHistory.Add(call);
        }

        public void DeleteCall(string phoneNumber, DateTime date, TimeSpan time, int duration)
        {
            Call call = new Call(phoneNumber, DateTime.Now.Date, DateTime.Now.TimeOfDay, duration);
            this.CallHistory.Remove(call);
        }

        public void ClearCallHistory()
        {
            this.CallHistory.Clear();
        }

        public double TotalCallsPrice(double pricePerMinute)
        {
            double totalDuration = 0;
            foreach (var call in this.CallHistory)
            {
                totalDuration += call.Duration;
            }
            return totalDuration / 60 * pricePerMinute;
        }

        public string PrintCallHistory()
        {
            return string.Join("\n", this.CallHistory);
        }
    }
}