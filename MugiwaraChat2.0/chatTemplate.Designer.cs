namespace MugiwaraChat2._0
{
    partial class chatTemplate
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
            this.pic_PFP = new MugiwaraChat2._0.PictureFormat();
            this.lbl_FullName = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.pic_status = new System.Windows.Forms.PictureBox();
            this.pic_forward = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_PFP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_status)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_forward)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(5, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 1);
            this.panel1.TabIndex = 1;
            // 
            // pic_PFP
            // 
            this.pic_PFP.Image = global::MugiwaraChat2._0.Properties.Resources.Screenshot_2023_12_24_075037;
            this.pic_PFP.Location = new System.Drawing.Point(4, 0);
            this.pic_PFP.Margin = new System.Windows.Forms.Padding(0);
            this.pic_PFP.Name = "pic_PFP";
            this.pic_PFP.Size = new System.Drawing.Size(77, 79);
            this.pic_PFP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_PFP.TabIndex = 0;
            this.pic_PFP.TabStop = false;
            // 
            // lbl_FullName
            // 
            this.lbl_FullName.AutoSize = true;
            this.lbl_FullName.Font = new System.Drawing.Font("Poppins ExtraLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FullName.ForeColor = System.Drawing.Color.Gray;
            this.lbl_FullName.Location = new System.Drawing.Point(83, 46);
            this.lbl_FullName.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.lbl_FullName.Name = "lbl_FullName";
            this.lbl_FullName.Size = new System.Drawing.Size(137, 28);
            this.lbl_FullName.TabIndex = 13;
            this.lbl_FullName.Text = "Ryomen Sukuna";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Poppins ExtraLight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(78, 9);
            this.lbl_username.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(116, 48);
            this.lbl_username.TabIndex = 12;
            this.lbl_username.Text = "Sukuna";
            // 
            // pic_status
            // 
            this.pic_status.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pic_status.Image = global::MugiwaraChat2._0.Properties.Resources.Green_Circle;
            this.pic_status.Location = new System.Drawing.Point(352, 25);
            this.pic_status.Margin = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.pic_status.Name = "pic_status";
            this.pic_status.Size = new System.Drawing.Size(35, 35);
            this.pic_status.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_status.TabIndex = 5;
            this.pic_status.TabStop = false;
            // 
            // pic_forward
            // 
            this.pic_forward.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_forward.Image = global::MugiwaraChat2._0.Properties.Resources.Forward;
            this.pic_forward.Location = new System.Drawing.Point(394, 15);
            this.pic_forward.Margin = new System.Windows.Forms.Padding(120, 15, 0, 0);
            this.pic_forward.Name = "pic_forward";
            this.pic_forward.Size = new System.Drawing.Size(60, 50);
            this.pic_forward.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_forward.TabIndex = 3;
            this.pic_forward.TabStop = false;
            this.pic_forward.Click += new System.EventHandler(this.pic_forward_Click);
            // 
            // chatTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_FullName);
            this.Controls.Add(this.pic_PFP);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.pic_status);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pic_forward);
            this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.Name = "chatTemplate";
            this.Size = new System.Drawing.Size(455, 85);
            ((System.ComponentModel.ISupportInitialize)(this.pic_PFP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_status)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_forward)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureFormat pic_PFP;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pic_forward;
        private System.Windows.Forms.PictureBox pic_status;
        private System.Windows.Forms.Label lbl_FullName;
        private System.Windows.Forms.Label lbl_username;
    }
}
