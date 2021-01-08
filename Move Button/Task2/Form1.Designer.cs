namespace Task2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnTop = new System.Windows.Forms.Button();
            this.btnBottom = new System.Windows.Forms.Button();
            this.btnDemo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRight
            // 
            this.btnRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRight.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRight.Location = new System.Drawing.Point(117, 39);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(110, 35);
            this.btnRight.TabIndex = 0;
            this.btnRight.Text = "Right";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLeft.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeft.Location = new System.Drawing.Point(267, 39);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(110, 35);
            this.btnLeft.TabIndex = 1;
            this.btnLeft.Text = "Left";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnTop
            // 
            this.btnTop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTop.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTop.Location = new System.Drawing.Point(117, 95);
            this.btnTop.Name = "btnTop";
            this.btnTop.Size = new System.Drawing.Size(110, 35);
            this.btnTop.TabIndex = 2;
            this.btnTop.Text = "Top";
            this.btnTop.UseVisualStyleBackColor = true;
            this.btnTop.Click += new System.EventHandler(this.btnTop_Click);
            // 
            // btnBottom
            // 
            this.btnBottom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBottom.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBottom.Location = new System.Drawing.Point(267, 95);
            this.btnBottom.Name = "btnBottom";
            this.btnBottom.Size = new System.Drawing.Size(110, 35);
            this.btnBottom.TabIndex = 3;
            this.btnBottom.Text = "Bottom";
            this.btnBottom.UseVisualStyleBackColor = true;
            this.btnBottom.Click += new System.EventHandler(this.btnBottom_Click);
            // 
            // btnDemo
            // 
            this.btnDemo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDemo.FlatAppearance.BorderSize = 0;
            this.btnDemo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDemo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDemo.Image = ((System.Drawing.Image)(resources.GetObject("btnDemo.Image")));
            this.btnDemo.Location = new System.Drawing.Point(191, 260);
            this.btnDemo.Name = "btnDemo";
            this.btnDemo.Size = new System.Drawing.Size(110, 35);
            this.btnDemo.TabIndex = 4;
            this.btnDemo.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 388);
            this.Controls.Add(this.btnDemo);
            this.Controls.Add(this.btnBottom);
            this.Controls.Add(this.btnTop);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnRight);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnTop;
        private System.Windows.Forms.Button btnBottom;
        private System.Windows.Forms.Button btnDemo;
    }
}

