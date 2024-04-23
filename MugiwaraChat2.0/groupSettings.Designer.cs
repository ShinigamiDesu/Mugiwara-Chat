namespace MugiwaraChat2._0
{
    partial class groupSettings
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
            this.btn_leave = new System.Windows.Forms.Button();
            this.members_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.pic_red = new System.Windows.Forms.PictureBox();
            this.pic_green = new System.Windows.Forms.PictureBox();
            this.pic_back = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_total = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_back)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_leave
            // 
            this.btn_leave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_leave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_leave.Font = new System.Drawing.Font("Poppins ExtraLight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_leave.ForeColor = System.Drawing.Color.White;
            this.btn_leave.Location = new System.Drawing.Point(3, 3);
            this.btn_leave.Name = "btn_leave";
            this.btn_leave.Size = new System.Drawing.Size(193, 47);
            this.btn_leave.TabIndex = 1;
            this.btn_leave.Text = "LEAVE GROUP";
            this.btn_leave.UseVisualStyleBackColor = false;
            this.btn_leave.Click += new System.EventHandler(this.btn_leave_Click);
            // 
            // members_panel
            // 
            this.members_panel.AutoScroll = true;
            this.members_panel.Location = new System.Drawing.Point(0, 99);
            this.members_panel.Margin = new System.Windows.Forms.Padding(0);
            this.members_panel.Name = "members_panel";
            this.members_panel.Size = new System.Drawing.Size(480, 497);
            this.members_panel.TabIndex = 2;
            // 
            // pic_red
            // 
            this.pic_red.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pic_red.Image = global::MugiwaraChat2._0.Properties.Resources.Red_Circle;
            this.pic_red.Location = new System.Drawing.Point(395, 5);
            this.pic_red.Margin = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.pic_red.Name = "pic_red";
            this.pic_red.Size = new System.Drawing.Size(35, 35);
            this.pic_red.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_red.TabIndex = 9;
            this.pic_red.TabStop = false;
            this.pic_red.Visible = false;
            // 
            // pic_green
            // 
            this.pic_green.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pic_green.Image = global::MugiwaraChat2._0.Properties.Resources.Green_Circle;
            this.pic_green.Location = new System.Drawing.Point(354, 5);
            this.pic_green.Margin = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.pic_green.Name = "pic_green";
            this.pic_green.Size = new System.Drawing.Size(35, 35);
            this.pic_green.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_green.TabIndex = 8;
            this.pic_green.TabStop = false;
            this.pic_green.Visible = false;
            // 
            // pic_back
            // 
            this.pic_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_back.Image = global::MugiwaraChat2._0.Properties.Resources.Go_Back;
            this.pic_back.Location = new System.Drawing.Point(432, 5);
            this.pic_back.Name = "pic_back";
            this.pic_back.Size = new System.Drawing.Size(44, 44);
            this.pic_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_back.TabIndex = 10;
            this.pic_back.TabStop = false;
            this.pic_back.Click += new System.EventHandler(this.pic_back_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(3, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 1);
            this.panel1.TabIndex = 11;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Poppins ExtraLight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(3, 59);
            this.lbl_total.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(28, 37);
            this.lbl_total.TabIndex = 12;
            this.lbl_total.Text = "X";
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.SystemColors.Control;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_add.Font = new System.Drawing.Font("Poppins ExtraLight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.Black;
            this.btn_add.Location = new System.Drawing.Point(199, 3);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(111, 47);
            this.btn_add.TabIndex = 13;
            this.btn_add.Text = "Add Member";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // groupSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.pic_back);
            this.Controls.Add(this.pic_red);
            this.Controls.Add(this.pic_green);
            this.Controls.Add(this.members_panel);
            this.Controls.Add(this.btn_leave);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "groupSettings";
            this.Size = new System.Drawing.Size(480, 596);
            this.Load += new System.EventHandler(this.groupSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_leave;
        private System.Windows.Forms.FlowLayoutPanel members_panel;
        private System.Windows.Forms.PictureBox pic_red;
        private System.Windows.Forms.PictureBox pic_green;
        private System.Windows.Forms.PictureBox pic_back;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Button btn_add;
    }
}
