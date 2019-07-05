using System;
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
        public FameAndShameForm()
        {
            InitializeComponent();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }
    }

    public class FameAndShameProps
    {
        private decimal _blub;

        private decimal Blub
        {
            get => _blub;
            set => _blub = value;
        }
    }
}
