<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Admin_Reports.aspx.vb" Inherits="Admin_Reports" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    
    <link href="\CSS\aos.css" rel="stylesheet" type="text/css" />
    <link href="\CSS\Button.css" rel="stylesheet" type="text/css" />
    <link href="\CSS\Color.css" rel="stylesheet" type="text/css" />
    <link href="\CSS\Font.css" rel="stylesheet" type="text/css" />
    <link href="\CSS\Main.css" rel="stylesheet" type="text/css" />

    <title>Report</title>
</head>
<body style=" background-image: url('../../../Images/Back.jpg'); background-repeat: no-repeat; background-attachment: fixed; background-size: 100% 100%;">
  
    <form id="frmReport" runat="server">
     
        <div class="Lobster-BlodItalic FontSizeHeading AlignCenter">
            Mota Vadala Gau Seva Rahat Trust
        </div>

        <br />
        <br />

        <div class="PlayBoldText FontSizeNormalHeavy AlignCenter">
            Admin Report Page
        </div>

         <div style="position: absolute; top: auto; margin: 0; left: 50%; transform: translate(-50%, 0%);">
            <div class="DIVCenterHorizental">
                 <br />
                <br />
                <asp:Label runat="server" ID="lblMessage" Text="" CssClass=" AlignLeft PlayBoldText FontSizeMediumNormal RedForeColor"></asp:Label>
                <br />
                <br />
                <asp:Button runat="server" ID="btnDontionRegister" Text="Donation Register" Width="120%" class="btn Lobster-BlodItalic DIVCenterHorizental"></asp:Button>
                <br />
                <br />
                <asp:Button runat="server" ID="btnForm10BD" Text="Form 10BD Donation Details" Width="120%" class="btn Lobster-BlodItalic DIVCenterHorizental"></asp:Button>
                <br />
                <br />
                <asp:Button runat="server" ID="btnBack" Text="Back to Admin Menu" Width="120%" class="btn Lobster-BlodItalic DIVCenterHorizental"></asp:Button>

            </div>
        </div>

    </form>

</body>
</html>
