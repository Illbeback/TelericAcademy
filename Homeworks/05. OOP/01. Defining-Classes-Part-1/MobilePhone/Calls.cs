namespace MobilePhone
{
    using System;

    public class Call
    {
        private DateTime date;
        private TimeSpan time;
        private string phoneNumber;
        private int duration;

        public Call(string phoneNumber, DateTime date, TimeSpan time, int duration)
        {
            this.phoneNumber = phoneNumber;
            this.date = date;
            this.time = time;
            this.duration = duration;
        }

        public int Duration
        {
            get
            {
                return this.duration;
            }
        }

        public override string ToString()
        {
            return String.Format("{0}, {1}.{2}.{3}, {4}, {5} seconds", this.phoneNumber, this.date.Year, this.date.Month, this.date.Day, this.time, this.duration);
        }
    }
}