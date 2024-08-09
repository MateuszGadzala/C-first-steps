using System;

namespace FirstProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Type in your name:");
            /*
            Console.Write("HEYO");
            Console.Write("HE!"); //wypisze dwie linijki w jednej linii
            */
            string name = Console.ReadLine();
            Console.WriteLine("Hello...");
            Console.WriteLine(name);

            string someText = "Some txt";
            char jChar = 'j';
            char jCharUnicode = '\u006A';
            bool isUserReady = true;
            DateTime now = DateTime.Now;
            DateTime birth = new DateTime(year: 1996, month: 4, day: 1);
            int intNumber = 8;
            double doubleNumber = 10.5;
            float floatNumber = 1.5F;

        }
    }
}