﻿
namespace PhotoStudio.WinUI.Forms.PosebnaPonuda
{
    partial class frmPosebnaPonudaDodaj
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
            this.components = new System.ComponentModel.Container();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.lblAA = new System.Windows.Forms.Label();
            this.cmbStudio = new System.Windows.Forms.ComboBox();
            this.Studio = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(101, 310);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(143, 23);
            this.btnDodaj.TabIndex = 30;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(43, 104);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(201, 119);
            this.txtOpis.TabIndex = 29;
            this.txtOpis.Validating += new System.ComponentModel.CancelEventHandler(this.txtOpis_Validating);
            // 
            // lblAA
            // 
            this.lblAA.AutoSize = true;
            this.lblAA.Location = new System.Drawing.Point(40, 78);
            this.lblAA.Name = "lblAA";
            this.lblAA.Size = new System.Drawing.Size(28, 13);
            this.lblAA.TabIndex = 28;
            this.lblAA.Text = "Opis";
            // 
            // cmbStudio
            // 
            this.cmbStudio.FormattingEnabled = true;
            this.cmbStudio.Location = new System.Drawing.Point(43, 270);
            this.cmbStudio.Name = "cmbStudio";
            this.cmbStudio.Size = new System.Drawing.Size(201, 21);
            this.cmbStudio.TabIndex = 27;
            this.cmbStudio.Validating += new System.ComponentModel.CancelEventHandler(this.cmbStudio_Validating);
            // 
            // Studio
            // 
            this.Studio.AutoSize = true;
            this.Studio.Location = new System.Drawing.Point(40, 240);
            this.Studio.Name = "Studio";
            this.Studio.Size = new System.Drawing.Size(37, 13);
            this.Studio.TabIndex = 26;
            this.Studio.Text = "Studio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Naziv ponude";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(43, 42);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(201, 20);
            this.txtNaziv.TabIndex = 24;
            this.txtNaziv.Validating += new System.ComponentModel.CancelEventHandler(this.txtNaziv_Validating);
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // frmPosebnaPonudaDodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(295, 377);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.lblAA);
            this.Controls.Add(this.cmbStudio);
            this.Controls.Add(this.Studio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNaziv);
            this.Name = "frmPosebnaPonudaDodaj";
            this.Text = "Dodavanje nove posebne ponude";
            this.Load += new System.EventHandler(this.frmPosebnaPonudaDodaj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Label lblAA;
        private System.Windows.Forms.ComboBox cmbStudio;
        private System.Windows.Forms.Label Studio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.ErrorProvider err;
    }
}