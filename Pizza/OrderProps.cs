using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    public class Order
    {
        private List<OrderProps> _orderPropsLst;

        private string _orderTitle;
        private DateTime _orderTimestamp;
        private bool _orderClosed;
        private float _orderSum;
        private float _orderSumWithDiscount;
        private float _orderSumPayed;

        public Order()
        {
            OrderPropsLst = new List<OrderProps>();
            OrderTimestamp = DateTime.Now;
        }

        public Order(List<OrderProps> tmp)
        {
            OrderPropsLst = tmp;
            OrderTimestamp = DateTime.Now;
        }

        public string OrderTitle
        {
            get => _orderTitle; set => _orderTitle = value;
        }
        public DateTime OrderTimestamp
        {
            get => _orderTimestamp; set => _orderTimestamp = value;
        }
        public bool OrderClosed
        {
            get => _orderClosed; set => _orderClosed = value;
        }
        public float OrderSum
        {
            get => _orderSum; set => _orderSum = value;
        }
        public float OrderSumWithDiscount
        {
            get => _orderSumWithDiscount; set => _orderSumWithDiscount = value;
        }
        public float OrderSumPayed
        {
            get => _orderSumPayed; set => _orderSumPayed = value;
        }
        public List<OrderProps> OrderPropsLst
        {
            get => _orderPropsLst; set => _orderPropsLst = value;
        }
    }

    public class OrderProps
    {
        private string _customerName;
        private string _articles;
        private bool _ordered;
        private float _price;
        private float _discount;
        private float _payed;
        private float _tip;
        private float _change;
        private float _credit;

        public OrderProps()
        {

        }

        public OrderProps(string CustomerName, string Articles)
        {
            this._customerName = CustomerName;
            this._articles = Articles;
        }

        public string CustomerName
        {
            get
            {
                if (_customerName == string.Empty)
                {
                    return "Unbekannt";
                }
                else
                {
                    return _customerName;
                }
            }
            set
            {
                if (value == string.Empty)
                {
                    _customerName = "Unbekannt";
                }
                else
                {
                    _customerName = value;
                }
            }
        }

        public string Articles
        {
            get
            {
                if (_articles == string.Empty)
                {
                    return "-";
                }
                else
                {
                    return _articles;
                }
            }
            set
            {
                _articles = value;
            }
        }

        public bool Ordered
        {
            get
            {
                return _ordered;
            }
            set
            {
                _ordered = value;
            }
        }

        public float Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value < 0)
                {
                    _price = 0;
                }
                else
                {
                    _price = value;
                }
            }
        }

        public float Discount
        {
            get
            {
                return _discount;
            }
            set
            {
                if (value < 0)
                {
                    _discount = 0;
                }
                else
                {
                    _discount = value;
                }
            }
        }

        public float Payed
        {
            get
            {
                return _payed;
            }
            set
            {
                if (value < 0)
                {
                    _payed = 0;
                }
                else
                {
                    _payed = value;
                }
            }
        }

        public float Tip
        {
            get
            {
                return _tip;
            }
            set
            {
                if (value < 0)
                {
                    _tip = 0;
                }
                else
                {
                    _tip = value;
                }
            }
        }

        public float Change
        {
            get
            {
                return _change;
            }
            set
            {
                if (value < 0)
                {
                    _change = 0;
                }
                else
                {
                    _change = value;
                }
            }
        }

        public float Credit
        {
            get
            {
                return _credit;
            }
            set
            {
                if (value < 0)
                {
                    _credit = 0;
                }
                else
                {
                    _credit = value;
                }
            }
        }
    }
}