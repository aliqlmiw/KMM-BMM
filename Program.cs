using System;
using System.Runtime.InteropServices;

namespace project
{
    class Test
    {
        public static void Main()
        {
            /********ALI*GHOLAMI*********/
            Console.WriteLine("please enter x & y:");
            Console.Write("x = ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("y = ");
            int y = Convert.ToInt32(Console.ReadLine());
            kmm (x, y);
            bmm (x, y);
        }
        private static void kmm (int x, int y)
        {
            int temp = 1;
            for (int i = 1; i <= x && i <= y; i++)
            {
                if (x % i == 0 && y % i == 0)
                {
                    temp = i;
                }
            }
            int kmm = (x * y) / temp;
            Console.WriteLine("K M M = {0}", kmm);
        }
        private static void bmm(int x, int y)
        {
            int temp = 1;
            for (int i = 1; i <= x && i <= y; i++)
            {
                if (x % i == 0 && y % i == 0)
                {
                    temp = i;
                }
            }

            Console.WriteLine("B M M = {0}",temp);
        }
    }
}