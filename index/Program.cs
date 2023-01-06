using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Numerics;

namespace index
{
    class Program
    {

        static void Main(string[] args)
        {
            //string methods
            //length of string
            string sentence = "i love coding in c#";
            Console.WriteLine("the length of the string is: {0}", sentence.Length);
            //contains
            Console.WriteLine("the string contains 'in': {0}", sentence.Contains("in"));
            //indexof
            Console.WriteLine("the indexof coding: {0}", sentence.IndexOf("coding"));
            //remove 
            Console.WriteLine("to remove the first 7 characters: {0}", sentence.Remove(0, 6));
            //insert
            Console.WriteLine("insert text to the string: {0}", sentence.Insert(19, " using vscode"));
            //replace
            Console.WriteLine("replace a text: {0}", sentence.Replace("c#","python"));
            //equal
            Console.WriteLine("string A=B: {0}", String.Equals("B","A", StringComparison.OrdinalIgnoreCase) );

            Console.WriteLine("Pad left: {0}", sentence.PadLeft(20, '.'));
            //add fullstop to the 
            Console.WriteLine("Pad right: {0}", sentence.PadRight(20, '.'));
            //trim
            Console.WriteLine("trim spaces {0}", sentence.Trim());
            //to uppercase
            Console.WriteLine("to uppercase {0}", sentence.ToUpper());
            //to lowercase
            Console.WriteLine("to lowercase {0}", sentence.ToLower());

            string newString = String.Format("{0} is {1}", "coding", "fun");
            Console.WriteLine(newString);



            //escape quotes
            Console.WriteLine("a long day \"in\" nigeria");


            //string builders

            //will give you 16 character of 16
            StringBuilder sb = new StringBuilder("i love coding");
            Console.WriteLine(sb);

            //to increase the character of space
            StringBuilder sb2 = new StringBuilder("this is a new concept" +
                "in c# that i am just exploring");
            
            Console.WriteLine("capacity of sb2 is :{0}",sb2.Capacity);

            //append text to string builder
            Console.WriteLine("{0}",sb.AppendLine(" in c#")); 
            //replace a text in a string builder
            sb.Replace("c#", "javascript");
            //append text in a string builder
            sb.Append("program");
            //check if two string builder are equal
            Console.WriteLine("is sb equal to sb2? {0}", sb.Equals(sb2));
            Console.WriteLine(sb);

        }

    }
}
