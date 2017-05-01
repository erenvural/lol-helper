using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace League_of_Legends_2
{
    class DB
    {
        public MySqlConnection connection;
        public MySqlDataReader reader;
        public MySqlCommand command;

        public DB()
        {
            connection = new MySqlConnection("Server=localhost;Port=3307;Database=mydb;Uid=root;Pwd='e1r2e3n4';");
        }

        public bool checkConnection()
        {
            try
            {
                connection = new MySqlConnection("Server=localhost;Port=3307;Database=mydb;Uid=root;Pwd='e1r2e3n4';");
               
                return true;
                //Veritabanına bağlanırsa connection_kontrol fonksiyonu "true" değeri gönderecek
            }

            catch (Exception)
            {
                return false;
                //Veritabanına bağlanamazsa "false" değeri dönecek
            }
        }

        public string select(string query)
        {
            connection.Open();
            command = new MySqlCommand(query, connection);
            reader = command.ExecuteReader();
            string result;
            if (reader.Read())
            {
                result = reader[0].ToString();
            }
            else
            {
                result = "";
            }
            connection.Close();
            return result;
        }
        
        public string[] select_as_array(string query)
        {
            connection.Open();
            command = new MySqlCommand(query, connection);
            reader = command.ExecuteReader();
            string[] result = new string[reader.FieldCount];
            reader.Read();
            for (int i = 0; i<reader.FieldCount;i++ )
            {
                result[i] = reader[i].ToString();
            }           
            connection.Close();
            return result;
        }

        public string select_as_multirow_array(string query)
        {
            connection.Open();
            command = new MySqlCommand(query, connection);
            reader = command.ExecuteReader();
            string result = "";
            while (reader.Read())
            {
                result += reader[0].ToString();
                result += " --- ";
            }
            connection.Close();
            return result;
        }

        public bool insert(string query)
        {
            try
            {
                connection.Open();
                command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                connection.Close();
                return true;
                //Veritabanına veriler eklenirse "true" değeri gönderecek
            }
            catch (Exception)
            {
                return false;
                //Veriler eklenmezse "false" değeri dönecek
            }
        }

        public DataTable dataTable(string query)
        {
            connection.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            connection.Close();
            return dt;
        }
    }
}
