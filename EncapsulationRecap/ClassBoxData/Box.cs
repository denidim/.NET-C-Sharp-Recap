namespace ClassBoxData
{
    internal class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public double Length
        {
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException($"{this.length.GetType().Name} cannot be zero or negative.");
                }
                length = value;
            }
        }

        public double Width
        {
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException($"{this.width.GetType().Name} cannot be zero or negative.");
                }
                width = value;
            }
        }

        public double Height
        {
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException($"{this.height.GetType().Name} cannot be zero or negative.");
                }
                height = value;
            }
        }

        public double GetSurfaceArea()
        {
            return 2 * (this.width * this.length) + 2 * (this.length * this.height) + 2 * (this.width * this.height);
        }

        public double GetLateralSurfaceArea()
        {
            return  2 * (this.length * this.height) + 2 * (this.width * this.height);
        }

        public double GetVolume()
        {
            return this.length * this.width * this.height;
        }
    }
}
