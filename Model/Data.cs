using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Windows;

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

            SQLiteDataReader datareader;
            SQLiteCommand cmd;

            try
            {
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM DataTable";
                datareader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex);
                Console.WriteLine(ex);
                conn.Close();
                return null;
            }

            while (datareader.Read())
            {
                data.Add(new Data(datareader.GetInt32(0), datareader.GetString(1), datareader.GetString(2), datareader.GetString(3)));
            }
            conn.Close();
            return data;
        }
        static public string Insert(string _applicationName, string _userName, string _comment)
        {
            SQLiteCommand cmd;
            try
            {
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = $"INSERT INTO DataTable (applicationName, userName, coment) VALUES(@text1, @text2, @text3); ";
                cmd.Prepare();
                cmd.Parameters.Add("@text1", DbType.AnsiString).Value = _applicationName;
                cmd.Parameters.Add("@text2", DbType.AnsiString).Value = _userName;
                cmd.Parameters.Add("@text3", DbType.AnsiString).Value = _comment;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex);
                Console.WriteLine(ex);
                conn.Close();
                return "Error";
            }
            conn.Close();
            return "Done";
        }
        static public string Update(int _id, string _applicationName, string _userName, string _comment)
        {
            SQLiteCommand cmd;
            try
            {
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = $"UPDATE DataTable SET applicationName = @text1, userName = @text2, coment = @text3 WHERE id = {_id}; ";
                cmd.Prepare();
                cmd.Parameters.Add("@text1", DbType.AnsiString).Value = _applicationName;
                cmd.Parameters.Add("@text2", DbType.AnsiString).Value = _userName;
                cmd.Parameters.Add("@text3", DbType.AnsiString).Value = _comment;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex);
                Console.WriteLine(ex);
                conn.Close();
                return "Error";
            }
            conn.Close();
            return "Done";
        }
        static public string Delete(int _id)
        {
            SQLiteCommand cmd;
            try
            {
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = $"DELETE FROM DataTable WHERE id = {_id}; ";
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                conn.Close();
                return "Error";
            }
            conn.Close();
            return "Done";
        }
    }
}
