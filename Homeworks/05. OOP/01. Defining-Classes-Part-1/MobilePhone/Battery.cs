namespace MobilePhone
{
    public class Battery
    {
        private string model;
        private int? hoursIdle;
        private int? hoursTalk;
        private BatteryType? batteryType;

        public Battery(string model)
        {
            this.Model = model;
            this.HoursIdle = null;
            this.HoursTalk = null;
            this.BatteryType = null;
        }

        public Battery(string model, int hoursIdle, int hoursTalk, BatteryType? batteryType) : this(model)
        {
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
            this.BatteryType = batteryType;
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }

        public int? HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }
            set
            {
                this.hoursIdle = value;
            }
        }

        public int? HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            set
            {
                this.hoursTalk = value;
            }
        }

        public BatteryType? BatteryType
        {
            get
            {
                return this.batteryType;
            }
            set
            {
                this.batteryType = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3}", this.model, this.hoursIdle.ToString(), this.hoursTalk.ToString(), this.batteryType);
        }
    }
}