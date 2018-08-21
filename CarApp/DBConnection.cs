using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Xml.Serialization;

namespace CarApp
{
    class DBConnection
    {
        MySqlConnection connect;
        Settings stg = new Settings();
        string server;


        private string username = "Ati";
        private string password = "test";

        public string Username { get => username; }
        public string Password { get => password; }

        public DBConnection()
        {
            loadData();


            string mycons = "SERVER=" + server + ";PORT=3306;DATABASE=car_db;UID=Ati;PASSWORD=test;SslMode=none";
            connect = new MySqlConnection(mycons);
        }

        public void Open()
        {
            connect.Open();
        }

        public void Close()
        {
            connect.Close();
        }

        public MySqlConnection getConnection()
        {
            return connect;
        }

        public void loadData()
        {
            FileStream fs = null;
            try
            {
                XmlSerializer deserializer = new XmlSerializer(stg.GetType());
                fs = new FileStream(System.AppDomain.CurrentDomain.BaseDirectory + "settings.xml", FileMode.Open);
                stg = (Settings)deserializer.Deserialize(fs);
                server = stg.DataServer;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                fs.Close();
            }

        }
    }
}
