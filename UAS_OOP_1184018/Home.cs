using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UAS_OOP_1184018
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

            

        private void tsView_Click(object sender, EventArgs e)
        {

        }

        private void InputMhsMenuItem_Click(object sender, EventArgs e)
        {
            Mahasiswa newMahasiswa = new Mahasiswa();
            newMahasiswa.MdiHome = this;
            newMahasiswa.Show();
        }

        private void InputProdiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program_Studi newProgram = new Program_Studi();
            newProgram.MdiHome = this;
            newProgram.Show();
        }

        private void ViewMhsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewMahasiswa newMahasiswa = new ViewMahasiswa();
            newMahasiswa.MdiHome = this;
            newMahasiswa.Show();
        }

        private void ViewProdiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewProdi newProgram = new ViewProdi();
            newProgram.MdiHome = this;
            newProgram.Show();
        }
    }

}
