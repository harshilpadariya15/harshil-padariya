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
    public partial class PatientForm : Form
    {
        public PatientForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SMANg\source\repos\HMS\HMS\HMSdb.mdf;Integrated Security=True;Connect Timeout=30");
        void populate()
        {
            con.Open();
            String query = "select * from Patienttbl";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            gunaDataGridView1.DataSource = ds.Tables[0];
            con.Close();

        }
        private void PatientForm_Load(object sender, EventArgs e)
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

        private void bunifuMaterialTextbox4_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox5_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox6_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Patid.Text == "" || Patname.Text == "" || Patad.Text == "" || Patphone.Text == "" || Patage.Text == ""|| Majortb.Text == "" )
                MessageBox.Show("No empty file accepted");
            else
            {
                con.Open();
                String query = "insert into Patienttbl values("+Patid.Text+",'"+Patname.Text+"','"+Patad.Text+"',"+Patphone.Text+","+Patage.Text+",'"+Gendercb.SelectedItem.ToString()+"','"+Bloodcb.SelectedItem.ToString()+"','"+Majortb.Text+"')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Patient Successfully Added");
                con.Close();
                populate();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "update patienttbl set patname = '" + Patname.Text + "',patad ='" + Patad.Text + "', patphone='" + Patphone.Text + "',patage="+Patage.Text+",patgender='"+Gendercb.SelectedItem.ToString()+ "',patblood='" + Bloodcb.SelectedItem.ToString() + "',patdisease='"+Majortb.Text+"' where patid = " + Patid.Text+ "";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Patient successfully updated");
            con.Close();
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Patid.Text == "")
                MessageBox.Show("Enter the Patient id ");
            else
            {
                con.Open();
                String query = "Delete from Patienttbl where Patid=" + Patid.Text + "";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Patient successfully deleted");
                con.Close();
                populate();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Patid.Text = gunaDataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            Patname.Text = gunaDataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            Patad.Text = gunaDataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            Patphone.Text = gunaDataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            Patage.Text = gunaDataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            Majortb.Text = gunaDataGridView1.SelectedRows[0].Cells[7].Value.ToString();

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
