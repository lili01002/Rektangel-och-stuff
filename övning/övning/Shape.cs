using System;
using System.Collections.Generic;
using System.Text;

namespace övning
{
    abstract class Shape
    {
        protected int width;
        protected int height;
        public Shape(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
        public abstract int Area();


        public abstract int Circumference();


    }
}