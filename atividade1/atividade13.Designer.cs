namespace atividade1
{
    partial class atividade13
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
            groupBox1 = new GroupBox();
            chklivro = new CheckBox();
            chkeletronico = new CheckBox();
            chkroupa = new CheckBox();
            chkAlimento = new CheckBox();
            listProdutos = new ListBox();
            btnAplicar = new Button();
            button1 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chklivro);
            groupBox1.Controls.Add(chkeletronico);
            groupBox1.Controls.Add(chkroupa);
            groupBox1.Controls.Add(chkAlimento);
            groupBox1.Location = new Point(52, 53);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(581, 125);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // chklivro
            // 
            chklivro.AutoSize = true;
            chklivro.Location = new Point(419, 37);
            chklivro.Name = "chklivro";
            chklivro.Size = new Size(60, 24);
            chklivro.TabIndex = 3;
            chklivro.Text = "livro";
            chklivro.UseVisualStyleBackColor = true;
            chklivro.CheckedChanged += chklivro_CheckedChanged;
            // 
            // chkeletronico
            // 
            chkeletronico.AutoSize = true;
            chkeletronico.Location = new Point(291, 33);
            chkeletronico.Name = "chkeletronico";
            chkeletronico.Size = new Size(98, 24);
            chkeletronico.TabIndex = 2;
            chkeletronico.Text = "Eletronico";
            chkeletronico.UseVisualStyleBackColor = true;
            chkeletronico.CheckedChanged += chkeletronico_CheckedChanged;
            // 
            // chkroupa
            // 
            chkroupa.AutoSize = true;
            chkroupa.Location = new Point(163, 33);
            chkroupa.Name = "chkroupa";
            chkroupa.Size = new Size(70, 24);
            chkroupa.TabIndex = 1;
            chkroupa.Text = "roupa";
            chkroupa.UseVisualStyleBackColor = true;
            chkroupa.CheckedChanged += chkroupa_CheckedChanged;
            // 
            // chkAlimento
            // 
            chkAlimento.AutoSize = true;
            chkAlimento.Location = new Point(33, 39);
            chkAlimento.Name = "chkAlimento";
            chkAlimento.Size = new Size(92, 24);
            chkAlimento.TabIndex = 0;
            chkAlimento.Text = "Alimento";
            chkAlimento.UseVisualStyleBackColor = true;
            chkAlimento.CheckedChanged += chkAlimento_CheckedChanged;
            // 
            // listProdutos
            // 
            listProdutos.FormattingEnabled = true;
            listProdutos.Location = new Point(80, 190);
            listProdutos.Name = "listProdutos";
            listProdutos.Size = new Size(316, 224);
            listProdutos.TabIndex = 1;
            // 
            // btnAplicar
            // 
            btnAplicar.Location = new Point(668, 117);
            btnAplicar.Name = "btnAplicar";
            btnAplicar.Size = new Size(94, 29);
            btnAplicar.TabIndex = 2;
            btnAplicar.Text = "aplicar";
            btnAplicar.UseVisualStyleBackColor = true;
            btnAplicar.Click += btnAplicar_Click;
            // 
            // button1
            // 
            button1.Location = new Point(589, 230);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // atividade13
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btnAplicar);
            Controls.Add(listProdutos);
            Controls.Add(groupBox1);
            Name = "atividade13";
            Text = "atividade13";
            Load += atividade13_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private CheckBox chklivro;
        private CheckBox chkeletronico;
        private CheckBox chkroupa;
        private CheckBox chkAlimento;
        private ListBox listProdutos;
        private Button btnAplicar;
        private Button button1;
    }
}