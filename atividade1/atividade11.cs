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
    public partial class atividade11 : Form
    {
        public atividade11()
        {
            InitializeComponent();
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            label1.Text = "Pedido :";
            if(chkboxMussarela.Checked)
            {
                label1.Text += " ";
                label1.Text += chkboxMussarela.Text;
            }
            else
            {
                label1.Text += "";
            }
            if (chkbacon.Checked)
            {
                label1.Text += " ";
                label1.Text += chkbacon.Text;
            }
            if (chkcatupiry.Checked) {
                label1.Text += " ";
                label1.Text+=chkcatupiry.Text;
            }
            if (chkcebola.Checked)
            {
                label1.Text += " ";
                label1.Text+=(chkcebola.Text);
            }
            else
            {
                label1.Text += " ";
            }
        }
    }
}
