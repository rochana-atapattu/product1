namespace HarasaraSystem.SubInterface.Production
{
    partial class OrdersUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdersUC));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bunifuThinButton1 = new WindowsFormsControlLibrary1.BunifuThinButton();
            this.bunifuThinButton2 = new WindowsFormsControlLibrary1.BunifuThinButton();
            this.bunifuThinButton3 = new WindowsFormsControlLibrary1.BunifuThinButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(220, 14);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(660, 314);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bunifuThinButton1
            // 
            this.bunifuThinButton1.BackColor = System.Drawing.Color.Honeydew;
            this.bunifuThinButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton1.BackgroundImage")));
            this.bunifuThinButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuThinButton1.ButtonText = "Get Current Orders";
            this.bunifuThinButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton1.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton1.ForeColorHoverState = System.Drawing.Color.White;
            this.bunifuThinButton1.Iconimage = null;
            this.bunifuThinButton1.IconVisible = true;
            this.bunifuThinButton1.IconZoom = 90D;
            this.bunifuThinButton1.ImageIconOverlay = false;
            this.bunifuThinButton1.Location = new System.Drawing.Point(12, 25);
            this.bunifuThinButton1.Name = "bunifuThinButton1";
            this.bunifuThinButton1.Size = new System.Drawing.Size(184, 36);
            this.bunifuThinButton1.TabIndex = 1;
            this.bunifuThinButton1.Click += new System.EventHandler(this.bunifuThinButton1_Click);
            // 
            // bunifuThinButton2
            // 
            this.bunifuThinButton2.BackColor = System.Drawing.Color.Honeydew;
            this.bunifuThinButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton2.BackgroundImage")));
            this.bunifuThinButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuThinButton2.ButtonText = "Check Availability";
            this.bunifuThinButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton2.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton2.ForeColorHoverState = System.Drawing.Color.White;
            this.bunifuThinButton2.Iconimage = null;
            this.bunifuThinButton2.IconVisible = true;
            this.bunifuThinButton2.IconZoom = 90D;
            this.bunifuThinButton2.ImageIconOverlay = false;
            this.bunifuThinButton2.Location = new System.Drawing.Point(12, 83);
            this.bunifuThinButton2.Name = "bunifuThinButton2";
            this.bunifuThinButton2.Size = new System.Drawing.Size(184, 36);
            this.bunifuThinButton2.TabIndex = 2;
            this.bunifuThinButton2.Click += new System.EventHandler(this.bunifuThinButton2_Click);
            // 
            // bunifuThinButton3
            // 
            this.bunifuThinButton3.BackColor = System.Drawing.Color.Honeydew;
            this.bunifuThinButton3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton3.BackgroundImage")));
            this.bunifuThinButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuThinButton3.ButtonText = "Add order";
            this.bunifuThinButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton3.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton3.ForeColorHoverState = System.Drawing.Color.White;
            this.bunifuThinButton3.Iconimage = null;
            this.bunifuThinButton3.IconVisible = true;
            this.bunifuThinButton3.IconZoom = 90D;
            this.bunifuThinButton3.ImageIconOverlay = false;
            this.bunifuThinButton3.Location = new System.Drawing.Point(12, 143);
            this.bunifuThinButton3.Name = "bunifuThinButton3";
            this.bunifuThinButton3.Size = new System.Drawing.Size(184, 36);
            this.bunifuThinButton3.TabIndex = 3;
            this.bunifuThinButton3.Click += new System.EventHandler(this.bunifuThinButton3_Click);
            // 
            // OrdersUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Controls.Add(this.bunifuThinButton3);
            this.Controls.Add(this.bunifuThinButton2);
            this.Controls.Add(this.bunifuThinButton1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "OrdersUC";
            this.Size = new System.Drawing.Size(1082, 616);
            this.Load += new System.EventHandler(this.OrdersUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private WindowsFormsControlLibrary1.BunifuThinButton bunifuThinButton1;
        private WindowsFormsControlLibrary1.BunifuThinButton bunifuThinButton2;
        private WindowsFormsControlLibrary1.BunifuThinButton bunifuThinButton3;
    }
}
