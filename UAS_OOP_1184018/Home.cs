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

        //Input
        private void InputMhsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mahasiswa newMahasiswa = new Mahasiswa();
            newMahasiswa.MdiHome = this;
            newMahasiswa.Show();
        }

        private void InputProdiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProgramStudi newProgram = new ProgramStudi();
            newProgram.MdiHome = this;
            newProgram.Show();
        }

        //View
        private void ViewMhsToolStripMenuItem1_Click(object sender, EventArgs e)
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

        //Update
        private void UpdateMhsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateMahasiswa newMahasiswa = new UpdateMahasiswa();
            newMahasiswa.MdiHome = this;
            newMahasiswa.Show();
        }

        private void UpdateProdiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateProdi newProgram = new UpdateProdi();
            newProgram.MdiHome = this;
            newProgram.Show();
        }

        //Transaksi
        private void DaftarUlangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DaftarUlang newProgram = new DaftarUlang();
            newProgram.MdiHome = this;
            newProgram.Show();
        }
    }
}
