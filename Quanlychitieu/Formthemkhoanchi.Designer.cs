namespace Quanlychitieu
{
    partial class Formthemkhoanchi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formthemkhoanchi));
            this.dtpngay = new System.Windows.Forms.DateTimePicker();
            this.btthemkhoanchi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbkhoanchi = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtghichu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsotien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btthemchitieu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btquaylai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpngay
            // 
            this.dtpngay.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpngay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpngay.Location = new System.Drawing.Point(165, 159);
            this.dtpngay.Name = "dtpngay";
            this.dtpngay.Size = new System.Drawing.Size(215, 29);
            this.dtpngay.TabIndex = 69;
            // 
            // btthemkhoanchi
            // 
            this.btthemkhoanchi.BackColor = System.Drawing.Color.Transparent;
            this.btthemkhoanchi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btthemkhoanchi.BackgroundImage")));
            this.btthemkhoanchi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btthemkhoanchi.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btthemkhoanchi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthemkhoanchi.ForeColor = System.Drawing.Color.Blue;
            this.btthemkhoanchi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btthemkhoanchi.ImageKey = "(none)";
            this.btthemkhoanchi.Location = new System.Drawing.Point(390, 80);
            this.btthemkhoanchi.Name = "btthemkhoanchi";
            this.btthemkhoanchi.Size = new System.Drawing.Size(30, 29);
            this.btthemkhoanchi.TabIndex = 68;
            this.btthemkhoanchi.UseVisualStyleBackColor = false;
            this.btthemkhoanchi.Click += new System.EventHandler(this.btthemkhoanchi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(93, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 26);
            this.label2.TabIndex = 67;
            this.label2.Text = "Ngày:";
            // 
            // cbkhoanchi
            // 
            this.cbkhoanchi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbkhoanchi.FormattingEnabled = true;
            this.cbkhoanchi.Location = new System.Drawing.Point(165, 80);
            this.cbkhoanchi.Name = "cbkhoanchi";
            this.cbkhoanchi.Size = new System.Drawing.Size(215, 29);
            this.cbkhoanchi.TabIndex = 66;
            this.cbkhoanchi.SelectedIndexChanged += new System.EventHandler(this.cbnoidungchi_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(386, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 19);
            this.label6.TabIndex = 65;
            this.label6.Text = "x1000 Đ";
            // 
            // txtghichu
            // 
            this.txtghichu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtghichu.Location = new System.Drawing.Point(165, 200);
            this.txtghichu.Multiline = true;
            this.txtghichu.Name = "txtghichu";
            this.txtghichu.Size = new System.Drawing.Size(318, 89);
            this.txtghichu.TabIndex = 64;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(65, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 26);
            this.label5.TabIndex = 63;
            this.label5.Text = "Ghi chú:";
            // 
            // txtsotien
            // 
            this.txtsotien.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsotien.Location = new System.Drawing.Point(165, 119);
            this.txtsotien.Name = "txtsotien";
            this.txtsotien.Size = new System.Drawing.Size(215, 29);
            this.txtsotien.TabIndex = 62;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(70, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 26);
            this.label4.TabIndex = 61;
            this.label4.Text = "Số Tiền:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 26);
            this.label3.TabIndex = 59;
            this.label3.Text = "Chi Tiêu Cho:";
            // 
            // btthemchitieu
            // 
            this.btthemchitieu.BackColor = System.Drawing.Color.Transparent;
            this.btthemchitieu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btthemchitieu.BackgroundImage")));
            this.btthemchitieu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btthemchitieu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btthemchitieu.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthemchitieu.ForeColor = System.Drawing.Color.Blue;
            this.btthemchitieu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btthemchitieu.ImageKey = "(none)";
            this.btthemchitieu.Location = new System.Drawing.Point(196, 306);
            this.btthemchitieu.Name = "btthemchitieu";
            this.btthemchitieu.Size = new System.Drawing.Size(135, 35);
            this.btthemchitieu.TabIndex = 60;
            this.btthemchitieu.UseVisualStyleBackColor = false;
            this.btthemchitieu.Click += new System.EventHandler(this.btthemchitieu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(30, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 32);
            this.label1.TabIndex = 58;
            this.label1.Text = "NHẬP THÔNG TIN CHI TIÊU";
            // 
            // btquaylai
            // 
            this.btquaylai.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btquaylai.BackgroundImage")));
            this.btquaylai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btquaylai.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btquaylai.Location = new System.Drawing.Point(434, 2);
            this.btquaylai.Name = "btquaylai";
            this.btquaylai.Size = new System.Drawing.Size(54, 41);
            this.btquaylai.TabIndex = 83;
            this.btquaylai.UseVisualStyleBackColor = true;
            this.btquaylai.Click += new System.EventHandler(this.btquaylai_Click);
            // 
            // Formthemkhoanchi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(491, 353);
            this.Controls.Add(this.btquaylai);
            this.Controls.Add(this.dtpngay);
            this.Controls.Add(this.btthemkhoanchi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbkhoanchi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtghichu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtsotien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btthemchitieu);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Formthemkhoanchi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm khoản chi";
            this.Load += new System.EventHandler(this.Formthemkhoanchi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpngay;
        private System.Windows.Forms.Button btthemkhoanchi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbkhoanchi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtghichu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsotien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btthemchitieu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btquaylai;
    }
}