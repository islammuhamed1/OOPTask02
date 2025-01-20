using OOPTask02.Classes;
using OOPTask02.Interfaces;

namespace OOPTask02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("OrderID:");
            int orderId = int.Parse(Console.ReadLine());

            Console.WriteLine("CustomerName:");
            string customerName = Console.ReadLine();

            Console.WriteLine("OrderAmount:");
            decimal orderAmount = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Choose Between Online / In-Store");
            string orderType = Console.ReadLine();
            IOrderProcessor orderProcessor = OrderDetails(orderType);

            Order order = new Order(orderId, customerName, orderAmount, orderProcessor);
            order.DisplayAndOrderProcess();

        }
        public static IOrderProcessor OrderDetails(string orderType)
        {
            if (orderType.ToLower() == "online")
            {
                return new OnlineOrderProcessor();
            }
            else if (orderType.ToLower() == "in-store")
            {
                return new InStoreOrderProcessor();
            }
            else
            {
                Console.WriteLine("You have entered a wrong value. Please enter 'online' or 'in-store'.");
                return null;
            }
        }

    }
}
