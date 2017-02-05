namespace QLChuyenBay.GUI
{
    partial class AddFlight
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
            this.CB_From = new System.Windows.Forms.ComboBox();
            this.CB_To = new System.Windows.Forms.ComboBox();
            this.DTP_Date = new System.Windows.Forms.DateTimePicker();
            this.TXT_Time = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BT_Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CB_From
            // 
            this.CB_From.FormattingEnabled = true;
            this.CB_From.Location = new System.Drawing.Point(47, 13);
            this.CB_From.Name = "CB_From";
            this.CB_From.Size = new System.Drawing.Size(199, 21);
            this.CB_From.TabIndex = 0;
            // 
            // CB_To
            // 
            this.CB_To.FormattingEnabled = true;
            this.CB_To.Location = new System.Drawing.Point(47, 41);
            this.CB_To.Name = "CB_To";
            this.CB_To.Size = new System.Drawing.Size(199, 21);
            this.CB_To.TabIndex = 1;
            // 
            // DTP_Date
            // 
            this.DTP_Date.Location = new System.Drawing.Point(47, 69);
            this.DTP_Date.Name = "DTP_Date";
            this.DTP_Date.Size = new System.Drawing.Size(200, 20);
            this.DTP_Date.TabIndex = 2;
            // 
            // TXT_Time
            // 
            this.TXT_Time.Location = new System.Drawing.Point(47, 95);
            this.TXT_Time.Name = "TXT_Time";
            this.TXT_Time.Size = new System.Drawing.Size(200, 20);
            this.TXT_Time.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Time";
            // 
            // BT_Add
            // 
            this.BT_Add.Location = new System.Drawing.Point(171, 121);
            this.BT_Add.Name = "BT_Add";
            this.BT_Add.Size = new System.Drawing.Size(75, 23);
            this.BT_Add.TabIndex = 8;
            this.BT_Add.Text = "Add";
            this.BT_Add.UseVisualStyleBackColor = true;
            this.BT_Add.Click += new System.EventHandler(this.BT_Add_Click);
            // 
            // AddFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 153);
            this.Controls.Add(this.BT_Add);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXT_Time);
            this.Controls.Add(this.DTP_Date);
            this.Controls.Add(this.CB_To);
            this.Controls.Add(this.CB_From);
            this.Name = "AddFlight";
            this.Text = "AddFlight";
            this.Load += new System.EventHandler(this.AddFlight_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_From;
        private System.Windows.Forms.ComboBox CB_To;
        private System.Windows.Forms.DateTimePicker DTP_Date;
        private System.Windows.Forms.TextBox TXT_Time;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BT_Add;
    }
}