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
            Console.WriteLine("Hello World!");
        }
    }
}
