namespace Ejercicios_Adicionales_1_y_2
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
            this.components = new System.ComponentModel.Container();
            this.gb_Adcional_1 = new System.Windows.Forms.GroupBox();
            this.cb_materias = new System.Windows.Forms.ComboBox();
            this.cb_Nombres = new System.Windows.Forms.ComboBox();
            this.btn_Procesar = new System.Windows.Forms.Button();
            this.lb_Informacion = new System.Windows.Forms.Label();
            this.gb_Adcional_2 = new System.Windows.Forms.GroupBox();
            this.btn_iniciar = new System.Windows.Forms.Button();
            this.lb_cronómetro = new System.Windows.Forms.Label();
            this.t_timer = new System.Windows.Forms.Timer(this.components);
            this.btn_detener = new System.Windows.Forms.Button();
            this.gb_Adcional_1.SuspendLayout();
            this.gb_Adcional_2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Adcional_1
            // 
            this.gb_Adcional_1.Controls.Add(this.lb_Informacion);
            this.gb_Adcional_1.Controls.Add(this.btn_Procesar);
            this.gb_Adcional_1.Controls.Add(this.cb_Nombres);
            this.gb_Adcional_1.Controls.Add(this.cb_materias);
            this.gb_Adcional_1.Location = new System.Drawing.Point(12, 12);
            this.gb_Adcional_1.Name = "gb_Adcional_1";
            this.gb_Adcional_1.Size = new System.Drawing.Size(311, 146);
            this.gb_Adcional_1.TabIndex = 0;
            this.gb_Adcional_1.TabStop = false;
            this.gb_Adcional_1.Text = "Ejercicio Adicional #1";
            // 
            // cb_materias
            // 
            this.cb_materias.FormattingEnabled = true;
            this.cb_materias.Items.AddRange(new object[] {
            "Matemática I",
            "Física I",
            "Introducción a la programación",
            "Magis Landivariano",
            "Matemática Discreta II"});
            this.cb_materias.Location = new System.Drawing.Point(184, 28);
            this.cb_materias.Name = "cb_materias";
            this.cb_materias.Size = new System.Drawing.Size(121, 21);
            this.cb_materias.TabIndex = 0;
            // 
            // cb_Nombres
            // 
            this.cb_Nombres.FormattingEnabled = true;
            this.cb_Nombres.Items.AddRange(new object[] {
            "Lester García",
            "Alejandra Castillo",
            "Carlos Guzmán",
            "Javier López",
            "Fernando Granados"});
            this.cb_Nombres.Location = new System.Drawing.Point(6, 28);
            this.cb_Nombres.Name = "cb_Nombres";
            this.cb_Nombres.Size = new System.Drawing.Size(121, 21);
            this.cb_Nombres.TabIndex = 1;
            // 
            // btn_Procesar
            // 
            this.btn_Procesar.Location = new System.Drawing.Point(99, 117);
            this.btn_Procesar.Name = "btn_Procesar";
            this.btn_Procesar.Size = new System.Drawing.Size(119, 23);
            this.btn_Procesar.TabIndex = 2;
            this.btn_Procesar.Text = "Procesar Información";
            this.btn_Procesar.UseVisualStyleBackColor = true;
            this.btn_Procesar.Click += new System.EventHandler(this.btn_Procesar_Click);
            // 
            // lb_Informacion
            // 
            this.lb_Informacion.AutoSize = true;
            this.lb_Informacion.Location = new System.Drawing.Point(34, 86);
            this.lb_Informacion.Name = "lb_Informacion";
            this.lb_Informacion.Size = new System.Drawing.Size(0, 13);
            this.lb_Informacion.TabIndex = 3;
            // 
            // gb_Adcional_2
            // 
            this.gb_Adcional_2.Controls.Add(this.btn_detener);
            this.gb_Adcional_2.Controls.Add(this.lb_cronómetro);
            this.gb_Adcional_2.Controls.Add(this.btn_iniciar);
            this.gb_Adcional_2.Location = new System.Drawing.Point(352, 12);
            this.gb_Adcional_2.Name = "gb_Adcional_2";
            this.gb_Adcional_2.Size = new System.Drawing.Size(311, 146);
            this.gb_Adcional_2.TabIndex = 1;
            this.gb_Adcional_2.TabStop = false;
            this.gb_Adcional_2.Text = "Ejercicio Adicional #2";
            // 
            // btn_iniciar
            // 
            this.btn_iniciar.Location = new System.Drawing.Point(46, 117);
            this.btn_iniciar.Name = "btn_iniciar";
            this.btn_iniciar.Size = new System.Drawing.Size(103, 23);
            this.btn_iniciar.TabIndex = 0;
            this.btn_iniciar.Text = "Iniciar";
            this.btn_iniciar.UseVisualStyleBackColor = true;
            this.btn_iniciar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_cronómetro
            // 
            this.lb_cronómetro.AutoSize = true;
            this.lb_cronómetro.Location = new System.Drawing.Point(126, 64);
            this.lb_cronómetro.Name = "lb_cronómetro";
            this.lb_cronómetro.Size = new System.Drawing.Size(61, 13);
            this.lb_cronómetro.TabIndex = 1;
            this.lb_cronómetro.Text = "Cronómetro";
            // 
            // t_timer
            // 
            this.t_timer.Interval = 1000;
            this.t_timer.Tick += new System.EventHandler(this.t_timer_Tick);
            // 
            // btn_detener
            // 
            this.btn_detener.Location = new System.Drawing.Point(166, 117);
            this.btn_detener.Name = "btn_detener";
            this.btn_detener.Size = new System.Drawing.Size(107, 23);
            this.btn_detener.TabIndex = 2;
            this.btn_detener.Text = "Detener";
            this.btn_detener.UseVisualStyleBackColor = true;
            this.btn_detener.Click += new System.EventHandler(this.btn_detener_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 186);
            this.Controls.Add(this.gb_Adcional_2);
            this.Controls.Add(this.gb_Adcional_1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gb_Adcional_1.ResumeLayout(false);
            this.gb_Adcional_1.PerformLayout();
            this.gb_Adcional_2.ResumeLayout(false);
            this.gb_Adcional_2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Adcional_1;
        private System.Windows.Forms.Label lb_Informacion;
        private System.Windows.Forms.Button btn_Procesar;
        private System.Windows.Forms.ComboBox cb_Nombres;
        private System.Windows.Forms.ComboBox cb_materias;
        private System.Windows.Forms.GroupBox gb_Adcional_2;
        private System.Windows.Forms.Label lb_cronómetro;
        private System.Windows.Forms.Button btn_iniciar;
        private System.Windows.Forms.Timer t_timer;
        private System.Windows.Forms.Button btn_detener;
    }
}

