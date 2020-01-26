namespace Puzzle
{
    partial class LogIn
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
            this.textBox_pass = new System.Windows.Forms.TextBox();
            this.textBox_nume = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_jucator = new System.Windows.Forms.Button();
            this.button_admin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_pass
            // 
            this.textBox_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_pass.Location = new System.Drawing.Point(159, 147);
            this.textBox_pass.Name = "textBox_pass";
            this.textBox_pass.PasswordChar = '*';
            this.textBox_pass.Size = new System.Drawing.Size(244, 30);
            this.textBox_pass.TabIndex = 0;
            // 
            // textBox_nume
            // 
            this.textBox_nume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_nume.Location = new System.Drawing.Point(159, 70);
            this.textBox_nume.Name = "textBox_nume";
            this.textBox_nume.Size = new System.Drawing.Size(244, 30);
            this.textBox_nume.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nume:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Parola:";
            // 
            // button_jucator
            // 
            this.button_jucator.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_jucator.Location = new System.Drawing.Point(74, 242);
            this.button_jucator.Name = "button_jucator";
            this.button_jucator.Size = new System.Drawing.Size(329, 44);
            this.button_jucator.TabIndex = 4;
            this.button_jucator.Text = "Jucator";
            this.button_jucator.UseVisualStyleBackColor = true;
            this.button_jucator.Click += new System.EventHandler(this.button_jucator_Click);
            // 
            // button_admin
            // 
            this.button_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_admin.Location = new System.Drawing.Point(74, 339);
            this.button_admin.Name = "button_admin";
            this.button_admin.Size = new System.Drawing.Size(329, 44);
            this.button_admin.TabIndex = 5;
            this.button_admin.Text = "Administrator";
            this.button_admin.UseVisualStyleBackColor = true;
            this.button_admin.Click += new System.EventHandler(this.button_admin_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 450);
            this.Controls.Add(this.button_admin);
            this.Controls.Add(this.button_jucator);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_nume);
            this.Controls.Add(this.textBox_pass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log in";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_pass;
        private System.Windows.Forms.TextBox textBox_nume;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_jucator;
        private System.Windows.Forms.Button button_admin;
    }
}