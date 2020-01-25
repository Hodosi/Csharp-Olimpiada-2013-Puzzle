using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Puzzle
{
    public partial class Lvl1 : Form
    {
        public Lvl1()
        {
            InitializeComponent();
        }
        List<string> val = new List<string>();
        int imgid = GLOBAL.selectedImg;
        Random rand = new Random();
        PICTURES pictures = new PICTURES();
        MemoryStream draged_picture;
        PictureBox draged_pictureBox;

        List<PictureBox> pictureBoxes = new List<PictureBox>();
        private void Lvl1_Load(object sender, EventArgs e)
        {
            this.pictureBox1.AllowDrop = true;
            this.pictureBox2.AllowDrop = true;
            this.pictureBox3.AllowDrop = true;
            this.pictureBox4.AllowDrop = true;
            //---------------------------------
            timer1.Enabled = true;
            //----------------------------
            MessageBox.Show(GLOBAL.selectedImg.ToString());
            this.timer1.Enabled = true;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    string valname = i.ToString() + "-" + j.ToString();
                    val.Add(valname);
                }
            }
            //-----------------------------
            int rimg;
            string fn, poz;
            MemoryStream pic, stream;
            DataTable table;
            //List<PictureBox> pictureBoxes = new List<PictureBox>();
            pictureBoxes.Add(this.pictureBox1);
            pictureBoxes.Add(this.pictureBox2);
            pictureBoxes.Add(this.pictureBox3);
            pictureBoxes.Add(this.pictureBox4);
            //------------------save img into DB----------------------
            PictureBox pictureBox = new PictureBox();
            for (int i = 1; i <= 4; i++)
            {
                rimg = rand.Next(0, val.Count);
                fn = Application.StartupPath + @"\Img\image"+imgid.ToString()+@"\image"+imgid.ToString()+ " [www.imagesplitter.net]-";
                fn = fn + val[rimg].ToString() + ".jpeg";
                poz = val[rimg];
                val.RemoveAt(rimg);
                pictureBox.Image = Image.FromFile(fn);
                pic = new MemoryStream();
                pictureBox.Image.Save(pic, pictureBox.Image.RawFormat);
                if (pictures.insertPic(imgid, poz, fn, pic))
                {
                    MessageBox.Show("Pic added");
                }
                else
                {
                    MessageBox.Show("Insertion Error");
                }
                table = pictures.getPic(poz);
                byte[] img = (byte[])table.Rows[0][0];
                stream = new MemoryStream(img);
                pictureBoxes[i - 1].Image = Image.FromStream(stream);
                
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            getTime();
        }

        public void getTime()
        {
            if (this.label_ss.Text == "59")
            {
                if (this.label_mm.Text == "59")
                {
                    int hh = Convert.ToInt32(this.label_hh.Text);
                    hh++;
                    this.label_hh.Text = hh.ToString();
                    this.label_mm.Text = "00";
                }
                else
                {
                    int mm = Convert.ToInt32(this.label_mm.Text);
                    mm++;
                    this.label_mm.Text = mm.ToString();
                    this.label_ss.Text = "00";
                }
            }
            else
            {
                int ss = Convert.ToInt32(this.label_ss.Text);
                ss++;
                this.label_ss.Text = ss.ToString();
            }
                

        }

        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            draged_picture = new MemoryStream();
            this.pictureBox1.Image.Save(draged_picture, this.pictureBox1.Image.RawFormat);
            //-----------------------------------------------------------------------------
            this.pictureBox1.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap, true);
            //-----------------------------------------------------------------------------
            draged_pictureBox.Image = Image.FromStream(draged_picture);
        }

        private void pictureBox2_DragDrop(object sender, DragEventArgs e)
        {
            draged_picture = new MemoryStream();
            this.pictureBox2.Image.Save(draged_picture, this.pictureBox2.Image.RawFormat);
            //-----------------------------------------------------------------------------
            this.pictureBox2.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap, true);

            //-----------------------------------------------------------------------------
            draged_pictureBox.Image = Image.FromStream(draged_picture);

        }

        private void pictureBox3_DragDrop(object sender, DragEventArgs e)
        {
            draged_picture = new MemoryStream();
            this.pictureBox3.Image.Save(draged_picture, this.pictureBox3.Image.RawFormat);
            //-----------------------------------------------------------------------------
            this.pictureBox3.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap, true);
            //-----------------------------------------------------------------------------
            draged_pictureBox.Image = Image.FromStream(draged_picture);
        }

        private void pictureBox4_DragDrop(object sender, DragEventArgs e)
        {
            draged_picture = new MemoryStream();
            this.pictureBox4.Image.Save(draged_picture, this.pictureBox4.Image.RawFormat);
            //-----------------------------------------------------------------------------
            this.pictureBox4.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap, true);
            //-----------------------------------------------------------------------------
            draged_pictureBox.Image = Image.FromStream(draged_picture);
        }

        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void pictureBox2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
            {

                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void pictureBox3_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void pictureBox4_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
            {

                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                draged_pictureBox = new PictureBox();
                draged_pictureBox = pictureBoxes[0];
                this.pictureBox1.DoDragDrop(this.pictureBox1.Image, DragDropEffects.Copy);
            }
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                draged_pictureBox = new PictureBox();
                draged_pictureBox = pictureBoxes[1];
                this.pictureBox2.DoDragDrop(this.pictureBox2.Image, DragDropEffects.Copy);
            }
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                draged_pictureBox = new PictureBox();
                draged_pictureBox = pictureBoxes[2];
                this.pictureBox3.DoDragDrop(this.pictureBox3.Image, DragDropEffects.Copy);
            }
        }

        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                draged_pictureBox = new PictureBox();
                draged_pictureBox = pictureBoxes[3];
                this.pictureBox4.DoDragDrop(this.pictureBox4.Image, DragDropEffects.Copy);
            }
        }
    }
}
