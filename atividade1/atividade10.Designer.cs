namespace atividade1
{
    partial class atividade10
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
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            formulario1ToolStripMenuItem = new ToolStripMenuItem();
            formulario2ToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { formulario1ToolStripMenuItem, formulario2ToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(60, 24);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // formulario1ToolStripMenuItem
            // 
            formulario1ToolStripMenuItem.Name = "formulario1ToolStripMenuItem";
            formulario1ToolStripMenuItem.Size = new Size(224, 26);
            formulario1ToolStripMenuItem.Text = "formulario 1";
            formulario1ToolStripMenuItem.Click += formulario1ToolStripMenuItem_Click;
            // 
            // formulario2ToolStripMenuItem
            // 
            formulario2ToolStripMenuItem.Name = "formulario2ToolStripMenuItem";
            formulario2ToolStripMenuItem.Size = new Size(224, 26);
            formulario2ToolStripMenuItem.Text = "formulario2";
            formulario2ToolStripMenuItem.Click += formulario2ToolStripMenuItem_Click;
            // 
            // atividade10
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "atividade10";
            Text = "atividade10";
            Load += atividade10_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem formulario1ToolStripMenuItem;
        private ToolStripMenuItem formulario2ToolStripMenuItem;
    }
}