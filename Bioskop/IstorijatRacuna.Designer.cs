namespace Bioskop
{
    partial class IstorijatRacuna
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
            this.label_istorijat = new System.Windows.Forms.Label();
            this.dataGridView_istorijat = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_istorijat)).BeginInit();
            this.SuspendLayout();
            // 
            // label_istorijat
            // 
            this.label_istorijat.AutoSize = true;
            this.label_istorijat.Font = new System.Drawing.Font("News701 BT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_istorijat.Location = new System.Drawing.Point(17, 14);
            this.label_istorijat.Name = "label_istorijat";
            this.label_istorijat.Size = new System.Drawing.Size(286, 39);
            this.label_istorijat.TabIndex = 13;
            this.label_istorijat.Text = "Istorijat Racuna";
            // 
            // dataGridView_istorijat
            // 
            this.dataGridView_istorijat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_istorijat.Location = new System.Drawing.Point(24, 72);
            this.dataGridView_istorijat.Name = "dataGridView_istorijat";
            this.dataGridView_istorijat.Size = new System.Drawing.Size(934, 361);
            this.dataGridView_istorijat.TabIndex = 14;
            // 
            // IstorijatRacuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 456);
            this.Controls.Add(this.dataGridView_istorijat);
            this.Controls.Add(this.label_istorijat);
            this.Name = "IstorijatRacuna";
            this.Text = "IstorijatRacuna";
            this.Load += new System.EventHandler(this.IstorijatRacuna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_istorijat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_istorijat;
        private System.Windows.Forms.DataGridView dataGridView_istorijat;
    }
}