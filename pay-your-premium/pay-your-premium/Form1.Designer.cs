namespace pay_your_premium
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.User = new System.Windows.Forms.TextBox();
            this.Pass = new System.Windows.Forms.TextBox();
            this.pnluser = new System.Windows.Forms.Panel();
            this.picuser = new System.Windows.Forms.PictureBox();
            this.pnlpass = new System.Windows.Forms.Panel();
            this.picpass = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pnltxt = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picuser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picpass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.pnltxt.SuspendLayout();
            this.SuspendLayout();
            // 
            // User
            // 
            this.User.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.User.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.User.Font = new System.Drawing.Font("Microsoft Yi Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User.ForeColor = System.Drawing.Color.DimGray;
            this.User.HideSelection = false;
            this.User.Location = new System.Drawing.Point(65, 182);
            this.User.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(264, 24);
            this.User.TabIndex = 0;
            this.User.TabStop = false;
            this.User.Text = "Username";
            this.User.Click += new System.EventHandler(this.User_Click);
            this.User.Enter += new System.EventHandler(this.User_Enter);
            this.User.Leave += new System.EventHandler(this.User_Leave);
            // 
            // Pass
            // 
            this.Pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.Pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Pass.Font = new System.Drawing.Font("Microsoft Yi Baiti", 13.8F);
            this.Pass.ForeColor = System.Drawing.Color.DimGray;
            this.Pass.HideSelection = false;
            this.Pass.Location = new System.Drawing.Point(65, 249);
            this.Pass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(264, 24);
            this.Pass.TabIndex = 1;
            this.Pass.TabStop = false;
            this.Pass.Text = "Password";
            this.Pass.UseSystemPasswordChar = true;
            this.Pass.Enter += new System.EventHandler(this.Pass_Enter);
            this.Pass.Leave += new System.EventHandler(this.Pass_Leave);
            // 
            // pnluser
            // 
            this.pnluser.BackColor = System.Drawing.Color.White;
            this.pnluser.Location = new System.Drawing.Point(29, 214);
            this.pnluser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnluser.Name = "pnluser";
            this.pnluser.Size = new System.Drawing.Size(300, 2);
            this.pnluser.TabIndex = 4;
            // 
            // picuser
            // 
            this.picuser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.picuser.Image = global::pay_your_premium.Properties.Resources.R;
            this.picuser.Location = new System.Drawing.Point(29, 181);
            this.picuser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picuser.Name = "picuser";
            this.picuser.Size = new System.Drawing.Size(29, 27);
            this.picuser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picuser.TabIndex = 0;
            this.picuser.TabStop = false;
            // 
            // pnlpass
            // 
            this.pnlpass.BackColor = System.Drawing.Color.White;
            this.pnlpass.Location = new System.Drawing.Point(29, 282);
            this.pnlpass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlpass.Name = "pnlpass";
            this.pnlpass.Size = new System.Drawing.Size(300, 2);
            this.pnlpass.TabIndex = 5;
            // 
            // picpass
            // 
            this.picpass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.picpass.Image = global::pay_your_premium.Properties.Resources.R__2_;
            this.picpass.Location = new System.Drawing.Point(29, 249);
            this.picpass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picpass.Name = "picpass";
            this.picpass.Size = new System.Drawing.Size(29, 27);
            this.picpass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picpass.TabIndex = 1;
            this.picpass.TabStop = false;
            this.picpass.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picpass_MouseDown);
            this.picpass.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picpass_MouseUp);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(101)))), ((int)(((byte)(199)))));
            this.close.Image = global::pay_your_premium.Properties.Resources.error;
            this.close.Location = new System.Drawing.Point(1027, 2);
            this.close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(29, 28);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close.TabIndex = 6;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(101)))), ((int)(((byte)(199)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(65, 329);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 34);
            this.button1.TabIndex = 7;
            this.button1.Text = "LOGIN";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnltxt
            // 
            this.pnltxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(101)))), ((int)(((byte)(199)))));
            this.pnltxt.Controls.Add(this.label3);
            this.pnltxt.Controls.Add(this.label2);
            this.pnltxt.Controls.Add(this.label1);
            this.pnltxt.Location = new System.Drawing.Point(709, 282);
            this.pnltxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnltxt.Name = "pnltxt";
            this.pnltxt.Size = new System.Drawing.Size(345, 233);
            this.pnltxt.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(196, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 52);
            this.label3.TabIndex = 2;
            this.label3.Text = "Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 52);
            this.label2.TabIndex = 1;
            this.label2.Text = "Welcome To ";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pay Your Premium";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.linkLabel1.LinkColor = System.Drawing.Color.Gray;
            this.linkLabel1.Location = new System.Drawing.Point(95, 367);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(126, 17);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Forget Password ?";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::pay_your_premium.Properties.Resources.animated_devices11;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.pnltxt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.close);
            this.Controls.Add(this.picpass);
            this.Controls.Add(this.picuser);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.User);
            this.Controls.Add(this.pnlpass);
            this.Controls.Add(this.pnluser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.picuser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picpass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.pnltxt.ResumeLayout(false);
            this.pnltxt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox User;
        private System.Windows.Forms.TextBox Pass;
        private System.Windows.Forms.Panel pnluser;
        private System.Windows.Forms.PictureBox picuser;
        private System.Windows.Forms.Panel pnlpass;
        private System.Windows.Forms.PictureBox picpass;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnltxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

