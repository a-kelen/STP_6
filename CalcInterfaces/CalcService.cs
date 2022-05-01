using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CalcInterfaces
{
    public class CalcService : ICalcService
    {
        public string DecimalToBinary(int number)
        {
            return Convert.ToString(number, 2);
        }
    }
}
