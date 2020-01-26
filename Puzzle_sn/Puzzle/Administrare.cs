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
            try
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button_Iesire_Click(object sender, EventArgs e)
        {
            string fn = Application.StartupPath + @"\Clasament.txt";
            DataTable table = clasament.getClasament();
            string row = "";
            System.IO.File.AppendAllText(fn, "\n\n");
            System.IO.File.AppendAllText(fn, "Clasament Nou");
            System.IO.File.AppendAllText(fn, "\n\n");
            for (int i = 0; i < table.Rows.Count; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    row += dataGridView1.Rows[i].Cells[j].Value.ToString() + " ";
                }
                System.IO.File.AppendAllText(fn, row);
                System.IO.File.AppendAllText(fn, "\n");
                row = "";
            }
            this.Close();
        }
    }
}
