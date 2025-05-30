namespace atividade1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            label1.Text = " Ola Windows forms ";
        }

        private void atividade2_Click(object sender, EventArgs e)
        {
           //crio o novo formulario atividade2
            atividade2 exercicio= new atividade2();
            //mostra a tela aberta
            exercicio.Show();
    
        }
    }
}
