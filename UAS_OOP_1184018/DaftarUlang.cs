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
    public partial class DaftarUlang : Form
    {
        public DaftarUlang()
        {
            InitializeComponent();
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string myCmd = "INSERT INTO tr_daftar_ulang VALUES ('"
                + txtNpm.Text + "','"
                + gbGrade.Text + "','"
                + txtTotal.Text + "',')";

            UpdateDB(myCmd);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void clear()
        {
            txtNpm.Text = "";
            gbGrade.Text = "";
            txtTotal.Text = "";
        }
    }
}
