using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using log4net.Config;

namespace LoggingConsoleUI.Helper
{
     public static class LoggerManager
        {
            public static readonly ILog logger = LogManager.GetLogger(typeof(LoggerManager));

            static LoggerManager()
            {
                XmlConfigurator.Configure();

            }
        }


   
}
