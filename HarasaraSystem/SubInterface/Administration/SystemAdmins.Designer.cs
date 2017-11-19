namespace HarasaraSystem.SubInterface.Administration
{
    partial class SystemAdmins
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Add1 = new System.Windows.Forms.Button();
            this.position = new System.Windows.Forms.ComboBox();
            this.contactnumber = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nam = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.Add1);
            this.panel1.Controls.Add(this.position);
            this.panel1.Controls.Add(this.contactnumber);
            this.panel1.Controls.Add(this.email);
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.username);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(148, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(926, 254);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(930, 194);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(89, 34);
            this.button4.TabIndex = 4;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(714, 204);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 34);
            this.button3.TabIndex = 4;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(578, 204);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 34);
            this.button2.TabIndex = 4;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Add1
            // 
            this.Add1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add1.Location = new System.Drawing.Point(443, 204);
            this.Add1.Name = "Add1";
            this.Add1.Size = new System.Drawing.Size(89, 34);
            this.Add1.TabIndex = 4;
            this.Add1.Text = "Add";
            this.Add1.UseVisualStyleBackColor = true;
            this.Add1.Click += new System.EventHandler(this.Add1_Click);
            // 
            // position
            // 
            this.position.FormattingEnabled = true;
            this.position.Items.AddRange(new object[] {
            "Sales",
            "Employees",
            "Inventory",
            "Accountant",
            "Transport",
            "Adminstration",
            "Manufacture",
            "Finance"});
            this.position.Location = new System.Drawing.Point(612, 66);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(218, 21);
            this.position.TabIndex = 3;
            this.position.SelectedIndexChanged += new System.EventHandler(this.position_SelectedIndexChanged);
            // 
            // contactnumber
            // 
            this.contactnumber.Location = new System.Drawing.Point(612, 136);
            this.contactnumber.Name = "contactnumber";
            this.contactnumber.Size = new System.Drawing.Size(218, 20);
            this.contactnumber.TabIndex = 2;
            this.contactnumber.TextChanged += new System.EventHandler(this.contactnumber_TextChanged);
            this.contactnumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.contactnumber_KeyPress);
            this.contactnumber.Leave += new System.EventHandler(this.contactnumber_Leave);
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(612, 104);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(218, 20);
            this.email.TabIndex = 2;
            this.email.TextChanged += new System.EventHandler(this.email_TextChanged);
            this.email.Leave += new System.EventHandler(this.email_Leave);
            this.email.Validated += new System.EventHandler(this.email_Validated);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(169, 138);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(218, 20);
            this.password.TabIndex = 2;
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(169, 102);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(218, 20);
            this.username.TabIndex = 2;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(169, 68);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(218, 20);
            this.name.TabIndex = 2;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(449, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "Position";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(449, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 19);
            this.label7.TabIndex = 1;
            this.label7.Text = "Contact Number";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(449, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Email";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "System Admins";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(148, 328);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(902, 256);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // nam
            // 
            this.nam.Location = new System.Drawing.Point(172, 289);
            this.nam.Name = "nam";
            this.nam.Size = new System.Drawing.Size(106, 20);
            this.nam.TabIndex = 6;
            this.nam.TextChanged += new System.EventHandler(this.nam_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(294, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(127, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 19);
            this.label8.TabIndex = 5;
            this.label8.Text = "Name";
            // 
            // SystemAdmins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nam);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "SystemAdmins";
            this.Size = new System.Drawing.Size(1140, 614);
            this.Load += new System.EventHandler(this.SystemAdmins_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Add1;
        private System.Windows.Forms.ComboBox position;
        private System.Windows.Forms.TextBox contactnumber;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox nam;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
    }
}
