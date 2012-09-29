using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using log4net;

//--------------------------------------------------------------------
// This implements the public interface for logging
// As an example.. I could call this directly, or I can call the interface
// If I published this to others, I'd ideally only publish the interface
//--------------------------------------------------------------------

namespace IEchoAndLoggingNS
{
    public class SpecificEchoer1 : IEchoAndLogging
    {
        // This allows simply the getting and setting of the string
        public string echoString { get; set; }

        public void doEcho() {
            Console.WriteLine( "I'm echoing: {0} \n from class {1}", echoString, this.ToString() );
        }
    }
}
