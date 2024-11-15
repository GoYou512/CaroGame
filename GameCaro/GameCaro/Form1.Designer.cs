namespace GameCaro
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pnlChessBoard = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            label1 = new Label();
            pctbMark = new PictureBox();
            btnLAN = new Button();
            txbIP = new TextBox();
            prcbCoolDown = new ProgressBar();
            txbPlayerName = new TextBox();
            tmCoolDown = new System.Windows.Forms.Timer(components);
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            newGameToolStripMenuItem = new ToolStripMenuItem();
            quitToolStripMenuItem = new ToolStripMenuItem();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctbMark).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlChessBoard
            // 
            pnlChessBoard.Location = new Point(33, 61);
            pnlChessBoard.Name = "pnlChessBoard";
            pnlChessBoard.Size = new Size(611, 611);
            pnlChessBoard.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(646, 61);
            panel2.Name = "panel2";
            panel2.Size = new Size(471, 352);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.logocaro;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(16, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(440, 322);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel3.BackColor = SystemColors.Control;
            panel3.Controls.Add(label1);
            panel3.Controls.Add(pctbMark);
            panel3.Controls.Add(btnLAN);
            panel3.Controls.Add(txbIP);
            panel3.Controls.Add(prcbCoolDown);
            panel3.Controls.Add(txbPlayerName);
            panel3.Location = new Point(646, 441);
            panel3.Name = "panel3";
            panel3.Size = new Size(471, 231);
            panel3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun-ExtB", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(223, 169);
            label1.Name = "label1";
            label1.Size = new Size(207, 19);
            label1.TabIndex = 5;
            label1.Text = "5 In A Line To Win";
            // 
            // pctbMark
            // 
            pctbMark.Location = new Point(295, 6);
            pctbMark.Name = "pctbMark";
            pctbMark.Size = new Size(135, 128);
            pctbMark.SizeMode = PictureBoxSizeMode.StretchImage;
            pctbMark.TabIndex = 4;
            pctbMark.TabStop = false;
            // 
            // btnLAN
            // 
            btnLAN.Location = new Point(16, 154);
            btnLAN.Name = "btnLAN";
            btnLAN.Size = new Size(157, 34);
            btnLAN.TabIndex = 3;
            btnLAN.Text = "LAN";
            btnLAN.UseVisualStyleBackColor = true;
            btnLAN.Click += btnLAN_Click;
            // 
            // txbIP
            // 
            txbIP.Location = new Point(14, 111);
            txbIP.Name = "txbIP";
            txbIP.Size = new Size(235, 23);
            txbIP.TabIndex = 2;
            txbIP.Text = "127.00.0.1";
            // 
            // prcbCoolDown
            // 
            prcbCoolDown.Location = new Point(14, 62);
            prcbCoolDown.Name = "prcbCoolDown";
            prcbCoolDown.Size = new Size(235, 28);
            prcbCoolDown.TabIndex = 1;
            // 
            // txbPlayerName
            // 
            txbPlayerName.Location = new Point(14, 13);
            txbPlayerName.Name = "txbPlayerName";
            txbPlayerName.ReadOnly = true;
            txbPlayerName.Size = new Size(235, 23);
            txbPlayerName.TabIndex = 0;
            // 
            // tmCoolDown
            // 
            tmCoolDown.Tick += tmCoolDown_Tick;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1129, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newGameToolStripMenuItem, quitToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(50, 20);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // newGameToolStripMenuItem
            // 
            newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            newGameToolStripMenuItem.Size = new Size(180, 22);
            newGameToolStripMenuItem.Text = "New Game";
            newGameToolStripMenuItem.Click += newGameToolStripMenuItem_Click;
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.Size = new Size(180, 22);
            quitToolStripMenuItem.Text = "Quit";
            quitToolStripMenuItem.Click += quitToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1129, 684);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(pnlChessBoard);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Game Caro LAN";
            FormClosing += Form1_FormClosing;
            Shown += Form1_Shown;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pctbMark).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlChessBoard;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox1;
        private ProgressBar prcbCoolDown;
        private TextBox txbPlayerName;
        private PictureBox pctbMark;
        private Button btnLAN;
        private TextBox txbIP;
        private Label label1;
        private System.Windows.Forms.Timer tmCoolDown;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem newGameToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem;
    }
}
