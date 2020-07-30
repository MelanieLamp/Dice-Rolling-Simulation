namespace Dice_Simulation
{
    partial class Dice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dice));
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileClear = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFilePrint = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDice = new System.Windows.Forms.MenuStrip();
            this.radOne = new System.Windows.Forms.RadioButton();
            this.radFive = new System.Windows.Forms.RadioButton();
            this.radTen = new System.Windows.Forms.RadioButton();
            this.radOther = new System.Windows.Forms.RadioButton();
            this.radHundred = new System.Windows.Forms.RadioButton();
            this.txtOther = new System.Windows.Forms.TextBox();
            this.picDie1 = new System.Windows.Forms.PictureBox();
            this.picDie2 = new System.Windows.Forms.PictureBox();
            this.lstDisplay = new System.Windows.Forms.ListBox();
            this.btnRoll = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.ttpDice = new System.Windows.Forms.ToolTip(this.components);
            this.ppdDice = new System.Windows.Forms.PrintPreviewDialog();
            this.pdDice = new System.Drawing.Printing.PrintDocument();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mnuDice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDie1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDie2)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileClear,
            this.toolStripMenuItem1,
            this.mnuFilePrint,
            this.toolStripMenuItem2,
            this.mnuFileQuit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(50, 29);
            this.mnuFile.Text = "&File";
            // 
            // mnuFileClear
            // 
            this.mnuFileClear.Name = "mnuFileClear";
            this.mnuFileClear.Size = new System.Drawing.Size(135, 30);
            this.mnuFileClear.Text = "C&lear";
            this.mnuFileClear.Click += new System.EventHandler(this.mnuFileClear_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(132, 6);
            // 
            // mnuFilePrint
            // 
            this.mnuFilePrint.Name = "mnuFilePrint";
            this.mnuFilePrint.Size = new System.Drawing.Size(135, 30);
            this.mnuFilePrint.Text = "Prin&t";
            this.mnuFilePrint.ToolTipText = "Prints content of GUI";
            this.mnuFilePrint.Click += new System.EventHandler(this.mnuFilePrint_Click_1);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(132, 6);
            // 
            // mnuFileQuit
            // 
            this.mnuFileQuit.Name = "mnuFileQuit";
            this.mnuFileQuit.Size = new System.Drawing.Size(135, 30);
            this.mnuFileQuit.Text = "&Quit";
            this.mnuFileQuit.Click += new System.EventHandler(this.mnuFileQuit_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHelpAbout});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(61, 29);
            this.mnuHelp.Text = "&Help";
            // 
            // mnuHelpAbout
            // 
            this.mnuHelpAbout.Name = "mnuHelpAbout";
            this.mnuHelpAbout.Size = new System.Drawing.Size(146, 30);
            this.mnuHelpAbout.Text = "&About";
            this.mnuHelpAbout.Click += new System.EventHandler(this.mnuHelpAbout_Click);
            // 
            // mnuDice
            // 
            this.mnuDice.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mnuDice.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuHelp});
            this.mnuDice.Location = new System.Drawing.Point(0, 0);
            this.mnuDice.Name = "mnuDice";
            this.mnuDice.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.mnuDice.Size = new System.Drawing.Size(751, 35);
            this.mnuDice.TabIndex = 1;
            this.mnuDice.Text = "menuStrip2";
            // 
            // radOne
            // 
            this.radOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radOne.Location = new System.Drawing.Point(56, 189);
            this.radOne.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radOne.Name = "radOne";
            this.radOne.Size = new System.Drawing.Size(135, 37);
            this.radOne.TabIndex = 2;
            this.radOne.TabStop = true;
            this.radOne.Text = "&One";
            this.radOne.UseVisualStyleBackColor = true;
            // 
            // radFive
            // 
            this.radFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radFive.Location = new System.Drawing.Point(263, 189);
            this.radFive.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radFive.Name = "radFive";
            this.radFive.Size = new System.Drawing.Size(139, 37);
            this.radFive.TabIndex = 3;
            this.radFive.TabStop = true;
            this.radFive.Text = "Fi&ve";
            this.radFive.UseVisualStyleBackColor = true;
            // 
            // radTen
            // 
            this.radTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTen.Location = new System.Drawing.Point(470, 189);
            this.radTen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radTen.Name = "radTen";
            this.radTen.Size = new System.Drawing.Size(189, 37);
            this.radTen.TabIndex = 4;
            this.radTen.TabStop = true;
            this.radTen.Text = "T&en";
            this.radTen.UseVisualStyleBackColor = true;
            // 
            // radOther
            // 
            this.radOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radOther.Location = new System.Drawing.Point(263, 254);
            this.radOther.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radOther.Name = "radOther";
            this.radOther.Size = new System.Drawing.Size(117, 37);
            this.radOther.TabIndex = 6;
            this.radOther.TabStop = true;
            this.radOther.Text = "&Other";
            this.radOther.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radOther.UseVisualStyleBackColor = true;
            this.radOther.CheckedChanged += new System.EventHandler(this.radOther_CheckedChanged);
            // 
            // radHundred
            // 
            this.radHundred.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radHundred.Location = new System.Drawing.Point(56, 254);
            this.radHundred.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radHundred.Name = "radHundred";
            this.radHundred.Size = new System.Drawing.Size(172, 37);
            this.radHundred.TabIndex = 5;
            this.radHundred.TabStop = true;
            this.radHundred.Text = "Hun&dred";
            this.radHundred.UseVisualStyleBackColor = true;
            // 
            // txtOther
            // 
            this.txtOther.Location = new System.Drawing.Point(388, 264);
            this.txtOther.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOther.Name = "txtOther";
            this.txtOther.ReadOnly = true;
            this.txtOther.Size = new System.Drawing.Size(148, 26);
            this.txtOther.TabIndex = 7;
            // 
            // picDie1
            // 
            this.picDie1.Image = ((System.Drawing.Image)(resources.GetObject("picDie1.Image")));
            this.picDie1.Location = new System.Drawing.Point(59, 364);
            this.picDie1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picDie1.Name = "picDie1";
            this.picDie1.Size = new System.Drawing.Size(78, 86);
            this.picDie1.TabIndex = 8;
            this.picDie1.TabStop = false;
            // 
            // picDie2
            // 
            this.picDie2.Image = ((System.Drawing.Image)(resources.GetObject("picDie2.Image")));
            this.picDie2.Location = new System.Drawing.Point(170, 364);
            this.picDie2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picDie2.Name = "picDie2";
            this.picDie2.Size = new System.Drawing.Size(78, 86);
            this.picDie2.TabIndex = 9;
            this.picDie2.TabStop = false;
            // 
            // lstDisplay
            // 
            this.lstDisplay.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDisplay.FormattingEnabled = true;
            this.lstDisplay.ItemHeight = 22;
            this.lstDisplay.Location = new System.Drawing.Point(297, 324);
            this.lstDisplay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstDisplay.Name = "lstDisplay";
            this.lstDisplay.Size = new System.Drawing.Size(362, 180);
            this.lstDisplay.TabIndex = 10;
            // 
            // btnRoll
            // 
            this.btnRoll.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoll.Location = new System.Drawing.Point(59, 524);
            this.btnRoll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(150, 65);
            this.btnRoll.TabIndex = 11;
            this.btnRoll.Text = "&Roll";
            this.btnRoll.UseVisualStyleBackColor = false;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(218, 524);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 65);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(536, 524);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(150, 65);
            this.btnQuit.TabIndex = 14;
            this.btnQuit.Text = "&Quit";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(377, 524);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(150, 65);
            this.btnPrint.TabIndex = 13;
            this.btnPrint.Text = "&Print";
            this.ttpDice.SetToolTip(this.btnPrint, "Print Form as GUI");
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // ppdDice
            // 
            this.ppdDice.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.ppdDice.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.ppdDice.ClientSize = new System.Drawing.Size(400, 300);
            this.ppdDice.Document = this.pdDice;
            this.ppdDice.Enabled = true;
            this.ppdDice.Icon = ((System.Drawing.Icon)(resources.GetObject("ppdDice.Icon")));
            this.ppdDice.Name = "ppdDice";
            this.ppdDice.Visible = false;
            // 
            // pdDice
            // 
            this.pdDice.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pdDice_PrintPage);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 44);
            this.label1.TabIndex = 15;
            this.label1.Text = "Welcome to Dice Simulator!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(114, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(458, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Select the number of times you\'d like to roll the dice:";
            // 
            // Dice
            // 
            this.AcceptButton = this.btnRoll;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(751, 646);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.lstDisplay);
            this.Controls.Add(this.picDie2);
            this.Controls.Add(this.picDie1);
            this.Controls.Add(this.txtOther);
            this.Controls.Add(this.radOther);
            this.Controls.Add(this.radHundred);
            this.Controls.Add(this.radTen);
            this.Controls.Add(this.radFive);
            this.Controls.Add(this.radOne);
            this.Controls.Add(this.mnuDice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Dice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dice Simulator";
            this.mnuDice.ResumeLayout(false);
            this.mnuDice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDie1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDie2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFileClear;
        private System.Windows.Forms.ToolStripMenuItem mnuFileQuit;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuHelpAbout;
        private System.Windows.Forms.MenuStrip mnuDice;
        private System.Windows.Forms.RadioButton radOne;
        private System.Windows.Forms.RadioButton radFive;
        private System.Windows.Forms.RadioButton radTen;
        private System.Windows.Forms.RadioButton radOther;
        private System.Windows.Forms.RadioButton radHundred;
        private System.Windows.Forms.TextBox txtOther;
        private System.Windows.Forms.PictureBox picDie1;
        private System.Windows.Forms.PictureBox picDie2;
        private System.Windows.Forms.ListBox lstDisplay;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.ToolTip ttpDice;
        private System.Windows.Forms.PrintPreviewDialog ppdDice;
        private System.Drawing.Printing.PrintDocument pdDice;
        private System.Windows.Forms.ToolStripMenuItem mnuFilePrint;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

