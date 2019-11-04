namespace ErgasiaCS
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.Label();
            this.groupLevel = new System.Windows.Forms.GroupBox();
            this.hardBtn = new System.Windows.Forms.RadioButton();
            this.regularBtn = new System.Windows.Forms.RadioButton();
            this.easyBtn = new System.Windows.Forms.RadioButton();
            this.leaderBtn = new System.Windows.Forms.Button();
            this.playBtn = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.playPanel = new System.Windows.Forms.Panel();
            this.loseLbl = new System.Windows.Forms.Label();
            this.stopBtn = new System.Windows.Forms.Button();
            this.continueBtn = new System.Windows.Forms.Button();
            this.finalScrLbl = new System.Windows.Forms.Label();
            this.congraLbl = new System.Windows.Forms.Label();
            this.infoLbl = new System.Windows.Forms.Label();
            this.hitBox = new System.Windows.Forms.PictureBox();
            this.topPanel = new System.Windows.Forms.Panel();
            this.scoreLbl = new System.Windows.Forms.Label();
            this.userLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timeLbl = new System.Windows.Forms.Label();
            this.leaderboardPanel = new System.Windows.Forms.Panel();
            this.exitBtn = new System.Windows.Forms.Button();
            this.leaderboardLbl = new System.Windows.Forms.Label();
            this.leaderboardTable = new System.Windows.Forms.TableLayoutPanel();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.locTimer = new System.Windows.Forms.Timer(this.components);
            this.mainExitBtn = new System.Windows.Forms.Button();
            this.backColorTimer = new System.Windows.Forms.Timer(this.components);
            this.infoBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupLevel.SuspendLayout();
            this.playPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hitBox)).BeginInit();
            this.topPanel.SuspendLayout();
            this.leaderboardPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(689, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Stencil", 72F, System.Drawing.FontStyle.Bold);
            this.title.Location = new System.Drawing.Point(274, 211);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(1056, 142);
            this.title.TabIndex = 1;
            this.title.Text = "bitcoin hunter";
            // 
            // groupLevel
            // 
            this.groupLevel.Controls.Add(this.hardBtn);
            this.groupLevel.Controls.Add(this.regularBtn);
            this.groupLevel.Controls.Add(this.easyBtn);
            this.groupLevel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupLevel.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupLevel.Location = new System.Drawing.Point(584, 418);
            this.groupLevel.Name = "groupLevel";
            this.groupLevel.Size = new System.Drawing.Size(349, 260);
            this.groupLevel.TabIndex = 2;
            this.groupLevel.TabStop = false;
            this.groupLevel.Text = "difficulty";
            // 
            // hardBtn
            // 
            this.hardBtn.AutoSize = true;
            this.hardBtn.Font = new System.Drawing.Font("Stencil", 15F, System.Drawing.FontStyle.Bold);
            this.hardBtn.Location = new System.Drawing.Point(88, 167);
            this.hardBtn.Name = "hardBtn";
            this.hardBtn.Size = new System.Drawing.Size(105, 34);
            this.hardBtn.TabIndex = 2;
            this.hardBtn.Text = "hard";
            this.hardBtn.UseVisualStyleBackColor = true;
            // 
            // regularBtn
            // 
            this.regularBtn.AutoSize = true;
            this.regularBtn.Font = new System.Drawing.Font("Stencil", 15F, System.Drawing.FontStyle.Bold);
            this.regularBtn.Location = new System.Drawing.Point(88, 109);
            this.regularBtn.Name = "regularBtn";
            this.regularBtn.Size = new System.Drawing.Size(151, 34);
            this.regularBtn.TabIndex = 1;
            this.regularBtn.Text = "regular";
            this.regularBtn.UseVisualStyleBackColor = true;
            // 
            // easyBtn
            // 
            this.easyBtn.AutoSize = true;
            this.easyBtn.Font = new System.Drawing.Font("Stencil", 15F, System.Drawing.FontStyle.Bold);
            this.easyBtn.Location = new System.Drawing.Point(88, 51);
            this.easyBtn.Name = "easyBtn";
            this.easyBtn.Size = new System.Drawing.Size(97, 34);
            this.easyBtn.TabIndex = 0;
            this.easyBtn.Text = "easy";
            this.easyBtn.UseVisualStyleBackColor = true;
            // 
            // leaderBtn
            // 
            this.leaderBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(168)))), ((int)(((byte)(7)))));
            this.leaderBtn.Font = new System.Drawing.Font("Stencil", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leaderBtn.Location = new System.Drawing.Point(242, 667);
            this.leaderBtn.Name = "leaderBtn";
            this.leaderBtn.Size = new System.Drawing.Size(226, 104);
            this.leaderBtn.TabIndex = 3;
            this.leaderBtn.Text = "leaderboard";
            this.leaderBtn.UseVisualStyleBackColor = false;
            this.leaderBtn.Click += new System.EventHandler(this.leaderBtn_Click);
            // 
            // playBtn
            // 
            this.playBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(168)))), ((int)(((byte)(7)))));
            this.playBtn.Font = new System.Drawing.Font("Stencil", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playBtn.Location = new System.Drawing.Point(1010, 667);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(226, 104);
            this.playBtn.TabIndex = 5;
            this.playBtn.Text = "play";
            this.playBtn.UseVisualStyleBackColor = false;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Stencil", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(677, 709);
            this.nameTextBox.Multiline = false;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(146, 30);
            this.nameTextBox.TabIndex = 7;
            this.nameTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(684, 776);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "username";
            // 
            // playPanel
            // 
            this.playPanel.Controls.Add(this.loseLbl);
            this.playPanel.Controls.Add(this.stopBtn);
            this.playPanel.Controls.Add(this.continueBtn);
            this.playPanel.Controls.Add(this.finalScrLbl);
            this.playPanel.Controls.Add(this.congraLbl);
            this.playPanel.Controls.Add(this.infoLbl);
            this.playPanel.Controls.Add(this.hitBox);
            this.playPanel.Controls.Add(this.topPanel);
            this.playPanel.Location = new System.Drawing.Point(1136, 264);
            this.playPanel.Name = "playPanel";
            this.playPanel.Size = new System.Drawing.Size(1571, 967);
            this.playPanel.TabIndex = 9;
            this.playPanel.Visible = false;
            // 
            // loseLbl
            // 
            this.loseLbl.AutoSize = true;
            this.loseLbl.Font = new System.Drawing.Font("Stencil", 48F, System.Drawing.FontStyle.Bold);
            this.loseLbl.Location = new System.Drawing.Point(217, 501);
            this.loseLbl.Name = "loseLbl";
            this.loseLbl.Size = new System.Drawing.Size(436, 95);
            this.loseLbl.TabIndex = 12;
            this.loseLbl.Text = "you lost!";
            // 
            // stopBtn
            // 
            this.stopBtn.BackColor = System.Drawing.Color.Red;
            this.stopBtn.Font = new System.Drawing.Font("Stencil", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopBtn.Location = new System.Drawing.Point(1512, 106);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(120, 57);
            this.stopBtn.TabIndex = 11;
            this.stopBtn.Text = "STOP";
            this.stopBtn.UseVisualStyleBackColor = false;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // continueBtn
            // 
            this.continueBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(168)))), ((int)(((byte)(7)))));
            this.continueBtn.Font = new System.Drawing.Font("Stencil", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continueBtn.Location = new System.Drawing.Point(672, 684);
            this.continueBtn.Name = "continueBtn";
            this.continueBtn.Size = new System.Drawing.Size(226, 104);
            this.continueBtn.TabIndex = 5;
            this.continueBtn.Text = "continue";
            this.continueBtn.UseVisualStyleBackColor = false;
            this.continueBtn.Visible = false;
            this.continueBtn.Click += new System.EventHandler(this.continueBtn_Click);
            // 
            // finalScrLbl
            // 
            this.finalScrLbl.AutoSize = true;
            this.finalScrLbl.Font = new System.Drawing.Font("Stencil", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalScrLbl.Location = new System.Drawing.Point(420, 295);
            this.finalScrLbl.Name = "finalScrLbl";
            this.finalScrLbl.Size = new System.Drawing.Size(673, 95);
            this.finalScrLbl.TabIndex = 4;
            this.finalScrLbl.Text = "your score is: ";
            this.finalScrLbl.Visible = false;
            // 
            // congraLbl
            // 
            this.congraLbl.AutoSize = true;
            this.congraLbl.Font = new System.Drawing.Font("Stencil", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.congraLbl.Location = new System.Drawing.Point(410, 190);
            this.congraLbl.Name = "congraLbl";
            this.congraLbl.Size = new System.Drawing.Size(770, 95);
            this.congraLbl.TabIndex = 3;
            this.congraLbl.Text = "congratulation!";
            this.congraLbl.Visible = false;
            // 
            // infoLbl
            // 
            this.infoLbl.AutoSize = true;
            this.infoLbl.Font = new System.Drawing.Font("Stencil", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLbl.Location = new System.Drawing.Point(365, 190);
            this.infoLbl.Name = "infoLbl";
            this.infoLbl.Size = new System.Drawing.Size(944, 95);
            this.infoLbl.TabIndex = 2;
            this.infoLbl.Text = "collect the bitcoins";
            // 
            // hitBox
            // 
            this.hitBox.Location = new System.Drawing.Point(704, 469);
            this.hitBox.Name = "hitBox";
            this.hitBox.Size = new System.Drawing.Size(100, 50);
            this.hitBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hitBox.TabIndex = 1;
            this.hitBox.TabStop = false;
            this.hitBox.Click += new System.EventHandler(this.hitBox_Click);
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(168)))), ((int)(((byte)(7)))));
            this.topPanel.Controls.Add(this.scoreLbl);
            this.topPanel.Controls.Add(this.userLbl);
            this.topPanel.Controls.Add(this.label3);
            this.topPanel.Controls.Add(this.label2);
            this.topPanel.Controls.Add(this.timeLbl);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1571, 100);
            this.topPanel.TabIndex = 0;
            // 
            // scoreLbl
            // 
            this.scoreLbl.AutoSize = true;
            this.scoreLbl.Font = new System.Drawing.Font("Stencil", 16F, System.Drawing.FontStyle.Bold);
            this.scoreLbl.Location = new System.Drawing.Point(1532, 44);
            this.scoreLbl.Name = "scoreLbl";
            this.scoreLbl.Size = new System.Drawing.Size(32, 32);
            this.scoreLbl.TabIndex = 5;
            this.scoreLbl.Text = "0";
            // 
            // userLbl
            // 
            this.userLbl.AutoSize = true;
            this.userLbl.Font = new System.Drawing.Font("Stencil", 15F, System.Drawing.FontStyle.Bold);
            this.userLbl.Location = new System.Drawing.Point(201, 44);
            this.userLbl.Name = "userLbl";
            this.userLbl.Size = new System.Drawing.Size(49, 30);
            this.userLbl.TabIndex = 4;
            this.userLbl.Text = "un";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Stencil", 17F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 34);
            this.label3.TabIndex = 3;
            this.label3.Text = "username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 17F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(1395, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "score:";
            // 
            // timeLbl
            // 
            this.timeLbl.AutoSize = true;
            this.timeLbl.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLbl.Location = new System.Drawing.Point(677, 22);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(147, 47);
            this.timeLbl.TabIndex = 1;
            this.timeLbl.Text = "timer";
            // 
            // leaderboardPanel
            // 
            this.leaderboardPanel.Controls.Add(this.exitBtn);
            this.leaderboardPanel.Controls.Add(this.leaderboardLbl);
            this.leaderboardPanel.Controls.Add(this.leaderboardTable);
            this.leaderboardPanel.Location = new System.Drawing.Point(25, 733);
            this.leaderboardPanel.Name = "leaderboardPanel";
            this.leaderboardPanel.Size = new System.Drawing.Size(1413, 1033);
            this.leaderboardPanel.TabIndex = 10;
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Red;
            this.exitBtn.Font = new System.Drawing.Font("Stencil", 13F, System.Drawing.FontStyle.Bold);
            this.exitBtn.Location = new System.Drawing.Point(1322, 764);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(185, 77);
            this.exitBtn.TabIndex = 10;
            this.exitBtn.Text = "exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // leaderboardLbl
            // 
            this.leaderboardLbl.AutoSize = true;
            this.leaderboardLbl.Font = new System.Drawing.Font("Stencil", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leaderboardLbl.Location = new System.Drawing.Point(623, 32);
            this.leaderboardLbl.Name = "leaderboardLbl";
            this.leaderboardLbl.Size = new System.Drawing.Size(457, 71);
            this.leaderboardLbl.TabIndex = 1;
            this.leaderboardLbl.Text = "leaderboard";
            // 
            // leaderboardTable
            // 
            this.leaderboardTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(168)))), ((int)(((byte)(7)))));
            this.leaderboardTable.ColumnCount = 3;
            this.leaderboardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.leaderboardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.leaderboardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.leaderboardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.leaderboardTable.Location = new System.Drawing.Point(491, 145);
            this.leaderboardTable.Name = "leaderboardTable";
            this.leaderboardTable.RowCount = 10;
            this.leaderboardTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.leaderboardTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.leaderboardTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.leaderboardTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.leaderboardTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.leaderboardTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.leaderboardTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.leaderboardTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.leaderboardTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.leaderboardTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.leaderboardTable.Size = new System.Drawing.Size(707, 763);
            this.leaderboardTable.TabIndex = 0;
            // 
            // mainTimer
            // 
            this.mainTimer.Interval = 1000;
            this.mainTimer.Tick += new System.EventHandler(this.mainTimer_Tick);
            // 
            // locTimer
            // 
            this.locTimer.Interval = 1500;
            this.locTimer.Tick += new System.EventHandler(this.locTimer_Tick);
            // 
            // mainExitBtn
            // 
            this.mainExitBtn.BackColor = System.Drawing.Color.Red;
            this.mainExitBtn.Font = new System.Drawing.Font("Stencil", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainExitBtn.Location = new System.Drawing.Point(630, 870);
            this.mainExitBtn.Name = "mainExitBtn";
            this.mainExitBtn.Size = new System.Drawing.Size(190, 85);
            this.mainExitBtn.TabIndex = 11;
            this.mainExitBtn.Text = "exit";
            this.mainExitBtn.UseVisualStyleBackColor = false;
            this.mainExitBtn.Click += new System.EventHandler(this.mainExitBtn_Click);
            // 
            // backColorTimer
            // 
            this.backColorTimer.Interval = 50;
            this.backColorTimer.Tick += new System.EventHandler(this.backColorTimer_Tick);
            // 
            // infoBtn
            // 
            this.infoBtn.BackColor = System.Drawing.Color.Silver;
            this.infoBtn.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Bold);
            this.infoBtn.Location = new System.Drawing.Point(660, 971);
            this.infoBtn.Name = "infoBtn";
            this.infoBtn.Size = new System.Drawing.Size(144, 39);
            this.infoBtn.TabIndex = 12;
            this.infoBtn.Text = "info";
            this.infoBtn.UseVisualStyleBackColor = false;
            this.infoBtn.Click += new System.EventHandler(this.infoBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(83)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(1697, 1007);
            this.Controls.Add(this.leaderboardPanel);
            this.Controls.Add(this.playPanel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.playBtn);
            this.Controls.Add(this.leaderBtn);
            this.Controls.Add(this.groupLevel);
            this.Controls.Add(this.title);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainExitBtn);
            this.Controls.Add(this.infoBtn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Bitoin Hunter";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupLevel.ResumeLayout(false);
            this.groupLevel.PerformLayout();
            this.playPanel.ResumeLayout(false);
            this.playPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hitBox)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.leaderboardPanel.ResumeLayout(false);
            this.leaderboardPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.GroupBox groupLevel;
        private System.Windows.Forms.RadioButton hardBtn;
        private System.Windows.Forms.RadioButton regularBtn;
        private System.Windows.Forms.RadioButton easyBtn;
        private System.Windows.Forms.Button leaderBtn;
        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.RichTextBox nameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel playPanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label timeLbl;
        private System.Windows.Forms.Timer mainTimer;
        private System.Windows.Forms.PictureBox hitBox;
        private System.Windows.Forms.Label infoLbl;
        private System.Windows.Forms.Label scoreLbl;
        private System.Windows.Forms.Label userLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer locTimer;
        private System.Windows.Forms.Label finalScrLbl;
        private System.Windows.Forms.Label congraLbl;
        private System.Windows.Forms.Button continueBtn;
        private System.Windows.Forms.Panel leaderboardPanel;
        private System.Windows.Forms.Label leaderboardLbl;
        private System.Windows.Forms.TableLayoutPanel leaderboardTable;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Label loseLbl;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button mainExitBtn;
        private System.Windows.Forms.Timer backColorTimer;
        private System.Windows.Forms.Button infoBtn;
    }
}

