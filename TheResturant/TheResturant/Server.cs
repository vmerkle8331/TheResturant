using System;
using System.Collections.Generic;
using System.Text;

namespace TheResturant
{
    public class Server
    {
        public delegate void PlaceOrderEventHandler(object sender, PlaceOrderEventArgs e);
        public event PlaceOrderEventHandler ?PlaceOrder;

        protected virtual void OnPlaceOrder(object sender, PlaceOrderEventArgs e)
        {
            PlaceOrderEventHandler ?handler = PlaceOrder;
            if(handler != null)
            {
                handler(sender, e);
            }
        }

        public void TakeAnOrder()
        {
            List<string> newOrder = new List<string>();
            newOrder.Add("nuggiez");
            newOrder.Add("Watered-down beer");

            PlaceOrderEventArgs args = new PlaceOrderEventArgs(newOrder);
            OnPlaceOrder(this, args);
        }

        public void OnOrderUp(object sender, OrderUpEventArgs e)
        {
            Console.WriteLine("Server picks up order and delivers: ");
            foreach(var item in e.OrderContent)
            {
                Console.WriteLine(item);
            }
        }
    }
}
