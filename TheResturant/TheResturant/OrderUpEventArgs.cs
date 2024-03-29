using System;
using System.Collections.Generic;
using System.Text;

namespace TheResturant
{
    public class OrderUpEventArgs : EventArgs
    {
        List<string> orderContent = new List<string>();

        public OrderUpEventArgs(List<string> orderContent)
        {
            this.orderContent = orderContent;

        }

        public List<string>? OrderContent
        {
            get
            {
                return orderContent;
            }
        }
    }
}
