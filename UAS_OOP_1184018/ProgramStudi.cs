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
    public partial class ProgramStudi : Form
    {

        public ProgramStudi()
        {
            InitializeComponent();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            // simpan data kedalam database
            string myCmd = "INSERT INTO ms_prodi VALUES ('"
                + txtKodeProdi.Text + "','"
                + txtNamaProdi.Text + "','"
                + txtSingkatan.Text + "','"
                + txtBiayaKuliah.Text + "')";

            UpdateDB(myCmd);
        }

        private void UpdateDB(string cmd)
        {

            try
            {

                SqlConnection myConnection = new SqlConnection(@"Data Source=NAOMI-CHT\SQLEXPRESS; Initial Catalog = UAS; Integrated Security = True");


                myConnection.Open();


                SqlCommand myCommand = new SqlCommand();


                myCommand.Connection = myConnection;


                myCommand.CommandText = cmd;


                myCommand.ExecuteNonQuery();


                MessageBox.Show("Data Berhasil Disubmit !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void txtKodeProdi_Leave(object sender, EventArgs e)
        {

            if (txtKodeProdi.Text == "")
            {
                epWrong.SetError(txtKodeProdi, "");
                epWarning.SetError(txtKodeProdi, "Kode Prodi tidak boleh kosong !");
                epCorrect.SetError(txtKodeProdi, "");
            }
            
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

        private void txtSingkatan_Leave(object sender, EventArgs e)
        {
            if (txtSingkatan.Text == "")
            {
                epWrong.SetError(txtSingkatan, "");
                epWarning.SetError(txtSingkatan, "Singkatan Prodi tidak boleh kosong !");
                epCorrect.SetError(txtSingkatan, "");
            }
            else
            {
                if ((txtSingkatan.Text).All(Char.IsLetter))
                {
                    epWarning.SetError(txtSingkatan, "");
                    epWrong.SetError(txtSingkatan, "");
                    epCorrect.SetError(txtSingkatan, "Betul!");
                }
                else
                {
                    epWarning.SetError(txtSingkatan, "Inputan hanya boleh huruf!");
                    epWrong.SetError(txtSingkatan, "");
                    epCorrect.SetError(txtSingkatan, "");
                }
            }
        }

        private void txtBiayaKuliah_Leave(object sender, EventArgs e)
        {
            if (txtBiayaKuliah.Text == "")
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
    }
}
