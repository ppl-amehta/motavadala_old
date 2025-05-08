<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Payment.aspx.vb" Inherits="Payment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    
    <link href="CSS\aos.css" rel="stylesheet" type="text/css" />
    <link href="CSS\Button.css" rel="stylesheet" type="text/css" />
    <link href="CSS\Color.css" rel="stylesheet" type="text/css" />
    <link href="CSS\Font.css" rel="stylesheet" type="text/css" />
    <link href="CSS\Main.css" rel="stylesheet" type="text/css" />
    <title>Payment Page</title>
</head>
<body class="PageBackground">
    <form id="frmPayment" runat="server">
        <div class ="Lobster-BlodItalic FontSizeHeading AlignCenter">
            Mota Vadala Gau Seva Rahat Trust
        </div>
        <div class="AlignCenter">
            <p class="PlayBoldText FontSizeNormal"> Scan QR Code For Donation.</p>
            <img src="Images\QR_CODE.png" alt="QR Code" width="325" height="450"/> 
            <br />
            <br />
            <asp:Button runat="server" id="btnSkip" Text="Skip to Login Page" class="btn Lobster-BlodItalic"> </asp:Button>
            <br />
            <br />
            <asp:Button runat="server" id="btnBack" Text="Back to Admin Menu Page" class="btn Lobster-BlodItalic"> </asp:Button>
        </div>
    </form>
</body>
</html>
