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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            try
            {
                Form_Methods.FillCombo(comboBox1);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void newCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCar addcar = new AddCar();
            addcar.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            try
            {
                Form_Methods.LoadCarDetails(lbl_brand, lbl_year, lbl_design, lbl_engine, lbl_type);
                pictureBox2.ImageLocation = Application.StartupPath + @"\\images\" + comboBox1.Text + "\\img.jpg";
                Form_Methods.LoadStatus("Asigurare", "yes", lbl_asig);
                Form_Methods.LoadStatus("ITP", "yes", lbl_itp);
                Form_Methods.LoadStatus("Ulei", "yes", lbl_ulei);
                Form_Methods.LoadStatus("Rovinieta", "yes", lbl_rov);
                Form_Methods.LoadStatus("Filtre", "yes", lbl_filtre);


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void maintanaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Maintanance mt = new Maintanance();
            mt.Show();
        }

        private void archiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Archive arch = new Archive();
            arch.Show();
        }

        private void currentExpansesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Current cr = new Current();
            cr.Show();
        }
    }
}
