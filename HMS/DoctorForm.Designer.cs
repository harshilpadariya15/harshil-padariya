
namespace HMS
{
    partial class DoctorForm
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
            this.Docid = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Docname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Docexp = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Docpass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.DoctorGV = new Guna.UI.WinForms.GunaDataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorGV)).BeginInit();
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
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(1349, 22);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 30);
            this.label5.TabIndex = 12;
            this.label5.Text = "X";
            this.label5.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(624, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "DOCTOR";
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
            // Docid
            // 
            this.Docid.BackColor = System.Drawing.SystemColors.Control;
            this.Docid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Docid.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Docid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Docid.HintForeColor = System.Drawing.Color.Empty;
            this.Docid.HintText = "";
            this.Docid.isPassword = false;
            this.Docid.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.Docid.LineIdleColor = System.Drawing.Color.Gray;
            this.Docid.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.Docid.LineThickness = 3;
            this.Docid.Location = new System.Drawing.Point(32, 185);
            this.Docid.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Docid.Name = "Docid";
            this.Docid.Size = new System.Drawing.Size(256, 39);
            this.Docid.TabIndex = 1;
            this.Docid.Text = "DOCTORID";
            this.Docid.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Docid.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox1_OnValueChanged);
            // 
            // Docname
            // 
            this.Docname.BackColor = System.Drawing.SystemColors.Control;
            this.Docname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Docname.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Docname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Docname.HintForeColor = System.Drawing.Color.Empty;
            this.Docname.HintText = "";
            this.Docname.isPassword = false;
            this.Docname.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.Docname.LineIdleColor = System.Drawing.Color.Gray;
            this.Docname.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.Docname.LineThickness = 3;
            this.Docname.Location = new System.Drawing.Point(32, 251);
            this.Docname.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Docname.Name = "Docname";
            this.Docname.Size = new System.Drawing.Size(256, 41);
            this.Docname.TabIndex = 2;
            this.Docname.Text = "DOCTORNAME";
            this.Docname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Docname.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox2_OnValueChanged);
            // 
            // Docexp
            // 
            this.Docexp.BackColor = System.Drawing.SystemColors.Control;
            this.Docexp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Docexp.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Docexp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Docexp.HintForeColor = System.Drawing.Color.Empty;
            this.Docexp.HintText = "";
            this.Docexp.isPassword = false;
            this.Docexp.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.Docexp.LineIdleColor = System.Drawing.Color.Gray;
            this.Docexp.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.Docexp.LineThickness = 3;
            this.Docexp.Location = new System.Drawing.Point(32, 315);
            this.Docexp.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Docexp.Name = "Docexp";
            this.Docexp.Size = new System.Drawing.Size(256, 44);
            this.Docexp.TabIndex = 3;
            this.Docexp.Text = "YEAROFFEXPERIENCE";
            this.Docexp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Docexp.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox3_OnValueChanged);
            // 
            // Docpass
            // 
            this.Docpass.BackColor = System.Drawing.SystemColors.Control;
            this.Docpass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Docpass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Docpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Docpass.HintForeColor = System.Drawing.Color.Empty;
            this.Docpass.HintText = "";
            this.Docpass.isPassword = false;
            this.Docpass.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.Docpass.LineIdleColor = System.Drawing.Color.Gray;
            this.Docpass.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.Docpass.LineThickness = 3;
            this.Docpass.Location = new System.Drawing.Point(32, 384);
            this.Docpass.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Docpass.Name = "Docpass";
            this.Docpass.Size = new System.Drawing.Size(256, 43);
            this.Docpass.TabIndex = 4;
            this.Docpass.Text = "PASSWORD";
            this.Docpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // DoctorGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DoctorGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DoctorGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DoctorGV.BackgroundColor = System.Drawing.Color.White;
            this.DoctorGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DoctorGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DoctorGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DoctorGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DoctorGV.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DoctorGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.DoctorGV.EnableHeadersVisualStyles = false;
            this.DoctorGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DoctorGV.Location = new System.Drawing.Point(481, 164);
            this.DoctorGV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DoctorGV.Name = "DoctorGV";
            this.DoctorGV.RowHeadersVisible = false;
            this.DoctorGV.RowHeadersWidth = 51;
            this.DoctorGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DoctorGV.Size = new System.Drawing.Size(841, 510);
            this.DoctorGV.TabIndex = 5;
            this.DoctorGV.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.DoctorGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DoctorGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DoctorGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DoctorGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DoctorGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DoctorGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DoctorGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DoctorGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Blue;
            this.DoctorGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DoctorGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.DoctorGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DoctorGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DoctorGV.ThemeStyle.HeaderStyle.Height = 25;
            this.DoctorGV.ThemeStyle.ReadOnly = false;
            this.DoctorGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DoctorGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DoctorGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DoctorGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DoctorGV.ThemeStyle.RowsStyle.Height = 22;
            this.DoctorGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DoctorGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DoctorGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gunaDataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LawnGreen;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(35, 567);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 52);
            this.button1.TabIndex = 6;
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
            this.button2.Location = new System.Drawing.Point(185, 567);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 52);
            this.button2.TabIndex = 7;
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
            this.button3.Location = new System.Drawing.Point(335, 567);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 52);
            this.button3.TabIndex = 8;
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
            this.button4.Location = new System.Drawing.Point(185, 641);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 52);
            this.button4.TabIndex = 9;
            this.button4.Text = "HOME";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // DoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1393, 700);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DoctorGV);
            this.Controls.Add(this.Docpass);
            this.Controls.Add(this.Docexp);
            this.Controls.Add(this.Docname);
            this.Controls.Add(this.Docid);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DoctorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoctorForm";
            this.Load += new System.EventHandler(this.DoctorForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Docid;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Docname;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Docexp;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Docpass;
        private Guna.UI.WinForms.GunaDataGridView DoctorGV;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
    }
}