using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    public class Orders
    {
        private List<OrderProps> orderPropsLst;

        private string orderTitle;
        private DateTime orderTimestamp;
        private bool orderClosed;
        private float orderSum;
        private float orderSumWithDiscount;
        private float orderSumPayed;

        public Orders()
        {
            OrderPropsLst = new List<OrderProps>();
            OrderTimestamp = DateTime.Now;
        }

        public Orders(List<OrderProps> tmp)
        {
            OrderPropsLst = tmp;
            OrderTimestamp = DateTime.Now;
        }

        public string OrderTitle
        {
            get => orderTitle; set => orderTitle = value;
        }
        public DateTime OrderTimestamp
        {
            get => orderTimestamp; set => orderTimestamp = value;
        }
        public bool OrderClosed
        {
            get => orderClosed; set => orderClosed = value;
        }
        public float OrderSum
        {
            get => orderSum; set => orderSum = value;
        }
        public float OrderSumWithDiscount
        {
            get => orderSumWithDiscount; set => orderSumWithDiscount = value;
        }
        public float OrderSumPayed
        {
            get => orderSumPayed; set => orderSumPayed = value;
        }
        public List<OrderProps> OrderPropsLst
        {
            get => orderPropsLst; set => orderPropsLst = value;
        }
    }

    public class OrderProps
    {
        private string customerName;
        private string articles;
        private bool ordered;
        private float price;
        private float discount;
        private float payed;
        private float tip;
        private float change;
        private float credit;

        public OrderProps()
        {

        }

        public OrderProps(string CustomerName, string Articles)
        {
            this.customerName = CustomerName;
            this.articles = Articles;
        }

        public string CustomerName
        {
            get
            {
                if (customerName == string.Empty)
                {
                    return "Unbekannt";
                }
                else
                {
                    return customerName;
                }
            }
            set
            {
                if (value == string.Empty)
                {
                    customerName = "Unbekannt";
                }
                else
                {
                    customerName = value;
                }
            }
        }

        public string Articles
        {
            get
            {
                if (articles == string.Empty)
                {
                    return "-";
                }
                else
                {
                    return articles;
                }
            }
            set
            {
                articles = value;
            }
        }

        public bool Ordered
        {
            get
            {
                return ordered;
            }
            set
            {
                ordered = value;
            }
        }

        public float Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value < 0)
                {
                    price = 0;
                }
                else
                {
                    price = value;
                }
            }
        }

        public float Discount
        {
            get
            {
                return discount;
            }
            set
            {
                if (value < 0)
                {
                    discount = 0;
                }
                else
                {
                    discount = value;
                }
            }
        }

        public float Payed
        {
            get
            {
                return payed;
            }
            set
            {
                if (value < 0)
                {
                    payed = 0;
                }
                else
                {
                    payed = value;
                }
            }
        }

        public float Tip
        {
            get
            {
                return tip;
            }
            set
            {
                if (value < 0)
                {
                    tip = 0;
                }
                else
                {
                    tip = value;
                }
            }
        }

        public float Change
        {
            get
            {
                return change;
            }
            set
            {
                if (value < 0)
                {
                    change = 0;
                }
                else
                {
                    change = value;
                }
            }
        }

        public float Credit
        {
            get
            {
                return credit;
            }
            set
            {
                if (value < 0)
                {
                    credit = 0;
                }
                else
                {
                    credit = value;
                }
            }
        }
    }
}