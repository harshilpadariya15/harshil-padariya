
namespace HMS
{
    partial class PatientForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Patid = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Patphone = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Patad = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Patname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Patage = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Gendercb = new System.Windows.Forms.ComboBox();
            this.Bloodcb = new System.Windows.Forms.ComboBox();
            this.Majortb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.gunaDataGridView1 = new Guna.UI.WinForms.GunaDataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).BeginInit();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1393, 124);
            this.panel1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(1349, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 30);
            this.label5.TabIndex = 12;
            this.label5.Text = "X";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(624, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "PATIENT";
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
            // 
            // Patid
            // 
            this.Patid.BackColor = System.Drawing.SystemColors.Control;
            this.Patid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Patid.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Patid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Patid.HintForeColor = System.Drawing.Color.Empty;
            this.Patid.HintText = "";
            this.Patid.isPassword = false;
            this.Patid.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.Patid.LineIdleColor = System.Drawing.Color.Gray;
            this.Patid.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.Patid.LineThickness = 3;
            this.Patid.Location = new System.Drawing.Point(36, 144);
            this.Patid.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Patid.Name = "Patid";
            this.Patid.Size = new System.Drawing.Size(256, 39);
            this.Patid.TabIndex = 2;
            this.Patid.Text = " PATIENTID";
            this.Patid.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Patid.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox1_OnValueChanged);
            // 
            // Patphone
            // 
            this.Patphone.BackColor = System.Drawing.SystemColors.Control;
            this.Patphone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Patphone.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Patphone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Patphone.HintForeColor = System.Drawing.Color.Empty;
            this.Patphone.HintText = "";
            this.Patphone.isPassword = false;
            this.Patphone.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.Patphone.LineIdleColor = System.Drawing.Color.Gray;
            this.Patphone.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.Patphone.LineThickness = 3;
            this.Patphone.Location = new System.Drawing.Point(36, 298);
            this.Patphone.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Patphone.Name = "Patphone";
            this.Patphone.Size = new System.Drawing.Size(256, 43);
            this.Patphone.TabIndex = 7;
            this.Patphone.Text = "PATIENTPHONE";
            this.Patphone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Patphone.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox4_OnValueChanged);
            // 
            // Patad
            // 
            this.Patad.BackColor = System.Drawing.SystemColors.Control;
            this.Patad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Patad.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Patad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Patad.HintForeColor = System.Drawing.Color.Empty;
            this.Patad.HintText = "";
            this.Patad.isPassword = false;
            this.Patad.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.Patad.LineIdleColor = System.Drawing.Color.Gray;
            this.Patad.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.Patad.LineThickness = 3;
            this.Patad.Location = new System.Drawing.Point(36, 244);
            this.Patad.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Patad.Name = "Patad";
            this.Patad.Size = new System.Drawing.Size(256, 44);
            this.Patad.TabIndex = 6;
            this.Patad.Text = "PATIENTADDRESS";
            this.Patad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Patad.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox3_OnValueChanged);
            // 
            // Patname
            // 
            this.Patname.BackColor = System.Drawing.SystemColors.Control;
            this.Patname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Patname.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Patname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Patname.HintForeColor = System.Drawing.Color.Empty;
            this.Patname.HintText = "";
            this.Patname.isPassword = false;
            this.Patname.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.Patname.LineIdleColor = System.Drawing.Color.Gray;
            this.Patname.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.Patname.LineThickness = 3;
            this.Patname.Location = new System.Drawing.Point(36, 193);
            this.Patname.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Patname.Name = "Patname";
            this.Patname.Size = new System.Drawing.Size(256, 41);
            this.Patname.TabIndex = 5;
            this.Patname.Text = "PATIENTNAME";
            this.Patname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Patname.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox2_OnValueChanged);
            // 
            // Patage
            // 
            this.Patage.BackColor = System.Drawing.SystemColors.Control;
            this.Patage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Patage.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Patage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Patage.HintForeColor = System.Drawing.Color.Empty;
            this.Patage.HintText = "";
            this.Patage.isPassword = false;
            this.Patage.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.Patage.LineIdleColor = System.Drawing.Color.Gray;
            this.Patage.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.Patage.LineThickness = 3;
            this.Patage.Location = new System.Drawing.Point(36, 351);
            this.Patage.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Patage.Name = "Patage";
            this.Patage.Size = new System.Drawing.Size(256, 43);
            this.Patage.TabIndex = 8;
            this.Patage.Text = "PATIENTAGE";
            this.Patage.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Patage.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox5_OnValueChanged);
            // 
            // Gendercb
            // 
            this.Gendercb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Gendercb.FormattingEnabled = true;
            this.Gendercb.Items.AddRange(new object[] {
            "MALE",
            "FEMALE"});
            this.Gendercb.Location = new System.Drawing.Point(36, 402);
            this.Gendercb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Gendercb.Name = "Gendercb";
            this.Gendercb.Size = new System.Drawing.Size(255, 24);
            this.Gendercb.TabIndex = 9;
            this.Gendercb.Text = "GENDER";
            this.Gendercb.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Bloodcb
            // 
            this.Bloodcb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Bloodcb.FormattingEnabled = true;
            this.Bloodcb.Items.AddRange(new object[] {
            "A+",
            "O+",
            "B+",
            "AB+",
            "A-",
            "O-",
            "B-",
            "AB-"});
            this.Bloodcb.Location = new System.Drawing.Point(36, 436);
            this.Bloodcb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Bloodcb.Name = "Bloodcb";
            this.Bloodcb.Size = new System.Drawing.Size(255, 24);
            this.Bloodcb.TabIndex = 10;
            this.Bloodcb.Text = "BLOODGROUP";
            this.Bloodcb.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // Majortb
            // 
            this.Majortb.BackColor = System.Drawing.SystemColors.Control;
            this.Majortb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Majortb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Majortb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Majortb.HintForeColor = System.Drawing.Color.Empty;
            this.Majortb.HintText = "";
            this.Majortb.isPassword = false;
            this.Majortb.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.Majortb.LineIdleColor = System.Drawing.Color.Gray;
            this.Majortb.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.Majortb.LineThickness = 3;
            this.Majortb.Location = new System.Drawing.Point(36, 470);
            this.Majortb.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Majortb.Name = "Majortb";
            this.Majortb.Size = new System.Drawing.Size(256, 43);
            this.Majortb.TabIndex = 11;
            this.Majortb.Text = "MAJORDISEASE";
            this.Majortb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Majortb.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox6_OnValueChanged);
            // 
            // gunaDataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gunaDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gunaDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.gunaDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gunaDataGridView1.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gunaDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.gunaDataGridView1.EnableHeadersVisualStyles = false;
            this.gunaDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.Location = new System.Drawing.Point(301, 160);
            this.gunaDataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gunaDataGridView1.Name = "gunaDataGridView1";
            this.gunaDataGridView1.RowHeadersVisible = false;
            this.gunaDataGridView1.RowHeadersWidth = 51;
            this.gunaDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunaDataGridView1.Size = new System.Drawing.Size(1076, 526);
            this.gunaDataGridView1.TabIndex = 12;
            this.gunaDataGridView1.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Height = 4;
            this.gunaDataGridView1.ThemeStyle.ReadOnly = false;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gunaDataGridView1_CellContentClick);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LawnGreen;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button3.Location = new System.Drawing.Point(216, 543);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 52);
            this.button3.TabIndex = 16;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LawnGreen;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Location = new System.Drawing.Point(120, 543);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 52);
            this.button2.TabIndex = 15;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LawnGreen;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(37, 543);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 52);
            this.button1.TabIndex = 14;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(796, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 29);
            this.label3.TabIndex = 18;
            this.label3.Text = "PATIENT LIST";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LawnGreen;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button4.Location = new System.Drawing.Point(105, 613);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 52);
            this.button4.TabIndex = 17;
            this.button4.Text = "Home";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // PatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1393, 700);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gunaDataGridView1);
            this.Controls.Add(this.Majortb);
            this.Controls.Add(this.Bloodcb);
            this.Controls.Add(this.Gendercb);
            this.Controls.Add(this.Patage);
            this.Controls.Add(this.Patphone);
            this.Controls.Add(this.Patad);
            this.Controls.Add(this.Patname);
            this.Controls.Add(this.Patid);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PatientForm";
            this.Text = "PatientForm";
            this.Load += new System.EventHandler(this.PatientForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Patid;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Patphone;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Patad;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Patname;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Patage;
        private System.Windows.Forms.ComboBox Gendercb;
        private System.Windows.Forms.ComboBox Bloodcb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Majortb;
        private Guna.UI.WinForms.GunaDataGridView gunaDataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
    }
}