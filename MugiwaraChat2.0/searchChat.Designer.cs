namespace MugiwaraChat2._0
{
    partial class searchChat
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
            this.pic_chat = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_PFP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_chat)).BeginInit();
            this.SuspendLayout();
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
            this.lbl_FullName.TabIndex = 18;
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
            this.lbl_username.TabIndex = 17;
            this.lbl_username.Text = "Sukuna";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(5, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 1);
            this.panel1.TabIndex = 15;
            // 
            // pic_PFP
            // 
            this.pic_PFP.Image = global::MugiwaraChat2._0.Properties.Resources.Screenshot_2023_12_24_075037;
            this.pic_PFP.Location = new System.Drawing.Point(4, 0);
            this.pic_PFP.Margin = new System.Windows.Forms.Padding(0);
            this.pic_PFP.Name = "pic_PFP";
            this.pic_PFP.Size = new System.Drawing.Size(77, 79);
            this.pic_PFP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_PFP.TabIndex = 14;
            this.pic_PFP.TabStop = false;
            // 
            // pic_chat
            // 
            this.pic_chat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_chat.Image = global::MugiwaraChat2._0.Properties.Resources.Chat_Room_2;
            this.pic_chat.Location = new System.Drawing.Point(382, 15);
            this.pic_chat.Margin = new System.Windows.Forms.Padding(120, 15, 0, 0);
            this.pic_chat.Name = "pic_chat";
            this.pic_chat.Size = new System.Drawing.Size(60, 50);
            this.pic_chat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_chat.TabIndex = 16;
            this.pic_chat.TabStop = false;
            this.pic_chat.Click += new System.EventHandler(this.pic_chat_Click);
            // 
            // searchChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_FullName);
            this.Controls.Add(this.pic_PFP);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pic_chat);
            this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.Name = "searchChat";
            this.Size = new System.Drawing.Size(455, 85);
            ((System.ComponentModel.ISupportInitialize)(this.pic_PFP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_chat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_FullName;
        private PictureFormat pic_PFP;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pic_chat;
    }
}
