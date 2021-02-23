using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentValueClassLibrary
{
    public static class Calculate
    {

        
        public static decimal CalcPresentValue(double yearInput, decimal endInput)
        {
            double interestRate = .04;

            return endInput / (decimal)Math.Pow((1 + interestRate), yearInput);
        }
    }
}
