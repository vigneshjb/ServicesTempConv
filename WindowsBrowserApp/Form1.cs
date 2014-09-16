using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsBrowserApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BackBut_Click(object sender, EventArgs e)
        {
            //Back Button
            webBrowser1.GoBack();
        }

        private void NextBut_Click(object sender, EventArgs e)
        {
            //Forward Button
            webBrowser1.GoForward();
        }

        private void NavBut_Click(object sender, EventArgs e)
        {
            //Navigating to a new Page
            webBrowser1.Navigate(AddressBox.Text);
        }

        private void CurRateBut_Click(object sender, EventArgs e)
        {
            //Get the Currency name as String and covert it to Enum Defined in the Service
            CurCovRef.Currency FromCurrency = (CurCovRef.Currency) System.Enum.Parse(typeof(CurCovRef.Currency), FromCurComBox.Text);
            CurCovRef.Currency ToCurrency = (CurCovRef.Currency)System.Enum.Parse(typeof(CurCovRef.Currency), ToCurComBox.Text);
            CurCovRef.CurrencyConvertorSoapClient CurConvClient = new CurCovRef.CurrencyConvertorSoapClient();
            //Invoking the service with the Enum values
            CurrencyRate.Text = CurConvClient.ConversionRate(FromCurrency, ToCurrency).ToString();
        }

        private void StoQuoBut_Click(object sender, EventArgs e)
        {
            //Stock Quote service invoking
            StockQuoteSerRef.ServiceClient StockClient = new StockQuoteSerRef.ServiceClient();
            StoQuoRes.Text = StockClient.getStockquote(StockSymbInp.Text);
        }

        private void EncrypBut_Click(object sender, EventArgs e)
        {
            //Encrypt Service Invoking
            EncryptDecryptRef.ServiceClient EncryptClient = new EncryptDecryptRef.ServiceClient();
            EncryptOut.Text = EncryptClient.Encrypt(EncryInp.Text);
        }

        private void DecrypBut_Click(object sender, EventArgs e)
        {
            //Decrypt Service Invoking
            EncryptDecryptRef.ServiceClient DecryptClient = new EncryptDecryptRef.ServiceClient();
            DecryptOut.Text = DecryptClient.Decrypt(DecryInp.Text);
        }
    }
}
