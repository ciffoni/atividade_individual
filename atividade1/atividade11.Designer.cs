namespace atividade1
{
    partial class atividade11
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
            chkcebola = new CheckBox();
            chkbacon = new CheckBox();
            chkcatupiry = new CheckBox();
            chkboxMussarela = new CheckBox();
            label1 = new Label();
            btnPedido = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkcebola);
            groupBox1.Controls.Add(chkbacon);
            groupBox1.Controls.Add(chkcatupiry);
            groupBox1.Controls.Add(chkboxMussarela);
            groupBox1.Location = new Point(80, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 200);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ingredientes extras";
            // 
            // chkcebola
            // 
            chkcebola.AutoSize = true;
            chkcebola.Location = new Point(26, 105);
            chkcebola.Name = "chkcebola";
            chkcebola.Size = new Size(109, 24);
            chkcebola.TabIndex = 3;
            chkcebola.Text = "cebola roxa";
            chkcebola.UseVisualStyleBackColor = true;
            // 
            // chkbacon
            // 
            chkbacon.AutoSize = true;
            chkbacon.Location = new Point(32, 81);
            chkbacon.Name = "chkbacon";
            chkbacon.Size = new Size(72, 24);
            chkbacon.TabIndex = 2;
            chkbacon.Text = "bacon";
            chkbacon.UseVisualStyleBackColor = true;
            // 
            // chkcatupiry
            // 
            chkcatupiry.AutoSize = true;
            chkcatupiry.Location = new Point(25, 52);
            chkcatupiry.Name = "chkcatupiry";
            chkcatupiry.Size = new Size(86, 24);
            chkcatupiry.TabIndex = 1;
            chkcatupiry.Text = "Catupiry";
            chkcatupiry.UseVisualStyleBackColor = true;
            // 
            // chkboxMussarela
            // 
            chkboxMussarela.AutoSize = true;
            chkboxMussarela.Location = new Point(23, 26);
            chkboxMussarela.Name = "chkboxMussarela";
            chkboxMussarela.Size = new Size(97, 24);
            chkboxMussarela.TabIndex = 0;
            chkboxMussarela.Text = "Mussarela";
            chkboxMussarela.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(128, 270);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 1;
            label1.Text = "Pedido:";
            // 
            // btnPedido
            // 
            btnPedido.Location = new Point(126, 330);
            btnPedido.Name = "btnPedido";
            btnPedido.Size = new Size(94, 29);
            btnPedido.TabIndex = 2;
            btnPedido.Text = "pedido";
            btnPedido.UseVisualStyleBackColor = true;
            btnPedido.Click += btnPedido_Click;
            // 
            // atividade11
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPedido);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "atividade11";
            Text = "atividade11";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private CheckBox chkcebola;
        private CheckBox chkbacon;
        private CheckBox chkcatupiry;
        private CheckBox chkboxMussarela;
        private Label label1;
        private Button btnPedido;
    }
}