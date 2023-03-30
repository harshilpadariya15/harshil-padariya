
namespace HMS
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Docnametb = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.Passtb = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LawnGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 97);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "HOSPITAL MANAGEMENT SYSTEM";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LawnGreen;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(40, 359);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(320, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Docnametb
            // 
            this.Docnametb.BorderColorFocused = System.Drawing.Color.BlueViolet;
            this.Docnametb.BorderColorIdle = System.Drawing.Color.Blue;
            this.Docnametb.BorderColorMouseHover = System.Drawing.Color.BlueViolet;
            this.Docnametb.BorderThickness = 3;
            this.Docnametb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Docnametb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Docnametb.ForeColor = System.Drawing.Color.Blue;
            this.Docnametb.isPassword = false;
            this.Docnametb.Location = new System.Drawing.Point(39, 155);
            this.Docnametb.Margin = new System.Windows.Forms.Padding(5);
            this.Docnametb.Name = "Docnametb";
            this.Docnametb.Size = new System.Drawing.Size(321, 57);
            this.Docnametb.TabIndex = 3;
            this.Docnametb.Text = "DocName";
            this.Docnametb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Docnametb.OnValueChanged += new System.EventHandler(this.Docnametb_OnValueChanged);
            // 
            // Passtb
            // 
            this.Passtb.BorderColorFocused = System.Drawing.Color.BlueViolet;
            this.Passtb.BorderColorIdle = System.Drawing.Color.Blue;
            this.Passtb.BorderColorMouseHover = System.Drawing.Color.BlueViolet;
            this.Passtb.BorderThickness = 3;
            this.Passtb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Passtb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Passtb.ForeColor = System.Drawing.Color.Blue;
            this.Passtb.isPassword = true;
            this.Passtb.Location = new System.Drawing.Point(40, 236);
            this.Passtb.Margin = new System.Windows.Forms.Padding(5);
            this.Passtb.Name = "Passtb";
            this.Passtb.Size = new System.Drawing.Size(321, 57);
            this.Passtb.TabIndex = 4;
            this.Passtb.Text = "DocPassword";
            this.Passtb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Passtb.OnValueChanged += new System.EventHandler(this.Passtb_OnValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(160, 449);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Clear";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(401, 500);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Passtb);
            this.Controls.Add(this.Docnametb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuMetroTextbox Docnametb;
        private Bunifu.Framework.UI.BunifuMetroTextbox Passtb;
        private System.Windows.Forms.Label label2;
    }
}

