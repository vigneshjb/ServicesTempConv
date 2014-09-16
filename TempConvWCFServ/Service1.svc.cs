using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

//Service Runs at port 50000. It provides methods to convert temperature between Celsius and fahrenheit

namespace TempConvWCFServ
{
    public class TempConvCore : IService1
    {
        public int c2f(int c)
        {
            double f = (c * 1.8) + 32;
            return (int)f;
        }

        public int f2c(int f)
        {
            double c = (f - 32) / 1.8;
            return (int)c;
        }
    }
}
