using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividade1
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //chama o formulario
            atividade5 at5 = new atividade5();
            //mostra na tela inicial
            at5.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            atividade6 at6 = new atividade6();
            at6.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            foto foto = new foto();
            foto.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            atividade9 at9 = new atividade9();
            at9.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            atividade10 at10 = new atividade10();
            at10.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            atividade11 at11 = new atividade11();
            at11.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            atividade12 at12 = new atividade12();
            at12.ShowDialog();
        }
    }
}
