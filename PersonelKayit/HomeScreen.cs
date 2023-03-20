using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelKayit
{
    public partial class HomeScreen : Form
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void btn_personalAdd_Click(object sender, EventArgs e)
        {
            new PersonalAdd().ShowDialog();
        }

        private void btn_personalList_Click(object sender, EventArgs e)
        {
            new PersonalList().ShowDialog();
        }

        private void btn_salary_Click(object sender, EventArgs e)
        {
            new CalculateSalary().ShowDialog();
        }

        private void btn_personalUpdate_Click(object sender, EventArgs e)
        {
            new PersonalUpdate().ShowDialog();
        }
    }
}
