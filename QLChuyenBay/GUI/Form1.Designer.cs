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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BT_ThemSanBay
            // 
            this.BT_ThemSanBay.Location = new System.Drawing.Point(6, 27);
            this.BT_ThemSanBay.Name = "BT_ThemSanBay";
            this.BT_ThemSanBay.Size = new System.Drawing.Size(109, 23);
            this.BT_ThemSanBay.TabIndex = 0;
            this.BT_ThemSanBay.Text = "Airport";
            this.BT_ThemSanBay.UseVisualStyleBackColor = true;
            this.BT_ThemSanBay.Click += new System.EventHandler(this.BT_ThemSanBay_Click);
            // 
            // BT_ThemChuyenBay
            // 
            this.BT_ThemChuyenBay.Location = new System.Drawing.Point(6, 57);
            this.BT_ThemChuyenBay.Name = "BT_ThemChuyenBay";
            this.BT_ThemChuyenBay.Size = new System.Drawing.Size(109, 23);
            this.BT_ThemChuyenBay.TabIndex = 1;
            this.BT_ThemChuyenBay.Text = "Flight";
            this.BT_ThemChuyenBay.UseVisualStyleBackColor = true;
            this.BT_ThemChuyenBay.Click += new System.EventHandler(this.BT_ThemChuyenBay_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BT_ThemChuyenBay);
            this.groupBox1.Controls.Add(this.BT_ThemSanBay);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(123, 89);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Admin";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(164, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(141, 89);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Customer";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 117);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Phong Thu Airlines";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BT_ThemSanBay;
        private System.Windows.Forms.Button BT_ThemChuyenBay;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
    }
}

