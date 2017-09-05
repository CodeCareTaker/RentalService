namespace RentalService
{
    partial class ManagementInterface
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbMovieGenre = new System.Windows.Forms.ComboBox();
            this.txtMovD = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMovS = new System.Windows.Forms.TextBox();
            this.cmdAddMovie = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMovY = new System.Windows.Forms.TextBox();
            this.txtMovT = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbGameGenre = new System.Windows.Forms.ComboBox();
            this.txtGameP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGameD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtGameR = new System.Windows.Forms.TextBox();
            this.txtGameT = new System.Windows.Forms.TextBox();
            this.cmdAddGame = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgMovies = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dgGames = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dgCustomers = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.cmdReturn = new System.Windows.Forms.Button();
            this.txtMoPr = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMovies)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgGames)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1277, 536);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtMoPr);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.cbMovieGenre);
            this.tabPage1.Controls.Add(this.txtMovD);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtMovS);
            this.tabPage1.Controls.Add(this.cmdAddMovie);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtMovY);
            this.tabPage1.Controls.Add(this.txtMovT);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1269, 510);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add Movie";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cbMovieGenre
            // 
            this.cbMovieGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMovieGenre.FormattingEnabled = true;
            this.cbMovieGenre.Location = new System.Drawing.Point(248, 113);
            this.cbMovieGenre.Name = "cbMovieGenre";
            this.cbMovieGenre.Size = new System.Drawing.Size(236, 21);
            this.cbMovieGenre.TabIndex = 11;
            // 
            // txtMovD
            // 
            this.txtMovD.Location = new System.Drawing.Point(248, 225);
            this.txtMovD.MaxLength = 50;
            this.txtMovD.Name = "txtMovD";
            this.txtMovD.Size = new System.Drawing.Size(236, 20);
            this.txtMovD.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(192, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Director:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Starring (Only one Actor, or Actress):";
            // 
            // txtMovS
            // 
            this.txtMovS.Location = new System.Drawing.Point(248, 188);
            this.txtMovS.MaxLength = 50;
            this.txtMovS.Name = "txtMovS";
            this.txtMovS.Size = new System.Drawing.Size(236, 20);
            this.txtMovS.TabIndex = 7;
            // 
            // cmdAddMovie
            // 
            this.cmdAddMovie.Location = new System.Drawing.Point(248, 311);
            this.cmdAddMovie.Name = "cmdAddMovie";
            this.cmdAddMovie.Size = new System.Drawing.Size(75, 23);
            this.cmdAddMovie.TabIndex = 6;
            this.cmdAddMovie.Text = "Add Movie";
            this.cmdAddMovie.UseVisualStyleBackColor = true;
            this.cmdAddMovie.Click += new System.EventHandler(this.cmdAddMovie_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Released in (Year):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Movie Genre (Only one genre):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Movie Title:";
            // 
            // txtMovY
            // 
            this.txtMovY.Location = new System.Drawing.Point(248, 149);
            this.txtMovY.MaxLength = 4;
            this.txtMovY.Name = "txtMovY";
            this.txtMovY.Size = new System.Drawing.Size(236, 20);
            this.txtMovY.TabIndex = 2;
            // 
            // txtMovT
            // 
            this.txtMovT.Location = new System.Drawing.Point(248, 74);
            this.txtMovT.MaxLength = 50;
            this.txtMovT.Name = "txtMovT";
            this.txtMovT.Size = new System.Drawing.Size(236, 20);
            this.txtMovT.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cbGameGenre);
            this.tabPage2.Controls.Add(this.txtGameP);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txtGameD);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.txtGameR);
            this.tabPage2.Controls.Add(this.txtGameT);
            this.tabPage2.Controls.Add(this.cmdAddGame);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1269, 510);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add Game";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbGameGenre
            // 
            this.cbGameGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGameGenre.FormattingEnabled = true;
            this.cbGameGenre.Location = new System.Drawing.Point(259, 114);
            this.cbGameGenre.Name = "cbGameGenre";
            this.cbGameGenre.Size = new System.Drawing.Size(236, 21);
            this.cbGameGenre.TabIndex = 21;
            // 
            // txtGameP
            // 
            this.txtGameP.Location = new System.Drawing.Point(259, 227);
            this.txtGameP.Name = "txtGameP";
            this.txtGameP.Size = new System.Drawing.Size(236, 20);
            this.txtGameP.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(197, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Publisher:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(191, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Developer:";
            // 
            // txtGameD
            // 
            this.txtGameD.Location = new System.Drawing.Point(259, 189);
            this.txtGameD.Name = "txtGameD";
            this.txtGameD.Size = new System.Drawing.Size(236, 20);
            this.txtGameD.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(153, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Released in (Year):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(170, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Game Genre:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(179, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Game Title:";
            // 
            // txtGameR
            // 
            this.txtGameR.Location = new System.Drawing.Point(259, 150);
            this.txtGameR.Name = "txtGameR";
            this.txtGameR.Size = new System.Drawing.Size(236, 20);
            this.txtGameR.TabIndex = 13;
            // 
            // txtGameT
            // 
            this.txtGameT.Location = new System.Drawing.Point(259, 75);
            this.txtGameT.Name = "txtGameT";
            this.txtGameT.Size = new System.Drawing.Size(236, 20);
            this.txtGameT.TabIndex = 11;
            // 
            // cmdAddGame
            // 
            this.cmdAddGame.Location = new System.Drawing.Point(259, 317);
            this.cmdAddGame.Name = "cmdAddGame";
            this.cmdAddGame.Size = new System.Drawing.Size(75, 23);
            this.cmdAddGame.TabIndex = 6;
            this.cmdAddGame.Text = "Add Game";
            this.cmdAddGame.UseVisualStyleBackColor = true;
            this.cmdAddGame.Click += new System.EventHandler(this.cmdAddGame_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgMovies);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1269, 510);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Movies";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgMovies
            // 
            this.dgMovies.AllowUserToAddRows = false;
            this.dgMovies.AllowUserToDeleteRows = false;
            this.dgMovies.AllowUserToResizeColumns = false;
            this.dgMovies.AllowUserToResizeRows = false;
            this.dgMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMovies.Location = new System.Drawing.Point(6, 6);
            this.dgMovies.Name = "dgMovies";
            this.dgMovies.Size = new System.Drawing.Size(944, 498);
            this.dgMovies.TabIndex = 0;
            this.dgMovies.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMovies_CellContentClick);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dgGames);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1269, 510);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Games";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgGames
            // 
            this.dgGames.AllowUserToAddRows = false;
            this.dgGames.AllowUserToDeleteRows = false;
            this.dgGames.AllowUserToResizeColumns = false;
            this.dgGames.AllowUserToResizeRows = false;
            this.dgGames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgGames.Location = new System.Drawing.Point(6, 6);
            this.dgGames.Name = "dgGames";
            this.dgGames.Size = new System.Drawing.Size(944, 498);
            this.dgGames.TabIndex = 0;
            this.dgGames.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgGames_CellContentClick);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dgCustomers);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1269, 510);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Customers";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dgCustomers
            // 
            this.dgCustomers.AllowUserToAddRows = false;
            this.dgCustomers.AllowUserToDeleteRows = false;
            this.dgCustomers.AllowUserToResizeColumns = false;
            this.dgCustomers.AllowUserToResizeRows = false;
            this.dgCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCustomers.Location = new System.Drawing.Point(6, 6);
            this.dgCustomers.Name = "dgCustomers";
            this.dgCustomers.Size = new System.Drawing.Size(1260, 498);
            this.dgCustomers.TabIndex = 0;
            this.dgCustomers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCustomers_CellContentClick);
            // 
            // cmdReturn
            // 
            this.cmdReturn.Location = new System.Drawing.Point(528, 563);
            this.cmdReturn.Name = "cmdReturn";
            this.cmdReturn.Size = new System.Drawing.Size(177, 23);
            this.cmdReturn.TabIndex = 4;
            this.cmdReturn.Text = "Reurn to Main Menu";
            this.cmdReturn.UseVisualStyleBackColor = true;
            this.cmdReturn.Click += new System.EventHandler(this.cmdReturn_Click);
            // 
            // txtMoPr
            // 
            this.txtMoPr.Location = new System.Drawing.Point(248, 260);
            this.txtMoPr.MaxLength = 50;
            this.txtMoPr.Name = "txtMoPr";
            this.txtMoPr.Size = new System.Drawing.Size(236, 20);
            this.txtMoPr.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(192, 263);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Director:";
            // 
            // ManagementInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 598);
            this.Controls.Add(this.cmdReturn);
            this.Controls.Add(this.tabControl1);
            this.Name = "ManagementInterface";
            this.Text = "Management Interface";
            this.Load += new System.EventHandler(this.ManagementInterface_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgMovies)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgGames)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button cmdAddMovie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMovY;
        private System.Windows.Forms.TextBox txtMovT;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button cmdAddGame;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgMovies;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dgGames;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView dgCustomers;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.BindingSource bindingSource3;
        private System.Windows.Forms.TextBox txtMovS;
        private System.Windows.Forms.TextBox txtMovD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGameP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGameD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtGameR;
        private System.Windows.Forms.TextBox txtGameT;
        private System.Windows.Forms.ComboBox cbMovieGenre;
        private System.Windows.Forms.ComboBox cbGameGenre;
        private System.Windows.Forms.Button cmdReturn;
        private System.Windows.Forms.TextBox txtMoPr;
        private System.Windows.Forms.Label label11;
    }
}