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
    public partial class foto : Form
    {
        public foto()
        {
            InitializeComponent();
        }

        private void btnCadastrr_Click(object sender, EventArgs e)
        {
            //crio a caixa de ferramenta
            OpenFileDialog ofd = new OpenFileDialog();
            //defino o filtro das imagens
            ofd.Filter = "*.jpg;*.png|";
            ofd.Title = "Selecionar imagens";
            //verifico se há imagem escolhida
            if (ofd.ShowDialog() == DialogResult.OK)
            {//carrega a imagem selecionada na caixa
                pictureBox1.Image = Image.FromFile(ofd.FileName);

            }
        }

        private void remover_Click(object sender, EventArgs e)
        {
            //deixa a imagem vazia
            pictureBox1.Image = null;
        }
    }
}
