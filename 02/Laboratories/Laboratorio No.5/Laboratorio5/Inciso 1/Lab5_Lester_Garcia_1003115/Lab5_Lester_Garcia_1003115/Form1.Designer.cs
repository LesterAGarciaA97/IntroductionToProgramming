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
            this.gb_problema1 = new System.Windows.Forms.GroupBox();
            this.lb_Nombre = new System.Windows.Forms.Label();
            this.lb_Apellido = new System.Windows.Forms.Label();
            this.lb_fecha = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.mtxt_fecha = new System.Windows.Forms.MaskedTextBox();
            this.btn_mensaje = new System.Windows.Forms.Button();
            this.gb_problema1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_problema1
            // 
            this.gb_problema1.Controls.Add(this.btn_mensaje);
            this.gb_problema1.Controls.Add(this.mtxt_fecha);
            this.gb_problema1.Controls.Add(this.txt_apellido);
            this.gb_problema1.Controls.Add(this.txt_nombre);
            this.gb_problema1.Controls.Add(this.lb_fecha);
            this.gb_problema1.Controls.Add(this.lb_Apellido);
            this.gb_problema1.Controls.Add(this.lb_Nombre);
            this.gb_problema1.Location = new System.Drawing.Point(12, 12);
            this.gb_problema1.Name = "gb_problema1";
            this.gb_problema1.Size = new System.Drawing.Size(227, 151);
            this.gb_problema1.TabIndex = 0;
            this.gb_problema1.TabStop = false;
            this.gb_problema1.Text = "Problema 1";
            // 
            // lb_Nombre
            // 
            this.lb_Nombre.AutoSize = true;
            this.lb_Nombre.Location = new System.Drawing.Point(7, 31);
            this.lb_Nombre.Name = "lb_Nombre";
            this.lb_Nombre.Size = new System.Drawing.Size(44, 13);
            this.lb_Nombre.TabIndex = 0;
            this.lb_Nombre.Text = "Nombre";
            // 
            // lb_Apellido
            // 
            this.lb_Apellido.AutoSize = true;
            this.lb_Apellido.Location = new System.Drawing.Point(6, 56);
            this.lb_Apellido.Name = "lb_Apellido";
            this.lb_Apellido.Size = new System.Drawing.Size(44, 13);
            this.lb_Apellido.TabIndex = 1;
            this.lb_Apellido.Text = "Apellido";
            // 
            // lb_fecha
            // 
            this.lb_fecha.AutoSize = true;
            this.lb_fecha.Location = new System.Drawing.Point(6, 81);
            this.lb_fecha.Name = "lb_fecha";
            this.lb_fecha.Size = new System.Drawing.Size(26, 13);
            this.lb_fecha.TabIndex = 2;
            this.lb_fecha.Text = "Año";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(75, 28);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(146, 20);
            this.txt_nombre.TabIndex = 3;
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(75, 53);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(146, 20);
            this.txt_apellido.TabIndex = 4;
            // 
            // mtxt_fecha
            // 
            this.mtxt_fecha.Location = new System.Drawing.Point(75, 78);
            this.mtxt_fecha.Mask = "0000";
            this.mtxt_fecha.Name = "mtxt_fecha";
            this.mtxt_fecha.Size = new System.Drawing.Size(146, 20);
            this.mtxt_fecha.TabIndex = 5;
            // 
            // btn_mensaje
            // 
            this.btn_mensaje.Location = new System.Drawing.Point(85, 113);
            this.btn_mensaje.Name = "btn_mensaje";
            this.btn_mensaje.Size = new System.Drawing.Size(75, 23);
            this.btn_mensaje.TabIndex = 6;
            this.btn_mensaje.Text = "Ver mensaje";
            this.btn_mensaje.UseVisualStyleBackColor = true;
            this.btn_mensaje.Click += new System.EventHandler(this.btn_mensaje_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 171);
            this.Controls.Add(this.gb_problema1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gb_problema1.ResumeLayout(false);
            this.gb_problema1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_problema1;
        private System.Windows.Forms.Button btn_mensaje;
        private System.Windows.Forms.MaskedTextBox mtxt_fecha;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lb_fecha;
        private System.Windows.Forms.Label lb_Apellido;
        private System.Windows.Forms.Label lb_Nombre;
    }
}

