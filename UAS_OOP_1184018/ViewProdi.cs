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
    public partial class ViewProdi : Form
    {
        private SqlCommand sc;
        private DataSet ds;
        private SqlDataAdapter sda;

        Connection connection = new Connection();

        public ViewProdi()
        {
            InitializeComponent();
        }

        private void showData()
        {
            SqlConnection conn = connection.GetConn();
            try
            {
                conn.Open();
                sc = new SqlCommand("SELECT * FROM ms_prodi", conn);
                ds = new DataSet();
                sda = new SqlDataAdapter(sc);
                sda.Fill(ds, "ms_prodi");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "ms_prodi";
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
        
    }

    
     

}
