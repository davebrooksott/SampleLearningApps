using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Configuration;
using log4net;
using log4net.Config;

namespace IEchoAndLoggingNS
{
    public class GetEchoer
    {
        // setup log4net
        private static ILog _log = LogManager.GetLogger(typeof(GetEchoer));
        private static string _loggerConfigFile = "";

        public static IEchoAndLogging getEchoer()
        {   
            // Read a config file to get the echoer type
            string echoer = "Echoer.config";
            AppSettingsReader ar = new AppSettingsReader();
            echoer = (string) ar.GetValue("EchoerType", typeof(string));
            _log.Info("Selected "+ echoer);

            if (echoer == "EchoerModel1")
            {

                return new SpecificEchoer1();
            }
            else
            {

                return new SpecificEchoer2();
            }
        }
    }
}
