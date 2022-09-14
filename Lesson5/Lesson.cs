using System;
using System.Globalization;


namespace Lesson5
{
    class Lesson
    {
        static void Main(string[] args)
        {
            String data;
            data = Console.ReadLine();

            Console.WriteLine("data {0}", data);

            //convert
            int b = 5;
            int a = Convert.ToInt32(data);
            Console.WriteLine("sum {0}", a + b);
            Console.WriteLine();

            //
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("age {0}", age);

        }
    }
}
