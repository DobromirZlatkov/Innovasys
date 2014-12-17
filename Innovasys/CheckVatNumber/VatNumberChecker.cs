namespace CheckVatNumber
{
    using System;
    using System.ComponentModel;
    using System.Windows.Forms;

    public partial class VatNumberChecker : Form
    {
        public VatNumberChecker()
        {
            this.InitializeComponent();
        }

        private void ButtonCheckVatNumber_Click(object sender, EventArgs e)
        {
            if (TextBoxVatNumber.Text == string.Empty)
            {
                LabelVatNumberError.Text = "Missing Vat Number";
                return;
            }
            else if (TextBoxCountryCode.Text == string.Empty)
            {
                LabelCountryCodeError.Text = "Missing Country Code";
                return;
            }

            var vatNumber = TextBoxVatNumber.Text;
            var countryCode = TextBoxCountryCode.Text;
            bool doVatNumberExists;
            string name;
            string address;

            var checkVatPortType = new ServiceReferenceCheckIfVatNumberIsValid.checkVatPortTypeClient();

            try
            {
                checkVatPortType.checkVat(ref countryCode, ref vatNumber, out doVatNumberExists, out name, out address);
                TextBoxResult.Text = doVatNumberExists.ToString();
            }
            catch (Exception)
            {
                TextBoxResult.Text = "Invalid input";
            }
        }

        private void TextBoxVatNumber_TextChanged(object sender, EventArgs e)
        {
            LabelVatNumberError.Text = string.Empty;
        }

        private void TextBoxCountryCode_TextChanged(object sender, EventArgs e)
        {
            LabelCountryCodeError.Text = string.Empty;
        }
    }
}
