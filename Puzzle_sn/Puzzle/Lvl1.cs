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
        CLASAMENT clasament = new CLASAMENT();

        List<PictureBox> pictureBoxes = new List<PictureBox>();
        private void Lvl1_Load(object sender, EventArgs e)
        {
            this.pictureBox1.AllowDrop = true;
            this.pictureBox2.AllowDrop = true;
            this.pictureBox3.AllowDrop = true;
            this.pictureBox4.AllowDrop = true;
            //----------------------------
            MessageBox.Show(GLOBAL.selectedImg.ToString());
            this.timer1.Enabled = true;
            fillPicPozVal();
            //-----------------------------
            int rimg;
            string fn, poz;
            MemoryStream pic, stream;
            DataTable table;
            PictureBox pictureBox = new PictureBox();
            //List<PictureBox> pictureBoxes = new List<PictureBox>();
            pictureBoxes.Add(this.pictureBox1);
            pictureBoxes.Add(this.pictureBox2);
            pictureBoxes.Add(this.pictureBox3);
            pictureBoxes.Add(this.pictureBox4);
            //------------------save img into DB----------------------
            for (int i = 1; i <= 4; i++)
            {
                rimg = rand.Next(0, val.Count);
                fn = Application.StartupPath + @"\Img\image" + imgid.ToString() + @"\image" + imgid.ToString() + " [www.imagesplitter.net]-";
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
            fillPicPozVal();
        }

        public void fillPicPozVal()
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    string valname = i.ToString() + "-" + j.ToString();
                    val.Add(valname);
                }
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
            //-----------------------------------------------------------------------------
            if (gameOver())
            {
                updDB();
                MessageBox.Show("Victory");
            }
        }

        private void pictureBox2_DragDrop(object sender, DragEventArgs e)
        {
            draged_picture = new MemoryStream();
            this.pictureBox2.Image.Save(draged_picture, this.pictureBox2.Image.RawFormat);
            //-----------------------------------------------------------------------------
            this.pictureBox2.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap, true);

            //-----------------------------------------------------------------------------
            draged_pictureBox.Image = Image.FromStream(draged_picture);
            //-----------------------------------------------------------------------------
            if (gameOver())
            {
                updDB();
                MessageBox.Show("Victory");
            }
        }

        private void pictureBox3_DragDrop(object sender, DragEventArgs e)
        {
            draged_picture = new MemoryStream();
            this.pictureBox3.Image.Save(draged_picture, this.pictureBox3.Image.RawFormat);
            //-----------------------------------------------------------------------------
            this.pictureBox3.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap, true);
            //-----------------------------------------------------------------------------
            draged_pictureBox.Image = Image.FromStream(draged_picture);
            //-----------------------------------------------------------------------------
            if (gameOver())
            {
                updDB();
                MessageBox.Show("Victory");
            }
        }

        private void pictureBox4_DragDrop(object sender, DragEventArgs e)
        {
            draged_picture = new MemoryStream();
            this.pictureBox4.Image.Save(draged_picture, this.pictureBox4.Image.RawFormat);
            //-----------------------------------------------------------------------------
            this.pictureBox4.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap, true);
            //-----------------------------------------------------------------------------
            draged_pictureBox.Image = Image.FromStream(draged_picture);
            //-----------------------------------------------------------------------------
            if (gameOver())
            {
                updDB();
                MessageBox.Show("Victory");
            }
        }

        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            enter(e);
        }

        private void pictureBox2_DragEnter(object sender, DragEventArgs e)
        {
            enter(e);
        }

        private void pictureBox3_DragEnter(object sender, DragEventArgs e)
        {
            enter(e);
        }

        private void pictureBox4_DragEnter(object sender, DragEventArgs e)
        {
            enter(e);
        }

        public void enter(DragEventArgs e)
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

        public bool gameOver()
        {
            MemoryStream overPic, over_valid_pic;
            for (int i = 1; i <= 4; i++)
            {
                overPic = new MemoryStream();
                pictureBoxes[i - 1].Image.Save(overPic, pictureBoxes[i - 1].Image.RawFormat);

                DataTable table = pictures.getPic(val[i - 1]);
                byte[] img = (byte[])table.Rows[0][0];
                over_valid_pic = new MemoryStream(img);

                var ms1 = overPic.ToArray();
                var ms2 = over_valid_pic.ToArray();
                if (!ms1.SequenceEqual(ms2))
                {
                    return false;
                }
            }
            return true;
        }
        public void updDB()
        {
            string timp = this.label_hh.Text + ":" + this.label_mm.Text + ":" + this.label_ss.Text;
            string nume = GLOBAL.globalusername;
            int ptr = 4;
            if (clasament.insertClasament(nume, timp, ptr))
            {
                MessageBox.Show("Clasament Updated");
            }
            else
            {
                MessageBox.Show("Clasament error");
            }
        }
    }
}
