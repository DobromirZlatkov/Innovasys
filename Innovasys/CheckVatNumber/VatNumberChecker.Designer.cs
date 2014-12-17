namespace CheckVatNumber
{
    partial class VatNumberChecker
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
            this.ButtonCheckVatNumber = new System.Windows.Forms.Button();
            this.TextBoxVatNumber = new System.Windows.Forms.TextBox();
            this.TextBoxCountryCode = new System.Windows.Forms.TextBox();
            this.LabelVatNumber = new System.Windows.Forms.Label();
            this.LabelCountryCode = new System.Windows.Forms.Label();
            this.LabelResult = new System.Windows.Forms.Label();
            this.TextBoxResult = new System.Windows.Forms.TextBox();
            this.LabelVatNumberError = new System.Windows.Forms.Label();
            this.LabelCountryCodeError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonCheckVatNumber
            // 
            this.ButtonCheckVatNumber.Location = new System.Drawing.Point(102, 206);
            this.ButtonCheckVatNumber.Name = "ButtonCheckVatNumber";
            this.ButtonCheckVatNumber.Size = new System.Drawing.Size(75, 23);
            this.ButtonCheckVatNumber.TabIndex = 0;
            this.ButtonCheckVatNumber.Text = "Check";
            this.ButtonCheckVatNumber.UseVisualStyleBackColor = true;
            this.ButtonCheckVatNumber.Click += new System.EventHandler(this.ButtonCheckVatNumber_Click);
            // 
            // TextBoxVatNumber
            // 
            this.TextBoxVatNumber.Location = new System.Drawing.Point(102, 26);
            this.TextBoxVatNumber.Name = "TextBoxVatNumber";
            this.TextBoxVatNumber.Size = new System.Drawing.Size(100, 20);
            this.TextBoxVatNumber.TabIndex = 2;
            this.TextBoxVatNumber.TextChanged += new System.EventHandler(this.TextBoxVatNumber_TextChanged);
            // 
            // TextBoxCountryCode
            // 
            this.TextBoxCountryCode.Location = new System.Drawing.Point(102, 83);
            this.TextBoxCountryCode.Name = "TextBoxCountryCode";
            this.TextBoxCountryCode.Size = new System.Drawing.Size(100, 20);
            this.TextBoxCountryCode.TabIndex = 3;
            this.TextBoxCountryCode.TextChanged += new System.EventHandler(this.TextBoxCountryCode_TextChanged);
            // 
            // LabelVatNumber
            // 
            this.LabelVatNumber.AutoSize = true;
            this.LabelVatNumber.Location = new System.Drawing.Point(30, 26);
            this.LabelVatNumber.Name = "LabelVatNumber";
            this.LabelVatNumber.Size = new System.Drawing.Size(61, 13);
            this.LabelVatNumber.TabIndex = 4;
            this.LabelVatNumber.Text = "Vat number";
            // 
            // LabelCountryCode
            // 
            this.LabelCountryCode.AutoSize = true;
            this.LabelCountryCode.Location = new System.Drawing.Point(30, 86);
            this.LabelCountryCode.Name = "LabelCountryCode";
            this.LabelCountryCode.Size = new System.Drawing.Size(71, 13);
            this.LabelCountryCode.TabIndex = 5;
            this.LabelCountryCode.Text = "Country Code";
            // 
            // LabelResult
            // 
            this.LabelResult.AutoSize = true;
            this.LabelResult.Location = new System.Drawing.Point(30, 147);
            this.LabelResult.Name = "LabelResult";
            this.LabelResult.Size = new System.Drawing.Size(37, 13);
            this.LabelResult.TabIndex = 6;
            this.LabelResult.Text = "Result";
            // 
            // TextBoxResult
            // 
            this.TextBoxResult.Enabled = false;
            this.TextBoxResult.Location = new System.Drawing.Point(102, 144);
            this.TextBoxResult.Name = "TextBoxResult";
            this.TextBoxResult.Size = new System.Drawing.Size(100, 20);
            this.TextBoxResult.TabIndex = 8;
            // 
            // LabelVatNumberError
            // 
            this.LabelVatNumberError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LabelVatNumberError.Location = new System.Drawing.Point(248, 23);
            this.LabelVatNumberError.Name = "LabelVatNumberError";
            this.LabelVatNumberError.Size = new System.Drawing.Size(229, 23);
            this.LabelVatNumberError.TabIndex = 9;
            // 
            // LabelCountryCodeError
            // 
            this.LabelCountryCodeError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LabelCountryCodeError.Location = new System.Drawing.Point(229, 83);
            this.LabelCountryCodeError.Name = "LabelCountryCodeError";
            this.LabelCountryCodeError.Size = new System.Drawing.Size(229, 23);
            this.LabelCountryCodeError.TabIndex = 10;
            // 
            // VatNumberChecker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 262);
            this.Controls.Add(this.LabelCountryCodeError);
            this.Controls.Add(this.LabelVatNumberError);
            this.Controls.Add(this.TextBoxResult);
            this.Controls.Add(this.LabelResult);
            this.Controls.Add(this.LabelCountryCode);
            this.Controls.Add(this.LabelVatNumber);
            this.Controls.Add(this.TextBoxCountryCode);
            this.Controls.Add(this.TextBoxVatNumber);
            this.Controls.Add(this.ButtonCheckVatNumber);
            this.Name = "VatNumberChecker";
            this.Text = "VatNumberChecker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonCheckVatNumber;
        private System.Windows.Forms.TextBox TextBoxVatNumber;
        private System.Windows.Forms.TextBox TextBoxCountryCode;
        private System.Windows.Forms.Label LabelVatNumber;
        private System.Windows.Forms.Label LabelCountryCode;
        private System.Windows.Forms.Label LabelResult;
        private System.Windows.Forms.TextBox TextBoxResult;
        private System.Windows.Forms.Label LabelVatNumberError;
        private System.Windows.Forms.Label LabelCountryCodeError;
    }
}