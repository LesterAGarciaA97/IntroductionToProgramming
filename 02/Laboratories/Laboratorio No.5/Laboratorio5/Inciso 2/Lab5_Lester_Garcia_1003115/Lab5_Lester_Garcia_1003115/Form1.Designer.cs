namespace Lab5_Lester_Garcia_1003115
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
            this.gb_problema2 = new System.Windows.Forms.GroupBox();
            this.lbx_resultados = new System.Windows.Forms.ListBox();
            this.btn_residuo = new System.Windows.Forms.Button();
            this.btn_division = new System.Windows.Forms.Button();
            this.btn_resta = new System.Windows.Forms.Button();
            this.btn_suma = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mtxt_numero2 = new System.Windows.Forms.MaskedTextBox();
            this.mtxt_numero1 = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.gb_problema2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_problema2
            // 
            this.gb_problema2.Controls.Add(this.button1);
            this.gb_problema2.Controls.Add(this.lbx_resultados);
            this.gb_problema2.Controls.Add(this.btn_residuo);
            this.gb_problema2.Controls.Add(this.btn_division);
            this.gb_problema2.Controls.Add(this.btn_resta);
            this.gb_problema2.Controls.Add(this.btn_suma);
            this.gb_problema2.Controls.Add(this.label3);
            this.gb_problema2.Controls.Add(this.label2);
            this.gb_problema2.Controls.Add(this.mtxt_numero2);
            this.gb_problema2.Controls.Add(this.mtxt_numero1);
            this.gb_problema2.Controls.Add(this.label1);
            this.gb_problema2.Location = new System.Drawing.Point(12, 12);
            this.gb_problema2.Name = "gb_problema2";
            this.gb_problema2.Size = new System.Drawing.Size(260, 321);
            this.gb_problema2.TabIndex = 0;
            this.gb_problema2.TabStop = false;
            this.gb_problema2.Text = "Problema 2";
            // 
            // lbx_resultados
            // 
            this.lbx_resultados.FormattingEnabled = true;
            this.lbx_resultados.Location = new System.Drawing.Point(6, 192);
            this.lbx_resultados.Name = "lbx_resultados";
            this.lbx_resultados.Size = new System.Drawing.Size(145, 121);
            this.lbx_resultados.TabIndex = 9;
            // 
            // btn_residuo
            // 
            this.btn_residuo.Location = new System.Drawing.Point(129, 134);
            this.btn_residuo.Name = "btn_residuo";
            this.btn_residuo.Size = new System.Drawing.Size(75, 23);
            this.btn_residuo.TabIndex = 8;
            this.btn_residuo.Text = "MOD";
            this.btn_residuo.UseVisualStyleBackColor = true;
            this.btn_residuo.Click += new System.EventHandler(this.btn_residuo_Click);
            // 
            // btn_division
            // 
            this.btn_division.Location = new System.Drawing.Point(48, 134);
            this.btn_division.Name = "btn_division";
            this.btn_division.Size = new System.Drawing.Size(75, 23);
            this.btn_division.TabIndex = 7;
            this.btn_division.Text = "DIV";
            this.btn_division.UseVisualStyleBackColor = true;
            this.btn_division.Click += new System.EventHandler(this.btn_division_Click);
            // 
            // btn_resta
            // 
            this.btn_resta.Location = new System.Drawing.Point(129, 105);
            this.btn_resta.Name = "btn_resta";
            this.btn_resta.Size = new System.Drawing.Size(75, 23);
            this.btn_resta.TabIndex = 6;
            this.btn_resta.Text = "-";
            this.btn_resta.UseVisualStyleBackColor = true;
            this.btn_resta.Click += new System.EventHandler(this.btn_resta_Click);
            // 
            // btn_suma
            // 
            this.btn_suma.Location = new System.Drawing.Point(48, 105);
            this.btn_suma.Name = "btn_suma";
            this.btn_suma.Size = new System.Drawing.Size(75, 23);
            this.btn_suma.TabIndex = 5;
            this.btn_suma.Text = "+";
            this.btn_suma.UseVisualStyleBackColor = true;
            this.btn_suma.Click += new System.EventHandler(this.btn_suma_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Número 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Número 1";
            // 
            // mtxt_numero2
            // 
            this.mtxt_numero2.Location = new System.Drawing.Point(154, 65);
            this.mtxt_numero2.Mask = "00000";
            this.mtxt_numero2.Name = "mtxt_numero2";
            this.mtxt_numero2.Size = new System.Drawing.Size(100, 20);
            this.mtxt_numero2.TabIndex = 2;
            // 
            // mtxt_numero1
            // 
            this.mtxt_numero1.Location = new System.Drawing.Point(6, 65);
            this.mtxt_numero1.Mask = "00000";
            this.mtxt_numero1.Name = "mtxt_numero1";
            this.mtxt_numero1.Size = new System.Drawing.Size(100, 20);
            this.mtxt_numero1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operaciones Artitméticas";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(167, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Limpiar lista";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 345);
            this.Controls.Add(this.gb_problema2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gb_problema2.ResumeLayout(false);
            this.gb_problema2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_problema2;
        private System.Windows.Forms.ListBox lbx_resultados;
        private System.Windows.Forms.Button btn_residuo;
        private System.Windows.Forms.Button btn_division;
        private System.Windows.Forms.Button btn_resta;
        private System.Windows.Forms.Button btn_suma;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtxt_numero2;
        private System.Windows.Forms.MaskedTextBox mtxt_numero1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

