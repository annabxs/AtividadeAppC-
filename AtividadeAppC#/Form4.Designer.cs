namespace AtividadeAppC_
{
    partial class frmexercicio3
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
            this.btncalcular = new System.Windows.Forms.Button();
            this.txttotalpago = new System.Windows.Forms.TextBox();
            this.lbltotalpago = new System.Windows.Forms.Label();
            this.txtquantidadelivros = new System.Windows.Forms.TextBox();
            this.lblnome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncalcular
            // 
            this.btncalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btncalcular.Location = new System.Drawing.Point(208, 198);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(125, 41);
            this.btncalcular.TabIndex = 14;
            this.btncalcular.Text = "calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            // 
            // txttotalpago
            // 
            this.txttotalpago.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txttotalpago.Location = new System.Drawing.Point(324, 122);
            this.txttotalpago.Name = "txttotalpago";
            this.txttotalpago.ReadOnly = true;
            this.txttotalpago.Size = new System.Drawing.Size(100, 30);
            this.txttotalpago.TabIndex = 13;
            // 
            // lbltotalpago
            // 
            this.lbltotalpago.AutoSize = true;
            this.lbltotalpago.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalpago.Location = new System.Drawing.Point(88, 127);
            this.lbltotalpago.Name = "lbltotalpago";
            this.lbltotalpago.Size = new System.Drawing.Size(230, 25);
            this.lbltotalpago.TabIndex = 12;
            this.lbltotalpago.Text = "O total a ser pago é: R$";
            // 
            // txtquantidadelivros
            // 
            this.txtquantidadelivros.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtquantidadelivros.Location = new System.Drawing.Point(324, 32);
            this.txtquantidadelivros.Name = "txtquantidadelivros";
            this.txtquantidadelivros.Size = new System.Drawing.Size(100, 30);
            this.txtquantidadelivros.TabIndex = 11;
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.Location = new System.Drawing.Point(39, 37);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(279, 25);
            this.lblnome.TabIndex = 10;
            this.lblnome.Text = "Insira a quantidade de livros:";
            // 
            // frmexercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txttotalpago);
            this.Controls.Add(this.lbltotalpago);
            this.Controls.Add(this.txtquantidadelivros);
            this.Controls.Add(this.lblnome);
            this.Name = "frmexercicio3";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.TextBox txttotalpago;
        private System.Windows.Forms.Label lbltotalpago;
        private System.Windows.Forms.TextBox txtquantidadelivros;
        private System.Windows.Forms.Label lblnome;
    }
}