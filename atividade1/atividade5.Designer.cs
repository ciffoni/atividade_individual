namespace atividade1
{
    partial class atividade5
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
            btnAdd = new Button();
            txtNome = new TextBox();
            produtos = new ListBox();
            btnremover = new Button();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(124, 101);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Adicionar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(153, 48);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(125, 27);
            txtNome.TabIndex = 1;
            // 
            // produtos
            // 
            produtos.FormattingEnabled = true;
            produtos.Location = new Point(342, 34);
            produtos.Name = "produtos";
            produtos.Size = new Size(150, 324);
            produtos.TabIndex = 2;
            // 
            // btnremover
            // 
            btnremover.Location = new Point(140, 166);
            btnremover.Name = "btnremover";
            btnremover.Size = new Size(94, 29);
            btnremover.TabIndex = 3;
            btnremover.Text = "Remover";
            btnremover.UseVisualStyleBackColor = true;
            btnremover.Click += btnremover_Click;
            // 
            // atividade5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnremover);
            Controls.Add(produtos);
            Controls.Add(txtNome);
            Controls.Add(btnAdd);
            Name = "atividade5";
            Text = "atividade5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private TextBox txtNome;
        private ListBox produtos;
        private Button btnremover;
    }
}