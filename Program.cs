using System;

namespace rectangle
{
    public class Rectangle
    {
        private int l;
        private int w;

        public Rectangle()
        {
            l = 1;
            w = 1;
        }

        public Rectangle(int len, int wid)
        {
            l = len;
            w = wid;
        }

        public int GetLength()
        {
            return l;
        }

        public int SetLength(int length)
        {
            l = length;
            return l;
        }
        public int GetWidth()
        {
            return w;
        }
        public int SetWidth(int width)
        {
            w = width;
            return w;
        }
        public int GetPerimeter()
        {
            return (2 * l + 2 * w);
        }
        public int GetArea()
        {
            return (l * w);
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Enter the length of the rectangle");
            int length = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the width of the rectangle");
            int width = Convert.ToInt32(Console.ReadLine());

            Rectangle rectangle = new Rectangle(length,width);

            Console.WriteLine("Select from the following options");

            Console.WriteLine("1. Get Rectangle Length");
            Console.WriteLine("2. Change Rectangle Length");
            Console.WriteLine("3. Get Rectangle Width");
            Console.WriteLine("4. Change Rectangle Width");
            Console.WriteLine("5. Get Rectangle Perimeter");
            Console.WriteLine("6. Get Rectangle Area");
            Console.WriteLine("7. Exit");

            int caseSwitch = Convert.ToInt32(Console.ReadLine());

            switch (caseSwitch)
            {
                case 1:

                    int rectleng = rectangle.GetLength();
                    Console.WriteLine(rectleng);
                    break;
                case 2:

                   
                default:
                    Console.WriteLine("Default case");
                    break;
            }
        }
    }
}
