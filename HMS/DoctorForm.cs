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

namespace HMS
{
    public partial class DoctorForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SMANg\source\repos\HMS\HMS\HMSdb.mdf;Integrated Security=True;Connect Timeout=30");
        public DoctorForm()
        {
            InitializeComponent();
        }
        void populate()
        {
            con.Open();
            String query = "select * from Doctortbl";
            SqlDataAdapter da = new SqlDataAdapter(query,con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            DoctorGV.DataSource = ds.Tables[0];
            con.Close();
            
        }
        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Docid.Text = DoctorGV.SelectedRows[0].Cells[0].Value.ToString();
            Docname.Text = DoctorGV.SelectedRows[0].Cells[1].Value.ToString();
            Docexp.Text = DoctorGV.SelectedRows[0].Cells[2].Value.ToString();
            Docpass.Text = DoctorGV.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void DoctorForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox3_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Docid.Text == "" || Docname.Text == "" || Docpass.Text == "" || Docexp.Text == "") 
            MessageBox.Show("No empty file accepted");
            else {
                con.Open();
                String query = "insert into Doctortbl values(" + Docid.Text + ",'" + Docname.Text + "'," + Docexp.Text + ",'" + Docpass.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Doctor Successfully Added");
                con.Close();
                populate();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "update doctortbl set Docname = '" + Docname.Text + "',Docexp ='" + Docexp.Text + "',Docpass ='" + Docpass.Text + "'where Docid = " + Docid.Text + "";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Doctor successfully updated");
            con.Close();
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Docid.Text == "")
                MessageBox.Show("Enter the doctor id ");
            else
            {
                con.Open();
                String query = "Delete from Doctortbl where Docid=" + Docid.Text + "";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Doctor successfully deleted");
                con.Close();
                populate();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void label5_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
