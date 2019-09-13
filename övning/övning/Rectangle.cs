using System;
using System.Collections.Generic;
using System.Text;

namespace övning
{
    class Rectangle : Shape
    {
        public Rectangle(int width, int height) : base(width, height)
        {

        }
        public override int Area()
        {
            int area = width * height;
            return area;
        }

        public override int Circumference()
        {
            int circumference = (width * 2) + (height * 2);
            return circumference;
        }
    }
}
