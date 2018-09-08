using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CarApp
{
    public partial class AddCar : Form
    {
        string picloc;
        string mainID;
        string filepath;
        public AddCar()
        {
            InitializeComponent();
        }

        private void btn_addpic_Click(object sender, EventArgs e)
        {
            picloc = Form_Methods.addImgPicbox(pictureBox1);
        }

        private void btn_addcar_Click(object sender, EventArgs e)
        {
            try
            {
                mainID = Form_Methods.GenerateID(txt_brand.Text, txt_year.Text);
                filepath = Application.StartupPath + @"\\images\" + mainID + "\\" ;
                Directory.CreateDirectory(filepath);
                File.Copy(picloc, filepath + Path.GetFileName(picloc));
                File.Move(filepath + Path.GetFileName(picloc), filepath + "img.jpg");
                Form_Methods.AddCar(mainID, txt_brand.Text, txt_year.Text, txt_design.Text, txt_engine.Text, txt_type.Text);
                MessageBox.Show("Car Added");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                txt_brand.Text = "";
                txt_year.Text = "";
                txt_design.Text = "";
                txt_engine.Text = "";
                txt_type.Text = "";
                pictureBox1.Image = null;

            }


        }
    }
}
