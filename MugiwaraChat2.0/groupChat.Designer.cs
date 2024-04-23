namespace MugiwaraChat2._0
{
    partial class groupChat
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
            this.pic_settings = new System.Windows.Forms.PictureBox();
            this.pic_PFP = new MugiwaraChat2._0.PictureFormat();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbl_Members = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.pic_send = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txt_message = new System.Windows.Forms.TextBox();
            this.updateChat = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.main_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_settings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_PFP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_send)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pic_settings);
            this.panel1.Controls.Add(this.pic_PFP);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.lbl_Members);
            this.panel1.Controls.Add(this.lbl_name);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 78);
            this.panel1.TabIndex = 0;
            // 
            // pic_settings
            // 
            this.pic_settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_settings.Image = global::MugiwaraChat2._0.Properties.Resources.Settings_1;
            this.pic_settings.Location = new System.Drawing.Point(426, 17);
            this.pic_settings.Margin = new System.Windows.Forms.Padding(120, 15, 0, 0);
            this.pic_settings.Name = "pic_settings";
            this.pic_settings.Size = new System.Drawing.Size(40, 39);
            this.pic_settings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_settings.TabIndex = 19;
            this.pic_settings.TabStop = false;
            this.pic_settings.Click += new System.EventHandler(this.pic_settings_Click);
            // 
            // pic_PFP
            // 
            this.pic_PFP.Image = global::MugiwaraChat2._0.Properties.Resources.jjk;
            this.pic_PFP.Location = new System.Drawing.Point(3, 3);
            this.pic_PFP.Name = "pic_PFP";
            this.pic_PFP.Size = new System.Drawing.Size(70, 66);
            this.pic_PFP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_PFP.TabIndex = 16;
            this.pic_PFP.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel5.Location = new System.Drawing.Point(-3, 73);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(480, 1);
            this.panel5.TabIndex = 15;
            // 
            // lbl_Members
            // 
            this.lbl_Members.AutoSize = true;
            this.lbl_Members.Font = new System.Drawing.Font("Poppins ExtraLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Members.ForeColor = System.Drawing.Color.Gray;
            this.lbl_Members.Location = new System.Drawing.Point(73, 43);
            this.lbl_Members.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.lbl_Members.Name = "lbl_Members";
            this.lbl_Members.Size = new System.Drawing.Size(104, 28);
            this.lbl_Members.TabIndex = 18;
            this.lbl_Members.Text = "21 Members";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Poppins ExtraLight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(70, 3);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(116, 48);
            this.lbl_name.TabIndex = 17;
            this.lbl_name.Text = "Sukuna";
            // 
            // pic_send
            // 
            this.pic_send.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_send.Image = global::MugiwaraChat2._0.Properties.Resources.Paper_Plane;
            this.pic_send.Location = new System.Drawing.Point(433, 6);
            this.pic_send.Name = "pic_send";
            this.pic_send.Size = new System.Drawing.Size(39, 33);
            this.pic_send.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_send.TabIndex = 19;
            this.pic_send.TabStop = false;
            this.pic_send.Visible = false;
            this.pic_send.Click += new System.EventHandler(this.pic_send_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel7.Location = new System.Drawing.Point(4, 40);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(472, 3);
            this.panel7.TabIndex = 17;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel6.Location = new System.Drawing.Point(5, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(470, 3);
            this.panel6.TabIndex = 16;
            // 
            // txt_message
            // 
            this.txt_message.BackColor = System.Drawing.SystemColors.Control;
            this.txt_message.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_message.Font = new System.Drawing.Font("Poppins ExtraLight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_message.Location = new System.Drawing.Point(1, 6);
            this.txt_message.Multiline = true;
            this.txt_message.Name = "txt_message";
            this.txt_message.Size = new System.Drawing.Size(430, 33);
            this.txt_message.TabIndex = 18;
            this.txt_message.TextChanged += new System.EventHandler(this.txt_message_TextChanged);
            // 
            // updateChat
            // 
            this.updateChat.Enabled = true;
            this.updateChat.Interval = 1000;
            this.updateChat.Tick += new System.EventHandler(this.updateChat_Tick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txt_message);
            this.panel2.Controls.Add(this.pic_send);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 549);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(480, 47);
            this.panel2.TabIndex = 20;
            // 
            // main_panel
            // 
            this.main_panel.AutoScroll = true;
            this.main_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_panel.Location = new System.Drawing.Point(0, 78);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(480, 471);
            this.main_panel.TabIndex = 21;
            // 
            // groupChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.main_panel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "groupChat";
            this.Size = new System.Drawing.Size(480, 596);
            this.Load += new System.EventHandler(this.groupChat_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_settings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_PFP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_send)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pic_settings;
        private PictureFormat pic_PFP;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbl_Members;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.PictureBox pic_send;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txt_message;
        private System.Windows.Forms.Timer updateChat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel main_panel;
    }
}
