﻿namespace Intro_a_la_Progra
{
    partial class votante
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
            this.btnVotar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnVotarAleatorio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCantidadAleatorios = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbPartidos = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVotar
            // 
            this.btnVotar.Location = new System.Drawing.Point(33, 162);
            this.btnVotar.Name = "btnVotar";
            this.btnVotar.Size = new System.Drawing.Size(132, 23);
            this.btnVotar.TabIndex = 1;
            this.btnVotar.Text = "Realizar Voto";
            this.btnVotar.UseVisualStyleBackColor = true;
            this.btnVotar.Click += new System.EventHandler(this.btnVotar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnVotarAleatorio);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCantidadAleatorios);
            this.groupBox1.Location = new System.Drawing.Point(33, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 144);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Votos Aleatorios";
            // 
            // btnVotarAleatorio
            // 
            this.btnVotarAleatorio.Location = new System.Drawing.Point(148, 73);
            this.btnVotarAleatorio.Name = "btnVotarAleatorio";
            this.btnVotarAleatorio.Size = new System.Drawing.Size(143, 23);
            this.btnVotarAleatorio.TabIndex = 2;
            this.btnVotarAleatorio.Text = "Votar Aleatorio";
            this.btnVotarAleatorio.UseVisualStyleBackColor = true;
            this.btnVotarAleatorio.Click += new System.EventHandler(this.btnVotarAleatorio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese cantidad de votos a realizar";
            // 
            // txtCantidadAleatorios
            // 
            this.txtCantidadAleatorios.Location = new System.Drawing.Point(14, 47);
            this.txtCantidadAleatorios.Name = "txtCantidadAleatorios";
            this.txtCantidadAleatorios.Size = new System.Drawing.Size(277, 20);
            this.txtCantidadAleatorios.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(368, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbPartidos);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(33, 220);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(749, 305);
            this.panel1.TabIndex = 4;
            this.panel1.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(518, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cbPartidos
            // 
            this.cbPartidos.FormattingEnabled = true;
            this.cbPartidos.Location = new System.Drawing.Point(518, 46);
            this.cbPartidos.Name = "cbPartidos";
            this.cbPartidos.Size = new System.Drawing.Size(200, 21);
            this.cbPartidos.TabIndex = 1;
            this.cbPartidos.SelectedIndexChanged += new System.EventHandler(this.cbPartidos_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(518, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Seleccione Partido";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(61, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(272, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Presidente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(61, 125);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(272, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Alcalde";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(61, 154);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(272, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Diputados Listado Nacional";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(61, 183);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(272, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Diputados Distritales";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(61, 212);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(272, 23);
            this.button5.TabIndex = 3;
            this.button5.Text = "Diputados al Parlacen";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(437, 254);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 4;
            this.button6.Text = "Terminar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // votante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 550);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnVotar);
            this.Name = "votante";
            this.Text = "votante";
            this.Load += new System.EventHandler(this.votante_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnVotar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnVotarAleatorio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCantidadAleatorios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbPartidos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
    }
}