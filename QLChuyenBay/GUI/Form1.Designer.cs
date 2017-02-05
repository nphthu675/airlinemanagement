namespace QLChuyenBay
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
            this.BT_ThemSanBay = new System.Windows.Forms.Button();
            this.BT_ThemChuyenBay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BT_ThemSanBay
            // 
            this.BT_ThemSanBay.Location = new System.Drawing.Point(25, 22);
            this.BT_ThemSanBay.Name = "BT_ThemSanBay";
            this.BT_ThemSanBay.Size = new System.Drawing.Size(109, 23);
            this.BT_ThemSanBay.TabIndex = 0;
            this.BT_ThemSanBay.Text = "Thêm sân bay";
            this.BT_ThemSanBay.UseVisualStyleBackColor = true;
            this.BT_ThemSanBay.Click += new System.EventHandler(this.BT_ThemSanBay_Click);
            // 
            // BT_ThemChuyenBay
            // 
            this.BT_ThemChuyenBay.Location = new System.Drawing.Point(25, 52);
            this.BT_ThemChuyenBay.Name = "BT_ThemChuyenBay";
            this.BT_ThemChuyenBay.Size = new System.Drawing.Size(109, 23);
            this.BT_ThemChuyenBay.TabIndex = 1;
            this.BT_ThemChuyenBay.Text = "Thêm chuyến bay";
            this.BT_ThemChuyenBay.UseVisualStyleBackColor = true;
            this.BT_ThemChuyenBay.Click += new System.EventHandler(this.BT_ThemChuyenBay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 340);
            this.Controls.Add(this.BT_ThemChuyenBay);
            this.Controls.Add(this.BT_ThemSanBay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BT_ThemSanBay;
        private System.Windows.Forms.Button BT_ThemChuyenBay;
    }
}

