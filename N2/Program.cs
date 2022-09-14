namespace N2
{
    class N2
    {
        static void Main(string[] args)
        {


            Console.WriteLine("If you want to convert dollar to euro pass 1");
            Console.WriteLine("If you want to convert euro to dollar pass 2");

            string str = Console.ReadLine();
            int a = Convert.ToInt32(str);

            while ((a == 1 || a == 2) || !(a==1 || a==2))
            {
                if (a == 1)
                {
                    Console.Write("Enter dollar = ");

                    string dollar = Console.ReadLine();
                    int d = Convert.ToInt32(dollar);
                    double resutEuro = d * 0.86;
                    Console.WriteLine("Euro {0}", resutEuro);
                    break;
                }
                else if (a == 2)
                {
                    Console.Write("Enter euro = ");

                    string euro = Console.ReadLine();
                    int e = Convert.ToInt32(euro);
                    double resutDollar = e * 1.16;
                    Console.WriteLine("Euro {0}", resutDollar);
                    break;
                                
                }
                else
                {
                    Console.WriteLine("You enter incorrect number");
                    str = Console.ReadLine();
                    a = Convert.ToInt32(str);
                }
            }
        }
    }
}