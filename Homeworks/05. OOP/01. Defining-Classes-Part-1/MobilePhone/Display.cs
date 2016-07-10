namespace MobilePhone
{
    public class Display
    {
        private double? sizeInches;
        private int? numberOfColors;

        public Display(double sizeInches, int numberOfColors)
        {
            this.SizeInches = sizeInches;
            this.NumberOfColors = numberOfColors;
        }

        public Display()
        {
            this.SizeInches = null;
            this.NumberOfColors = null;
        }

        public double? SizeInches
        {
            get
            {
                return this.sizeInches;
            }
            set
            {
                this.sizeInches = value;
            }
        }

        public int? NumberOfColors
        {
            get
            {
                return this.numberOfColors;
            }
            set
            {
                this.numberOfColors = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", this.sizeInches, this.numberOfColors);
        }
    }
}