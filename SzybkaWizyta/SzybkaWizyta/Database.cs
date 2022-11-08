using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Text;

namespace SzybkaWizyta
{
    internal class Database
    {
        public SQLiteConnection myconn;
        public Database()
        {
            myconn = new SQLiteConnection("Data Source=SzybkaWizyta.sqlite3");

            if (!File.Exists("./SzybkaWizyta.sqlite3"))
            {
                SQLiteConnection.CreateFile("SzybkaWizyta.sqlite3");
            }

        }
        public void OpenConnection()
        {
            if (myconn.State != System.Data.ConnectionState.Open)
            {
                myconn.Open();
            }
        }
        public void CloseConnection()
        {
            if (myconn.State != System.Data.ConnectionState.Closed)
            {
                myconn.Clone();
            }
        }
    }
}
