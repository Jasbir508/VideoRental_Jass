namespace VideoRental_Jass
{
    partial class ReturnMovie
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
            this.returnMovieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewReturn = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReturn)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // returnMovieToolStripMenuItem
            // 
            this.returnMovieToolStripMenuItem.Name = "returnMovieToolStripMenuItem";
            this.returnMovieToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.returnMovieToolStripMenuItem.Text = "Return Movie";
            this.returnMovieToolStripMenuItem.Click += new System.EventHandler(this.returnMovieToolStripMenuItem_Click);
            // 
            // dataGridViewReturn
            // 
            this.dataGridViewReturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReturn.Location = new System.Drawing.Point(-49, 41);
            this.dataGridViewReturn.Name = "dataGridViewReturn";
            this.dataGridViewReturn.Size = new System.Drawing.Size(801, 367);
            this.dataGridViewReturn.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.returnMovieToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(755, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ReturnMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 366);
            this.Controls.Add(this.dataGridViewReturn);
            this.Controls.Add(this.menuStrip1);
            this.Name = "ReturnMovie";
            this.Text = "ReturnMovie";
            this.Load += new System.EventHandler(this.ReturnMovie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReturn)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem returnMovieToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewReturn;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}