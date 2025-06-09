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
    public partial class atividade13 : Form
    {
        //criar o objeto produto
        public class produto
        {
            //criar seus atributos
            public string nome { get; set; }
            public string categoria { get; set; }
            public decimal preco { get; set; }
            //metodo para escrever as informações
            public override string ToString()
            {
                return $"{nome} {categoria} - {preco}";
            }
        }
        //cria a varaivel privada de todos os produtos
        private List<produto> Listarprodutos;
        // criar uma lista de categoria
        private List<string> categoriaSelecionada = new List<string>();
        public atividade13()
        {
            InitializeComponent();
            //criar os produtos
            Listarprodutos = new List<produto>()
            {
                new produto{nome="celular", preco=1200,categoria="eletronico"},
                new produto{nome="camiseta",categoria="roupa",preco=89},
                new produto{nome="coxinha de frango",categoria="alimento",preco=8},
                new produto{nome="livro c#",categoria="livro",preco=170}

            };
        }

        private void atividade13_Load(object sender, EventArgs e)
        {

        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            //limpa a listabox lista produto
            listProdutos.Items.Clear();
           
            if(chkAlimento.Checked == false ) {
                categoriaSelecionada.Remove("alimento");
                
            }
            if(chkeletronico.Checked == false )
            {
                categoriaSelecionada.Remove("eletronico");
            }
            if(chkroupa.Checked == false )
            {
                categoriaSelecionada.Remove("roupa");
            }
            if(chklivro.Checked == false )
            {
                categoriaSelecionada.Remove("livro");
            }
            if (categoriaSelecionada.Count == 0)
            {
                listProdutos.Items.Add("Nenhuma categoria seleciona");
            }
            else
            {
                //seleção de checkbox buscar
                var produtosfiltrados = Listarprodutos.Where(
                    p => categoriaSelecionada.Contains(p.categoria)).ToList();
                if (produtosfiltrados.Any())
                {
                    //procura o item selecionado
                    foreach(var produto in produtosfiltrados)
                    {
                        //adicionar os itens a lista
                        listProdutos.Items.Add(produto);
                    }
                }
                else
                {
                    listProdutos.Items.Add("nenhum produto encontrado");
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void chkAlimento_CheckedChanged(object sender, EventArgs e)
        {
            categoriaSelecionada.Add("alimento");
        }

        private void chkroupa_CheckedChanged(object sender, EventArgs e)
        {
            categoriaSelecionada.Add("roupa");
        }

        private void chkeletronico_CheckedChanged(object sender, EventArgs e)
        {
            categoriaSelecionada.Add("eletronico");
        }

        private void chklivro_CheckedChanged(object sender, EventArgs e)
        {
            categoriaSelecionada.Add("livro");
        }
    }
}

