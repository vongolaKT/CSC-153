using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeightClassLibrary
{
    public class CalculateWeight
    {
        public static double WeightCalculation(ref double mass)
        {
            double weight;

            weight = mass * 9.8;

            return weight;
        }
    }
}
