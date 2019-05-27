using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech;

namespace View_Console
{
    class Program
    {
        private const string Value = "dfrff";

        static void Main(string[] args)
        {
            Console.Write("Hello!!!");
            Console.Write("Katoikia:");
            string b = Console.ReadLine();
            Console.Write("Hlikia:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("H Hlikia mou einai: {0}",a);

            Console.WriteLine($"H ilikia mou einai {a} kai katoikw ston {b}");
            Console.WriteLine("The end");
        }
    }
}
