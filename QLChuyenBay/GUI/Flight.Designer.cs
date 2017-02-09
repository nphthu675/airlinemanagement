namespace QLChuyenBay.GUI
{
    partial class Flight
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
            this.BT_Add = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_Time = new System.Windows.Forms.TextBox();
            this.DTP_Date = new System.Windows.Forms.DateTimePicker();
            this.CB_To = new System.Windows.Forms.ComboBox();
            this.CB_From = new System.Windows.Forms.ComboBox();
            this.DGVFlight = new System.Windows.Forms.DataGridView();
            this.BTSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVFlight)).BeginInit();
            this.SuspendLayout();
            // 
            // BT_Add
            // 
            this.BT_Add.Location = new System.Drawing.Point(435, 66);
            this.BT_Add.Name = "BT_Add";
            this.BT_Add.Size = new System.Drawing.Size(75, 23);
            this.BT_Add.TabIndex = 17;
            this.BT_Add.Text = "Add";
            this.BT_Add.UseVisualStyleBackColor = true;
            this.BT_Add.Click += new System.EventHandler(this.BT_Add_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(275, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "From";
            // 
            // TXT_Time
            // 
            this.TXT_Time.Location = new System.Drawing.Point(310, 40);
            this.TXT_Time.Name = "TXT_Time";
            this.TXT_Time.Size = new System.Drawing.Size(200, 20);
            this.TXT_Time.TabIndex = 12;
            // 
            // DTP_Date
            // 
            this.DTP_Date.Location = new System.Drawing.Point(46, 39);
            this.DTP_Date.Name = "DTP_Date";
            this.DTP_Date.Size = new System.Drawing.Size(200, 20);
            this.DTP_Date.TabIndex = 11;
            // 
            // CB_To
            // 
            this.CB_To.FormattingEnabled = true;
            this.CB_To.Location = new System.Drawing.Point(310, 13);
            this.CB_To.Name = "CB_To";
            this.CB_To.Size = new System.Drawing.Size(199, 21);
            this.CB_To.TabIndex = 10;
            // 
            // CB_From
            // 
            this.CB_From.FormattingEnabled = true;
            this.CB_From.Location = new System.Drawing.Point(46, 12);
            this.CB_From.Name = "CB_From";
            this.CB_From.Size = new System.Drawing.Size(199, 21);
            this.CB_From.TabIndex = 9;
            // 
            // DGVFlight
            // 
            this.DGVFlight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVFlight.Location = new System.Drawing.Point(13, 93);
            this.DGVFlight.Name = "DGVFlight";
            this.DGVFlight.Size = new System.Drawing.Size(496, 217);
            this.DGVFlight.TabIndex = 18;
            // 
            // BTSave
            // 
            this.BTSave.Location = new System.Drawing.Point(435, 316);
            this.BTSave.Name = "BTSave";
            this.BTSave.Size = new System.Drawing.Size(75, 23);
            this.BTSave.TabIndex = 19;
            this.BTSave.Text = "Save";
            this.BTSave.UseVisualStyleBackColor = true;
            // 
            // Flight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 348);
            this.Controls.Add(this.BTSave);
            this.Controls.Add(this.DGVFlight);
            this.Controls.Add(this.BT_Add);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXT_Time);
            this.Controls.Add(this.DTP_Date);
            this.Controls.Add(this.CB_To);
            this.Controls.Add(this.CB_From);
            this.Name = "Flight";
            this.Text = "Flight";
            this.Load += new System.EventHandler(this.Flight_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVFlight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_Add;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXT_Time;
        private System.Windows.Forms.DateTimePicker DTP_Date;
        private System.Windows.Forms.ComboBox CB_To;
        private System.Windows.Forms.ComboBox CB_From;
        private System.Windows.Forms.DataGridView DGVFlight;
        private System.Windows.Forms.Button BTSave;
    }
}