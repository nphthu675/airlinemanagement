namespace QLChuyenBay.GUI
{
    partial class QLSanBay
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
            this.label2 = new System.Windows.Forms.Label();
            this.TXT_Name = new System.Windows.Forms.TextBox();
            this.TXT_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DGV_Airport = new System.Windows.Forms.DataGridView();
            this.BT_Save = new System.Windows.Forms.Button();
            this.BT_Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Airport)).BeginInit();
            this.SuspendLayout();
            // 
            // BT_Add
            // 
            this.BT_Add.Location = new System.Drawing.Point(357, 64);
            this.BT_Add.Name = "BT_Add";
            this.BT_Add.Size = new System.Drawing.Size(75, 23);
            this.BT_Add.TabIndex = 9;
            this.BT_Add.Text = "Add";
            this.BT_Add.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Name";
            // 
            // TXT_Name
            // 
            this.TXT_Name.Location = new System.Drawing.Point(52, 38);
            this.TXT_Name.Name = "TXT_Name";
            this.TXT_Name.Size = new System.Drawing.Size(380, 20);
            this.TXT_Name.TabIndex = 7;
            // 
            // TXT_ID
            // 
            this.TXT_ID.Location = new System.Drawing.Point(52, 12);
            this.TXT_ID.Name = "TXT_ID";
            this.TXT_ID.Size = new System.Drawing.Size(380, 20);
            this.TXT_ID.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID";
            // 
            // DGV_Airport
            // 
            this.DGV_Airport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Airport.Location = new System.Drawing.Point(11, 102);
            this.DGV_Airport.Name = "DGV_Airport";
            this.DGV_Airport.Size = new System.Drawing.Size(421, 217);
            this.DGV_Airport.TabIndex = 10;
            // 
            // BT_Save
            // 
            this.BT_Save.Location = new System.Drawing.Point(356, 326);
            this.BT_Save.Name = "BT_Save";
            this.BT_Save.Size = new System.Drawing.Size(75, 23);
            this.BT_Save.TabIndex = 11;
            this.BT_Save.Text = "Save";
            this.BT_Save.UseVisualStyleBackColor = true;
            this.BT_Save.Click += new System.EventHandler(this.BT_Save_Click);
            // 
            // BT_Delete
            // 
            this.BT_Delete.Location = new System.Drawing.Point(275, 326);
            this.BT_Delete.Name = "BT_Delete";
            this.BT_Delete.Size = new System.Drawing.Size(75, 23);
            this.BT_Delete.TabIndex = 12;
            this.BT_Delete.Text = "Delete";
            this.BT_Delete.UseVisualStyleBackColor = true;
            // 
            // QLSanBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 356);
            this.Controls.Add(this.BT_Delete);
            this.Controls.Add(this.BT_Save);
            this.Controls.Add(this.DGV_Airport);
            this.Controls.Add(this.BT_Add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXT_Name);
            this.Controls.Add(this.TXT_ID);
            this.Controls.Add(this.label1);
            this.Name = "QLSanBay";
            this.Text = "QLSanBay";
            this.Load += new System.EventHandler(this.QLSanBay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Airport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_Add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXT_Name;
        private System.Windows.Forms.TextBox TXT_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGV_Airport;
        private System.Windows.Forms.Button BT_Save;
        private System.Windows.Forms.Button BT_Delete;
    }
}