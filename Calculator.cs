using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Calculator<T> where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {
        public T Add(T x, T y)
        {
            dynamic dx = x;
            dynamic dy = y;
            return dx + dy;
        }

        public T Subtract(T x, T y)
        {
            dynamic dx = x;
            dynamic dy = y;
            return dx - dy;
        }

        public T Multiply(T x, T y)
        {
            dynamic dx = x;
            dynamic dy = y;
            return dx * dy;
        }

        public T Divide(T x, T y)
        {
            dynamic dx = x;
            dynamic dy = y;
            return dx / dy;
        }
    }
}