using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace button.ornek._27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbSes_Scroll(object sender, EventArgs e)
        {
            int deger = tbSes.Value;
            lblSeviyeDeger.Text = tbSes.Value.ToString();
            if (deger>=0 && deger < 25)
            {
                lblSes.Text = "Ses Seviyesi DÜşük";
            }
            else if (deger>=25 && deger < 70)
            {
                lblSes.Text = "Ses Seviyesi Normal";
            }
            else if (deger>=70 && deger<90)
            {
                lblSes.Text = "Ses Seviyesi Yüksek";
            }
            else
            {
                lblSes.Text = "Ses Seviyesi Çok Yüksek";
            }
        } 
    }
}
