using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace HostelManagementSystem
{
    class databaseConnection
    {
        string constring = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\data.accdb";
        OleDbConnection connection;
        OleDbCommand command;
        OleDbDataAdapter adapter;
        DataSet ds;
        public DataSet sqlreader(string sqlstring)
        {
            connection = new OleDbConnection(constring);
            command = new OleDbCommand(sqlstring, connection);
            adapter = new OleDbDataAdapter();
            connection.Open();
            ds = new DataSet();
            adapter.SelectCommand = command;
            adapter.Fill(ds);
            return ds;
        }
        public void sqlwritter(string sqlstring)
        {
            connection = new OleDbConnection(constring);
            command = new OleDbCommand(sqlstring, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}