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
        /// This methods the info of a particular empoyee and returns a new Employee object containing that info
        /// </summary>
        /// <param name="MembersId">The employee ID</param>
        /// <returns></returns>
        private List<Member> GetMembersFromDB()
        {

            Member currentMember;
            List<Member> foundMembers = new List<Member>();

            dbConnection.Open();

            string sqlQuery = "SELECT * FROM Member;";

            NpgsqlCommand dbCommand = new NpgsqlCommand(sqlQuery, dbConnection);

            NpgsqlDataReader dataReader = dbCommand.ExecuteReader();

            while (dataReader.Read())
            {
                currentMember = new Member();

                currentMember.ID = dataReader.GetInt32(0);
                currentMember.Name = dataReader.GetString(1);
                currentMember.DOB = dataReader.GetDateTime(2);
                currentMember.Type = dataReader.GetInt32(3);

                foundMembers.Add(currentMember);
                
            }
            dbConnection.Close();

            return foundMembers;
        }

        private List<Movie> GetMoviesFromDB()
        {
            Movie currentMovie;
            List<Movie> foundMovies = new List<Movie>();


            dbConnection.Open();

            string sqlQuery = "SELECT * FROM Movie;";

            NpgsqlCommand dbCommand = new NpgsqlCommand(sqlQuery, dbConnection);

            NpgsqlDataReader dataReader = dbCommand.ExecuteReader();

            while (dataReader.Read())
            {
                currentMovie = new Movie();

                currentMovie.ID = dataReader.GetInt32(0);
                currentMovie.Title = dataReader.GetString(1);
                currentMovie.Year = dataReader.GetInt32(2);
                currentMovie.Length = dataReader.GetInterval(3).ToString();
                currentMovie.Rating = dataReader.GetDouble(4);
                if (dataReader.IsDBNull(5))
                {
                    currentMovie.Image = "";
                }
                else
                {
                  currentMovie.Image = dataReader.GetString(5);
                }

                foundMovies.Add(currentMovie);
            }

            dbConnection.Close();

            
            return foundMovies;
        }

        private List<Genre> GetGenresFromDB()
        {
         
            Genre currentGenre;

            dbConnection.Open();

            string sqlQuery = "SELECT * FROM Genre;";

            NpgsqlCommand dbCommand = new NpgsqlCommand(sqlQuery, dbConnection);

            NpgsqlDataReader dataReader = dbCommand.ExecuteReader();

            while (dataReader.Read())
            {
                currentGenre = new Genre();

                currentGenre.Code = dataReader.GetString(0);
                currentGenre.Name = dataReader.GetString(1);
                if (dataReader.IsDBNull(2))
                {
                    currentGenre.Description = "";
                }
                else
                {
                    currentGenre.Description = dataReader.GetString(2);
                }
                foundGenres.Add(currentGenre); 
                genreNameComboBox.Items.Add(currentGenre.Name);
            }

         
            
            dbConnection.Close();

           
            return foundGenres;
        }

        private void genreNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
                foreach(Genre currentGenre in foundGenres)
                {
                  if(genreNameComboBox.GetItemText(genreNameComboBox.SelectedItem) == currentGenre.Name)
                  {
                       genreCodeTextBox.Text = currentGenre.Code;
                       genreDescriptionTextBox.Text = currentGenre.Description;
                  }
                }
        }
    }
}
//hello

