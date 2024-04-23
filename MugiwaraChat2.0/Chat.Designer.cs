namespace MugiwaraChat2._0
{
    partial class Chat
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_FullName = new System.Windows.Forms.Label();
            this.txt_message = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btn_delete = new System.Windows.Forms.Button();
            this.updateChat = new System.Windows.Forms.Timer(this.components);
            this.pic_settings = new System.Windows.Forms.PictureBox();
            this.pic_send = new System.Windows.Forms.PictureBox();
            this.panel_message = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.pic_PFP = new MugiwaraChat2._0.PictureFormat();
            this.main_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_settings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_send)).BeginInit();
            this.panel_message.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_PFP)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 1);
            this.panel1.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(0, 23);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(471, 10);
            this.panel3.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.Location = new System.Drawing.Point(0, 69);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(471, 10);
            this.panel4.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Location = new System.Drawing.Point(0, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(471, 10);
            this.panel2.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel5.Location = new System.Drawing.Point(4, 72);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(472, 1);
            this.panel5.TabIndex = 8;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Poppins ExtraLight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(64, 2);
            this.lbl_username.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(116, 48);
            this.lbl_username.TabIndex = 10;
            this.lbl_username.Text = "Sukuna";
            // 
            // lbl_FullName
            // 
            this.lbl_FullName.AutoSize = true;
            this.lbl_FullName.Font = new System.Drawing.Font("Poppins ExtraLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FullName.ForeColor = System.Drawing.Color.Gray;
            this.lbl_FullName.Location = new System.Drawing.Point(67, 38);
            this.lbl_FullName.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.lbl_FullName.Name = "lbl_FullName";
            this.lbl_FullName.Size = new System.Drawing.Size(137, 28);
            this.lbl_FullName.TabIndex = 11;
            this.lbl_FullName.Text = "Ryomen Sukuna";
            // 
            // txt_message
            // 
            this.txt_message.BackColor = System.Drawing.SystemColors.Control;
            this.txt_message.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_message.Font = new System.Drawing.Font("Poppins ExtraLight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_message.Location = new System.Drawing.Point(3, 8);
            this.txt_message.Multiline = true;
            this.txt_message.Name = "txt_message";
            this.txt_message.Size = new System.Drawing.Size(430, 33);
            this.txt_message.TabIndex = 12;
            this.txt_message.TextChanged += new System.EventHandler(this.txt_message_TextChanged);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel6.Location = new System.Drawing.Point(7, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(470, 3);
            this.panel6.TabIndex = 9;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel7.Location = new System.Drawing.Point(6, 42);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(472, 3);
            this.panel7.TabIndex = 10;
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Poppins ExtraLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(293, 26);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(124, 26);
            this.btn_delete.TabIndex = 0;
            this.btn_delete.Text = "Delete Chat";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Visible = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // updateChat
            // 
            this.updateChat.Enabled = true;
            this.updateChat.Interval = 2000;
            this.updateChat.Tick += new System.EventHandler(this.updateChat_Tick);
            // 
            // pic_settings
            // 
            this.pic_settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_settings.Image = global::MugiwaraChat2._0.Properties.Resources.Settings_1;
            this.pic_settings.Location = new System.Drawing.Point(425, 16);
            this.pic_settings.Margin = new System.Windows.Forms.Padding(120, 15, 0, 0);
            this.pic_settings.Name = "pic_settings";
            this.pic_settings.Size = new System.Drawing.Size(40, 39);
            this.pic_settings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_settings.TabIndex = 14;
            this.pic_settings.TabStop = false;
            this.pic_settings.Click += new System.EventHandler(this.pic_settings_Click);
            // 
            // pic_send
            // 
            this.pic_send.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_send.Image = global::MugiwaraChat2._0.Properties.Resources.Paper_Plane;
            this.pic_send.Location = new System.Drawing.Point(435, 8);
            this.pic_send.Name = "pic_send";
            this.pic_send.Size = new System.Drawing.Size(39, 33);
            this.pic_send.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_send.TabIndex = 13;
            this.pic_send.TabStop = false;
            this.pic_send.Visible = false;
            this.pic_send.Click += new System.EventHandler(this.pic_send_Click);
            // 
            // panel_message
            // 
            this.panel_message.Controls.Add(this.pic_send);
            this.panel_message.Controls.Add(this.txt_message);
            this.panel_message.Controls.Add(this.panel6);
            this.panel_message.Controls.Add(this.panel7);
            this.panel_message.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_message.Location = new System.Drawing.Point(0, 544);
            this.panel_message.Margin = new System.Windows.Forms.Padding(0);
            this.panel_message.Name = "panel_message";
            this.panel_message.Size = new System.Drawing.Size(480, 52);
            this.panel_message.TabIndex = 15;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.pic_PFP);
            this.panel8.Controls.Add(this.btn_delete);
            this.panel8.Controls.Add(this.lbl_FullName);
            this.panel8.Controls.Add(this.pic_settings);
            this.panel8.Controls.Add(this.panel5);
            this.panel8.Controls.Add(this.lbl_username);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Margin = new System.Windows.Forms.Padding(0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(480, 79);
            this.panel8.TabIndex = 16;
            // 
            // pic_PFP
            // 
            this.pic_PFP.Image = global::MugiwaraChat2._0.Properties.Resources.Screenshot_2023_12_24_075037;
            this.pic_PFP.Location = new System.Drawing.Point(2, 2);
            this.pic_PFP.Name = "pic_PFP";
            this.pic_PFP.Size = new System.Drawing.Size(65, 66);
            this.pic_PFP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_PFP.TabIndex = 9;
            this.pic_PFP.TabStop = false;
            // 
            // main_panel
            // 
            this.main_panel.AutoScroll = true;
            this.main_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_panel.Location = new System.Drawing.Point(0, 79);
            this.main_panel.Margin = new System.Windows.Forms.Padding(0);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(480, 465);
            this.main_panel.TabIndex = 17;
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.main_panel);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel_message);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Chat";
            this.Size = new System.Drawing.Size(480, 596);
            this.Load += new System.EventHandler(this.Chat_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_settings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_send)).EndInit();
            this.panel_message.ResumeLayout(false);
            this.panel_message.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_PFP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private PictureFormat pic_PFP;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_FullName;
        private System.Windows.Forms.TextBox txt_message;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox pic_send;
        private System.Windows.Forms.PictureBox pic_settings;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Timer updateChat;
        private System.Windows.Forms.Panel panel_message;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.FlowLayoutPanel main_panel;
    }
}
