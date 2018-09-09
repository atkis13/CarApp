namespace CarApp
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentExpansesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintanaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_type = new System.Windows.Forms.Label();
            this.lbl_engine = new System.Windows.Forms.Label();
            this.lbl_design = new System.Windows.Forms.Label();
            this.lbl_year = new System.Windows.Forms.Label();
            this.lbl_brand = new System.Windows.Forms.Label();
            this.lbl_filtre = new System.Windows.Forms.Label();
            this.lbl_ulei = new System.Windows.Forms.Label();
            this.lbl_itp = new System.Windows.Forms.Label();
            this.lbl_rov = new System.Windows.Forms.Label();
            this.lbl_asig = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_load = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(25, 40);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(351, 385);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.carOptionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1150, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newCarToolStripMenuItem,
            this.loadCarToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // newCarToolStripMenuItem
            // 
            this.newCarToolStripMenuItem.Name = "newCarToolStripMenuItem";
            this.newCarToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.newCarToolStripMenuItem.Text = "New Car";
            this.newCarToolStripMenuItem.Click += new System.EventHandler(this.newCarToolStripMenuItem_Click);
            // 
            // loadCarToolStripMenuItem
            // 
            this.loadCarToolStripMenuItem.Name = "loadCarToolStripMenuItem";
            this.loadCarToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.loadCarToolStripMenuItem.Text = "Load Car";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // carOptionsToolStripMenuItem
            // 
            this.carOptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archiveToolStripMenuItem,
            this.currentExpansesToolStripMenuItem,
            this.maintanaceToolStripMenuItem});
            this.carOptionsToolStripMenuItem.Name = "carOptionsToolStripMenuItem";
            this.carOptionsToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.carOptionsToolStripMenuItem.Text = "Car Options";
            // 
            // archiveToolStripMenuItem
            // 
            this.archiveToolStripMenuItem.Name = "archiveToolStripMenuItem";
            this.archiveToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.archiveToolStripMenuItem.Text = "Archive";
            this.archiveToolStripMenuItem.Click += new System.EventHandler(this.archiveToolStripMenuItem_Click);
            // 
            // currentExpansesToolStripMenuItem
            // 
            this.currentExpansesToolStripMenuItem.Name = "currentExpansesToolStripMenuItem";
            this.currentExpansesToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.currentExpansesToolStripMenuItem.Text = "Current Expanses";
            this.currentExpansesToolStripMenuItem.Click += new System.EventHandler(this.currentExpansesToolStripMenuItem_Click);
            // 
            // maintanaceToolStripMenuItem
            // 
            this.maintanaceToolStripMenuItem.Name = "maintanaceToolStripMenuItem";
            this.maintanaceToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.maintanaceToolStripMenuItem.Text = "Maintanace";
            this.maintanaceToolStripMenuItem.Click += new System.EventHandler(this.maintanaceToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(466, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(836, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(465, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Brand";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(465, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Year";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(465, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Design";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(466, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Engine";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(466, 360);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Type";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(836, 329);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Schimb ulei";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(836, 300);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "ITP";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(836, 265);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Rovinieta";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(836, 230);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Asigurare";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(836, 360);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Filtre";
            // 
            // lbl_type
            // 
            this.lbl_type.AutoSize = true;
            this.lbl_type.Location = new System.Drawing.Point(544, 360);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(31, 13);
            this.lbl_type.TabIndex = 20;
            this.lbl_type.Text = "Type";
            // 
            // lbl_engine
            // 
            this.lbl_engine.AutoSize = true;
            this.lbl_engine.Location = new System.Drawing.Point(544, 324);
            this.lbl_engine.Name = "lbl_engine";
            this.lbl_engine.Size = new System.Drawing.Size(40, 13);
            this.lbl_engine.TabIndex = 19;
            this.lbl_engine.Text = "Engine";
            // 
            // lbl_design
            // 
            this.lbl_design.AutoSize = true;
            this.lbl_design.Location = new System.Drawing.Point(543, 289);
            this.lbl_design.Name = "lbl_design";
            this.lbl_design.Size = new System.Drawing.Size(40, 13);
            this.lbl_design.TabIndex = 18;
            this.lbl_design.Text = "Design";
            // 
            // lbl_year
            // 
            this.lbl_year.AutoSize = true;
            this.lbl_year.Location = new System.Drawing.Point(543, 254);
            this.lbl_year.Name = "lbl_year";
            this.lbl_year.Size = new System.Drawing.Size(29, 13);
            this.lbl_year.TabIndex = 17;
            this.lbl_year.Text = "Year";
            // 
            // lbl_brand
            // 
            this.lbl_brand.AutoSize = true;
            this.lbl_brand.Location = new System.Drawing.Point(543, 219);
            this.lbl_brand.Name = "lbl_brand";
            this.lbl_brand.Size = new System.Drawing.Size(35, 13);
            this.lbl_brand.TabIndex = 16;
            this.lbl_brand.Text = "Brand";
            // 
            // lbl_filtre
            // 
            this.lbl_filtre.AutoSize = true;
            this.lbl_filtre.Location = new System.Drawing.Point(917, 360);
            this.lbl_filtre.Name = "lbl_filtre";
            this.lbl_filtre.Size = new System.Drawing.Size(29, 13);
            this.lbl_filtre.TabIndex = 25;
            this.lbl_filtre.Text = "Filtre";
            // 
            // lbl_ulei
            // 
            this.lbl_ulei.AutoSize = true;
            this.lbl_ulei.Location = new System.Drawing.Point(917, 329);
            this.lbl_ulei.Name = "lbl_ulei";
            this.lbl_ulei.Size = new System.Drawing.Size(61, 13);
            this.lbl_ulei.TabIndex = 24;
            this.lbl_ulei.Text = "Schimb ulei";
            // 
            // lbl_itp
            // 
            this.lbl_itp.AutoSize = true;
            this.lbl_itp.Location = new System.Drawing.Point(917, 300);
            this.lbl_itp.Name = "lbl_itp";
            this.lbl_itp.Size = new System.Drawing.Size(24, 13);
            this.lbl_itp.TabIndex = 23;
            this.lbl_itp.Text = "ITP";
            // 
            // lbl_rov
            // 
            this.lbl_rov.AutoSize = true;
            this.lbl_rov.Location = new System.Drawing.Point(917, 265);
            this.lbl_rov.Name = "lbl_rov";
            this.lbl_rov.Size = new System.Drawing.Size(52, 13);
            this.lbl_rov.TabIndex = 22;
            this.lbl_rov.Text = "Rovinieta";
            // 
            // lbl_asig
            // 
            this.lbl_asig.AutoSize = true;
            this.lbl_asig.Location = new System.Drawing.Point(917, 230);
            this.lbl_asig.Name = "lbl_asig";
            this.lbl_asig.Size = new System.Drawing.Size(51, 13);
            this.lbl_asig.TabIndex = 21;
            this.lbl_asig.Text = "Asigurare";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(468, 65);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 26;
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(617, 65);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(75, 23);
            this.btn_load.TabIndex = 27;
            this.btn_load.Text = "Load car";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 471);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbl_filtre);
            this.Controls.Add(this.lbl_ulei);
            this.Controls.Add(this.lbl_itp);
            this.Controls.Add(this.lbl_rov);
            this.Controls.Add(this.lbl_asig);
            this.Controls.Add(this.lbl_type);
            this.Controls.Add(this.lbl_engine);
            this.Controls.Add(this.lbl_design);
            this.Controls.Add(this.lbl_year);
            this.Controls.Add(this.lbl_brand);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newCarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadCarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem archiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currentExpansesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintanaceToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl_type;
        private System.Windows.Forms.Label lbl_engine;
        private System.Windows.Forms.Label lbl_design;
        private System.Windows.Forms.Label lbl_year;
        private System.Windows.Forms.Label lbl_brand;
        private System.Windows.Forms.Label lbl_filtre;
        private System.Windows.Forms.Label lbl_ulei;
        private System.Windows.Forms.Label lbl_itp;
        private System.Windows.Forms.Label lbl_rov;
        private System.Windows.Forms.Label lbl_asig;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_load;
    }
}