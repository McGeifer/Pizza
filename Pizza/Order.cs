using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Pizza
{
    public class Order
    {
        private List<CustomerProps> customerPropsLst;

        private string      orderTitle;
        private DateTime    orderTimestamp;
        private bool        orderClosed;
        private float       orderSum;
        private float       orderSumWithDiscount;
        private float       orderSumPayed;

        public Order()
        {
            customerPropsLst = new List<CustomerProps>();
            OrderTimestamp = DateTime.Now;
        }

        public Order(List<CustomerProps> tmp)
        {
            customerPropsLst = tmp;
            OrderTimestamp = DateTime.Now;
        }

        public string OrderTitle { get => orderTitle; set => orderTitle = value; }
        public DateTime OrderTimestamp { get => orderTimestamp; set => orderTimestamp = value; }
        public bool OrderClosed { get => orderClosed; set => orderClosed = value; }
        public float OrderSum { get => orderSum; set => orderSum = value; }
        public float OrderSumWithDiscount { get => orderSumWithDiscount; set => orderSumWithDiscount = value; }
        public float OrderSumPayed { get => orderSumPayed; set => orderSumPayed = value; }
        public List<CustomerProps> CustomerPropsLst { get => customerPropsLst; set => customerPropsLst = value; }
    }

    
}
