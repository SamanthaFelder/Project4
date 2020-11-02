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
        }

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
        private Member GetMembersFromDB(int MembersId)
        {
            Member member = new Member();

            dbConnection.Open();

            string sqlQuery = "SELECT * FROM Members WHERE Member.ID = " + MembersId + ";";

            NpgsqlCommand dbCommand = new NpgsqlCommand(sqlQuery, dbConnection);

            NpgsqlDataReader dataReader = dbCommand.ExecuteReader();

            dataReader.Read();
            
            member.Name = dataReader.GetString(0);
            member.Type = dataReader.GetInt32(1);
            member.ID = dataReader.GetInt32(2);
            member.DOB = dataReader.GetDateTime(3);

            dbConnection.Close();

            return member;
        }
    }
}
//hello

