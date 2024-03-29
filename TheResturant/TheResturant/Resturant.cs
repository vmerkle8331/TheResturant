using System;
using System.Collections.Generic;
using System.Text;

namespace TheResturant
{
    public class Resturant
    {
        Kitchen kitchen = new Kitchen();
        Server joe = new Server();

        public Resturant()
        {
            joe.PlaceOrder += kitchen.OnPlaceOrder;
            kitchen.OrderUp += joe.OnOrderUp;
            joe.TakeAnOrder();
            kitchen.OrderFinishedBeingPrepared();
        }
        
    }
}
