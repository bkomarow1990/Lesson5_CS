using System;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector a = new Vector(1, 2);
            Vector b = new Vector(4, 3);
            Vector c = new Vector(0, 0);
            a += b;
            Console.WriteLine(a.ToString());
            a -= b;
            Console.WriteLine(a.ToString());
            a *= b;
            Console.WriteLine(a.ToString());
            a *= c;
            Console.WriteLine(a.ToString());
            a[0] = 2;
            a[1] = 3;
            Console.WriteLine(a.ToString());
            Console.WriteLine("Hello World!");
        }
    }
}
