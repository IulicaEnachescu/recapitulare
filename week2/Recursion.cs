using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2
{
    public class Recursion
    {
        //How to find sum of digits of a number using Recursion?
        public static int SumOfBits(int nr)
        {
            int count = 0;
            while (nr > 0)
            {
                count = count + (nr & 1);
                nr >>= 1;
            }
            return count;
        }
        public static int SumOfDigitsRec(int nr)
        {
            if (nr==0) return 0;
            else return SumOfDigitsRec(nr/10) + nr%10;
        }
        //How to calculate factorial using recursion in C# + iterative + time difference
        public static int IterativFactorial(int nr)
        {
            int fact = 1;
            for (int i = 1; i <= nr; i++)
            {
                fact =fact* i;
            }
            return fact;
        }
        public static int RecursiveFactorial(int nr)
        {
            if (nr == 1) return 1;
            else return nr * RecursiveFactorial(nr - 1);
        }
        public static int Fibonacci(int nr)
        {
            if (nr == 0) return 0;
            else if (nr == 1) return 1;
            else return Fibonacci(nr - 1) + Fibonacci(nr - 2);
        }
        public static int FibonacciIterative(int nr)
        {
            int a = 0;
            int b = 1;
            int c = 0;
            for(int i=1; i<nr; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            return c;
        }

    }

}


