namespace Lab9_Ejemplo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.mtxt_numero = new System.Windows.Forms.MaskedTextBox();
            this.btn_Pserie1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_serie = new System.Windows.Forms.Label();
            this.btn_Fserie1 = new System.Windows.Forms.Button();
            this.lbl_numero = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mtxt_numero
            // 
            this.mtxt_numero.Location = new System.Drawing.Point(183, 19);
            this.mtxt_numero.Mask = "99999";
            this.mtxt_numero.Name = "mtxt_numero";
            this.mtxt_numero.Size = new System.Drawing.Size(100, 20);
            this.mtxt_numero.TabIndex = 0;
            this.mtxt_numero.ValidatingType = typeof(int);
            // 
            // btn_Pserie1
            // 
            this.btn_Pserie1.Location = new System.Drawing.Point(28, 92);
            this.btn_Pserie1.Name = "btn_Pserie1";
            this.btn_Pserie1.Size = new System.Drawing.Size(147, 40);
            this.btn_Pserie1.TabIndex = 1;
            this.btn_Pserie1.Text = "Resolver con procedimiento";
            this.btn_Pserie1.UseVisualStyleBackColor = true;
            this.btn_Pserie1.Click += new System.EventHandler(this.btn_serie1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_numero);
            this.groupBox1.Controls.Add(this.btn_Fserie1);
            this.groupBox1.Controls.Add(this.lbl_serie);
            this.groupBox1.Controls.Add(this.btn_Pserie1);
            this.groupBox1.Controls.Add(this.mtxt_numero);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 173);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Problema 1 - Serie 1";
            // 
            // lbl_serie
            // 
            this.lbl_serie.AutoSize = true;
            this.lbl_serie.Location = new System.Drawing.Point(6, 62);
            this.lbl_serie.Name = "lbl_serie";
            this.lbl_serie.Size = new System.Drawing.Size(29, 13);
            this.lbl_serie.TabIndex = 2;
            this.lbl_serie.Text = "serie";
            // 
            // btn_Fserie1
            // 
            this.btn_Fserie1.Location = new System.Drawing.Point(207, 92);
            this.btn_Fserie1.Name = "btn_Fserie1";
            this.btn_Fserie1.Size = new System.Drawing.Size(147, 40);
            this.btn_Fserie1.TabIndex = 3;
            this.btn_Fserie1.Text = "Resolver con función";
            this.btn_Fserie1.UseVisualStyleBackColor = true;
            this.btn_Fserie1.Click += new System.EventHandler(this.btn_Fserie1_Click);
            // 
            // lbl_numero
            // 
            this.lbl_numero.AutoSize = true;
            this.lbl_numero.Location = new System.Drawing.Point(47, 22);
            this.lbl_numero.Name = "lbl_numero";
            this.lbl_numero.Size = new System.Drawing.Size(95, 13);
            this.lbl_numero.TabIndex = 4;
            this.lbl_numero.Text = "Ingrese un número";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 262);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtxt_numero;
        private System.Windows.Forms.Button btn_Pserie1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_serie;
        private System.Windows.Forms.Button btn_Fserie1;
        private System.Windows.Forms.Label lbl_numero;
    }
}

