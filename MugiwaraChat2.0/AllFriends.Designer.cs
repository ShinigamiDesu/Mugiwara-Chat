namespace MugiwaraChat2._0
{
    partial class AllFriends
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
            this.pic_manage = new System.Windows.Forms.PictureBox();
            this.lbl_FullName = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.pic_Status = new System.Windows.Forms.PictureBox();
            this.btn_remove = new System.Windows.Forms.Button();
            this.pic_PFP = new MugiwaraChat2._0.PictureFormat();
            ((System.ComponentModel.ISupportInitialize)(this.pic_manage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Status)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_PFP)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(1, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 1);
            this.panel1.TabIndex = 21;
            // 
            // pic_manage
            // 
            this.pic_manage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_manage.Image = global::MugiwaraChat2._0.Properties.Resources.Ellipsis;
            this.pic_manage.Location = new System.Drawing.Point(389, 11);
            this.pic_manage.Margin = new System.Windows.Forms.Padding(130, 10, 0, 0);
            this.pic_manage.Name = "pic_manage";
            this.pic_manage.Size = new System.Drawing.Size(62, 65);
            this.pic_manage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_manage.TabIndex = 24;
            this.pic_manage.TabStop = false;
            this.pic_manage.Click += new System.EventHandler(this.pic_manage_Click);
            // 
            // lbl_FullName
            // 
            this.lbl_FullName.AutoSize = true;
            this.lbl_FullName.Font = new System.Drawing.Font("Poppins ExtraLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FullName.ForeColor = System.Drawing.Color.Gray;
            this.lbl_FullName.Location = new System.Drawing.Point(81, 43);
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
            this.lbl_username.Location = new System.Drawing.Point(78, 7);
            this.lbl_username.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(116, 48);
            this.lbl_username.TabIndex = 12;
            this.lbl_username.Text = "Sukuna";
            // 
            // pic_Status
            // 
            this.pic_Status.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pic_Status.Image = global::MugiwaraChat2._0.Properties.Resources.Green_Circle;
            this.pic_Status.Location = new System.Drawing.Point(339, 27);
            this.pic_Status.Margin = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.pic_Status.Name = "pic_Status";
            this.pic_Status.Size = new System.Drawing.Size(35, 35);
            this.pic_Status.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Status.TabIndex = 5;
            this.pic_Status.TabStop = false;
            // 
            // btn_remove
            // 
            this.btn_remove.BackColor = System.Drawing.Color.Gray;
            this.btn_remove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_remove.Font = new System.Drawing.Font("Poppins ExtraLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove.ForeColor = System.Drawing.Color.White;
            this.btn_remove.Location = new System.Drawing.Point(266, 29);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(115, 31);
            this.btn_remove.TabIndex = 25;
            this.btn_remove.Text = "REMOVE";
            this.btn_remove.UseVisualStyleBackColor = false;
            this.btn_remove.Visible = false;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // pic_PFP
            // 
            this.pic_PFP.Image = global::MugiwaraChat2._0.Properties.Resources.Screenshot_2023_12_24_075037;
            this.pic_PFP.Location = new System.Drawing.Point(1, 1);
            this.pic_PFP.Margin = new System.Windows.Forms.Padding(0);
            this.pic_PFP.Name = "pic_PFP";
            this.pic_PFP.Size = new System.Drawing.Size(77, 79);
            this.pic_PFP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_PFP.TabIndex = 0;
            this.pic_PFP.TabStop = false;
            // 
            // AllFriends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.lbl_FullName);
            this.Controls.Add(this.pic_PFP);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pic_Status);
            this.Controls.Add(this.pic_manage);
            this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.Name = "AllFriends";
            this.Size = new System.Drawing.Size(455, 85);
            ((System.ComponentModel.ISupportInitialize)(this.pic_manage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Status)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_PFP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_manage;
        private System.Windows.Forms.Panel panel1;
        private PictureFormat pic_PFP;
        private System.Windows.Forms.Label lbl_FullName;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.PictureBox pic_Status;
        private System.Windows.Forms.Button btn_remove;
    }
}
