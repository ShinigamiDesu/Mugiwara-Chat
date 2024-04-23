namespace MugiwaraChat2._0
{
    partial class groupChatTemplate
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
            this.lbl_members = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pic_forward = new System.Windows.Forms.PictureBox();
            this.pic_PFP = new MugiwaraChat2._0.PictureFormat();
            ((System.ComponentModel.ISupportInitialize)(this.pic_forward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_PFP)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_members
            // 
            this.lbl_members.AutoSize = true;
            this.lbl_members.Font = new System.Drawing.Font("Poppins ExtraLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_members.ForeColor = System.Drawing.Color.Gray;
            this.lbl_members.Location = new System.Drawing.Point(80, 50);
            this.lbl_members.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.lbl_members.Name = "lbl_members";
            this.lbl_members.Size = new System.Drawing.Size(104, 28);
            this.lbl_members.TabIndex = 18;
            this.lbl_members.Text = "21 Members";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Poppins ExtraLight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(76, 9);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(187, 48);
            this.lbl_name.TabIndex = 17;
            this.lbl_name.Text = "Jump Kaisen";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(3, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 1);
            this.panel1.TabIndex = 15;
            // 
            // pic_forward
            // 
            this.pic_forward.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_forward.Image = global::MugiwaraChat2._0.Properties.Resources.Forward;
            this.pic_forward.Location = new System.Drawing.Point(392, 15);
            this.pic_forward.Margin = new System.Windows.Forms.Padding(120, 15, 0, 0);
            this.pic_forward.Name = "pic_forward";
            this.pic_forward.Size = new System.Drawing.Size(60, 50);
            this.pic_forward.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_forward.TabIndex = 16;
            this.pic_forward.TabStop = false;
            this.pic_forward.Click += new System.EventHandler(this.pic_forward_Click);
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
            // groupChatTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_members);
            this.Controls.Add(this.pic_PFP);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pic_forward);
            this.Controls.Add(this.lbl_name);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "groupChatTemplate";
            this.Size = new System.Drawing.Size(455, 85);
            this.Load += new System.EventHandler(this.groupChatTemplate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_forward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_PFP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_members;
        private PictureFormat pic_PFP;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pic_forward;
    }
}
