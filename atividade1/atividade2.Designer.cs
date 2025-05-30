namespace atividade1
{
    partial class atividade2
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
            click = new Button();
            nome = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // click
            // 
            click.Location = new Point(216, 149);
            click.Name = "click";
            click.Size = new Size(94, 29);
            click.TabIndex = 0;
            click.Text = "saudação";
            click.UseVisualStyleBackColor = true;
            click.Click += button1_Click;
            // 
            // nome
            // 
            nome.Location = new Point(214, 78);
            nome.Name = "nome";
            nome.Size = new Size(125, 27);
            nome.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(570, 322);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "calculadora";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // atividade2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(nome);
            Controls.Add(click);
            Name = "atividade2";
            Text = "atividade2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button click;
        private TextBox nome;
        private Button button1;
    }
}