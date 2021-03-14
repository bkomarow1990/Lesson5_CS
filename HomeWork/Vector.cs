using System;
using System.Collections.Generic;
using System.Text; 

namespace HomeWork
{
    class Vector
    {
        private int x;
        private int y;
        public int X
        {
            get => x;
            set
            {
                this.x = value;
            }
        }
        public int Y
        {
            get => y;
            set
            {
                this.y = value;
            }
        }
        public int getLength()
        {
            return (int)Math.Sqrt(x * x + y * y);
        }
        public static Vector operator +(Vector one, Vector two)
        {
            Vector result=new Vector();
            result.X = one.X + two.X;
            result.Y = one.Y + two.Y;
            return result;
        }
        public static Vector operator +(Vector one, double two)
        {
            Vector result = new Vector();
            result.X = (int)(one.X * two);
            result.Y = (int)(one.Y + two);
            return result;
        }
        public static double operator *(Vector one, Vector two)
        {
            return one.X * two.X + two.Y * one.Y;
        }
        public static Vector operator -(Vector one, Vector two)
        {
            Vector result = new Vector();
            result.X = one.X - two.X;
            result.Y = one.Y - two.Y;
            return result;
        }
        public static Vector operator -(Vector one)
        {
            return new Vector(-one.x, -one.y);
        }
        public static bool operator true(Vector one)
        {
            if (one.x ==0 && one.y ==0)
            {
                return false;
            }
            return true;
        }
        private bool IsValidIndex(int index) => index >= 0 && index <= 1;
        public int this[int index] // property = indexator одновимірний 
        {
            get
            {
                if (!IsValidIndex(index))
                    throw new Exception($"Error index {index}");
                if (index == 0)
                    return x;
                return y;
            }
            set
            {
                if (!IsValidIndex(index))
                    throw new Exception($"Error index {index}");
                if (index == 0)
                    X = value;
                else// !!!
                    Y = value; //
            }
        }
        public static bool operator false(Vector one)
        {
            if (one.x == 0 && one.y == 0)
            {
                return true;
            }
            return false;
        }
        public Vector(int x=0,int y=0)
        {
            this.X = x;
            this.Y = y;
        }
        public static bool operator==(Vector one, Vector two)
        {
            if (ReferenceEquals(one, two) == true)
            {
                return true;
            }
            if (one == null)
            {
                return false;
            }
            return one.Equals(two);
        }
        public static bool operator!=(Vector one, Vector two)
        {
            return !(one == two);
        }
        public static explicit operator double(Vector vector)
        {
            return vector.getLength();
        }
        public static implicit operator Vector(double num)
        {
            return new Vector((int)num, 0);
        }
        public static Vector operator ++(Vector one) 
        {
            return new Vector(++one.X,++one.Y);
        }
        public static Vector operator --(Vector one) 
        {
            return new Vector(--one.X, --one.Y);
        }
        public override int GetHashCode()
        {
            return ((decimal)(this.x / this.y)).ToString().GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Vector))
            {
                return false;
            }
            Vector vector = (Vector)obj;
            return this.x == vector.x && this.y == vector.y;
        }
        public override string ToString()
        {
            return $"Vector: ({x} , {y})";
        }
    }
}
