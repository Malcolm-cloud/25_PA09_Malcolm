namespace _25_Malcolm_PA09
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
            this.txt_Amount = new System.Windows.Forms.TextBox();
            this.lbl_Amount = new System.Windows.Forms.Label();
            this.lbl_selectcurrency = new System.Windows.Forms.Label();
            this.rdb_JapaneseYen = new System.Windows.Forms.RadioButton();
            this.rdb_USdollars = new System.Windows.Forms.RadioButton();
            this.lbl_value = new System.Windows.Forms.Label();
            this.txt_convertedAmt = new System.Windows.Forms.TextBox();
            this.btn_Convert = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.ringit = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txt_Amount
            // 
            this.txt_Amount.Location = new System.Drawing.Point(125, 26);
            this.txt_Amount.Name = "txt_Amount";
            this.txt_Amount.Size = new System.Drawing.Size(100, 20);
            this.txt_Amount.TabIndex = 0;
            // 
            // lbl_Amount
            // 
            this.lbl_Amount.AutoSize = true;
            this.lbl_Amount.Location = new System.Drawing.Point(48, 26);
            this.lbl_Amount.Name = "lbl_Amount";
            this.lbl_Amount.Size = new System.Drawing.Size(43, 13);
            this.lbl_Amount.TabIndex = 1;
            this.lbl_Amount.Text = "Amount";
            // 
            // lbl_selectcurrency
            // 
            this.lbl_selectcurrency.AutoSize = true;
            this.lbl_selectcurrency.Location = new System.Drawing.Point(12, 83);
            this.lbl_selectcurrency.Name = "lbl_selectcurrency";
            this.lbl_selectcurrency.Size = new System.Drawing.Size(82, 13);
            this.lbl_selectcurrency.TabIndex = 2;
            this.lbl_selectcurrency.Text = "Select Currency";
            // 
            // rdb_JapaneseYen
            // 
            this.rdb_JapaneseYen.AutoSize = true;
            this.rdb_JapaneseYen.Location = new System.Drawing.Point(125, 83);
            this.rdb_JapaneseYen.Name = "rdb_JapaneseYen";
            this.rdb_JapaneseYen.Size = new System.Drawing.Size(93, 17);
            this.rdb_JapaneseYen.TabIndex = 3;
            this.rdb_JapaneseYen.TabStop = true;
            this.rdb_JapaneseYen.Text = "Japanese Yen";
            this.rdb_JapaneseYen.UseVisualStyleBackColor = true;
            // 
            // rdb_USdollars
            // 
            this.rdb_USdollars.AutoSize = true;
            this.rdb_USdollars.Location = new System.Drawing.Point(125, 119);
            this.rdb_USdollars.Name = "rdb_USdollars";
            this.rdb_USdollars.Size = new System.Drawing.Size(75, 17);
            this.rdb_USdollars.TabIndex = 4;
            this.rdb_USdollars.TabStop = true;
            this.rdb_USdollars.Text = "US Dollars";
            this.rdb_USdollars.UseVisualStyleBackColor = true;
            // 
            // lbl_value
            // 
            this.lbl_value.AutoSize = true;
            this.lbl_value.Location = new System.Drawing.Point(51, 187);
            this.lbl_value.Name = "lbl_value";
            this.lbl_value.Size = new System.Drawing.Size(34, 13);
            this.lbl_value.TabIndex = 5;
            this.lbl_value.Text = "Value";
            // 
            // txt_convertedAmt
            // 
            this.txt_convertedAmt.Location = new System.Drawing.Point(125, 184);
            this.txt_convertedAmt.Name = "txt_convertedAmt";
            this.txt_convertedAmt.ReadOnly = true;
            this.txt_convertedAmt.Size = new System.Drawing.Size(54, 20);
            this.txt_convertedAmt.TabIndex = 6;
            // 
            // btn_Convert
            // 
            this.btn_Convert.Location = new System.Drawing.Point(415, 83);
            this.btn_Convert.Name = "btn_Convert";
            this.btn_Convert.Size = new System.Drawing.Size(75, 23);
            this.btn_Convert.TabIndex = 7;
            this.btn_Convert.Text = "Convert";
            this.btn_Convert.UseVisualStyleBackColor = true;
            this.btn_Convert.Click += new System.EventHandler(this.btn_Convert_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(415, 119);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 23);
            this.btn_Clear.TabIndex = 8;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // ringit
            // 
            this.ringit.AutoSize = true;
            this.ringit.Location = new System.Drawing.Point(125, 151);
            this.ringit.Name = "ringit";
            this.ringit.Size = new System.Drawing.Size(108, 17);
            this.ringit.TabIndex = 9;
            this.ringit.TabStop = true;
            this.ringit.Text = "Malaysian Ringgit";
            this.ringit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 290);
            this.Controls.Add(this.ringit);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Convert);
            this.Controls.Add(this.txt_convertedAmt);
            this.Controls.Add(this.lbl_value);
            this.Controls.Add(this.rdb_USdollars);
            this.Controls.Add(this.rdb_JapaneseYen);
            this.Controls.Add(this.lbl_selectcurrency);
            this.Controls.Add(this.lbl_Amount);
            this.Controls.Add(this.txt_Amount);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Amount;
        private System.Windows.Forms.Label lbl_Amount;
        private System.Windows.Forms.Label lbl_selectcurrency;
        private System.Windows.Forms.RadioButton rdb_JapaneseYen;
        private System.Windows.Forms.RadioButton rdb_USdollars;
        private System.Windows.Forms.Label lbl_value;
        private System.Windows.Forms.TextBox txt_convertedAmt;
        private System.Windows.Forms.Button btn_Convert;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.RadioButton ringit;
    }
}

