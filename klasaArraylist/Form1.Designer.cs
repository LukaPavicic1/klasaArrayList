﻿namespace klasaArraylist
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
            this.btnNovi = new System.Windows.Forms.Button();
            this.txtBoxAuto = new System.Windows.Forms.TextBox();
            this.btnUnesi = new System.Windows.Forms.Button();
            this.rtbLista = new System.Windows.Forms.RichTextBox();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNovi
            // 
            this.btnNovi.Location = new System.Drawing.Point(26, 29);
            this.btnNovi.Name = "btnNovi";
            this.btnNovi.Size = new System.Drawing.Size(119, 23);
            this.btnNovi.TabIndex = 0;
            this.btnNovi.Text = "Novi automobil";
            this.btnNovi.UseVisualStyleBackColor = true;
            this.btnNovi.Click += new System.EventHandler(this.btnNovi_Click);
            // 
            // txtBoxAuto
            // 
            this.txtBoxAuto.Enabled = false;
            this.txtBoxAuto.Location = new System.Drawing.Point(26, 76);
            this.txtBoxAuto.Name = "txtBoxAuto";
            this.txtBoxAuto.Size = new System.Drawing.Size(171, 20);
            this.txtBoxAuto.TabIndex = 1;
            // 
            // btnUnesi
            // 
            this.btnUnesi.Enabled = false;
            this.btnUnesi.Location = new System.Drawing.Point(212, 76);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(75, 20);
            this.btnUnesi.TabIndex = 2;
            this.btnUnesi.Text = "Unesi";
            this.btnUnesi.UseVisualStyleBackColor = true;
            this.btnUnesi.Click += new System.EventHandler(this.btnUnesi_Click);
            // 
            // rtbLista
            // 
            this.rtbLista.Location = new System.Drawing.Point(26, 116);
            this.rtbLista.Name = "rtbLista";
            this.rtbLista.Size = new System.Drawing.Size(283, 202);
            this.rtbLista.TabIndex = 3;
            this.rtbLista.Text = "";
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(26, 335);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(99, 23);
            this.btnObrisi.TabIndex = 4;
            this.btnObrisi.Text = "Obrisi listu";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 370);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.rtbLista);
            this.Controls.Add(this.btnUnesi);
            this.Controls.Add(this.txtBoxAuto);
            this.Controls.Add(this.btnNovi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNovi;
        private System.Windows.Forms.TextBox txtBoxAuto;
        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.RichTextBox rtbLista;
        private System.Windows.Forms.Button btnObrisi;
    }
}

