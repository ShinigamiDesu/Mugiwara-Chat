namespace MugiwaraChat2._0
{
    partial class Text2
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
            this.lbl_req = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(4, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 1);
            this.panel1.TabIndex = 7;
            // 
            // lbl_req
            // 
            this.lbl_req.AutoSize = true;
            this.lbl_req.Font = new System.Drawing.Font("Poppins ExtraLight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_req.Location = new System.Drawing.Point(4, 3);
            this.lbl_req.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.lbl_req.Name = "lbl_req";
            this.lbl_req.Size = new System.Drawing.Size(28, 37);
            this.lbl_req.TabIndex = 8;
            this.lbl_req.Text = "X";
            this.lbl_req.Click += new System.EventHandler(this.lbl_req_Click);
            // 
            // Text2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_req);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Text2";
            this.Size = new System.Drawing.Size(455, 42);
            this.Load += new System.EventHandler(this.Text2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_req;
    }
}
