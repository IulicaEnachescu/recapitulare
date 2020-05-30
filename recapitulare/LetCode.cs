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
        public static int RomanToInt(string s)
        {
            //           If I comes before V or X, subtract 1 eg: IV = 4 and IX = 9
            //* If X comes before L or C, subtract 10 eg: XL = 40 and XC = 90
            //* If C comes before D or M, subtract 100 eg: CD = 400 and CM = 900
            if (String.IsNullOrEmpty(s)) throw new ArgumentNullException();

            s = s.ToUpper();
            int l = s.Length;
            int res = 0;

            for (int i = 0; i < l; i++)
            {
                // Getting value of symbol s[i]  
                int s1 = Value(s[i]);

                // Getting value of symbol s[i+1]  
                if (i + 2 < l)
                {

                    if ((s[i] == s[i + 2]) && !(s[i + 1] == s[i]) && (Value(s[i]) < Value(s[i + 1]))) return -1;
                }
                if (i + 1 < l)
                {
                    int s2 = Value(s[i + 1]);
                   

                    // Comparing both values  
                   // if (s)
                    if (s1 >= s2)
                    {
                        // Value of current symbol is greater  
                        // or equalto the next symbol  
                        res = res + s1;
                    }
                    else
                    {
                        res = res + s2 - s1;
                        i++; // Value of current symbol is 
                             // less than the next symbol  
                    }
                }
                else
                {
                    res = res + s1;
                    i++;
                }
            }
                return res;
        }
        private static int Value(char v)
        {   
            if (v == 'I') return 1;
            if (v == 'V') return 5;
            if (v == 'L') return 50;
            if (v == 'X') return 10;
            if (v == 'C') return 100;
            if (v == 'D') return 500;
            if (v == 'M') return 1000;
            return -1;
        }
        public static int Reverse(int x)
        {
            int reverse = 0;
            while (x != 0)
            {
                int pop = x % 10;
                x /= 10;
                if (reverse > Int32.MaxValue / 10 || (reverse == Int32.MinValue / 10 && pop >7))  return 0;
                if (reverse < Int32.MinValue / 10 || (reverse == Int32.MinValue / 10 && pop < -8)) return 0;
                reverse = reverse * 10 + pop;
            }
            return reverse;

        }
    }
}

   
