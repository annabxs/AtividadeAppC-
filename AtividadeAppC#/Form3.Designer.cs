namespace AtividadeAppC_
{
    partial class frmexercicio2
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
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.lblresultado = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.lblnome = new System.Windows.Forms.Label();
            this.txtidade = new System.Windows.Forms.TextBox();
            this.lblidade = new System.Windows.Forms.Label();
            this.txtsexo = new System.Windows.Forms.TextBox();
            this.lblsexo = new System.Windows.Forms.Label();
            this.txtsalario = new System.Windows.Forms.TextBox();
            this.lblsalario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncalcular
            // 
            this.btncalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btncalcular.Location = new System.Drawing.Point(181, 246);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(125, 41);
            this.btncalcular.TabIndex = 9;
            this.btncalcular.Text = "calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // txtresultado
            // 
            this.txtresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtresultado.Location = new System.Drawing.Point(297, 200);
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.ReadOnly = true;
            this.txtresultado.Size = new System.Drawing.Size(491, 30);
            this.txtresultado.TabIndex = 8;
            this.txtresultado.TextChanged += new System.EventHandler(this.txttotalpago_TextChanged);
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresultado.Location = new System.Drawing.Point(61, 205);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(230, 25);
            this.lblresultado.TabIndex = 7;
            this.lblresultado.Text = "O total a ser pago é: R$";
            this.lblresultado.Click += new System.EventHandler(this.lbltotalpago_Click);
            // 
            // txtnome
            // 
            this.txtnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtnome.Location = new System.Drawing.Point(297, 15);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(100, 30);
            this.txtnome.TabIndex = 6;
            this.txtnome.TextChanged += new System.EventHandler(this.txtnome_TextChanged);
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.Location = new System.Drawing.Point(146, 18);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(145, 25);
            this.lblnome.TabIndex = 5;
            this.lblnome.Text = "Insira o nome:";
            this.lblnome.Click += new System.EventHandler(this.lblnome_Click);
            // 
            // txtidade
            // 
            this.txtidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtidade.Location = new System.Drawing.Point(297, 51);
            this.txtidade.Name = "txtidade";
            this.txtidade.Size = new System.Drawing.Size(100, 30);
            this.txtidade.TabIndex = 11;
            this.txtidade.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblidade
            // 
            this.lblidade.AutoSize = true;
            this.lblidade.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidade.Location = new System.Drawing.Point(146, 54);
            this.lblidade.Name = "lblidade";
            this.lblidade.Size = new System.Drawing.Size(141, 25);
            this.lblidade.TabIndex = 10;
            this.lblidade.Text = "Insira a idade:";
            this.lblidade.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtsexo
            // 
            this.txtsexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtsexo.Location = new System.Drawing.Point(297, 87);
            this.txtsexo.Name = "txtsexo";
            this.txtsexo.Size = new System.Drawing.Size(100, 30);
            this.txtsexo.TabIndex = 13;
            // 
            // lblsexo
            // 
            this.lblsexo.AutoSize = true;
            this.lblsexo.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsexo.Location = new System.Drawing.Point(146, 90);
            this.lblsexo.Name = "lblsexo";
            this.lblsexo.Size = new System.Drawing.Size(133, 25);
            this.lblsexo.TabIndex = 12;
            this.lblsexo.Text = "Insira o sexo:";
            // 
            // txtsalario
            // 
            this.txtsalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtsalario.Location = new System.Drawing.Point(297, 123);
            this.txtsalario.Name = "txtsalario";
            this.txtsalario.Size = new System.Drawing.Size(100, 30);
            this.txtsalario.TabIndex = 15;
            // 
            // lblsalario
            // 
            this.lblsalario.AutoSize = true;
            this.lblsalario.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsalario.Location = new System.Drawing.Point(146, 126);
            this.lblsalario.Name = "lblsalario";
            this.lblsalario.Size = new System.Drawing.Size(151, 25);
            this.lblsalario.TabIndex = 14;
            this.lblsalario.Text = "Insira o salario:";
            // 
            // frmexercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtsalario);
            this.Controls.Add(this.lblsalario);
            this.Controls.Add(this.txtsexo);
            this.Controls.Add(this.lblsexo);
            this.Controls.Add(this.txtidade);
            this.Controls.Add(this.lblidade);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.lblnome);
            this.Name = "frmexercicio2";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.TextBox txtresultado;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.TextBox txtidade;
        private System.Windows.Forms.Label lblidade;
        private System.Windows.Forms.TextBox txtsexo;
        private System.Windows.Forms.Label lblsexo;
        private System.Windows.Forms.TextBox txtsalario;
        private System.Windows.Forms.Label lblsalario;
    }
}