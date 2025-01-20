using OOPTask02.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTask02.Classes
{
    internal class Order
    {
        public int OrderId { get; set; }
        public string CustomerName { get; set; }
        public decimal OrderAmount { get; set; }
        public IOrderProcessor OrderProcessor { get; set; }
        public Order(int orderId, string customerName, decimal orderAmount, IOrderProcessor orderProcessor)
        {
            OrderId = orderId;
            CustomerName = customerName;
            OrderAmount = orderAmount;
            OrderProcessor = orderProcessor;
        }
    
        public void DisplayAndOrderProcess()
        {
            OrderProcessor.ProcessOrder();
            decimal discount = OrderProcessor.Discount(OrderAmount);
            decimal latestPrice = OrderAmount - discount;
            Console.WriteLine($"OrderNumber {OrderId} processed for {CustomerName} Total After Discound: {latestPrice:F2}");

        }


    }
}
