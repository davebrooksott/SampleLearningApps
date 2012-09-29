using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


//--------------------------------------------------------------------
// Define a public interface for echoing to the screen
//--------------------------------------------------------------------

namespace IEchoAndLoggingNS
{
    public interface IEchoAndLogging
    {
        string echoString { get; set; }

        void doEcho();
    }

}
