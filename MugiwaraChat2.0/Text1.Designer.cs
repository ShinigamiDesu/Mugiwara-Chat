namespace MugiwaraChat2._0
{
    partial class Text1
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
            this.lbl_chat = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pic_refresh = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_refresh)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_chat
            // 
            this.lbl_chat.AutoSize = true;
            this.lbl_chat.Font = new System.Drawing.Font("Poppins ExtraLight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_chat.Location = new System.Drawing.Point(0, 0);
            this.lbl_chat.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.lbl_chat.Name = "lbl_chat";
            this.lbl_chat.Size = new System.Drawing.Size(202, 48);
            this.lbl_chat.TabIndex = 3;
            this.lbl_chat.Text = "Recent Chats:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(3, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 1);
            this.panel1.TabIndex = 4;
            // 
            // pic_refresh
            // 
            this.pic_refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_refresh.Image = global::MugiwaraChat2._0.Properties.Resources.Refresh;
            this.pic_refresh.Location = new System.Drawing.Point(414, 2);
            this.pic_refresh.Margin = new System.Windows.Forms.Padding(120, 15, 0, 0);
            this.pic_refresh.Name = "pic_refresh";
            this.pic_refresh.Size = new System.Drawing.Size(39, 36);
            this.pic_refresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_refresh.TabIndex = 5;
            this.pic_refresh.TabStop = false;
            this.pic_refresh.Click += new System.EventHandler(this.pic_refresh_Click);
            // 
            // Text1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pic_refresh);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_chat);
            this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.Name = "Text1";
            this.Size = new System.Drawing.Size(455, 42);
            this.Load += new System.EventHandler(this.Text1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_refresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_chat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pic_refresh;
    }
}
