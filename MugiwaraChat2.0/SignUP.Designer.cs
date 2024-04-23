namespace MugiwaraChat2._0
{
    partial class SignUP
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
            this.toolbar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_upload = new System.Windows.Forms.Button();
            this.txt_fn = new System.Windows.Forms.TextBox();
            this.txt_ln = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Signup = new System.Windows.Forms.Button();
            this.pic_pfp2 = new MugiwaraChat2._0.PictureFormat();
            this.pic_back = new System.Windows.Forms.PictureBox();
            this.pic_pfp = new MugiwaraChat2._0.PictureFormat();
            this.pic_minimize = new System.Windows.Forms.PictureBox();
            this.pic_exit = new System.Windows.Forms.PictureBox();
            this.toolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_pfp2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_pfp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_exit)).BeginInit();
            this.SuspendLayout();
            // 
            // toolbar
            // 
            this.toolbar.BackColor = System.Drawing.Color.White;
            this.toolbar.Controls.Add(this.pic_minimize);
            this.toolbar.Controls.Add(this.pic_exit);
            this.toolbar.Controls.Add(this.label1);
            this.toolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolbar.Location = new System.Drawing.Point(0, 0);
            this.toolbar.Name = "toolbar";
            this.toolbar.Size = new System.Drawing.Size(418, 34);
            this.toolbar.TabIndex = 1;
            this.toolbar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolbar_MouseDown);
            this.toolbar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.toolbar_MouseMove);
            this.toolbar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.toolbar_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins ExtraLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sign Up";
            // 
            // btn_upload
            // 
            this.btn_upload.BackColor = System.Drawing.Color.White;
            this.btn_upload.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_upload.Font = new System.Drawing.Font("Poppins ExtraLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_upload.Location = new System.Drawing.Point(128, 262);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Size = new System.Drawing.Size(148, 31);
            this.btn_upload.TabIndex = 3;
            this.btn_upload.Text = "UPLOAD";
            this.btn_upload.UseVisualStyleBackColor = false;
            this.btn_upload.Click += new System.EventHandler(this.btn_upload_Click);
            // 
            // txt_fn
            // 
            this.txt_fn.Font = new System.Drawing.Font("Poppins ExtraLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fn.Location = new System.Drawing.Point(90, 327);
            this.txt_fn.Name = "txt_fn";
            this.txt_fn.Size = new System.Drawing.Size(217, 27);
            this.txt_fn.TabIndex = 4;
            // 
            // txt_ln
            // 
            this.txt_ln.Font = new System.Drawing.Font("Poppins ExtraLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ln.Location = new System.Drawing.Point(90, 379);
            this.txt_ln.Name = "txt_ln";
            this.txt_ln.Size = new System.Drawing.Size(217, 27);
            this.txt_ln.TabIndex = 5;
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Poppins ExtraLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Location = new System.Drawing.Point(90, 433);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(217, 27);
            this.txt_username.TabIndex = 6;
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Poppins ExtraLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(90, 487);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(217, 27);
            this.txt_password.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins ExtraLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins ExtraLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(90, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = "Last Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins ExtraLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(90, 411);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 28);
            this.label4.TabIndex = 9;
            this.label4.Text = "Username:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins ExtraLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(90, 465);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 28);
            this.label5.TabIndex = 10;
            this.label5.Text = "Password:";
            // 
            // btn_Signup
            // 
            this.btn_Signup.BackColor = System.Drawing.Color.White;
            this.btn_Signup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Signup.Font = new System.Drawing.Font("Poppins ExtraLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Signup.Location = new System.Drawing.Point(119, 533);
            this.btn_Signup.Name = "btn_Signup";
            this.btn_Signup.Size = new System.Drawing.Size(148, 33);
            this.btn_Signup.TabIndex = 11;
            this.btn_Signup.Text = "Sign Up";
            this.btn_Signup.UseVisualStyleBackColor = false;
            this.btn_Signup.Click += new System.EventHandler(this.btn_Signup_Click);
            // 
            // pic_pfp2
            // 
            this.pic_pfp2.BackColor = System.Drawing.Color.White;
            this.pic_pfp2.Image = global::MugiwaraChat2._0.Properties.Resources.Male_User;
            this.pic_pfp2.Location = new System.Drawing.Point(330, 37);
            this.pic_pfp2.Margin = new System.Windows.Forms.Padding(0);
            this.pic_pfp2.Name = "pic_pfp2";
            this.pic_pfp2.Size = new System.Drawing.Size(83, 81);
            this.pic_pfp2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_pfp2.TabIndex = 12;
            this.pic_pfp2.TabStop = false;
            this.pic_pfp2.Visible = false;
            // 
            // pic_back
            // 
            this.pic_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_back.Image = global::MugiwaraChat2._0.Properties.Resources.Go_Back;
            this.pic_back.Location = new System.Drawing.Point(7, 543);
            this.pic_back.Name = "pic_back";
            this.pic_back.Size = new System.Drawing.Size(44, 44);
            this.pic_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_back.TabIndex = 5;
            this.pic_back.TabStop = false;
            this.pic_back.Click += new System.EventHandler(this.pic_back_Click);
            // 
            // pic_pfp
            // 
            this.pic_pfp.BackColor = System.Drawing.Color.White;
            this.pic_pfp.Location = new System.Drawing.Point(90, 40);
            this.pic_pfp.Name = "pic_pfp";
            this.pic_pfp.Size = new System.Drawing.Size(224, 216);
            this.pic_pfp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_pfp.TabIndex = 2;
            this.pic_pfp.TabStop = false;
            // 
            // pic_minimize
            // 
            this.pic_minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_minimize.Image = global::MugiwaraChat2._0.Properties.Resources.Minimize_Window;
            this.pic_minimize.Location = new System.Drawing.Point(349, 3);
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
            this.pic_exit.Location = new System.Drawing.Point(382, 3);
            this.pic_exit.Name = "pic_exit";
            this.pic_exit.Size = new System.Drawing.Size(31, 28);
            this.pic_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_exit.TabIndex = 3;
            this.pic_exit.TabStop = false;
            this.pic_exit.Click += new System.EventHandler(this.pic_exit_Click);
            // 
            // SignUP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 594);
            this.Controls.Add(this.pic_pfp2);
            this.Controls.Add(this.pic_back);
            this.Controls.Add(this.btn_Signup);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.txt_ln);
            this.Controls.Add(this.txt_fn);
            this.Controls.Add(this.btn_upload);
            this.Controls.Add(this.pic_pfp);
            this.Controls.Add(this.toolbar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUP";
            this.toolbar.ResumeLayout(false);
            this.toolbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_pfp2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_pfp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel toolbar;
        private System.Windows.Forms.PictureBox pic_minimize;
        private System.Windows.Forms.PictureBox pic_exit;
        private System.Windows.Forms.Label label1;
        private PictureFormat pic_pfp;
        private System.Windows.Forms.Button btn_upload;
        private System.Windows.Forms.TextBox txt_fn;
        private System.Windows.Forms.TextBox txt_ln;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Signup;
        private System.Windows.Forms.PictureBox pic_back;
        private PictureFormat pic_pfp2;
    }
}