using System;

namespace Bullet_Proof
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = CheckDouble();
            int y = CheckInt();
        }
        static double CheckDouble()
        {
            double x = 0;
            bool succeed = false;
            while (succeed == false)
            {
                try
                {
                    Console.WriteLine("Enter a double:");
                    x = double.Parse(Console.ReadLine());
                    succeed = true;
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return x;
        }
        static int CheckInt()
        {
            int x = 0;
            bool succeed = false;
            while (succeed == false)
            {
                try
                {
                    Console.WriteLine("Enter an integer:");
                    x = int.Parse(Console.ReadLine());
                    succeed = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return x;
        }
    }
}
