namespace RentalService
{
    partial class GameEdit
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
            this.cmdEditGame = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbGameGenre
            // 
            this.cbGameGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGameGenre.FormattingEnabled = true;
            this.cbGameGenre.Location = new System.Drawing.Point(179, 179);
            this.cbGameGenre.Name = "cbGameGenre";
            this.cbGameGenre.Size = new System.Drawing.Size(236, 21);
            this.cbGameGenre.TabIndex = 32;
            // 
            // txtGameP
            // 
            this.txtGameP.Location = new System.Drawing.Point(179, 292);
            this.txtGameP.Name = "txtGameP";
            this.txtGameP.Size = new System.Drawing.Size(236, 20);
            this.txtGameP.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Publisher:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(111, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Developer:";
            // 
            // txtGameD
            // 
            this.txtGameD.Location = new System.Drawing.Point(179, 254);
            this.txtGameD.Name = "txtGameD";
            this.txtGameD.Size = new System.Drawing.Size(236, 20);
            this.txtGameD.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(73, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Released in (Year):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(90, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Game Genre:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(99, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Game Title:";
            // 
            // txtGameR
            // 
            this.txtGameR.Location = new System.Drawing.Point(179, 215);
            this.txtGameR.Name = "txtGameR";
            this.txtGameR.Size = new System.Drawing.Size(236, 20);
            this.txtGameR.TabIndex = 24;
            // 
            // txtGameT
            // 
            this.txtGameT.Location = new System.Drawing.Point(179, 140);
            this.txtGameT.Name = "txtGameT";
            this.txtGameT.ReadOnly = true;
            this.txtGameT.Size = new System.Drawing.Size(236, 20);
            this.txtGameT.TabIndex = 23;
            // 
            // cmdEditGame
            // 
            this.cmdEditGame.Location = new System.Drawing.Point(179, 382);
            this.cmdEditGame.Name = "cmdEditGame";
            this.cmdEditGame.Size = new System.Drawing.Size(75, 23);
            this.cmdEditGame.TabIndex = 22;
            this.cmdEditGame.Text = "Edit Game";
            this.cmdEditGame.UseVisualStyleBackColor = true;
            this.cmdEditGame.Click += new System.EventHandler(this.cmdEditGame_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 31);
            this.label1.TabIndex = 33;
            this.label1.Text = "Game Editing Window";
            // 
            // cmdReturn
            // 
            this.cmdReturn.Location = new System.Drawing.Point(130, 433);
            this.cmdReturn.Name = "cmdReturn";
            this.cmdReturn.Size = new System.Drawing.Size(177, 23);
            this.cmdReturn.TabIndex = 34;
            this.cmdReturn.Text = "Reurn to Main Menu";
            this.cmdReturn.UseVisualStyleBackColor = true;
            this.cmdReturn.Click += new System.EventHandler(this.cmdReturn_Click);
            // 
            // GameEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 545);
            this.Controls.Add(this.cmdReturn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbGameGenre);
            this.Controls.Add(this.txtGameP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtGameD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtGameR);
            this.Controls.Add(this.txtGameT);
            this.Controls.Add(this.cmdEditGame);
            this.Name = "GameEdit";
            this.Text = "GameEdit";
            this.Load += new System.EventHandler(this.GameEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbGameGenre;
        private System.Windows.Forms.TextBox txtGameP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGameD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtGameR;
        private System.Windows.Forms.TextBox txtGameT;
        private System.Windows.Forms.Button cmdEditGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdReturn;
    }
}