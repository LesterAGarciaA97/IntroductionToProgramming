namespace DemoClases
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
            this.ejecutarDemo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ejecutarDemo
            // 
            this.ejecutarDemo.Location = new System.Drawing.Point(42, 87);
            this.ejecutarDemo.Name = "ejecutarDemo";
            this.ejecutarDemo.Size = new System.Drawing.Size(140, 23);
            this.ejecutarDemo.TabIndex = 0;
            this.ejecutarDemo.Text = "Ejecutar Demo";
            this.ejecutarDemo.UseVisualStyleBackColor = true;
            this.ejecutarDemo.Click += new System.EventHandler(this.ejecutarDemo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ejecutarDemo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ejecutarDemo;
    }
}

