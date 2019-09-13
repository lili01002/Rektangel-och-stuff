using System;
using System.Collections.Generic;
using System.Text;

namespace övning
{
    class Triangle : Shape
    {
        public Triangle(int width, int height) : base(width, height)
        {
        }

        public override int Area()
        {
            int area = (width * height) / 2;
            return area;
        }

        public override int Circumference()
        {
            double pyt = Math.Pow(width, 2) + Math.Pow(height, 2);
            int hypotenusan = Convert.ToInt32(Math.Sqrt(pyt));
            int circumference = width + height + hypotenusan;
            return circumference;

        }
    }
}
