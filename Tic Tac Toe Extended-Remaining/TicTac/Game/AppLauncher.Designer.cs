namespace Game
{
    partial class AppLauncher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppLauncher));
            this.containerPanel = new System.Windows.Forms.Panel();
            this.shutDown = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.onlineGame = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pcGame = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.twoPlayerGame = new System.Windows.Forms.PictureBox();
            this.tic_Tac_Toe_Form1 = new Game.Tic_Tac_Toe_Form();
            this.twoPlayerGame1 = new Game.TwoPlayerGame();
            this.homeControl1 = new Game.HomeControl();
            this.pc_Tic_Tac_Toe1 = new Game.Pc_Tic_Tac_Toe();
            this.containerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shutDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlineGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.twoPlayerGame)).BeginInit();
            this.SuspendLayout();
            // 
            // containerPanel
            // 
            this.containerPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.containerPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.containerPanel.Controls.Add(this.shutDown);
            this.containerPanel.Controls.Add(this.label3);
            this.containerPanel.Controls.Add(this.onlineGame);
            this.containerPanel.Controls.Add(this.label2);
            this.containerPanel.Controls.Add(this.pcGame);
            this.containerPanel.Controls.Add(this.label1);
            this.containerPanel.Controls.Add(this.twoPlayerGame);
            this.containerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.containerPanel.Location = new System.Drawing.Point(0, 308);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Size = new System.Drawing.Size(644, 100);
            this.containerPanel.TabIndex = 0;
            // 
            // shutDown
            // 
            this.shutDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.shutDown.Image = ((System.Drawing.Image)(resources.GetObject("shutDown.Image")));
            this.shutDown.Location = new System.Drawing.Point(587, 59);
            this.shutDown.Name = "shutDown";
            this.shutDown.Size = new System.Drawing.Size(45, 29);
            this.shutDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.shutDown.TabIndex = 6;
            this.shutDown.TabStop = false;
            this.shutDown.Click += new System.EventHandler(this.shutDown_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(398, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Go Online";
            // 
            // onlineGame
            // 
            this.onlineGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.onlineGame.Image = ((System.Drawing.Image)(resources.GetObject("onlineGame.Image")));
            this.onlineGame.Location = new System.Drawing.Point(402, 4);
            this.onlineGame.Name = "onlineGame";
            this.onlineGame.Size = new System.Drawing.Size(87, 66);
            this.onlineGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.onlineGame.TabIndex = 4;
            this.onlineGame.TabStop = false;
            this.onlineGame.Click += new System.EventHandler(this.onlineGame_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(228, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Play with PC";
            // 
            // pcGame
            // 
            this.pcGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcGame.Image = ((System.Drawing.Image)(resources.GetObject("pcGame.Image")));
            this.pcGame.Location = new System.Drawing.Point(245, 4);
            this.pcGame.Name = "pcGame";
            this.pcGame.Size = new System.Drawing.Size(87, 66);
            this.pcGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcGame.TabIndex = 2;
            this.pcGame.TabStop = false;
            this.pcGame.Click += new System.EventHandler(this.pcGame_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(68, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "2 Player Mode";
            // 
            // twoPlayerGame
            // 
            this.twoPlayerGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.twoPlayerGame.Image = ((System.Drawing.Image)(resources.GetObject("twoPlayerGame.Image")));
            this.twoPlayerGame.Location = new System.Drawing.Point(92, 4);
            this.twoPlayerGame.Name = "twoPlayerGame";
            this.twoPlayerGame.Size = new System.Drawing.Size(87, 66);
            this.twoPlayerGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.twoPlayerGame.TabIndex = 0;
            this.twoPlayerGame.TabStop = false;
            this.twoPlayerGame.Click += new System.EventHandler(this.twoPlayerGame_Click);
            // 
            // tic_Tac_Toe_Form1
            // 
            this.tic_Tac_Toe_Form1.Location = new System.Drawing.Point(142, 11);
            this.tic_Tac_Toe_Form1.Name = "tic_Tac_Toe_Form1";
            this.tic_Tac_Toe_Form1.Size = new System.Drawing.Size(335, 291);
            this.tic_Tac_Toe_Form1.TabIndex = 3;
            // 
            // twoPlayerGame1
            // 
            this.twoPlayerGame1.Location = new System.Drawing.Point(142, 11);
            this.twoPlayerGame1.Name = "twoPlayerGame1";
            this.twoPlayerGame1.Size = new System.Drawing.Size(335, 291);
            this.twoPlayerGame1.TabIndex = 2;
            // 
            // homeControl1
            // 
            this.homeControl1.Location = new System.Drawing.Point(142, 11);
            this.homeControl1.Name = "homeControl1";
            this.homeControl1.Size = new System.Drawing.Size(335, 291);
            this.homeControl1.TabIndex = 1;
            // 
            // pc_Tic_Tac_Toe1
            // 
            this.pc_Tic_Tac_Toe1.Location = new System.Drawing.Point(142, 8);
            this.pc_Tic_Tac_Toe1.Name = "pc_Tic_Tac_Toe1";
            this.pc_Tic_Tac_Toe1.Size = new System.Drawing.Size(335, 291);
            this.pc_Tic_Tac_Toe1.TabIndex = 5;
            // 
            // AppLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 408);
            this.Controls.Add(this.pc_Tic_Tac_Toe1);
            this.Controls.Add(this.tic_Tac_Toe_Form1);
            this.Controls.Add(this.twoPlayerGame1);
            this.Controls.Add(this.homeControl1);
            this.Controls.Add(this.containerPanel);
            this.Name = "AppLauncher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic-Tac-Toe Menu";
            this.Load += new System.EventHandler(this.AppLauncher_Load);
            this.containerPanel.ResumeLayout(false);
            this.containerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shutDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlineGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.twoPlayerGame)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel containerPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox twoPlayerGame;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox onlineGame;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pcGame;
        private System.Windows.Forms.PictureBox shutDown;
        private HomeControl homeControl1;
        private TwoPlayerGame twoPlayerGame1;
        private Tic_Tac_Toe_Form tic_Tac_Toe_Form1;
        private Pc_Tic_Tac_Toe pc_Tic_Tac_Toe1;
    }
}