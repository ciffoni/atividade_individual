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
    public partial class atividade10 : Form
    {
        public atividade10()
        {
            InitializeComponent();
        }

        private void atividade10_Load(object sender, EventArgs e)
        {

        }

        private void formulario1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filho1 f1 = new filho1();
            //transforma ele em filho
           f1.MdiParent = this;
            f1.Show();
        }

        private void formulario2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filho2 f2= new filho2();
            f2.MdiParent = this;
            f2.Show();
        }
    }
}
