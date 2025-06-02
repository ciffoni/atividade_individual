namespace atividade1
{
    partial class foto
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
            pictureBox1 = new PictureBox();
            btnCadastrr = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(101, 120);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(337, 234);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnCadastrr
            // 
            btnCadastrr.Location = new Point(113, 32);
            btnCadastrr.Name = "btnCadastrr";
            btnCadastrr.Size = new Size(94, 29);
            btnCadastrr.TabIndex = 1;
            btnCadastrr.Text = "adicionar foto";
            btnCadastrr.UseVisualStyleBackColor = true;
            btnCadastrr.Click += btnCadastrr_Click;
            // 
            // button2
            // 
            button2.Location = new Point(315, 39);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // foto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(btnCadastrr);
            Controls.Add(pictureBox1);
            Name = "foto";
            Text = "foto";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnCadastrr;
        private Button button2;
    }
}