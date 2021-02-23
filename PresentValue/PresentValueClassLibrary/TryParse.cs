using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentValueClassLibrary
{
    public static class TryParse
    {
        public static double ParseToDouble(string input)
        {
            double output;

            if (double.TryParse(input, out output))
            {
                return output;
            }
            else 
            {
                return 0;
            }
            
        }

        public static decimal ParseToDecimal(string input)
        {
            decimal output;

            if (decimal.TryParse(input, out output))
            {
                return output;
            }
            else
            {
                return 0;
            }

        }

    }
}
