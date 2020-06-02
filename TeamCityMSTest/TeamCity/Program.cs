using System;

namespace TeamCity
{
    public class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(Sum(2, 3));
        }

        public static int Sum(int a, int b)
        {
            return a + b;
        }
    }
}
