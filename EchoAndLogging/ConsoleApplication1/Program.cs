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
            IEchoAndLogging echoer = GetEchoer.getEchoer();

            Console.WriteLine("Hello World");
            echoer.echoString = Console.ReadLine();
            echoer.doEcho();
            Console.ReadLine();
        }
    }
}
