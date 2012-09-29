using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using log4net;

namespace IEchoAndLoggingNS
{
    public class SpecificEchoer2 : IEchoAndLogging
    {
        // This allows simply the getting and setting of the string
        public string echoString { get; set; }

        public void doEcho() {
            Console.WriteLine( "I'm echoing: {0} \n from class {1}", echoString, this.ToString() );
        }
    }
}
