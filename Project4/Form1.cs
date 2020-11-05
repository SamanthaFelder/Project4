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
        //Constants to use when creating DB connections
        private const string DbServerHost = "localhost";
        private const string DbUsername = "postgres";
        private const string DbUuserPassword = "peteypete117";
        private const string DbName = "OOP";

        NpgsqlConnection dbConnection;
        public Form1()
        {
            InitializeComponent();

            SetDBConnection(DbServerHost, DbUsername, DbUuserPassword, DbName);

            CheckPostgresVersion();

            GetMembersFromDB();
            GetMoviesFromDB();
            GetGenresFromDB();
            //GetMemberTypeFromDB();
            //GetGenreMovieFromDB();
            //GetMovieMemberFromDB();

            moviesListView.View = View.Details;
            moviesListView.FullRowSelect = true;
            moviesListView.GridLines = true;
            moviesListView.Columns.Add("Title");
            moviesListView.Columns.Add("Year");
            moviesListView.Columns.Add("Length");

        }

        List<Genre> foundGenres = new List<Genre>();
        List<Member> foundMembers = new List<Member>();
        List<Movie> foundMovies = new List<Movie>();
        //List<MemberTypes> foundMemberType = new List<MemberTypes>();
        //List<GenreMovie> foundGenresMovie = new List<GenreMovie>();
        //List<MovieMember> foundMovieMember = new List<MovieMember>();

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

        private NpgsqlConnection CreateDBConnection(string serverAddress, string username, string passwd, string dbName)
        {

            string conectionString = "Host=" + serverAddress + "; Username=" + username + "; Password=" + passwd + "; Database=" + dbName + ";";

            dbConnection = new NpgsqlConnection(conectionString);

            return dbConnection;
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
                memberListBox.Items.Add(currentMember.Name);
                memberNameComboBox.Items.Add(currentMember.Name);

            }

            dbConnection.Close();

            return foundMembers;
        }

        private List<Movie> GetMoviesFromDB()
        {

            Movie currentMovie;

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

                currentMovie.Genres = LoadMovieGenres(currentMovie.ID);
                currentMovie.Members = LoadMovieMembers(currentMovie.ID);

                if (dataReader.IsDBNull(5))
                {
                    currentMovie.Image = "";
                }
                else
                {
                    currentMovie.Image = dataReader.GetString(5);
                }

                foundMovies.Add(currentMovie);
                moviesListView.Items.Add(new ListViewItem(new[] { currentMovie.Title, currentMovie.Year.ToString(), currentMovie.Length }));
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

        /* private List<MemberTypes> GetMemberTypeFromDB()
         {
             MemberTypes currentMemberTypes;

             dbConnection.Open();

             string sqlQuery = "SELECT * FROM member_type;";

             NpgsqlCommand dbCommand = new NpgsqlCommand(sqlQuery, dbConnection);

             NpgsqlDataReader dataReader = dbCommand.ExecuteReader();

             while (dataReader.Read())
             {
                 currentMemberTypes = new MemberTypes();

                 currentMemberTypes.ID = dataReader.GetInt32(0);
                 currentMemberTypes.Name = dataReader.GetString(1);
                 currentMemberTypes.Description = dataReader.GetString(2);

                 foundMemberType.Add(currentMemberTypes);
             }
             dbConnection.Close();

             return foundMemberType;

         }

         private List<GenreMovie> GetGenreMovieFromDB()
         {
             GenreMovie currentGenreMovie;

             dbConnection.Open();

             string sqlQuery = "SELECT * FROM jt_genre_movie;";

             NpgsqlCommand dbCommand = new NpgsqlCommand(sqlQuery, dbConnection);

             NpgsqlDataReader dataReader = dbCommand.ExecuteReader();

             while (dataReader.Read())
             {
                 currentGenreMovie = new GenreMovie();

                 currentGenreMovie.Code = dataReader.GetString(0);
                 currentGenreMovie.ID = dataReader.GetInt32(1);


                 foundGenresMovie.Add(currentGenreMovie);
             }
             dbConnection.Close();

             return foundGenresMovie;

         }

         private List<MovieMember> GetMovieMemberFromDB()
         {
             MovieMember currentMovieMember;

             dbConnection.Open();

             string sqlQuery = "SELECT * FROM jt_movie_member;";

             NpgsqlCommand dbCommand = new NpgsqlCommand(sqlQuery, dbConnection);

             NpgsqlDataReader dataReader = dbCommand.ExecuteReader();

             while (dataReader.Read())
             {
                 currentMovieMember = new MovieMember();

                 currentMovieMember.MovieID = dataReader.GetInt32(0);
                 currentMovieMember.MemberID = dataReader.GetInt32(1);


                 foundMovieMember.Add(currentMovieMember);
             }
             dbConnection.Close();

             return foundMovieMember;

         }*/

        private List<Genre> LoadMovieGenres(int movieID)
        {

            //The following Connection, Command and DataReader objects will be used to access the jt_genre_movie table
            NpgsqlConnection dbConnection2 = CreateDBConnection(DbServerHost, DbUsername, DbUuserPassword, DbName);
            NpgsqlCommand dbCommand2;
            NpgsqlDataReader dataReader2;

            //The following Connection, Command and DataReader objects will be used to access the genre table
            NpgsqlConnection dbConnection3 = CreateDBConnection(DbServerHost, DbUsername, DbUuserPassword, DbName);
            NpgsqlCommand dbCommand3;
            NpgsqlDataReader dataReader3;

            string currentGenreCode;

            Genre currentGenre;

            List<Genre> GenreList = new List<Genre>();

            dbConnection2.Open();

            string sqlQuery = "SELECT genre_code FROM jt_genre_movie WHERE movie_id = " + movieID + ";";

            dbCommand2 = new NpgsqlCommand(sqlQuery, dbConnection2);

            dataReader2 = dbCommand2.ExecuteReader();

            //While there are genre_codes in the dataReader2
            while (dataReader2.Read())
            {
                currentGenre = new Genre();

                currentGenreCode = dataReader2.GetString(0);

                //Open a connection to access the 'genre' table
                dbConnection3.Open();

                sqlQuery = "SELECT * FROM genre WHERE code = '" + currentGenreCode + "';";

                dbCommand3 = new NpgsqlCommand(sqlQuery, dbConnection3);

                dataReader3 = dbCommand3.ExecuteReader();

                //Read a line from the 'genre' table
                dataReader3.Read();

                currentGenre.Code = dataReader3.GetString(0);
                currentGenre.Name = dataReader3.GetString(1);
                if (dataReader3.IsDBNull(2))
                {
                    currentGenre.Description = "";
                }
                else
                {
                    currentGenre.Description = dataReader3.GetString(2);
                }

                GenreList.Add(currentGenre);

                dbConnection3.Close();
            }

            dbConnection2.Close();

            return GenreList;
        }

        private List<Member> LoadMovieMembers(int movieID)
        {

            //The following Connection, Command and DataReader objects will be used to access the jt_genre_movie table
            NpgsqlConnection dbConnection4 = CreateDBConnection(DbServerHost, DbUsername, DbUuserPassword, DbName);
            NpgsqlCommand dbCommand4;
            NpgsqlDataReader dataReader4;

            //The following Connection, Command and DataReader objects will be used to access the genre table
            NpgsqlConnection dbConnection5 = CreateDBConnection(DbServerHost, DbUsername, DbUuserPassword, DbName);
            NpgsqlCommand dbCommand5;
            NpgsqlDataReader dataReader5;

            int currentMemberID;

            Member currentMember;

            List<Member> MemberList = new List<Member>();

            dbConnection4.Open();

            string sqlQuery = "SELECT member_id FROM jt_movie_member WHERE movie_id = " + movieID + ";";

            dbCommand4 = new NpgsqlCommand(sqlQuery, dbConnection4);

            dataReader4 = dbCommand4.ExecuteReader();

            //While there are genre_codes in the dataReader2
            while (dataReader4.Read())
            {
                currentMember = new Member();

                currentMemberID = dataReader4.GetInt32(0);

                //Open a connection to access the 'genre' table
                dbConnection5.Open();

                sqlQuery = "SELECT * FROM member WHERE id = '" + currentMemberID + "';";

                dbCommand5 = new NpgsqlCommand(sqlQuery, dbConnection5);

                dataReader5 = dbCommand5.ExecuteReader();

                //Read a line from the 'genre' table
                dataReader5.Read();

                currentMember.ID = dataReader5.GetInt32(0);
                currentMember.Name = dataReader5.GetString(1);
                currentMember.DOB = dataReader5.GetDateTime(2);
                currentMember.Type = dataReader5.GetInt32(3);

                MemberList.Add(currentMember);

                dbConnection5.Close();
            }

            dbConnection5.Close();

            return MemberList;
        }

        private void genreNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            moviesListView.Clear();
            moviesListView.View = View.Details;
            moviesListView.FullRowSelect = true;
            moviesListView.GridLines = true;
            moviesListView.Columns.Add("Title");
            moviesListView.Columns.Add("Year");
            moviesListView.Columns.Add("Length");

            foreach (Genre currentGenre in foundGenres)
            {
                if (genreNameComboBox.GetItemText(genreNameComboBox.SelectedItem) == currentGenre.Name)
                {
                    genreCodeTextBox.Text = currentGenre.Code;
                    genreDescriptionTextBox.Text = currentGenre.Description;
                }
            }

            foreach (Movie currentMovie in foundMovies)
            {

                foreach (Genre currentGenre in currentMovie.Genres)
                {
                    if (genreNameComboBox.GetItemText(genreNameComboBox.SelectedItem) == currentGenre.Name)
                    {
                        moviesListView.Items.Add(new ListViewItem(new[] { currentMovie.Title, currentMovie.Year.ToString(), currentMovie.Length }));
                    }
                }
            }
        }

        private void memberNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            moviesListView.Clear();
            moviesListView.View = View.Details;
            moviesListView.FullRowSelect = true;
            moviesListView.GridLines = true;
            moviesListView.Columns.Add("Title");
            moviesListView.Columns.Add("Year");
            moviesListView.Columns.Add("Length");

            foreach (Member currentMember in foundMembers)
            {
                if (memberNameComboBox.GetItemText(memberNameComboBox.SelectedItem) == currentMember.Name)
                {

                    memberTypeComboBox.Text = currentMember.Type.ToString();
                    memberIDTextBox.Text = currentMember.ID.ToString();
                    memberDOBTextBox.Text = currentMember.DOB.ToString();
                }
            }

            foreach (Movie currentMovie in foundMovies)
            {

                foreach (Member currentMember in currentMovie.Members)
                {
                    if (memberNameComboBox.GetItemText(memberNameComboBox.SelectedItem) == currentMember.Name)
                    {
                        moviesListView.Items.Add(new ListViewItem(new[] { currentMovie.Title, currentMovie.Year.ToString(), currentMovie.Length }));
                    }
                }
            }
        }

        private void moviesListView_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                if (moviesListView.SelectedIndices.Count <= 0)
                {
                    return;
                }

                int index = moviesListView.SelectedIndices[0];
                string Name = moviesListView.Items[index].Text;

                genreComboBox.Items.Clear();
                genreComboBox.Text = "";

                foreach (Genre genre in foundMovies[SearchMoviesByName(Name)].Genres)
                {
                    genreComboBox.Items.Add(genre.Name);
                }

                idTextBox.Text = foundMovies[SearchMoviesByName(Name)].ID.ToString();
                nameTextBox.Text = foundMovies[SearchMoviesByName(Name)].Title;
                yearTextBox.Text = foundMovies[SearchMoviesByName(Name)].Year.ToString();
                lengthTextBox.Text = foundMovies[SearchMoviesByName(Name)].Length;
                ratingTextBox.Text = foundMovies[SearchMoviesByName(Name)].Rating.ToString("N2");
                imageTextBox.Text = foundMovies[SearchMoviesByName(Name)].Image;


                  /*  ListBox.Items.Clear();

                    foreach (Animal animal in OwnerList[memberListBox.SelectedIndex].PetList)
                    {
                        petListBox.Items.Add(animal.Name);
                    }
                */
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private int SearchMoviesByName(string movieName)
        {
            int I = 0;
            foreach (Movie movies in foundMovies)
            {
                if (movieName != foundMovies[I].Title)
                {
                    I++;
                }
            }
            return I;
        }
    }
}


