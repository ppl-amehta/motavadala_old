<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Whatsapp.aspx.vb" Inherits="Whatsapp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />

   
    <link href="CSS\aos.css" rel="stylesheet" type="text/css" />
    <link href="CSS\Button.css" rel="stylesheet" type="text/css" />
    <link href="CSS\Color.css" rel="stylesheet" type="text/css" />
    <link href="CSS\Font.css" rel="stylesheet" type="text/css" />
    <link href="CSS\Main.css" rel="stylesheet" type="text/css" />
    <title>Whatsapp Page</title>
</head>
    <body class="PageBackground">

    <form id="frmWhatsapp" runat="server">
         <div class="Lobster-BlodItalic FontSizeHeading AlignCenter">
            Mota Vadala Gau Seva Rahat Trust
        </div>
        <br />
        <br />
          <div class="PlayBoldText FontSizeNormalHeavy AlignCenter">
            SENDING WHATSAPP MESSAGE, PLEASE PRESS BACK BUTTON AFTER WHATSAPP MESSAGE IS SANDED TO GO BACK.
        </div>
        <%--check receipt code for use of this page.--%>
         <div class="DIVCenterHorizental">

                <div>

                    <br />
                    <br />
                    <asp:Button runat="server" ID="btnBack" Text="Back" class="btn Lobster-BlodItalic"></asp:Button>
                    <br />
                    <br />

                </div>

            </div>
    </form>
</body>
</html>
