namespace AtividadeAppC_
{
    partial class frmexercicio1
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
            this.lbltotalpublico = new System.Windows.Forms.Label();
            this.txtpublicototal = new System.Windows.Forms.TextBox();
            this.txtrendatotal = new System.Windows.Forms.TextBox();
            this.lblrendatotal = new System.Windows.Forms.Label();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbltotalpublico
            // 
            this.lbltotalpublico.AutoSize = true;
            this.lbltotalpublico.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalpublico.Location = new System.Drawing.Point(80, 107);
            this.lbltotalpublico.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltotalpublico.Name = "lbltotalpublico";
            this.lbltotalpublico.Size = new System.Drawing.Size(214, 25);
            this.lbltotalpublico.TabIndex = 0;
            this.lbltotalpublico.Text = "Insira o público total: ";
            // 
            // txtpublicototal
            // 
            this.txtpublicototal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtpublicototal.Location = new System.Drawing.Point(421, 101);
            this.txtpublicototal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtpublicototal.Name = "txtpublicototal";
            this.txtpublicototal.Size = new System.Drawing.Size(132, 30);
            this.txtpublicototal.TabIndex = 1;
            // 
            // txtrendatotal
            // 
            this.txtrendatotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtrendatotal.Location = new System.Drawing.Point(421, 212);
            this.txtrendatotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtrendatotal.Name = "txtrendatotal";
            this.txtrendatotal.ReadOnly = true;
            this.txtrendatotal.Size = new System.Drawing.Size(132, 30);
            this.txtrendatotal.TabIndex = 3;
            // 
            // lblrendatotal
            // 
            this.lblrendatotal.AutoSize = true;
            this.lblrendatotal.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrendatotal.Location = new System.Drawing.Point(80, 218);
            this.lblrendatotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblrendatotal.Name = "lblrendatotal";
            this.lblrendatotal.Size = new System.Drawing.Size(264, 25);
            this.lblrendatotal.TabIndex = 2;
            this.lblrendatotal.Text = "A renda total do jogo é: R$";
            // 
            // btncalcular
            // 
            this.btncalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btncalcular.Location = new System.Drawing.Point(142, 346);
            this.btncalcular.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(167, 50);
            this.btncalcular.TabIndex = 4;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnlimpar.Location = new System.Drawing.Point(350, 346);
            this.btnlimpar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(167, 50);
            this.btnlimpar.TabIndex = 5;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnvoltar.Location = new System.Drawing.Point(565, 346);
            this.btnvoltar.Margin = new System.Windows.Forms.Padding(4);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(167, 50);
            this.btnvoltar.TabIndex = 6;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // frmexercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtrendatotal);
            this.Controls.Add(this.lblrendatotal);
            this.Controls.Add(this.txtpublicototal);
            this.Controls.Add(this.lbltotalpublico);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmexercicio1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltotalpublico;
        private System.Windows.Forms.TextBox txtpublicototal;
        private System.Windows.Forms.TextBox txtrendatotal;
        private System.Windows.Forms.Label lblrendatotal;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnvoltar;
    }
}