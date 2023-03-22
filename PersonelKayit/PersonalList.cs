using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelKayit
{
    public partial class PersonalList : Form
    {
        public PersonalList()
        {
            InitializeComponent();
        }

        private void PersonalList_Load(object sender, EventArgs e)
        {
            
        }

        private void cb_personelList_SelectedIndexChanged(object sender, EventArgs e)
        {

            string dataPath = @"C://Personal}";
            //DirectoryInfo di = new DirectoryInfo(dataPath);
            //DirectoryInfo[] folders = di.GetDirectories();

            //foreach (DirectoryInfo item in folders)
            //{
            //    cb_personelList.Items.Add(item.Name);
            //}
            //FileInfo[] files = di.GetFiles();
            //foreach (FileInfo item in files)
            //{
            //    cb_personelList.Items.Add(item.Name);
            ////}
            //StreamReader reader = new StreamReader(dataPath,true);
            //cb_personelList.Items.Add(reader.ToString());
            OpenFileDialog.ReferenceEquals(this, dataPath);
            
        }
    }
}
