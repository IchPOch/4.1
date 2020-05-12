using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4._1F
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static double f(int n, int i, double b)
        {
            i++;
            if (i <= n)
            {
                return f(n, i, b / (n * n + n + 1));
            }
            else
            {
                return b;
            }
        }

        private void b_Click(object sender, EventArgs e)
        {
            try
            {
                V.Text = "";
                int n = Convert.ToInt32(N.Text);
                V.Text += f(n, 1, 5);
            }
            catch
            {
                V.Text = "Неккотректно введены данные";
            }

        }
    }
}
