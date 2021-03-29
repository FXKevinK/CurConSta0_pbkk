using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurConSta0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rate = int.Parse(NumericUpDown1.Text);
            float result = (float)rate;
            // idr
            if ((string)comboBox1.SelectedItem == "IDR" && (string)comboBox2.SelectedItem == "IDR")
            {
                result = (float)rate * 1;
            }
            else if ((string)comboBox1.SelectedItem == "IDR" && (string)comboBox2.SelectedItem == "USD")
            {
                result = (float)rate / 14415;
            }
            else if ((string)comboBox1.SelectedItem == "IDR" && (string)comboBox2.SelectedItem == "EUR")
            {
                result = (float)rate / 17045;
            }
            else if ((string)comboBox1.SelectedItem == "IDR" && (string)comboBox2.SelectedItem == "SGD")
            {
                result = (float)rate / 10710;
            }
            else if ((string)comboBox1.SelectedItem == "IDR" && (string)comboBox2.SelectedItem == "JPY")
            {
                result = (float)rate / (float)130.89;
            }
            else if ((string)comboBox1.SelectedItem == "IDR" && (string)comboBox2.SelectedItem == "MYR")
            {
                result = (float)rate / 3474;
            }

            // usd
            else if ((string)comboBox1.SelectedItem == "USD" && (string)comboBox2.SelectedItem == "USD")
            {
                result = (float)rate * 1;
            }
            else if ((string)comboBox1.SelectedItem == "USD" && (string)comboBox2.SelectedItem == "IDR")
            {
                result = (float)rate * 14415;
            }
            else if ((string)comboBox1.SelectedItem == "USD" && (string)comboBox2.SelectedItem == "EUR")
            {
                result = (float)rate / (float)1.18;
            }
            else if ((string)comboBox1.SelectedItem == "USD" && (string)comboBox2.SelectedItem == "SGD")
            {
                result = (float)rate * (float)1.35;
            }
            else if ((string)comboBox1.SelectedItem == "USD" && (string)comboBox2.SelectedItem == "JPY")
            {
                result = (float)rate * (float)109.61;
            }
            else if ((string)comboBox1.SelectedItem == "USD" && (string)comboBox2.SelectedItem == "MYR")
            {
                result = (float)rate * (float)4.15;
            }

            // eur
            else if ((string)comboBox1.SelectedItem == "EUR" && (string)comboBox2.SelectedItem == "EUR")
            {
                result = (float)rate * 1;
            }
            else if ((string)comboBox1.SelectedItem == "EUR" && (string)comboBox2.SelectedItem == "IDR")
            {
                result = (float)rate * 17045;
            }
            else if ((string)comboBox1.SelectedItem == "EUR" && (string)comboBox2.SelectedItem == "USD")
            {
                result = (float)rate * (float)1.18;
            }
            else if ((string)comboBox1.SelectedItem == "EUR" && (string)comboBox2.SelectedItem == "SGD")
            {
                result = (float)rate * (float)1.59;
            }
            else if ((string)comboBox1.SelectedItem == "EUR" && (string)comboBox2.SelectedItem == "JPY")
            {
                result = (float)rate * (float)129.61;
            }
            else if ((string)comboBox1.SelectedItem == "EUR" && (string)comboBox2.SelectedItem == "MYR")
            {
                result = (float)rate * (float)4.90;
            }


            // sgd
            else if ((string)comboBox1.SelectedItem == "SGD" && (string)comboBox2.SelectedItem == "SGD")
            {
                result = (float)rate * 1;
            }
            else if ((string)comboBox1.SelectedItem == "SGD" && (string)comboBox2.SelectedItem == "IDR")
            {
                result = (float)rate * (float)10710;
            }
            else if ((string)comboBox1.SelectedItem == "SGD" && (string)comboBox2.SelectedItem == "USD")
            {
                result = (float)rate / (float)1.35;
            }
            else if ((string)comboBox1.SelectedItem == "SGD" && (string)comboBox2.SelectedItem == "EUR")
            {
                result = (float)rate / (float)1.59;
            }
            else if ((string)comboBox1.SelectedItem == "SGD" && (string)comboBox2.SelectedItem == "JPY")
            {
                result = (float)rate * (float)81.44;
            }
            else if ((string)comboBox1.SelectedItem == "SGD" && (string)comboBox2.SelectedItem == "MYR")
            {
                result = (float)rate * (float)3.08;
            }

            // jpy
            else if ((string)comboBox1.SelectedItem == "JPY" && (string)comboBox2.SelectedItem == "JPY")
            {
                result = (float)rate * 1;
            }
            else if ((string)comboBox1.SelectedItem == "JPY" && (string)comboBox2.SelectedItem == "IDR")
            {
                result = (float)rate * (float)130.89;
            }
            else if ((string)comboBox1.SelectedItem == "JPY" && (string)comboBox2.SelectedItem == "USD")
            {
                result = (float)rate / (float)109.61;
            }
            else if ((string)comboBox1.SelectedItem == "JPY" && (string)comboBox2.SelectedItem == "EUR")
            {
                result = (float)rate / (float)129.61;
            }
            else if ((string)comboBox1.SelectedItem == "JPY" && (string)comboBox2.SelectedItem == "SGD")
            {
                result = (float)rate / (float)81.44;
            }
            else if ((string)comboBox1.SelectedItem == "JPY" && (string)comboBox2.SelectedItem == "MYR")
            {
                result = (float)rate / (float)26.55;
            }

            // myr
            else if ((string)comboBox1.SelectedItem == "MYR" && (string)comboBox2.SelectedItem == "MYR")
            {
                result = (float)rate * 1;
            }
            else if ((string)comboBox1.SelectedItem == "MYR" && (string)comboBox2.SelectedItem == "IDR")
            {
                result = (float)rate * 3474;
            }
            else if ((string)comboBox1.SelectedItem == "MYR" && (string)comboBox2.SelectedItem == "USD")
            {
                result = (float)rate / (float)4.15;
            }
            else if ((string)comboBox1.SelectedItem == "MYR" && (string)comboBox2.SelectedItem == "EUR")
            {
                result = (float)rate / (float)4.90;
            }
            else if ((string)comboBox1.SelectedItem == "MYR" && (string)comboBox2.SelectedItem == "SGD")
            {
                result = (float)rate / (float)3.08;
            }
            else if ((string)comboBox1.SelectedItem == "MYR" && (string)comboBox2.SelectedItem == "JPY")
            {
                result = (float)rate * (float)26.55;
            }

            textBox1.Text = result.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}