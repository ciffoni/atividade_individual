namespace atividade1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnClick = new Button();
            label1 = new Label();
            atividade2 = new Button();
            SuspendLayout();
            // 
            // btnClick
            // 
            btnClick.Location = new Point(263, 87);
            btnClick.Name = "btnClick";
            btnClick.Size = new Size(94, 29);
            btnClick.TabIndex = 0;
            btnClick.Text = "click";
            btnClick.UseVisualStyleBackColor = true;
            btnClick.Click += btnClick_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(276, 181);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // atividade2
            // 
            atividade2.Location = new Point(584, 294);
            atividade2.Name = "atividade2";
            atividade2.Size = new Size(94, 29);
            atividade2.TabIndex = 2;
            atividade2.Text = "atividade2";
            atividade2.UseVisualStyleBackColor = true;
            atividade2.Click += atividade2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(atividade2);
            Controls.Add(label1);
            Controls.Add(btnClick);
            Name = "Form1";
            Text = "atividade 1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClick;
        private Label label1;
        private Button atividade2;
    }
}
