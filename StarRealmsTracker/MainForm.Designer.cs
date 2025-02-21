namespace StarRealmsTracker
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            toolStrip1 = new ToolStrip();
            toolStripButtonReset = new ToolStripButton();
            tabControl1 = new TabControl();
            tabPageArena = new TabPage();
            panel1 = new Panel();
            pictureBoxLoss1 = new PictureBox();
            pictureBoxLoss0 = new PictureBox();
            pictureBoxWin5 = new PictureBox();
            pictureBoxWin4 = new PictureBox();
            pictureBoxWin3 = new PictureBox();
            pictureBoxWin2 = new PictureBox();
            pictureBoxWin1 = new PictureBox();
            pictureBoxWin0 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBoxTitle = new PictureBox();
            upDownLoss = new NumericUpDown();
            label2 = new Label();
            upDownWin = new NumericUpDown();
            label1 = new Label();
            tabPageTournament = new TabPage();
            upDownTournamentLoss = new NumericUpDown();
            label6 = new Label();
            upDownTournamentWin = new NumericUpDown();
            label5 = new Label();
            textBoxTournament = new TextBox();
            label4 = new Label();
            panel2 = new Panel();
            labelRecord = new Label();
            labelTournamentName = new Label();
            toolStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPageArena.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLoss1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLoss0).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxWin5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxWin4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxWin3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxWin2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxWin1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxWin0).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTitle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)upDownLoss).BeginInit();
            ((System.ComponentModel.ISupportInitialize)upDownWin).BeginInit();
            tabPageTournament.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)upDownTournamentLoss).BeginInit();
            ((System.ComponentModel.ISupportInitialize)upDownTournamentWin).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButtonReset });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(334, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonReset
            // 
            toolStripButtonReset.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonReset.Image = (Image)resources.GetObject("toolStripButtonReset.Image");
            toolStripButtonReset.ImageTransparentColor = Color.Magenta;
            toolStripButtonReset.Name = "toolStripButtonReset";
            toolStripButtonReset.Size = new Size(23, 22);
            toolStripButtonReset.Text = "toolStripButton2";
            toolStripButtonReset.Click += toolStripButtonReset_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageArena);
            tabControl1.Controls.Add(tabPageTournament);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 25);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(334, 263);
            tabControl1.TabIndex = 1;
            // 
            // tabPageArena
            // 
            tabPageArena.Controls.Add(panel1);
            tabPageArena.Controls.Add(upDownLoss);
            tabPageArena.Controls.Add(label2);
            tabPageArena.Controls.Add(upDownWin);
            tabPageArena.Controls.Add(label1);
            tabPageArena.Location = new Point(4, 24);
            tabPageArena.Name = "tabPageArena";
            tabPageArena.Padding = new Padding(3);
            tabPageArena.Size = new Size(326, 235);
            tabPageArena.TabIndex = 0;
            tabPageArena.Text = "Arena";
            tabPageArena.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(pictureBoxLoss1);
            panel1.Controls.Add(pictureBoxLoss0);
            panel1.Controls.Add(pictureBoxWin5);
            panel1.Controls.Add(pictureBoxWin4);
            panel1.Controls.Add(pictureBoxWin3);
            panel1.Controls.Add(pictureBoxWin2);
            panel1.Controls.Add(pictureBoxWin1);
            panel1.Controls.Add(pictureBoxWin0);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pictureBoxTitle);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(3, 135);
            panel1.Name = "panel1";
            panel1.Size = new Size(320, 97);
            panel1.TabIndex = 4;
            // 
            // pictureBoxLoss1
            // 
            pictureBoxLoss1.Image = (Image)resources.GetObject("pictureBoxLoss1.Image");
            pictureBoxLoss1.Location = new Point(271, 57);
            pictureBoxLoss1.Name = "pictureBoxLoss1";
            pictureBoxLoss1.Size = new Size(36, 14);
            pictureBoxLoss1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxLoss1.TabIndex = 13;
            pictureBoxLoss1.TabStop = false;
            // 
            // pictureBoxLoss0
            // 
            pictureBoxLoss0.Image = (Image)resources.GetObject("pictureBoxLoss0.Image");
            pictureBoxLoss0.Location = new Point(235, 57);
            pictureBoxLoss0.Name = "pictureBoxLoss0";
            pictureBoxLoss0.Size = new Size(36, 14);
            pictureBoxLoss0.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxLoss0.TabIndex = 12;
            pictureBoxLoss0.TabStop = false;
            // 
            // pictureBoxWin5
            // 
            pictureBoxWin5.Image = (Image)resources.GetObject("pictureBoxWin5.Image");
            pictureBoxWin5.Location = new Point(193, 57);
            pictureBoxWin5.Name = "pictureBoxWin5";
            pictureBoxWin5.Size = new Size(36, 14);
            pictureBoxWin5.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxWin5.TabIndex = 11;
            pictureBoxWin5.TabStop = false;
            // 
            // pictureBoxWin4
            // 
            pictureBoxWin4.Image = (Image)resources.GetObject("pictureBoxWin4.Image");
            pictureBoxWin4.Location = new Point(157, 57);
            pictureBoxWin4.Name = "pictureBoxWin4";
            pictureBoxWin4.Size = new Size(36, 14);
            pictureBoxWin4.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxWin4.TabIndex = 10;
            pictureBoxWin4.TabStop = false;
            // 
            // pictureBoxWin3
            // 
            pictureBoxWin3.Image = (Image)resources.GetObject("pictureBoxWin3.Image");
            pictureBoxWin3.Location = new Point(121, 57);
            pictureBoxWin3.Name = "pictureBoxWin3";
            pictureBoxWin3.Size = new Size(36, 14);
            pictureBoxWin3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxWin3.TabIndex = 9;
            pictureBoxWin3.TabStop = false;
            // 
            // pictureBoxWin2
            // 
            pictureBoxWin2.Image = (Image)resources.GetObject("pictureBoxWin2.Image");
            pictureBoxWin2.Location = new Point(85, 57);
            pictureBoxWin2.Name = "pictureBoxWin2";
            pictureBoxWin2.Size = new Size(36, 14);
            pictureBoxWin2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxWin2.TabIndex = 8;
            pictureBoxWin2.TabStop = false;
            // 
            // pictureBoxWin1
            // 
            pictureBoxWin1.Image = (Image)resources.GetObject("pictureBoxWin1.Image");
            pictureBoxWin1.Location = new Point(49, 57);
            pictureBoxWin1.Name = "pictureBoxWin1";
            pictureBoxWin1.Size = new Size(36, 14);
            pictureBoxWin1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxWin1.TabIndex = 7;
            pictureBoxWin1.TabStop = false;
            // 
            // pictureBoxWin0
            // 
            pictureBoxWin0.Image = (Image)resources.GetObject("pictureBoxWin0.Image");
            pictureBoxWin0.Location = new Point(13, 57);
            pictureBoxWin0.Name = "pictureBoxWin0";
            pictureBoxWin0.Size = new Size(36, 14);
            pictureBoxWin0.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxWin0.TabIndex = 6;
            pictureBoxWin0.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(235, 36);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(23, 15);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(13, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(21, 15);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBoxTitle
            // 
            pictureBoxTitle.Image = (Image)resources.GetObject("pictureBoxTitle.Image");
            pictureBoxTitle.Location = new Point(113, 7);
            pictureBoxTitle.Name = "pictureBoxTitle";
            pictureBoxTitle.Size = new Size(95, 18);
            pictureBoxTitle.TabIndex = 3;
            pictureBoxTitle.TabStop = false;
            // 
            // upDownLoss
            // 
            upDownLoss.Location = new Point(50, 44);
            upDownLoss.Maximum = new decimal(new int[] { 2, 0, 0, 0 });
            upDownLoss.Name = "upDownLoss";
            upDownLoss.Size = new Size(42, 23);
            upDownLoss.TabIndex = 3;
            upDownLoss.ValueChanged += upDownLoss_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 46);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 2;
            label2.Text = "Loss:";
            // 
            // upDownWin
            // 
            upDownWin.Location = new Point(50, 15);
            upDownWin.Maximum = new decimal(new int[] { 6, 0, 0, 0 });
            upDownWin.Name = "upDownWin";
            upDownWin.Size = new Size(42, 23);
            upDownWin.TabIndex = 1;
            upDownWin.ValueChanged += numericUpDownWin_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 17);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 0;
            label1.Text = "Win:";
            // 
            // tabPageTournament
            // 
            tabPageTournament.Controls.Add(upDownTournamentLoss);
            tabPageTournament.Controls.Add(label6);
            tabPageTournament.Controls.Add(upDownTournamentWin);
            tabPageTournament.Controls.Add(label5);
            tabPageTournament.Controls.Add(textBoxTournament);
            tabPageTournament.Controls.Add(label4);
            tabPageTournament.Controls.Add(panel2);
            tabPageTournament.Location = new Point(4, 24);
            tabPageTournament.Name = "tabPageTournament";
            tabPageTournament.Padding = new Padding(3);
            tabPageTournament.Size = new Size(326, 235);
            tabPageTournament.TabIndex = 1;
            tabPageTournament.Text = "Tournament";
            tabPageTournament.UseVisualStyleBackColor = true;
            // 
            // upDownTournamentLoss
            // 
            upDownTournamentLoss.Location = new Point(50, 90);
            upDownTournamentLoss.Name = "upDownTournamentLoss";
            upDownTournamentLoss.Size = new Size(46, 23);
            upDownTournamentLoss.TabIndex = 11;
            upDownTournamentLoss.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 92);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 10;
            label6.Text = "Loss:";
            // 
            // upDownTournamentWin
            // 
            upDownTournamentWin.Location = new Point(50, 61);
            upDownTournamentWin.Name = "upDownTournamentWin";
            upDownTournamentWin.Size = new Size(46, 23);
            upDownTournamentWin.TabIndex = 9;
            upDownTournamentWin.ValueChanged += upDownTournamentWin_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 63);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 8;
            label5.Text = "Win:";
            // 
            // textBoxTournament
            // 
            textBoxTournament.Location = new Point(8, 21);
            textBoxTournament.Name = "textBoxTournament";
            textBoxTournament.Size = new Size(270, 23);
            textBoxTournament.TabIndex = 7;
            textBoxTournament.Text = "Tournament";
            textBoxTournament.Leave += textBoxTournament_Leave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 3);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 6;
            label4.Text = "Name:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(labelRecord);
            panel2.Controls.Add(labelTournamentName);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(3, 135);
            panel2.Name = "panel2";
            panel2.Size = new Size(320, 97);
            panel2.TabIndex = 5;
            // 
            // labelRecord
            // 
            labelRecord.Font = new Font("Myriad Pro Light", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRecord.ForeColor = Color.White;
            labelRecord.Location = new Point(5, 37);
            labelRecord.Name = "labelRecord";
            labelRecord.Size = new Size(310, 23);
            labelRecord.TabIndex = 1;
            labelRecord.Text = "0-0";
            labelRecord.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelTournamentName
            // 
            labelTournamentName.Font = new Font("Myriad Pro", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTournamentName.ForeColor = Color.White;
            labelTournamentName.Location = new Point(5, 11);
            labelTournamentName.Name = "labelTournamentName";
            labelTournamentName.Size = new Size(310, 23);
            labelTournamentName.TabIndex = 0;
            labelTournamentName.Text = "Tournament";
            labelTournamentName.TextAlign = ContentAlignment.TopCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 288);
            Controls.Add(tabControl1);
            Controls.Add(toolStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainForm";
            Text = "Star Realms Tracker";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPageArena.ResumeLayout(false);
            tabPageArena.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLoss1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLoss0).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxWin5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxWin4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxWin3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxWin2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxWin1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxWin0).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTitle).EndInit();
            ((System.ComponentModel.ISupportInitialize)upDownLoss).EndInit();
            ((System.ComponentModel.ISupportInitialize)upDownWin).EndInit();
            tabPageTournament.ResumeLayout(false);
            tabPageTournament.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)upDownTournamentLoss).EndInit();
            ((System.ComponentModel.ISupportInitialize)upDownTournamentWin).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private TabControl tabControl1;
        private TabPage tabPageArena;
        private TabPage tabPageTournament;
        private NumericUpDown upDownWin;
        private Label label1;
        private ToolStripButton toolStripButtonReset;
        private NumericUpDown upDownLoss;
        private Label label2;
        private Panel panel1;
        private PictureBox pictureBoxTitle;
        private Panel panel2;
        private Label labelTournamentName;
        private NumericUpDown upDownTournamentLoss;
        private Label label6;
        private NumericUpDown upDownTournamentWin;
        private Label label5;
        private TextBox textBoxTournament;
        private Label label4;
        private Label labelRecord;
        private PictureBox pictureBoxWin0;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBoxLoss1;
        private PictureBox pictureBoxLoss0;
        private PictureBox pictureBoxWin5;
        private PictureBox pictureBoxWin4;
        private PictureBox pictureBoxWin3;
        private PictureBox pictureBoxWin2;
        private PictureBox pictureBoxWin1;
    }
}
