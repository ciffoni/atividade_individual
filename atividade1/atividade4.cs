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
    public partial class atividade4 : Form
    {
        //variavel guardar os clicks
        int contador = 0;
        public atividade4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            contador++; //incremente o valor
            //mostrar quantos clicks foram
            label1.Text = contador.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
        }
    }
}
