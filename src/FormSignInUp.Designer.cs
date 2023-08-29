
namespace YazılımMimarisiProjeV2
{
    partial class FormSignInUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSignInUp));
            this.picImgTemplate = new System.Windows.Forms.PictureBox();
            this.lblUnderline = new System.Windows.Forms.Label();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.picImgEarth = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picImgTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImgEarth)).BeginInit();
            this.SuspendLayout();
            // 
            // picImgTemplate
            // 
            this.picImgTemplate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.picImgTemplate.Image = ((System.Drawing.Image)(resources.GetObject("picImgTemplate.Image")));
            this.picImgTemplate.Location = new System.Drawing.Point(0, 400);
            this.picImgTemplate.Name = "picImgTemplate";
            this.picImgTemplate.Size = new System.Drawing.Size(500, 400);
            this.picImgTemplate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picImgTemplate.TabIndex = 1;
            this.picImgTemplate.TabStop = false;
            // 
            // lblUnderline
            // 
            this.lblUnderline.BackColor = System.Drawing.Color.Black;
            this.lblUnderline.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUnderline.ForeColor = System.Drawing.Color.White;
            this.lblUnderline.Location = new System.Drawing.Point(149, 786);
            this.lblUnderline.Name = "lblUnderline";
            this.lblUnderline.Size = new System.Drawing.Size(200, 5);
            this.lblUnderline.TabIndex = 3;
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignUp.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSignUp.FlatAppearance.BorderSize = 0;
            this.btnSignUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(104)))));
            this.btnSignUp.Location = new System.Drawing.Point(49, 649);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(400, 50);
            this.btnSignUp.TabIndex = 1;
            this.btnSignUp.Text = "Kayıt Ol";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(104)))));
            this.btnSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignIn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSignIn.FlatAppearance.BorderSize = 0;
            this.btnSignIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(54)))), ((int)(((byte)(109)))));
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIn.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.ForeColor = System.Drawing.Color.White;
            this.btnSignIn.Location = new System.Drawing.Point(49, 579);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(400, 50);
            this.btnSignIn.TabIndex = 0;
            this.btnSignIn.Text = "Giriş";
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // picImgEarth
            // 
            this.picImgEarth.Image = ((System.Drawing.Image)(resources.GetObject("picImgEarth.Image")));
            this.picImgEarth.Location = new System.Drawing.Point(184, 116);
            this.picImgEarth.Name = "picImgEarth";
            this.picImgEarth.Size = new System.Drawing.Size(150, 150);
            this.picImgEarth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImgEarth.TabIndex = 76;
            this.picImgEarth.TabStop = false;
            // 
            // FormSignInUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(500, 800);
            this.Controls.Add(this.picImgEarth);
            this.Controls.Add(this.lblUnderline);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.picImgTemplate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormSignInUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSignInUp";
            this.Load += new System.EventHandler(this.FormSignInUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImgTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImgEarth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picImgTemplate;
        private System.Windows.Forms.Label lblUnderline;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.PictureBox picImgEarth;
    }
}