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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxResult = new System.Windows.Forms.TextBox();
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
            // 
            // TextBoxCountryCode
            // 
            this.TextBoxCountryCode.Location = new System.Drawing.Point(102, 83);
            this.TextBoxCountryCode.Name = "TextBoxCountryCode";
            this.TextBoxCountryCode.Size = new System.Drawing.Size(100, 20);
            this.TextBoxCountryCode.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Vat number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Country Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Result";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 7;
            // 
            // TextBoxResult
            // 
            this.TextBoxResult.Location = new System.Drawing.Point(102, 144);
            this.TextBoxResult.Name = "TextBoxResult";
            this.TextBoxResult.Size = new System.Drawing.Size(100, 20);
            this.TextBoxResult.TabIndex = 8;
            // 
            // VatNumberChecker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 262);
            this.Controls.Add(this.TextBoxResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBoxResult;
    }
}