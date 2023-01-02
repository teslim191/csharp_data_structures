using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods_enum
{
    class Program
    {
        static void Main(string[] args)
        {
            //double x = 5;
            //double y = 6;
            //Console.WriteLine("5 + 6 = {0}",GetSum(x,y)); 

            int solution;
            DoubleIt(15, out solution);
            Console.WriteLine("15 * 2 = {0}",solution);

            int num1 = 10;
            int num2 = 11;

            Console.WriteLine("before ref--num1: {0} num2: {1}",num1,num2);

            GetResult(ref num1, ref num2);
            Console.WriteLine("after ref--num1: {0} num2: {1}", num1, num2);


            Console.WriteLine("the sum of 1+2+3={0}",GetSomeMore(1,2,3));

            //you can switch arguments
            GetDetails(zipcode: 5132, name: "james");

            
            Console.WriteLine("the sum of 2.0 + 7.0={0}", GetSum("2.0", "7.0").GetType());


            //enum result
            CarColor car1 = CarColor.green;
            PaintColor(car1);

    

        }

        static double GetSum(double x=1, double y = 1)
        {
            double temp = x;
            x = y;
            y = temp;
            return x + y;
        }

        //working with out parameters

        static void DoubleIt(int x, out int solution)
        {
            solution = x * 2;
        }

        //working with ref parameters

        public static void GetResult(ref int num1, ref int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
        }

        //params
        static double GetSomeMore(params double[] data)
        {
            int sum = 0;
            foreach (int item in data)
            {
                sum += item;
            }
            return sum;
        }

        //named params
        public static void GetDetails(string name, int zipcode)
        {
            Console.WriteLine("{0} lives at number {1}", name, zipcode);
        }

        //method overload

        static double GetSum(int x = 1, int y = 2)
        {
            return x + y;

        }

        static double GetSum(string x="1", string y = "2")
        {
            double dblX = Convert.ToDouble(x);
            double dblY = Convert.ToDouble(y);
            return dblX + dblY;
        }

        //enum
        enum CarColor: byte
        {
            orange = 1,
            red,
            green,
            blue
        }

        static void PaintColor(CarColor cc)
        {
            Console.WriteLine("the car with the color code {0} was painted {1}", (int)cc, cc);
        }
   
    }
}
