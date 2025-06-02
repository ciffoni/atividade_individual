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
    public partial class atividade6 : Form
    {
        public atividade6()
        {
            InitializeComponent();
        }

        private void chkAzul_CheckedChanged(object sender, EventArgs e)
        {
            //seta o fundo  azul
            this.BackColor = Color.Blue;
        }

        private void chkVermelho_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void chkVerde_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            atividade7 at7 = new atividade7();
            at7.Show();
        }
    }
}
