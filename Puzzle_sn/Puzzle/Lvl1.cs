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
        int imgPat = GLOBAL.selectedPat;
        Random rand = new Random();
        PICTURES pictures = new PICTURES();
        MemoryStream draged_picture;
        PictureBox draged_pictureBox;
        CLASAMENT clasament = new CLASAMENT();

        List<PictureBox> pictureBoxes = new List<PictureBox>();
        private void Lvl1_Load(object sender, EventArgs e)
        {
            if (imgPat == 4)
            {
                this.panel1.Location = new Point(this.panel1.Location.X + 200, this.panel1.Location.Y + 100);
                this.pictureBox5.Visible = false;
                this.pictureBox6.Visible = false;
                this.pictureBox7.Visible = false;
                this.pictureBox8.Visible = false;
                this.pictureBox9.Visible = false;

            }
            this.pictureBox1.AllowDrop = true;
            this.pictureBox2.AllowDrop = true;
            this.pictureBox3.AllowDrop = true;
            this.pictureBox4.AllowDrop = true;
            if (imgPat == 9)
            {
                this.pictureBox5.AllowDrop = true;
                this.pictureBox6.AllowDrop = true;
                this.pictureBox7.AllowDrop = true;
                this.pictureBox8.AllowDrop = true;
                this.pictureBox9.AllowDrop = true;
            }
            //----------------------------
            //MessageBox.Show(GLOBAL.selectedImg.ToString());
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
            if (imgPat == 9)
            {
                pictureBoxes.Add(this.pictureBox5);
                pictureBoxes.Add(this.pictureBox6);
                pictureBoxes.Add(this.pictureBox7);
                pictureBoxes.Add(this.pictureBox8);
                pictureBoxes.Add(this.pictureBox9);
            }
            //------------------clear DB------------------------------
            pictures.deletePic();
            //------------------save img into DB----------------------
            for (int i = 1; i <= imgPat; i++)
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
                   // MessageBox.Show("Pic added");
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
            int k = 0;
            if (imgPat == 4)
            {
                k = 2;
            }
            else
            {
                k = 3;
            }
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < k; j++)
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
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            down(0, e);
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            down(1, e);
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            down(2, e);
        }

        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            down(3, e);
        }
        private void pictureBox5_MouseDown(object sender, MouseEventArgs e)
        {
            down(4, e);
        }

        private void pictureBox6_MouseDown(object sender, MouseEventArgs e)
        {
            down(5, e);
        }

        private void pictureBox7_MouseDown(object sender, MouseEventArgs e)
        {
            down(6, e);
        }

        private void pictureBox8_MouseDown(object sender, MouseEventArgs e)
        {
            down(7, e);
        }

        private void pictureBox9_MouseDown(object sender, MouseEventArgs e)
        {
            down(8, e);
        }

        public void down(int i, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                draged_pictureBox = new PictureBox();
                draged_pictureBox = pictureBoxes[i];
                pictureBoxes[i].DoDragDrop(pictureBoxes[i].Image, DragDropEffects.Copy);
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
        private void pictureBox5_DragEnter(object sender, DragEventArgs e)
        {
            enter(e);
        }

        private void pictureBox6_DragEnter(object sender, DragEventArgs e)
        {
            enter(e);
        }

        private void pictureBox7_DragEnter(object sender, DragEventArgs e)
        {
            enter(e);
        }

        private void pictureBox8_DragEnter(object sender, DragEventArgs e)
        {
            enter(e);
        }

        private void pictureBox9_DragEnter(object sender, DragEventArgs e)
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

        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            drop(0, e);
        }

        private void pictureBox2_DragDrop(object sender, DragEventArgs e)
        {
            drop(1, e);
        }

        private void pictureBox3_DragDrop(object sender, DragEventArgs e)
        {
            drop(2, e);
        }

        private void pictureBox4_DragDrop(object sender, DragEventArgs e)
        {
            drop(3, e);
        }
        private void pictureBox5_DragDrop(object sender, DragEventArgs e)
        {
            drop(4, e);
        }

        private void pictureBox6_DragDrop(object sender, DragEventArgs e)
        {
            drop(5, e);
        }

        private void pictureBox7_DragDrop(object sender, DragEventArgs e)
        {
            drop(6, e);
        }

        private void pictureBox8_DragDrop(object sender, DragEventArgs e)
        {
            drop(7, e);
        }

        private void pictureBox9_DragDrop(object sender, DragEventArgs e)
        {
            drop(8, e);
        }

        public void drop(int i, DragEventArgs e)
        {
            draged_picture = new MemoryStream();
            pictureBoxes[i].Image.Save(draged_picture, pictureBoxes[i].Image.RawFormat);
            //-----------------------------------------------------------------------------
            pictureBoxes[i].Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap, true);
            //-----------------------------------------------------------------------------
            draged_pictureBox.Image = Image.FromStream(draged_picture);
            //-----------------------------------------------------------------------------
            if (gameOver())
            {
                updDB();
                Joc joc_form = new Joc();
                joc_form.dataGridView1.DataSource = clasament.getClasament();
                MessageBox.Show("Victory");
                this.Close();
            }
        }

        public bool gameOver()
        {
            if (imgPat == 4)
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
            else
            {
                if(over(1, 1) && over(2, 2) && over(5,3) && over(3,4) && over(4,5) && over(6,6) && over(7,7) && over(8,8) && over(9,9))
                {
                    return true;
                }
                return false;
            }
        }

        public bool over(int i,int j)
        {
            MemoryStream overPic, over_valid_pic;
            overPic = new MemoryStream();
            pictureBoxes[i - 1].Image.Save(overPic, pictureBoxes[i - 1].Image.RawFormat);

            DataTable table = pictures.getPic(val[j - 1]);
            byte[] img = (byte[])table.Rows[0][0];
            over_valid_pic = new MemoryStream(img);

            var ms1 = overPic.ToArray();
            var ms2 = over_valid_pic.ToArray();
            if (!ms1.SequenceEqual(ms2))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void updDB()
        {
            string timp = this.label_hh.Text + ":" + this.label_mm.Text + ":" + this.label_ss.Text;
            string nume = GLOBAL.globalusername;
            int ptr = imgPat;
            if (clasament.insertClasament(nume, timp, ptr))
            {
              //  MessageBox.Show("Clasament Updated");
            }
            else
            {
                MessageBox.Show("Clasament error");
            }
        }
    }
}
