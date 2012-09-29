using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Configuration;


namespace IEchoAndLoggingNS
{
    public class GetEchoer
    {
        public static IEchoAndLogging getEchoer()
        {
            // Read a config file to get the echoer type
            string echoer = "Echoer.config";
            AppSettingsReader ar = new AppSettingsReader();
            echoer = (string) ar.GetValue("EchoerType", typeof(string));

            // echoer = ConfigurationSettings.AppSettings.GetHashCode("EchoerType");

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
