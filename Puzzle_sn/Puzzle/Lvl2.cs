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
    public partial class Lvl2 : Form
    {
        public Lvl2()
        {
            InitializeComponent();
        }

        private void Lvl2_Load(object sender, EventArgs e)
        {
            MessageBox.Show(GLOBAL.selectedImg.ToString());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
