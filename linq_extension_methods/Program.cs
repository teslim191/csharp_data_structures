using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace linq_extension_methods
{
    class Program
    {
        delegate double doubleIt(double val);
        static void Main(string[] args)
        {
            
            //list
            //Using Where, Select, Zip
            List<int> newList = new List<int> { 1, 2, 3, 4, 5, 6,7,8,9,10 };
            //return a list that contains only even values using Where
            var evenList = newList.Where(a => a % 2 == 0).ToList();
            foreach (var item in evenList)
                Console.WriteLine(item);


            //return a list with values gt 2 and less than 10
            var Range = newList.Where(a => (a > 2) && (a < 9)).ToList();
            foreach(var item_2 in Range)
                Console.WriteLine(item_2);

            //while loop
            int x = 0;
            while (x <= 10)
            {
                Console.WriteLine("the value of x is {0}\n",x);
                x++;
            }

            //create a list like so
            var names = new List<string> { "john", "sally", "jonathan" };
            //return names that starts with j
            var namesWithJ = names.Where(a => a.StartsWith("j")).ToList();
            foreach(var item_3 in namesWithJ)
                Console.WriteLine(item_3);

            //create a list having a range and return the square of each of the number
            var rangeOneToTen = new List<int>();
            rangeOneToTen.AddRange(Enumerable.Range(1,10));

            var squaredValues = rangeOneToTen.Select(i => i * i).ToList();

            foreach(var m in squaredValues)
                Console.WriteLine(m);

            //USING ZIP TO SUM LIST TOGETHER

            var listOne = new List<int> { 1, 2, 3, 4, 5 };
            var listTwo = new List<int> { 6, 7, 8, 9, 10 };

            var sumList = listOne.Zip(listTwo, (y, z) => y + z);

            foreach(var item_4 in sumList)
                Console.WriteLine(item_4);

            //using aggregate function to sum items in alist
            var studentScores = new List<int>() { 20, 30, 40, 50 };
            Console.WriteLine("Total Score: {0}", studentScores.Aggregate((a, b)=> a + b));

            //average
            var averageScores = new List<int>() { 1, 2, 3, 4, 5 };
            Console.WriteLine("Average:{0}", averageScores.AsQueryable().Average());

            //All (to check if all items meet a particular condition)

            Console.WriteLine("are all student scores > 10 ? {0}", studentScores.All(n => n > 10));

            //Any (to check if any of the item meets a particular condition)

            Console.WriteLine("is any of the student scores below 20? {0}", studentScores.Any(r => r < 20));

            //Distinct will return values that are distinct

            var Values = new List<int>() { 1, 2, 3, 3, 5, 5 };
            var distinctValues = Values.Distinct().ToList();
            foreach(var item_5 in distinctValues)
                Console.WriteLine(item_5);

            //except compares two list and return values that are not in the second list
            var newValue = new List<int>() { 2, 4, 7 };
            //var result = newValue.Except(Values);
            //foreach(var item_6 in result)
            //  Console.WriteLine(item_6);

            //intersect will compare two values but return values that are in both list
            var result = Values.Intersect(newValue).ToList();
            foreach(var item_7 in result)
                Console.WriteLine(item_7);

        }
    }
}
