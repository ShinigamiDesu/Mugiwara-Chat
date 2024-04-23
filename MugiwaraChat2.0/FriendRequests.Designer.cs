namespace MugiwaraChat2._0
{
    partial class FriendRequests
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
            this.lbl_FullName = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pic_reject = new System.Windows.Forms.PictureBox();
            this.pic_accept = new System.Windows.Forms.PictureBox();
            this.pic_PFP = new MugiwaraChat2._0.PictureFormat();
            ((System.ComponentModel.ISupportInitialize)(this.pic_reject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_accept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_PFP)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_FullName
            // 
            this.lbl_FullName.AutoSize = true;
            this.lbl_FullName.Font = new System.Drawing.Font("Poppins ExtraLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FullName.ForeColor = System.Drawing.Color.Gray;
            this.lbl_FullName.Location = new System.Drawing.Point(82, 45);
            this.lbl_FullName.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.lbl_FullName.Name = "lbl_FullName";
            this.lbl_FullName.Size = new System.Drawing.Size(137, 28);
            this.lbl_FullName.TabIndex = 17;
            this.lbl_FullName.Text = "Ryomen Sukuna";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Poppins ExtraLight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(79, 9);
            this.lbl_username.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(116, 48);
            this.lbl_username.TabIndex = 16;
            this.lbl_username.Text = "Sukuna";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(3, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 1);
            this.panel1.TabIndex = 15;
            // 
            // pic_reject
            // 
            this.pic_reject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_reject.Image = global::MugiwaraChat2._0.Properties.Resources.Xbox_X;
            this.pic_reject.Location = new System.Drawing.Point(382, 9);
            this.pic_reject.Name = "pic_reject";
            this.pic_reject.Size = new System.Drawing.Size(70, 65);
            this.pic_reject.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_reject.TabIndex = 19;
            this.pic_reject.TabStop = false;
            this.pic_reject.Click += new System.EventHandler(this.pic_reject_Click);
            // 
            // pic_accept
            // 
            this.pic_accept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_accept.Image = global::MugiwaraChat2._0.Properties.Resources.Ok_1;
            this.pic_accept.Location = new System.Drawing.Point(293, 9);
            this.pic_accept.Name = "pic_accept";
            this.pic_accept.Size = new System.Drawing.Size(70, 65);
            this.pic_accept.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_accept.TabIndex = 18;
            this.pic_accept.TabStop = false;
            this.pic_accept.Click += new System.EventHandler(this.pic_accept_Click);
            // 
            // pic_PFP
            // 
            this.pic_PFP.Image = global::MugiwaraChat2._0.Properties.Resources.Screenshot_2023_12_24_075037;
            this.pic_PFP.Location = new System.Drawing.Point(2, 0);
            this.pic_PFP.Margin = new System.Windows.Forms.Padding(0);
            this.pic_PFP.Name = "pic_PFP";
            this.pic_PFP.Size = new System.Drawing.Size(77, 79);
            this.pic_PFP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_PFP.TabIndex = 14;
            this.pic_PFP.TabStop = false;
            // 
            // FriendRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pic_reject);
            this.Controls.Add(this.pic_accept);
            this.Controls.Add(this.pic_PFP);
            this.Controls.Add(this.lbl_FullName);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.Name = "FriendRequests";
            this.Size = new System.Drawing.Size(455, 85);
            ((System.ComponentModel.ISupportInitialize)(this.pic_reject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_accept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_PFP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureFormat pic_PFP;
        private System.Windows.Forms.Label lbl_FullName;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pic_accept;
        private System.Windows.Forms.PictureBox pic_reject;
    }
}
