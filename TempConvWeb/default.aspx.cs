using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TempConvWebForm : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void CelToFarBut_Click(object sender, EventArgs e)
    {
        TempConvService.Service1Client TempConvSerCliet = new TempConvService.Service1Client();
        try { Result.Text = TempConvSerCliet.c2f(int.Parse(InpCel.Text)).ToString(); }
        catch (Exception) { Console.WriteLine("Exception caught in CelToFarConv"); }
    }
    protected void FarToCelBut_Click(object sender, EventArgs e)
    {
        TempConvService.Service1Client TempConvSerCliet = new TempConvService.Service1Client();
        try { Result.Text = TempConvSerCliet.f2c(int.Parse(FarInp.Text)).ToString(); }
        catch (Exception) { Console.WriteLine("Exception caught in FarToCelConv"); }
    }
}