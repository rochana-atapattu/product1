namespace HarasaraSystem.SubInterface.Sales
{
    partial class CustomMsgBox
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
            this.Yesbtn = new System.Windows.Forms.Button();
            this.MsgBoxLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(583, 37);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Yesbtn
            // 
            this.Yesbtn.BackColor = System.Drawing.Color.SeaGreen;
            this.Yesbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Yesbtn.ForeColor = System.Drawing.Color.White;
            this.Yesbtn.Location = new System.Drawing.Point(227, 105);
            this.Yesbtn.Name = "Yesbtn";
            this.Yesbtn.Size = new System.Drawing.Size(94, 32);
            this.Yesbtn.TabIndex = 1;
            this.Yesbtn.Text = "Yes";
            this.Yesbtn.UseVisualStyleBackColor = false;
            this.Yesbtn.Click += new System.EventHandler(this.Yesbtn_Click);
            // 
            // MsgBoxLabel
            // 
            this.MsgBoxLabel.AutoSize = true;
            this.MsgBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MsgBoxLabel.ForeColor = System.Drawing.Color.Green;
            this.MsgBoxLabel.Location = new System.Drawing.Point(179, 58);
            this.MsgBoxLabel.Name = "MsgBoxLabel";
            this.MsgBoxLabel.Size = new System.Drawing.Size(26, 18);
            this.MsgBoxLabel.TabIndex = 2;
            this.MsgBoxLabel.Text = "rrr";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Message";
            // 
            // CustomMsgBox
            // 
            this.AcceptButton = this.Yesbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 149);
            this.Controls.Add(this.MsgBoxLabel);
            this.Controls.Add(this.Yesbtn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomMsgBox";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomMsgBox";
            this.Load += new System.EventHandler(this.CustomMsgBox_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Yesbtn;
        private System.Windows.Forms.Label MsgBoxLabel;
        private System.Windows.Forms.Label label1;
    }
}