
namespace SuperShopManagementSystem
{
    partial class LOGIN
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
            this.pictureLogin = new System.Windows.Forms.PictureBox();
            this.lblloginheading = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.cmblogin = new System.Windows.Forms.ComboBox();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.lblclear = new System.Windows.Forms.Label();
            this.lblcrosssign = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureLogin
            // 
            this.pictureLogin.BackgroundImage = global::SuperShopManagementSystem.Properties.Resources.Shop;
            this.pictureLogin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureLogin.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureLogin.Location = new System.Drawing.Point(0, 0);
            this.pictureLogin.Name = "pictureLogin";
            this.pictureLogin.Size = new System.Drawing.Size(201, 368);
            this.pictureLogin.TabIndex = 0;
            this.pictureLogin.TabStop = false;
            // 
            // lblloginheading
            // 
            this.lblloginheading.AutoSize = true;
            this.lblloginheading.Font = new System.Drawing.Font("Modern No. 20", 15.70909F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblloginheading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblloginheading.Location = new System.Drawing.Point(323, 72);
            this.lblloginheading.Name = "lblloginheading";
            this.lblloginheading.Size = new System.Drawing.Size(91, 25);
            this.lblloginheading.TabIndex = 1;
            this.lblloginheading.Text = "LOGIN";
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Modern No. 20", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblusername.Location = new System.Drawing.Point(223, 237);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(122, 21);
            this.lblusername.TabIndex = 2;
            this.lblusername.Text = "USERNAME";
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Font = new System.Drawing.Font("Modern No. 20", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblpassword.Location = new System.Drawing.Point(223, 283);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(120, 21);
            this.lblpassword.TabIndex = 3;
            this.lblpassword.Text = "PASSWORD";
            this.lblpassword.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtusername
            // 
            this.txtusername.Font = new System.Drawing.Font("Nirmala UI", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtusername.Location = new System.Drawing.Point(361, 232);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(188, 27);
            this.txtusername.TabIndex = 4;
            // 
            // txtpassword
            // 
            this.txtpassword.Font = new System.Drawing.Font("Nirmala UI", 9.818182F, System.Drawing.FontStyle.Bold);
            this.txtpassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtpassword.Location = new System.Drawing.Point(361, 280);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(188, 27);
            this.txtpassword.TabIndex = 5;
            // 
            // cmblogin
            // 
            this.cmblogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmblogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.163636F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmblogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmblogin.FormattingEnabled = true;
            this.cmblogin.Items.AddRange(new object[] {
            "Owner",
            "Seller"});
            this.cmblogin.Location = new System.Drawing.Point(361, 130);
            this.cmblogin.Name = "cmblogin";
            this.cmblogin.Size = new System.Drawing.Size(188, 25);
            this.cmblogin.TabIndex = 6;
            this.cmblogin.Text = "Select Roles";
            // 
            // btnsubmit
            // 
            this.btnsubmit.AllowDrop = true;
            this.btnsubmit.AutoEllipsis = true;
            this.btnsubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnsubmit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnsubmit.FlatAppearance.BorderSize = 2;
            this.btnsubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsubmit.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.163636F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsubmit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnsubmit.Location = new System.Drawing.Point(361, 327);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(76, 29);
            this.btnsubmit.TabIndex = 7;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.UseVisualStyleBackColor = false;
            // 
            // lblclear
            // 
            this.lblclear.AutoSize = true;
            this.lblclear.Font = new System.Drawing.Font("Raleway", 11.12727F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblclear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblclear.Location = new System.Drawing.Point(475, 326);
            this.lblclear.Name = "lblclear";
            this.lblclear.Size = new System.Drawing.Size(57, 24);
            this.lblclear.TabIndex = 8;
            this.lblclear.Text = "Clear";
            // 
            // lblcrosssign
            // 
            this.lblcrosssign.AllowDrop = true;
            this.lblcrosssign.AutoSize = true;
            this.lblcrosssign.Font = new System.Drawing.Font("Arial", 15.70909F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcrosssign.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblcrosssign.Location = new System.Drawing.Point(576, 0);
            this.lblcrosssign.Name = "lblcrosssign";
            this.lblcrosssign.Size = new System.Drawing.Size(24, 28);
            this.lblcrosssign.TabIndex = 9;
            this.lblcrosssign.Text = "x";
            this.lblcrosssign.Click += new System.EventHandler(this.lblcrosssign_Click);
            // 
            // LOGIN
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(607, 368);
            this.Controls.Add(this.lblcrosssign);
            this.Controls.Add(this.lblclear);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.cmblogin);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.lblloginheading);
            this.Controls.Add(this.pictureLogin);
            this.Name = "LOGIN";
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.LOGIN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureLogin;
        private System.Windows.Forms.Label lblloginheading;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.ComboBox cmblogin;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.Label lblclear;
        private System.Windows.Forms.Label lblcrosssign;
    }
}

