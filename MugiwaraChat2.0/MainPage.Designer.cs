namespace MugiwaraChat2._0
{
    partial class MainPage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.toolbar = new System.Windows.Forms.Panel();
            this.pic_red = new System.Windows.Forms.PictureBox();
            this.pic_green = new System.Windows.Forms.PictureBox();
            this.pic_minimize = new System.Windows.Forms.PictureBox();
            this.pic_exit = new System.Windows.Forms.PictureBox();
            this.pic_menu = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sidebar = new System.Windows.Forms.Panel();
            this.lbl_viewFriends = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pic_pfp = new MugiwaraChat2._0.PictureFormat();
            this.lbl_OfflineFriends = new System.Windows.Forms.Label();
            this.lbl_OnlineFriends = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.lbl_NewChat = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.lbl_GroupChats = new System.Windows.Forms.Label();
            this.lbl_Requests = new System.Windows.Forms.Label();
            this.lbl_AddUser = new System.Windows.Forms.Label();
            this.lbl_Home = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.sidebartimer = new System.Windows.Forms.Timer(this.components);
            this.main_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.friendUpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.toolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_menu)).BeginInit();
            this.sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_pfp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolbar
            // 
            this.toolbar.BackColor = System.Drawing.Color.White;
            this.toolbar.Controls.Add(this.pic_red);
            this.toolbar.Controls.Add(this.pic_green);
            this.toolbar.Controls.Add(this.pic_minimize);
            this.toolbar.Controls.Add(this.pic_exit);
            this.toolbar.Controls.Add(this.pic_menu);
            this.toolbar.Controls.Add(this.label1);
            this.toolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolbar.Location = new System.Drawing.Point(0, 0);
            this.toolbar.Name = "toolbar";
            this.toolbar.Size = new System.Drawing.Size(520, 34);
            this.toolbar.TabIndex = 0;
            this.toolbar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolbar_MouseDown);
            this.toolbar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.toolbar_MouseMove);
            this.toolbar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.toolbar_MouseUp);
            // 
            // pic_red
            // 
            this.pic_red.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pic_red.Image = global::MugiwaraChat2._0.Properties.Resources.Red_Circle;
            this.pic_red.Location = new System.Drawing.Point(243, 0);
            this.pic_red.Margin = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.pic_red.Name = "pic_red";
            this.pic_red.Size = new System.Drawing.Size(35, 35);
            this.pic_red.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_red.TabIndex = 7;
            this.pic_red.TabStop = false;
            this.pic_red.Visible = false;
            // 
            // pic_green
            // 
            this.pic_green.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pic_green.Image = global::MugiwaraChat2._0.Properties.Resources.Green_Circle;
            this.pic_green.Location = new System.Drawing.Point(202, 0);
            this.pic_green.Margin = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.pic_green.Name = "pic_green";
            this.pic_green.Size = new System.Drawing.Size(35, 35);
            this.pic_green.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_green.TabIndex = 6;
            this.pic_green.TabStop = false;
            this.pic_green.Visible = false;
            // 
            // pic_minimize
            // 
            this.pic_minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_minimize.Image = global::MugiwaraChat2._0.Properties.Resources.Minimize_Window;
            this.pic_minimize.Location = new System.Drawing.Point(453, 3);
            this.pic_minimize.Name = "pic_minimize";
            this.pic_minimize.Size = new System.Drawing.Size(31, 28);
            this.pic_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_minimize.TabIndex = 4;
            this.pic_minimize.TabStop = false;
            // 
            // pic_exit
            // 
            this.pic_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_exit.Image = global::MugiwaraChat2._0.Properties.Resources.Close_Window;
            this.pic_exit.Location = new System.Drawing.Point(486, 3);
            this.pic_exit.Name = "pic_exit";
            this.pic_exit.Size = new System.Drawing.Size(31, 28);
            this.pic_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_exit.TabIndex = 3;
            this.pic_exit.TabStop = false;
            this.pic_exit.Click += new System.EventHandler(this.pic_exit_Click);
            // 
            // pic_menu
            // 
            this.pic_menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_menu.Image = global::MugiwaraChat2._0.Properties.Resources.Menu;
            this.pic_menu.Location = new System.Drawing.Point(3, 3);
            this.pic_menu.Name = "pic_menu";
            this.pic_menu.Size = new System.Drawing.Size(35, 28);
            this.pic_menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_menu.TabIndex = 2;
            this.pic_menu.TabStop = false;
            this.pic_menu.Click += new System.EventHandler(this.pic_menu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins ExtraLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mugiwara Chat";
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.Black;
            this.sidebar.Controls.Add(this.lbl_viewFriends);
            this.sidebar.Controls.Add(this.pictureBox4);
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.label2);
            this.sidebar.Controls.Add(this.pic_pfp);
            this.sidebar.Controls.Add(this.lbl_OfflineFriends);
            this.sidebar.Controls.Add(this.lbl_OnlineFriends);
            this.sidebar.Controls.Add(this.pictureBox8);
            this.sidebar.Controls.Add(this.pictureBox7);
            this.sidebar.Controls.Add(this.lbl_NewChat);
            this.sidebar.Controls.Add(this.pictureBox6);
            this.sidebar.Controls.Add(this.lbl_GroupChats);
            this.sidebar.Controls.Add(this.lbl_Requests);
            this.sidebar.Controls.Add(this.lbl_AddUser);
            this.sidebar.Controls.Add(this.lbl_Home);
            this.sidebar.Controls.Add(this.pictureBox5);
            this.sidebar.Controls.Add(this.pictureBox3);
            this.sidebar.Controls.Add(this.pictureBox2);
            this.sidebar.Controls.Add(this.pictureBox1);
            this.sidebar.Controls.Add(this.lbl_username);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 34);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(200, 596);
            this.sidebar.TabIndex = 1;
            // 
            // lbl_viewFriends
            // 
            this.lbl_viewFriends.AutoSize = true;
            this.lbl_viewFriends.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_viewFriends.Font = new System.Drawing.Font("Poppins ExtraLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_viewFriends.ForeColor = System.Drawing.Color.White;
            this.lbl_viewFriends.Location = new System.Drawing.Point(40, 248);
            this.lbl_viewFriends.Name = "lbl_viewFriends";
            this.lbl_viewFriends.Size = new System.Drawing.Size(129, 34);
            this.lbl_viewFriends.TabIndex = 25;
            this.lbl_viewFriends.Text = "View Friends";
            this.lbl_viewFriends.Click += new System.EventHandler(this.lbl_viewFriends_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox4.Image = global::MugiwaraChat2._0.Properties.Resources.User_Account;
            this.pictureBox4.Location = new System.Drawing.Point(4, 247);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 28);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 24;
            this.pictureBox4.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(5, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 1);
            this.panel1.TabIndex = 23;
            this.panel1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Poppins ExtraLight", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(63, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 34);
            this.label2.TabIndex = 22;
            this.label2.Text = "Menu";
            // 
            // pic_pfp
            // 
            this.pic_pfp.Location = new System.Drawing.Point(4, 560);
            this.pic_pfp.Name = "pic_pfp";
            this.pic_pfp.Size = new System.Drawing.Size(34, 30);
            this.pic_pfp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_pfp.TabIndex = 20;
            this.pic_pfp.TabStop = false;
            // 
            // lbl_OfflineFriends
            // 
            this.lbl_OfflineFriends.AutoSize = true;
            this.lbl_OfflineFriends.Font = new System.Drawing.Font("Poppins ExtraLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OfflineFriends.ForeColor = System.Drawing.Color.White;
            this.lbl_OfflineFriends.Location = new System.Drawing.Point(35, 527);
            this.lbl_OfflineFriends.Name = "lbl_OfflineFriends";
            this.lbl_OfflineFriends.Size = new System.Drawing.Size(161, 34);
            this.lbl_OfflineFriends.TabIndex = 19;
            this.lbl_OfflineFriends.Text = "5 Offline Friends";
            // 
            // lbl_OnlineFriends
            // 
            this.lbl_OnlineFriends.AutoSize = true;
            this.lbl_OnlineFriends.Font = new System.Drawing.Font("Poppins ExtraLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OnlineFriends.ForeColor = System.Drawing.Color.White;
            this.lbl_OnlineFriends.Location = new System.Drawing.Point(35, 496);
            this.lbl_OnlineFriends.Name = "lbl_OnlineFriends";
            this.lbl_OnlineFriends.Size = new System.Drawing.Size(166, 34);
            this.lbl_OnlineFriends.TabIndex = 18;
            this.lbl_OnlineFriends.Text = "21 Online Friends";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox8.Image = global::MugiwaraChat2._0.Properties.Resources.Green_Circle;
            this.pictureBox8.Location = new System.Drawing.Point(3, 496);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(30, 28);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 17;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox7.Image = global::MugiwaraChat2._0.Properties.Resources.Red_Circle;
            this.pictureBox7.Location = new System.Drawing.Point(3, 527);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(30, 28);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 16;
            this.pictureBox7.TabStop = false;
            // 
            // lbl_NewChat
            // 
            this.lbl_NewChat.AutoSize = true;
            this.lbl_NewChat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_NewChat.Font = new System.Drawing.Font("Poppins ExtraLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NewChat.ForeColor = System.Drawing.Color.White;
            this.lbl_NewChat.Location = new System.Drawing.Point(41, 201);
            this.lbl_NewChat.Name = "lbl_NewChat";
            this.lbl_NewChat.Size = new System.Drawing.Size(157, 34);
            this.lbl_NewChat.TabIndex = 15;
            this.lbl_NewChat.Text = "Start New Chat";
            this.lbl_NewChat.Click += new System.EventHandler(this.lbl_NewChat_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox6.Image = global::MugiwaraChat2._0.Properties.Resources.Chat_1;
            this.pictureBox6.Location = new System.Drawing.Point(5, 200);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(30, 28);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 14;
            this.pictureBox6.TabStop = false;
            // 
            // lbl_GroupChats
            // 
            this.lbl_GroupChats.AutoSize = true;
            this.lbl_GroupChats.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_GroupChats.Font = new System.Drawing.Font("Poppins ExtraLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GroupChats.ForeColor = System.Drawing.Color.White;
            this.lbl_GroupChats.Location = new System.Drawing.Point(41, 156);
            this.lbl_GroupChats.Name = "lbl_GroupChats";
            this.lbl_GroupChats.Size = new System.Drawing.Size(135, 34);
            this.lbl_GroupChats.TabIndex = 12;
            this.lbl_GroupChats.Text = "Group Chats";
            this.lbl_GroupChats.Click += new System.EventHandler(this.lbl_GroupChats_Click);
            // 
            // lbl_Requests
            // 
            this.lbl_Requests.AutoSize = true;
            this.lbl_Requests.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Requests.Font = new System.Drawing.Font("Poppins ExtraLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Requests.ForeColor = System.Drawing.Color.White;
            this.lbl_Requests.Location = new System.Drawing.Point(39, 115);
            this.lbl_Requests.Name = "lbl_Requests";
            this.lbl_Requests.Size = new System.Drawing.Size(162, 34);
            this.lbl_Requests.TabIndex = 11;
            this.lbl_Requests.Text = "Friend Requests";
            this.lbl_Requests.Click += new System.EventHandler(this.lbl_Requests_Click);
            // 
            // lbl_AddUser
            // 
            this.lbl_AddUser.AutoSize = true;
            this.lbl_AddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_AddUser.Font = new System.Drawing.Font("Poppins ExtraLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AddUser.ForeColor = System.Drawing.Color.White;
            this.lbl_AddUser.Location = new System.Drawing.Point(39, 76);
            this.lbl_AddUser.Name = "lbl_AddUser";
            this.lbl_AddUser.Size = new System.Drawing.Size(98, 34);
            this.lbl_AddUser.TabIndex = 10;
            this.lbl_AddUser.Text = "Add User";
            this.lbl_AddUser.Click += new System.EventHandler(this.lbl_AddUser_Click);
            // 
            // lbl_Home
            // 
            this.lbl_Home.AutoSize = true;
            this.lbl_Home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Home.Font = new System.Drawing.Font("Poppins ExtraLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Home.ForeColor = System.Drawing.Color.White;
            this.lbl_Home.Location = new System.Drawing.Point(39, 38);
            this.lbl_Home.Name = "lbl_Home";
            this.lbl_Home.Size = new System.Drawing.Size(71, 34);
            this.lbl_Home.TabIndex = 5;
            this.lbl_Home.Text = "Home";
            this.lbl_Home.Click += new System.EventHandler(this.lbl_Home_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox5.Image = global::MugiwaraChat2._0.Properties.Resources.Home;
            this.pictureBox5.Location = new System.Drawing.Point(4, 39);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(31, 28);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox3.Image = global::MugiwaraChat2._0.Properties.Resources.People_Skin_Type_7;
            this.pictureBox3.Location = new System.Drawing.Point(4, 157);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 28);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox2.Image = global::MugiwaraChat2._0.Properties.Resources.Heart;
            this.pictureBox2.Location = new System.Drawing.Point(4, 116);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox1.Image = global::MugiwaraChat2._0.Properties.Resources.Join;
            this.pictureBox1.Location = new System.Drawing.Point(4, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lbl_username.Font = new System.Drawing.Font("Poppins ExtraLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.ForeColor = System.Drawing.Color.White;
            this.lbl_username.Location = new System.Drawing.Point(39, 561);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(65, 34);
            this.lbl_username.TabIndex = 21;
            this.lbl_username.Text = "XXXXX";
            // 
            // sidebartimer
            // 
            this.sidebartimer.Interval = 1;
            this.sidebartimer.Tick += new System.EventHandler(this.sidebartimer_Tick);
            // 
            // main_panel
            // 
            this.main_panel.AutoScroll = true;
            this.main_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_panel.Location = new System.Drawing.Point(200, 34);
            this.main_panel.Margin = new System.Windows.Forms.Padding(0);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(320, 596);
            this.main_panel.TabIndex = 2;
            // 
            // friendUpdateTimer
            // 
            this.friendUpdateTimer.Enabled = true;
            this.friendUpdateTimer.Interval = 3000;
            this.friendUpdateTimer.Tick += new System.EventHandler(this.friendUpdateTimer_Tick);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 630);
            this.Controls.Add(this.main_panel);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.toolbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.toolbar.ResumeLayout(false);
            this.toolbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_menu)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.sidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_pfp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel toolbar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.PictureBox pic_menu;
        private System.Windows.Forms.PictureBox pic_exit;
        private System.Windows.Forms.PictureBox pic_minimize;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Timer sidebartimer;
        private System.Windows.Forms.Label lbl_Home;
        private System.Windows.Forms.Label lbl_AddUser;
        private System.Windows.Forms.Label lbl_Requests;
        private System.Windows.Forms.Label lbl_GroupChats;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label lbl_NewChat;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label lbl_OnlineFriends;
        private System.Windows.Forms.Label lbl_OfflineFriends;
        private System.Windows.Forms.FlowLayoutPanel main_panel;
        private PictureFormat pic_pfp;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.PictureBox pic_red;
        private System.Windows.Forms.PictureBox pic_green;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_viewFriends;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Timer friendUpdateTimer;
    }
}

