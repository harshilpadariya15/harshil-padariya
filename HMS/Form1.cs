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
using System.Threading;
namespace HMS
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SMANg\source\repos\HMS\HMS\HMSdb.mdf;Integrated Security=True;Connect Timeout=30");
        public Form1()
        {
            Thread t = new Thread(new ThreadStart(StartForm));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            t.Abort();
            
        }

        private void StartForm()
        {
            Application.Run(new SplashForm());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Docnametb.Text == "" || Passtb.Text == "")
                MessageBox.Show("enter a username and passwoed");
            else
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select count(*)from Doctortbl where Docname='" + Docnametb.Text + "' and Docpass='" + Passtb.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    Home H = new Home();
                    H.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong username or oassword");

                }
                con.Close();
            }
          //  Home H = new Home();
            //H.Show();
            //this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Docnametb.Text = "";
            Passtb.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Docnametb_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void Passtb_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
