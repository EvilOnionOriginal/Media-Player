using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBProjek01
{
    public partial class Form1 : Form
    {
        // media player wat ons gan maak
        // aparte folder met musiek wat gescan word en data word in db in gelees


        // Doel: Splash screen op start
        // Form1: Menue, Refresh DB, 
        // Form2:
        // Form3:



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openNewFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View view = new View();
            view.Show();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edit edit = new Edit();
            edit.Show();
        }
    }
}
