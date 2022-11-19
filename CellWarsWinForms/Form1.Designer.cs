namespace CellWarsWinForms
{
    partial class WindowForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowForm));
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.tResolution = new System.Windows.Forms.TextBox();
            this.tbResolution = new System.Windows.Forms.TrackBar();
            this.tbDensityBLUE = new System.Windows.Forms.TrackBar();
            this.tDensityBlue = new System.Windows.Forms.TextBox();
            this.tbDensityRED = new System.Windows.Forms.TrackBar();
            this.tDensityRed = new System.Windows.Forms.TextBox();
            this.tbBlueRedGreen = new System.Windows.Forms.TrackBar();
            this.tBLUE = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.tBlueCount = new System.Windows.Forms.TextBox();
            this.tRedCount = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bStart = new System.Windows.Forms.Button();
            this.bStop = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tRED = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tbDensityGREEN = new System.Windows.Forms.TrackBar();
            this.tDensityGreen = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.tGREEN = new System.Windows.Forms.TextBox();
            this.tGreenCount = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbResolution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDensityBLUE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDensityRED)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBlueRedGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDensityGREEN)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitter1.Enabled = false;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(183, 745);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // tResolution
            // 
            this.tResolution.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tResolution.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tResolution.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tResolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tResolution.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tResolution.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tResolution.Location = new System.Drawing.Point(9, 12);
            this.tResolution.Name = "tResolution";
            this.tResolution.ReadOnly = true;
            this.tResolution.Size = new System.Drawing.Size(138, 22);
            this.tResolution.TabIndex = 1;
            this.tResolution.TabStop = false;
            this.tResolution.Text = "Resolution: 3";
            this.tResolution.WordWrap = false;
            // 
            // tbResolution
            // 
            this.tbResolution.LargeChange = 1;
            this.tbResolution.Location = new System.Drawing.Point(19, 39);
            this.tbResolution.Maximum = 25;
            this.tbResolution.Minimum = 3;
            this.tbResolution.Name = "tbResolution";
            this.tbResolution.Size = new System.Drawing.Size(104, 45);
            this.tbResolution.TabIndex = 2;
            this.tbResolution.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbResolution.Value = 3;
            this.tbResolution.ValueChanged += new System.EventHandler(this.tbResolution_ValueChanged);
            // 
            // tbDensityBLUE
            // 
            this.tbDensityBLUE.LargeChange = 1;
            this.tbDensityBLUE.Location = new System.Drawing.Point(19, 109);
            this.tbDensityBLUE.Maximum = 25;
            this.tbDensityBLUE.Minimum = 2;
            this.tbDensityBLUE.Name = "tbDensityBLUE";
            this.tbDensityBLUE.Size = new System.Drawing.Size(104, 45);
            this.tbDensityBLUE.TabIndex = 4;
            this.tbDensityBLUE.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbDensityBLUE.Value = 23;
            this.tbDensityBLUE.ValueChanged += new System.EventHandler(this.tbDensityBLUE_ValueChanged);
            // 
            // tDensityBlue
            // 
            this.tDensityBlue.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tDensityBlue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tDensityBlue.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tDensityBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tDensityBlue.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tDensityBlue.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tDensityBlue.Location = new System.Drawing.Point(9, 83);
            this.tDensityBlue.Name = "tDensityBlue";
            this.tDensityBlue.ReadOnly = true;
            this.tDensityBlue.Size = new System.Drawing.Size(138, 19);
            this.tDensityBlue.TabIndex = 3;
            this.tDensityBlue.TabStop = false;
            this.tDensityBlue.Text = "Density Blue: 23";
            this.tDensityBlue.WordWrap = false;
            // 
            // tbDensityRED
            // 
            this.tbDensityRED.LargeChange = 1;
            this.tbDensityRED.Location = new System.Drawing.Point(19, 177);
            this.tbDensityRED.Maximum = 25;
            this.tbDensityRED.Minimum = 2;
            this.tbDensityRED.Name = "tbDensityRED";
            this.tbDensityRED.Size = new System.Drawing.Size(104, 45);
            this.tbDensityRED.TabIndex = 6;
            this.tbDensityRED.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbDensityRED.Value = 23;
            this.tbDensityRED.ValueChanged += new System.EventHandler(this.tbDensityRED_ValueChanged);
            // 
            // tDensityRed
            // 
            this.tDensityRed.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tDensityRed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tDensityRed.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tDensityRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tDensityRed.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tDensityRed.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tDensityRed.Location = new System.Drawing.Point(11, 152);
            this.tDensityRed.Name = "tDensityRed";
            this.tDensityRed.ReadOnly = true;
            this.tDensityRed.Size = new System.Drawing.Size(135, 19);
            this.tDensityRed.TabIndex = 5;
            this.tDensityRed.TabStop = false;
            this.tDensityRed.Text = "Density Red: 23";
            this.tDensityRed.WordWrap = false;
            // 
            // tbBlueRedGreen
            // 
            this.tbBlueRedGreen.LargeChange = 1;
            this.tbBlueRedGreen.Location = new System.Drawing.Point(19, 451);
            this.tbBlueRedGreen.Maximum = 3;
            this.tbBlueRedGreen.Minimum = 1;
            this.tbBlueRedGreen.Name = "tbBlueRedGreen";
            this.tbBlueRedGreen.Size = new System.Drawing.Size(132, 45);
            this.tbBlueRedGreen.TabIndex = 8;
            this.tbBlueRedGreen.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbBlueRedGreen.Value = 1;
            this.tbBlueRedGreen.ValueChanged += new System.EventHandler(this.tbBlueRedGreen_ValueChanged);
            // 
            // tBLUE
            // 
            this.tBLUE.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tBLUE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBLUE.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tBLUE.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.tBLUE.ForeColor = System.Drawing.Color.Turquoise;
            this.tBLUE.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tBLUE.Location = new System.Drawing.Point(16, 427);
            this.tBLUE.Name = "tBLUE";
            this.tBLUE.ReadOnly = true;
            this.tBLUE.Size = new System.Drawing.Size(39, 17);
            this.tBLUE.TabIndex = 7;
            this.tBLUE.TabStop = false;
            this.tBLUE.Text = "Blue";
            this.tBLUE.WordWrap = false;
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(183, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1183, 745);
            this.pictureBox.TabIndex = 9;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            // 
            // tBlueCount
            // 
            this.tBlueCount.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tBlueCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBlueCount.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tBlueCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.tBlueCount.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tBlueCount.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tBlueCount.Location = new System.Drawing.Point(19, 567);
            this.tBlueCount.Name = "tBlueCount";
            this.tBlueCount.ReadOnly = true;
            this.tBlueCount.Size = new System.Drawing.Size(128, 13);
            this.tBlueCount.TabIndex = 10;
            this.tBlueCount.TabStop = false;
            this.tBlueCount.Text = "Count of Blue: 0";
            this.tBlueCount.WordWrap = false;
            // 
            // tRedCount
            // 
            this.tRedCount.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tRedCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tRedCount.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tRedCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.tRedCount.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tRedCount.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tRedCount.Location = new System.Drawing.Point(19, 598);
            this.tRedCount.Name = "tRedCount";
            this.tRedCount.ReadOnly = true;
            this.tRedCount.Size = new System.Drawing.Size(128, 13);
            this.tRedCount.TabIndex = 11;
            this.tRedCount.TabStop = false;
            this.tRedCount.Text = "Count of Red: 0";
            this.tRedCount.WordWrap = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 60;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bStart
            // 
            this.bStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bStart.Location = new System.Drawing.Point(19, 322);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(104, 36);
            this.bStart.TabIndex = 12;
            this.bStart.Text = "Start";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // bStop
            // 
            this.bStop.Enabled = false;
            this.bStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bStop.Location = new System.Drawing.Point(19, 374);
            this.bStop.Name = "bStop";
            this.bStop.Size = new System.Drawing.Size(104, 36);
            this.bStop.TabIndex = 13;
            this.bStop.Text = "Stop";
            this.bStop.UseVisualStyleBackColor = true;
            this.bStop.Click += new System.EventHandler(this.bStop_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textBox1.Location = new System.Drawing.Point(50, 428);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(28, 17);
            this.textBox1.TabIndex = 14;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "- -";
            this.textBox1.WordWrap = false;
            // 
            // tRED
            // 
            this.tRED.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tRED.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tRED.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tRED.Enabled = false;
            this.tRED.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.tRED.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tRED.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tRED.Location = new System.Drawing.Point(70, 428);
            this.tRED.Name = "tRED";
            this.tRED.ReadOnly = true;
            this.tRED.Size = new System.Drawing.Size(33, 17);
            this.tRED.TabIndex = 15;
            this.tRED.TabStop = false;
            this.tRED.Text = "Red";
            this.tRED.WordWrap = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.textBox2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox2.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textBox2.Location = new System.Drawing.Point(19, 502);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(119, 13);
            this.textBox2.TabIndex = 16;
            this.textBox2.TabStop = false;
            this.textBox2.Text = "Left Click - Add Cell";
            this.textBox2.WordWrap = false;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.textBox3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox3.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textBox3.Location = new System.Drawing.Point(3, 521);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(148, 13);
            this.textBox3.TabIndex = 17;
            this.textBox3.TabStop = false;
            this.textBox3.Text = "Right Click - Remove Cell";
            this.textBox3.WordWrap = false;
            // 
            // tbDensityGREEN
            // 
            this.tbDensityGREEN.LargeChange = 1;
            this.tbDensityGREEN.Location = new System.Drawing.Point(20, 258);
            this.tbDensityGREEN.Maximum = 25;
            this.tbDensityGREEN.Minimum = 2;
            this.tbDensityGREEN.Name = "tbDensityGREEN";
            this.tbDensityGREEN.Size = new System.Drawing.Size(104, 45);
            this.tbDensityGREEN.TabIndex = 19;
            this.tbDensityGREEN.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbDensityGREEN.Value = 23;
            this.tbDensityGREEN.ValueChanged += new System.EventHandler(this.tbDensityGREEN_ValueChanged);
            // 
            // tDensityGreen
            // 
            this.tDensityGreen.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tDensityGreen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tDensityGreen.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tDensityGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tDensityGreen.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tDensityGreen.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tDensityGreen.Location = new System.Drawing.Point(12, 233);
            this.tDensityGreen.Name = "tDensityGreen";
            this.tDensityGreen.ReadOnly = true;
            this.tDensityGreen.Size = new System.Drawing.Size(152, 19);
            this.tDensityGreen.TabIndex = 18;
            this.tDensityGreen.TabStop = false;
            this.tDensityGreen.Text = "Density Green: 23";
            this.tDensityGreen.WordWrap = false;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.textBox4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox4.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textBox4.Location = new System.Drawing.Point(101, 427);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(28, 17);
            this.textBox4.TabIndex = 20;
            this.textBox4.TabStop = false;
            this.textBox4.Text = "- -";
            this.textBox4.WordWrap = false;
            // 
            // tGREEN
            // 
            this.tGREEN.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tGREEN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tGREEN.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tGREEN.Enabled = false;
            this.tGREEN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.tGREEN.ForeColor = System.Drawing.Color.Green;
            this.tGREEN.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tGREEN.Location = new System.Drawing.Point(119, 428);
            this.tGREEN.Name = "tGREEN";
            this.tGREEN.ReadOnly = true;
            this.tGREEN.Size = new System.Drawing.Size(53, 17);
            this.tGREEN.TabIndex = 21;
            this.tGREEN.TabStop = false;
            this.tGREEN.Text = "Green";
            this.tGREEN.WordWrap = false;
            // 
            // tGreenCount
            // 
            this.tGreenCount.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tGreenCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tGreenCount.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tGreenCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.tGreenCount.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tGreenCount.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tGreenCount.Location = new System.Drawing.Point(19, 626);
            this.tGreenCount.Name = "tGreenCount";
            this.tGreenCount.ReadOnly = true;
            this.tGreenCount.Size = new System.Drawing.Size(128, 13);
            this.tGreenCount.TabIndex = 22;
            this.tGreenCount.TabStop = false;
            this.tGreenCount.Text = "Count of Green: 0";
            this.tGreenCount.WordWrap = false;
            // 
            // WindowForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1366, 745);
            this.Controls.Add(this.tGreenCount);
            this.Controls.Add(this.tGREEN);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.tbDensityGREEN);
            this.Controls.Add(this.tDensityGreen);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.tRED);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bStop);
            this.Controls.Add(this.bStart);
            this.Controls.Add(this.tRedCount);
            this.Controls.Add(this.tBlueCount);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.tbBlueRedGreen);
            this.Controls.Add(this.tBLUE);
            this.Controls.Add(this.tbDensityRED);
            this.Controls.Add(this.tDensityRed);
            this.Controls.Add(this.tbDensityBLUE);
            this.Controls.Add(this.tDensityBlue);
            this.Controls.Add(this.tbResolution);
            this.Controls.Add(this.tResolution);
            this.Controls.Add(this.splitter1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WindowForm";
            this.Text = "Cells Wars";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.tbResolution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDensityBLUE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDensityRED)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBlueRedGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDensityGREEN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TextBox tResolution;
        private System.Windows.Forms.TrackBar tbResolution;
        private System.Windows.Forms.TrackBar tbDensityBLUE;
        private System.Windows.Forms.TextBox tDensityBlue;
        private System.Windows.Forms.TrackBar tbDensityRED;
        private System.Windows.Forms.TextBox tDensityRed;
        private System.Windows.Forms.TrackBar tbBlueRedGreen;
        private System.Windows.Forms.TextBox tBLUE;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox tBlueCount;
        private System.Windows.Forms.TextBox tRedCount;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.Button bStop;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tRED;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TrackBar tbDensityGREEN;
        private System.Windows.Forms.TextBox tDensityGreen;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox tGREEN;
        private System.Windows.Forms.TextBox tGreenCount;
    }
}

