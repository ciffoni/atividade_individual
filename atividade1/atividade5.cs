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
    public partial class atividade5 : Form
    {
        public atividade5()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //adicionar um item ao listbox
            produtos.Items.Add(txtNome.Text);
        }

        private void btnremover_Click(object sender, EventArgs e)
        {
            //verificar se há item selecionado
            if(produtos.SelectedIndex != -1)
            {
                //se tiver remove o item
                produtos.Items.RemoveAt(produtos.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Item não selecionado!");
            }
        }
    }
}



