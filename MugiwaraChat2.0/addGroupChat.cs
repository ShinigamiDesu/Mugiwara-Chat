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
    public partial class addGroupChat : Form
    {
        public string loggedID {  get; set; }

        byte[] img;
        DataIO dataIO = new DataIO();

        public addGroupChat()
        {
            InitializeComponent();
        }

        private void pic_back_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_name.Text == "")
            {
                MessageBox.Show("Fill All Fields.");
            }
            else
            {
                if (pic_pfp.Image != null)
                {
                    int ID = int.Parse(loggedID);
                    dataIO.addGroupChat(ID, txt_name.Text, img);
                    this.Close();
                }
                else
                {
                    int ID = int.Parse(loggedID);
                    byte[] DefaultPic;
                    MemoryStream ms = new MemoryStream();
                    pic_pfp2.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    DefaultPic = ms.ToArray();
                    dataIO.addGroupChat(ID, txt_name.Text, DefaultPic);
                    this.Close();
                }
            }
        }
    }
}
