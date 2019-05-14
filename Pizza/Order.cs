using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    class Order
    {
        private Customer customer;

        private string      orderTitel;
        private DateTime    orderTimestamp;
        private bool        orderClosed;
        private float       orderSum;
        private float       orderSumWithDiscount;
        private float       orderSumPayed;

        public Order()
        {
            customer = new Customer();       
        }

        public Order(Customer tmp)
        {
            customer = tmp;
        }

        public string OrderTitel { get => orderTitel; set => orderTitel = value; }
        public DateTime OrderTimestamp { get => orderTimestamp; set => orderTimestamp = value; }
        public bool OrderClosed { get => orderClosed; set => orderClosed = value; }
        public float OrderSum { get => orderSum; set => orderSum = value; }
        public float OrderSumWithDiscount { get => orderSumWithDiscount; set => orderSumWithDiscount = value; }
        public float OrderSumPayed { get => orderSumPayed; set => orderSumPayed = value; }
    }
}
