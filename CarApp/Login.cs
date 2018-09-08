using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarApp
{
    public partial class Login : Form
    {
        DBConnection conn;
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string pass = textBox2.Text;

            try
            {
                conn = new DBConnection();
                if (user == conn.Username && pass == conn.Password)
                {


                    conn.Open();
                    this.Hide();
                    MainForm mfrom = new MainForm();
                    mfrom.Show();
                    
                    

                }

                else
                {
                    MessageBox.Show("Ivalid username or password");
                }



            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                conn.Close();
                
            }
        }
    }
    
}
