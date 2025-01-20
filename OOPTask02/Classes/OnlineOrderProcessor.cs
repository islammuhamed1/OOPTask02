using OOPTask02.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTask02.Classes
{
    internal class OnlineOrderProcessor : IOrderProcessor
    {
        public void ProcessOrder()
        {
            Console.WriteLine("Processes orders placed online.");
        }

        public decimal Discount(decimal amount)
        {
            return amount * 0.10m; 
        }
    }
}
