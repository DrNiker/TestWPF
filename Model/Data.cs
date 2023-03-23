using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace TestWPF.Model
{

    public class Data
    {
        public int id { get; set; }
        public string applicationName { get; set; }
        public string userName { get; set; }
        public string comment { get; set; }

        public Data(int _id, string _applicationName, string _userName, string _comment)
        {
            id = _id;
            applicationName = _applicationName;
            userName = _userName;
            comment = _comment;
        }
    }
    static class DataSet
    {
        static SQLiteConnection conn;

        static public List<Data> ReadData()
        {
            List<Data> data = new List<Data>();
            conn = new SQLiteConnection("Data Source= data.db; Version = 3; New = True; Compress = True; ");
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
            SQLiteDataReader datareader;
            SQLiteCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM DataTable";

            datareader = cmd.ExecuteReader();
            while (datareader.Read())
            {
                data.Add(new Data(datareader.GetInt32(0), datareader.GetString(1), datareader.GetString(2), datareader.GetString(3)));
            }
            conn.Close();
            return data ;
        }
        static public string Insert(string _applicationName, string _userName, string _comment)
        {
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return "Error";
            }
            SQLiteCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = $"INSERT INTO DataTable (applicationName, userName, coment) VALUES({_applicationName}, {_userName}, {_comment}); ";
            cmd.ExecuteNonQuery();
            return "Done";
        }
        static public string Update(int _id, string _applicationName, string _userName, string _comment)
        {
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return "Error";
            }
            SQLiteCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = $"UPDATE DataTable SET applicationName = {_applicationName}, userName = {_userName}, coment = {_comment} WHERE id = {_id}; ";
            cmd.ExecuteNonQuery();
            return "Done";
        }
        static public string Delete(int _id)
        {
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return "Error";
            }
            SQLiteCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = $"DELETE FROM DataTable WHERE id = {_id}; ";
            cmd.ExecuteNonQuery();
            return "Done";
        }
    }
}
