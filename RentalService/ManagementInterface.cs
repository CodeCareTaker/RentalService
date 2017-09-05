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
    public partial class ManagementInterface : Form
    {
        DataGridViewButtonColumn movieEditButton;
        DataGridViewButtonColumn movieDeleteButton;
        DataGridViewButtonColumn movieReturnedButton;
        DataGridViewButtonColumn gameEditButton;
        DataGridViewButtonColumn gameDeleteButton;
        DataGridViewButtonColumn gameReturnedButton;
        DataGridViewButtonColumn memActivatedButton;
        DataGridViewButtonColumn memDeactivatedButton;
        DataGridViewButtonColumn memEditButton;
        SqlConnection conn;
        SqlCommand cmd;
        SqlConnection conn2;
        SqlCommand cmd2;
        SqlConnection conn3;
        SqlCommand cmd3;
        int memID;
        int rowIndex = -1;

        public ManagementInterface()
        {
            InitializeComponent();
        }

        private void ManagementInterface_Load(object sender, EventArgs e)
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
            cbGameGenre.Items.Add("Action");
            cbGameGenre.Items.Add("RPG");
            cbGameGenre.Items.Add("Shooter");
            cbGameGenre.Items.Add("Horror");
            cbGameGenre.Items.Add("Puzzle");
            cbGameGenre.Items.Add("Platformer");
            txtMovT.ContextMenu = new System.Windows.Forms.ContextMenu();
            cbMovieGenre.ContextMenu = new System.Windows.Forms.ContextMenu();
            txtMovY.ContextMenu = new System.Windows.Forms.ContextMenu();
            txtMovS.ContextMenu = new System.Windows.Forms.ContextMenu();
            txtMovD.ContextMenu = new System.Windows.Forms.ContextMenu();
            txtGameT.ContextMenu = new System.Windows.Forms.ContextMenu();
            cbGameGenre.ContextMenu = new System.Windows.Forms.ContextMenu();
            txtGameR.ContextMenu = new System.Windows.Forms.ContextMenu();
            txtGameD.ContextMenu = new System.Windows.Forms.ContextMenu();
            txtGameP.ContextMenu = new System.Windows.Forms.ContextMenu();
            dgMovies.Click += new EventHandler(dgMovies_Click);
            dgGames.Click += new EventHandler(dgGames_Click);
            dgCustomers.Click += new EventHandler(dgCustomers_Click);
            txtMovT.KeyPress += new KeyPressEventHandler(txtMovT_KeyPress);
            txtMovY.KeyPress += new KeyPressEventHandler(txtMovY_KeyPress);
            txtMovS.KeyPress += new KeyPressEventHandler(txtMovS_KeyPress);
            txtMovD.KeyPress += new KeyPressEventHandler(txtMovD_KeyPress);
            txtMoPr.KeyPress += new KeyPressEventHandler(txtMoPr_KeyPress);
            txtGameT.KeyPress += new KeyPressEventHandler(txtGameT_KeyPress);
            txtGameR.KeyPress += new KeyPressEventHandler(txtGameR_KeyPress);
            txtGameD.KeyPress += new KeyPressEventHandler(txtGameD_KeyPress);
            txtGameP.KeyPress += new KeyPressEventHandler(txtGameP_KeyPress);
            getData();
        }

        void dgMovies_Click(object sender, EventArgs e)
        {
            rowIndex = dgMovies.CurrentRow.Index;
        }

        void dgGames_Click(object sender, EventArgs e)
        {
            rowIndex = dgGames.CurrentRow.Index;
        }

        void dgCustomers_Click(object sender, EventArgs e)
        {
            rowIndex = dgCustomers.CurrentRow.Index;
        }

        // Validation for textboxes
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

        void txtMoPr_KeyPress(object sender, KeyPressEventArgs e)
        {
            int c = e.KeyChar;
            int len = ((TextBox)sender).Text.Length;
            ((TextBox)sender).SelectionStart = len;
            string text = ((TextBox)sender).Text;

            if (c != 8)
            {
                if (len < 2)
                {
                    if (c < 49 || c > 57)
                    {
                        e.Handled = true;
                    }
                }
                else if ((c < 48 || c > 57) && (text.IndexOf(".") != -1 && c != 56))
                {
                    if (c != 32)
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        void txtGameT_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cmdAddMovie_Click(object sender, EventArgs e)
        {
            memID = 0;
            string connStr = "Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename = D:\\Projects\\RentalService\\RentalService\\App_Data\\RentalData.mdf; Integrated Security = True";
            //Adds new movie to the table
            try
            {
                string sql = "INSERT INTO [movieList] ([MovieTitle], [MovieGenre], [MovieYear], [MovieStar], [MovieDirector], [RentedBy]) VALUES ('" + txtMovT.Text + "', '" + cbMovieGenre.Text + "', " + int.Parse(txtMovY.Text) + ", '" + txtMovS.Text + "', '" + txtMovD.Text + "', " + memID + ")";

                conn = new SqlConnection(connStr);
                conn.Open();
                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                conn.Close();
                getMovies();
                clearText();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("This movie can't be added", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clearText();
            }
        }

        private void cmdAddGame_Click(object sender, EventArgs e)
        {
            memID = 0;
            string connStr = "Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename = D:\\Projects\\RentalService\\RentalService\\App_Data\\RentalData.mdf; Integrated Security = True";
            //Adds new game to the table
            try
            {
                string sql = "INSERT INTO [gameList] ([GameTitle], [GameGenre], [GameYear], [GameDeveloper], [GamePublisher], [RentedBy]) VALUES ('" + txtGameT.Text + "', '" + cbGameGenre.Text + "', " + int.Parse(txtGameR.Text) + ", '" + txtGameD.Text + "', '" + txtGameP.Text + "', " + memID + ")";

                conn = new SqlConnection(connStr);
                conn.Open();
                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                conn.Close();
                getGames();
                clearText();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("This game can't be added", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clearText();
            }
        }

        private void dgMovies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            string movieTitle;
            string movieGenre;
            int movieYear;
            string movieStar;
            string movieDirector;
            int rentedBy;
            int memID2 = 0;
            int currentRow = int.Parse(e.RowIndex.ToString());

            try
            {
                //Press to edit movie
                if (dgMovies.Columns[e.ColumnIndex] == movieEditButton && currentRow >= 0)
                {
                    movieTitle = dgMovies[3, currentRow].Value.ToString();
                    movieGenre = dgMovies[4, currentRow].Value.ToString();
                    movieYear = int.Parse(dgMovies[5, currentRow].Value.ToString());
                    movieStar = dgMovies[6, currentRow].Value.ToString();
                    movieDirector = dgMovies[7, currentRow].Value.ToString();
                    rentedBy = int.Parse(dgMovies[8, currentRow].Value.ToString());

                    //Code for editing movie data  
                    MovieEdit movEd = new MovieEdit();
                    movEd.movieTitle = movieTitle;
                    movEd.movieGenre = movieGenre;
                    movEd.movieYear = movieYear;
                    movEd.movieStar = movieStar;
                    movEd.movieDirector = movieDirector;
                    movEd.rentedBy = rentedBy;
                    movEd.ShowDialog();
                    getMovies();
                }
                //Press to delete movie
                else if (dgMovies.Columns[e.ColumnIndex] == movieDeleteButton && currentRow >= 0)
                {
                    movieTitle = dgMovies[3, currentRow].Value.ToString();
                    string sql = "DELETE FROM [movieList] WHERE [MovieTitle] = '" + movieTitle + "'";
                    conn.Open();
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    getMovies();
                }
                //Press to return movie
                else if (dgMovies.Columns[e.ColumnIndex] == movieReturnedButton && currentRow >= 0)
                {
                    movieTitle = dgMovies[3, currentRow].Value.ToString();
                    string sql = "UPDATE [movieList] SET [RentedBy] = " + memID2 + "  WHERE [MovieTitle] = '" + movieTitle + "'";

                    conn.Open();
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    getMovies();
                }
            }
            catch (SqlException ex)
            {
                if (conn != null)
                {
                    conn.Close();
                }
                MessageBox.Show("This title can't be modified or deleted", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgGames_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            string gameTitle;
            string gameGenre;
            int gameYear;
            string gameDeveloper;
            string gamePublisher;
            int rentedBy;
            int memID2 = 0;

            int currentRow = int.Parse(e.RowIndex.ToString());
            try
            {
                //Press to edit game data
                if (dgGames.Columns[e.ColumnIndex] == gameEditButton && currentRow >= 0)
                {
                    gameTitle = dgGames[3, currentRow].Value.ToString();
                    gameGenre = dgGames[4, currentRow].Value.ToString();
                    gameYear = int.Parse(dgGames[5, currentRow].Value.ToString());
                    gameDeveloper = dgGames[6, currentRow].Value.ToString();
                    gamePublisher = dgGames[7, currentRow].Value.ToString();
                    rentedBy = int.Parse(dgGames[8, currentRow].Value.ToString());

                    //Code for editing game data   
                    GameEdit gamEd = new GameEdit();
                    gamEd.gameTitle = gameTitle;
                    gamEd.gameGenre = gameGenre;
                    gamEd.gameYear = gameYear;
                    gamEd.gameDeveloper = gameDeveloper;
                    gamEd.gamePublisher = gamePublisher;
                    gamEd.rentedBy = rentedBy;
                    gamEd.ShowDialog();
                    getGames();
                }
                //Press to delete game data
                else if (dgGames.Columns[e.ColumnIndex] == gameDeleteButton && currentRow >= 0)
                {
                    gameTitle = dgGames[3, currentRow].Value.ToString();
                    string sql = "DELETE FROM [gameList] WHERE [GameTitle] = '" + gameTitle + "'";
                    conn.Open();
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    getGames();
                }
                //Press to return game
                else if (dgGames.Columns[e.ColumnIndex] == gameReturnedButton && currentRow >= 0)
                {
                    gameTitle = dgGames[3, currentRow].Value.ToString();
                    string sql = "UPDATE [gameList] SET [RentedBy] = " + memID2 + "  WHERE [GameTitle] = '" + gameTitle + "'";

                    conn.Open();
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    getGames();
                }
            }
            catch (SqlException ex)
            {
                if (conn != null)
                {
                    conn.Close();
                }
                MessageBox.Show("This title can't be modified or deleted", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            int currentRow = int.Parse(e.RowIndex.ToString());
            try
            {
                //Activates member
                if (dgCustomers.Columns[e.ColumnIndex] == memActivatedButton && currentRow >= 0)
                {
                    memID = int.Parse(dgCustomers[3, currentRow].Value.ToString());
                    string newMemStatus = "Active";
                    string sql = "UPDATE [memberList] SET [status] = '" + newMemStatus +"'  WHERE [MemberID] = " + memID + "";

                    conn.Open();
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    getCustomers();
                }
                //De-Activates member
                else if (dgCustomers.Columns[e.ColumnIndex] == memDeactivatedButton && currentRow >= 0)
                {
                    memID = int.Parse(dgCustomers[3, currentRow].Value.ToString());
                    string newMemStatus = "De-Activated";
                    string sql = "UPDATE [memberList] SET [status] = '" + newMemStatus + "'  WHERE [MemberID] = " + memID + "";

                    conn.Open();
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    getCustomers();
                }
                else if (dgCustomers.Columns[e.ColumnIndex] == memEditButton && currentRow >= 0)
                {
                    memID = int.Parse(dgCustomers[3, currentRow].Value.ToString());
                    string firstName = dgCustomers[4, currentRow].Value.ToString();
                    string lastName = dgCustomers[5, currentRow].Value.ToString();
                    string addressNumber = dgCustomers[6, currentRow].Value.ToString();
                    string streetName = dgCustomers[7, currentRow].Value.ToString();
                    string city = dgCustomers[8, currentRow].Value.ToString();
                    string postalCode = dgCustomers[9, currentRow].Value.ToString();
                    string province = dgCustomers[10, currentRow].Value.ToString();
                    string status = dgCustomers[11, currentRow].Value.ToString();

                    //Code for editing a song    
                    MemberEdit memEd = new MemberEdit();
                    memEd.memID = memID;
                    memEd.firstName = firstName;
                    memEd.lastName = lastName;
                    memEd.addressNumber = addressNumber;
                    memEd.streetName = streetName;
                    memEd.city = city;
                    memEd.postalCode = postalCode;
                    memEd.province = province;
                    memEd.status = status;
                    memEd.ShowDialog();
                    getCustomers();
                }
            }
            catch(SqlException ex)
            {
                if (conn != null)
                {
                    conn.Close();
                }
                MessageBox.Show("This customer can't be activated, or de-activated", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void getData()
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
                dgMovies.DataSource = bindingSource1;
                dr.Close();
                conn.Close();

                movieEditButton = new DataGridViewButtonColumn();
                movieEditButton.HeaderText = " ";
                movieEditButton.Text = "Edit Movie Info";
                movieEditButton.UseColumnTextForButtonValue = true;
                dgMovies.Columns.Add(movieEditButton);

                movieDeleteButton = new DataGridViewButtonColumn();
                movieDeleteButton.HeaderText = " ";
                movieDeleteButton.Text = "Delete Movie";
                movieDeleteButton.UseColumnTextForButtonValue = true;
                dgMovies.Columns.Add(movieDeleteButton);

                movieReturnedButton = new DataGridViewButtonColumn();
                movieReturnedButton.HeaderText = " ";
                movieReturnedButton.Text = "Returned";
                movieReturnedButton.UseColumnTextForButtonValue = true;
                dgMovies.Columns.Add(movieReturnedButton);

                //Load game table
                conn = new SqlConnection(connStr);
                conn.Open();
                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM [gameList]";
                dr = cmd.ExecuteReader();
                bindingSource2.DataSource = dr;
                dgGames.DataSource = bindingSource2;
                dr.Close();
                conn.Close();

                gameEditButton = new DataGridViewButtonColumn();
                gameEditButton.HeaderText = " ";
                gameEditButton.Text = "Edit Game Info";
                gameEditButton.UseColumnTextForButtonValue = true;
                dgGames.Columns.Add(gameEditButton);

                gameDeleteButton = new DataGridViewButtonColumn();
                gameDeleteButton.HeaderText = " ";
                gameDeleteButton.Text = "Delete Game";
                gameDeleteButton.UseColumnTextForButtonValue = true;
                dgGames.Columns.Add(gameDeleteButton);

                gameReturnedButton = new DataGridViewButtonColumn();
                gameReturnedButton.HeaderText = " ";
                gameReturnedButton.Text = "Returned";
                gameReturnedButton.UseColumnTextForButtonValue = true;
                dgGames.Columns.Add(gameReturnedButton);

                //Load member table
                conn = new SqlConnection(connStr);
                conn.Open();
                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM [memberList]";
                dr = cmd.ExecuteReader();
                bindingSource3.DataSource = dr;
                dgCustomers.DataSource = bindingSource3;
                dr.Close();
                conn.Close();

                memActivatedButton = new DataGridViewButtonColumn();
                memActivatedButton.HeaderText = " ";
                memActivatedButton.Text = "Activate Member";
                memActivatedButton.UseColumnTextForButtonValue = true;
                dgCustomers.Columns.Add(memActivatedButton);

                memDeactivatedButton = new DataGridViewButtonColumn();
                memDeactivatedButton.HeaderText = " ";
                memDeactivatedButton.Text = "DeActivate Member";
                memDeactivatedButton.Width = 120;
                memDeactivatedButton.UseColumnTextForButtonValue = true;
                dgCustomers.Columns.Add(memDeactivatedButton);

                memEditButton = new DataGridViewButtonColumn();
                memEditButton.HeaderText = " ";
                memEditButton.Text = "Edit Member";
                memEditButton.UseColumnTextForButtonValue = true;
                dgCustomers.Columns.Add(memEditButton);
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
            //Checks all entered data to make sure that its valid
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
            else if (txtGameT.Text.Length < 1)
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
            else if (cbMovieGenre.Text.Equals("") || cbMovieGenre.Text.Equals(" ") || cbMovieGenre.Text.Equals(null))
            {
                MessageBox.Show("You must select a Genre", "Genre Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMovT.Focus();
                return false;
            }
            else if (cbGameGenre.Text.Equals("") || cbGameGenre.Text.Equals(" ") || cbGameGenre.Text.Equals(null))
            {
                MessageBox.Show("You must select a Genre", "Genre Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGameT.Focus();
                return false;
            }
            return true;
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
                dgMovies.DataSource = bindingSource1;
                dr.Close();
                conn.Close();
            }
            catch(SqlException ex)
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
                dgGames.DataSource = bindingSource2;
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

        private void getCustomers()
        {
            string connStr = "Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename = D:\\Projects\\RentalService\\RentalService\\App_Data\\RentalData.mdf; Integrated Security = True";
            try
            {
                //Load member table
                conn3 = new SqlConnection(connStr);
                conn3.Open();
                cmd3 = new SqlCommand();
                cmd3.Connection = conn3;
                cmd3.CommandText = "SELECT * FROM [memberList]";
                SqlDataReader dr3 = cmd3.ExecuteReader();
                bindingSource3.DataSource = dr3;
                dgCustomers.DataSource = bindingSource3;
                dr3.Close();
                conn3.Close();
            }
            catch (SqlException ex)
            {
                if (conn != null)
                {
                    conn.Close();
                }
                MessageBox.Show("Customer data won't load", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void clearText()
        {
            //Clears all text boxes
            txtMovT.Text = "";
            cbMovieGenre.Text = "";
            txtMovY.Text = "";
            txtMovS.Text = "";
            txtMovD.Text = "";
            txtGameT.Text = "";
            cbGameGenre.Text = "";
            txtGameR.Text = "";
            txtGameD.Text = "";
            txtGameP.Text = "";
        }
    }
}
