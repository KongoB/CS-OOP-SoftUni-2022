using System;
using System.Text;

namespace P01.ClassBoxData
{
    public class Box
    {

        private double _length;
        private double _width;
        private double _height;


        public Box(double Length, double width, double height)
        {
            this.Length = Length;
            this.Width = width;
            this.Height = height;
        }



        public double Length 
        {
            get
            {
                return this._length;
            }
            private set
            {
                ValidatorZeroOrNegative(nameof(Length), value);
                this._length = value;
            }
        }
        public double Width
        {
            get
            {
                return this._width;
            }
            private set
            {
                ValidatorZeroOrNegative(nameof(Width), value);
                this._width = value;
            }
        }
        public double Height
        {
            get
            {
                return this._height;
            }
            private set
            {
                ValidatorZeroOrNegative(nameof(Height), value);
                this._height = value;
            }
        }

        public double SurfaceArea()
        {
            double surfaceArea = 2 * this.Length * this.Width + 2 * this.Length * this.Height + 2 * this.Width * this.Height;

            return surfaceArea;
        }

        public double LateralSurfaceArea()
        {
            double lateralSurfaceArea = 2 * this.Length * this.Height + 2 * this.Width * this.Height;

            return lateralSurfaceArea;
        }

        public double Volume()
        {
            double volume = this.Length * this.Width * this.Height;

            return volume;
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();


            sb
                .AppendLine($"Surface Area - {this.SurfaceArea():f2}")
                .AppendLine($"Lateral Surface Area - {this.LateralSurfaceArea():f2}")
                .AppendLine($"Volume - {this.Volume():f2}");

            return sb.ToString().TrimEnd();
        }

        private void ValidatorZeroOrNegative (string nameOfProp, double number)
        {
            if (number <= 0)
            {
                throw new ArgumentException(nameOfProp + " cannot be zero or negative.");
            }
        }



    }
}
