<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Reports.aspx.vb" Inherits="Reports" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    
     <link href="CSS\aos.css" rel="stylesheet" type="text/css" />
    <link href="CSS\Button.css" rel="stylesheet" type="text/css" />
    <link href="CSS\Color.css" rel="stylesheet" type="text/css" />
    <link href="CSS\Font.css" rel="stylesheet" type="text/css" />
    <link href="CSS\Main.css" rel="stylesheet" type="text/css" />
    <link href="CSS\GridStyle.css" rel="stylesheet" type="text/css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label runat="server" ID="lblMessage" Text="" Width="300px" CssClass=" AlignLeft PlayBoldText RedForeColor FontSizeMediumNormal"></asp:Label>
            <br />
            <br />
            <asp:Button runat="server" ID="btnReport" Text="Report" />
            <br />
            <br />
            <asp:HyperLink runat ="server" ID="hlTest" NavigateUrl="www.nexuscomputer.in" Target="_blank" Text="www.nexuscomputer.in" >

            </asp:HyperLink>
            <script>
function ClickLink() {
    document.getElementById('hlTest').click();
}
            </script>

        </div>
    </form>
</body>
</html>
