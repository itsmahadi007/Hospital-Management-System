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

namespace Hospital_Management_System
{
    public partial class wardBoyDelete : Form
    {

        SqlDataAdapter adapter;
        DataTable table = new DataTable();
        SqlConnection cnn;
        SqlCommand cmd;
        string connection;
        int pos = 0;
        public wardBoyDelete()
        {
            InitializeComponent();
            ShowWardBoy();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\hospital.mdf;Integrated Security=True;Connect Timeout=30";
                cnn = new SqlConnection(connection);
                cnn.Open();
                int name = Convert.ToInt32(Name.Text);

                string sqlcmd = "DELETE from wardBoy where Id='"+name+"'";
                cmd = new SqlCommand(sqlcmd, cnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("DELETED!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cnn.Close();
               
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Connection Error" + ex);
            }
        }

        void ShowWardBoy()
        {
            connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\hospital.mdf;Integrated Security=True;Connect Timeout=30";
            cnn = new SqlConnection(connection);
            cnn.Open();
            cmd = new SqlCommand("SELECT *  from wardBoy", cnn);
            SqlDataReader reader = cmd.ExecuteReader();
            //SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dt.Load(reader);
            //MessageBox.Show(dt.ToString());
            dataGridView1.DataSource = dt;
            cnn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dash_Board d=new Dash_Board();
            d.Show();
            this.Hide();
        }
    }
}
