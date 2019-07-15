using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza
{
    public partial class FameAndShameForm : Form
    {
        const int MinOrderCount = 5; // minimum number of orders to enter the hall of fame and shame
        private List<Order> _ordersLst = new List<Order>();
        private List<FameAndShameProps> _fameAndShamePropsLst = new List<FameAndShameProps>();

        internal List<Order> OrdersLst
        {
            get => _ordersLst;
            set => _ordersLst = value;
        }

        internal List<FameAndShameProps> FameAndShamePropsLst
        {
            get => _fameAndShamePropsLst;
            set => _fameAndShamePropsLst = value;
        }

        public FameAndShameForm(List<Order> ordersLst)
        {
            InitializeComponent();
            OrdersLst = ordersLst;
            this.Shown += new System.EventHandler(this.FameAndShameForm_Shown);
        }

        private void GetUserStats()
        {
            List<FameAndShameProps> _tmpLst = new List<FameAndShameProps>();

            foreach (Order order in OrdersLst)
            {
                foreach (OrderProps orderProps in order.OrderPropsLst)
                {
                    if (orderProps.Price > 0 && !orderProps.Articles.Equals(String.Empty))
                    {
                        int customerIdx = _tmpLst.FindIndex(i => i.CustomerName.Equals(orderProps.CustomerName));

                        if (customerIdx == -1)
                        {
                            _tmpLst.Add(new FameAndShameProps(orderProps.CustomerName));
                            customerIdx = _tmpLst.Count() - 1;
                        }

                        _tmpLst[customerIdx].OrderCount++;
                        _tmpLst[customerIdx].OrderSum += orderProps.Price;
                        _tmpLst[customerIdx].TipSum += orderProps.Tip;

                        if (_tmpLst[customerIdx].OrderCount > 0)
                        {
                            _tmpLst[customerIdx].MeanOrderSum =
                                _tmpLst[customerIdx].OrderSum / _tmpLst[customerIdx].OrderCount;
                        }

                        if (_tmpLst[customerIdx].OrderSum > 0)
                        {
                            _tmpLst[customerIdx].MeanTip =
                                 _tmpLst[customerIdx].TipSum / _tmpLst[customerIdx].OrderSum;
                        }
                    }
                }
            }

            foreach (FameAndShameProps fameAndShameProp in _tmpLst)
            {
                if (fameAndShameProp.OrderCount >= MinOrderCount)
                {
                    FameAndShamePropsLst.Add(fameAndShameProp);
                }
            }
        }

        private void MeanTip()
        {
            FameAndShamePropsLst.Sort((x, y) => y.MeanTip.CompareTo(x.MeanTip));

            labelFameTip.Text =
                "1. " + FameAndShamePropsLst[0].CustomerName + " - " + FameAndShamePropsLst[0].MeanTip.ToString("P") + Environment.NewLine +
                "2. " + FameAndShamePropsLst[1].CustomerName + " - " + FameAndShamePropsLst[1].MeanTip.ToString("P") + Environment.NewLine +
                "3. " + FameAndShamePropsLst[2].CustomerName + " - " + FameAndShamePropsLst[2].MeanTip.ToString("P");

            FameAndShamePropsLst.Sort((x, y) => x.MeanTip.CompareTo(y.MeanTip));

            labelShameTip.Text =
                "1. " + FameAndShamePropsLst[0].CustomerName + " - " + FameAndShamePropsLst[0].MeanTip.ToString("P") + Environment.NewLine +
                "2. " + FameAndShamePropsLst[1].CustomerName + " - " + FameAndShamePropsLst[1].MeanTip.ToString("P") + Environment.NewLine +
                "3. " + FameAndShamePropsLst[2].CustomerName + " - " + FameAndShamePropsLst[2].MeanTip.ToString("P");
        }

        private void MeanOrderPrice()
        {
            FameAndShamePropsLst.Sort((x, y) => y.MeanOrderSum.CompareTo(x.MeanOrderSum));

            labelFameOrderSum.Text =
                "1. " + FameAndShamePropsLst[0].CustomerName + " - " + FameAndShamePropsLst[0].MeanOrderSum.ToString("N2") + " € " + Environment.NewLine +
                "2. " + FameAndShamePropsLst[1].CustomerName + " - " + FameAndShamePropsLst[1].MeanOrderSum.ToString("N2") + " € " + Environment.NewLine +
                "3. " + FameAndShamePropsLst[2].CustomerName + " - " + FameAndShamePropsLst[2].MeanOrderSum.ToString("N2") + " € ";
                                                                                                                      
            FameAndShamePropsLst.Sort((x, y) => x.MeanOrderSum.CompareTo(y.MeanOrderSum));                            
                                                                                                                      
            labelShameOrderSum.Text =                                                                                 
                "1. " + FameAndShamePropsLst[0].CustomerName + " - " + FameAndShamePropsLst[0].MeanOrderSum.ToString("N2") + " € " + Environment.NewLine +
                "2. " + FameAndShamePropsLst[1].CustomerName + " - " + FameAndShamePropsLst[1].MeanOrderSum.ToString("N2") + " € " + Environment.NewLine +
                "3. " + FameAndShamePropsLst[2].CustomerName + " - " + FameAndShamePropsLst[2].MeanOrderSum.ToString("N2") + " € ";
        }

        private void NumberOfOrders()
        {
            FameAndShamePropsLst.Sort((x, y) => y.OrderCount.CompareTo(x.OrderCount));

            labelFameOrderCount.Text =
                "1. " + FameAndShamePropsLst[0].CustomerName + " - " + FameAndShamePropsLst[0].OrderCount.ToString("D") + Environment.NewLine +
                "2. " + FameAndShamePropsLst[1].CustomerName + " - " + FameAndShamePropsLst[1].OrderCount.ToString("D") + Environment.NewLine +
                "3. " + FameAndShamePropsLst[2].CustomerName + " - " + FameAndShamePropsLst[2].OrderCount.ToString("D");
                                                                                                                    
            FameAndShamePropsLst.Sort((x, y) => x.OrderCount.CompareTo(y.OrderCount));

            labelShameOrderCount.Text =                                                                               
                "1. " + FameAndShamePropsLst[0].CustomerName + " - " + FameAndShamePropsLst[0].OrderCount.ToString("D") + Environment.NewLine +
                "2. " + FameAndShamePropsLst[1].CustomerName + " - " + FameAndShamePropsLst[1].OrderCount.ToString("D") + Environment.NewLine +
                "3. " + FameAndShamePropsLst[2].CustomerName + " - " + FameAndShamePropsLst[2].OrderCount.ToString("D");
        }

        private void SparfuchsGröpatz()
        {
            
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void FameAndShameForm_Shown(Object sender, EventArgs e)
        {
            GetUserStats();

            int lstLength = FameAndShamePropsLst.Count;

            if (lstLength >= 6)
            {
                MeanTip();
                MeanOrderPrice();
                NumberOfOrders();
                SparfuchsGröpatz();
            }                                                                                   
            else
            {
                labelFameTip.Text = "Zu wenig Daten";
                labelShameTip.Text = "Zu wenig Daten";
            }
   
        }
    }

    class FameAndShameProps
    {
        private string _customerName;
        private int _orderCount;
        private decimal _orderSum;
        private decimal _tipSum;
        private decimal _meanOrderSum;
        private decimal _meanTip;

        internal string CustomerName
        {
            get => _customerName;
            set => _customerName = value;
        }

        internal int OrderCount
        {
            get => _orderCount;
            set => _orderCount = value;
        }

        internal decimal OrderSum
        {
            get => _orderSum;
            set => _orderSum = value;
        }

        internal decimal TipSum
        {
            get => _tipSum;
            set => _tipSum = value;
        }

        internal decimal MeanOrderSum
        {
            get => _meanOrderSum;
            set => _meanOrderSum = value;
        }

        internal decimal MeanTip
        {
            get => _meanTip;
            set => _meanTip = value;
        }

        public FameAndShameProps(string customerName)
        {
            CustomerName = customerName;
        }

        public FameAndShameProps()
        {

        }
    }
}