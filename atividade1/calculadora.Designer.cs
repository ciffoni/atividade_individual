namespace atividade1
{
    partial class calculadora
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            valor1 = new TextBox();
            valor2 = new TextBox();
            Soma = new Button();
            subtracao = new Button();
            divisao = new Button();
            multiplicacao = new Button();
            resultado = new Label();
            button1 = new Button();
            lblcontar = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // valor1
            // 
            valor1.Location = new Point(46, 58);
            valor1.Name = "valor1";
            valor1.Size = new Size(125, 27);
            valor1.TabIndex = 0;
            // 
            // valor2
            // 
            valor2.Location = new Point(267, 57);
            valor2.Name = "valor2";
            valor2.Size = new Size(125, 27);
            valor2.TabIndex = 1;
            // 
            // Soma
            // 
            Soma.Location = new Point(65, 122);
            Soma.Name = "Soma";
            Soma.Size = new Size(94, 29);
            Soma.TabIndex = 2;
            Soma.Text = "Adição";
            Soma.UseVisualStyleBackColor = true;
            Soma.Click += Soma_Click;
            // 
            // subtracao
            // 
            subtracao.Location = new Point(259, 119);
            subtracao.Name = "subtracao";
            subtracao.Size = new Size(94, 29);
            subtracao.TabIndex = 3;
            subtracao.Text = "Subtração";
            subtracao.UseVisualStyleBackColor = true;
            // 
            // divisao
            // 
            divisao.Location = new Point(72, 182);
            divisao.Name = "divisao";
            divisao.Size = new Size(94, 29);
            divisao.TabIndex = 4;
            divisao.Text = "divisão";
            divisao.UseVisualStyleBackColor = true;
            divisao.Click += divisao_Click;
            // 
            // multiplicacao
            // 
            multiplicacao.Location = new Point(259, 182);
            multiplicacao.Name = "multiplicacao";
            multiplicacao.Size = new Size(94, 29);
            multiplicacao.TabIndex = 5;
            multiplicacao.Text = "Multiplicação";
            multiplicacao.UseVisualStyleBackColor = true;
            // 
            // resultado
            // 
            resultado.AutoSize = true;
            resultado.Location = new Point(76, 256);
            resultado.Name = "resultado";
            resultado.Size = new Size(50, 20);
            resultado.TabIndex = 6;
            resultado.Text = "label1";
            // 
            // button1
            // 
            button1.Location = new Point(542, 162);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 7;
            button1.Text = "atividade 4";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblcontar
            // 
            lblcontar.AutoSize = true;
            lblcontar.Location = new Point(548, 263);
            lblcontar.Name = "lblcontar";
            lblcontar.Size = new Size(50, 20);
            lblcontar.TabIndex = 8;
            lblcontar.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 22);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 9;
            label1.Text = "Digite o valor 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(272, 19);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 10;
            label2.Text = "Digite o valor 2";
            // 
            // calculadora
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblcontar);
            Controls.Add(button1);
            Controls.Add(resultado);
            Controls.Add(multiplicacao);
            Controls.Add(divisao);
            Controls.Add(subtracao);
            Controls.Add(Soma);
            Controls.Add(valor2);
            Controls.Add(valor1);
            Name = "calculadora";
            Text = "calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox valor1;
        private TextBox valor2;
        private Button Soma;
        private Button subtracao;
        private Button divisao;
        private Button multiplicacao;
        private Label resultado;
        private Button button1;
        private Label lblcontar;
        private Label label1;
        private Label label2;
    }
}