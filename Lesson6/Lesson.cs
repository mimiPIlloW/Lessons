using System.Globalization;

namespace Lesson7
{
    class Lesson
    {
        static void Main(string[] args)
        {
            NumberFormatInfo nmi = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ".",
            };

            ///////parse
            string str = "5.8"; 
            double a = double.Parse(str, nmi);
            Console.WriteLine(a);
            Console.WriteLine("////////");
            Console.WriteLine();

            /////try catch
            string str1 = "5";
            try
            {
                int b = Convert.ToInt32(str1);
                Console.WriteLine("Good");
            }
            catch (Exception)
            {
                Console.WriteLine("Bad");
                
            }


            //////tryparse
            string str2 = "5";

            int c;

            int.TryParse(str2, out c);

            Console.WriteLine("///////");
            Console.WriteLine();


            ///// bool tryparse
            string str3 = "5 fsddfsd fds";

            int d;

            bool result = int.TryParse(str3, out d);

            if (result)
            {
                Console.WriteLine("Good");
            }
            else
            {
                Console.WriteLine("Bad");
            }
        }
    }
}
