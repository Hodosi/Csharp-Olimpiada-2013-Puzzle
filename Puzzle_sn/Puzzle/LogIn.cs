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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        string nume_user="";
        private void button_jucator_Click(object sender, EventArgs e)
        {
            if (this.textBox_pass.Text == "jucator")
            {
                nume_user = this.textBox_nume.Text;
                GLOBAL.globalusername = nume_user;
                Joc jf = new Joc();
                jf.ShowDialog();
            }
            else
            {
                MessageBox.Show("Parola Invalida!");
            }
        }

        private void button_admin_Click(object sender, EventArgs e)
        {
            if (this.textBox_pass.Text == "administrator")
            {
                //nume_user = this.textBox_nume.Text;
                Administrare af = new Administrare();
                af.ShowDialog();
            }
            else
            {
                MessageBox.Show("Parola Invalida!");
            }
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }
    }
}
