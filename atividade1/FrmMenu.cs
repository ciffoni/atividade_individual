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
    }
}
