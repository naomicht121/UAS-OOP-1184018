using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UAS_OOP_1184018
{
    public partial class Program_Studi : Form
    {
        internal Home MdiHome;

        public Program_Studi()
        {
            InitializeComponent();
        }


        private void txtNamaProdi_Leave(object sender, EventArgs e)
        {
            if (txtNamaProdi.Text == "")
            {
                epWrong.SetError(txtNamaProdi, "");
                epWarning.SetError(txtNamaProdi, "Nama Prodi tidak boleh kosong !");
                epCorrect.SetError(txtNamaProdi, "");
            }
            else
            {
                if ((txtNamaProdi.Text).All(Char.IsLetter))
                {
                    epWarning.SetError(txtNamaProdi, "");
                    epWrong.SetError(txtNamaProdi, "");
                    epCorrect.SetError(txtNamaProdi, "Betul!");
                }
                else
                {
                    epWarning.SetError(txtNamaProdi, "Inputan hanya boleh huruf!");
                    epWrong.SetError(txtNamaProdi, "");
                    epCorrect.SetError(txtNamaProdi, "");
                }
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void clear()
        {
            txtKodeProdi.Clear();
            txtNamaProdi.Clear();
            txtSingkatan.Clear();
            txtBiayaKuliah.Clear();
        }
    }
    
}
