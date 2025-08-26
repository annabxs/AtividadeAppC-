namespace AtividadeAppC_
{
    partial class frmmenu
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
            this.tsmlista = new System.Windows.Forms.MenuStrip();
            this.tsmi1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi3 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi4 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi5 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmlista.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsmlista
            // 
            this.tsmlista.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi1,
            this.tsmi2,
            this.tsmi3,
            this.tsmi4,
            this.tsmi5});
            this.tsmlista.Location = new System.Drawing.Point(0, 0);
            this.tsmlista.Name = "tsmlista";
            this.tsmlista.Size = new System.Drawing.Size(800, 24);
            this.tsmlista.TabIndex = 0;
            this.tsmlista.Text = "menuStrip1";
            // 
            // tsmi1
            // 
            this.tsmi1.Name = "tsmi1";
            this.tsmi1.Size = new System.Drawing.Size(74, 20);
            this.tsmi1.Text = "Exercício1 ";
            this.tsmi1.Click += new System.EventHandler(this.tsmi1_Click);
            // 
            // tsmi2
            // 
            this.tsmi2.Name = "tsmi2";
            this.tsmi2.Size = new System.Drawing.Size(71, 20);
            this.tsmi2.Text = "Exercício2";
            this.tsmi2.Click += new System.EventHandler(this.tsmi2_Click);
            // 
            // tsmi3
            // 
            this.tsmi3.Name = "tsmi3";
            this.tsmi3.Size = new System.Drawing.Size(71, 20);
            this.tsmi3.Text = "Exercício3";
            this.tsmi3.Click += new System.EventHandler(this.tsmi3_Click);
            // 
            // tsmi4
            // 
            this.tsmi4.Name = "tsmi4";
            this.tsmi4.Size = new System.Drawing.Size(71, 20);
            this.tsmi4.Text = "Exercício4";
            this.tsmi4.Click += new System.EventHandler(this.tsmi4_Click);
            // 
            // tsmi5
            // 
            this.tsmi5.Name = "tsmi5";
            this.tsmi5.Size = new System.Drawing.Size(71, 20);
            this.tsmi5.Text = "Exercício5";
            this.tsmi5.Click += new System.EventHandler(this.tsmi5_Click);
            // 
            // frmmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tsmlista);
            this.MainMenuStrip = this.tsmlista;
            this.Name = "frmmenu";
            this.Text = "Form1";
            this.tsmlista.ResumeLayout(false);
            this.tsmlista.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip tsmlista;
        private System.Windows.Forms.ToolStripMenuItem tsmi1;
        private System.Windows.Forms.ToolStripMenuItem tsmi2;
        private System.Windows.Forms.ToolStripMenuItem tsmi3;
        private System.Windows.Forms.ToolStripMenuItem tsmi4;
        private System.Windows.Forms.ToolStripMenuItem tsmi5;
    }
}

