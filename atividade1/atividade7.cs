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
    public partial class atividade7 : Form
    {
        public atividade7()
        {
            InitializeComponent();
        }

        private void cpf_Leave(object sender, EventArgs e)
        {
            //valida o tamanho do campo
            if (cpf.Text.Length != 11)
            {
                //informa o erro ao cmapo
                errorProvider1.SetError(cpf, "Erro CPF invalido!");
            }
        }

        private void atividade7_Load(object sender, EventArgs e)
        {

        }
    }
}
