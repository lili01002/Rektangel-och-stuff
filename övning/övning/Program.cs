using System;

namespace övning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what shape");
            string shape;
            shape = Console.ReadLine();

            if(shape == "triangle")
            {
                Console.WriteLine("what height");
                int height = int.Parse(Console.ReadLine());
                Console.WriteLine("what width");
                int width = int.Parse(Console.ReadLine());
                Triangle t = new Triangle(width, height);
                Console.WriteLine("Area: " + t.Area());
                Console.WriteLine("Circumference: " + t.Circumference());
            }

            else if(shape == "rectangle")
            {
                Console.WriteLine("what height");
                int height = int.Parse(Console.ReadLine());
                Console.WriteLine("what width");
                int width = int.Parse(Console.ReadLine());
                Rectangle r = new Rectangle(width, height);
                Console.WriteLine("Area: " + r.Area());
                Console.WriteLine("Circumference: " + r.Circumference());
            }

            else
            {

            }
        }
    }
}
