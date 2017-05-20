using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {

        public string formula = "";
        public double result = 0;
        bool performed = false;


        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            txtNums.Text = "0";
        }

        //nums
        private void button28_Click(object sender, EventArgs e)
        {
            if (txtNums.Text == "0" || performed)
                txtNums.Clear();

            performed = false;

            string s = (sender as Button).Text;
            if (s == ".")
            {
                if (!txtNums.Text.Contains("."))
                    txtNums.Text += s;
            } else
            {
                txtNums.Text += s;
            }

        }

        //operator
        private void button19_Click(object sender, EventArgs e)
        {
            string s = (sender as Button).Text;


            if (result != 0)
            {
                button30.PerformClick();

                formula = s;
                lblAns.Text = result + "" + formula;
                performed = true;

            }
            else
            {
                formula = s;
                result = Double.Parse(txtNums.Text);
                lblAns.Text = result + "" + formula;
                performed = true;

            }

        }

        //clear
        private void button15_Click(object sender, EventArgs e)
        {
            txtNums.Text = "0";
            result = 0;
            lblAns.Text = "0";

        }

        //answer
        private double ans;
        private void button30_Click(object sender, EventArgs e)
        {

            switch (formula)
            {
                case "+":
                    ans = calculator1.add(result, Double.Parse(txtNums.Text));
                    break;
                case "-":
                    ans = calculator1.sub(result, Double.Parse(txtNums.Text));
                    break;
                case "*":
                    ans = calculator1.multi(result, Double.Parse(txtNums.Text));
                    break;
                case "/":
                    ans = calculator1.div(result, Double.Parse(txtNums.Text));
                    break;
            }
            result = ans;
            txtNums.Text = ans.ToString();
            lblAns.Text = "";

        }
    }
        class calculator1
        {
  
        public static double add(double num, double num2)
        {

            return num + num2;
        }

        public static double sub(double num, double num2)
        {

            return num + num2;
        }
        public static double multi(double num, double num2)
        {

            return num + num2;
        }
        public static double div(double num, double num2)
        {

            if (num2 == 0)
            {
                MessageBox.Show("operation failed");
                return 0;
            }
            else
            {
                double ans = num / num2;
                return ans;

            }
        }
    }

    
}
