using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bhaskara
{
    public partial class Bhaskara : Form
    {
        public Calculadora Calc = new Calculadora();
        public Bhaskara()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool ValorReal=Calc.Calculo(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text));
            if (ValorReal)
            {
                lblX1.Text = Calc.X1.ToString("F");
                lblX2.Text = Calc.X2.ToString("F");
            } else
            {
                lblX1.Text = "Não existe";
                lblX2.Text = "Não existe";
            }
          

        }

       
    }
}
