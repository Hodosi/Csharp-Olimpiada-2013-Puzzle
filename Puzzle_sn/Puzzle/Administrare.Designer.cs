namespace Puzzle
{
    partial class Administrare
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrare));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_Clasament = new System.Windows.Forms.TabPage();
            this.button_delete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage_Iesire = new System.Windows.Forms.TabPage();
            this.button_Iesire = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage_Clasament.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage_Iesire.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_Clasament);
            this.tabControl1.Controls.Add(this.tabPage_Iesire);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 495);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage_Clasament
            // 
            this.tabPage_Clasament.BackColor = System.Drawing.Color.Silver;
            this.tabPage_Clasament.Controls.Add(this.button_delete);
            this.tabPage_Clasament.Controls.Add(this.dataGridView1);
            this.tabPage_Clasament.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage_Clasament.Location = new System.Drawing.Point(4, 38);
            this.tabPage_Clasament.Name = "tabPage_Clasament";
            this.tabPage_Clasament.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Clasament.Size = new System.Drawing.Size(792, 453);
            this.tabPage_Clasament.TabIndex = 0;
            this.tabPage_Clasament.Text = "Clasament";
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(322, 399);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(159, 46);
            this.button_delete.TabIndex = 1;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(93, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(606, 387);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage_Iesire
            // 
            this.tabPage_Iesire.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage_Iesire.BackgroundImage")));
            this.tabPage_Iesire.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage_Iesire.Controls.Add(this.button_Iesire);
            this.tabPage_Iesire.Location = new System.Drawing.Point(4, 38);
            this.tabPage_Iesire.Name = "tabPage_Iesire";
            this.tabPage_Iesire.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Iesire.Size = new System.Drawing.Size(792, 453);
            this.tabPage_Iesire.TabIndex = 1;
            this.tabPage_Iesire.Text = "Iesire";
            this.tabPage_Iesire.UseVisualStyleBackColor = true;
            // 
            // button_Iesire
            // 
            this.button_Iesire.BackColor = System.Drawing.Color.Gray;
            this.button_Iesire.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Iesire.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button_Iesire.Location = new System.Drawing.Point(198, 93);
            this.button_Iesire.Name = "button_Iesire";
            this.button_Iesire.Size = new System.Drawing.Size(103, 64);
            this.button_Iesire.TabIndex = 1;
            this.button_Iesire.Text = "Iesire";
            this.button_Iesire.UseVisualStyleBackColor = false;
            this.button_Iesire.Click += new System.EventHandler(this.button_Iesire_Click);
            // 
            // Administrare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 495);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Administrare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrare";
            this.Load += new System.EventHandler(this.Administrare_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage_Clasament.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage_Iesire.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_Clasament;
        private System.Windows.Forms.TabPage tabPage_Iesire;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_Iesire;
    }
}