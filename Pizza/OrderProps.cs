using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    public class Order
    {
        #region Properties   

        private List<OrderProps> _orderPropsLst;
        private string _orderTitle;
        private DateTime _orderTimestamp;
        private bool _orderClosed;

        public List<OrderProps> OrderPropsLst
        {
            get => _orderPropsLst;
            set => _orderPropsLst = value;
        }

        public string OrderTitle
        {
            get => _orderTitle;
            set => _orderTitle = value;
        }

        public DateTime OrderTimestamp
        {
            get => _orderTimestamp;
            set => _orderTimestamp = value;
        }

        public bool OrderClosed
        {
            get => _orderClosed;
            set => _orderClosed = value;
        }

        #endregion

        #region Constructors

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

        #endregion
    }

    public class OrderProps
    {
        #region Properties

        private string _customerName;
        private string _articles;
        private decimal _price;
        private decimal _discount;
        private decimal _credit;
        private decimal _priceWithDiscount;
        private decimal _pricePayed;
        private decimal _change;
        private decimal _tip;
        private bool _ordered;

        public string CustomerName
        {
            get
            {
                if (_customerName != string.Empty)
                {
                    return _customerName;
                }
                else
                {
                    return "Unbekannt";
                }
            }
            set
            {
                if (value != string.Empty)
                {
                    _customerName = value;
                }
                else
                {
                    _customerName = "Unbekannt";
                }

                OnControlValueChanged(EventArgs.Empty, "CustomerName");
            }
        }

        public string Articles
        {
            get
            {
                if (_articles != string.Empty)
                {
                    return _articles;
                }
                else
                {
                    return string.Empty;
                }
            }
            set
            {
                _articles = value;
                OnControlValueChanged(EventArgs.Empty, "Articles");
            }
        }

        public decimal Price
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

                OnControlValueChanged(EventArgs.Empty, "Price");
            }
        }

        public decimal Discount
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

                OnControlValueChanged(EventArgs.Empty, "Discount");
            }
        }

        public decimal PricePayed
        {
            get
            {
                return _pricePayed;
            }
            set
            {
                if (value < 0)
                {
                    _pricePayed = 0;
                }
                else
                {
                    _pricePayed = value;
                }

                OnControlValueChanged(EventArgs.Empty, "PricePayed");
            }
        }

        public decimal Tip
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

                OnControlValueChanged(EventArgs.Empty, "Tip");
            }
        }

        public decimal Change
        {
            get
            {
                return _change;
            }
            set
            {
                _change = value;
                OnControlValueChanged(EventArgs.Empty, "Change");
            }
        }

        public decimal Credit
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

                OnControlValueChanged(EventArgs.Empty, "Credit");
            }
        }

        public bool Ordered
        {
            get => _ordered;
            set
            {
                _ordered = value;
                OnControlValueChanged(EventArgs.Empty, "Ordered");
            }
        }

        public decimal PriceWithDiscount
        {
            get => _priceWithDiscount;
            set
            {
                _priceWithDiscount = value;
                OnControlValueChanged(EventArgs.Empty, "PriceWithDiscount");
            }
        }

        #endregion

        #region Constructors

        public OrderProps()
        {
            this.CustomerName = String.Empty;
            this.Articles = String.Empty;
            this.Price = 0.00m;
            this.Discount = 0.00m;
            this.PricePayed = 0.00m;
            this.Tip = 0.00m;
            this.Change = 0.00m;
            this.Credit = 0.00m;
            this.Ordered = false;
            this.PriceWithDiscount = 0.00m;
        }

        public OrderProps(string customerName)
        {
            this.CustomerName = customerName;
            this.Articles = String.Empty;
            this.Price = 0.00m;
            this.Discount = 0.00m;
            this.PricePayed = 0.00m;
            this.Tip = 0.00m;
            this.Change = 0.00m;
            this.Credit = 0.00m;
            this.Ordered = false;
            this.PriceWithDiscount = 0.00m;
        }

        #endregion

        #region EventHandler

        public event EventHandler ControlValueChanged;

        protected virtual void OnControlValueChanged(EventArgs e, string propertyName)
        {
            EventHandler controlValueChanged = ControlValueChanged;

            if (controlValueChanged != null)
            {
                controlValueChanged(propertyName, e);
            }
        }

        #endregion
    }
}