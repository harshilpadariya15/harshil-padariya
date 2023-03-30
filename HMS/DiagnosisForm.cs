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
    public partial class DiagnosisForm : Form
    {
        public DiagnosisForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SMANg\source\repos\HMS\HMS\HMSdb.mdf;Integrated Security=True;Connect Timeout=30");
        void populatecombo()
        {
            String Sql = "select * from Patienttbl";
            SqlCommand cmd = new SqlCommand(Sql, con);
            SqlDataReader rdr;
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("Patid", typeof(int));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                Patientidcb.ValueMember = "Patid";
                Patientidcb.DataSource = dt;
                con.Close();

            }
            catch
            {
            }
        }
        String Patname;
        void fecthpatientname()
        {
           // con.Open();
            String mySql = "select * from Patienttbl where Patid=" + Patientidcb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(mySql, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                Patname = dr["Patname"].ToString();
                Patienttb.Text = Patname;
            }
            //con.Close();
        }
        void populate()
        {
            con.Open();
            String query = "select * from Diagnosistbl";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            DiagnosisGV.DataSource = ds.Tables[0];
            con.Close();

        }
        private void bunifuMaterialTextbox4_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
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
            if (Diagid.Text == "" || Medicinestb.Text == "" || Diagnosistb.Text == "" || Patienttb.Text == "" || Medicinestb.Text == "") 
          
          MessageBox.Show("No empty file accepted");
            else
            {
                con.Open();
                String query = "insert into Diagnosistbl values(" + Diagid.Text + "," + Patientidcb.SelectedValue.ToString() + ",'" + Patienttb.Text + "','" + Symptomstb.Text + "','" + Diagnosistb.Text + "','" +Medicinestb.Text+"')";
                SqlCommand cmd = new SqlCommand(query,con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Diagnosis Successfully Added");
                con.Close();
                populate();
               
            }
        }

        private void Patientidtb_SelectedIndexChanged(object sender, EventArgs e)
        {
            fecthpatientname();
        }

        private void DiagnosisForm_Load(object sender, EventArgs e)
        {
            populatecombo();
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Diagid.Text == "")
                MessageBox.Show("Enter the Diagnosis id ");
            else
            {
                con.Open();
                String query = "Delete from Diagnosistbl where Diagid=" + Diagid.Text + "";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Diagnosis successfully deleted");
                con.Close();
                populate();
            }
        }

        private void DiagnosisGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Diagid.Text = DiagnosisGV.SelectedRows[0].Cells[0].Value.ToString();
            Patientidcb.SelectedValue = DiagnosisGV.SelectedRows[0].Cells[1].Value.ToString();
            Patienttb.Text = DiagnosisGV.SelectedRows[0].Cells[2].Value.ToString();
            Symptomstb.Text = DiagnosisGV.SelectedRows[0].Cells[3].Value.ToString();
            Diagnosistb.Text = DiagnosisGV.SelectedRows[0].Cells[4].Value.ToString();
            Medicinestb.Text = DiagnosisGV.SelectedRows[0].Cells[5].Value.ToString();
            Patientnamelbl.Text = DiagnosisGV.SelectedRows[0].Cells[2].Value.ToString();
            Diagnosislbl.Text = DiagnosisGV.SelectedRows[0].Cells[4].Value.ToString();
            Symptomslbl.Text = DiagnosisGV.SelectedRows[0].Cells[3].Value.ToString();
            Medicineslbl.Text = DiagnosisGV.SelectedRows[0].Cells[5].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "update Diagnosistbl set Patid = " + Patientidcb.SelectedValue.ToString() + ",Patname ='" +Patienttb.Text + "',Symptoms ='" + Symptomstb.Text + "', Diagnosis = '"+Diagnosistb.Text+"',Medicines = '"+Medicinestb.Text+"' where Diagid = " +Diagid.Text + "";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Diagnosis successfully updated");
            con.Close();
            populate();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(label4.Text, new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(230));
            e.Graphics.DrawString(Patientnamelbl.Text + "\n" +Diagnosislbl.Text + "\n"+ Symptomslbl.Text + "\n" +Medicineslbl.Text , new Font("Century Gothic", 12, FontStyle.Regular), Brushes.Black, new Point(130,150));
            e.Graphics.DrawString(label10.Text + "\n\t"+label11.Text, new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Red, new Point(230,380));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(printPreviewDialog1.ShowDialog()==DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Diagid_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
