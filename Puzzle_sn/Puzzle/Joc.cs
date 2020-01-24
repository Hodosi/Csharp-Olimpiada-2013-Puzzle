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
    public partial class Joc : Form
    {
        public Joc()
        {
            InitializeComponent();
        }

        int slectedimg = 0;
        private void Joc_Load(object sender, EventArgs e)
        {
            string fn = Application.StartupPath + @"\Img";
            fn = fn + @"\image" + "1" + @"\image" + "1" + ".jpg";
            this.pictureBox1.Image = Image.FromFile(fn);

            fn = Application.StartupPath + @"\Img";
            fn = fn + @"\image" + "2" + @"\image" + "2" + ".jpg";
            this.pictureBox2.Image = Image.FromFile(fn);

            fn = Application.StartupPath + @"\Img";
            fn = fn + @"\image" + "3" + @"\image" + "3" + ".jpg";
            this.pictureBox3.Image = Image.FromFile(fn);

            fn = Application.StartupPath + @"\Img";
            fn = fn + @"\image" + "4" + @"\image" + "4" + ".jpg";
            this.pictureBox4.Image = Image.FromFile(fn);

            fn = Application.StartupPath + @"\Img";
            fn = fn + @"\image" + "5" + @"\image" + "5" + ".jpg";
            this.pictureBox5.Image = Image.FromFile(fn);

            fn = Application.StartupPath + @"\Img";
            fn = fn + @"\image" + "6" + @"\image" + "6" + ".jpg";
            this.pictureBox6.Image = Image.FromFile(fn);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            slectedimg = 0;
            if (this.comboBox1.SelectedItem.ToString() == "4")
            {
                this.pictureBox1.Enabled = false;
                this.pictureBox1.Visible = false;
                this.pictureBox2.Enabled = false;
                this.pictureBox2.Visible = false;
                this.pictureBox3.Enabled = false;
                this.pictureBox3.Visible = false;
                this.pictureBox5.Enabled = false;
                this.pictureBox5.Visible = false;

                this.pictureBox4.Visible = true;
                this.pictureBox6.Visible = true;

            }
            else if (this.comboBox1.SelectedItem.ToString() == "9")
            {
                this.pictureBox4.Enabled = false;
                this.pictureBox4.Visible = false;
                this.pictureBox6.Enabled = false;
                this.pictureBox6.Visible = false;

                this.pictureBox1.Visible = true;
                this.pictureBox2.Visible = true;
                this.pictureBox3.Visible = true;
                this.pictureBox5.Visible = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            slectedimg = 1;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            slectedimg = 2;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            slectedimg = 3;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            slectedimg = 4;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            slectedimg = 5;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            slectedimg = 6;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (slectedimg == 0 || this.comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Selectati numarul de patratele si o imagine");
            }
            else 
            {
                if (this.comboBox1.SelectedItem.ToString() == "4")
                {
                    GLOBAL.selectedImg = slectedimg;
                    Lvl1 l1 = new Lvl1();
                    l1.ShowDialog();
                }
                else if (this.comboBox1.SelectedItem.ToString() == "9")
                {
                    GLOBAL.selectedImg = slectedimg;
                    Lvl2 l2 = new Lvl2();
                    l2.ShowDialog();
                }
            }
        }
    }
}
