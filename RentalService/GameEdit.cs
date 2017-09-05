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
    public partial class GameEdit : Form
    {
        public string gameTitle;
        public string gameGenre;
        public int gameYear;
        public string gameDeveloper;
        public string gamePublisher;
        public int rentedBy;
        string sql;
        SqlConnection conn;
        SqlCommand cmd;

        public GameEdit()
        {
            InitializeComponent();
        }

        private void GameEdit_Load(object sender, EventArgs e)
        {
            cbGameGenre.Items.Add("Action");
            cbGameGenre.Items.Add("RPG");
            cbGameGenre.Items.Add("Shooter");
            cbGameGenre.Items.Add("Horror");
            cbGameGenre.Items.Add("Puzzle");
            cbGameGenre.Items.Add("Platformer");

            txtGameT.ContextMenu = new System.Windows.Forms.ContextMenu();
            cbGameGenre.ContextMenu = new System.Windows.Forms.ContextMenu();
            txtGameR.ContextMenu = new System.Windows.Forms.ContextMenu();
            txtGameD.ContextMenu = new System.Windows.Forms.ContextMenu();
            txtGameP.ContextMenu = new System.Windows.Forms.ContextMenu();

            txtGameT.KeyPress += new KeyPressEventHandler(TxtGameT_KeyPress);
            txtGameR.KeyPress += new KeyPressEventHandler(txtGameR_KeyPress);
            txtGameD.KeyPress += new KeyPressEventHandler(txtGameD_KeyPress);
            txtGameP.KeyPress += new KeyPressEventHandler(txtGameP_KeyPress);

            getData();
            txtGameT.Text = gameTitle;
            cbGameGenre.Text = gameGenre;
            txtGameR.Text = gameYear.ToString();
            txtGameD.Text = gameDeveloper;
            txtGameP.Text = gamePublisher;
        }

        void TxtGameT_KeyPress(object sender, KeyPressEventArgs e)
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

        void txtGameR_KeyPress(object sender, KeyPressEventArgs e)
        {
            int c = e.KeyChar;
            int len = ((TextBox)sender).Text.Length;
            ((TextBox)sender).SelectionStart = len;

            if (c != 8)
            {
                if (c < 48 || c > 57)
                {
                    e.Handled = true;
                }
            }
        }

        void txtGameD_KeyPress(object sender, KeyPressEventArgs e)
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

        void txtGameP_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cmdEditGame_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "UPDATE [gameList] SET [GameTitle] = '" + gameTitle + "', [GameGenre] = '" + cbGameGenre.Text + "', [GameYear] = " + int.Parse(txtGameR.Text) + ", [GameDeveloper] = '" + txtGameD.Text + "', [GamePublisher] = '" + txtGameP.Text + "', [RentedBy] = " + rentedBy + "  WHERE [GameTitle] = '" + gameTitle + "'";

                conn.Open();
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
                MessageBox.Show("This title can't be modified", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void getData()
        {
            string connStr = "Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename = D:\\Projects\\RentalService\\RentalService\\App_Data\\RentalData.mdf; Integrated Security = True";

            try
            {
                conn = new SqlConnection(connStr);
                conn.Open();
                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM [gameList]";
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Close();
                conn.Close();
            }
            catch (SqlException ex)
            {
                if (conn != null)
                {
                    conn.Close();
                }
                MessageBox.Show("Data couldn't be loaded", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool dataGood()
        {
            if (txtGameT.Text.Length < 1)
            {
                MessageBox.Show("Please enter a valid game title, Must have more than 1 character", "Game Title Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGameT.Focus();
                return false;
            }
            else if (txtGameR.Text.Length < 4 || txtGameR.Text.Length > 4)
            {
                MessageBox.Show("Please enter a valid game release year, there must be 4 chracters", "Release Year Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGameR.Focus();
                return false;
            }
            else if (txtGameD.Text.Length < 1)
            {
                MessageBox.Show("Please enter a valid game developer, Must have more than 1 character", "Game Developer Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGameD.Focus();
                return false;
            }
            else if (txtGameP.Text.Length < 1)
            {
                MessageBox.Show("Please enter a valid game publisher, Must have more than 1 character", "Game Publisher Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGameP.Focus();
                return false;
            }
            else if (cbGameGenre.Text.Equals("") || cbGameGenre.Text.Equals(" "))
            {
                MessageBox.Show("You must select a Genre", "Genre Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGameT.Focus();
                return false;
            }
            return true;
        }

        private void cmdReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
