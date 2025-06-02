namespace atividade1
{
    partial class atividade6
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
            chkAzul = new CheckBox();
            chkVermelho = new CheckBox();
            chkVerde = new CheckBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // chkAzul
            // 
            chkAzul.AutoSize = true;
            chkAzul.Location = new Point(102, 72);
            chkAzul.Name = "chkAzul";
            chkAzul.Size = new Size(60, 24);
            chkAzul.TabIndex = 0;
            chkAzul.Text = "Azul";
            chkAzul.UseVisualStyleBackColor = true;
            chkAzul.CheckedChanged += chkAzul_CheckedChanged;
            // 
            // chkVermelho
            // 
            chkVermelho.AutoSize = true;
            chkVermelho.Location = new Point(102, 102);
            chkVermelho.Name = "chkVermelho";
            chkVermelho.Size = new Size(94, 24);
            chkVermelho.TabIndex = 1;
            chkVermelho.Text = "Vermelho";
            chkVermelho.UseVisualStyleBackColor = true;
            chkVermelho.CheckedChanged += chkVermelho_CheckedChanged;
            // 
            // chkVerde
            // 
            chkVerde.AutoSize = true;
            chkVerde.Location = new Point(102, 147);
            chkVerde.Name = "chkVerde";
            chkVerde.Size = new Size(68, 24);
            chkVerde.TabIndex = 2;
            chkVerde.Text = "verde";
            chkVerde.UseVisualStyleBackColor = true;
            chkVerde.CheckedChanged += chkVerde_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(554, 303);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // atividade6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(chkVerde);
            Controls.Add(chkVermelho);
            Controls.Add(chkAzul);
            Name = "atividade6";
            Text = "atividade6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkAzul;
        private CheckBox chkVermelho;
        private CheckBox chkVerde;
        private Button button1;
    }
}