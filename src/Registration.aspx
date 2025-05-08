<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Registration.aspx.vb" Inherits="Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    
     <link href="CSS\aos.css" rel="stylesheet" type="text/css" />
    <link href="CSS\Button.css" rel="stylesheet" type="text/css" />
    <link href="CSS\Color.css" rel="stylesheet" type="text/css" />
    <link href="CSS\Font.css" rel="stylesheet" type="text/css" />
    <link href="CSS\Main.css" rel="stylesheet" type="text/css" />
    <title>Registration Form</title>
</head>
<body class="PageBackground">
    <form id="frmRegistration" runat="server">
        <div class="Lobster-BlodItalic FontSizeHeading AlignCenter">
            Mota Vadala Gau Seva Rahat Trust
        </div>
        <br />
        <br />
        <div class="PlayBoldText FontSizeNormalHeavy AlignCenter">
            User Registration Form
        </div>
        <div style="position: absolute; top: auto; margin: 0; left: 50%; transform: translate(-50%, 0%);">
            <div class="DIVCenterHorizental">
                <br />
                <br />
                <asp:Label runat="server" ID="lblMessage" Text="" CssClass=" AlignLeft PlayBoldText FontSizeMediumNormal RedForeColor"></asp:Label>

                <br />
                <asp:Label runat="server" ID="lblContactPersonName" Text="Contact Person Name :" CssClass="PlayBoldText FontSizeMediumNormal"></asp:Label>
                <br />
                <asp:TextBox runat="server" ID="txtContactPersonName" Width="300px" CssClass="RoundCornerWithBorder PlayText FontSizeNormal"></asp:TextBox>
                <br />
                <asp:Label runat="server" ID="lblMobileNumber" Text="Mobile :" CssClass="PlayBoldText FontSizeMediumNormal"></asp:Label>
                <br />
                <asp:TextBox runat="server" ID="txtMobile" Width="300px" CssClass="RoundCornerWithBorder PlayText FontSizeNormal" onkeypress="OnlyNumericEntry(this)"> </asp:TextBox>
                <br />
                <asp:Label runat="server" ID="lblAddress" Text="Address :" CssClass="PlayBoldText FontSizeMediumNormal"></asp:Label>
                <br />
                <asp:TextBox runat="server" ID="txtAddress" Width="300px" CssClass="RoundCornerWithBorder PlayText FontSizeNormal"></asp:TextBox>
                <br />
                <asp:Label runat="server" ID="lblCity" Text="City :" CssClass="PlayBoldText FontSizeMediumNormal"></asp:Label>
                <br />
                <asp:TextBox runat="server" ID="txtCity" Width="300px" CssClass="RoundCornerWithBorder PlayText FontSizeNormal"></asp:TextBox>
                <br />
                <asp:Label runat="server" ID="lblPincode" Text="Pincode :" CssClass="PlayBoldText FontSizeMediumNormal"></asp:Label>
                <br />
                <asp:TextBox runat="server" ID="txtPincode" Width="300px" CssClass="RoundCornerWithBorder PlayText FontSizeNormal"></asp:TextBox>
                <br />
                <asp:Label runat="server" ID="lblState" Text="State :" CssClass="PlayBoldText FontSizeMediumNormal"></asp:Label>
                <br />
                <asp:TextBox runat="server" ID="txtState" Width="300px" CssClass="RoundCornerWithBorder PlayText FontSizeNormal"></asp:TextBox>
                <br />
                <asp:Label runat="server" ID="lblCountry" Text="Country :" CssClass="PlayBoldText FontSizeMediumNormal"></asp:Label>
                <br />
                <asp:TextBox runat="server" ID="txtCountry" Width="300px" CssClass="RoundCornerWithBorder PlayText FontSizeNormal"></asp:TextBox>
                <br />
                <asp:Label runat="server" ID="lblEmail" Text="Email :" CssClass="PlayBoldText FontSizeMediumNormal"></asp:Label>
                <br />
                <asp:TextBox runat="server" ID="txtEmail" Width="300px" CssClass="RoundCornerWithBorder PlayText FontSizeNormal"></asp:TextBox>
                <br />

                <asp:Label runat="server" ID="lblUsername" Text="RBU Name :" CssClass=" AlignLeft PlayBoldText FontSizeMediumNormal"></asp:Label>
                <br />
                <asp:TextBox runat="server" ID="txtUserName" Width="300px" CssClass="RoundCornerWithBorder PlayText FontSizeNormal"></asp:TextBox>
                <br />
                <asp:Label runat="server" ID="lblPassword" Text="Password :" CssClass=" AlignLeft PlayBoldText FontSizeMediumNormal"></asp:Label>
                <br />
                <asp:TextBox runat="server" ID="txtPassword" Width="300px" CssClass="RoundCornerWithBorder PlayText FontSizeNormal"></asp:TextBox>
                <br />
                <asp:Label runat="server" ID="lblRemark" Text="Remkark :" CssClass="PlayBoldText FontSizeMediumNormal"></asp:Label>
                <br />
                <asp:TextBox runat="server" ID="txtRemark" TextMode="MultiLine" Width="300px" Height="100px" CssClass="RoundCornerWithBorder PlayText FontSizeNormal"></asp:TextBox>
                <br />

                <br />
                <br />
                <div class="AlignCenter">
                    <asp:Button runat="server" ID="btnSumbit" Text="Submit" Width="75%" class="btn Lobster-BlodItalic"></asp:Button>

                </div>
                <br />
                <br />

               

            </div>
        </div>

    </form>
     
</body>
</html>