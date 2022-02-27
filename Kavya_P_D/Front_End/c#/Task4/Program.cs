using System;
namespace StringApplication
{
    public class Program
    {
        public static void Main(String[] args)
        {//clone()
            string s1 = "Hello ";
            string s2 = (String)s1.Clone();
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine("---------------------------");
            //compare()->s1==s2->0,s1>s2->1,s1<s->-1
            string s3 = "hi";
            string s4 = "hello";
            string s5 = "good";
            string s6 = "hi";
            Console.WriteLine(string.Compare(s3, s4));
            Console.WriteLine(string.Compare(s4, s5));
            Console.WriteLine(string.Compare(s3, s6));
            Console.WriteLine("---------------------------");
            //concat()->use to concatinate the mulitiple strings
            string s7 = "Hello";
            string s8 = "CSHARP";
            Console.WriteLine(string.Concat(s7, s8));
            Console.WriteLine("---------------------------");
            //copy()->use to copy the string
            string s9 = "Hello Everyone";
            string s10 = string.Copy(s9);
            Console.WriteLine(s9);
            Console.WriteLine(s10);
            //The C# Remove() method is used to get a new string after removing all the characters from specified beginIndex till given length. If length is not specified, it removes all the characters after beginIndex.
            string s11 = "Hello C#";
            string s12 = s1.Remove(2);
            Console.WriteLine(s12);
            Console.WriteLine("--------------------------------------");
            //The C# Replace() method is used to get a new string in which all occurrences of a specified Unicode character in this string are replaced with another specified Unicode character.
            string s13 = s11.Replace('#','S');
            Console.WriteLine(s13);
            Console.WriteLine("--------------------------------------");
            //The C# StartsWith() method is used to check whether the beginning of this string instance matches the specified string.
            bool b1 = s9.StartsWith("h");
            bool b2 = s9.StartsWith("H");
            Console.WriteLine(b1);
            Console.WriteLine(b2);
            Console.WriteLine("--------------------------------------");
            //The C# Split() method is used to split a string into substrings on the basis of characters in an array. It returns string array.
            string s14 = "Hello C Sharp";
            string[] s18 = s14.Split(' ');
            foreach (string s in s18)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("--------------------------------------");
            //The C# ToCharArray() method is used to get character array from a string object.
            char[] ch3 = s14.ToCharArray();
            foreach (char c in ch3)
            {
                Console.WriteLine(c);

            }
            Console.WriteLine("--------------------------------------");
            //The C# EndsWith() method is used to check whether the specified string matches the end of this string or not. If the specified string is found at the end of this string, it returns true otherwise false.
            Console.WriteLine(s11.EndsWith("lo"));
            Console.WriteLine("--------------------------------------");
        }
    }
}