namespace Game
{
    partial class logInSignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(logInSignUp));
            this.headerLab = new System.Windows.Forms.Label();
            this.shutDownbtn = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.userNameBox = new System.Windows.Forms.TextBox();
            this.passWordBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.loginBtn = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.signUpBtn = new Guna.UI2.WinForms.Guna2GradientTileButton();
            ((System.ComponentModel.ISupportInitialize)(this.shutDownbtn)).BeginInit();
            this.SuspendLayout();
            // 
            // headerLab
            // 
            this.headerLab.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.headerLab.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.headerLab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.headerLab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.headerLab.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLab.ForeColor = System.Drawing.Color.Purple;
            this.headerLab.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.headerLab.Location = new System.Drawing.Point(-3, 0);
            this.headerLab.Name = "headerLab";
            this.headerLab.Size = new System.Drawing.Size(381, 39);
            this.headerLab.TabIndex = 0;
            this.headerLab.Text = "Tic Tac Toe ";
            this.headerLab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // shutDownbtn
            // 
            this.shutDownbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.shutDownbtn.Image = ((System.Drawing.Image)(resources.GetObject("shutDownbtn.Image")));
            this.shutDownbtn.Location = new System.Drawing.Point(336, 5);
            this.shutDownbtn.Name = "shutDownbtn";
            this.shutDownbtn.Size = new System.Drawing.Size(33, 31);
            this.shutDownbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.shutDownbtn.TabIndex = 1;
            this.shutDownbtn.TabStop = false;
            this.shutDownbtn.Click += new System.EventHandler(this.shutDownbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(28, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "User Name:";
            // 
            // userNameBox
            // 
            this.userNameBox.Location = new System.Drawing.Point(142, 96);
            this.userNameBox.Name = "userNameBox";
            this.userNameBox.Size = new System.Drawing.Size(210, 20);
            this.userNameBox.TabIndex = 3;
            // 
            // passWordBox
            // 
            this.passWordBox.Location = new System.Drawing.Point(141, 169);
            this.passWordBox.Name = "passWordBox";
            this.passWordBox.PasswordChar = '*';
            this.passWordBox.Size = new System.Drawing.Size(210, 20);
            this.passWordBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(27, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password:";
            // 
            // loginBtn
            // 
            this.loginBtn.CheckedState.Parent = this.loginBtn;
            this.loginBtn.CustomImages.Parent = this.loginBtn;
            this.loginBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.HoverState.Parent = this.loginBtn;
            this.loginBtn.Location = new System.Drawing.Point(31, 245);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.ShadowDecoration.Parent = this.loginBtn;
            this.loginBtn.Size = new System.Drawing.Size(152, 33);
            this.loginBtn.TabIndex = 6;
            this.loginBtn.Text = "Login";
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // signUpBtn
            // 
            this.signUpBtn.CheckedState.Parent = this.signUpBtn;
            this.signUpBtn.CustomImages.Parent = this.signUpBtn;
            this.signUpBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.signUpBtn.ForeColor = System.Drawing.Color.White;
            this.signUpBtn.HoverState.Parent = this.signUpBtn;
            this.signUpBtn.Location = new System.Drawing.Point(194, 245);
            this.signUpBtn.Name = "signUpBtn";
            this.signUpBtn.ShadowDecoration.Parent = this.signUpBtn;
            this.signUpBtn.Size = new System.Drawing.Size(152, 33);
            this.signUpBtn.TabIndex = 7;
            this.signUpBtn.Text = "SignUp";
            this.signUpBtn.Click += new System.EventHandler(this.signUpBtn_Click);
            // 
            // logInSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(378, 403);
            this.Controls.Add(this.signUpBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.passWordBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userNameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shutDownbtn);
            this.Controls.Add(this.headerLab);
            this.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "logInSignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.shutDownbtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLab;
        private System.Windows.Forms.PictureBox shutDownbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userNameBox;
        private System.Windows.Forms.TextBox passWordBox;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2GradientTileButton loginBtn;
        private Guna.UI2.WinForms.Guna2GradientTileButton signUpBtn;
    }
}

