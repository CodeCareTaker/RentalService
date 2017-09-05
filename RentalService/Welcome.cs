using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RentalService
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void cmdManage_Click(object sender, EventArgs e)
        {
            ManagementInterface ManInt = new ManagementInterface();
            ManInt.ShowDialog();
        }

        private void cmdRent_Click(object sender, EventArgs e)
        {
            RentTitle rental = new RentTitle();
            rental.ShowDialog();
        }

        private void cmdMember_Click(object sender, EventArgs e)
        {
            MemberAppl memApplication = new MemberAppl();
            memApplication.ShowDialog();
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
