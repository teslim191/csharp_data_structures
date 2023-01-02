using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //arraylist are resizeable arrays can hold multiple  data types
            // bring in System.Collections to use ArrayList
            ArrayList aList = new ArrayList();
            //add items singly
            aList.Add("Bob");
            aList.Add(20);
            //get count of item
            Console.WriteLine("Count: {0}", aList.Count);
            // get capacity
            Console.WriteLine("Count: {0}", aList.Capacity);


            //add multiple items at once
            ArrayList aList2 = new ArrayList();
            aList2.AddRange(new Object[] { "Bob", "zigler", "adam", "king" });
            Console.WriteLine("Count:{0}", aList2.Count);

            //add an ArrayList into another
            //aList2.AddRange(aList);

            //sort arraylist
            //aList2.Sort();
            //reverse
            //aList2.Reverse();

            //insert data at a particular position
            aList2.Insert(4, "john");
            SortArray(aList2);

            //create an array that is made up of first two items of an existing array
            ArrayList Range = aList2.GetRange(0, 2);
            SortArray(Range);

            //remove a specific item using index position
            aList2.RemoveAt(4);

            //remove range of item
            aList2.RemoveRange(0, 4);

            //search for a match starting at a provided index

            Console.WriteLine("position of zigler is {0}", aList2.IndexOf("zigler",0));

            //working with dictionaries -- key-value pairs
            Dictionary<string, string> profile = new Dictionary<string, string>();
            //add key and value
            profile.Add("Name", "James Bond");
            profile.Add("Alias", "007");
            profile.Add("Email", "007@hismagesty.com");

            //remove key
            profile.Remove("Name");
            //check if key is present
            profile.ContainsKey("Alias");
            //get value of key
            profile.TryGetValue("Email", out string email);

            Console.WriteLine($"007 email is {email}");


            //loop through a dictionary using foreach loop
            foreach (KeyValuePair<string, string> item in profile)
            {
                Console.WriteLine("key: {0} - value:{1}", item.Key, item.Value);
            }

            //delete every items in a dictionary
            profile.Clear();

            //Queue

            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);

            //removes the first item in a queue
            queue.Dequeue();

            //look at the first item in a queue
            queue.Peek();

            foreach (object item in queue)
            {
                Console.WriteLine($"items: {item}");
            }

            //check if item is inside of a queue
            Console.WriteLine("is 1 present in queue?:{0}",queue.Contains(1));

            //copy queue to an array
            object[] queueArray = queue.ToArray();

            foreach (object item in queueArray)
            {
                Console.WriteLine("items--{0}", item);
            }            

            //clear queue
            queue.Clear();

            //stack -- last in, first out collection

            Stack stack = new Stack();
            //add items to a stack
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            //look at the first item
            stack.Peek();

            //to remove an item
            stack.Pop();
           
            //to check if an item exist
            
            Console.WriteLine("is item present? {0}", stack.Contains(10));

            //copy stack to an array
            object[] stackToArray = stack.ToArray();

            //clear stack
            stack.Clear();
            foreach (object item in stack)
            {
                Console.WriteLine("items--{0}", item);
            }
        }


        public static void SortArray(ArrayList names)
        {
            foreach (object item in names)
            {
                Console.WriteLine("class names: {0}", item);
            }
        }
    }
}
