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

        private void button_jucator_Click(object sender, EventArgs e)
        {
            if (this.textBox_pass.Text == "jucator" && this.textBox_nume.Text.Trim() != "")
            {
                string nume_user = this.textBox_nume.Text;
                GLOBAL.globalusername = nume_user;
                Joc jf = new Joc();
                jf.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Introduceti o parola si un nume valid!");
            }
        }

        private void button_admin_Click(object sender, EventArgs e)
        {
            if (this.textBox_pass.Text == "administrator" && this.textBox_nume.Text== "admin")
            {
                Administrare af = new Administrare();
                af.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Nume sau Parola invalida!");
            }
        }
    }
}
