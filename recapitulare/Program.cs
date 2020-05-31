using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week2;

namespace recapitulare
{
    class Program
    {
        static void Main(string[] args)
        {
            // Class1.FizzBuzz(100, 3, 5);
            //Class1.CountFrArray(new[] { 1, 4, 5, 2, 1, 4, 3, 1, 2});
            //  Class1.SplitOddEven(new[] { 1, 4, 5, 2, 1, 4, 3, 1, 2 });
            int[] array1 = { 1, 4, 2, 8, 7 };
            int[] array2 = { 7, 5, 9, 1, 0, 2, 6 };
            int[] array3 = { 7,7, 5, 5, 9, 1, 0, 2, 6 };
            Console.WriteLine(array3.Distinct().ToList().Sum());
            LinkedList<int> lList = new LinkedList<int>();
            lList.AddLast(11);
            lList.AddLast(10);
            lList.AddLast(5);
            lList.AddLast(4);
            var node = lList.First;
            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }
            LinkedL l = new LinkedL();
            var li = l.BubleSort(lList);
            node = li.First;
            while (node!=null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }
            


            //Console.WriteLine(LetCode.RomanToInt("VCV"));
            //  Console.WriteLine(LetCode.Reverse(1534236469));
            // Class1.CountUniqueElements(array3);
            //Console.WriteLine (LetCode.IsPowerOfThree(22));

            //Console.WriteLine(LetCode.CountPrimes(8));

            // Console.WriteLine(ClassString.TimeConversion("06:40:03AM"));
            // Console.WriteLine(Class1.diagonalDifference());
            //Class1.CommonElements(array1, array2);
            //Class1.ListPrim(esNumbers(100);
            // Console.WriteLine(ClassString.UniquesCharacters("sdarsra"));
            //Console.WriteLine(ClassString.UniquesCharacters("sdare"));
            //ClassString.ReverseText();
            //Console.WriteLine(ClassString.LastWordLength());
            //Console.WriteLine(ClassString.RemoveDuplicatesFromString("asrtea sas"));
            //Console.WriteLine(Recursion.SumOfBits(4));
            //Console.WriteLine(Recursion.Fibonacci(6));
            //Console.WriteLine(Recursion.FibonacciIterative(6));
            //Console.WriteLine(Recursion.SumOfDigitsRec(704));
            //// Console.WriteLine(Class1.MajorityNumber(new[] { 1, 4, 5, 2, 1, 4, 3, 1, 2 }));
            //Console.WriteLine(Class1.MajorityNumber2(new[] { 1, 4, 5, 2, 1, 4, 3, 1, 2 ,1,1,1,1,1}));
            //Class1.PairsAdd(new[] { 1, 4, 5, 2, 1, 4, 3, 1, 2, 1, 1, 1, 1, 1 }, 4);
            //Stopwatch watch = new Stopwatch();
            // watch.Start();
            //int nr = Recursion.Fibonacci(20);
            // watch.Stop();
            //Console.WriteLine(nr+" "+watch.ElapsedMilliseconds);
            //watch.Start();
            //int nr1 = Recursion.RecursiveFactorial(10);
            //watch.Stop();
            //Console.WriteLine(nr1 + " " + watch.ElapsedMilliseconds);
            //Console.WriteLine(ClassString.Anagrams("ana", "naa"));
            //Console.WriteLine(ClassString.Anagrams("ann", "naa"));
            //Console.WriteLine(Class1.AmstrongNumber(371));
            //Console.WriteLine(Class1.PalindromNumber(373));
            //Console.WriteLine(Class1.PalindromNumber(371));
            //Class1.Rotate(new[] { 1, 4, 5, 2, 1, 4, 3, 1, 2 }, 2, 9);
            Console.ReadLine();
        }
    }
}
