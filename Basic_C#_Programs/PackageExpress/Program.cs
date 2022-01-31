using System;

namespace PackageExpress
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Packae Express! Please follow instructions below.");
            Console.WriteLine("Please wnter the package weight:");
            float weight = float.Parse(Console.ReadLine());
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                Console.WriteLine("Please enter package width:");
                float width = float.Parse(Console.ReadLine());
                Console.WriteLine("Please enter package height:");
                float height = float.Parse(Console.ReadLine());
                Console.WriteLine("Please enter package length:");
                float length = float.Parse(Console.ReadLine());

                if ((length + height + width) > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express. Have a good day.");
                }
                else
                {
                    float dimension = width * height * length;
                    float quote = dimension * weight / 100;

                    Console.WriteLine("Your estimated total for shipping this package is: $" + quote + "\n Thank you!");
                }
            }

            Console.ReadLine();
        }
    }
}
