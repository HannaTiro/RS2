﻿
namespace PhotoStudio.WinUI.Forms
{
    partial class frmPocetna
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.korisniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledajKorisnikeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fotografiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledajFotografeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajFotografaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rezervacijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledajRezervacijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ocjeneIKomentariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledajOcjeneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledajKomentareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oNamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.korisniciToolStripMenuItem,
            this.fotografiToolStripMenuItem,
            this.rezervacijeToolStripMenuItem,
            this.ocjeneIKomentariToolStripMenuItem,
            this.oNamaToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_ItemClicked);
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // korisniciToolStripMenuItem
            // 
            this.korisniciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledajKorisnikeToolStripMenuItem});
            this.korisniciToolStripMenuItem.Name = "korisniciToolStripMenuItem";
            this.korisniciToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.korisniciToolStripMenuItem.Text = "Korisnici";
            // 
            // pregledajKorisnikeToolStripMenuItem
            // 
            this.pregledajKorisnikeToolStripMenuItem.Name = "pregledajKorisnikeToolStripMenuItem";
            this.pregledajKorisnikeToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.pregledajKorisnikeToolStripMenuItem.Text = "Pregledaj korisnike";
            this.pregledajKorisnikeToolStripMenuItem.Click += new System.EventHandler(this.pregledajKorisnikeToolStripMenuItem_Click);
            // 
            // fotografiToolStripMenuItem
            // 
            this.fotografiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledajFotografeToolStripMenuItem,
            this.dodajFotografaToolStripMenuItem});
            this.fotografiToolStripMenuItem.Name = "fotografiToolStripMenuItem";
            this.fotografiToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.fotografiToolStripMenuItem.Text = "Fotografi";
            // 
            // pregledajFotografeToolStripMenuItem
            // 
            this.pregledajFotografeToolStripMenuItem.Name = "pregledajFotografeToolStripMenuItem";
            this.pregledajFotografeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pregledajFotografeToolStripMenuItem.Text = "Pregledaj fotografe";
            this.pregledajFotografeToolStripMenuItem.Click += new System.EventHandler(this.pregledajFotografeToolStripMenuItem_Click);
            // 
            // dodajFotografaToolStripMenuItem
            // 
            this.dodajFotografaToolStripMenuItem.Name = "dodajFotografaToolStripMenuItem";
            this.dodajFotografaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dodajFotografaToolStripMenuItem.Text = "Dodaj fotografa";
            this.dodajFotografaToolStripMenuItem.Click += new System.EventHandler(this.dodajFotografaToolStripMenuItem_Click);
            // 
            // rezervacijeToolStripMenuItem
            // 
            this.rezervacijeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledajRezervacijeToolStripMenuItem});
            this.rezervacijeToolStripMenuItem.Name = "rezervacijeToolStripMenuItem";
            this.rezervacijeToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.rezervacijeToolStripMenuItem.Text = "Rezervacije";
            // 
            // pregledajRezervacijeToolStripMenuItem
            // 
            this.pregledajRezervacijeToolStripMenuItem.Name = "pregledajRezervacijeToolStripMenuItem";
            this.pregledajRezervacijeToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.pregledajRezervacijeToolStripMenuItem.Text = "Pregledaj rezervacije";
            // 
            // ocjeneIKomentariToolStripMenuItem
            // 
            this.ocjeneIKomentariToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledajOcjeneToolStripMenuItem,
            this.pregledajKomentareToolStripMenuItem});
            this.ocjeneIKomentariToolStripMenuItem.Name = "ocjeneIKomentariToolStripMenuItem";
            this.ocjeneIKomentariToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.ocjeneIKomentariToolStripMenuItem.Text = "Ocjene i komentari";
            // 
            // pregledajOcjeneToolStripMenuItem
            // 
            this.pregledajOcjeneToolStripMenuItem.Name = "pregledajOcjeneToolStripMenuItem";
            this.pregledajOcjeneToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.pregledajOcjeneToolStripMenuItem.Text = "Pregledaj ocjene";
            // 
            // pregledajKomentareToolStripMenuItem
            // 
            this.pregledajKomentareToolStripMenuItem.Name = "pregledajKomentareToolStripMenuItem";
            this.pregledajKomentareToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.pregledajKomentareToolStripMenuItem.Text = "Pregledaj komentare";
            // 
            // oNamaToolStripMenuItem
            // 
            this.oNamaToolStripMenuItem.Name = "oNamaToolStripMenuItem";
            this.oNamaToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.oNamaToolStripMenuItem.Text = "O nama";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // frmPocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmPocetna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPocetna";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPocetna_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem korisniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledajKorisnikeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fotografiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledajFotografeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rezervacijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledajRezervacijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ocjeneIKomentariToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledajOcjeneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledajKomentareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oNamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajFotografaToolStripMenuItem;
    }
}


