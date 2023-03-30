
namespace HMS
{
    partial class DiagnosisForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiagnosisForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Diagid = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Patienttb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Patientidcb = new System.Windows.Forms.ComboBox();
            this.Symptomstb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Diagnosistb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Medicinestb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Diagnosislbl = new System.Windows.Forms.Label();
            this.Medicineslbl = new System.Windows.Forms.Label();
            this.Symptomslbl = new System.Windows.Forms.Label();
            this.Patientnamelbl = new System.Windows.Forms.Label();
            this.DiagnosisGV = new Guna.UI.WinForms.GunaDataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiagnosisGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LawnGreen;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1393, 124);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(1288, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 30);
            this.label5.TabIndex = 11;
            this.label5.Text = "X";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(599, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "DIAGNOSIS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(497, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "HOSPITAL MANAGEMENT SYSTEM";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Diagid
            // 
            this.Diagid.BackColor = System.Drawing.SystemColors.Control;
            this.Diagid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Diagid.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Diagid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Diagid.HintForeColor = System.Drawing.Color.Empty;
            this.Diagid.HintText = "";
            this.Diagid.isPassword = false;
            this.Diagid.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.Diagid.LineIdleColor = System.Drawing.Color.Gray;
            this.Diagid.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.Diagid.LineThickness = 3;
            this.Diagid.Location = new System.Drawing.Point(39, 149);
            this.Diagid.Margin = new System.Windows.Forms.Padding(5);
            this.Diagid.Name = "Diagid";
            this.Diagid.Size = new System.Drawing.Size(256, 39);
            this.Diagid.TabIndex = 3;
            this.Diagid.Text = "DIAGNOSISID";
            this.Diagid.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Diagid.OnValueChanged += new System.EventHandler(this.Diagid_OnValueChanged);
            // 
            // Patienttb
            // 
            this.Patienttb.BackColor = System.Drawing.SystemColors.Control;
            this.Patienttb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Patienttb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Patienttb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Patienttb.HintForeColor = System.Drawing.Color.Empty;
            this.Patienttb.HintText = "";
            this.Patienttb.isPassword = false;
            this.Patienttb.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.Patienttb.LineIdleColor = System.Drawing.Color.Gray;
            this.Patienttb.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.Patienttb.LineThickness = 3;
            this.Patienttb.Location = new System.Drawing.Point(39, 247);
            this.Patienttb.Margin = new System.Windows.Forms.Padding(5);
            this.Patienttb.Name = "Patienttb";
            this.Patienttb.Size = new System.Drawing.Size(256, 39);
            this.Patienttb.TabIndex = 4;
            this.Patienttb.Text = "PATIENTNAME";
            this.Patienttb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Patientidcb
            // 
            this.Patientidcb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Patientidcb.FormattingEnabled = true;
            this.Patientidcb.Items.AddRange(new object[] {
            ""});
            this.Patientidcb.Location = new System.Drawing.Point(39, 213);
            this.Patientidcb.Margin = new System.Windows.Forms.Padding(4);
            this.Patientidcb.Name = "Patientidcb";
            this.Patientidcb.Size = new System.Drawing.Size(255, 24);
            this.Patientidcb.TabIndex = 10;
            this.Patientidcb.Text = "PATIENTID";
            this.Patientidcb.SelectedIndexChanged += new System.EventHandler(this.Patientidtb_SelectedIndexChanged);
            this.Patientidcb.SelectionChangeCommitted += new System.EventHandler(this.Patientidtb_SelectedIndexChanged);
            // 
            // Symptomstb
            // 
            this.Symptomstb.BackColor = System.Drawing.SystemColors.Control;
            this.Symptomstb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Symptomstb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Symptomstb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Symptomstb.HintForeColor = System.Drawing.Color.Empty;
            this.Symptomstb.HintText = "";
            this.Symptomstb.isPassword = false;
            this.Symptomstb.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.Symptomstb.LineIdleColor = System.Drawing.Color.Gray;
            this.Symptomstb.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.Symptomstb.LineThickness = 3;
            this.Symptomstb.Location = new System.Drawing.Point(357, 149);
            this.Symptomstb.Margin = new System.Windows.Forms.Padding(5);
            this.Symptomstb.Name = "Symptomstb";
            this.Symptomstb.Size = new System.Drawing.Size(256, 39);
            this.Symptomstb.TabIndex = 11;
            this.Symptomstb.Text = "SYMPTOMS";
            this.Symptomstb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Diagnosistb
            // 
            this.Diagnosistb.BackColor = System.Drawing.SystemColors.Control;
            this.Diagnosistb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Diagnosistb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Diagnosistb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Diagnosistb.HintForeColor = System.Drawing.Color.Empty;
            this.Diagnosistb.HintText = "";
            this.Diagnosistb.isPassword = false;
            this.Diagnosistb.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.Diagnosistb.LineIdleColor = System.Drawing.Color.Gray;
            this.Diagnosistb.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.Diagnosistb.LineThickness = 3;
            this.Diagnosistb.Location = new System.Drawing.Point(357, 199);
            this.Diagnosistb.Margin = new System.Windows.Forms.Padding(5);
            this.Diagnosistb.Name = "Diagnosistb";
            this.Diagnosistb.Size = new System.Drawing.Size(256, 39);
            this.Diagnosistb.TabIndex = 12;
            this.Diagnosistb.Text = "DIAGNOSIS";
            this.Diagnosistb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Diagnosistb.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox4_OnValueChanged);
            // 
            // Medicinestb
            // 
            this.Medicinestb.BackColor = System.Drawing.SystemColors.Control;
            this.Medicinestb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Medicinestb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Medicinestb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Medicinestb.HintForeColor = System.Drawing.Color.Empty;
            this.Medicinestb.HintText = "";
            this.Medicinestb.isPassword = false;
            this.Medicinestb.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.Medicinestb.LineIdleColor = System.Drawing.Color.Gray;
            this.Medicinestb.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.Medicinestb.LineThickness = 3;
            this.Medicinestb.Location = new System.Drawing.Point(357, 249);
            this.Medicinestb.Margin = new System.Windows.Forms.Padding(5);
            this.Medicinestb.Name = "Medicinestb";
            this.Medicinestb.Size = new System.Drawing.Size(256, 39);
            this.Medicinestb.TabIndex = 13;
            this.Medicinestb.Text = "MEDICINES";
            this.Medicinestb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LawnGreen;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(141, 311);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 52);
            this.button1.TabIndex = 15;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LawnGreen;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Location = new System.Drawing.Point(271, 311);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 52);
            this.button2.TabIndex = 16;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LawnGreen;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button3.Location = new System.Drawing.Point(400, 311);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 52);
            this.button3.TabIndex = 17;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LawnGreen;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button4.Location = new System.Drawing.Point(271, 374);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 52);
            this.button4.TabIndex = 18;
            this.button4.Text = "Home";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(599, 486);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 29);
            this.label3.TabIndex = 20;
            this.label3.Text = "DIAGNOSIS LIST";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(259, 17);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "DIAGNOSIS SUMMARY";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.Diagnosislbl);
            this.panel2.Controls.Add(this.Medicineslbl);
            this.panel2.Controls.Add(this.Symptomslbl);
            this.panel2.Controls.Add(this.Patientnamelbl);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(667, 132);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(693, 330);
            this.panel2.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkRed;
            this.label11.Location = new System.Drawing.Point(281, 288);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 22);
            this.label11.TabIndex = 10;
            this.label11.Text = "BYCODESPACE";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkRed;
            this.label10.Location = new System.Drawing.Point(216, 242);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(250, 22);
            this.label10.TabIndex = 9;
            this.label10.Text = "HOSPITAL MANAGEMENT SYSTEM";
            // 
            // Diagnosislbl
            // 
            this.Diagnosislbl.AutoSize = true;
            this.Diagnosislbl.BackColor = System.Drawing.Color.Transparent;
            this.Diagnosislbl.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Diagnosislbl.ForeColor = System.Drawing.Color.DimGray;
            this.Diagnosislbl.Location = new System.Drawing.Point(476, 100);
            this.Diagnosislbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Diagnosislbl.Name = "Diagnosislbl";
            this.Diagnosislbl.Size = new System.Drawing.Size(88, 22);
            this.Diagnosislbl.TabIndex = 7;
            this.Diagnosislbl.Text = "DIAGNOSIS";
            // 
            // Medicineslbl
            // 
            this.Medicineslbl.AutoSize = true;
            this.Medicineslbl.BackColor = System.Drawing.Color.Transparent;
            this.Medicineslbl.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Medicineslbl.ForeColor = System.Drawing.Color.DimGray;
            this.Medicineslbl.Location = new System.Drawing.Point(476, 180);
            this.Medicineslbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Medicineslbl.Name = "Medicineslbl";
            this.Medicineslbl.Size = new System.Drawing.Size(88, 22);
            this.Medicineslbl.TabIndex = 6;
            this.Medicineslbl.Text = "MEDICINES";
            this.Medicineslbl.Click += new System.EventHandler(this.label7_Click);
            // 
            // Symptomslbl
            // 
            this.Symptomslbl.AutoSize = true;
            this.Symptomslbl.BackColor = System.Drawing.Color.Transparent;
            this.Symptomslbl.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Symptomslbl.ForeColor = System.Drawing.Color.DimGray;
            this.Symptomslbl.Location = new System.Drawing.Point(117, 176);
            this.Symptomslbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Symptomslbl.Name = "Symptomslbl";
            this.Symptomslbl.Size = new System.Drawing.Size(91, 22);
            this.Symptomslbl.TabIndex = 5;
            this.Symptomslbl.Text = "SYMPTOMS";
            // 
            // Patientnamelbl
            // 
            this.Patientnamelbl.AutoSize = true;
            this.Patientnamelbl.BackColor = System.Drawing.Color.Transparent;
            this.Patientnamelbl.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Patientnamelbl.ForeColor = System.Drawing.Color.DimGray;
            this.Patientnamelbl.Location = new System.Drawing.Point(117, 100);
            this.Patientnamelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Patientnamelbl.Name = "Patientnamelbl";
            this.Patientnamelbl.Size = new System.Drawing.Size(112, 22);
            this.Patientnamelbl.TabIndex = 4;
            this.Patientnamelbl.Text = "PATIENTNAME";
            // 
            // DiagnosisGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DiagnosisGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DiagnosisGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DiagnosisGV.BackgroundColor = System.Drawing.Color.White;
            this.DiagnosisGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DiagnosisGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DiagnosisGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DiagnosisGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DiagnosisGV.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DiagnosisGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.DiagnosisGV.EnableHeadersVisualStyles = false;
            this.DiagnosisGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DiagnosisGV.Location = new System.Drawing.Point(39, 514);
            this.DiagnosisGV.Margin = new System.Windows.Forms.Padding(4);
            this.DiagnosisGV.Name = "DiagnosisGV";
            this.DiagnosisGV.RowHeadersVisible = false;
            this.DiagnosisGV.RowHeadersWidth = 51;
            this.DiagnosisGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DiagnosisGV.Size = new System.Drawing.Size(1321, 171);
            this.DiagnosisGV.TabIndex = 22;
            this.DiagnosisGV.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.DiagnosisGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DiagnosisGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DiagnosisGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DiagnosisGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DiagnosisGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DiagnosisGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DiagnosisGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DiagnosisGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Blue;
            this.DiagnosisGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DiagnosisGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.DiagnosisGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DiagnosisGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DiagnosisGV.ThemeStyle.HeaderStyle.Height = 25;
            this.DiagnosisGV.ThemeStyle.ReadOnly = false;
            this.DiagnosisGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DiagnosisGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DiagnosisGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DiagnosisGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.DarkRed;
            this.DiagnosisGV.ThemeStyle.RowsStyle.Height = 22;
            this.DiagnosisGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DiagnosisGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DiagnosisGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DiagnosisGV_CellContentClick);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LawnGreen;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button5.Location = new System.Drawing.Point(948, 469);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(121, 38);
            this.button5.TabIndex = 23;
            this.button5.Text = "Print";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // DiagnosisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1393, 700);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.DiagnosisGV);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Medicinestb);
            this.Controls.Add(this.Diagnosistb);
            this.Controls.Add(this.Symptomstb);
            this.Controls.Add(this.Patientidcb);
            this.Controls.Add(this.Patienttb);
            this.Controls.Add(this.Diagid);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DiagnosisForm";
            this.Text = "DiagnosisForm";
            this.Load += new System.EventHandler(this.DiagnosisForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiagnosisGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Diagid;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Patienttb;
        private System.Windows.Forms.ComboBox Patientidcb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Symptomstb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Diagnosistb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Medicinestb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label Diagnosislbl;
        private System.Windows.Forms.Label Medicineslbl;
        private System.Windows.Forms.Label Symptomslbl;
        private System.Windows.Forms.Label Patientnamelbl;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaDataGridView DiagnosisGV;
        private System.Windows.Forms.Button button5;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label label5;
    }
}