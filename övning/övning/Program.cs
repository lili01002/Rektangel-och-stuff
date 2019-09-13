using System;

namespace övning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what shape");
            string shape;
            Shape s;
            shape = Console.ReadLine();
            Console.WriteLine("what height");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine("what width");
            int width = int.Parse(Console.ReadLine());

            if (shape == "triangle")
            {
                s = new Triangle(width, height);
            }

            else //if(shape == "rectangle")
            {
                s = new Rectangle(width, height);
            }

            Console.WriteLine("Area: " + s.Area());
            Console.WriteLine("Circumference: " + s.Circumference());
        }
    }
}
