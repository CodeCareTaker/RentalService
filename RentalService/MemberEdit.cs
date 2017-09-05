using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RentalService
{
    public partial class MemberEdit : Form
    {
        public int memID;
        public string firstName;
        public string lastName;
        public string addressNumber;
        public string streetName;
        public string city;
        public string postalCode;
        public string province;
        public string status;
        SqlConnection conn;
        SqlCommand cmd;
        public MemberEdit()
        {
            InitializeComponent();
        }

        private void MemberEdit_Load(object sender, EventArgs e)
        {
            cbProvince.Items.Add("Ontario");
            cbProvince.Items.Add("Quebec");
            cbProvince.Items.Add("Manitoba");
            cbProvince.Items.Add("Saskatchewan");
            cbProvince.Items.Add("Nunavut");
            cbProvince.Items.Add("North West Territories");
            cbProvince.Items.Add("Yukon");
            cbProvince.Items.Add("British Columbia");
            cbProvince.Items.Add("Nova Scotia");
            cbProvince.Items.Add("New Brunswick");
            cbProvince.Items.Add("Prince Edward Island");
            cbProvince.Items.Add("Newfoundland");
            cbProvince.Items.Add("Alberta");
            txtFN.ContextMenu = new System.Windows.Forms.ContextMenu();
            txtLN.ContextMenu = new System.Windows.Forms.ContextMenu();
            txtAdNum.ContextMenu = new System.Windows.Forms.ContextMenu();
            txtStreet.ContextMenu = new System.Windows.Forms.ContextMenu();
            txtCity.ContextMenu = new System.Windows.Forms.ContextMenu();
            txtPostal.ContextMenu = new System.Windows.Forms.ContextMenu();
            txtFN.KeyPress += new KeyPressEventHandler(txtFN_KeyPress);
            txtLN.KeyPress += new KeyPressEventHandler(txtLN_KeyPress);
            txtAdNum.KeyPress += new KeyPressEventHandler(txtAdNum_KeyPress);
            txtStreet.KeyPress += new KeyPressEventHandler(txtStreet_KeyPress);
            txtCity.KeyPress += new KeyPressEventHandler(txtCity_KeyPress);
            txtPostal.KeyPress += new KeyPressEventHandler(txtPostal_KeyPress);

        txtFN.Text = firstName;
        txtLN.Text = lastName;
        txtAdNum.Text = addressNumber;
        txtStreet.Text = streetName;
        txtCity.Text = city;
        txtPostal.Text = postalCode;
        cbProvince.Text = province;
        }

        private void cmdReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdApply_Click(object sender, EventArgs e)
        {
            if (dataGood())
            {
                string connStr = "Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename = D:\\Projects\\RentalService\\RentalService\\App_Data\\RentalData.mdf; Integrated Security = True";

                try
                {
                    //address number variable
                    int adNum = Convert.ToInt32(txtAdNum.Text);

                    //
                    string sql = "UPDATE [memberList] SET [FirstName] = '" + txtFN.Text + "', [LastName] = '" + txtLN.Text + "', [AddressNumber] = " + adNum + ", [AddressStreet] = '" + txtStreet.Text + "', [City] ='" + txtCity.Text + "', [PostalCode] = '" + txtPostal.Text + "', [Province] = '" + cbProvince.Text + "'  WHERE [MemberID] = " + memID + "";

                    conn = new SqlConnection(connStr);
                    conn.Open();
                    cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    this.Close();
                }
                catch (SqlException ex)
                {
                    if (conn != null)
                    {
                        conn.Close();
                    }
                    MessageBox.Show("This Membership can't be modified", "Member Application Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }

        void txtFN_KeyPress(object sender, KeyPressEventArgs e)
        {
            int c = e.KeyChar;
            int len = ((TextBox)sender).Text.Length;
            ((TextBox)sender).SelectionStart = len;

            if (c != 8)
            {
                if (len < 2)
                {
                    if ((c < 65 || c > 90) && (c < 97 || c > 122))
                    {
                        e.Handled = true;
                    }
                }
                else if ((c < 65 || c > 90) && (c < 97 || c > 122))
                {
                    e.Handled = true;
                }
            }
        }

        void txtLN_KeyPress(object sender, KeyPressEventArgs e)
        {
            int c = e.KeyChar;
            int len = ((TextBox)sender).Text.Length;
            ((TextBox)sender).SelectionStart = len;

            if (c != 8)
            {
                if (len < 2)
                {
                    if ((c < 65 || c > 90) && (c < 97 || c > 122))
                    {
                        e.Handled = true;
                    }
                }
                else if ((c < 65 || c > 90) && (c < 97 || c > 122))
                {
                    e.Handled = true;
                }
            }
        }

        void txtAdNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            int c = e.KeyChar;
            int len = ((TextBox)sender).Text.Length;
            ((TextBox)sender).SelectionStart = len;

            if (c != 8)
            {
                if (len < 2)
                {
                    if (c < 49 || c > 57)
                    {
                        e.Handled = true;
                    }
                }
                else if (c < 48 || c > 57)
                {
                    e.Handled = true;
                }
            }
        }

        void txtStreet_KeyPress(object sender, KeyPressEventArgs e)
        {
            int c = e.KeyChar;
            int len = ((TextBox)sender).Text.Length;
            ((TextBox)sender).SelectionStart = len;

            if (c != 8)
            {
                if (len < 2)
                {
                    if ((c < 65 || c > 90) && (c < 97 || c > 122))
                    {
                        e.Handled = true;
                    }
                }
                else if ((c < 65 || c > 90) && (c < 97 || c > 122))
                {
                    if (c != 32)
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        void txtCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            int c = e.KeyChar;
            int len = ((TextBox)sender).Text.Length;
            ((TextBox)sender).SelectionStart = len;

            if (c != 8)
            {
                if (len < 2)
                {
                    if ((c < 65 || c > 90) && (c < 97 || c > 122))
                    {
                        e.Handled = true;
                    }
                }
                else if ((c < 65 || c > 90) && (c < 97 || c > 122))
                {
                    if (c != 32)
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        void txtPostal_KeyPress(object sender, KeyPressEventArgs e)
        {
            int c = e.KeyChar;
            int len = ((TextBox)sender).Text.Length;
            ((TextBox)sender).SelectionStart = len;

            if (c != 8)
            {
                if ((len % 2) == 0)
                {
                    if ((c < 65 || c > 90) && (c < 97 || c > 122))
                    {
                        e.Handled = true;
                    }
                }
                else if (c < 48 || c > 57)
                {
                    if (c != 32)
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private bool dataGood()
        {
            if (txtFN.Text.Length < 2)
            {
                MessageBox.Show("Please enter a valid First Name, Must have more than 1 character", "First Name Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFN.Focus();
                return false;
            }
            else if (txtLN.Text.Length < 2)
            {
                MessageBox.Show("Please enter a valid Last Name, Must have more than 1 character", "Last Name Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLN.Focus();
                return false;
            }
            else if (txtAdNum.Text.Length < 1 || txtAdNum.Text.Length > 8)
            {
                MessageBox.Show("Please enter valid a Address number, there must be 1 to 8 numbers", "Address Number Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAdNum.Focus();
                return false;
            }
            else if (txtStreet.Text.Length < 2)
            {
                MessageBox.Show("Please enter a valid street name, Must have more than 1 character", "Street Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStreet.Focus();
                return false;
            }
            else if (txtCity.Text.Length < 2)
            {
                MessageBox.Show("Please enter a valid city, Must have more than 1 character", "City Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCity.Focus();
                return false;
            }
            else if (txtPostal.Text.Length < 6)
            {
                MessageBox.Show("Please enter a valid postal code, Must have six characters in the following format(A1B2B3)", "Postal Code Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPostal.Focus();
                return false;
            }
            else if (cbProvince.Text.Equals("") || cbProvince.Text.Equals(" "))
            {
                MessageBox.Show("You must select a Province", "Province Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFN.Focus();
                return false;
            }
            return true;
        }
    }
}
