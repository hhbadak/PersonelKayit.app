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
using static System.Net.WebRequestMethods;

namespace PersonelKayit
{
    public partial class PersonalAdd : Form
    {
        public PersonalAdd()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string personalFileName = tb_name.Text + " " + tb_surname.Text;
            string fileName = personalFileName;
            string filePath = @"C:\Personal";
            StreamWriter sw = sw = System.IO.File.CreateText(filePath + "//" + personalFileName + ".txt");

            sw.WriteLine($"{lbl_name} : {tb_name.Text}");
            sw.WriteLine($"{lbl_surname} : {tb_surname.Text}");
            sw.WriteLine($"{lbl_nationalNumber} : {tb_nationalNumber.Text}");
            sw.WriteLine($"{lbl_placeBirth} : {cb_placeBirth.Text}");
            if ()
            {

            }
            sw.Flush();
            sw.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
