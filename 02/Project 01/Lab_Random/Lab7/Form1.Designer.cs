namespace Lab7
{
    partial class Form1
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
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.btn_random = new System.Windows.Forms.Button();
            this.lbx_votos = new System.Windows.Forms.ListBox();
            this.lbl_rojo = new System.Windows.Forms.Label();
            this.lbl_azul = new System.Windows.Forms.Label();
            this.lbl_naranja = new System.Windows.Forms.Label();
            this.lbl_amarillo = new System.Windows.Forms.Label();
            this.lbl_verde = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(99, 24);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(100, 20);
            this.txt_numero.TabIndex = 0;
            // 
            // btn_random
            // 
            this.btn_random.Location = new System.Drawing.Point(223, 22);
            this.btn_random.Name = "btn_random";
            this.btn_random.Size = new System.Drawing.Size(75, 23);
            this.btn_random.TabIndex = 1;
            this.btn_random.Text = "Calcular";
            this.btn_random.UseVisualStyleBackColor = true;
            this.btn_random.Click += new System.EventHandler(this.btn_random_Click);
            // 
            // lbx_votos
            // 
            this.lbx_votos.FormattingEnabled = true;
            this.lbx_votos.Location = new System.Drawing.Point(42, 82);
            this.lbx_votos.Name = "lbx_votos";
            this.lbx_votos.Size = new System.Drawing.Size(157, 199);
            this.lbx_votos.TabIndex = 2;
            // 
            // lbl_rojo
            // 
            this.lbl_rojo.AutoSize = true;
            this.lbl_rojo.Location = new System.Drawing.Point(303, 114);
            this.lbl_rojo.Name = "lbl_rojo";
            this.lbl_rojo.Size = new System.Drawing.Size(59, 13);
            this.lbl_rojo.TabIndex = 3;
            this.lbl_rojo.Text = "Votos Rojo";
            // 
            // lbl_azul
            // 
            this.lbl_azul.AutoSize = true;
            this.lbl_azul.Location = new System.Drawing.Point(303, 144);
            this.lbl_azul.Name = "lbl_azul";
            this.lbl_azul.Size = new System.Drawing.Size(57, 13);
            this.lbl_azul.TabIndex = 4;
            this.lbl_azul.Text = "Votos Azul";
            // 
            // lbl_naranja
            // 
            this.lbl_naranja.AutoSize = true;
            this.lbl_naranja.Location = new System.Drawing.Point(303, 174);
            this.lbl_naranja.Name = "lbl_naranja";
            this.lbl_naranja.Size = new System.Drawing.Size(72, 13);
            this.lbl_naranja.TabIndex = 5;
            this.lbl_naranja.Text = "Votos naranja";
            // 
            // lbl_amarillo
            // 
            this.lbl_amarillo.AutoSize = true;
            this.lbl_amarillo.Location = new System.Drawing.Point(303, 204);
            this.lbl_amarillo.Name = "lbl_amarillo";
            this.lbl_amarillo.Size = new System.Drawing.Size(72, 13);
            this.lbl_amarillo.TabIndex = 6;
            this.lbl_amarillo.Text = "Votos amarillo";
            // 
            // lbl_verde
            // 
            this.lbl_verde.AutoSize = true;
            this.lbl_verde.Location = new System.Drawing.Point(303, 234);
            this.lbl_verde.Name = "lbl_verde";
            this.lbl_verde.Size = new System.Drawing.Size(65, 13);
            this.lbl_verde.TabIndex = 7;
            this.lbl_verde.Text = "Votos Verde";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Votos Verde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Votos amarillo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Votos naranja";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Votos Azul";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(229, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Votos Rojo";
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(327, 22);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_limpiar.TabIndex = 13;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "No. de personas:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(75, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Votos generados";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 308);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_verde);
            this.Controls.Add(this.lbl_amarillo);
            this.Controls.Add(this.lbl_naranja);
            this.Controls.Add(this.lbl_azul);
            this.Controls.Add(this.lbl_rojo);
            this.Controls.Add(this.lbx_votos);
            this.Controls.Add(this.btn_random);
            this.Controls.Add(this.txt_numero);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.Button btn_random;
        private System.Windows.Forms.ListBox lbx_votos;
        private System.Windows.Forms.Label lbl_rojo;
        private System.Windows.Forms.Label lbl_azul;
        private System.Windows.Forms.Label lbl_naranja;
        private System.Windows.Forms.Label lbl_amarillo;
        private System.Windows.Forms.Label lbl_verde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

