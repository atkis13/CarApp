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
    public partial class Current : Form
    {
        public Current()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                Form_Methods.AddWork(dateTimePicker1.Text, txt_work.Text, txt_cost.Text, txt_desc.Text);
                MessageBox.Show("Work Added");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                txt_work.Text = "";
                txt_cost.Text = "";
                txt_desc.Text = "";
            }
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            try
            {
                Form_Methods.LoadData(dataGridView1, "current");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

            }
        }
    }
}
