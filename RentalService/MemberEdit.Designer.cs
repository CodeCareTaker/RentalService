namespace RentalService
{
    partial class MemberEdit
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
            this.cmdReturn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbProvince = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPostal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.cmdApply = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdNum = new System.Windows.Forms.TextBox();
            this.txtLN = new System.Windows.Forms.TextBox();
            this.txtFN = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdReturn
            // 
            this.cmdReturn.Location = new System.Drawing.Point(152, 474);
            this.cmdReturn.Name = "cmdReturn";
            this.cmdReturn.Size = new System.Drawing.Size(177, 23);
            this.cmdReturn.TabIndex = 35;
            this.cmdReturn.Text = "Reurn to Main Menu";
            this.cmdReturn.UseVisualStyleBackColor = true;
            this.cmdReturn.Click += new System.EventHandler(this.cmdReturn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(80, 394);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "Province:";
            // 
            // cbProvince
            // 
            this.cbProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProvince.FormattingEnabled = true;
            this.cbProvince.Location = new System.Drawing.Point(152, 391);
            this.cbProvince.Name = "cbProvince";
            this.cbProvince.Size = new System.Drawing.Size(236, 21);
            this.cbProvince.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "Postal Code(ex. A1B2B3):";
            // 
            // txtPostal
            // 
            this.txtPostal.Location = new System.Drawing.Point(152, 354);
            this.txtPostal.MaxLength = 6;
            this.txtPostal.Name = "txtPostal";
            this.txtPostal.Size = new System.Drawing.Size(236, 20);
            this.txtPostal.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "City:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(152, 314);
            this.txtCity.MaxLength = 40;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(236, 20);
            this.txtCity.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Street Name:";
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(152, 278);
            this.txtStreet.MaxLength = 40;
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(236, 20);
            this.txtStreet.TabIndex = 40;
            // 
            // cmdApply
            // 
            this.cmdApply.Location = new System.Drawing.Point(198, 445);
            this.cmdApply.Name = "cmdApply";
            this.cmdApply.Size = new System.Drawing.Size(75, 23);
            this.cmdApply.TabIndex = 46;
            this.cmdApply.Text = "Apply";
            this.cmdApply.UseVisualStyleBackColor = true;
            this.cmdApply.Click += new System.EventHandler(this.cmdApply_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Address Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Last Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "First Name:";
            // 
            // txtAdNum
            // 
            this.txtAdNum.Location = new System.Drawing.Point(152, 243);
            this.txtAdNum.MaxLength = 8;
            this.txtAdNum.Name = "txtAdNum";
            this.txtAdNum.Size = new System.Drawing.Size(236, 20);
            this.txtAdNum.TabIndex = 38;
            // 
            // txtLN
            // 
            this.txtLN.Location = new System.Drawing.Point(152, 207);
            this.txtLN.MaxLength = 20;
            this.txtLN.Name = "txtLN";
            this.txtLN.Size = new System.Drawing.Size(236, 20);
            this.txtLN.TabIndex = 37;
            // 
            // txtFN
            // 
            this.txtFN.Location = new System.Drawing.Point(152, 171);
            this.txtFN.MaxLength = 20;
            this.txtFN.Name = "txtFN";
            this.txtFN.Size = new System.Drawing.Size(236, 20);
            this.txtFN.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(37, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(418, 31);
            this.label8.TabIndex = 51;
            this.label8.Text = "Please edit you information below";
            // 
            // MemberEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 545);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbProvince);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPostal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtStreet);
            this.Controls.Add(this.cmdApply);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAdNum);
            this.Controls.Add(this.txtLN);
            this.Controls.Add(this.txtFN);
            this.Controls.Add(this.cmdReturn);
            this.Name = "MemberEdit";
            this.Text = "MemberEdit";
            this.Load += new System.EventHandler(this.MemberEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdReturn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbProvince;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPostal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Button cmdApply;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdNum;
        private System.Windows.Forms.TextBox txtLN;
        private System.Windows.Forms.TextBox txtFN;
        private System.Windows.Forms.Label label8;
    }
}