using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Globalization;
namespace loops_casting
{
    class Program
    {
        static void Main(string[] args)
        {
            //working with arrays
            //to declarre an array
            int[] numList = new int[3];
            numList[0] = 1;
            numList[1] = 2;
            numList[2] = 3;
            // to get the index item using bracket notation
            Console.WriteLine("first item in the array: {0} ",numList[0]);

            // you can also declare array like so
            int[] items = { 20, 30, 40, 50 };

            //get the last item
            Console.WriteLine("last item in the array: {0}",items[items.Length-1]);

            //string array
            string[] names = { "john", "michael", "dave", "bayo" };
            Console.WriteLine("student names: {0}", names[2]);

            //to create an array with multiple data types
            object[] randomValues = { "john", 30, true, 40.8 };
            Console.WriteLine("type of value: {0}", randomValues[2].GetType());

            //to get the length of an array
            Console.WriteLine("length of array: {0}", randomValues.Length);

            //loop through an array using a for loop
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("array {0} : value {1}", i, names[i]);
            }

            //working with multidimensional array
            string[,] students = new string[2,2] { { "john", "jake" }, { "bane", "jude" } };
            Console.WriteLine("jake's value : {0}", students.GetValue(0,1));

            //loop through a multidimensional array using a for loop
            for(int i=0; i < students.GetLength(0); i++)
            {
                for(int j=0; j < students.GetLength(1); j++)
                {
                    Console.Write("{0} \n", students[i,j]);
                }
            }

            //sorting an array in ascending order (smallest to largest/alphabetical order)
            Array.Sort(names);

            //sorting an array in descending order (largest to smallest)
            Array.Reverse(names);

            //foreach loop
            printStudents(names, "student: {0}");

            //get index position of an item
            int[] scores = new int[5] {20, 30, 50, 60, 70 };
            Console.WriteLine("index position of score: {0}", Array.IndexOf(scores,70));

            //change value at specific index
            scores.SetValue(100,4);
            setValues(scores);

            //copy items from an array
            int[] srcArray = { 1, 2, 3,4 };
            int[] desArray = new int[4];

            int startindex = 0;
            int length = 4;

            Array.Copy(srcArray, startindex, desArray, startindex, length);
            copyArray(desArray, "copy_array: {0}");


            //to check if a condition is met

            int[] values = { 10, 12, 13 };
            Console.WriteLine("greater than 10: {0}", Array.FindAll(values,greaterThanTen));
           

        }
        //loop using a foreach loop
        static void printStudents(string[] students, string message)
        {
            foreach (string item in students)
            {
                Console.WriteLine(message,item);
            }
        }
        //function to set values
        static void setValues(int[] scores)
        {
            foreach (int item in scores)
            {
                Console.WriteLine(item);
            }
        }

        //function to copy array
        static void copyArray(int[] desArray, string message)
        {
            foreach (int item in desArray)
            {
            Console.WriteLine(message, item);

            }
        }

        public static bool greaterThanTen(int val)
        {
            return val > 10;
        }
    }
}
