using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTask02.Interfaces
{
    internal interface IOrderProcessor
    {
         void ProcessOrder();
         decimal Discount(decimal orderAmount);
    }
}
