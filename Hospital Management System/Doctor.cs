using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hospital_Management_System
{
    public partial class Doctor : Form
    {
        SqlDataAdapter adapter;
      
        SqlConnection cnn;
        SqlCommand cmd;

        int pos = 0;
        string connection;
        public Doctor()
        {
            InitializeComponent();
          
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

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
                int name = Convert.ToInt16(Name.Text);
                string doctor = Doctoe_Name.Text;
                string age = Age.Text;
                string dis = Diseases.Text;
                string sqlcmd = "INSERT INTO Doctor values ('"+name+"','"+doctor+"','"+age+"','"+dis+"')";
                cmd = new SqlCommand(sqlcmd, cnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Inserted!","Done", MessageBoxButtons.OK,MessageBoxIcon.Information);
                cnn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Connection Error" + ex);
            }

                
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           DoctorDelete d=new DoctorDelete();
            d.Show();
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
                string doctor = Doctoe_Name.Text;
                string age = Age.Text;
                string dis = Diseases.Text;
                //MessageBox.Show(Services);
                string sqlcmd = "UPDATA  SET Name='"+name+"',Doctor='"+doctor+"',Age='"+age+"',Diseases='"+dis+"'";
                cmd = new SqlCommand(sqlcmd, cnn);
                int count = cmd.ExecuteNonQuery();
                cnn.Close();
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Connection Error" + ex);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //connection = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\Hospital Management System\Hospital Management System\hospital.mdf ;Integrated Security=True";
            //cnn = new SqlConnection(connection);
            //cnn.Open();
            //cmd = new SqlCommand("Select * Doctor from ", cnn);
            //SqlDataReader reader = cmd.ExecuteReader();
            ////SqlDataAdapter adp = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //dt.Load(reader);
            ////MessageBox.Show(dt.ToString);
            //dataGridView1.DataSource = dt;
            //cnn.Close();
        }


        void ShowDoctor()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\hospital.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlDataAdapter sa = new SqlDataAdapter("select *from Doctor", con);

            try
            {
                DataTable data1 = new DataTable();
                sa.Fill(data1);

                dataGridView1.DataSource = data1;
            }
            catch
            {
                MessageBox.Show("No Date");
                con.Close();

            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("jbjhsbdjbjksdc");
            Name.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            Doctoe_Name.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            Age.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            Diseases.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void View_Click(object sender, EventArgs e)
        {
            ShowDoctor();
        }

       

        
    }
}
