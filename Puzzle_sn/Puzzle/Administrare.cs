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
    public partial class Administrare : Form
    {
        public Administrare()
        {
            InitializeComponent();
        }

        CLASAMENT clasament = new CLASAMENT();
        private void Administrare_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = clasament.getClasament();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            if (clasament.deletUser(id))
            {
                this.dataGridView1.DataSource = clasament.getClasament();
                MessageBox.Show("user deleted");
            }
            else
            {
                MessageBox.Show("error");
            }
        }
    }
}
