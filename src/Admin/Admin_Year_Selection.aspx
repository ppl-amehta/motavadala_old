<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Admin_Year_Selection.aspx.vb" Inherits="Admin_Year_Selection" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    
    <link href="\CSS\aos.css" rel="stylesheet" type="text/css" />
    <link href="\CSS\Button.css" rel="stylesheet" type="text/css" />
    <link href="\CSS\Color.css" rel="stylesheet" type="text/css" />
    <link href="\CSS\Font.css" rel="stylesheet" type="text/css" />
    <link href="\CSS\Main.css" rel="stylesheet" type="text/css" />
    
    <title>OLD Year Selection</title>

</head>
<body style=" background-image: url('../../../Images/Back.jpg'); background-repeat: no-repeat; background-attachment: fixed; background-size: 100% 100%;">
    <form id="frmAdminYearSelection" runat="server">
        <div class="Lobster-BlodItalic FontSizeHeading AlignCenter">
            Mota Vadala Gau Seva Rahat Trust
        </div>
        <br />
        <br />
        <div class="PlayBoldText FontSizeNormalHeavy AlignCenter">
            Old Year Selection.
        </div>
        <div style="position: absolute; top: auto; margin: 0; left: 50%; transform: translate(-50%, 0%);">
            <div class="DIVCenterHorizental">
                <br />
                <br />
                <asp:Label runat="server" ID="lblMessage" Text="" Width="300px" CssClass=" AlignLeft PlayBoldText RedForeColor FontSizeMediumNormal"></asp:Label>
                <br />
                <br />
                <asp:ListBox ID="lstYearSelection" runat="server" Height="75px" Width="100%" CssClass="PlayBoldText FontSizeNormal LineSpace1 PaddingAllSide"></asp:ListBox>

                <br />
                <br />
                <asp:Button runat="server" ID="btnSelect" Text="Select Year And Go To Receipt" Width="100%" class="btn Lobster-BlodItalic"></asp:Button>
                <br />
                <br />
            </div>
            <br />
 <br />
 <div class="AlignCenter">

     <asp:Button runat="server" ID="btnBack" Text="Back to Admin Menu" Width="100%" class="btn Lobster-BlodItalic"></asp:Button>

 </div>
 <br />
 <br />
        </div>
    </form>
</body>
</html>
