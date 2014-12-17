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
            catch (Exception ex)
            {
                TextBoxResult.Text = ex.Message.ToString();
            }  
        }
    }
}
