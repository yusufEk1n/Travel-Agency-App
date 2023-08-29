
namespace YazılımMimarisiProjeV2
{
    partial class FormSignIn
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
            System.Environment.Exit(0);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSignIn));
            this.lblCheckPassword = new System.Windows.Forms.Label();
            this.lblCheckUserName = new System.Windows.Forms.Label();
            this.lblUnderline = new System.Windows.Forms.Label();
            this.picPasswordIcon = new System.Windows.Forms.PictureBox();
            this.picUserNameIcon = new System.Windows.Forms.PictureBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext2 = new System.Windows.Forms.Button();
            this.picImgTemplate = new System.Windows.Forms.PictureBox();
            this.btnNext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picPasswordIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUserNameIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImgTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCheckPassword
            // 
            this.lblCheckPassword.AutoSize = true;
            this.lblCheckPassword.BackColor = System.Drawing.Color.White;
            this.lblCheckPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblCheckPassword.ForeColor = System.Drawing.Color.Red;
            this.lblCheckPassword.Location = new System.Drawing.Point(442, 469);
            this.lblCheckPassword.Name = "lblCheckPassword";
            this.lblCheckPassword.Size = new System.Drawing.Size(0, 18);
            this.lblCheckPassword.TabIndex = 131;
            // 
            // lblCheckUserName
            // 
            this.lblCheckUserName.AutoSize = true;
            this.lblCheckUserName.BackColor = System.Drawing.Color.White;
            this.lblCheckUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCheckUserName.ForeColor = System.Drawing.Color.Red;
            this.lblCheckUserName.Location = new System.Drawing.Point(442, 375);
            this.lblCheckUserName.Name = "lblCheckUserName";
            this.lblCheckUserName.Size = new System.Drawing.Size(0, 18);
            this.lblCheckUserName.TabIndex = 130;
            // 
            // lblUnderline
            // 
            this.lblUnderline.BackColor = System.Drawing.Color.Black;
            this.lblUnderline.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUnderline.ForeColor = System.Drawing.Color.White;
            this.lblUnderline.Location = new System.Drawing.Point(149, 786);
            this.lblUnderline.Name = "lblUnderline";
            this.lblUnderline.Size = new System.Drawing.Size(200, 5);
            this.lblUnderline.TabIndex = 129;
            // 
            // picPasswordIcon
            // 
            this.picPasswordIcon.BackColor = System.Drawing.Color.White;
            this.picPasswordIcon.Image = ((System.Drawing.Image)(resources.GetObject("picPasswordIcon.Image")));
            this.picPasswordIcon.Location = new System.Drawing.Point(404, 464);
            this.picPasswordIcon.Name = "picPasswordIcon";
            this.picPasswordIcon.Size = new System.Drawing.Size(20, 20);
            this.picPasswordIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPasswordIcon.TabIndex = 125;
            this.picPasswordIcon.TabStop = false;
            // 
            // picUserNameIcon
            // 
            this.picUserNameIcon.BackColor = System.Drawing.Color.White;
            this.picUserNameIcon.Image = ((System.Drawing.Image)(resources.GetObject("picUserNameIcon.Image")));
            this.picUserNameIcon.Location = new System.Drawing.Point(404, 370);
            this.picUserNameIcon.Name = "picUserNameIcon";
            this.picUserNameIcon.Size = new System.Drawing.Size(20, 20);
            this.picUserNameIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picUserNameIcon.TabIndex = 124;
            this.picUserNameIcon.TabStop = false;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.White;
            this.lblPassword.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lblPassword.Location = new System.Drawing.Point(65, 422);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(58, 26);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Şifre";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPassword.Location = new System.Drawing.Point(69, 456);
            this.txtPassword.MaxLength = 6;
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(366, 40);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.White;
            this.lblUserName.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lblUserName.Location = new System.Drawing.Point(65, 328);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(116, 26);
            this.lblUserName.TabIndex = 5;
            this.lblUserName.Text = "Kullanıcı Adı";
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.White;
            this.txtUserName.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtUserName.Location = new System.Drawing.Point(69, 362);
            this.txtUserName.MaxLength = 20;
            this.txtUserName.Multiline = true;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(366, 40);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserName_KeyPress);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.LightCyan;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(22, 746);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(30, 30);
            this.btnBack.TabIndex = 4;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnBack_MouseMove);
            // 
            // btnNext2
            // 
            this.btnNext2.BackColor = System.Drawing.Color.White;
            this.btnNext2.FlatAppearance.BorderSize = 0;
            this.btnNext2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext2.Image = ((System.Drawing.Image)(resources.GetObject("btnNext2.Image")));
            this.btnNext2.Location = new System.Drawing.Point(218, 539);
            this.btnNext2.Name = "btnNext2";
            this.btnNext2.Size = new System.Drawing.Size(65, 65);
            this.btnNext2.TabIndex = 4;
            this.btnNext2.UseVisualStyleBackColor = false;
            this.btnNext2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnNext2_MouseMove);
            // 
            // picImgTemplate
            // 
            this.picImgTemplate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picImgTemplate.Enabled = false;
            this.picImgTemplate.Image = ((System.Drawing.Image)(resources.GetObject("picImgTemplate.Image")));
            this.picImgTemplate.Location = new System.Drawing.Point(0, 0);
            this.picImgTemplate.Name = "picImgTemplate";
            this.picImgTemplate.Size = new System.Drawing.Size(500, 800);
            this.picImgTemplate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImgTemplate.TabIndex = 119;
            this.picImgTemplate.TabStop = false;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.White;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.Location = new System.Drawing.Point(218, 539);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(65, 65);
            this.btnNext.TabIndex = 3;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            this.btnNext.MouseLeave += new System.EventHandler(this.btnNext_MouseLeave);
            this.btnNext.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnNext_MouseMove);
            // 
            // FormSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(500, 800);
            this.Controls.Add(this.lblCheckPassword);
            this.Controls.Add(this.lblCheckUserName);
            this.Controls.Add(this.lblUnderline);
            this.Controls.Add(this.picPasswordIcon);
            this.Controls.Add(this.picUserNameIcon);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNext2);
            this.Controls.Add(this.picImgTemplate);
            this.Controls.Add(this.btnNext);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormSignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSignIn";
            ((System.ComponentModel.ISupportInitialize)(this.picPasswordIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUserNameIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImgTemplate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCheckPassword;
        private System.Windows.Forms.Label lblCheckUserName;
        private System.Windows.Forms.Label lblUnderline;
        private System.Windows.Forms.PictureBox picPasswordIcon;
        private System.Windows.Forms.PictureBox picUserNameIcon;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext2;
        private System.Windows.Forms.PictureBox picImgTemplate;
        private System.Windows.Forms.Button btnNext;
    }
}