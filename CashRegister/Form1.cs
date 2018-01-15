using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashRegister
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstOrderSummary.Items.Add("Order Summary");
        }

        private void btnPizza_Click(object sender, EventArgs e)
        {

            lstOrderSummary.Items.Add("Pizza" + lblPizza.Text);
        }

        private void btnBurger_Click(object sender, EventArgs e)
        {
            lstOrderSummary.Items.Add("Burger" + lblBurger.Text);
        }

        private void btnFries_Click(object sender, EventArgs e)
        {
            lstOrderSummary.Items.Add("Fries" + lblFries.Text);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstOrderSummary.Items.Clear();
            lstOrderSummary.Items.Add("Order Summary");

        }
    }
}
