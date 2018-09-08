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
    public partial class Maintanance : Form
    {
        public Maintanance()
        {
            InitializeComponent();
            comboBox1.Items.Add("Asigurare");
            comboBox1.Items.Add("Rovinieta");
            comboBox1.Items.Add("ITP");
            comboBox1.Items.Add("Ulei");
            comboBox1.Items.Add("Filtre");
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                Form_Methods.RemoveLatest(comboBox1.Text);
                Form_Methods.AddMaint(comboBox1.Text, dateTimePicker1.Text, dateTimePicker2.Text, txt_cost.Text);
                MessageBox.Show("Work Added");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                txt_cost.Text = "";
            }
        }
    }
}
