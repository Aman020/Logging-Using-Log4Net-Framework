using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingConsoleUI
{
    public class Calculation
    {

        public int add(int a, int b)
        {

            return a + b;

        }
        public int divide(int numerator, int denominator)
        {
            Helper.LoggerManager.logger.Info("divide function");
            try
            {
                return numerator / denominator;
            }
            catch (Exception ex)
            {
                Helper.LoggerManager.logger.Error(ex.Message);
                return 0;
            }

        }
    }
}
