<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<%@ Register Assembly="DevExpress.Web.v24.1, Version=24.1.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    
    <link href="CSS\aos.css" rel="stylesheet" type="text/css" />
    <link href="CSS\Button.css" rel="stylesheet" type="text/css" />
    <link href="CSS\Color.css" rel="stylesheet" type="text/css" />
    <link href="CSS\Font.css" rel="stylesheet" type="text/css" />
    <link href="CSS\Main.css" rel="stylesheet" type="text/css" />
    <title> Welcome to Mota Vadala Official Website. </title>
</head>
<body class="PageBackground">
    <form id="form1" runat="server">

        <div class="Lobster-BlodItalic FontSizeHeading AlignCenter">
           Mota Vadala Gau Seva Rahat Trust Official Website
        </div>
        
        <br />
        <br />
        <asp:Label runat="server" ID="lblMessage" Text="" CssClass=" AlignLeft PlayBoldText FontSizeMediumNormal RedForeColor"></asp:Label>
        <br />
        <br />

    </form>
</body>
</html>
