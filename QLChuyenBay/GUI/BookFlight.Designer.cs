namespace QLChuyenBay.GUI
{
    partial class BookFlight
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FromCB = new System.Windows.Forms.ComboBox();
            this.ToCB = new System.Windows.Forms.ComboBox();
            this.DateDTP = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            this.ResultDGV = new System.Windows.Forms.DataGridView();
            this.BookBT = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Search);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DateDTP);
            this.groupBox1.Controls.Add(this.ToCB);
            this.groupBox1.Controls.Add(this.FromCB);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(622, 79);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // FromCB
            // 
            this.FromCB.FormattingEnabled = true;
            this.FromCB.Location = new System.Drawing.Point(36, 23);
            this.FromCB.Name = "FromCB";
            this.FromCB.Size = new System.Drawing.Size(140, 21);
            this.FromCB.TabIndex = 0;
            // 
            // ToCB
            // 
            this.ToCB.FormattingEnabled = true;
            this.ToCB.Location = new System.Drawing.Point(209, 23);
            this.ToCB.Name = "ToCB";
            this.ToCB.Size = new System.Drawing.Size(143, 21);
            this.ToCB.TabIndex = 1;
            // 
            // DateDTP
            // 
            this.DateDTP.Location = new System.Drawing.Point(404, 23);
            this.DateDTP.Name = "DateDTP";
            this.DateDTP.Size = new System.Drawing.Size(200, 20);
            this.DateDTP.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(363, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date";
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(529, 49);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 6;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // ResultDGV
            // 
            this.ResultDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultDGV.Location = new System.Drawing.Point(12, 97);
            this.ResultDGV.Name = "ResultDGV";
            this.ResultDGV.Size = new System.Drawing.Size(622, 222);
            this.ResultDGV.TabIndex = 1;
            // 
            // BookBT
            // 
            this.BookBT.Location = new System.Drawing.Point(559, 325);
            this.BookBT.Name = "BookBT";
            this.BookBT.Size = new System.Drawing.Size(75, 23);
            this.BookBT.TabIndex = 2;
            this.BookBT.Text = "Book";
            this.BookBT.UseVisualStyleBackColor = true;
            // 
            // BookFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 351);
            this.Controls.Add(this.BookBT);
            this.Controls.Add(this.ResultDGV);
            this.Controls.Add(this.groupBox1);
            this.Name = "BookFlight";
            this.Text = "BookFlight";
            this.Load += new System.EventHandler(this.BookFlight_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DateDTP;
        private System.Windows.Forms.ComboBox ToCB;
        private System.Windows.Forms.ComboBox FromCB;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.DataGridView ResultDGV;
        private System.Windows.Forms.Button BookBT;
    }
}