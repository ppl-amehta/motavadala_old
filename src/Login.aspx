<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Login.aspx.vb" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    
    <link href="CSS\aos.css" rel="stylesheet" type="text/css" />
    <link href="CSS\Button.css" rel="stylesheet" type="text/css" />
    <link href="CSS\Color.css" rel="stylesheet" type="text/css" />
    <link href="CSS\Font.css" rel="stylesheet" type="text/css" />
    <link href="CSS\Main.css" rel="stylesheet" type="text/css" />

    <script src="JavaScript/aos.js"></script>

    <title>User / RBU Log in Page</title>
</head>
<body class="PageBackground">

    <script>
        AOS.init();
    </script>

    <form id="frmLogin" runat="server">
        <div class="Lobster-BlodItalic FontSizeHeading AlignCenter" data-aos="fade-down" data-aos-duration="1000">
            Mota Vadala Gau Seva Rahat Trust
        </div>
        <br />
        <br />
        <div class="PlayBoldText FontSizeNormalHeavy AlignCenter" data-aos="zoom-in" data-aos-duration="1000">
            User / RBU Log in Page
        </div>
        <div style="position: absolute; top: auto; margin: 0; left: 50%; transform: translate(-50%, 0%);">
            <div class="DIVCenterHorizental">
                <br />
                <br />
                <asp:Label runat="server" ID="lblMessage" Text="" CssClass=" AlignLeft PlayBoldText FontSizeMediumNormal RedForeColor"></asp:Label>
                <br />
                <br />
                <asp:Label runat="server" ID="lblUsername" Text="User Name :" CssClass=" AlignLeft PlayBoldText FontSizeMediumNormal" ></asp:Label>
                <br />
                <asp:TextBox runat="server" ID="txtUserName" Width="250px" CssClass="RoundCornerWithBorder PlayText FontSizeNormal" ></asp:TextBox>
                <br />
                <asp:Label runat="server" ID="lblPassword" Text="Password :" CssClass="PlayBoldText FontSizeMediumNormal" ></asp:Label>
                <br />
                <asp:TextBox runat="server" ID="txtPassword" Width="250px" TextMode="Password" CssClass="RoundCornerWithBorder PlayText FontSizeNormal" ></asp:TextBox>
                <br />
                <br />
                <br />
                <div class="AlignCenter">
                    <asp:Button runat="server" ID="btnLogin" Text="Login" Width="100px" class="btn Lobster-BlodItalic" data-aos="zoom-in" data-aos-duration="1000"></asp:Button>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button runat="server" ID="btnForgot" Text="Forgot" Width="100px" class="btn Lobster-BlodItalic" data-aos="zoom-in" data-aos-duration="1000"></asp:Button>
                    <br />
                    <br />
                    <br />
                    <asp:Button runat="server" ID="btnRegister" Text="Register" Width="100%" class="btn Lobster-BlodItalic" data-aos="zoom-in" data-aos-duration="1000"></asp:Button>

                </div>
            </div>
        </div>
    </form>
</body>
</html>
