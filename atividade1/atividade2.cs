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
    public partial class atividade2 : Form
    {
        public atividade2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bem vindo, " + nome.Text);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            calculadora calc= new calculadora();
            calc.Show();
        }
    }
}
