using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceWebDemo
{
    public partial class frmAccueil : Form
    {
        public frmAccueil()
        {
            InitializeComponent();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            MonServiceWeb.CalcServiceSoapClient client = new MonServiceWeb.CalcServiceSoapClient();
            txtResultat.Text = client.Plus(Convert.ToDecimal(txtA.Text), Convert.ToDecimal(txtB.Text)).ToString();
        }

        private void btnMoins_Click(object sender, EventArgs e)
        {
            MonServiceWeb.CalcServiceSoapClient client = new MonServiceWeb.CalcServiceSoapClient();
            txtResultat.Text = client.Moins(Convert.ToDecimal(txtA.Text), Convert.ToDecimal(txtB.Text)).ToString();
        }

        private void btnMultiplier_Click(object sender, EventArgs e)
        {
            MonServiceWeb.CalcServiceSoapClient client = new MonServiceWeb.CalcServiceSoapClient();
            txtResultat.Text = client.Multiplier(Convert.ToDecimal(txtA.Text), Convert.ToDecimal(txtB.Text)).ToString();
        }

        private void btnDiviser_Click(object sender, EventArgs e)
        {
            MonServiceWeb.CalcServiceSoapClient client = new MonServiceWeb.CalcServiceSoapClient();
            txtResultat.Text = client.Diviser(Convert.ToDecimal(txtA.Text), Convert.ToDecimal(txtB.Text)).ToString();
        }

        private void btnMessage_Click(object sender, EventArgs e)
        {
            MonServiceWeb.CalcServiceSoapClient client = new MonServiceWeb.CalcServiceSoapClient();
            MessageBox.Show(client.Message(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void IsNumeric(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar <= '0' || e.KeyChar >= '9') e.Handled = true;
        }

        private void frmAccueil_Load(object sender, EventArgs e)
        {

        }
    }
}
