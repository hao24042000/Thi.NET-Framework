﻿namespace Quanlychitieu
{
    partial class Formxoachitieu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formxoachitieu));
            this.cbmachi = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbkhoanchi = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btxoakhoanthu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btquaylai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbmachi
            // 
            this.cbmachi.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbmachi.FormattingEnabled = true;
            this.cbmachi.Location = new System.Drawing.Point(174, 114);
            this.cbmachi.Name = "cbmachi";
            this.cbmachi.Size = new System.Drawing.Size(225, 35);
            this.cbmachi.TabIndex = 89;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(17, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 26);
            this.label2.TabIndex = 86;
            this.label2.Text = "Mã khoản chi:";
            // 
            // cbkhoanchi
            // 
            this.cbkhoanchi.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbkhoanchi.FormattingEnabled = true;
            this.cbkhoanchi.Location = new System.Drawing.Point(174, 69);
            this.cbkhoanchi.Name = "cbkhoanchi";
            this.cbkhoanchi.Size = new System.Drawing.Size(225, 35);
            this.cbkhoanchi.TabIndex = 90;
            this.cbkhoanchi.SelectedIndexChanged += new System.EventHandler(this.cbkhoanchi_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 26);
            this.label3.TabIndex = 87;
            this.label3.Text = "Tên khoản chi:";
            // 
            // btxoakhoanthu
            // 
            this.btxoakhoanthu.BackColor = System.Drawing.Color.Transparent;
            this.btxoakhoanthu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btxoakhoanthu.BackgroundImage")));
            this.btxoakhoanthu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btxoakhoanthu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btxoakhoanthu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btxoakhoanthu.ForeColor = System.Drawing.Color.Blue;
            this.btxoakhoanthu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btxoakhoanthu.ImageKey = "(none)";
            this.btxoakhoanthu.Location = new System.Drawing.Point(154, 178);
            this.btxoakhoanthu.Name = "btxoakhoanthu";
            this.btxoakhoanthu.Size = new System.Drawing.Size(148, 47);
            this.btxoakhoanthu.TabIndex = 88;
            this.btxoakhoanthu.UseVisualStyleBackColor = false;
            this.btxoakhoanthu.Click += new System.EventHandler(this.btxoakhoanthu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(32, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 26);
            this.label1.TabIndex = 85;
            this.label1.Text = "XÓA THÔNG TIN CHI TIÊU";
            // 
            // btquaylai
            // 
            this.btquaylai.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btquaylai.BackgroundImage")));
            this.btquaylai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btquaylai.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btquaylai.Location = new System.Drawing.Point(365, 5);
            this.btquaylai.Name = "btquaylai";
            this.btquaylai.Size = new System.Drawing.Size(49, 39);
            this.btquaylai.TabIndex = 91;
            this.btquaylai.UseVisualStyleBackColor = true;
            this.btquaylai.Click += new System.EventHandler(this.btquaylai_Click);
            // 
            // Formxoachitieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(419, 237);
            this.Controls.Add(this.btquaylai);
            this.Controls.Add(this.cbmachi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbkhoanchi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btxoakhoanthu);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Formxoachitieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xóa chi tiêu";
            this.Load += new System.EventHandler(this.Formxoachitieu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbmachi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbkhoanchi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btxoakhoanthu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btquaylai;
    }
}