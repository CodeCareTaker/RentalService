namespace RentalService
{
    partial class Welcome
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmdManage = new System.Windows.Forms.Button();
            this.cmdRent = new System.Windows.Forms.Button();
            this.cmdMember = new System.Windows.Forms.Button();
            this.cmdExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(270, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to the Rental Service";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmdManage
            // 
            this.cmdManage.Location = new System.Drawing.Point(341, 215);
            this.cmdManage.Name = "cmdManage";
            this.cmdManage.Size = new System.Drawing.Size(262, 45);
            this.cmdManage.TabIndex = 1;
            this.cmdManage.Text = "Manage the Store";
            this.cmdManage.UseVisualStyleBackColor = true;
            this.cmdManage.Click += new System.EventHandler(this.cmdManage_Click);
            // 
            // cmdRent
            // 
            this.cmdRent.Location = new System.Drawing.Point(341, 266);
            this.cmdRent.Name = "cmdRent";
            this.cmdRent.Size = new System.Drawing.Size(262, 45);
            this.cmdRent.TabIndex = 2;
            this.cmdRent.Text = "Rent a Title";
            this.cmdRent.UseVisualStyleBackColor = true;
            this.cmdRent.Click += new System.EventHandler(this.cmdRent_Click);
            // 
            // cmdMember
            // 
            this.cmdMember.Location = new System.Drawing.Point(341, 317);
            this.cmdMember.Name = "cmdMember";
            this.cmdMember.Size = new System.Drawing.Size(262, 45);
            this.cmdMember.TabIndex = 3;
            this.cmdMember.Text = "Apply for Membership";
            this.cmdMember.UseVisualStyleBackColor = true;
            this.cmdMember.Click += new System.EventHandler(this.cmdMember_Click);
            // 
            // cmdExit
            // 
            this.cmdExit.Location = new System.Drawing.Point(341, 368);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(262, 45);
            this.cmdExit.TabIndex = 4;
            this.cmdExit.Text = "Exit";
            this.cmdExit.UseVisualStyleBackColor = true;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 598);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.cmdMember);
            this.Controls.Add(this.cmdRent);
            this.Controls.Add(this.cmdManage);
            this.Controls.Add(this.label1);
            this.Name = "Welcome";
            this.Text = "Welcome to the Rental Service";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdManage;
        private System.Windows.Forms.Button cmdRent;
        private System.Windows.Forms.Button cmdMember;
        private System.Windows.Forms.Button cmdExit;

    }
}

