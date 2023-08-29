
namespace YazılımMimarisiProjeV2.FormReservasionsFolder
{
    partial class CampReservasions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CampReservasions));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvReservasions = new System.Windows.Forms.DataGridView();
            this.btnHtmlReport = new System.Windows.Forms.Button();
            this.btnJsonReport = new System.Windows.Forms.Button();
            this.btnXmlReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservasions)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.Control;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(22, 341);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(55, 55);
            this.btnBack.TabIndex = 4;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDelete.FlatAppearance.BorderSize = 2;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.btnDelete.Location = new System.Drawing.Point(1039, 341);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(217, 49);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "İPTAL ET";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvReservasions
            // 
            this.dgvReservasions.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvReservasions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReservasions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReservasions.ColumnHeadersHeight = 30;
            this.dgvReservasions.EnableHeadersVisualStyles = false;
            this.dgvReservasions.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(49)))));
            this.dgvReservasions.Location = new System.Drawing.Point(72, 20);
            this.dgvReservasions.Name = "dgvReservasions";
            this.dgvReservasions.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(231)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(190)))), ((int)(((byte)(182)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvReservasions.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReservasions.RowTemplate.Height = 24;
            this.dgvReservasions.Size = new System.Drawing.Size(1138, 293);
            this.dgvReservasions.TabIndex = 5;
            // 
            // btnHtmlReport
            // 
            this.btnHtmlReport.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnHtmlReport.FlatAppearance.BorderSize = 2;
            this.btnHtmlReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnHtmlReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHtmlReport.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.btnHtmlReport.Location = new System.Drawing.Point(649, 341);
            this.btnHtmlReport.Name = "btnHtmlReport";
            this.btnHtmlReport.Size = new System.Drawing.Size(217, 49);
            this.btnHtmlReport.TabIndex = 2;
            this.btnHtmlReport.Text = "HTML RAPOR";
            this.btnHtmlReport.UseVisualStyleBackColor = true;
            this.btnHtmlReport.Click += new System.EventHandler(this.btnHtmlReport_Click);
            // 
            // btnJsonReport
            // 
            this.btnJsonReport.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnJsonReport.FlatAppearance.BorderSize = 2;
            this.btnJsonReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnJsonReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJsonReport.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.btnJsonReport.Location = new System.Drawing.Point(426, 341);
            this.btnJsonReport.Name = "btnJsonReport";
            this.btnJsonReport.Size = new System.Drawing.Size(217, 49);
            this.btnJsonReport.TabIndex = 1;
            this.btnJsonReport.Text = "JSON RAPOR";
            this.btnJsonReport.UseVisualStyleBackColor = true;
            this.btnJsonReport.Click += new System.EventHandler(this.btnJsonReport_Click);
            // 
            // btnXmlReport
            // 
            this.btnXmlReport.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnXmlReport.FlatAppearance.BorderSize = 2;
            this.btnXmlReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnXmlReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXmlReport.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.btnXmlReport.Location = new System.Drawing.Point(203, 341);
            this.btnXmlReport.Name = "btnXmlReport";
            this.btnXmlReport.Size = new System.Drawing.Size(217, 49);
            this.btnXmlReport.TabIndex = 0;
            this.btnXmlReport.Text = "XML RAPOR";
            this.btnXmlReport.UseVisualStyleBackColor = true;
            this.btnXmlReport.Click += new System.EventHandler(this.btnXmlReport_Click);
            // 
            // CampReservasions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 446);
            this.ControlBox = false;
            this.Controls.Add(this.btnHtmlReport);
            this.Controls.Add(this.btnJsonReport);
            this.Controls.Add(this.btnXmlReport);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvReservasions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CampReservasions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CampReservasions";
            this.Load += new System.EventHandler(this.CampReservasions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservasions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvReservasions;
        private System.Windows.Forms.Button btnHtmlReport;
        private System.Windows.Forms.Button btnJsonReport;
        private System.Windows.Forms.Button btnXmlReport;
    }
}