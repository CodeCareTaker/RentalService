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
    public partial class MovieEdit : Form
    {
        public string movieTitle;
        public string movieGenre;
        public int movieYear;
        public string movieStar;
        public string movieDirector;
        public int rentedBy;
        string sql;
        SqlConnection conn;
        SqlCommand cmd;

        public MovieEdit()
        {
            InitializeComponent();
        }

        private void MovieEdit_Load(object sender, EventArgs e)
        {
            cbMovieGenre.Items.Add("Action");
            cbMovieGenre.Items.Add("Romance");
            cbMovieGenre.Items.Add("Adventure");
            cbMovieGenre.Items.Add("Horror");
            cbMovieGenre.Items.Add("Documentary");
            cbMovieGenre.Items.Add("Comedy");
            cbMovieGenre.Items.Add("Sci-Fi");
            cbMovieGenre.Items.Add("Sports");
            cbMovieGenre.Items.Add("Crime");
            cbMovieGenre.Items.Add("Drama");

            txtMovT.ContextMenu = new System.Windows.Forms.ContextMenu();
            cbMovieGenre.ContextMenu = new System.Windows.Forms.ContextMenu();
            txtMovY.ContextMenu = new System.Windows.Forms.ContextMenu();
            txtMovS.ContextMenu = new System.Windows.Forms.ContextMenu();
            txtMovD.ContextMenu = new System.Windows.Forms.ContextMenu();

            txtMovT.KeyPress += new KeyPressEventHandler(txtMovT_KeyPress);
            txtMovY.KeyPress += new KeyPressEventHandler(txtMovY_KeyPress);
            txtMovS.KeyPress += new KeyPressEventHandler(txtMovS_KeyPress);
            txtMovD.KeyPress += new KeyPressEventHandler(txtMovD_KeyPress);

            getData();
            txtMovT.Text = movieTitle;
            cbMovieGenre.Text = movieGenre;
            txtMovY.Text = movieYear.ToString();
            txtMovS.Text = movieStar;
            txtMovD.Text = movieDirector;
        }

        void txtMovT_KeyPress(object sender, KeyPressEventArgs e)
        {
            int c = e.KeyChar;
            int len = ((TextBox)sender).Text.Length;
            ((TextBox)sender).SelectionStart = len;

            if (c != 8)
            {
                if (len < 2)
                {
                    if ((c < 65 || c > 90) && (c < 97 || c > 122) && (c < 48 || c > 57))
                    {
                        e.Handled = true;
                    }
                }
                else if ((c < 65 || c > 90) && (c < 97 || c > 122) && (c < 48 || c > 57))
                {
                    if (c != 32)
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        void txtMovY_KeyPress(object sender, KeyPressEventArgs e)
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

        void txtMovS_KeyPress(object sender, KeyPressEventArgs e)
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

        void txtMovD_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cmdEditMovie_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "UPDATE [movieList] SET [MovieTitle] = '" + movieTitle + "', [MovieGenre] = '" + cbMovieGenre.Text + "', [MovieYear] = " + txtMovY.Text + ", [MovieStar] = '" + txtMovS.Text + "', [MovieDirector] = '" + txtMovD.Text + "', [RentedBy] = " + rentedBy + "  WHERE [MovieTitle] = '" + movieTitle + "'";

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
                cmd.CommandText = "SELECT * FROM [movieList]";
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
            if (txtMovT.Text.Length < 1)
            {
                MessageBox.Show("Please enter a valid movie title, Must have more than 1 character", "Movie Title Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMovT.Focus();
                return false;
            }
            else if (txtMovY.Text.Length < 4 || txtMovY.Text.Length > 4)
            {
                MessageBox.Show("Please enter a valid movie release year, there must be 4 chracters", "Release Year Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMovY.Focus();
                return false;
            }
            else if (txtMovS.Text.Length < 1)
            {
                MessageBox.Show("Please enter a valid movie star, Must have more than 1 character", "Movie Star Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMovS.Focus();
                return false;
            }
            else if (txtMovD.Text.Length < 1)
            {
                MessageBox.Show("Please enter a valid movie director, Must have more than 1 character", "Movie Director Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMovD.Focus();
                return false;
            }
            else if (cbMovieGenre.Text.Equals("") || cbMovieGenre.Text.Equals(" "))
            {
                MessageBox.Show("You must select a Genre", "Genre Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMovT.Focus();
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
