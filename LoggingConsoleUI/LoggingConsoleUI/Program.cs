using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingConsoleUI
{

    class Program
    {
        static void Main(string[] args)
        {
            Helper.LoggerManager.logger.Info("Main function started");
            Console.WriteLine("Logging using log4net framework");
            Console.ReadLine();

        }
    }
}
