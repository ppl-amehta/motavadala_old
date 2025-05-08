<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Admin_Menu.aspx.vb" Inherits="Admin_Menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    
    <link href="\CSS\aos.css" rel="stylesheet" type="text/css" />
    <link href="\CSS\Button.css" rel="stylesheet" type="text/css" />
    <link href="\CSS\Color.css" rel="stylesheet" type="text/css" />
    <link href="\CSS\Font.css" rel="stylesheet" type="text/css" />
    <link href="\CSS\Main.css" rel="stylesheet" type="text/css" />
    <title>Administrator Menu</title>
</head>
<body style=" background-image: url('../../../Images/Back.jpg'); background-repeat: no-repeat; background-attachment: fixed; background-size: 120% 120%;">
    <form id="frmAdminMenu" runat="server">
        <div class ="Lobster-BlodItalic FontSizeHeading AlignCenter">
            Mota Vadala Gau Seva Rahat Trust
        </div>
        <br />
        <br />
        <div class="PlayBoldText FontSizeNormalHeavy AlignCenter">
            Admin Menu
        </div>
        <div style="position: absolute; top: auto; margin: 0; left: 50%; transform: translate(-50%, 0%);">
            <div class="DIVCenterHorizental">
                <br />
                <br />
                <asp:Button runat="server" ID="btnPayment" Text="Payment (QR Code)" Width="120%" class="btn Lobster-BlodItalic DIVCenterHorizental"></asp:Button>
                <br />
                <br />
                <asp:Button runat="server" ID="btnCreateNewReceipt" Text="Create New Receipt" Width="120%" class="btn Lobster-BlodItalic DIVCenterHorizental"></asp:Button>
                <br />
                <br />
                <asp:Button runat="server" ID="btnModifyReceipt" Text="View and Modify Old Receipt" Width="120%" class="btn Lobster-BlodItalic DIVCenterHorizental"></asp:Button>
                <br />
                <br />
                <asp:Button runat="server" ID="btnUserList" Text="User List" Width="120%" class="btn Lobster-BlodItalic DIVCenterHorizental"></asp:Button>
                <br />
                <br />
                <asp:Button runat="server" ID="btnOldDatabaseSelectionAndCreateReceipt" Text="Select Old Database & Create Receipt" Width="120%" Height="70px" class="btn Lobster-BlodItalic WrapText DIVCenterHorizental"></asp:Button>
                <br />
                <br />
                <asp:Button runat="server" ID="btnReports" Text="Reports" Width="120%" class="btn Lobster-BlodItalic DIVCenterHorizental"></asp:Button>
                <br />
                <br />
                <asp:Button runat="server" ID="btnLogout" Text="Logout" Width="120%" class="btn Lobster-BlodItalic DIVCenterHorizental"></asp:Button>

            </div>
        </div>
    </form>
</body>
</html>
