namespace MugiwaraChat2._0
{
    partial class addGroupChat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addGroupChat));
            this.pic_pfp2 = new MugiwaraChat2._0.PictureFormat();
            this.pic_back = new System.Windows.Forms.PictureBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.btn_upload = new System.Windows.Forms.Button();
            this.pic_pfp = new MugiwaraChat2._0.PictureFormat();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_pfp2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_pfp)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_pfp2
            // 
            this.pic_pfp2.BackColor = System.Drawing.Color.White;
            this.pic_pfp2.Image = global::MugiwaraChat2._0.Properties.Resources.Male_User;
            this.pic_pfp2.Location = new System.Drawing.Point(314, 9);
            this.pic_pfp2.Margin = new System.Windows.Forms.Padding(0);
            this.pic_pfp2.Name = "pic_pfp2";
            this.pic_pfp2.Size = new System.Drawing.Size(83, 81);
            this.pic_pfp2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_pfp2.TabIndex = 26;
            this.pic_pfp2.TabStop = false;
            this.pic_pfp2.Visible = false;
            // 
            // pic_back
            // 
            this.pic_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_back.Image = global::MugiwaraChat2._0.Properties.Resources.Go_Back;
            this.pic_back.Location = new System.Drawing.Point(12, 383);
            this.pic_back.Name = "pic_back";
            this.pic_back.Size = new System.Drawing.Size(44, 44);
            this.pic_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_back.TabIndex = 17;
            this.pic_back.TabStop = false;
            this.pic_back.Click += new System.EventHandler(this.pic_back_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.White;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_add.Font = new System.Drawing.Font("Poppins ExtraLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(122, 369);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(148, 33);
            this.btn_add.TabIndex = 25;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Poppins ExtraLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(92, 318);
            this.txt_name.MaxLength = 25;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(217, 27);
            this.txt_name.TabIndex = 21;
            // 
            // btn_upload
            // 
            this.btn_upload.BackColor = System.Drawing.Color.White;
            this.btn_upload.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_upload.Font = new System.Drawing.Font("Poppins ExtraLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_upload.Location = new System.Drawing.Point(122, 234);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Size = new System.Drawing.Size(148, 31);
            this.btn_upload.TabIndex = 15;
            this.btn_upload.Text = "UPLOAD";
            this.btn_upload.UseVisualStyleBackColor = false;
            this.btn_upload.Click += new System.EventHandler(this.btn_upload_Click);
            // 
            // pic_pfp
            // 
            this.pic_pfp.BackColor = System.Drawing.SystemColors.Control;
            this.pic_pfp.Location = new System.Drawing.Point(85, 9);
            this.pic_pfp.Name = "pic_pfp";
            this.pic_pfp.Size = new System.Drawing.Size(224, 216);
            this.pic_pfp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_pfp.TabIndex = 14;
            this.pic_pfp.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins ExtraLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(87, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 28);
            this.label5.TabIndex = 24;
            this.label5.Text = "Group Name:";
            // 
            // addGroupChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(402, 436);
            this.Controls.Add(this.pic_pfp2);
            this.Controls.Add(this.pic_back);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.btn_upload);
            this.Controls.Add(this.pic_pfp);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "addGroupChat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addGroupChat";
            ((System.ComponentModel.ISupportInitialize)(this.pic_pfp2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_pfp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureFormat pic_pfp2;
        private System.Windows.Forms.PictureBox pic_back;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Button btn_upload;
        private PictureFormat pic_pfp;
        private System.Windows.Forms.Label label5;
    }
}