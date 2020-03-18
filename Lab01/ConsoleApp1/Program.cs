using System;

namespace ConsoleApp1
{
    class Program
    {
        private const string V = "Hello World!";
        private const string V1 = " My Name is Nicholas Lemke!";
       

        static void Main(string[] args)
        {
            string V100 = V1;
            string V50 = V;
            string str = $"{V}{V1} ";
                System.Console.WriteLine(str);
           System.Console.ReadKey();
        }
    }
}
