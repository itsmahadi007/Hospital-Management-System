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
    public partial class Wardboy : Form
    {
        SqlDataAdapter adapter;
        DataTable table = new DataTable();
        SqlConnection cnn;
        SqlCommand cmd;
        string connection;
        int pos = 0;
        public Wardboy()
        {
            InitializeComponent();
            ShowWardBoy();
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
                string patient_assent = Patient_Assent.Text;
                string room_assent = Room_Assent.Text;
                string sqlcmd = "INSERT INTO wardBoy (Name,Age,Patient_Assent,Room) values ('"+name+"','"+age+"','"+patient_assent+"','"+room_assent+"')"; 
                cmd = new SqlCommand(sqlcmd,cnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Inserted!","Done",MessageBoxButtons.OK,MessageBoxIcon.Information);
                cnn.Close();
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Connection Error" + ex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            wardBoyDelete w=new wardBoyDelete();
            w.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\hospital.mdf;Integrated Security=True;Connect Timeout=30";
                cnn = new SqlConnection(connection);
                cnn.Open();
                int name = Convert.ToInt16(Name.Text);
                string age = Age.Text;
                String patient_assent = Patient_Assent.Text;
                String room_assent = Room_Assent.Text;
                //MessageBox.Show(services);
                string sqlcmd = "UPDATA SET Name='"+name+"', Age='"+age+"', Patient_Assent='"+patient_assent+"',Room_Assent='"+room_assent+"'";
                cmd = new SqlCommand(sqlcmd,cnn);
                int cont = cmd.ExecuteNonQuery();
                cnn.Close();
                MessageBox.Show("Record Updated!","Done");
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Connection Error" + ex);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\hospital.mdf;Integrated Security=True;Connect Timeout=30";
            cnn = new SqlConnection(connection);
            cnn.Open();
            cmd = new SqlCommand("SELECT * from ", cnn);
            SqlDataReader reader = cmd.ExecuteReader();
            //SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dt.Load(reader);
            //MessageBox.Show(dt.ToString());
            dataGridView1.DataSource = dt;
            cnn.Close();
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
        
    }
}
