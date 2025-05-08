<%@ Page Language="VB" AutoEventWireup="false" CodeFile="ForgotPassword.aspx.vb" Inherits="ForgotPassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    
    <link href="CSS\aos.css" rel="stylesheet" type="text/css" />
    <link href="CSS\Button.css" rel="stylesheet" type="text/css" />
    <link href="CSS\Color.css" rel="stylesheet" type="text/css" />
    <link href="CSS\Font.css" rel="stylesheet" type="text/css" />
    <link href="CSS\Main.css" rel="stylesheet" type="text/css" />
    <title>Forgot Password Page</title>
</head>
<body class="PageBackground">
    <form id="frmForgotPassword" runat="server">
        <div class="Lobster-BlodItalic FontSizeHeading AlignCenter">
            Mota Vadala Gau Seva Rahat Trust
        </div>  
        <br />
        <br />
        <div class="PlayBoldText FontSizeNormalHeavy AlignCenter" >
            Forgot Password Form
        </div>
        
        <div style="position: absolute; top: auto; margin: 0; left: 50%; transform: translate(-50%, 0%);">
            <div class="DIVCenterHorizental">
                <br />
                 <br />
                <asp:Label runat="server" ID="lblMessage" Text="" CssClass=" AlignLeft PlayBoldText FontSizeMediumNormal RedForeColor"></asp:Label>
                <br />
                <br />
                <asp:Label runat="server" ID="lblMobile" Text="Mobile :" CssClass=" AlignLeft PlayBoldText FontSizeMediumNormal"></asp:Label>
                <br />
                <asp:TextBox runat="server" ID="txtMobile" Width="300px" CssClass="RoundCornerWithBorder PlayText FontSizeNormal"></asp:TextBox>
                <br />
                <asp:Label runat="server" ID="lblOR" Text="OR" CssClass="PlayBoldText FontSizeMediumNormal DIVCenterHorizental"></asp:Label>
                <br />
                <asp:Label runat="server" ID="lblEmail" Text="Email :" CssClass="PlayBoldText FontSizeMediumNormal"></asp:Label>
                <br />
                <asp:TextBox runat="server" ID="txtEmail" Width="300px" CssClass="RoundCornerWithBorder PlayText FontSizeNormal"></asp:TextBox>
                <br />
                <br />
                <br />
                <div class="AlignCenter">
                    <asp:Button runat="server" ID="btnSubmit" Text="Submit" class="btn Lobster-BlodItalic"></asp:Button>
                    <br />
                </div>
            </div>
        </div>
    </form>
</body>

</html>
