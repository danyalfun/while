using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Task1()
        {
            int num;
            int cunt = 0;
            while (cunt != 3)
            {
                Console.WriteLine("enter a number");
                num = int.Parse(Console.ReadLine());
                if (num%2 == 0)
                    cunt++ ;
            }
            Console.WriteLine("finally");
                
        }
        static void Task2()
        {
            int sam = 0;
            int pr;
            int min = int.MaxValue;
            int max = int.MinValue;
            while (sam < 100)
            {
                Console.WriteLine("enter a price :");
                pr = int.Parse(Console.ReadLine());
                sam = sam + pr;
                if (min > pr || sam == 0) { min = pr; }
                if (max < pr || sam == 0) { max = pr; }
            }
            Console.WriteLine("totl sam: " + sam);
            Console.WriteLine("min: " + min);
            Console.WriteLine("max: " + max);
        }
        static void Task3()
        {
            int sam = 0;
            int num = 0;
            int cunt = 0;
            while (num != -1)
            {
                cunt++;
                Console.WriteLine("enter num -1 to stop");
                num= int.Parse(Console.ReadLine());
                sam = sam + num;
            }
            Console.WriteLine("the of the" + cunt +  "avreg is : " + (sam / cunt));
        }
        static void Main(string[] args)
        {
            //Task1();
            //Task2();
            Task3();
        }
    }
}
