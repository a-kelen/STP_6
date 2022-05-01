﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace CalcServer
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(CalcInterfaces.CalcService))) {
                host.Open();
                Console.WriteLine("Service Hosted Sucessfully");
                Console.Read();
            }
        }
    }
}
