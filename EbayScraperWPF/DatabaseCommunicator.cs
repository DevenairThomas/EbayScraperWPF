using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace EbayScraperWPF
{
    //@"Server=localhost;Port=5432;User Id=postgres;Password=123;Database=RecipeProj;");
    public class DatabaseCommunicator
    {
        private string _PortNumber;
        private string _ServerName;
        private string _UserName;
        private string _Password;

        private string _ConnectionString;

        public enum DatabaseStates
        {
            None,
            DATABASE_CHECK_SUCCESS,
            DATABASE_CHECK_FAIL,
            DATABASE_CREATE_SUCCESS,
            DATABASE_CREATE_FAIL,
            DATABASE_TABLE_CREATE_SUCCESS,
            DATABASE_TABLE_CREATE_FAIL,
            DATABASE_TABLE_UPDATE_SUCCESS,
            DATABASE_TABLE_UPDATE_FAIL,
            DATABASE_TABLE_DELETE_SUCCESS,
            DATABASE_TABLE_DELETE_FAIL,
            DATABASE_TABLE_READ_SUCCESS,
            DATABASE_TABLE_READ_FAIL,
            DATABASE_TABLE_WRITE_SUCCESS,
            DATABASE_TABLE_WRITE_FAIL
        }

        public enum DatabaseActions
        {
            None,
            CREATE_DATABASE,
            CREATE_TABLE,
            UPDATE_TABLE,
            DELETE_TABLE,
            READ_TABLE,
            WRITE_TABLE
        }
        public DatabaseActions DATABASE_ACTION { get; set; }
        public DatabaseStates DATABASE_STATE { get; set; }

        public string DatabaseName { get; set; }
        public string DatabaseConnectionString { get; set; }
        public string DatabaseTableName { get; set; }


        public DatabaseCommunicator() { }

        //TODO
        //Connect to database, if database doesnt exist, create it
        //Create Tables in database if they dont exist,up to 3 tables
        //Read from database
        //Write to database
        //Update database
        //Delete from database

        public async void CheckDatabaseConnection()
        {
            var connectionString = "Host=myserver;Username=mylogin;Password=mypass;Database=mydatabase";
            try 
            { 
                await using var dataSource = NpgsqlDataSource.Create(connectionString);
                DATABASE_STATE = DatabaseStates.DATABASE_CHECK_SUCCESS;
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
                DATABASE_STATE = DatabaseStates.DATABASE_CHECK_FAIL;
            }
        }


        public string PortNumber
        {
            get { return _PortNumber; }
            set { _PortNumber = value; }
        }
        public string ServerName
        {
            get { return _ServerName; }
            set { _ServerName = value; }
        }
        public string UserName
        {
            get { return _UserName; }
            set { _UserName = value; }
        }
        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }
        public string ConnectionString
        {
            get { return _ConnectionString; }
            set { _ConnectionString = value; }
        }
    }
}
