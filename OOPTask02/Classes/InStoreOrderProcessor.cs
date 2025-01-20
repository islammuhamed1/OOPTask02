using OOPTask02.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTask02.Classes
{
    internal class InStoreOrderProcessor : IOrderProcessor
    {
        public void ProcessOrder()
        {
            Console.WriteLine("Processes orders placed in physical");
        }

        public decimal Discount(decimal amount)
        {
            return amount * 0.05m; 
        }
    }
}
