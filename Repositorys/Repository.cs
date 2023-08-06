using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Web;

namespace LoginWithMSSQL.Repositorys
{
    public class Repository
    {
        public Repository()
        {
            
        }

        static string resourcesPath= System.AppDomain.CurrentDomain.BaseDirectory + "\\..\\..\\Resources\\Users.db";

        SQLiteConnection conn = new SQLiteConnection($"Data Source={resourcesPath};Version=3;");

        bool isThere;
        public bool GetUser(string _username, string _pass)
        {
            conn.Open();

            var command = new SQLiteCommand("SELECT * FROM user", conn);

            SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                if (_username == Decryption((string)reader["username"]) && _pass == Decryption((string)reader["pass"]))
                {
                    isThere = true;
                    break;
                }
                else
                    isThere = false;
            }

            conn.Close();

           return isThere;
        }

        public byte AddUser(string _user, string _pass, string _email, string _phone)
        {
            conn.Open();

            var cmd = new SQLiteCommand($"INSERT INTO user VALUES('{Encryption(_user)}','{Encryption(_pass)}','{Encryption(_email)}',{Encryption(_phone)})",conn);

            byte affectedRows = (byte)cmd.ExecuteNonQuery();

            conn.Close();

            return affectedRows;
        }

        private string Encryption(string text, int key = 2)
        {
            string reversed = "";

            foreach (var item in text.ToCharArray())
                reversed += (char)(item + key);

            return reversed;
        }

        private string Decryption(string text, int key = 2)
        {
            string reversed = "";

            foreach (var item in text.ToCharArray())
                reversed += (char)(item - key);

            return reversed;
        }

    }
}
