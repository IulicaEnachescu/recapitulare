using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recapitulare
{
    public class LetCode
    {
        public static bool IsHappy(int n)
        {
            int nr = n;
            if (nr == 1 || n == 7) return true;
            int sum = n, copy = n;
            // this loop executes till the sum of square of 
            // digits obtained is not a single digit number 
            while (sum > 9)
            {
                sum = 0;

                // this loop finds the sum of square of digits 
                while (copy > 0)
                {
                    sum = sum + (copy % 10) * (copy % 10);
                    copy = copy / 10;

                }
                if (sum == 1)
                    return true;
                copy = sum;
            }
            if (sum == 7)
                return true;
            return false;
        }
        public static bool IsPowerOfThree(int n)
        {

            while (n < 3)
            {
                n = n / 3;
            }
            if (n % 3 == 0) return true;
            else return false;
        }
        public static int CountPrimes(int n)
        {
            bool[] isPrime = new bool[n];
            for (int i = 2; i < n; i++)
            {
                isPrime[i] = true;
            }
            // Loop's ending condition is i * i < n instead of i < sqrt(n)
            // to avoid repeatedly calling an expensive function sqrt().
            for (int i = 2; i * i < n; i++)
            {
                if (!isPrime[i]) continue;
                for (int j = i * i; j < n; j += i)
                {
                    isPrime[j] = false;
                }
            }
            int count = 0;
            for (int i = 2; i < n; i++)
            {
                if (isPrime[i]) count++;
            }
            return count;
        }
        public bool isPrime(int num)
        {

            if (num <= 1) return false;

            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }
    }
}

   
