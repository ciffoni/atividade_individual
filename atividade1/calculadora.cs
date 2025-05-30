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
    public partial class calculadora : Form
    {
        public calculadora()
        {
            InitializeComponent();
        }

        private void Soma_Click(object sender, EventArgs e)
        {
            //criando a variavel inteiro
            int v1 = 0;
            int v2 = 0;
            int res = 0;
            //convertendo o texto para inteiro
            v1=Convert.ToInt32(valor1.Text);
            v2=Convert.ToInt32(valor2.Text);
            //realizando a soma
            res = v1 + v2;
            //converto o resultado em texto
            resultado.Text = res.ToString();

        }
    }
}
