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
        public static void LoadStatus(string maint, string latest, Label lbl)
        {
            string query = "Select * FROM maint WHERE maint =@maint AND latest =@latest;";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn.getConnection());
            cmd.Parameters.AddWithValue("@maint", maint);
            cmd.Parameters.AddWithValue("@latest", "yes");
            MySqlDataReader red = cmd.ExecuteReader();
            if ((maint == "Filtre") || (maint == "Ulei"))
            {
                while (red.Read())
                {
                    lbl.Text = red.GetString("start_date");
                }

            }
            else
            {
                while (red.Read())
                {
                    lbl.Text = red.GetString("exp_date");
                }
            }
            conn.Close();


        }

        public static void AddMaint(string maint, string start_date, string end_date, string cost)
        {
            string query = "INSERT INTO maint(maint, start_date, exp_date, cost, latest) VALUES(@maint, @start_date, @exp_date, @cost, @latest);";
            conn = new DBConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn.getConnection());
            cmd.Parameters.AddWithValue("@maint", maint);
            cmd.Parameters.AddWithValue("@start_date", start_date);
            cmd.Parameters.AddWithValue("@exp_date", end_date);
            cmd.Parameters.AddWithValue("@cost", cost);
            cmd.Parameters.AddWithValue("@latest", "yes");
            
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static string GenerateID(string brand, string year)
        {
            string word = null;
            word = brand.Replace(" ", null);
            return word + year.ToString();
        }

        public static void AddWork()
        {

        }

        
        public static void SearchLatest() //maintanance
        {

        }

        public static void RemoveLatest(string maint) //maintanance
        {
            string query = "UPDATE maint SET latest =@nlatest WHERE maint =@maint AND latest =@latest;";
            conn = new DBConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn.getConnection());
            cmd.Parameters.AddWithValue("@maint", maint);
            cmd.Parameters.AddWithValue("@nlatest", "no");
            cmd.Parameters.AddWithValue("@latest", "yes");
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void LoadData(string db_table)
        {

        }
        public static void FillCombo(ComboBox cb)
        {
            string query = "Select * from all_cars;";
            conn = new DBConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn.getConnection());
            MySqlDataReader red = cmd.ExecuteReader();
            while (red.Read())
            {
                string id = red.GetString("car_id");
                cb.Items.Add(id);
            }
            conn.Close();

        }

        public static string addImgPicbox(PictureBox pic)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "JPG Files(*.jpg)|*.jpg|All files(*.*)|*.*";
            string picloc = null;

            if (op.ShowDialog() == DialogResult.OK)
            {
                picloc = op.FileName.ToString();
                
                pic.ImageLocation = picloc;
            }
            return picloc;
        }
    }
}
