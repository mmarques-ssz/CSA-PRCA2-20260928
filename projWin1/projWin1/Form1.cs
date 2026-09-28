using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projWin1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            /*
            Soma s = new Soma();
            s.setN1(int.Parse(txtValor1.Text));
            s.setN2(int.Parse(txtValor2.Text))
            */

            Soma s = new Soma(int.Parse(txtValor1.Text), int.Parse(txtValor2.Text));

            s.calcular();
            lblResultado.Text = s.getResultado().ToString();
        }
    }
}
