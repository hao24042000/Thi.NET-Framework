namespace Quanlychitieu
{
    partial class Formthemnoidungthu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formthemnoidungthu));
            this.txttennoidung = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btthemnoidungthu = new System.Windows.Forms.Button();
            this.btquaylai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txttennoidung
            // 
            this.txttennoidung.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttennoidung.Location = new System.Drawing.Point(58, 61);
            this.txttennoidung.Name = "txttennoidung";
            this.txttennoidung.Size = new System.Drawing.Size(307, 35);
            this.txttennoidung.TabIndex = 83;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(11, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 26);
            this.label2.TabIndex = 81;
            this.label2.Text = "Tên nội dung thu nhập:";
            // 
            // btthemnoidungthu
            // 
            this.btthemnoidungthu.BackColor = System.Drawing.Color.Transparent;
            this.btthemnoidungthu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btthemnoidungthu.BackgroundImage")));
            this.btthemnoidungthu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btthemnoidungthu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btthemnoidungthu.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthemnoidungthu.ForeColor = System.Drawing.Color.Blue;
            this.btthemnoidungthu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btthemnoidungthu.ImageKey = "(none)";
            this.btthemnoidungthu.Location = new System.Drawing.Point(135, 114);
            this.btthemnoidungthu.Name = "btthemnoidungthu";
            this.btthemnoidungthu.Size = new System.Drawing.Size(125, 35);
            this.btthemnoidungthu.TabIndex = 80;
            this.btthemnoidungthu.UseVisualStyleBackColor = false;
            this.btthemnoidungthu.Click += new System.EventHandler(this.btthemnoidungthu_Click);
            // 
            // btquaylai
            // 
            this.btquaylai.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btquaylai.BackgroundImage")));
            this.btquaylai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btquaylai.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btquaylai.Location = new System.Drawing.Point(354, 3);
            this.btquaylai.Name = "btquaylai";
            this.btquaylai.Size = new System.Drawing.Size(47, 41);
            this.btquaylai.TabIndex = 86;
            this.btquaylai.UseVisualStyleBackColor = true;
            this.btquaylai.Click += new System.EventHandler(this.btquaylai_Click);
            // 
            // Formthemnoidungthu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(404, 163);
            this.Controls.Add(this.btquaylai);
            this.Controls.Add(this.txttennoidung);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btthemnoidungthu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Formthemnoidungthu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm nội dung thu";
            this.Load += new System.EventHandler(this.Formthemnoidungthu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txttennoidung;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btthemnoidungthu;
        private System.Windows.Forms.Button btquaylai;
    }
}