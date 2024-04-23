namespace MugiwaraChat2._0
{
    partial class fromMessage
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
            this.roundedPanel1 = new RoundedPanel();
            this.lbl_Message = new System.Windows.Forms.Label();
            this.pic_PFP = new MugiwaraChat2._0.PictureFormat();
            this.roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_PFP)).BeginInit();
            this.SuspendLayout();
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.AutoSize = true;
            this.roundedPanel1.BackColor = System.Drawing.Color.White;
            this.roundedPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roundedPanel1.Controls.Add(this.lbl_Message);
            this.roundedPanel1.CornerRadius = 100;
            this.roundedPanel1.Location = new System.Drawing.Point(71, 14);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(77, 38);
            this.roundedPanel1.TabIndex = 16;
            // 
            // lbl_Message
            // 
            this.lbl_Message.AutoSize = true;
            this.lbl_Message.Font = new System.Drawing.Font("Poppins ExtraLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Message.Location = new System.Drawing.Point(0, 0);
            this.lbl_Message.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_Message.MaximumSize = new System.Drawing.Size(375, 0);
            this.lbl_Message.Name = "lbl_Message";
            this.lbl_Message.Size = new System.Drawing.Size(66, 34);
            this.lbl_Message.TabIndex = 0;
            this.lbl_Message.Text = "label1";
            // 
            // pic_PFP
            // 
            this.pic_PFP.Image = global::MugiwaraChat2._0.Properties.Resources.Screenshot_2023_12_24_075037;
            this.pic_PFP.Location = new System.Drawing.Point(8, 0);
            this.pic_PFP.Margin = new System.Windows.Forms.Padding(0);
            this.pic_PFP.Name = "pic_PFP";
            this.pic_PFP.Size = new System.Drawing.Size(60, 60);
            this.pic_PFP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_PFP.TabIndex = 15;
            this.pic_PFP.TabStop = false;
            // 
            // fromMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.roundedPanel1);
            this.Controls.Add(this.pic_PFP);
            this.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.MaximumSize = new System.Drawing.Size(455, 0);
            this.MinimumSize = new System.Drawing.Size(455, 0);
            this.Name = "fromMessage";
            this.Size = new System.Drawing.Size(455, 60);
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_PFP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureFormat pic_PFP;
        private System.Windows.Forms.Label lbl_Message;
        private RoundedPanel roundedPanel1;
    }
}
