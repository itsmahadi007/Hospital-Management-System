using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hospital_Management_System
{
    public partial class Patient : Form
    {
        SqlDataAdapter adapter;
        DataTable table = new DataTable();
        SqlConnection cnn;
        SqlCommand cmd;
        SqlDataReader reader;
        string connection;
        int pos = 0;
        public Patient()
        {
            InitializeComponent();
            ShowBilling();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dash_Board ss = new Dash_Board();
            ss.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\hospital.mdf;Integrated Security=True;Connect Timeout=30";
                cnn = new SqlConnection(connection);
                cnn.Open();
                string name = Name.Text;
                int age = Convert.ToInt32(Age.Text);
                string address = Address.Text;
                int doctor_fee = Convert.ToInt32(Doctor_Fee.Text);
                int room_fee = Convert.ToInt32(Room_Fee.Text);
                string sqlcmd = "INSERT INTO patient (Name,Age,address,Doctor_Fee,Room_Fee) values ('"+name+"','"+age+"','"+address+"','"+doctor_fee+"','"+room_fee+"')";
                cmd = new SqlCommand(sqlcmd,cnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("INSERTED!","Done",MessageBoxButtons.OK,MessageBoxIcon.Information);
                cnn.Close();
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Connection Error"+ex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PatientDelete b=new PatientDelete();
            b.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                connection = "Data Source=; Initial Catalog=; User Id=; Password=;";
                cnn = new SqlConnection(connection);
                cnn.Open();
                int name = Convert.ToInt16(Name.Text);
                string age = Age.Text;
                string address = Address.Text;
                string doctor_fee = Doctor_Fee.Text;
                string room_fee = Room_Fee.Text;
                //MessageBox.Show(Services);
                string sqlcmd = "UPDATA SET Name='" + name + "',Age='" + age + "',address='" + Address + "', Doctor_Fee='" + doctor_fee + "',Room_Fee='" + room_fee + "'";
                cmd = new SqlCommand(sqlcmd,cnn);
                cnn.Close();
                MessageBox.Show("Record Updated");
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Connection Error"+ex);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //connection = "Data Source=; Initial Catalog=; User Id=; Password=;";
            //cnn = new SqlConnection(connection);
            //cnn.Open();
            //cmd = new SqlCommand("SELECT * from", cnn);
            //SqlDataReader reader = cmd.ExecuteReader();
            ////SqlDataAdapter adp = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //dt.Load(reader);
            ////MessageBox.Show(dt.ToString());
            //dataGridView1.DataSource = dt;
            //cnn.Close();
 
        }


        void ShowBilling()
        {
            connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\hospital.mdf;Integrated Security=True;Connect Timeout=30";
            cnn = new SqlConnection(connection);
            cnn.Open();
            cmd = new SqlCommand("SELECT * from patient", cnn);
            SqlDataReader reader = cmd.ExecuteReader();
            //SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dt.Load(reader);
            //MessageBox.Show(dt.ToString());
            dataGridView1.DataSource = dt;
            cnn.Close();
        }
        private void Load(object sender, EventArgs e)
        {
            
        }

        private void Patient_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ShowBilling();
        }
    }
}
