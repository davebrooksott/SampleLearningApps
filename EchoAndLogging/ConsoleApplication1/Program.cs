using System;
using System.Collections.Generic;
using System.Text;

using IEchoAndLoggingNS;


namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IEchoAndLogging inputString = GetEchoer.getEchoer();

            Console.WriteLine("Hello World");
            inputString.echoString = Console.ReadLine();
            inputString.doEcho();
            Console.ReadLine();
        }
    }
}
