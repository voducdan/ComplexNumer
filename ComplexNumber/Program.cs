using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumber
{
    class ComplexNumber
    {
        private double _real;
        private double _image;
        public double Real
        {
            get { return _real; }
            set { _real = value; }
        }
        public double Image
        {
            get { return _image; }
            set { _image = value; }
        }
        // ham tao khong co tham so
        public ComplexNumber() { }
        // ham tao co tham so
        public ComplexNumber(double real, double image)
        {
            this._real = real;
            this._image = image;
        }
        public void PrintComplex()
        {
            if (this.Image > 0)
            {
                if (this.Image == 1)
                {
                    Console.WriteLine(this.Real.ToString() + "+i");
                } else
                    Console.WriteLine(this.Real.ToString() + "+" + this.Image.ToString() + "i");
            }
            else if (this.Image < 0)
            {
                Console.WriteLine(this.Real.ToString() + this.Image.ToString() + "i");
            }
            else
            {
                Console.WriteLine(this.Real.ToString());
            }
        }
        public static ComplexNumber operator +(ComplexNumber num1, ComplexNumber num2)
        {
            double real = num1.Real + num2.Real;
            double image = num1.Image + num2.Image;
            return new ComplexNumber(real, image);
        }
        public static ComplexNumber operator -(ComplexNumber num1, ComplexNumber num2)
        {
            double real = num1.Real - num2.Real;
            double image = num1.Image - num2.Image;
            return new ComplexNumber(real, image);
        }
        public double Abs()
        {
            return Math.Sqrt(this.Real * this.Real + this.Image * this.Image);
        }
        public static bool operator ==(ComplexNumber num1, ComplexNumber num2) {
            if (num1.Real == num2.Real && num1.Image == num2.Image)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(ComplexNumber num1, ComplexNumber num2)
        {
            if (num1.Real == num2.Real && num1.Image == num2.Image)
            {
                return false;
            }
            return true;
        }
        public string Sqrt()
        {
            if (this.Image == 0)
            {
                if (this.Real == 0)
                {
                    return "0";
                }
                else if (this.Real > 0)
                {
                    return $"{Math.Sqrt(this.Real)}, -{Math.Sqrt(this.Real)}";
                }
                else
                {
                    return $"i{Math.Sqrt(Math.Abs(this.Real))}, -i{Math.Sqrt(Math.Abs(this.Real))}";
                }
            }
            if(this.Real * this.Image > 0)
            {
                return $"{this.Real * this.Real - this.Image - this.Image}+{2 * this.Real * this.Image}i";
            }
            return $"{this.Real * this.Real - this.Image - this.Image}{2 * this.Real * this.Image}i";

        }
        public static ComplexNumber operator /(ComplexNumber num1, ComplexNumber num2)
        {
            double real = (num1.Real * num2.Real + num1.Image * num2.Image) / (num2.Real * num2.Real + num2.Image * num2.Image);
            double image = (num1.Image * num2.Real - num1.Image * num2.Image) / (num2.Real * num2.Real + num2.Image * num2.Image);
            return new ComplexNumber(real, image);
        }
        public static ComplexNumber operator *(ComplexNumber num1, ComplexNumber num2)
        {
            double real = num1.Image * num2.Real - num1.Image * num2.Image;
            double image = (num1.Image * num2.Real + num1.Image * num2.Image);
            return new ComplexNumber(real, image);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ComplexNumber num1 = new ComplexNumber(1, -2);
            ComplexNumber num2 = new ComplexNumber(2, -3);
            ComplexNumber add = num1 + num2;
            ComplexNumber sub = num1 - num2;
            ComplexNumber abs = new ComplexNumber(2, 3);
            ComplexNumber div = num1 / num2;
            ComplexNumber mul = num1 * num2;
            ComplexNumber sqrt = new ComplexNumber(2, 7);
            bool equal = num1 == num2;
            Console.WriteLine(abs.Abs().ToString());
            add.PrintComplex();
            sub.PrintComplex();
            div.PrintComplex();
            mul.PrintComplex();
            Console.WriteLine(sqrt.Sqrt());
            Console.WriteLine(equal.ToString());
        }
    }
}
