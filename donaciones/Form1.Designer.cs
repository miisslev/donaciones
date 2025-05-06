namespace donaciones
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblMetodo = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.cmbMetodoPago = new System.Windows.Forms.ComboBox();
            this.chkAnonima = new System.Windows.Forms.CheckBox();
            this.btnDonar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.BackColor = System.Drawing.Color.Thistle;
            this.lblMonto.Location = new System.Drawing.Point(104, 67);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(44, 16);
            this.lblMonto.TabIndex = 0;
            this.lblMonto.Text = "Monto";
            // 
            // lblMetodo
            // 
            this.lblMetodo.AutoSize = true;
            this.lblMetodo.BackColor = System.Drawing.Color.Thistle;
            this.lblMetodo.Location = new System.Drawing.Point(104, 132);
            this.lblMetodo.Name = "lblMetodo";
            this.lblMetodo.Size = new System.Drawing.Size(107, 16);
            this.lblMetodo.TabIndex = 1;
            this.lblMetodo.Text = "Método de pago";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(265, 61);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(214, 22);
            this.txtMonto.TabIndex = 2;
            // 
            // cmbMetodoPago
            // 
            this.cmbMetodoPago.FormattingEnabled = true;
            this.cmbMetodoPago.Location = new System.Drawing.Point(265, 124);
            this.cmbMetodoPago.Name = "cmbMetodoPago";
            this.cmbMetodoPago.Size = new System.Drawing.Size(221, 24);
            this.cmbMetodoPago.TabIndex = 3;
            this.cmbMetodoPago.SelectedIndexChanged += new System.EventHandler(this.cmbMetodoPago_SelectedIndexChanged);
            // 
            // chkAnonima
            // 
            this.chkAnonima.AutoSize = true;
            this.chkAnonima.Location = new System.Drawing.Point(528, 94);
            this.chkAnonima.Name = "chkAnonima";
            this.chkAnonima.Size = new System.Drawing.Size(158, 20);
            this.chkAnonima.TabIndex = 4;
            this.chkAnonima.Text = "Donar anónimamente";
            this.chkAnonima.UseVisualStyleBackColor = true;
            // 
            // btnDonar
            // 
            this.btnDonar.BackColor = System.Drawing.Color.Thistle;
            this.btnDonar.Location = new System.Drawing.Point(107, 232);
            this.btnDonar.Name = "btnDonar";
            this.btnDonar.Size = new System.Drawing.Size(117, 52);
            this.btnDonar.TabIndex = 5;
            this.btnDonar.Text = "Donar";
            this.btnDonar.UseVisualStyleBackColor = false;
            this.btnDonar.Click += new System.EventHandler(this.btnDonar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDonar);
            this.Controls.Add(this.chkAnonima);
            this.Controls.Add(this.cmbMetodoPago);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.lblMetodo);
            this.Controls.Add(this.lblMonto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblMetodo;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.ComboBox cmbMetodoPago;
        private System.Windows.Forms.CheckBox chkAnonima;
        private System.Windows.Forms.Button btnDonar;
    }
}

