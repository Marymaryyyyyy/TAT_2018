using System;

namespace Task_2kr
{
    public class Rectangle
    {
        public double Width { get; set; }
        public double Length { get; set; }

        public Rectangle(string[] args)
        {
            if (args.Length != 2)
                throw new ArgumentException();
            Width = Single.Parse(args[1]);
            Length = Single.Parse(args[2]);

            if (Width <= 0 || Length <= 0)
                throw new ArgumentException();
        }

        public double CalculateSquare()
        {
            return Length * Width;
        }
    }
}
