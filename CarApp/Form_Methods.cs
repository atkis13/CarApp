using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.IO;

namespace CarApp
{
    class Form_Methods
    {
        static DBConnection conn;

        public static void AddCar(string _id, string _brand, string _year, string _design, string _engine, string _type)
        {
            string query = "INSERT INTO all_cars(car_id, brand, year, design, engine, type) VALUES(@id, @brand, @year, @design, @engine, @type);";
            conn = new DBConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn.getConnection());
            cmd.Parameters.AddWithValue("@id", _id);
            cmd.Parameters.AddWithValue("@brand", _brand);
            cmd.Parameters.AddWithValue("@year", _year);
            cmd.Parameters.AddWithValue("@design", _design);
            cmd.Parameters.AddWithValue("@engine", _engine);
            cmd.Parameters.AddWithValue("@type", _type);
            cmd.ExecuteNonQuery();
            conn.Close();

        }

        public static void LoadCarDetails(Label _txt1, Label _txt2, Label _txt3, Label _txt4, Label _txt5)
        {        
                       
            string query = "Select * FROM all_cars;";
            conn = new DBConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn.getConnection());
            MySqlDataReader red = cmd.ExecuteReader();
            while (red.Read())
            {
            _txt1.Text = red.GetString("brand");
            _txt2.Text = red.GetString("year");
            _txt3.Text = red.GetString("design");
            _txt4.Text = red.GetString("engine");
            _txt5.Text = red.GetString("type");                    
            }
            conn.Close();           
           

        }
        public void LoadStatus(string maint, string latest, Label lbl)
        {

        }

        public static void AddWork()
        {

        }

        public static void AddMaint()
        {

        }

        public static void AddLatest() //maintanance
        {

        }

        public static void RemoveLatest() //maintanance
        {

        }

        public static void LoadData(string db_table)
        {

        }
    }
}
