using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // button to close the page
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //button clixk event calls the calacualte tax method and gets tax
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal income = Convert.ToDecimal(txtIncome.Text);
            decimal tax = CalculateTax(income);
            txtTax.Text = tax.ToString();

        }

        // calculatetax method 
        private decimal CalculateTax(decimal income)
        {
            decimal tax = 0m;
            if (income <= 9225)
                tax = (int)(income * .10m);
            else if (income > 9225 && income <= 37450)
                tax = 922.50m + (int)((income - 9225) * .15m);
            else if (income > 37450 && income <= 90750)
                tax = 5156.25m + (int)((income - 37450) * .25m);
            else if (income > 90750 && income <= 189300)
                tax = 18481.25m + (int)((income - 90750) * .28m);
            else if (income > 189300 && income <= 411500)
                tax = 46075.25m + (int)((income - 189300) * .33m);
            else if (income > 411500 && income <= 413200)
                tax = 119401.25m + (int)((income - 411500) * .35m);
            else if (income > 413200)
                tax = 119996.25m + (int)((income - 413200) * .396m);

            return tax;


        }

        // textchange event if text is changed in the textbox it clears the tax textbox
        private void txtIncome_TextChanged(object sender, EventArgs e)
        {
            txtTax.Clear();
        }
    }
}