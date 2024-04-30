namespace FormsTestDelete
{
    partial class FormHome
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
            this.labelSaludo = new System.Windows.Forms.Label();
            this.labelSaldoTarjeta = new System.Windows.Forms.Label();
            this.labelSaldoEfectivo = new System.Windows.Forms.Label();
            this.textBoxSaldoTarjeta = new System.Windows.Forms.TextBox();
            this.textBoxSaldoEfectivo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelSaludo
            // 
            this.labelSaludo.AutoSize = true;
            this.labelSaludo.Location = new System.Drawing.Point(326, 51);
            this.labelSaludo.Name = "labelSaludo";
            this.labelSaludo.Size = new System.Drawing.Size(89, 16);
            this.labelSaludo.TabIndex = 1;
            this.labelSaludo.Text = "BIENVENIDO";
            this.labelSaludo.Click += new System.EventHandler(this.labelSaludo_Click);
            // 
            // labelSaldoTarjeta
            // 
            this.labelSaldoTarjeta.AutoSize = true;
            this.labelSaldoTarjeta.Location = new System.Drawing.Point(64, 95);
            this.labelSaldoTarjeta.Name = "labelSaldoTarjeta";
            this.labelSaldoTarjeta.Size = new System.Drawing.Size(107, 16);
            this.labelSaldoTarjeta.TabIndex = 2;
            this.labelSaldoTarjeta.Text = "Saldo en tarjeta: ";
            // 
            // labelSaldoEfectivo
            // 
            this.labelSaldoEfectivo.AutoSize = true;
            this.labelSaldoEfectivo.Location = new System.Drawing.Point(64, 124);
            this.labelSaldoEfectivo.Name = "labelSaldoEfectivo";
            this.labelSaldoEfectivo.Size = new System.Drawing.Size(117, 16);
            this.labelSaldoEfectivo.TabIndex = 3;
            this.labelSaldoEfectivo.Text = "Saldo en efectivo: ";
            // 
            // textBoxSaldoTarjeta
            // 
            this.textBoxSaldoTarjeta.Location = new System.Drawing.Point(198, 88);
            this.textBoxSaldoTarjeta.Name = "textBoxSaldoTarjeta";
            this.textBoxSaldoTarjeta.Size = new System.Drawing.Size(132, 22);
            this.textBoxSaldoTarjeta.TabIndex = 4;
            this.textBoxSaldoTarjeta.TextChanged += new System.EventHandler(this.textBoxSaldoTarjeta_TextChanged);
            // 
            // textBoxSaldoEfectivo
            // 
            this.textBoxSaldoEfectivo.Location = new System.Drawing.Point(198, 121);
            this.textBoxSaldoEfectivo.Name = "textBoxSaldoEfectivo";
            this.textBoxSaldoEfectivo.Size = new System.Drawing.Size(132, 22);
            this.textBoxSaldoEfectivo.TabIndex = 5;
            this.textBoxSaldoEfectivo.TextChanged += new System.EventHandler(this.textBoxSaldoEfectivo_TextChanged);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxSaldoEfectivo);
            this.Controls.Add(this.textBoxSaldoTarjeta);
            this.Controls.Add(this.labelSaldoEfectivo);
            this.Controls.Add(this.labelSaldoTarjeta);
            this.Controls.Add(this.labelSaludo);
            this.Name = "FormHome";
            this.Text = "PRINCIPAL";
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelSaludo;
        private System.Windows.Forms.Label labelSaldoTarjeta;
        private System.Windows.Forms.Label labelSaldoEfectivo;
        private System.Windows.Forms.TextBox textBoxSaldoTarjeta;
        private System.Windows.Forms.TextBox textBoxSaldoEfectivo;
    }
}