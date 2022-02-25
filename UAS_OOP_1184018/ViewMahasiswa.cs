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
    public partial class ViewMahasiswa : Form
    {
        public ViewMahasiswa()
        {
            InitializeComponent();
        }

        private DataSet ds_Mahasiswa;

        public DataSet CreateMahasiswaDataSet()
        {
            DataSet myDataSet = new DataSet();

            try
            {

                SqlConnection myConnection = new SqlConnection(@"Data Source=NAOMI-CHT\SQLEXPRESS; Initial Catalog = UAS; Integrated Security = True");


                SqlCommand myCommand = new SqlCommand();


                myCommand.Connection = myConnection;


                myCommand.CommandText = "SELECT * FROM ms_mhs";
                myCommand.CommandType = CommandType.Text;


                SqlDataAdapter myDataAdapter = new SqlDataAdapter();
                myDataAdapter.SelectCommand = myCommand;
                myDataAdapter.TableMappings.Add("Table", "Mahasiswa");


                myDataAdapter.Fill(myDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return myDataSet;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshDataSet();
        }

        private void RefreshDataSet()
        {
            ds_Mahasiswa = CreateMahasiswaDataSet();

            dgMahasiswa.DataSource = ds_Mahasiswa.Tables["Mahasiswa"];
        }
    }
}
