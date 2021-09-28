using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        double X0, XK, DX, A;

        private void CalcButton_Click(object sender, EventArgs e)
        {
            try
            {
                X0 = double.Parse(XOTextBox.Text);
                XK = double.Parse(XKTextBox.Text);
                DX = double.Parse(DXTextBox.Text);
                A = double.Parse(ConstTextBox.Text);
            }
            catch (Exception)
            {
                try
                {
                    X0 = double.Parse(XOTextBox.Text,  System.Globalization.CultureInfo.InvariantCulture);
                    XK = double.Parse(XKTextBox.Text, System.Globalization.CultureInfo.InvariantCulture);
                    DX = double.Parse(DXTextBox.Text, System.Globalization.CultureInfo.InvariantCulture);
                    A = double.Parse(ConstTextBox.Text, System.Globalization.CultureInfo.InvariantCulture);
                }
                catch (Exception ex)
                {
                    ResultTextBox.Text = ex.Message;
                }
                 
            }
            ResultTextBox.Text = Calculation();

        }

        public Form1()
        {
            InitializeComponent();
        }
        private string Calculation()
        {
            string result= "";
            for (double i = X0; i < XK; i+= DX)
            {
                double y = 2.5e-3 * A * Math.Pow(i, 3) + Math.Pow(i + Math.Pow(Math.E, 0.82),0.5);
                result += "\n X = " + i + "; Y = " + y + " "  ;
            }

            return result;
        }

    }
}
