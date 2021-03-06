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
    public partial class Mahasiswa : Form
    {
        public Mahasiswa()
        {
            InitializeComponent();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            // simpan data kedalam database
            string myCmd = "INSERT INTO ms_mhs VALUES ('"
                + txtNPM.Text + "','"
                + txtNama.Text + "')";

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
            txtNPM.Clear();
            txtNama.Clear();
            cbProdi.Text = "";
        }

        private void showDataComboBox()
        {
            cbProdi.Items.Add("Teknik Informatika");
            cbProdi.Items.Add("Logistik Bisnis");
            cbProdi.Items.Add("Manajemen Bisnis");
            cbProdi.Items.Add("Akutansi");
            cbProdi.Items.Add("Manajemen Informasi");
        }

        private void Mahasiswa_Load(object sender, EventArgs e)
        {
            showDataComboBox();
        }
    }
}
