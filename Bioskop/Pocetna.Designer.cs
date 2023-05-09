namespace Bioskop
{
    partial class Pocetna
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filmoviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label_bioskop = new System.Windows.Forms.Label();
            this.kasaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.istorijatRacunaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmoviToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filmoviToolStripMenuItem1,
            this.filmoviToolStripMenuItem,
            this.kasaToolStripMenuItem,
            this.radniciToolStripMenuItem,
            this.istorijatRacunaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(339, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filmoviToolStripMenuItem
            // 
            this.filmoviToolStripMenuItem.Name = "filmoviToolStripMenuItem";
            this.filmoviToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.filmoviToolStripMenuItem.Text = "Repertoar";
            this.filmoviToolStripMenuItem.Click += new System.EventHandler(this.filmoviToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label_bioskop
            // 
            this.label_bioskop.AutoSize = true;
            this.label_bioskop.Font = new System.Drawing.Font("News701 BT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_bioskop.Location = new System.Drawing.Point(91, 75);
            this.label_bioskop.Name = "label_bioskop";
            this.label_bioskop.Size = new System.Drawing.Size(153, 39);
            this.label_bioskop.TabIndex = 9;
            this.label_bioskop.Text = "Bioskop";
            // 
            // kasaToolStripMenuItem
            // 
            this.kasaToolStripMenuItem.Name = "kasaToolStripMenuItem";
            this.kasaToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.kasaToolStripMenuItem.Text = "Kasa";
            this.kasaToolStripMenuItem.Click += new System.EventHandler(this.kasaToolStripMenuItem_Click);
            // 
            // radniciToolStripMenuItem
            // 
            this.radniciToolStripMenuItem.Name = "radniciToolStripMenuItem";
            this.radniciToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.radniciToolStripMenuItem.Text = "Radnici";
            this.radniciToolStripMenuItem.Click += new System.EventHandler(this.radniciToolStripMenuItem_Click);
            // 
            // istorijatRacunaToolStripMenuItem
            // 
            this.istorijatRacunaToolStripMenuItem.Name = "istorijatRacunaToolStripMenuItem";
            this.istorijatRacunaToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.istorijatRacunaToolStripMenuItem.Text = "Istorijat racuna";
            this.istorijatRacunaToolStripMenuItem.Click += new System.EventHandler(this.istorijatRacunaToolStripMenuItem_Click);
            // 
            // filmoviToolStripMenuItem1
            // 
            this.filmoviToolStripMenuItem1.Name = "filmoviToolStripMenuItem1";
            this.filmoviToolStripMenuItem1.Size = new System.Drawing.Size(58, 20);
            this.filmoviToolStripMenuItem1.Text = "Filmovi";
            this.filmoviToolStripMenuItem1.Click += new System.EventHandler(this.filmoviToolStripMenuItem1_Click);
            // 
            // Pocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 173);
            this.Controls.Add(this.label_bioskop);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Pocetna";
            this.Text = "Pocetna";
            this.Load += new System.EventHandler(this.Pocetna_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem filmoviToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kasaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem radniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem istorijatRacunaToolStripMenuItem;
        private System.Windows.Forms.Label label_bioskop;
        public System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filmoviToolStripMenuItem1;
    }
}