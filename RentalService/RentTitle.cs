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
    public partial class RentTitle : Form
    {
        DataGridViewButtonColumn rentMovie;
        DataGridViewButtonColumn rentGame;
        SqlConnection conn;
        SqlCommand cmd;
        SqlConnection conn2;
        SqlCommand cmd2;
        string sql;
        int rowIndex = -1;
        int rentedBy;
        int currentRentedBy;
        int currentRow;

        public RentTitle()
        {
            InitializeComponent();
        }

        private void RentTitle_Load(object sender, EventArgs e)
        {
            dgRentMovie.Click += new EventHandler(dgRentMovie_Click);
            dgRentGame.Click += new EventHandler(dgRentGame_Click);
            getCbCustomers();
            getData();
        }

        private void dgRentMovie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            currentRow = int.Parse(e.RowIndex.ToString());
            string movieTitle = dgRentMovie[0, currentRow].Value.ToString();
            currentRentedBy = Convert.ToInt32(dgRentMovie[5, currentRow].Value.ToString());
            try
            {
                //Rent a movie
                if(rentalGood())
                {
                    if (dgRentMovie.Columns[e.ColumnIndex] == rentMovie && currentRow >= 0)
                    {
                        sql = "UPDATE [movieList] SET [RentedBy] = " + rentedBy + "  WHERE [MovieTitle] = '" + movieTitle + "'";

                        conn.Open();
                        cmd.CommandText = sql;
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        getMovies();
                        this.Close();
                    }
                }
            }
            catch (SqlException ex)
            {
                if (conn != null)
                {
                    conn.Close();
                }
                MessageBox.Show("This title can't be rented at the momemt", "Rental Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgRentGame_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            currentRow = int.Parse(e.RowIndex.ToString());
            string gameTitle = dgRentGame[1, currentRow].Value.ToString();
            currentRentedBy = Convert.ToInt32(dgRentGame[6, currentRow].Value.ToString());
            try
            {
                //Rent a movie
                if(rentalGood())
                {
                    if (dgRentGame.Columns[e.ColumnIndex] == rentGame && currentRow >= 0)
                    {
                        sql = "UPDATE [gameList] SET [RentedBy] = " + rentedBy + "  WHERE [GameTitle] = '" + gameTitle + "'";

                        conn.Open();
                        cmd.CommandText = sql;
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        getGames();
                        this.Close();
                    }
                }
            }
            catch (SqlException ex)
            {
                if (conn != null)
                {
                    conn.Close();
                }
                MessageBox.Show("This title can't be rented at the momemt", "Rental Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void getData()
        {
            string connStr = "Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename = D:\\Projects\\RentalService\\RentalService\\App_Data\\RentalData.mdf; Integrated Security = True";
            try
            {
                //Load movie table
                conn = new SqlConnection(connStr);
                conn.Open();
                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM [movieList]";
                SqlDataReader dr = cmd.ExecuteReader();
                bindingSource1.DataSource = dr;
                dgRentMovie.DataSource = bindingSource1;
                dr.Close();
                conn.Close();

                rentMovie = new DataGridViewButtonColumn();
                rentMovie.HeaderText = " ";
                rentMovie.Text = "Rent Movie";
                rentMovie.UseColumnTextForButtonValue = true;
                dgRentMovie.Columns.Add(rentMovie);

                //Load game table
                conn = new SqlConnection(connStr);
                conn.Open();
                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM [gameList]";
                dr = cmd.ExecuteReader();
                bindingSource2.DataSource = dr;
                dgRentGame.DataSource = bindingSource2;
                dr.Close();
                conn.Close();

                rentGame = new DataGridViewButtonColumn();
                rentGame.HeaderText = " ";
                rentGame.Text = "Rent Game";
                rentGame.UseColumnTextForButtonValue = true;
                dgRentGame.Columns.Add(rentGame);
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

        void dgRentMovie_Click(object sender, EventArgs e)
        {
            rowIndex = dgRentMovie.CurrentRow.Index;
        }

        void dgRentGame_Click(object sender, EventArgs e)
        {
            rowIndex = dgRentGame.CurrentRow.Index;
        }

        private bool rentalGood()
        {
            if (rentedBy.Equals(0))
            {
                MessageBox.Show("Please choose another member", "Rental Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (cbCustomers.Text.Equals("") || cbCustomers.Text.Equals(" ") || cbCustomers.Text.Equals(null))
            {
                MessageBox.Show("Please choose a member", "Rental Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!currentRentedBy.Equals(0))
            {
                MessageBox.Show("This title is currently unavailable", "Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void cmdReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connStr = "Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename = D:\\Projects\\RentalService\\RentalService\\App_Data\\RentalData.mdf; Integrated Security = True";
            conn = new SqlConnection(connStr);
            conn.Open();
            cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT [MemberID] FROM [memberList] WHERE [FirstName] = '" + cbCustomers.Text + "'";
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    rentedBy = rentedBy = Convert.ToInt32(dr.GetValue(0));
                }
            }
            dr.Close();
            conn.Close();
        }

        private void getMovies()
        {
            string connStr = "Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename = D:\\Projects\\RentalService\\RentalService\\App_Data\\RentalData.mdf; Integrated Security = True";
            try
            {
                //Load movie table
                conn = new SqlConnection(connStr);
                conn.Open();
                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM [movieList]";
                SqlDataReader dr = cmd.ExecuteReader();
                bindingSource1.DataSource = dr;
                dgRentMovie.DataSource = bindingSource1;
                dr.Close();
                conn.Close();
            }
            catch (SqlException ex)
            {
                if (conn != null)
                {
                    conn.Close();
                }
                MessageBox.Show("Movie data won't load", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void getGames()
        {
            string connStr = "Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename = D:\\Projects\\RentalService\\RentalService\\App_Data\\RentalData.mdf; Integrated Security = True";
            try
            {
                //Load game table
                conn2 = new SqlConnection(connStr);
                conn2.Open();
                cmd2 = new SqlCommand();
                cmd2.Connection = conn2;
                cmd2.CommandText = "SELECT * FROM [gameList]";
                SqlDataReader dr2 = cmd2.ExecuteReader();
                bindingSource2.DataSource = dr2;
                dgRentGame.DataSource = bindingSource2;
                dr2.Close();
                conn2.Close();
            }
            catch (SqlException ex)
            {
                if (conn2 != null)
                {
                    conn2.Close();
                }
                MessageBox.Show("Game data won't load", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void getCbCustomers()
        {
            string connStr = "Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename = D:\\Projects\\RentalService\\RentalService\\App_Data\\RentalData.mdf; Integrated Security = True";
            conn = new SqlConnection(connStr);
            conn.Open();
            cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT [FirstName] FROM [memberList] WHERE [status] = 'Active'";
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    cbCustomers.Items.Add(dr.GetValue(0));
                }
            }
            dr.Close();
            conn.Close();
        }
    }
}
