using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ay daxil edin:");
            string ay = Console.ReadLine();            
            switch (ay)
            {
                case "yanvar":
                    Console.WriteLine("31 gun var");
                    break;
                case "fevral":
                    Console.WriteLine("28 gun var");
                    break;
                case "mart":
                    Console.WriteLine("31 gun var");
                    break;
                case "aprel":
                    Console.WriteLine("30 gun var");
                    break;
                case "may":
                    Console.WriteLine("31 gun var");
                    break;
                case "iyun":
                    Console.WriteLine("30 gun var");
                    break;
                case "iyul":
                    Console.WriteLine("31 gun var");
                    break;
                case "avqust":
                    Console.WriteLine("31 gun var");
                    break;
                case "sentyabr":
                    Console.WriteLine("30 gun var");
                    break;
                case "oktyabr":
                    Console.WriteLine("31 gun var");
                    break;
                case "noyabr":
                    Console.WriteLine("30 gun var");
                    break;
                case "dekabr":
                    Console.WriteLine("31 gun var");
                    break;
                default:
                    Console.WriteLine("bele ay yoxdur");
                    break;
            }
            Console.ReadLine();
        }
    }
}
