using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace week2
{
    /*For all numbers from 1 to 1000, print the following:
- If number is divisible by 3, print Fizz
- If number is divisible by 5, print Buzz
- If number is divisible by 3 and 5, print FizzBuzz
- Otherwise, print the number

02. Write a program to count the frequency of each element in an array e. g. [1, 4, 5, 2, 1, 4, 3, 1, 2]
should output: 1 - 3 times 4 - 2 times 5 - one time 2 - 2 times 3 - one time

03. Read an array from the console and separate odd and even values into 2 arrays. 
E.g. Number of elements in array: 3
- element 1: 4
- element 2: 3
- element 3: 2
Result: Odd array: [3] Even array: [4, 2]

04. Homework 4
1. Find common elements between two arrays of integers.
2. Write a function to check if a number is prime or not.*/
    public class Class1
    {
        public static void FizzBuzz(int max, int nr1, int nr2)
        {
            /*For all numbers from 1 to 1000, print the following:
- If number is divisible by 3, print Fizz
- If number is divisible by 5, print Buzz
- If number is divisible by 3 and 5, print FizzBuzz
- Otherwise, print the number*/
            for (int i=1; i<=max; i++) 
            {
                StringBuilder str = new StringBuilder();
                if (i%nr1 == 0) str.Append("Fizz");
                if (i%nr2 == 0) str.Append("Buzz");
                if (str.Length == 0) str.Append(i);
                Console.WriteLine(str);
            }
            
        }
        public static void CountFrArray(int[] array)
        {
            /*Write a program to count the frequency of each element in an array e. g. [1, 4, 5, 2, 1, 4, 3, 1, 2]
should output: 1 - 3 times 4 - 2 times 5 - one time 2 - 2 times 3 - one time*/
            Dictionary<int,int> dict = new Dictionary<int, int>();
            for(int i=0;i<array.Length;i++)
            {
                if (!dict.ContainsKey(array[i])) dict.Add(array[i], 0);
                else dict[array[i]]++;
            }
            foreach (KeyValuePair<int,int> item in dict)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
          
        }
        public static void SplitOddEven(int []array)
        {
            //Read an array from the console and separate odd and even values into 2 arrays. 
            List <int>oddArr = new List<int>();
            List <int>evenArr = new List<int>();
            foreach(int item in array)
            {
                if (item % 2 == 0) evenArr.Add(item);
                else oddArr.Add(item);
            }
            Console.Write("Odd numbers: ");
            foreach (var item in oddArr)
            {
                Console.Write(item+ " , ");
            }
            Console.WriteLine();
            Console.Write("Even numbers: ");
            foreach (var item in evenArr)
            {
                Console.Write(item + " , ");
            }   
        }
        public static void CommonElements(int[]arr1, int[] arr2)
        {
            
            // Call Intersect extension method.  
            var intersect = arr1.Intersect(arr2).ToList();

            foreach (int value in intersect)
            {
                Console.WriteLine(value);
            }
        }
        public static void ListPrimesNumbers(int nr) 
        {
            for (int i = 1; i <= nr; i++)
            {
                if (IsPrime(i) == true) Console.WriteLine(i);
            }
        } 
        private static bool IsPrime(int nr)
        {
            for(int i=2; i*i<=nr; i++)
            {
                if (nr % i == 0) return false;
            }
            return true;

        }
        //Given an unsorted array which has a number in the majority
        //(a number appears more than 50% in the array), find that number?
        public static int diagonalDifference()
        {
            List<List<int>> arr = new List<List<int>>();
            arr.Add(new List<int> { 11, 2, 4 });
            arr.Add(new List<int> { 4, 5, 6 });
            arr.Add(new List<int> { 10, 8, 12 });
            int dim = arr.Count();
            int sum1 = 0;
            int sum2 = 0;
            int[,] matrix = new int[dim, dim];
            int i = 0;

            foreach (List<int> item1 in arr)
            {
                int j = 0;
                foreach (int item2 in item1)
                {
                    if (item2 < -100 || item2 > 100) throw new ArgumentException();
                    matrix[i, j++] = item2;
                    Console.WriteLine(item2);
                }
                i++;
            }
            for (i = 0; i < dim; i++)
            {
                sum1 += matrix[i, i];
                Console.WriteLine($"matrix[i, i], { matrix[i, i]} sum1 {sum1}");
                sum2 += matrix[i, dim - i-1];
                Console.WriteLine($"matrix[dim-i-1], {matrix[dim - i - 1, dim - i - 1]} sum2 {sum2}");
            }
            int rez = Math.Abs(sum1 - sum2);
            
            return rez;
        }

    
    public static int MajorityNumber(int[] array)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
                for (int i=0;i<array.Length; i++)
                {
                if (dict.ContainsKey(array[i])) dict[array[i]]++;
                else dict.Add(array[i], 0);
                }
            int max = 0;
            int count=0;
            foreach (KeyValuePair<int,int> item in dict)
            {
                if (item.Value>count)
                {
                    max = item.Key;
                    count = item.Value;
                }
            }
            return max;
        }
        public static int MajorityNumber2(int[] array)
        {
            for (int i = 0; i < array.Length-1; i++)
            {   
                int count = 0;
                int number = array[i];
                for (int j = i; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    { count++; }
                }
                if (count >=array.Length / 2) return count;
               
            }
            return 0;
        }
        //How to find all pairs of elements in an integer array, whose sum is equal to a given number?
        public static void PairsAdd(int[] array, int nr)
        {
            for (int i=0;i<=array.Length-2; i++)
            {
                for (int j = i+1; j < array.Length - 1; j++)
                {
                    if (array[i] + array[j] == nr) Console.WriteLine(array[i] +" , " + array[j]);
                }
            }
        }

        
        public static void CountUniqueElements(int[] array)
        {
            //FRECVENTA ELEMENTELOR DISTENCTE DINTR-UN SIR DE NUMERE
            //1, 6, 2, 7, 1
            int n = 1;
            int[] arraynew = new int[array.Length];

            for (int i = 0, ia = 0; i < array.Length; i++, ia++)
            {
                int x = array[i];
                bool found = IfElementExists(arraynew, x);

                if (found == true)
                {
                    continue;
                }
                    arraynew[ia] = array[i];
                    for (int j = 0; j < array.Length; j++)
                    {
                        if (x == array[j] && i != j)
                        {
                            n++;
                        }

                    }
                    Console.WriteLine($"Element {x}: {n}");
                    n = 1;
                
            }
            /*List<int> noDuplicates = numbers.Distinct().ToList();

            foreach (int element in noDuplicates)
            {
                int c = 0;
                for (int i = 0; i<numbers.Length; i++)
                {
                    if (element == numbers[i])
                    {
                        c++;
                    }

                }

                Console.WriteLine($"{element}={c}");
            }*/
        }

        private static bool IfElementExists(int[] arraynew, int i)
        {
            bool found = false;
            for (int k = 0; k < arraynew.Length; k++)
            {
                if (arraynew[k] == i)
                {
                    found = true;
                    break;
                }
            }

            return found;
        }
        public static bool AmstrongNumber(int nr)
        {
            int ln = nr.ToString().Length;
            int duplicateNr = nr;
            int sum = 0;
            while (nr !=0)
            {
                sum = sum + (int)Math.Pow(nr % 10, ln);
                nr = nr / 10;
            }
            return sum == duplicateNr;
        }
        public static bool PalindromNumber(int nr)
        {
            int duplicateNr = nr;
            int sum = 0;
            while (nr != 0)
            {
                sum = sum*10 + nr % 10;
                nr = nr / 10;
            }
            return sum == duplicateNr;
        }
       public static void RotateArrByAPivot(int[] arr, int nr)
        {
            int[] newArr = new int[arr.Length];
            int i;
            int j = 0;
           for(i=nr+1;i<=newArr.Length;i++)
            {
                newArr[j++] = arr[i];
            }
            for (int k = 0;  k< nr; k++)
            {
                if (k == 0) newArr[j++] = nr;
                newArr[j++] = arr[k];
            }
            PrintArrays(newArr);
        }
        //elementul unic dintr-un array
        public int SingleNumber(int[] nums)
        {
            var nr = nums.GroupBy(i => i).Where(i => i.Count() == 1).Select(i => i.Key).FirstOrDefault();
            return (int)nr;
        }

        static void PrintArrays(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + ", ");
            }
            Console.WriteLine("");
            Console.WriteLine("-----------------");
        }

        private static void RandomGuess()
        {//Ghiceste un numar generat aleator
            Random rand = new Random();
            int numarRandom = rand.Next(1, 10);

            while (true)
            {
                Console.WriteLine("Introduceti nr:");
                int nr = int.Parse(Console.ReadLine());

                if (numarRandom == nr)
                {
                    Console.WriteLine("Bravo");
                    break;
                }

                if (nr > numarRandom)
                {
                    Console.WriteLine("Prea mare");
                }
                else
                {
                    Console.WriteLine("Prea mic");
                }
            }
        }

    }
}
