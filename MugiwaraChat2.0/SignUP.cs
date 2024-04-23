using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MugiwaraChat2._0
{
    public partial class SignUP : Form
    {
        byte[] img;
        DataIO dataIO = new DataIO();
        bool drag = false;
        Point start_point = new Point(0, 0);
        #region Drag
        private void toolbar_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void toolbar_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void toolbar_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
            }
        }
        #endregion


        public SignUP()
        {
            InitializeComponent();
        }

        private void pic_exit_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            string ImagePath = "";

            OpenFileDialog Dialog = new OpenFileDialog();
            Dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All Files(*.*)|*.*";
            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                ImagePath = Dialog.FileName.ToString();
                pic_pfp.ImageLocation = ImagePath;
                byte[] imagebyte = null;
                FileStream fs = new FileStream(ImagePath, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                imagebyte = br.ReadBytes((int)fs.Length);
                img = imagebyte;
            }
        }

        private void btn_Signup_Click(object sender, EventArgs e)
        {
            if(txt_fn.Text == "" ||  txt_fn.Text == "" || txt_username.Text == "" || txt_password.Text == "")
            {
                MessageBox.Show("Fill All Fields.");
            }
            else 
            {
                if (dataIO.CheckAvailableUsername(txt_username.Text)) 
                {
                    MessageBox.Show("Username Taken.");
                }
                else 
                {
                    if (pic_pfp.Image != null)
                    {
                        dataIO.AddUser(txt_username.Text, txt_password.Text, txt_fn.Text, txt_ln.Text, img);
                        txt_username.Text = "";
                        txt_password.Text = "";
                        txt_fn.Text = "";
                        txt_ln.Text = "";
                        pic_pfp.Image = null;
                    }
                    else
                    {
                        byte[] DefaultPic;
                        MemoryStream ms = new MemoryStream();
                        pic_pfp2.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        DefaultPic = ms.ToArray();
                        dataIO.AddUser(txt_username.Text, txt_password.Text, txt_fn.Text, txt_ln.Text, DefaultPic);
                    }
                }
            }
        }

        private void pic_back_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Close();
        }
    }
}
