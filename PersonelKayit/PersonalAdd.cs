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

            sw.WriteLine($"{lbl_name.Text} : {tb_name.Text}");
            sw.WriteLine($"{lbl_surname.Text} : {tb_surname.Text}");
            sw.WriteLine($"{lbl_nationalNumber.Text} : {tb_nationalNumber.Text}");
            sw.WriteLine($"{lbl_placeBirth.Text} : {cb_placeBirth.Text}");
            sw.WriteLine($"{lbl_adress.Text} : {tb_adress.Text}");
            if (rb_man.Checked)
            {
                sw.WriteLine($"{lbl_gender.Text} : Erkek");
            }
            if (rb_woman.Checked)
            {
                sw.WriteLine($"{lbl_gender.Text} : Kadın");
            }
            if (rb_married.Checked)
            {
                sw.WriteLine($"{lbl_maritalStatus.Text} : Evli");
            }
            if (rb_unmarried.Checked)
            {
                sw.WriteLine($"{lbl_maritalStatus.Text} : Bekar");
            }
            if (rb_widow.Checked)
            {
                sw.WriteLine($"{lbl_maritalStatus.Text} : Dul");
            }
            sw.WriteLine($"{lbl_childrenNumber.Text} : {mtb_childNumber.Text}");
            if (cb_drivingYes.Checked)
            {
                cb_drivingLicence.Enabled = true;
                sw.WriteLine($"{lbl_drivingClass.Text} : {cb_drivingLicence.Text}");
            }
            else
            {
                sw.WriteLine($"{lbl_drivingClass} : Yok");
            }
            sw.WriteLine($"{lbl_dateBirth.Text} : {mtb_birthDate.Text}");
            sw.WriteLine($"{lbl_dateStart.Text} : {mtb_workStart.Text}");
            sw.WriteLine($"{lbl_departments.Text} : {cb_departments.Text}");
            sw.Flush();
            sw.Close();
        }

        private void cb_drivingYes_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_drivingYes.Checked)
            {
                cb_drivingLicence.Enabled = true;
            }
            else
            {
            }
        }
    }
}
