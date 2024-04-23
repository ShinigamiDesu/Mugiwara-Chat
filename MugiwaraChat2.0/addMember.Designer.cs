namespace MugiwaraChat2._0
{
    partial class addMember
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
            this.pic_PFP = new MugiwaraChat2._0.PictureFormat();
            this.pic_add = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_PFP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_add)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_FullName
            // 
            this.lbl_FullName.AutoSize = true;
            this.lbl_FullName.Font = new System.Drawing.Font("Poppins ExtraLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FullName.ForeColor = System.Drawing.Color.Gray;
            this.lbl_FullName.Location = new System.Drawing.Point(81, 46);
            this.lbl_FullName.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.lbl_FullName.Name = "lbl_FullName";
            this.lbl_FullName.Size = new System.Drawing.Size(137, 28);
            this.lbl_FullName.TabIndex = 23;
            this.lbl_FullName.Text = "Ryomen Sukuna";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Poppins ExtraLight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(76, 7);
            this.lbl_username.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(116, 48);
            this.lbl_username.TabIndex = 22;
            this.lbl_username.Text = "Sukuna";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(4, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 1);
            this.panel1.TabIndex = 20;
            // 
            // pic_PFP
            // 
            this.pic_PFP.Image = global::MugiwaraChat2._0.Properties.Resources.Screenshot_2023_12_24_075037;
            this.pic_PFP.Location = new System.Drawing.Point(2, 0);
            this.pic_PFP.Margin = new System.Windows.Forms.Padding(0);
            this.pic_PFP.Name = "pic_PFP";
            this.pic_PFP.Size = new System.Drawing.Size(77, 79);
            this.pic_PFP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_PFP.TabIndex = 19;
            this.pic_PFP.TabStop = false;
            // 
            // pic_add
            // 
            this.pic_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_add.Image = global::MugiwaraChat2._0.Properties.Resources.Add;
            this.pic_add.Location = new System.Drawing.Point(381, 9);
            this.pic_add.Margin = new System.Windows.Forms.Padding(120, 15, 0, 0);
            this.pic_add.Name = "pic_add";
            this.pic_add.Size = new System.Drawing.Size(70, 65);
            this.pic_add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_add.TabIndex = 21;
            this.pic_add.TabStop = false;
            this.pic_add.Click += new System.EventHandler(this.pic_add_Click);
            // 
            // addMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pic_PFP);
            this.Controls.Add(this.lbl_FullName);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.pic_add);
            this.Controls.Add(this.panel1);
            this.Name = "addMember";
            this.Size = new System.Drawing.Size(455, 85);
            ((System.ComponentModel.ISupportInitialize)(this.pic_PFP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_add)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureFormat pic_PFP;
        private System.Windows.Forms.Label lbl_FullName;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.PictureBox pic_add;
        private System.Windows.Forms.Panel panel1;
    }
}
