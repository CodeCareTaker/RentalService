namespace RentalService
{
    partial class MovieEdit
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
            this.cbMovieGenre = new System.Windows.Forms.ComboBox();
            this.txtMovD = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMovS = new System.Windows.Forms.TextBox();
            this.cmdEditMovie = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMovY = new System.Windows.Forms.TextBox();
            this.txtMovT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmdReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbMovieGenre
            // 
            this.cbMovieGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMovieGenre.FormattingEnabled = true;
            this.cbMovieGenre.Location = new System.Drawing.Point(217, 177);
            this.cbMovieGenre.Name = "cbMovieGenre";
            this.cbMovieGenre.Size = new System.Drawing.Size(236, 21);
            this.cbMovieGenre.TabIndex = 22;
            // 
            // txtMovD
            // 
            this.txtMovD.Location = new System.Drawing.Point(217, 289);
            this.txtMovD.Name = "txtMovD";
            this.txtMovD.Size = new System.Drawing.Size(236, 20);
            this.txtMovD.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(161, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Director:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Starring (Only one Actor, or Actress):";
            // 
            // txtMovS
            // 
            this.txtMovS.Location = new System.Drawing.Point(217, 252);
            this.txtMovS.Name = "txtMovS";
            this.txtMovS.Size = new System.Drawing.Size(236, 20);
            this.txtMovS.TabIndex = 18;
            // 
            // cmdEditMovie
            // 
            this.cmdEditMovie.Location = new System.Drawing.Point(217, 365);
            this.cmdEditMovie.Name = "cmdEditMovie";
            this.cmdEditMovie.Size = new System.Drawing.Size(75, 23);
            this.cmdEditMovie.TabIndex = 17;
            this.cmdEditMovie.Text = "Edit Movie";
            this.cmdEditMovie.UseVisualStyleBackColor = true;
            this.cmdEditMovie.Click += new System.EventHandler(this.cmdEditMovie_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Released in (Year):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Movie Genre (Only one genre):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Movie Title:";
            // 
            // txtMovY
            // 
            this.txtMovY.Location = new System.Drawing.Point(217, 213);
            this.txtMovY.Name = "txtMovY";
            this.txtMovY.Size = new System.Drawing.Size(236, 20);
            this.txtMovY.TabIndex = 13;
            // 
            // txtMovT
            // 
            this.txtMovT.Location = new System.Drawing.Point(217, 138);
            this.txtMovT.Name = "txtMovT";
            this.txtMovT.ReadOnly = true;
            this.txtMovT.Size = new System.Drawing.Size(236, 20);
            this.txtMovT.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(108, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(279, 31);
            this.label4.TabIndex = 34;
            this.label4.Text = "Movie Editing Window";
            // 
            // cmdReturn
            // 
            this.cmdReturn.Location = new System.Drawing.Point(164, 408);
            this.cmdReturn.Name = "cmdReturn";
            this.cmdReturn.Size = new System.Drawing.Size(177, 23);
            this.cmdReturn.TabIndex = 35;
            this.cmdReturn.Text = "Reurn to Main Menu";
            this.cmdReturn.UseVisualStyleBackColor = true;
            this.cmdReturn.Click += new System.EventHandler(this.cmdReturn_Click);
            // 
            // MovieEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 545);
            this.Controls.Add(this.cmdReturn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbMovieGenre);
            this.Controls.Add(this.txtMovD);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMovS);
            this.Controls.Add(this.cmdEditMovie);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMovY);
            this.Controls.Add(this.txtMovT);
            this.Name = "MovieEdit";
            this.Text = "MovieEdit";
            this.Load += new System.EventHandler(this.MovieEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMovieGenre;
        private System.Windows.Forms.TextBox txtMovD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMovS;
        private System.Windows.Forms.Button cmdEditMovie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMovY;
        private System.Windows.Forms.TextBox txtMovT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cmdReturn;
    }
}