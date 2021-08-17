using System;

namespace cp4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            calc();
        }
        static void calc()

        {
            Console.WriteLine("Ilk ededi daxil et : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ikinci  ededi daxil et : ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("emeliyyati secin + ; - : * ; /");
            string emeliyyat = Console.ReadLine();

            if (emeliyyat == "+")
            {
                Console.WriteLine(num1+num2);
            }
            else if (emeliyyat == "-")
            {
                Console.WriteLine(num1-num2);
            }
            else if (emeliyyat == "*")
            {
                Console.WriteLine(num1*num2);
            }
            else if (emeliyyat == "/")
            {
                Console.WriteLine(num1/num2);
            }
            else
            {
                Console.WriteLine("Duzgun emeliyyat daxil edin ");
            }



        }
    }
}
