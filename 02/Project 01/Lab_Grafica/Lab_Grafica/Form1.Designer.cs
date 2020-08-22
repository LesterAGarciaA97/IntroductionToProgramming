namespace Lab_Grafica
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
            this.btn_Graficar = new System.Windows.Forms.Button();
            this.ptb_grafica = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_grafica)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Graficar
            // 
            this.btn_Graficar.Location = new System.Drawing.Point(154, 482);
            this.btn_Graficar.Name = "btn_Graficar";
            this.btn_Graficar.Size = new System.Drawing.Size(393, 41);
            this.btn_Graficar.TabIndex = 4;
            this.btn_Graficar.Text = "Grafica líneas";
            this.btn_Graficar.UseVisualStyleBackColor = true;
            this.btn_Graficar.Click += new System.EventHandler(this.btn_Graficar_Click);
            // 
            // ptb_grafica
            // 
            this.ptb_grafica.Location = new System.Drawing.Point(6, 12);
            this.ptb_grafica.Name = "ptb_grafica";
            this.ptb_grafica.Size = new System.Drawing.Size(682, 447);
            this.ptb_grafica.TabIndex = 3;
            this.ptb_grafica.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 535);
            this.Controls.Add(this.btn_Graficar);
            this.Controls.Add(this.ptb_grafica);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ptb_grafica)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Graficar;
        private System.Windows.Forms.PictureBox ptb_grafica;
    }
}

