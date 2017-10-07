namespace HarasaraSystem
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.Employees = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Leave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Inventory = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Transport = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Request = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton6 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SystemAdministration = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Production = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.Transport);
            this.bunifuGradientPanel1.Controls.Add(this.Inventory);
            this.bunifuGradientPanel1.Controls.Add(this.Leave);
            this.bunifuGradientPanel1.Controls.Add(this.Production);
            this.bunifuGradientPanel1.Controls.Add(this.SystemAdministration);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuFlatButton6);
            this.bunifuGradientPanel1.Controls.Add(this.Request);
            this.bunifuGradientPanel1.Controls.Add(this.Employees);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.LightGray;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.MediumSeaGreen;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.MediumAquamarine;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(947, 491);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // Employees
            // 
            this.Employees.Activecolor = System.Drawing.Color.MediumSeaGreen;
            this.Employees.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Employees.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Employees.BorderRadius = 0;
            this.Employees.ButtonText = "Employees";
            this.Employees.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Employees.Iconcolor = System.Drawing.Color.Transparent;
            this.Employees.Iconimage = ((System.Drawing.Image)(resources.GetObject("Employees.Iconimage")));
            this.Employees.Iconimage_right = null;
            this.Employees.Iconimage_right_Selected = null;
            this.Employees.Iconimage_Selected = null;
            this.Employees.IconZoom = 80D;
            this.Employees.IsTab = false;
            this.Employees.Location = new System.Drawing.Point(33, 163);
            this.Employees.Name = "Employees";
            this.Employees.Normalcolor = System.Drawing.Color.MediumSeaGreen;
            this.Employees.OnHovercolor = System.Drawing.Color.DarkSeaGreen;
            this.Employees.OnHoverTextColor = System.Drawing.Color.White;
            this.Employees.selected = false;
            this.Employees.Size = new System.Drawing.Size(228, 73);
            this.Employees.TabIndex = 0;
            this.Employees.Textcolor = System.Drawing.Color.White;
            this.Employees.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employees.Click += new System.EventHandler(this.Employees_Click);
            // 
            // Leave
            // 
            this.Leave.Activecolor = System.Drawing.Color.MediumSeaGreen;
            this.Leave.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Leave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Leave.BorderRadius = 0;
            this.Leave.ButtonText = "Financial";
            this.Leave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Leave.Iconcolor = System.Drawing.Color.Transparent;
            this.Leave.Iconimage = ((System.Drawing.Image)(resources.GetObject("Leave.Iconimage")));
            this.Leave.Iconimage_right = null;
            this.Leave.Iconimage_right_Selected = null;
            this.Leave.Iconimage_Selected = null;
            this.Leave.IconZoom = 90D;
            this.Leave.IsTab = false;
            this.Leave.Location = new System.Drawing.Point(33, 242);
            this.Leave.Name = "Leave";
            this.Leave.Normalcolor = System.Drawing.Color.MediumSeaGreen;
            this.Leave.OnHovercolor = System.Drawing.Color.DarkSeaGreen;
            this.Leave.OnHoverTextColor = System.Drawing.Color.White;
            this.Leave.selected = false;
            this.Leave.Size = new System.Drawing.Size(228, 73);
            this.Leave.TabIndex = 0;
            this.Leave.Textcolor = System.Drawing.Color.White;
            this.Leave.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Leave.Click += new System.EventHandler(this.Leave_Click);
            // 
            // Inventory
            // 
            this.Inventory.Activecolor = System.Drawing.Color.MediumSeaGreen;
            this.Inventory.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Inventory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Inventory.BorderRadius = 0;
            this.Inventory.ButtonText = "Inventory";
            this.Inventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Inventory.Iconcolor = System.Drawing.Color.Transparent;
            this.Inventory.Iconimage = ((System.Drawing.Image)(resources.GetObject("Inventory.Iconimage")));
            this.Inventory.Iconimage_right = null;
            this.Inventory.Iconimage_right_Selected = null;
            this.Inventory.Iconimage_Selected = null;
            this.Inventory.IconZoom = 80D;
            this.Inventory.IsTab = false;
            this.Inventory.Location = new System.Drawing.Point(33, 321);
            this.Inventory.Name = "Inventory";
            this.Inventory.Normalcolor = System.Drawing.Color.MediumSeaGreen;
            this.Inventory.OnHovercolor = System.Drawing.Color.DarkSeaGreen;
            this.Inventory.OnHoverTextColor = System.Drawing.Color.White;
            this.Inventory.selected = false;
            this.Inventory.Size = new System.Drawing.Size(228, 73);
            this.Inventory.TabIndex = 0;
            this.Inventory.Textcolor = System.Drawing.Color.White;
            this.Inventory.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inventory.Click += new System.EventHandler(this.Inventory_Click);
            // 
            // Transport
            // 
            this.Transport.Activecolor = System.Drawing.Color.MediumSeaGreen;
            this.Transport.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Transport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Transport.BorderRadius = 0;
            this.Transport.ButtonText = "Transport";
            this.Transport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Transport.Iconcolor = System.Drawing.Color.Transparent;
            this.Transport.Iconimage = ((System.Drawing.Image)(resources.GetObject("Transport.Iconimage")));
            this.Transport.Iconimage_right = null;
            this.Transport.Iconimage_right_Selected = null;
            this.Transport.Iconimage_Selected = null;
            this.Transport.IconZoom = 90D;
            this.Transport.IsTab = false;
            this.Transport.Location = new System.Drawing.Point(33, 400);
            this.Transport.Name = "Transport";
            this.Transport.Normalcolor = System.Drawing.Color.MediumSeaGreen;
            this.Transport.OnHovercolor = System.Drawing.Color.DarkSeaGreen;
            this.Transport.OnHoverTextColor = System.Drawing.Color.White;
            this.Transport.selected = false;
            this.Transport.Size = new System.Drawing.Size(228, 73);
            this.Transport.TabIndex = 0;
            this.Transport.Textcolor = System.Drawing.Color.White;
            this.Transport.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Transport.Click += new System.EventHandler(this.Transport_Click);
            // 
            // Request
            // 
            this.Request.Activecolor = System.Drawing.Color.MediumSeaGreen;
            this.Request.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Request.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Request.BorderRadius = 0;
            this.Request.ButtonText = "Leave Request";
            this.Request.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Request.Iconcolor = System.Drawing.Color.Transparent;
            this.Request.Iconimage = ((System.Drawing.Image)(resources.GetObject("Request.Iconimage")));
            this.Request.Iconimage_right = null;
            this.Request.Iconimage_right_Selected = null;
            this.Request.Iconimage_Selected = null;
            this.Request.IconZoom = 90D;
            this.Request.IsTab = false;
            this.Request.Location = new System.Drawing.Point(693, 163);
            this.Request.Name = "Request";
            this.Request.Normalcolor = System.Drawing.Color.MediumSeaGreen;
            this.Request.OnHovercolor = System.Drawing.Color.DarkSeaGreen;
            this.Request.OnHoverTextColor = System.Drawing.Color.White;
            this.Request.selected = false;
            this.Request.Size = new System.Drawing.Size(228, 73);
            this.Request.TabIndex = 0;
            this.Request.Textcolor = System.Drawing.Color.White;
            this.Request.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Request.Click += new System.EventHandler(this.Request_Click);
            // 
            // bunifuFlatButton6
            // 
            this.bunifuFlatButton6.Activecolor = System.Drawing.Color.MediumSeaGreen;
            this.bunifuFlatButton6.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.bunifuFlatButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton6.BorderRadius = 0;
            this.bunifuFlatButton6.ButtonText = "Sales and Purchasings";
            this.bunifuFlatButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton6.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton6.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton6.Iconimage")));
            this.bunifuFlatButton6.Iconimage_right = null;
            this.bunifuFlatButton6.Iconimage_right_Selected = null;
            this.bunifuFlatButton6.Iconimage_Selected = null;
            this.bunifuFlatButton6.IconZoom = 90D;
            this.bunifuFlatButton6.IsTab = false;
            this.bunifuFlatButton6.Location = new System.Drawing.Point(693, 242);
            this.bunifuFlatButton6.Name = "bunifuFlatButton6";
            this.bunifuFlatButton6.Normalcolor = System.Drawing.Color.MediumSeaGreen;
            this.bunifuFlatButton6.OnHovercolor = System.Drawing.Color.DarkSeaGreen;
            this.bunifuFlatButton6.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton6.selected = false;
            this.bunifuFlatButton6.Size = new System.Drawing.Size(228, 73);
            this.bunifuFlatButton6.TabIndex = 0;
            this.bunifuFlatButton6.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton6.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton6.Click += new System.EventHandler(this.bunifuFlatButton6_Click);
            // 
            // SystemAdministration
            // 
            this.SystemAdministration.Activecolor = System.Drawing.Color.MediumSeaGreen;
            this.SystemAdministration.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.SystemAdministration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SystemAdministration.BorderRadius = 0;
            this.SystemAdministration.ButtonText = "System Administration";
            this.SystemAdministration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SystemAdministration.Iconcolor = System.Drawing.Color.Transparent;
            this.SystemAdministration.Iconimage = ((System.Drawing.Image)(resources.GetObject("SystemAdministration.Iconimage")));
            this.SystemAdministration.Iconimage_right = null;
            this.SystemAdministration.Iconimage_right_Selected = null;
            this.SystemAdministration.Iconimage_Selected = null;
            this.SystemAdministration.IconZoom = 90D;
            this.SystemAdministration.IsTab = false;
            this.SystemAdministration.Location = new System.Drawing.Point(693, 406);
            this.SystemAdministration.Name = "SystemAdministration";
            this.SystemAdministration.Normalcolor = System.Drawing.Color.MediumSeaGreen;
            this.SystemAdministration.OnHovercolor = System.Drawing.Color.DarkSeaGreen;
            this.SystemAdministration.OnHoverTextColor = System.Drawing.Color.White;
            this.SystemAdministration.selected = false;
            this.SystemAdministration.Size = new System.Drawing.Size(228, 73);
            this.SystemAdministration.TabIndex = 0;
            this.SystemAdministration.Textcolor = System.Drawing.Color.White;
            this.SystemAdministration.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SystemAdministration.Click += new System.EventHandler(this.SystemAdministration_Click);
            // 
            // Production
            // 
            this.Production.Activecolor = System.Drawing.Color.MediumSeaGreen;
            this.Production.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Production.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Production.BorderRadius = 0;
            this.Production.ButtonText = "Production";
            this.Production.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Production.Iconcolor = System.Drawing.Color.Transparent;
            this.Production.Iconimage = ((System.Drawing.Image)(resources.GetObject("Production.Iconimage")));
            this.Production.Iconimage_right = null;
            this.Production.Iconimage_right_Selected = null;
            this.Production.Iconimage_Selected = null;
            this.Production.IconZoom = 90D;
            this.Production.IsTab = false;
            this.Production.Location = new System.Drawing.Point(693, 321);
            this.Production.Name = "Production";
            this.Production.Normalcolor = System.Drawing.Color.MediumSeaGreen;
            this.Production.OnHovercolor = System.Drawing.Color.DarkSeaGreen;
            this.Production.OnHoverTextColor = System.Drawing.Color.White;
            this.Production.selected = false;
            this.Production.Size = new System.Drawing.Size(228, 73);
            this.Production.TabIndex = 0;
            this.Production.Textcolor = System.Drawing.Color.White;
            this.Production.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Production.Click += new System.EventHandler(this.Production_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(947, 491);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Harasara Industries";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuFlatButton Employees;
        private Bunifu.Framework.UI.BunifuFlatButton Transport;
        private Bunifu.Framework.UI.BunifuFlatButton Inventory;
        private Bunifu.Framework.UI.BunifuFlatButton Leave;
        private Bunifu.Framework.UI.BunifuFlatButton SystemAdministration;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton6;
        private Bunifu.Framework.UI.BunifuFlatButton Request;
        private Bunifu.Framework.UI.BunifuFlatButton Production;


    }
}

