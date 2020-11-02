using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Project4
{
    public partial class Form1 : Form
    {
        NpgsqlConnection dbConnection;
        public Form1()
        {
            InitializeComponent();

            SetDBConnection("localhost", "postgres", "peteypete117", "OOP");

            CheckPostgresVersion();

            GetMembersFromDB();
            GetMoviesFromDB();
            GetGenresFromDB();


            moviesListView.View = View.Details;
            moviesListView.FullRowSelect = true;
            moviesListView.GridLines = true;
            moviesListView.Columns.Add("Title");
            moviesListView.Columns.Add("Year");
            moviesListView.Columns.Add("Length");

        }

        List<Genre> foundGenres = new List<Genre>();


        /// <summary>
        /// This method setsup a db connection to a postgreSQL db. The connection is stored in the global variable 'dbConnection'
        /// </summary>
        /// <param name="serverAddress">The server name or IP address</param>
        /// <param name="username">The username having the right to manipulate the db</param>
        /// <param name="passwd">The corresponding password of the user</param>
        /// <param name="dbName">The db to connect to</param>
        /// <returns></returns>
        private void SetDBConnection(string serverAddress, string username, string passwd, string dbName)
        {
            string conectionString = "Host=" + serverAddress + "; Username=" + username + "; Password=" + passwd + "; Database=" + dbName + ";";

            dbConnection = new NpgsqlConnection(conectionString);
        }

        private void CheckPostgresVersion()
        {
            dbConnection.Open();

            string sqlQuery = "SELECT version()";

            NpgsqlCommand dbCommand = new NpgsqlCommand(sqlQuery, dbConnection);

            string postgresVersion = dbCommand.ExecuteScalar().ToString();

            dbConnection.Close();



        }

        /// <summary>
        /// This methods the info of the movie members and returns the new member list containing that info.
        /// </summary>
        /// <param name="MembersId">The employee ID</param>
        /// <returns></returns>
        private List<Member> GetMembersFromDB()
        {
            Member currentMember;
            List<Member> foundMembers = new List<Member>();

            // Open the connection to the database.
            dbConnection.Open();

            // This respresents the SQL query to execute in the database.
            string sqlQuery = "SELECT * FROM Member;";

            // This is the actual SQL containing the query to be executed.
            NpgsqlCommand dbCommand = new NpgsqlCommand(sqlQuery, dbConnection);

            // This variable stores the result of the SQL query sent to the database.
            NpgsqlDataReader dataReader = dbCommand.ExecuteReader();

            // Read each line present in the dataReader.
            while (dataReader.Read())
            {
                // Create new member.
                currentMember = new Member();

                // Retrieve the member information from the database.
                currentMember.ID = dataReader.GetInt32(0);
                currentMember.Name = dataReader.GetString(1);
                currentMember.DOB = dataReader.GetDateTime(2);
                currentMember.Type = dataReader.GetInt32(3);

                // Add the member to the member list.
                foundMembers.Add(currentMember);

            }
            // Close the connection to the database.
            dbConnection.Close();

            return foundMembers;
        }

        private List<Movie> GetMoviesFromDB()
        {
            Movie currentMovie;
            List<Movie> foundMovies = new List<Movie>();

            // Open the connection to the database.
            dbConnection.Open();

            // This respresents the SQL query to execute in the database.
            string sqlQuery = "SELECT * FROM Movie;";

            // This is the actual SQL containing the query to be executed.
            NpgsqlCommand dbCommand = new NpgsqlCommand(sqlQuery, dbConnection);

            // This variable stores the result of the SQL query sent to the database.
            NpgsqlDataReader dataReader = dbCommand.ExecuteReader();

            // Read each line present in the dataReader.
            while (dataReader.Read())
            {
                // Create new movie.
                currentMovie = new Movie();

                // Retrieve the movie information from the database.
                currentMovie.ID = dataReader.GetInt32(0);
                currentMovie.Title = dataReader.GetString(1);
                currentMovie.Year = dataReader.GetInt32(2);
                currentMovie.Length = dataReader.GetInterval(3).ToString();
                currentMovie.Rating = dataReader.GetDouble(4);
                // If there is no image for the movie.
                if (dataReader.IsDBNull(5))
                {
                    currentMovie.Image = "";
                }
                else
                {
                    currentMovie.Image = dataReader.GetString(5);
                }

                // Add the movie to the movie list.
                foundMovies.Add(currentMovie);
            }

            // Close the connection to the database.
            dbConnection.Close();

            return foundMovies;
        }

        private List<Genre> GetGenresFromDB()
        {
            Genre currentGenre;

            // Open the connection to the database.
            dbConnection.Open();

            // This respresents the SQL query to execute in the database.
            string sqlQuery = "SELECT * FROM Genre;";

            // This is the actual SQL containing the query to be executed.
            NpgsqlCommand dbCommand = new NpgsqlCommand(sqlQuery, dbConnection);

            // This variable stores the result of the SQL query sent to the database.
            NpgsqlDataReader dataReader = dbCommand.ExecuteReader();

            // Retrieve the genre information from the database.
            while (dataReader.Read())
            {
                // Create new genre.
                currentGenre = new Genre();

                // Retrieve the genre information from the database.
                currentGenre.Code = dataReader.GetString(0);
                currentGenre.Name = dataReader.GetString(1);
                // If there is no description for the genre.
                if (dataReader.IsDBNull(2))
                {
                    currentGenre.Description = "";
                }
                else
                {
                    currentGenre.Description = dataReader.GetString(2);
                }

                // Add the genre to the genre list.
                foundGenres.Add(currentGenre);

                // Add the genre to the genre combo box.
                genreNameComboBox.Items.Add(currentGenre.Name);
            }

            // Close the connection to the database.
            dbConnection.Close();

            return foundGenres;
        }

        private void Clear()
        {
            moviesListView.Clear();

            yearTextBox.Clear();
            lengthTextBox.Clear();
            ratingTextBox.Clear();
            imageTextBox.Clear();
            moviesPictureBox.ImageLocation = "";

        }

        private void genreNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Clear the listview and textboxes.
            Clear();

            // Add column titles to the ListView.
            moviesListView.Columns.Add("Title");
            moviesListView.Columns.Add("Year");
            moviesListView.Columns.Add("length");

            foreach (Genre currentGenre in foundGenres)
            {
                if (genreNameComboBox.GetItemText(genreNameComboBox.SelectedItem) == currentGenre.Name)
                {

                    genreCodeTextBox.Text = currentGenre.Code;
                    genreDescriptionTextBox.Text = currentGenre.Description;
                }
            }
        
    }
    }
    
}
//hello

