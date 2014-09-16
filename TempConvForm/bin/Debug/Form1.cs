using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempConvForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CelToFarBut_Click(object sender, EventArgs e)
        {
            //Celsius to Fahrenheit Conversation
            TempConvWCFServ.Service1Client TempConvSerCli = new TempConvWCFServ.Service1Client();
            try { Result.Text = TempConvSerCli.c2f(int.Parse(InpCel.Text)).ToString(); }
            catch (Exception) { Console.WriteLine("Exception caught in CelToFarConv"); }
        }

        private void FarToCelBut_Click(object sender, EventArgs e)
        {
            //Fahrenheit to Celsius Conversation
            TempConvWCFServ.Service1Client TempConvSerCli = new TempConvWCFServ.Service1Client();
            try { Result.Text = TempConvSerCli.f2c(int.Parse(InpFar.Text)).ToString(); }
            catch (Exception) { Console.WriteLine("Exception caught in FarToCelConv"); }
        }
    }
}
