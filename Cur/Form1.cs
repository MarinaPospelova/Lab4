using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cur
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            chart1.Series[0].Points.Clear();
        }

        const double k = 0.05;
        private void btStart_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            double rate = (double)edRate.Value;
            chart1.Series[0].Points.AddXY(0, rate);
            rate = rate * (1 + k * (random.NextDouble() - 0.5));
            edRate.Value = (decimal)rate;
            chart1.Series[0].Points.AddXY(0, rate);
        }

        private void btBuy_Click(object sender, EventArgs e)
        {
            if (edRub.Value >= (edRate.Value*edBuy.Value))
                {
                    edDoll.Value += edBuy.Value;
                    edRub.Value -= edRate.Value * edBuy.Value;
                    textBox1.Text = "Успешно!";
                }
            else
                textBox1.Text = "Недостаточно средств!";
        }

        private void btSell_Click(object sender, EventArgs e)
        {
            if (edDoll.Value >= edSell.Value)
            {
                edRub.Value += edSell.Value*edRate.Value;
                edDoll.Value -= edSell.Value;
                textBox1.Text = "Успешно!";
            }
            else
                textBox1.Text = "Недостаточно средств!";
        }
    }
}
