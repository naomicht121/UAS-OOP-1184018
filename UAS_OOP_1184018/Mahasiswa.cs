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
        private object connection;

        public Mahasiswa()
        {
            InitializeComponent();
        }

        private void Mahasiswa_Load(object sender, EventArgs e)
        {
            showDataComboBox();
            showData();
            clear();
        }

        private void clear()
        {
            txtKodeProdi.Clear();
            txtNamaProdi.Clear();
            cbProdi.Text = "";
        }

        private void showData()
        {
            SqlConnection conn = connection.GetConn();
            try
            {
                conn.Open();
                sc = new SqlCommand("SELECT * FROM ms_mhs", conn);
                ds = new DataSet();
                sda = new SqlDataAdapter(sc);
                sda.Fill(ds, "ms_mhs");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "ms_mhs";
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception G)
            {
                MessageBox.Show(G.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        private void showDataComboBox()
        {
            throw new NotImplementedException();
        }
    }


    private void showDataComboBox()
    {
        cbProdi.Items.Add("PCS");
        cbProdi.Items.Add("BOX");
        cbProdi.Items.Add("LUSIN");
        cbProdi.Items.Add("BOTOL");
        cbProdi.Items.Add("SACHET");
    }
}
