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
    public partial class atividade9 : Form
    {
        public atividade9()
        {
            InitializeComponent();
        }

        private void atividade9_Load(object sender, EventArgs e)
        {
            
            
            //definir o intervalo
            timer1.Interval = 1000;
            //recebe a hora no label
         }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            //inicia a hora
            timer1.Start();
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            //para a hora
            timer1.Stop();
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            //ativa a cada intervalo de tempo
            lblHora.Text = DateTime.Now.ToString();

        }
    }
}
