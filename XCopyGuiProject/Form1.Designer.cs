using System;

namespace XCopyGuiProject
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Source = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox_Destination = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox_Modified_After = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox_Matched_Files_Only = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox_Rewrite_Read_only = new System.Windows.Forms.CheckBox();
            this.checkBox_Hidden_Files = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox_Archive_Only = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBox_Archive_Only_Clear = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBox_8_3_Names = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBox_Permissions_Audits = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.checkBox_Permissions = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.checkBox_Modified_Lately = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox_Exclude = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.button_save_exceptions = new System.Windows.Forms.Button();
            this.button_add_exceptions = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(618, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Visible = false;
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Visible = false;
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Visible = false;
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(37, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Source Directory";
            // 
            // textBox_Source
            // 
            this.textBox_Source.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Source.Location = new System.Drawing.Point(153, 29);
            this.textBox_Source.Name = "textBox_Source";
            this.textBox_Source.Size = new System.Drawing.Size(403, 20);
            this.textBox_Source.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Location = new System.Drawing.Point(562, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 23);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Location = new System.Drawing.Point(562, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(24, 23);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox_Destination
            // 
            this.textBox_Destination.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Destination.Location = new System.Drawing.Point(153, 70);
            this.textBox_Destination.Name = "textBox_Destination";
            this.textBox_Destination.Size = new System.Drawing.Size(403, 20);
            this.textBox_Destination.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(37, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Destination Directory";
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.DarkOliveGreen;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.SpringGreen;
            this.button3.Location = new System.Drawing.Point(0, 450);
            this.button3.Margin = new System.Windows.Forms.Padding(10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(630, 30);
            this.button3.TabIndex = 7;
            this.button3.Text = "START";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox1.Items.AddRange(new object[] {
            "Only the root directory",
            "Include non-empty subdirectories",
            "Include all subdirectories",
            "Tree only; non-empty folders (no files copied)",
            "Tree only; all folders (no files copied)"});
            this.comboBox1.Location = new System.Drawing.Point(154, 127);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(432, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(37, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Scope";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(37, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Modified After";
            // 
            // checkBox_Modified_After
            // 
            this.checkBox_Modified_After.AutoSize = true;
            this.checkBox_Modified_After.Location = new System.Drawing.Point(153, 173);
            this.checkBox_Modified_After.Name = "checkBox_Modified_After";
            this.checkBox_Modified_After.Size = new System.Drawing.Size(15, 14);
            this.checkBox_Modified_After.TabIndex = 12;
            this.checkBox_Modified_After.UseVisualStyleBackColor = true;
            this.checkBox_Modified_After.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Enabled = this.checkBox_Modified_After.Checked;
            this.dateTimePicker1.Location = new System.Drawing.Point(186, 167);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(400, 20);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(247, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Matched Files Only";
            // 
            // checkBox_Matched_Files_Only
            // 
            this.checkBox_Matched_Files_Only.AutoSize = true;
            this.checkBox_Matched_Files_Only.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_Matched_Files_Only.Location = new System.Drawing.Point(363, 214);
            this.checkBox_Matched_Files_Only.Name = "checkBox_Matched_Files_Only";
            this.checkBox_Matched_Files_Only.Size = new System.Drawing.Size(15, 14);
            this.checkBox_Matched_Files_Only.TabIndex = 15;
            this.checkBox_Matched_Files_Only.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::XCopyGuiProject.XcopyResources.info;
            this.pictureBox1.Location = new System.Drawing.Point(221, 209);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Include only files that already exist in the destination (override)");
            this.pictureBox1.Click += new System.EventHandler(this.infoIcon_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::XCopyGuiProject.XcopyResources.info;
            this.pictureBox2.Location = new System.Drawing.Point(432, 209);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Padding = new System.Windows.Forms.Padding(5);
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox2, "Rewrite read-only attribute for source files that have it");
            this.pictureBox2.Click += new System.EventHandler(this.infoIcon_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::XCopyGuiProject.XcopyResources.info;
            this.pictureBox3.Location = new System.Drawing.Point(12, 248);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Padding = new System.Windows.Forms.Padding(5);
            this.pictureBox3.Size = new System.Drawing.Size(20, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox3, "Also include hidden & system files");
            this.pictureBox3.Click += new System.EventHandler(this.infoIcon_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::XCopyGuiProject.XcopyResources.info;
            this.pictureBox4.Location = new System.Drawing.Point(222, 247);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Padding = new System.Windows.Forms.Padding(5);
            this.pictureBox4.Size = new System.Drawing.Size(20, 20);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 24;
            this.pictureBox4.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox4, "Include only files having archive attribute turned on");
            this.pictureBox4.Click += new System.EventHandler(this.infoIcon_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::XCopyGuiProject.XcopyResources.info;
            this.pictureBox5.Location = new System.Drawing.Point(432, 248);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Padding = new System.Windows.Forms.Padding(5);
            this.pictureBox5.Size = new System.Drawing.Size(20, 20);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 27;
            this.pictureBox5.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox5, "Include only files having archive attribute turned on, and turn it off source fil" +
        "es afterwards");
            this.pictureBox5.Click += new System.EventHandler(this.infoIcon_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::XCopyGuiProject.XcopyResources.info;
            this.pictureBox6.Location = new System.Drawing.Point(12, 286);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Padding = new System.Windows.Forms.Padding(5);
            this.pictureBox6.Size = new System.Drawing.Size(20, 20);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 30;
            this.pictureBox6.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox6, "Converts file/directory names so that they match SFN filename convention");
            this.pictureBox6.Click += new System.EventHandler(this.infoIcon_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = global::XCopyGuiProject.XcopyResources.info;
            this.pictureBox7.Location = new System.Drawing.Point(12, 167);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Padding = new System.Windows.Forms.Padding(5);
            this.pictureBox7.Size = new System.Drawing.Size(20, 20);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 38;
            this.pictureBox7.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox7, "Include only files that modified after the date");
            this.pictureBox7.Click += new System.EventHandler(this.infoIcon_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Image = global::XCopyGuiProject.XcopyResources.info;
            this.pictureBox8.Location = new System.Drawing.Point(11, 211);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Padding = new System.Windows.Forms.Padding(5);
            this.pictureBox8.Size = new System.Drawing.Size(20, 20);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 41;
            this.pictureBox8.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox8, "If a file exist in destination, will be overriden if the source file is newer");
            this.pictureBox8.Click += new System.EventHandler(this.infoIcon_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox9.Image = global::XCopyGuiProject.XcopyResources.info;
            this.pictureBox9.Location = new System.Drawing.Point(12, 343);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Padding = new System.Windows.Forms.Padding(5);
            this.pictureBox9.Size = new System.Drawing.Size(20, 20);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 44;
            this.pictureBox9.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox9, "Click!");
            this.pictureBox9.Click += new System.EventHandler(this.pictureBox9_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(457, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Rewrite Read-Only";
            // 
            // checkBox_Rewrite_Read_only
            // 
            this.checkBox_Rewrite_Read_only.AutoSize = true;
            this.checkBox_Rewrite_Read_only.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_Rewrite_Read_only.Location = new System.Drawing.Point(573, 216);
            this.checkBox_Rewrite_Read_only.Name = "checkBox_Rewrite_Read_only";
            this.checkBox_Rewrite_Read_only.Size = new System.Drawing.Size(15, 14);
            this.checkBox_Rewrite_Read_only.TabIndex = 19;
            this.checkBox_Rewrite_Read_only.UseVisualStyleBackColor = false;
            // 
            // checkBox_Hidden_Files
            // 
            this.checkBox_Hidden_Files.AutoSize = true;
            this.checkBox_Hidden_Files.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_Hidden_Files.Location = new System.Drawing.Point(153, 255);
            this.checkBox_Hidden_Files.Name = "checkBox_Hidden_Files";
            this.checkBox_Hidden_Files.Size = new System.Drawing.Size(15, 14);
            this.checkBox_Hidden_Files.TabIndex = 22;
            this.checkBox_Hidden_Files.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(37, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Hidden Files";
            // 
            // checkBox_Archive_Only
            // 
            this.checkBox_Archive_Only.AutoSize = true;
            this.checkBox_Archive_Only.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_Archive_Only.Location = new System.Drawing.Point(363, 254);
            this.checkBox_Archive_Only.Name = "checkBox_Archive_Only";
            this.checkBox_Archive_Only.Size = new System.Drawing.Size(15, 14);
            this.checkBox_Archive_Only.TabIndex = 25;
            this.checkBox_Archive_Only.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(247, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Archive Only";
            // 
            // checkBox_Archive_Only_Clear
            // 
            this.checkBox_Archive_Only_Clear.AutoSize = true;
            this.checkBox_Archive_Only_Clear.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_Archive_Only_Clear.Location = new System.Drawing.Point(573, 255);
            this.checkBox_Archive_Only_Clear.Name = "checkBox_Archive_Only_Clear";
            this.checkBox_Archive_Only_Clear.Size = new System.Drawing.Size(15, 14);
            this.checkBox_Archive_Only_Clear.TabIndex = 28;
            this.checkBox_Archive_Only_Clear.UseVisualStyleBackColor = false;
            this.checkBox_Archive_Only_Clear.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(457, 255);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Archive Only + Clear";
            // 
            // checkBox_8_3_Names
            // 
            this.checkBox_8_3_Names.AutoSize = true;
            this.checkBox_8_3_Names.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_8_3_Names.Location = new System.Drawing.Point(153, 293);
            this.checkBox_8_3_Names.Name = "checkBox_8_3_Names";
            this.checkBox_8_3_Names.Size = new System.Drawing.Size(15, 14);
            this.checkBox_8_3_Names.TabIndex = 31;
            this.checkBox_8_3_Names.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(37, 293);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "8.3 Names";
            // 
            // checkBox_Permissions_Audits
            // 
            this.checkBox_Permissions_Audits.AutoSize = true;
            this.checkBox_Permissions_Audits.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_Permissions_Audits.Location = new System.Drawing.Point(573, 292);
            this.checkBox_Permissions_Audits.Name = "checkBox_Permissions_Audits";
            this.checkBox_Permissions_Audits.Size = new System.Drawing.Size(15, 14);
            this.checkBox_Permissions_Audits.TabIndex = 37;
            this.checkBox_Permissions_Audits.UseVisualStyleBackColor = false;
            this.checkBox_Permissions_Audits.CheckedChanged += new System.EventHandler(this.checkBox_Permissions_Audits_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(457, 292);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "Permissions + Audits";
            // 
            // checkBox_Permissions
            // 
            this.checkBox_Permissions.AutoSize = true;
            this.checkBox_Permissions.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_Permissions.Location = new System.Drawing.Point(363, 291);
            this.checkBox_Permissions.Name = "checkBox_Permissions";
            this.checkBox_Permissions.Size = new System.Drawing.Size(15, 14);
            this.checkBox_Permissions.TabIndex = 34;
            this.checkBox_Permissions.UseVisualStyleBackColor = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(247, 291);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "Permissions";
            // 
            // checkBox_Modified_Lately
            // 
            this.checkBox_Modified_Lately.AutoSize = true;
            this.checkBox_Modified_Lately.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_Modified_Lately.Location = new System.Drawing.Point(153, 216);
            this.checkBox_Modified_Lately.Name = "checkBox_Modified_Lately";
            this.checkBox_Modified_Lately.Size = new System.Drawing.Size(15, 14);
            this.checkBox_Modified_Lately.TabIndex = 40;
            this.checkBox_Modified_Lately.UseVisualStyleBackColor = false;
            this.checkBox_Modified_Lately.CheckedChanged += new System.EventHandler(this.checkBox10_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(37, 217);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 13);
            this.label13.TabIndex = 39;
            this.label13.Text = "Modified Lately";
            // 
            // textBox_Exclude
            // 
            this.textBox_Exclude.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_Exclude.Location = new System.Drawing.Point(153, 347);
            this.textBox_Exclude.Multiline = true;
            this.textBox_Exclude.Name = "textBox_Exclude";
            this.textBox_Exclude.Size = new System.Drawing.Size(273, 79);
            this.textBox_Exclude.TabIndex = 42;
            this.textBox_Exclude.TextChanged += new System.EventHandler(this.textBox_Exclude_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(37, 350);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 13);
            this.label14.TabIndex = 43;
            this.label14.Text = "Path Exceptions";
            // 
            // button_save_exceptions
            // 
            this.button_save_exceptions.Enabled = false;
            this.button_save_exceptions.Location = new System.Drawing.Point(432, 403);
            this.button_save_exceptions.Name = "button_save_exceptions";
            this.button_save_exceptions.Size = new System.Drawing.Size(154, 23);
            this.button_save_exceptions.TabIndex = 45;
            this.button_save_exceptions.Text = "Save Exeptions";
            this.button_save_exceptions.UseVisualStyleBackColor = true;
            this.button_save_exceptions.Click += new System.EventHandler(this.button_save_exceptions_Click);
            // 
            // button_add_exceptions
            // 
            this.button_add_exceptions.Enabled = false;
            this.button_add_exceptions.Location = new System.Drawing.Point(432, 374);
            this.button_add_exceptions.Name = "button_add_exceptions";
            this.button_add_exceptions.Size = new System.Drawing.Size(154, 23);
            this.button_add_exceptions.TabIndex = 46;
            this.button_add_exceptions.Text = "Add Exeptions";
            this.button_add_exceptions.UseVisualStyleBackColor = true;
            this.button_add_exceptions.Click += new System.EventHandler(this.button_add_exceptions_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(432, 347);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(154, 21);
            this.comboBox2.TabIndex = 47;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(630, 480);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.button_add_exceptions);
            this.Controls.Add(this.button_save_exceptions);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBox_Exclude);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.checkBox_Modified_Lately);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.checkBox_Permissions_Audits);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.checkBox_Permissions);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.checkBox_8_3_Names);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.checkBox_Archive_Only_Clear);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.checkBox_Archive_Only);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.checkBox_Hidden_Files);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.checkBox_Rewrite_Read_only);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkBox_Matched_Files_Only);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.checkBox_Modified_After);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox_Destination);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_Source);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "XCopy GUI";
            this.TransparencyKey = System.Drawing.SystemColors.ButtonShadow;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        
        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Source;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox_Destination;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox_Modified_After;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox_Matched_Files_Only;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox checkBox_Rewrite_Read_only;
        private System.Windows.Forms.CheckBox checkBox_Hidden_Files;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBox_Archive_Only;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBox_Archive_Only_Clear;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBox_8_3_Names;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox checkBox_Permissions_Audits;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox checkBox_Permissions;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.CheckBox checkBox_Modified_Lately;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox_Exclude;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Button button_save_exceptions;
        private System.Windows.Forms.Button button_add_exceptions;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}

