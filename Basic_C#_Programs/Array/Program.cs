using System;
using System.Collections.Generic;


namespace Array
{
    class Program
    {
        static void Main()
        {
            string[] stringArray = { "apple", "pear", "kiwi", "banana" };
            Console.WriteLine("Enter an index for string array");
            int index = Convert.ToInt32(Console.ReadLine());

            if (index<stringArray.Length)
            {
                Console.WriteLine(stringArray[index]);
            }
            else
            {
                nonIndex(index);
            }

            int[] intArray = { 40, 79, 2, 100584};
            Console.WriteLine("Enter an index for int array");
            index = Convert.ToInt32(Console.ReadLine());

            if (index < intArray.Length)
            {
                Console.WriteLine(intArray[index]);
            }
            else
            {
                nonIndex(index);
            }

            string[] stringList = { "cat", "mouse", "dog"};
            Console.WriteLine("Enter an index for string list");
            index = Convert.ToInt32(Console.ReadLine());

            if (index < stringList.Length)
            {
                Console.WriteLine(stringList[index]);
            }
            else
            {
                nonIndex(index);
            }



            Console.ReadLine();
        }

        static void nonIndex(int index)
        {
            Console.WriteLine("The index of " + index + " doesn't exist");
        }
    }
}
