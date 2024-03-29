using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TheResturant
{
    public class Kitchen
    {
        public event EventHandler<OrderUpEventArgs> ?OrderUp;

        private List<List<string>> orders = new List<List<string>>();

        protected virtual void OnOrderUp(object sender, OrderUpEventArgs e)
        {
            OrderUp?.Invoke(sender, e);
        }

        public void OrderFinishedBeingPrepared()
        {
            List<string> finishedOrder = orders.Last();
            orders.RemoveAt(orders.Count - 1);
            Console.WriteLine("Order Up!");

            OrderUpEventArgs e = new OrderUpEventArgs(finishedOrder);
            OnOrderUp(this, e);
        }

        public void OnPlaceOrder(object sender, PlaceOrderEventArgs e)
        {
            Console.WriteLine("Order has been placed: ");
            foreach(var item in e.OrderContent)
            {
                Console.WriteLine(item);
            }
            orders.Add(e.OrderContent);
        }
    }
}
