using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
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
            GetMemberTypeFromDB();
           
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
        List<MemberTypes> foundMemberType = new List<MemberTypes>();
        
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

        /// <summary>
        /// This method displays the version of the Postgres server to which the program connects to.
        /// </summary>
        private void CheckPostgresVersion()
        {
            dbConnection.Open();

            string sqlQuery = "SELECT version()";

            NpgsqlCommand dbCommand = new NpgsqlCommand(sqlQuery, dbConnection);

            string postgresVersion = dbCommand.ExecuteScalar().ToString();

            dbConnection.Close();
        }

        /// <summary>
        /// This method gets all the member information from the database and stores it in a list.
        /// </summary>
        /// <param name="MembersId">The employee ID</param>
        /// <returns></returns>
        private List<Member> GetMembersFromDB()
        {
            Member currentMember;

            // Open the connection.
            dbConnection.Open();

            // This is a string representing the SQL query to execute in the db.
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

                currentMember.MemberType = LoadMemberType(currentMember.Type);

                foundMembers.Add(currentMember);
                memberListBox.Items.Add(currentMember.Name);
                memberNameComboBox.Items.Add(currentMember.Name);
            }
            dbConnection.Close();

            return foundMembers;
        }

        /// <summary>
        /// This method gets all the movie information from the database and stores it in a list.
        /// </summary>
        /// <returns></returns>
        private List<Movie> GetMoviesFromDB()
        {
            Movie currentMovie;

            dbConnection.Open();

            // This is a string representing the SQL query to execute in the db.
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

        /// <summary>
        /// This method gets all the genre information from the database and stores it in a list.
        /// </summary>
        /// <returns></returns>
        private List<Genre> GetGenresFromDB()
        {
            Genre currentGenre;

            dbConnection.Open();

            // This is a string representing the SQL query to execute in the db.
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

        /// <summary>
        /// This method gets all the member type information from the database and stores it in a list.
        /// </summary>
        /// <returns></returns>
        private List<MemberTypes> GetMemberTypeFromDB()
        {
             MemberTypes currentMemberTypes;

             dbConnection.Open();

            // This is a string representing the SQL query to execute in the db.
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


        /// <summary>
        /// This method gets all the movie's genre information from the database and stores it in a list.
        /// </summary>
        /// <param name="movieID"></param>
        /// <returns></returns>
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

            // This is a string representing the SQL query to execute in the db.
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

                // This is a string representing the SQL query to execute in the db.
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

        /// <summary>
        /// This method gets all the movie's member information from the database and stores it in a list.
        /// </summary>
        /// <param name="movieID"></param>
        /// <returns></returns>
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

            // This is a string representing the SQL query to execute in the db.
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

                // This is a string representing the SQL query to execute in the db.
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

        /// <summary>
        /// This method gets all the movie's member type information from the database and stores it in a list.
        /// </summary>
        /// <param name="memberType"></param>
        /// <returns></returns>
        private List<MemberTypes> LoadMemberType(int memberType)
        {
            //The following Connection, Command and DataReader objects will be used to access the jt_genre_movie table
            NpgsqlConnection dbConnection6 = CreateDBConnection(DbServerHost, DbUsername, DbUuserPassword, DbName);
            NpgsqlCommand dbCommand6;
            NpgsqlDataReader dataReader6;

            MemberTypes currentMemberType;

            List<MemberTypes> MemberTypeList = new List<MemberTypes>();

            dbConnection6.Open();

            // This is a string representing the SQL query to execute in the db.
            string sqlQuery = "SELECT * FROM member_type WHERE id = " + memberType + ";";

            dbCommand6 = new NpgsqlCommand(sqlQuery, dbConnection6);

            dataReader6 = dbCommand6.ExecuteReader();

            //While there are genre_codes in the dataReader2
            while (dataReader6.Read())
            {
                currentMemberType = new MemberTypes();

                currentMemberType.ID = dataReader6.GetInt32(0);
                currentMemberType.Name = dataReader6.GetString(1);
                currentMemberType.Description = dataReader6.GetString(2);

                MemberTypeList.Add(currentMemberType);
            }
            dbConnection6.Close();

            return MemberTypeList;
        } 
        
        /// <summary>
        /// This method adds a genre to the database.
        /// </summary>
        /// <param name="genre"></param>
        /// <returns></returns>
        private int InsertGenreInDB(Genre genre)
        {
            try 
            { 
                NpgsqlConnection dbConnection7 = CreateDBConnection(DbServerHost, DbUsername, DbUuserPassword, DbName);
                NpgsqlCommand dbCommand7;

                //This variable will store the number of affecter rows by the INSERT query
                int queryResult;

                //Before sending commands to the database, the connection must be opened
                dbConnection7.Open();

                //This is a string representing the SQL query to execute in the db
                string sqlQuery = "INSERT INTO genre VALUES('" + genre.Code.ToUpper() + "', '" + genre.Name + "', '" + genre.Description + "');";

                //This is the actual SQL containing the query to be executed
                dbCommand7 = new NpgsqlCommand(sqlQuery, dbConnection7);

                queryResult = dbCommand7.ExecuteNonQuery();
           
                //After executing the query(ies) in the db, the connection must be closed
                dbConnection7.Close();

                return queryResult;
            }
            catch
            {
                MessageBox.Show("please enter a different genre");
                
                NpgsqlConnection dbConnection7 = CreateDBConnection(DbServerHost, DbUsername, DbUuserPassword, DbName);
                
                dbConnection7.Close();
                
                return  0;
            }
        }
        
        /// <summary>
        /// This method modifies the genre in the database.
        /// </summary>
        /// <param name="genre"></param>
        /// <returns></returns>
        private int ModifyGenreInDB(Genre genre)
        {
            NpgsqlConnection dbConnection10 = CreateDBConnection(DbServerHost, DbUsername, DbUuserPassword, DbName);

            //This variable will store the number of affecter rows by the INSERT query
            int queryResult;

            //Before sending commands to the database, the connection must be opened
            dbConnection10.Open();

            //This is a string representing the SQL query to execute in the db           
            string sqlQuery = "UPDATE genre SET name = '" + genre.Name + "', description = '" + genre.Description + "' WHERE code = '" + genre.Code.ToUpper() + "';";
       
            //This is the actual SQL containing the query to be executed
            NpgsqlCommand dbCommand10 = new NpgsqlCommand(sqlQuery, dbConnection10);

            queryResult = dbCommand10.ExecuteNonQuery();

            //After executing the query(ies) in the db, the connection must be closed
            dbConnection10.Close();

            return queryResult;
        }
       
        /// <summary>
        /// This method deletes the genre from the database.
        /// </summary>
        /// <param name="genre"></param>
        /// <returns></returns>
        private int DeleteGenreInDB(Genre genre)
        {
            try
            {
                NpgsqlConnection dbConnection13 = CreateDBConnection(DbServerHost, DbUsername, DbUuserPassword, DbName);
                NpgsqlCommand dbCommand13;

                //This variable will store the number of affecter rows by the INSERT query
                int queryResult;

                //Before sending commands to the database, the connection must be opened
                dbConnection13.Open();

                //This is a string representing the SQL query to execute in the db
                string sqlQuery = "DELETE FROM genre WHERE code = '" + genre.Code + "';";

                //This is the actual SQL containing the query to be executed
                dbCommand13 = new NpgsqlCommand(sqlQuery, dbConnection13);

                queryResult = dbCommand13.ExecuteNonQuery();

                //After executing the query(ies) in the db, the connection must be closed
                dbConnection13.Close();

                return queryResult;
            }
            catch
            {
                MessageBox.Show("please delete a different genre");

                NpgsqlConnection dbConnection13 = CreateDBConnection(DbServerHost, DbUsername, DbUuserPassword, DbName);

                dbConnection13.Close();

                return 0;
            }
        }
        
        /// <summary>
        /// This method adds a member to the database.
        /// </summary>
        /// <param name="member"></param>
        /// <returns></returns>
        private int InsertMemberInDB(Member member)
        {
            try
            {     
                NpgsqlConnection dbConnection8 = CreateDBConnection(DbServerHost, DbUsername, DbUuserPassword, DbName);
                NpgsqlCommand dbCommand8;

                //This variable will store the number of affecter rows by the INSERT query
                int queryResult;

                //Before sending commands to the database, the connection must be opened
                dbConnection8.Open();

                //This is a string representing the SQL query to execute in the db
                string sqlQuery = "INSERT INTO member VALUES('" + member.ID + "', '" + member.Name + "', '" + member.DOB + "' , '" + member.Type + "');";

                //This is the actual SQL containing the query to be executed
                dbCommand8 = new NpgsqlCommand(sqlQuery, dbConnection8);

                queryResult = dbCommand8.ExecuteNonQuery();

                //After executing the query(ies) in the db, the connection must be closed
                dbConnection8.Close();

                return queryResult;

            }
            catch
            {
                MessageBox.Show("please enter a different member");

                NpgsqlConnection dbConnection8 = CreateDBConnection(DbServerHost, DbUsername, DbUuserPassword, DbName);

                dbConnection8.Close();

                return 0;
            }
           
        }
        
        /// <summary>
        /// This method modifies the member in the database.
        /// </summary>
        /// <param name="member"></param>
        /// <returns></returns>
        private int ModifyMemberInDB(Member member)
        {
            NpgsqlConnection dbConnection11 = CreateDBConnection(DbServerHost, DbUsername, DbUuserPassword, DbName);

            //This variable will store the number of affecter rows by the INSERT query
            int queryResult;

            //Before sending commands to the database, the connection must be opened
            dbConnection11.Open();

            //This is a string representing the SQL query to execute in the db           
            string sqlQuery = "UPDATE member SET name = '" + member.Name + "', date_of_birth = '" + member.DOB + "', member_type_id = '" + member.Type + "' WHERE id = " + member.ID + ";";
            
            //This is the actual SQL containing the query to be executed
            NpgsqlCommand dbCommand11 = new NpgsqlCommand(sqlQuery, dbConnection11);

            queryResult = dbCommand11.ExecuteNonQuery();

            //After executing the query(ies) in the db, the connection must be closed
            dbConnection11.Close();

            return queryResult;
        }

        /// <summary>
        /// This method deletes the member from the database.
        /// </summary>
        /// <param name="member"></param>
        /// <returns></returns>
        private int DeleteMemberInDB(Member member)
        {
            try
            {
                NpgsqlConnection dbConnection14 = CreateDBConnection(DbServerHost, DbUsername, DbUuserPassword, DbName);
                NpgsqlCommand dbCommand14;

                //This variable will store the number of affecter rows by the INSERT query
                int queryResult;

                //Before sending commands to the database, the connection must be opened
                dbConnection14.Open();

                //This is a string representing the SQL query to execute in the db
                string sqlQuery = "DELETE FROM member WHERE id = '" + member.ID + "';";

                //This is the actual SQL containing the query to be executed
                dbCommand14 = new NpgsqlCommand(sqlQuery, dbConnection14);

                queryResult = dbCommand14.ExecuteNonQuery();

                //After executing the query(ies) in the db, the connection must be closed
                dbConnection14.Close();

                return queryResult;

            }
            catch
            {
                MessageBox.Show("please delete a different member");

                NpgsqlConnection dbConnection14 = CreateDBConnection(DbServerHost, DbUsername, DbUuserPassword, DbName);

                dbConnection14.Close();

                return 0;
            }

        }

        /// <summary>
        /// This method adds a movie to the database.
        /// </summary>
        /// <param name="movie"></param>
        /// <returns></returns>
        private int InsertMovieInDB(Movie movie)
        {
            try
            {    
                NpgsqlConnection dbConnection9 = CreateDBConnection(DbServerHost, DbUsername, DbUuserPassword, DbName);
                NpgsqlCommand dbCommand9;

                //This variable will store the number of affecter rows by the INSERT query
                int queryResult;
            
                //Before sending commands to the database, the connection must be opened
                dbConnection9.Open();

                //This is a string representing the SQL query to execute in the db
                string sqlQuery = "INSERT INTO movie VALUES('" + movie.ID + "', '" + movie.Title + "', '"
                    + movie.Year + "', '" + movie.Length + "', '" + movie.Rating + "', '" + movie.Image + "');";

                //This is the actual SQL containing the query to be executed
                dbCommand9 = new NpgsqlCommand(sqlQuery, dbConnection9);

                queryResult = dbCommand9.ExecuteNonQuery();

                //After executing the query(ies) in the db, the connection must be closed
                dbConnection9.Close();

                return queryResult;

            }
            catch
            {
                MessageBox.Show("please enter a different movie");

                NpgsqlConnection dbConnection9 = CreateDBConnection(DbServerHost, DbUsername, DbUuserPassword, DbName);

                dbConnection9.Close();

                return 0;
            }
        }

        /// <summary>
        /// This method modifies the movie in the database.
        /// </summary>
        /// <param name="movie"></param>
        /// <returns></returns>
        private int ModifyMovieInDB(Movie movie)
        {
            try
            {
                NpgsqlConnection dbConnection12 = CreateDBConnection(DbServerHost, DbUsername, DbUuserPassword, DbName);

                //This variable will store the number of affecter rows by the INSERT query
                int queryResult;

                //Before sending commands to the database, the connection must be opened
                dbConnection12.Open();

                //This is a string representing the SQL query to execute in the db           
                string sqlQuery = "UPDATE movie SET image_file_path = '" + movie.Image + "', title = '" + movie.Title + "', year = '"
                        + movie.Year + "', length = '" + movie.Length + "', audience_rating = '" + movie.Rating + "' WHERE id = " + movie.ID + ";";

                //This is the actual SQL containing the query to be executed
                NpgsqlCommand dbCommand12 = new NpgsqlCommand(sqlQuery, dbConnection12);

                queryResult = dbCommand12.ExecuteNonQuery();

                //After executing the query(ies) in the db, the connection must be closed
                dbConnection12.Close();

                return queryResult;
            }
           catch
            {
                MessageBox.Show("please Modify a different movie");

                NpgsqlConnection dbConnection12 = CreateDBConnection(DbServerHost, DbUsername, DbUuserPassword, DbName);

                dbConnection12.Close();

                return 0;
            }
        }

        /// <summary>
        /// This method deletes the movie from the database.
        /// </summary>
        /// <param name="movie"></param>
        /// <returns></returns>
        private int DeleteMovieInDB(Movie movie)
        {
            try
            {
                NpgsqlConnection dbConnection15 = CreateDBConnection(DbServerHost, DbUsername, DbUuserPassword, DbName);
                NpgsqlCommand dbCommand15;

                //This variable will store the number of affecter rows by the INSERT query
                int queryResult;

                //Before sending commands to the database, the connection must be opened
                dbConnection15.Open();

                //This is a string representing the SQL query to execute in the db
                string sqlQuery = "DELETE FROM movie WHERE id = '" + movie.ID + "';";
              
                //This is the actual SQL containing the query to be executed
                dbCommand15 = new NpgsqlCommand(sqlQuery, dbConnection15);

                queryResult = dbCommand15.ExecuteNonQuery();

                //After executing the query(ies) in the db, the connection must be closed
                dbConnection15.Close();

                return queryResult;

            }
            catch
            {
                MessageBox.Show("please delete a different movie");

                NpgsqlConnection dbConnection15 = CreateDBConnection(DbServerHost, DbUsername, DbUuserPassword, DbName);

                dbConnection15.Close();

                return 0;
            }
        }

        /// <summary>
        /// This method changes the Date Of Birth textbox depending on the text.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void memberDOBTextBox_Enter(object sender, EventArgs e)
        {
            if(memberDOBTextBox.Text== "YYYY-MM-DD")
            {
                memberDOBTextBox.Text = "";
                memberDOBTextBox.ForeColor = Color.Black;
            }
        }

        /// <summary>
        /// This method changes the Date Of Birth textbox depending on the text.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void memberDOBTextBox_Leave(object sender, EventArgs e)
        {
            if (memberDOBTextBox.Text == "")
            {
                memberDOBTextBox.Text = "YYYY-MM-DD";
                memberDOBTextBox.ForeColor = Color.Silver;
            }
        }

        /// <summary>
        /// This method searches for a movie based on its name.
        /// </summary>
        /// <param name="movieName"></param>
        /// <returns></returns>
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

        /// <summary>
        /// This method searches for a member based on its name.
        /// </summary>
        /// <param name="memberName"></param>
        /// <returns></returns>
        private int SearchMembersByName(string memberName)
        {
            int I = 0;
            foreach (Member member in foundMembers)
            {
                if (memberName != foundMembers[I].Name)
                {
                    I++;
                }
            }
            return I;
        }
        
        /// <summary>
        /// This method clears everything.
        /// </summary>
        private void ClearMethod()
        {
            movieMemberListBox.Items.Clear();
            moviesListView.Clear();
            memberNameComboBox.Text = "";
            memberIDTextBox.Text = "";
            memberDOBTextBox.Text = "";
            memberFieldTextBox.Text = "";
            memberDescriptionRichTextBox.Text = "";
            idTextBox.Text = "";
            nameTextBox.Text = "";
            yearTextBox.Text = "";
            lengthTextBox.Text = "";
            ratingTextBox.Text = "";
            imageTextBox.Text = "";
            genreComboBox.Items.Clear();
            genreNameComboBox.Text = "";
            genreCodeTextBox.Text = "";
            genreDescriptionTextBox.Text = "";
            moviesListView.View = View.Details;
            moviesListView.FullRowSelect = true;
            moviesListView.GridLines = true;
            moviesListView.Columns.Add("Title");
            moviesListView.Columns.Add("Year");
            moviesListView.Columns.Add("Length");

            foreach (Movie currentMovie in foundMovies)
            {
                moviesListView.Items.Add(new ListViewItem(new[] { currentMovie.Title, currentMovie.Year.ToString(), currentMovie.Length }));

            }
        }

        /// <summary>
        /// This method displays the genre's information and it's movies based on the genre selected.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// This method displays the member's information, member type and the movies the member participated in, based on the member selected.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                    foreach (Member currentMember2 in foundMembers)
                    {
                        foreach (MemberTypes currentMemberType in currentMember2.MemberType)
                        {
                            if (memberNameComboBox.GetItemText(memberNameComboBox.SelectedItem) == currentMember2.Name)
                            {
                                memberFieldTextBox.Text = currentMemberType.Name;
                                memberDescriptionRichTextBox.Text = currentMemberType.Description;
                            }
                        }
                    }
                   
                    if (memberNameComboBox.GetItemText(memberNameComboBox.SelectedItem) == currentMember.Name)
                    {
                        moviesListView.Items.Add(new ListViewItem(new[] { currentMovie.Title, currentMovie.Year.ToString(), currentMovie.Length }));
                    }
                }
            }
        }

        /// <summary>
        /// This method displays the movie's information and it's participating members, based on the movie selected.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                if (foundMovies[SearchMoviesByName(Name)].Image != "")
                {
                    moviesPictureBox.ImageLocation = foundMovies[SearchMoviesByName(Name)].Image;
                }
                else
                {
                    moviesPictureBox.ImageLocation = "";
                }

                movieMemberListBox.Items.Clear();
                
                foreach (Member member in foundMovies[SearchMoviesByName(Name)].Members)
                {
                    movieMemberListBox.Items.Add(member.Name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        /// <summary>
        /// This method displays the member's information based on the member selected.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void movieMemberListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (movieMemberListBox.SelectedIndices.Count <= 0)
            {
                return;
            }

            int index = movieMemberListBox.SelectedIndices[0];
            string Name = movieMemberListBox.Items[index].ToString();

            memberNameComboBox.Text = foundMembers[SearchMembersByName(Name)].Name;
            memberTypeComboBox.Text = foundMembers[SearchMembersByName(Name)].Type.ToString();
            memberIDTextBox.Text = foundMembers[SearchMembersByName(Name)].ID.ToString();
            memberDOBTextBox.Text = foundMembers[SearchMembersByName(Name)].DOB.ToString();
            memberFieldTextBox.Text = foundMemberType[foundMembers[SearchMembersByName(Name)].Type - 1].Name.ToString();
            memberDescriptionRichTextBox.Text = foundMemberType[foundMembers[SearchMembersByName(Name)].Type - 1].Description.ToString();
        }

        /// <summary>
        /// This method allows the User to add a genre.
        /// It adds it to the database and the ComboBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addGenreButton_Click(object sender, EventArgs e)
        {
            Genre NewGenre = new Genre();

            NewGenre.Code = genreCodeTextBox.Text;
            NewGenre.Name = genreNameComboBox.Text;
            NewGenre.Description = genreDescriptionTextBox.Text;
            
            
            InsertGenreInDB(NewGenre);
            genreNameComboBox.Items.Clear();
            GetGenresFromDB();
            ClearMethod();
        }
        
        /// <summary>
        /// This method allows the User to modify 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void modifyGenreButton_Click(object sender, EventArgs e)
        {
            Genre modifyGenre = new Genre();

            modifyGenre.Code = genreCodeTextBox.Text;
            modifyGenre.Name = genreNameComboBox.Text;
            modifyGenre.Description = genreDescriptionTextBox.Text;
            
            
            ModifyGenreInDB(modifyGenre);
            genreNameComboBox.Items.Clear();
            GetGenresFromDB();
            ClearMethod();

        }

        private void deleteGenreButton_Click(object sender, EventArgs e)
        {
            Genre DeleteGenre = new Genre();

            DeleteGenre.Code = genreCodeTextBox.Text;
            DeleteGenre.Name = genreNameComboBox.Text;
            DeleteGenre.Description = genreDescriptionTextBox.Text;
            
           
            DeleteGenreInDB(DeleteGenre);
            genreNameComboBox.Items.Clear();
            GetGenresFromDB();
            ClearMethod();
        }
        
        private void addMemberButton_Click(object sender, EventArgs e)
        {
            Member NewMember = new Member();

            NewMember.ID = int.Parse(memberIDTextBox.Text);
            NewMember.Name = memberNameComboBox.Text;
            NewMember.DOB = DateTime.Parse(memberDOBTextBox.Text);
            NewMember.Type = int.Parse(memberTypeComboBox.Text);
 
            foundMembers.Clear();
            InsertMemberInDB(NewMember);
            memberListBox.Items.Clear();
            memberNameComboBox.Items.Clear();
            GetMembersFromDB();
            ClearMethod();
        } 
        
        private void modifyMemberButton_Click(object sender, EventArgs e)
        {
            Member ModifyMember = new Member();

            ModifyMember.ID = int.Parse(memberIDTextBox.Text);
            ModifyMember.Name = memberNameComboBox.Text;
            ModifyMember.DOB = DateTime.Parse(memberDOBTextBox.Text);
            ModifyMember.Type = int.Parse(memberTypeComboBox.Text);

            foundMembers.Clear();
            ModifyMemberInDB(ModifyMember);
            memberListBox.Items.Clear();
            memberNameComboBox.Items.Clear();
            GetMembersFromDB();
            ClearMethod();

        }
        
        private void deleteMemberButton_Click(object sender, EventArgs e)
        {
            Member DeleteMember = new Member();

            DeleteMember.ID = int.Parse(memberIDTextBox.Text);
            DeleteMember.Name = memberNameComboBox.Text;
            DeleteMember.DOB = DateTime.Parse(memberDOBTextBox.Text);
            DeleteMember.Type = int.Parse(memberTypeComboBox.Text);
            
            foundMembers.Clear();
            DeleteMemberInDB(DeleteMember);
            memberListBox.Items.Clear();
            memberNameComboBox.Items.Clear();
            GetMembersFromDB();
            ClearMethod();
        }

        private void addMovieButton_Click(object sender, EventArgs e)
        {
            Movie NewMovie = new Movie();

            NewMovie.ID = int.Parse(idTextBox.Text);
            NewMovie.Title = nameTextBox.Text;
            NewMovie.Year = int.Parse(yearTextBox.Text);
            NewMovie.Length = lengthTextBox.Text;
            NewMovie.Rating = double.Parse(ratingTextBox.Text);
            NewMovie.Image = imageTextBox.Text;
            
            foundMovies.Clear();
            InsertMovieInDB(NewMovie);
            moviesListView.Clear();
            moviesListView.View = View.Details;
            moviesListView.FullRowSelect = true;
            moviesListView.GridLines = true;
            moviesListView.Columns.Add("Title");
            moviesListView.Columns.Add("Year");
            moviesListView.Columns.Add("Length");
            GetMoviesFromDB();
            ClearMethod();
        }

        private void modifyMovieButton_Click(object sender, EventArgs e)
        {
            Movie ModifyMovie = new Movie();

            ModifyMovie.ID = int.Parse(idTextBox.Text);
            ModifyMovie.Title = nameTextBox.Text;
            ModifyMovie.Year = int.Parse(yearTextBox.Text);
            ModifyMovie.Length = lengthTextBox.Text;
            ModifyMovie.Rating = double.Parse(ratingTextBox.Text);
            ModifyMovie.Image = imageTextBox.Text;
            
            foundMovies.Clear();
            ModifyMovieInDB(ModifyMovie);
            moviesListView.Clear();
            moviesListView.View = View.Details;
            moviesListView.FullRowSelect = true;
            moviesListView.GridLines = true;
            moviesListView.Columns.Add("Title");
            moviesListView.Columns.Add("Year");
            moviesListView.Columns.Add("Length");
            GetMoviesFromDB();
            ClearMethod();

        }

        private void deleteMovieButton_Click(object sender, EventArgs e)
        {
            Movie DeleteMovie = new Movie();

            DeleteMovie.ID = int.Parse(idTextBox.Text);
            DeleteMovie.Title = nameTextBox.Text;
            DeleteMovie.Year = int.Parse(yearTextBox.Text);
            DeleteMovie.Length = lengthTextBox.Text;
            DeleteMovie.Rating = double.Parse(ratingTextBox.Text);
            DeleteMovie.Image = imageTextBox.Text;
 
            foundMovies.Clear();
            DeleteMovieInDB(DeleteMovie);
            moviesListView.Clear();
            moviesListView.View = View.Details;
            moviesListView.FullRowSelect = true;
            moviesListView.GridLines = true;
            moviesListView.Columns.Add("Title");
            moviesListView.Columns.Add("Year");
            moviesListView.Columns.Add("Length");
            GetMoviesFromDB();
            ClearMethod();
        }

       private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearMethod();
        }

        private void removeMemberButton_Click(object sender, EventArgs e)
        {
            Member DeleteMember = new Member();

            DeleteMember.ID = int.Parse(memberIDTextBox.Text);
            DeleteMember.Name = memberNameComboBox.Text;
            DeleteMember.Type = int.Parse(memberTypeComboBox.Text);
            DeleteMember.DOB = DateTime.Parse(memberDOBTextBox.Text);
           

            foundMembers.Clear();
            DeleteMemberInDB(DeleteMember);
            memberListBox.Items.Clear();
            GetMembersFromDB();
            ClearMethod();
        }

        private void addMemberToMovieButton_Click(object sender, EventArgs e)
        {

        }

        private void memberListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /* 
         WHATS LEFT
        1)to add member to move and to remove them 
        2)delete joining table rows button
        3)to add movie to genre
        4)comments
         */

    }
}


