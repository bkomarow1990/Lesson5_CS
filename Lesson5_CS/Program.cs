using System;   
namespace Lesson5_CS
{
    class Program
    {
        static void NullLesson()
        { 
            // Null-COLEASING
            string str = null;
            Console.WriteLine(str ?? "Empty string");
            // Null - CONDITIONAL
            Console.WriteLine(str?.Remove(0, 4));
            // if you need to else case, then
            Console.WriteLine(str?.Remove(0, 4) ?? "Bad String");
            Console.WriteLine("Hello World!");
        }
        class Fraction
        {
            int num, denom;
            public int Denom {
                get => denom;
                set => denom = value!=0 ? value : throw new Exception("Wrong denom");
            }
            public int Num
            {
                get => num;
                set => num = value;
            }
            public Fraction(int num=0, int denom=1)
            {
                try
                {
                    Denom = denom;
                }
                catch (Exception)
                {
                    denom = 1;
                }
                Num = num;
            }
            public override string ToString()
            {
                return $"{Num} / {Denom}"; 
            }
            public override bool Equals(object obj)
            {
                if (obj == null || ! (obj is Fraction))
                {
                    return false;
                }
                Fraction fr = (Fraction)obj;
                return this.num * fr.denom == this.denom * fr.num;
            }
            public override int GetHashCode()
            {
                return ((decimal)(this.num/this.denom)).ToString().GetHashCode();
            }
            public static Fraction operator +(Fraction one, Fraction two) {
                return new Fraction(one.num * two.denom + two.num * one.denom);
            }
            public static bool operator ==(Fraction one, Fraction two) {
                if (ReferenceEquals(one,two) == true)
                {
                    return true;
                }
                if (one == null)
                {
                    return false;
                }
                return one.Equals(two);
            }
            public static bool operator!=(Fraction one, Fraction two)
            {
                return !(one == two);
            }
        }

        static void Main(string[] args)
        {
            // Equals vs reference Lesson
            int[] arrA = { 10, 2, 34 };
            int[] arrB = { 10, 2, 34 };
            int[] arrC = arrA;
            Console.WriteLine($" Ref arrA == arrB : {object.ReferenceEquals(arrA,arrB)}"); //false
            Console.WriteLine($" Ref arrA == arrB : {object.ReferenceEquals(arrA,arrC)}"); // true
            Fraction fr1 = new Fraction(1, 2);
            
        }
    }
}
