namespace Kadrovay_slujba
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отделToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.должностьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зарплатаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOtdel = new System.Windows.Forms.Button();
            this.btnSotrudnik = new System.Windows.Forms.Button();
            this.btnDoljnost = new System.Windows.Forms.Button();
            this.btnZarplata = new System.Windows.Forms.Button();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.менюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(885, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отделToolStripMenuItem,
            this.должностьToolStripMenuItem,
            this.сотрудникToolStripMenuItem,
            this.зарплатаToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // отделToolStripMenuItem
            // 
            this.отделToolStripMenuItem.Name = "отделToolStripMenuItem";
            this.отделToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.отделToolStripMenuItem.Text = "Отдел";
            this.отделToolStripMenuItem.Click += new System.EventHandler(this.отделToolStripMenuItem_Click);
            // 
            // должностьToolStripMenuItem
            // 
            this.должностьToolStripMenuItem.Name = "должностьToolStripMenuItem";
            this.должностьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.должностьToolStripMenuItem.Text = "Должность";
            this.должностьToolStripMenuItem.Click += new System.EventHandler(this.должностьToolStripMenuItem_Click);
            // 
            // сотрудникToolStripMenuItem
            // 
            this.сотрудникToolStripMenuItem.Name = "сотрудникToolStripMenuItem";
            this.сотрудникToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сотрудникToolStripMenuItem.Text = "Сотрудник";
            this.сотрудникToolStripMenuItem.Click += new System.EventHandler(this.сотрудникToolStripMenuItem_Click);
            // 
            // зарплатаToolStripMenuItem
            // 
            this.зарплатаToolStripMenuItem.Name = "зарплатаToolStripMenuItem";
            this.зарплатаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.зарплатаToolStripMenuItem.Text = "Зарплата";
            this.зарплатаToolStripMenuItem.Click += new System.EventHandler(this.зарплатаToolStripMenuItem_Click);
            // 
            // btnOtdel
            // 
            this.btnOtdel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOtdel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOtdel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOtdel.Location = new System.Drawing.Point(12, 42);
            this.btnOtdel.Name = "btnOtdel";
            this.btnOtdel.Size = new System.Drawing.Size(289, 53);
            this.btnOtdel.TabIndex = 1;
            this.btnOtdel.Text = "Личная карточка";
            this.btnOtdel.UseVisualStyleBackColor = false;
            this.btnOtdel.Click += new System.EventHandler(this.btnOtdel_Click);
            // 
            // btnSotrudnik
            // 
            this.btnSotrudnik.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSotrudnik.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSotrudnik.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSotrudnik.Location = new System.Drawing.Point(12, 225);
            this.btnSotrudnik.Name = "btnSotrudnik";
            this.btnSotrudnik.Size = new System.Drawing.Size(289, 53);
            this.btnSotrudnik.TabIndex = 2;
            this.btnSotrudnik.Text = "Сотрудники";
            this.btnSotrudnik.UseVisualStyleBackColor = false;
            this.btnSotrudnik.Click += new System.EventHandler(this.btnSotrudnik_Click);
            // 
            // btnDoljnost
            // 
            this.btnDoljnost.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDoljnost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoljnost.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDoljnost.Location = new System.Drawing.Point(12, 135);
            this.btnDoljnost.Name = "btnDoljnost";
            this.btnDoljnost.Size = new System.Drawing.Size(289, 53);
            this.btnDoljnost.TabIndex = 3;
            this.btnDoljnost.Text = "Должность";
            this.btnDoljnost.UseVisualStyleBackColor = false;
            this.btnDoljnost.Click += new System.EventHandler(this.btnDoljnost_Click);
            // 
            // btnZarplata
            // 
            this.btnZarplata.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnZarplata.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnZarplata.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnZarplata.Location = new System.Drawing.Point(12, 319);
            this.btnZarplata.Name = "btnZarplata";
            this.btnZarplata.Size = new System.Drawing.Size(289, 53);
            this.btnZarplata.TabIndex = 5;
            this.btnZarplata.Text = "Зарплата";
            this.btnZarplata.UseVisualStyleBackColor = false;
            this.btnZarplata.Click += new System.EventHandler(this.btnZarplata_Click);
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::Kadrovay_slujba.Properties.Resources.Принципы_управления_персоналом_для_предприятий_общепита_768x529_1;
            this.pictureBox1.Location = new System.Drawing.Point(340, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(545, 414);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 438);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnZarplata);
            this.Controls.Add(this.btnDoljnost);
            this.Controls.Add(this.btnSotrudnik);
            this.Controls.Add(this.btnOtdel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Кадровая планирование";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отделToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem должностьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникToolStripMenuItem;
        private System.Windows.Forms.Button btnOtdel;
        private System.Windows.Forms.Button btnSotrudnik;
        private System.Windows.Forms.Button btnDoljnost;
        private System.Windows.Forms.Button btnZarplata;
        private System.Windows.Forms.ToolStripMenuItem зарплатаToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
    }
}