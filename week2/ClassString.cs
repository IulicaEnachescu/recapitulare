using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2
{
    public class ClassString
    {   //Implement an algorithm to determine first unique element in a string

        public int FirstUniqChar(string s)
        {
            if (String.IsNullOrEmpty(s)) return -1;
            int n = s.Length;
            if (n == 1) return 0;
            Dictionary<char, int> dict = new Dictionary<char, int>();
            for (int i = 0; i < n; i++)
            {
                if (dict.ContainsKey(s[i])) dict[s[i]]++;
                else dict.Add(s[i], 1);
            }
            for (int i = 0; i < n; i++)
            {
                if (dict[s[i]] == 1) return i;
            }
            return -1;
        }

            //Implement an algorithm to determine if a string has all unique characters.

            public static bool UniquesCharacters(string str)
        {
            Console.WriteLine(str);
            var str2 = str.Distinct().ToList();
            if (str.Length == str2.Count) return true;
            else return false;
        }
        public static string RemoveDuplicatesFromString(string str)
        {
            StringBuilder strB = new StringBuilder(str);
            for(int i=0;i<strB.Length-2;i++)
            {
                for (int j = i + 1; j < strB.Length-1; j++)
                    if (strB[i] == strB[j]) strB.Remove(j,j);
            }
            return strB.ToString();
        }
        // Read a text from console and print it reversed.
        public static void ReverseText()
        {
            Console.WriteLine("Input a text");
            string txt=Console.ReadLine();
            //txt=txt.re
            var txt2 = txt.Reverse();
            Console.WriteLine(txt2.ToArray());
            StringBuilder txt1 = new StringBuilder(txt);
            for(int i=0;i<txt1.Length/2;i++)
            {
                char aux;
                aux=txt1[i];
                txt1[i] = txt1[txt.Length - i - 1];
                txt1[txt.Length - i - 1] = aux;
            }
            Console.WriteLine(txt1.ToString());
        }
        //Given a string s consists of upper/lower-case alphabets and empty space characters ' ', 
        //return the length of last word in the string.If the last word does not exist, return 0.
       
        public static string TimeConversion(string s)
        {
            char e = s.ElementAt(s.Length - 2);
            Console.WriteLine(e);
            string first = s.Substring(0, 2);
            Console.WriteLine(first);
            string result;
            if (e == 'A')
            {
                int i = int.Parse(first);
                Console.WriteLine("i "+i);
                if (i == 12)
                {
                    i = 0;
                    result=i.ToString() + i.ToString() + s.Substring(2, s.Length - 4);
                    Console.WriteLine(i+" "+ result);
                }
                else result = s.Substring(0, s.Length - 2);
            }
            else
            {
                int i = int.Parse(first);
                if (i == 12) result = i.ToString() + s.Substring(2, s.Length - 4);
                else
                {
                    i = i + 12;
                    result = i.ToString() + s.Substring(2, s.Length - 4);
                }
            }
            return result;

        }
        public static int LastWordLength()
        {
            Console.WriteLine("Introduceti propozitia");
            string word = Console.ReadLine();
            
            if (string.IsNullOrEmpty(word)) return 0;
            int result = 0;
            int len = word.Length;
            bool flag = false;
                for (int i = len - 1; i >= 0; i--)
                {
                    char c = word[i];
                    if (c!= ' ')
                    {
                        flag = true;
                        result++;
                    }
                    else
                    {
                        if (flag)
                            return result;
                    }
                }
                return result;
        }
        //Write a Program which checks if two Strings are Anagram or not?
        public static bool Anagrams(string first, string second)
        {
            if (first == second) return true;
            if (first.Length != second.Length) return false;
            var f = first.ToLower().ToCharArray();
            Array.Sort(f);
            var s = second.ToLower().ToCharArray();
            Array.Sort(s);
            string frs = new String(f);
            string scd = new String(s);
            return frs == scd;
        }
        public static bool IsPalindrome(string s)
        {
            if (String.IsNullOrEmpty(s)) return true;

            s = s.ToLower();
            var copy = s.Where(i => (Char.IsLetter(i) == true || Char.IsNumber(i) == true)).ToArray();
            if (copy.Length == 1) return true;
            int f = 0;
            int l = copy.Length - 1;
            while (f < l)
            {
                if (copy[f] != copy[l]) return false;
                f++;
                l--;
            }
            return true;
        }
    }
       
}

