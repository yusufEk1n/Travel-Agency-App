
namespace YazılımMimarisiProjeV2
{
    partial class FormRezCamp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRezCamp));
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.picCampIcon = new System.Windows.Forms.PictureBox();
            this.lblRoomPersonCount = new System.Windows.Forms.Label();
            this.txtPersonCount = new System.Windows.Forms.TextBox();
            this.lblCampTypeHead = new System.Windows.Forms.Label();
            this.lblTentCamp = new System.Windows.Forms.Label();
            this.lblFixCamp = new System.Windows.Forms.Label();
            this.lblStick5 = new System.Windows.Forms.Label();
            this.lblStick1 = new System.Windows.Forms.Label();
            this.lblStick2 = new System.Windows.Forms.Label();
            this.lblStick4 = new System.Windows.Forms.Label();
            this.lblStick3 = new System.Windows.Forms.Label();
            this.lblStickTent = new System.Windows.Forms.Label();
            this.lblStickFix = new System.Windows.Forms.Label();
            this.dateCheckOut = new System.Windows.Forms.DateTimePicker();
            this.lblCheckOutDate = new System.Windows.Forms.Label();
            this.dateCheckIn = new System.Windows.Forms.DateTimePicker();
            this.lblCheckInDate = new System.Windows.Forms.Label();
            this.picTentIcon = new System.Windows.Forms.PictureBox();
            this.picHouseIcon = new System.Windows.Forms.PictureBox();
            this.picTrueTentCamp = new System.Windows.Forms.PictureBox();
            this.picTrueFixCamp = new System.Windows.Forms.PictureBox();
            this.lblCheckPersonCount = new System.Windows.Forms.Label();
            this.lblCheckCampType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCampIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTentIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHouseIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTrueTentCamp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTrueFixCamp)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.LightCyan;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(40, 685);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(55, 55);
            this.btnBack.TabIndex = 172;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.LightCyan;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan;
            this.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.Location = new System.Drawing.Point(538, 685);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(55, 55);
            this.btnNext.TabIndex = 171;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // picCampIcon
            // 
            this.picCampIcon.Image = ((System.Drawing.Image)(resources.GetObject("picCampIcon.Image")));
            this.picCampIcon.Location = new System.Drawing.Point(244, 18);
            this.picCampIcon.Name = "picCampIcon";
            this.picCampIcon.Size = new System.Drawing.Size(150, 150);
            this.picCampIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCampIcon.TabIndex = 170;
            this.picCampIcon.TabStop = false;
            // 
            // lblRoomPersonCount
            // 
            this.lblRoomPersonCount.AutoSize = true;
            this.lblRoomPersonCount.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRoomPersonCount.ForeColor = System.Drawing.Color.Black;
            this.lblRoomPersonCount.Location = new System.Drawing.Point(255, 190);
            this.lblRoomPersonCount.Name = "lblRoomPersonCount";
            this.lblRoomPersonCount.Size = new System.Drawing.Size(139, 26);
            this.lblRoomPersonCount.TabIndex = 165;
            this.lblRoomPersonCount.Text = "Oda Kişi Sayısı";
            // 
            // txtPersonCount
            // 
            this.txtPersonCount.BackColor = System.Drawing.Color.LightCyan;
            this.txtPersonCount.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPersonCount.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPersonCount.Location = new System.Drawing.Point(184, 224);
            this.txtPersonCount.MaxLength = 25;
            this.txtPersonCount.Multiline = true;
            this.txtPersonCount.Name = "txtPersonCount";
            this.txtPersonCount.Size = new System.Drawing.Size(292, 40);
            this.txtPersonCount.TabIndex = 1;
            this.txtPersonCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPersonCount_KeyPress);
            // 
            // lblCampTypeHead
            // 
            this.lblCampTypeHead.AutoSize = true;
            this.lblCampTypeHead.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCampTypeHead.ForeColor = System.Drawing.Color.Black;
            this.lblCampTypeHead.Location = new System.Drawing.Point(278, 291);
            this.lblCampTypeHead.Name = "lblCampTypeHead";
            this.lblCampTypeHead.Size = new System.Drawing.Size(107, 26);
            this.lblCampTypeHead.TabIndex = 173;
            this.lblCampTypeHead.Text = "Kamp Türü";
            // 
            // lblTentCamp
            // 
            this.lblTentCamp.AutoSize = true;
            this.lblTentCamp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTentCamp.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTentCamp.ForeColor = System.Drawing.Color.Black;
            this.lblTentCamp.Location = new System.Drawing.Point(210, 394);
            this.lblTentCamp.Name = "lblTentCamp";
            this.lblTentCamp.Size = new System.Drawing.Size(110, 26);
            this.lblTentCamp.TabIndex = 3;
            this.lblTentCamp.Text = "Çadır Kamp";
            this.lblTentCamp.Click += new System.EventHandler(this.lblTentCamp_Click);
            this.lblTentCamp.MouseLeave += new System.EventHandler(this.lblTentCamp_MouseLeave);
            this.lblTentCamp.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblTentCamp_MouseMove);
            // 
            // lblFixCamp
            // 
            this.lblFixCamp.AutoSize = true;
            this.lblFixCamp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFixCamp.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFixCamp.ForeColor = System.Drawing.Color.Black;
            this.lblFixCamp.Location = new System.Drawing.Point(349, 394);
            this.lblFixCamp.Name = "lblFixCamp";
            this.lblFixCamp.Size = new System.Drawing.Size(111, 26);
            this.lblFixCamp.TabIndex = 4;
            this.lblFixCamp.Text = "Sabit Kamp";
            this.lblFixCamp.Click += new System.EventHandler(this.lblFixCamp_Click);
            this.lblFixCamp.MouseLeave += new System.EventHandler(this.lblFixCamp_MouseLeave);
            this.lblFixCamp.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblFixCamp_MouseMove);
            // 
            // lblStick5
            // 
            this.lblStick5.BackColor = System.Drawing.Color.Black;
            this.lblStick5.Location = new System.Drawing.Point(141, 302);
            this.lblStick5.Name = "lblStick5";
            this.lblStick5.Size = new System.Drawing.Size(130, 2);
            this.lblStick5.TabIndex = 178;
            this.lblStick5.Text = "label4";
            // 
            // lblStick1
            // 
            this.lblStick1.BackColor = System.Drawing.Color.Black;
            this.lblStick1.Location = new System.Drawing.Point(390, 302);
            this.lblStick1.Name = "lblStick1";
            this.lblStick1.Size = new System.Drawing.Size(130, 2);
            this.lblStick1.TabIndex = 179;
            this.lblStick1.Text = "label5";
            // 
            // lblStick2
            // 
            this.lblStick2.BackColor = System.Drawing.Color.Black;
            this.lblStick2.Location = new System.Drawing.Point(520, 302);
            this.lblStick2.Name = "lblStick2";
            this.lblStick2.Size = new System.Drawing.Size(2, 150);
            this.lblStick2.TabIndex = 180;
            this.lblStick2.Text = "label6";
            // 
            // lblStick4
            // 
            this.lblStick4.BackColor = System.Drawing.Color.Black;
            this.lblStick4.Location = new System.Drawing.Point(141, 302);
            this.lblStick4.Name = "lblStick4";
            this.lblStick4.Size = new System.Drawing.Size(2, 150);
            this.lblStick4.TabIndex = 181;
            this.lblStick4.Text = "label7";
            // 
            // lblStick3
            // 
            this.lblStick3.BackColor = System.Drawing.Color.Black;
            this.lblStick3.Location = new System.Drawing.Point(143, 450);
            this.lblStick3.Name = "lblStick3";
            this.lblStick3.Size = new System.Drawing.Size(377, 2);
            this.lblStick3.TabIndex = 182;
            this.lblStick3.Text = "label8";
            // 
            // lblStickTent
            // 
            this.lblStickTent.BackColor = System.Drawing.Color.Blue;
            this.lblStickTent.Location = new System.Drawing.Point(209, 420);
            this.lblStickTent.Name = "lblStickTent";
            this.lblStickTent.Size = new System.Drawing.Size(110, 2);
            this.lblStickTent.TabIndex = 183;
            this.lblStickTent.Text = "label9";
            this.lblStickTent.Visible = false;
            // 
            // lblStickFix
            // 
            this.lblStickFix.BackColor = System.Drawing.Color.Blue;
            this.lblStickFix.Location = new System.Drawing.Point(351, 420);
            this.lblStickFix.Name = "lblStickFix";
            this.lblStickFix.Size = new System.Drawing.Size(110, 2);
            this.lblStickFix.TabIndex = 184;
            this.lblStickFix.Text = "label10";
            this.lblStickFix.Visible = false;
            // 
            // dateCheckOut
            // 
            this.dateCheckOut.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dateCheckOut.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateCheckOut.Location = new System.Drawing.Point(332, 530);
            this.dateCheckOut.Name = "dateCheckOut";
            this.dateCheckOut.Size = new System.Drawing.Size(261, 28);
            this.dateCheckOut.TabIndex = 6;
            // 
            // lblCheckOutDate
            // 
            this.lblCheckOutDate.AutoSize = true;
            this.lblCheckOutDate.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCheckOutDate.ForeColor = System.Drawing.Color.Black;
            this.lblCheckOutDate.Location = new System.Drawing.Point(399, 492);
            this.lblCheckOutDate.Name = "lblCheckOutDate";
            this.lblCheckOutDate.Size = new System.Drawing.Size(121, 26);
            this.lblCheckOutDate.TabIndex = 187;
            this.lblCheckOutDate.Text = "Dönüş Tarihi";
            // 
            // dateCheckIn
            // 
            this.dateCheckIn.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dateCheckIn.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateCheckIn.Location = new System.Drawing.Point(40, 530);
            this.dateCheckIn.Name = "dateCheckIn";
            this.dateCheckIn.Size = new System.Drawing.Size(261, 28);
            this.dateCheckIn.TabIndex = 5;
            // 
            // lblCheckInDate
            // 
            this.lblCheckInDate.AutoSize = true;
            this.lblCheckInDate.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCheckInDate.ForeColor = System.Drawing.Color.Black;
            this.lblCheckInDate.Location = new System.Drawing.Point(111, 492);
            this.lblCheckInDate.Name = "lblCheckInDate";
            this.lblCheckInDate.Size = new System.Drawing.Size(109, 26);
            this.lblCheckInDate.TabIndex = 185;
            this.lblCheckInDate.Text = "Gidiş Tarihi";
            // 
            // picTentIcon
            // 
            this.picTentIcon.Image = ((System.Drawing.Image)(resources.GetObject("picTentIcon.Image")));
            this.picTentIcon.Location = new System.Drawing.Point(237, 334);
            this.picTentIcon.Name = "picTentIcon";
            this.picTentIcon.Size = new System.Drawing.Size(50, 50);
            this.picTentIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTentIcon.TabIndex = 189;
            this.picTentIcon.TabStop = false;
            // 
            // picHouseIcon
            // 
            this.picHouseIcon.Image = ((System.Drawing.Image)(resources.GetObject("picHouseIcon.Image")));
            this.picHouseIcon.Location = new System.Drawing.Point(377, 334);
            this.picHouseIcon.Name = "picHouseIcon";
            this.picHouseIcon.Size = new System.Drawing.Size(50, 50);
            this.picHouseIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHouseIcon.TabIndex = 190;
            this.picHouseIcon.TabStop = false;
            // 
            // picTrueTentCamp
            // 
            this.picTrueTentCamp.Image = ((System.Drawing.Image)(resources.GetObject("picTrueTentCamp.Image")));
            this.picTrueTentCamp.Location = new System.Drawing.Point(253, 426);
            this.picTrueTentCamp.Name = "picTrueTentCamp";
            this.picTrueTentCamp.Size = new System.Drawing.Size(20, 20);
            this.picTrueTentCamp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTrueTentCamp.TabIndex = 191;
            this.picTrueTentCamp.TabStop = false;
            this.picTrueTentCamp.Visible = false;
            // 
            // picTrueFixCamp
            // 
            this.picTrueFixCamp.Image = ((System.Drawing.Image)(resources.GetObject("picTrueFixCamp.Image")));
            this.picTrueFixCamp.Location = new System.Drawing.Point(397, 425);
            this.picTrueFixCamp.Name = "picTrueFixCamp";
            this.picTrueFixCamp.Size = new System.Drawing.Size(20, 20);
            this.picTrueFixCamp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTrueFixCamp.TabIndex = 192;
            this.picTrueFixCamp.TabStop = false;
            this.picTrueFixCamp.Visible = false;
            // 
            // lblCheckPersonCount
            // 
            this.lblCheckPersonCount.AutoSize = true;
            this.lblCheckPersonCount.BackColor = System.Drawing.Color.LightCyan;
            this.lblCheckPersonCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblCheckPersonCount.ForeColor = System.Drawing.Color.Red;
            this.lblCheckPersonCount.Location = new System.Drawing.Point(484, 236);
            this.lblCheckPersonCount.Name = "lblCheckPersonCount";
            this.lblCheckPersonCount.Size = new System.Drawing.Size(0, 18);
            this.lblCheckPersonCount.TabIndex = 193;
            // 
            // lblCheckCampType
            // 
            this.lblCheckCampType.AutoSize = true;
            this.lblCheckCampType.BackColor = System.Drawing.Color.LightCyan;
            this.lblCheckCampType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblCheckCampType.ForeColor = System.Drawing.Color.Red;
            this.lblCheckCampType.Location = new System.Drawing.Point(532, 370);
            this.lblCheckCampType.Name = "lblCheckCampType";
            this.lblCheckCampType.Size = new System.Drawing.Size(0, 18);
            this.lblCheckCampType.TabIndex = 194;
            // 
            // FormRezCamp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(639, 783);
            this.ControlBox = false;
            this.Controls.Add(this.lblCheckCampType);
            this.Controls.Add(this.lblCheckPersonCount);
            this.Controls.Add(this.picTrueFixCamp);
            this.Controls.Add(this.picTrueTentCamp);
            this.Controls.Add(this.dateCheckOut);
            this.Controls.Add(this.lblCheckOutDate);
            this.Controls.Add(this.dateCheckIn);
            this.Controls.Add(this.lblCheckInDate);
            this.Controls.Add(this.lblStickFix);
            this.Controls.Add(this.lblStickTent);
            this.Controls.Add(this.lblStick3);
            this.Controls.Add(this.lblStick4);
            this.Controls.Add(this.lblStick2);
            this.Controls.Add(this.lblStick1);
            this.Controls.Add(this.lblStick5);
            this.Controls.Add(this.lblFixCamp);
            this.Controls.Add(this.lblTentCamp);
            this.Controls.Add(this.lblCampTypeHead);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.picCampIcon);
            this.Controls.Add(this.lblRoomPersonCount);
            this.Controls.Add(this.txtPersonCount);
            this.Controls.Add(this.picTentIcon);
            this.Controls.Add(this.picHouseIcon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormRezCamp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRezCamp";
            ((System.ComponentModel.ISupportInitialize)(this.picCampIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTentIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHouseIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTrueTentCamp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTrueFixCamp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.PictureBox picCampIcon;
        private System.Windows.Forms.Label lblRoomPersonCount;
        private System.Windows.Forms.TextBox txtPersonCount;
        private System.Windows.Forms.Label lblCampTypeHead;
        private System.Windows.Forms.Label lblTentCamp;
        private System.Windows.Forms.Label lblFixCamp;
        private System.Windows.Forms.Label lblStick5;
        private System.Windows.Forms.Label lblStick1;
        private System.Windows.Forms.Label lblStick2;
        private System.Windows.Forms.Label lblStick4;
        private System.Windows.Forms.Label lblStick3;
        private System.Windows.Forms.Label lblStickTent;
        private System.Windows.Forms.Label lblStickFix;
        private System.Windows.Forms.DateTimePicker dateCheckOut;
        private System.Windows.Forms.Label lblCheckOutDate;
        private System.Windows.Forms.DateTimePicker dateCheckIn;
        private System.Windows.Forms.Label lblCheckInDate;
        private System.Windows.Forms.PictureBox picTentIcon;
        private System.Windows.Forms.PictureBox picHouseIcon;
        private System.Windows.Forms.PictureBox picTrueTentCamp;
        private System.Windows.Forms.PictureBox picTrueFixCamp;
        private System.Windows.Forms.Label lblCheckPersonCount;
        private System.Windows.Forms.Label lblCheckCampType;
    }
}