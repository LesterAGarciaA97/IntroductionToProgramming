namespace Lab2_Lester_Andrés_García_Aquino_1003115
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
            this.gb_problema1 = new System.Windows.Forms.GroupBox();
            this.btn_elegir = new System.Windows.Forms.Button();
            this.cb_opciones = new System.Windows.Forms.ComboBox();
            this.lb_resultado = new System.Windows.Forms.Label();
            this.gb_problema2 = new System.Windows.Forms.GroupBox();
            this.btn_iniciar = new System.Windows.Forms.Button();
            this.btn_detener = new System.Windows.Forms.Button();
            this.lb_cronometro = new System.Windows.Forms.Label();
            this.t_tiempo = new System.Windows.Forms.Timer(this.components);
            this.gb_problema1.SuspendLayout();
            this.gb_problema2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_problema1
            // 
            this.gb_problema1.Controls.Add(this.btn_elegir);
            this.gb_problema1.Controls.Add(this.cb_opciones);
            this.gb_problema1.Controls.Add(this.lb_resultado);
            this.gb_problema1.Location = new System.Drawing.Point(12, 12);
            this.gb_problema1.Name = "gb_problema1";
            this.gb_problema1.Size = new System.Drawing.Size(327, 97);
            this.gb_problema1.TabIndex = 0;
            this.gb_problema1.TabStop = false;
            this.gb_problema1.Text = "Problema 1";
            // 
            // btn_elegir
            // 
            this.btn_elegir.Location = new System.Drawing.Point(97, 68);
            this.btn_elegir.Name = "btn_elegir";
            this.btn_elegir.Size = new System.Drawing.Size(75, 23);
            this.btn_elegir.TabIndex = 2;
            this.btn_elegir.Text = "Elegir";
            this.btn_elegir.UseVisualStyleBackColor = true;
            this.btn_elegir.Click += new System.EventHandler(this.btn_elegir_Click);
            // 
            // cb_opciones
            // 
            this.cb_opciones.FormattingEnabled = true;
            this.cb_opciones.Items.AddRange(new object[] {
            "Guatemala",
            "El Salvador",
            "Honduras",
            "Nicaragua",
            "Costa Rica"});
            this.cb_opciones.Location = new System.Drawing.Point(200, 19);
            this.cb_opciones.Name = "cb_opciones";
            this.cb_opciones.Size = new System.Drawing.Size(121, 21);
            this.cb_opciones.TabIndex = 1;
            // 
            // lb_resultado
            // 
            this.lb_resultado.AutoSize = true;
            this.lb_resultado.Location = new System.Drawing.Point(6, 25);
            this.lb_resultado.Name = "lb_resultado";
            this.lb_resultado.Size = new System.Drawing.Size(119, 13);
            this.lb_resultado.TabIndex = 0;
            this.lb_resultado.Text = "País de Centro América";
            // 
            // gb_problema2
            // 
            this.gb_problema2.Controls.Add(this.lb_cronometro);
            this.gb_problema2.Controls.Add(this.btn_detener);
            this.gb_problema2.Controls.Add(this.btn_iniciar);
            this.gb_problema2.Location = new System.Drawing.Point(360, 12);
            this.gb_problema2.Name = "gb_problema2";
            this.gb_problema2.Size = new System.Drawing.Size(327, 97);
            this.gb_problema2.TabIndex = 1;
            this.gb_problema2.TabStop = false;
            this.gb_problema2.Text = "Problema 2";
            // 
            // btn_iniciar
            // 
            this.btn_iniciar.Location = new System.Drawing.Point(78, 67);
            this.btn_iniciar.Name = "btn_iniciar";
            this.btn_iniciar.Size = new System.Drawing.Size(75, 23);
            this.btn_iniciar.TabIndex = 0;
            this.btn_iniciar.Text = "Iniciar";
            this.btn_iniciar.UseVisualStyleBackColor = true;
            this.btn_iniciar.Click += new System.EventHandler(this.btn_iniciar_Click);
            // 
            // btn_detener
            // 
            this.btn_detener.Location = new System.Drawing.Point(215, 67);
            this.btn_detener.Name = "btn_detener";
            this.btn_detener.Size = new System.Drawing.Size(75, 23);
            this.btn_detener.TabIndex = 1;
            this.btn_detener.Text = "Detener";
            this.btn_detener.UseVisualStyleBackColor = true;
            this.btn_detener.Click += new System.EventHandler(this.btn_detener_Click);
            // 
            // lb_cronometro
            // 
            this.lb_cronometro.AutoSize = true;
            this.lb_cronometro.Location = new System.Drawing.Point(154, 27);
            this.lb_cronometro.Name = "lb_cronometro";
            this.lb_cronometro.Size = new System.Drawing.Size(61, 13);
            this.lb_cronometro.TabIndex = 2;
            this.lb_cronometro.Text = "Cronómetro";
            // 
            // t_tiempo
            // 
            this.t_tiempo.Interval = 1000;
            this.t_tiempo.Tick += new System.EventHandler(this.t_tiempo_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 134);
            this.Controls.Add(this.gb_problema2);
            this.Controls.Add(this.gb_problema1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gb_problema1.ResumeLayout(false);
            this.gb_problema1.PerformLayout();
            this.gb_problema2.ResumeLayout(false);
            this.gb_problema2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_problema1;
        private System.Windows.Forms.Button btn_elegir;
        private System.Windows.Forms.ComboBox cb_opciones;
        private System.Windows.Forms.Label lb_resultado;
        private System.Windows.Forms.GroupBox gb_problema2;
        private System.Windows.Forms.Label lb_cronometro;
        private System.Windows.Forms.Button btn_detener;
        private System.Windows.Forms.Button btn_iniciar;
        private System.Windows.Forms.Timer t_tiempo;
    }
}

