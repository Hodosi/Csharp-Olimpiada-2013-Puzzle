using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Puzzle
{
    public partial class Lvl1 : Form
    {
        public Lvl1()
        {
            InitializeComponent();
        }

        int time = 0;
        int imgid = GLOBAL.selectedImg;
        List<string> val = new List<string>();
        Random rand = new Random();
        private void Lvl1_Load(object sender, EventArgs e)
        {
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

            int rimg = rand.Next(0, val.Count);
            string fn = Application.StartupPath + @"\Img\image" + imgid.ToString() + @"\image" + imgid.ToString() + @" [www.imagesplitter.net]-";
            fn = fn + val[rimg].ToString() + ".jpeg";
            this.pictureBox1.Image = Image.FromFile(fn);
            val.RemoveAt(rimg);

            rimg = rand.Next(0, val.Count);
            fn = Application.StartupPath + @"\Img\image" + imgid.ToString() + @"\image" + imgid.ToString() + @" [www.imagesplitter.net]-";
            fn = fn + val[rimg].ToString() + ".jpeg";
            this.pictureBox2.Image = Image.FromFile(fn);
            val.RemoveAt(rimg);

            rimg = rand.Next(0, val.Count);
            fn = Application.StartupPath + @"\Img\image" + imgid.ToString() + @"\image" + imgid.ToString() + @" [www.imagesplitter.net]-";
            fn = fn + val[rimg].ToString() + ".jpeg";
            this.pictureBox3.Image = Image.FromFile(fn);
            val.RemoveAt(rimg);

            rimg = rand.Next(0, val.Count);
            fn = Application.StartupPath + @"\Img\image" + imgid.ToString() + @"\image" + imgid.ToString() + @" [www.imagesplitter.net]-";
            fn = fn + val[rimg].ToString() + ".jpeg";
            this.pictureBox4.Image = Image.FromFile(fn);
            val.RemoveAt(rimg);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
        }
    }
}
