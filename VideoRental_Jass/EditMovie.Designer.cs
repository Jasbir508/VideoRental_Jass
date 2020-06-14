namespace VideoRental_Jass
{
    partial class EditMovie
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
            this.button1 = new System.Windows.Forms.Button();
            this.genre = new System.Windows.Forms.TextBox();
            this.plot = new System.Windows.Forms.TextBox();
            this.copies = new System.Windows.Forms.TextBox();
            this.year = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.TextBox();
            this.rating = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtMoviesID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Goldenrod;
            this.button1.Location = new System.Drawing.Point(248, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 68);
            this.button1.TabIndex = 47;
            this.button1.Text = "Update Movie";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // genre
            // 
            this.genre.Location = new System.Drawing.Point(174, 240);
            this.genre.Multiline = true;
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(523, 53);
            this.genre.TabIndex = 46;
            // 
            // plot
            // 
            this.plot.Location = new System.Drawing.Point(174, 181);
            this.plot.Multiline = true;
            this.plot.Name = "plot";
            this.plot.Size = new System.Drawing.Size(523, 53);
            this.plot.TabIndex = 45;
            // 
            // copies
            // 
            this.copies.Location = new System.Drawing.Point(174, 155);
            this.copies.Name = "copies";
            this.copies.Size = new System.Drawing.Size(523, 20);
            this.copies.TabIndex = 44;
            // 
            // year
            // 
            this.year.Location = new System.Drawing.Point(174, 129);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(523, 20);
            this.year.TabIndex = 43;
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(174, 44);
            this.title.Multiline = true;
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(523, 53);
            this.title.TabIndex = 41;
            // 
            // rating
            // 
            this.rating.Location = new System.Drawing.Point(174, 103);
            this.rating.Name = "rating";
            this.rating.Size = new System.Drawing.Size(523, 20);
            this.rating.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Goldenrod;
            this.label6.Location = new System.Drawing.Point(105, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 53;
            this.label6.Text = "Genre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Goldenrod;
            this.label5.Location = new System.Drawing.Point(105, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 52;
            this.label5.Text = "Plot";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Goldenrod;
            this.label4.Location = new System.Drawing.Point(105, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "Copies";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Goldenrod;
            this.label3.Location = new System.Drawing.Point(105, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label2.Location = new System.Drawing.Point(105, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(105, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Rating";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Goldenrod;
            this.button2.Location = new System.Drawing.Point(468, 304);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 68);
            this.button2.TabIndex = 54;
            this.button2.Text = "Delete Movie";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtMoviesID
            // 
            this.txtMoviesID.Location = new System.Drawing.Point(174, 12);
            this.txtMoviesID.Name = "txtMoviesID";
            this.txtMoviesID.Size = new System.Drawing.Size(523, 20);
            this.txtMoviesID.TabIndex = 55;
            // 
            // EditMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 389);
            this.Controls.Add(this.txtMoviesID);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.genre);
            this.Controls.Add(this.plot);
            this.Controls.Add(this.copies);
            this.Controls.Add(this.year);
            this.Controls.Add(this.title);
            this.Controls.Add(this.rating);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditMovie";
            this.Text = "EditMovie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox genre;
        public System.Windows.Forms.TextBox plot;
        public System.Windows.Forms.TextBox copies;
        public System.Windows.Forms.TextBox year;
        public System.Windows.Forms.TextBox title;
        public System.Windows.Forms.TextBox rating;
        public System.Windows.Forms.TextBox txtMoviesID;
    }
}