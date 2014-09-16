<%@ Page Language="C#" AutoEventWireup="true" CodeFile="default.aspx.cs" Inherits="TempConvWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 272px;
        }
        .auto-style2 {
            text-align: center;
            width: 768px;
            height: 264px;
        }
    </style>
</head>
<body style="height: 314px">
    <form id="form1" runat="server" class="auto-style1">
        <div class="auto-style2">
            <h2>Temperature Conversion</h2>
            This Web form Consumes a WCF Service to perform temperature conversation.<br />
            <br />
            <b>Celsius to Fahrenheit</b><br />
            Enter Celsius Temperature&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="InpCel" runat="server" Width="127px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="CelToFarBut" runat="server" OnClick="CelToFarBut_Click" Text="Convert" />
            <br />
            <br />
            <b>Fahrenheit to Celsius</b><br />
            Enter Fahrenheit Temperature&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="FarInp" runat="server" Width="127px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="FarToCelBut" runat="server" OnClick="FarToCelBut_Click" Text="Convert" />
            <br />
            <br />
            Result<br />
            <asp:TextBox ID="Result" runat="server" ReadOnly="True"></asp:TextBox>
            <br />
            <div align="right">Vignesh Jayabalan</div>
        </div>
    </form>
</body>
</html>
