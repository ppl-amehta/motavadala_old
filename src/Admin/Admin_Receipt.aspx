<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Admin_Receipt.aspx.vb" Inherits="Admin_Receipt" %>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    
    <link href="\CSS\aos.css" rel="stylesheet" type="text/css" />
    <link href="\CSS\Button.css" rel="stylesheet" type="text/css" />
    <link href="\CSS\Color.css" rel="stylesheet" type="text/css" />
    <link href="\CSS\Font.css" rel="stylesheet" type="text/css" />
    <link href="\CSS\Main.css" rel="stylesheet" type="text/css" />
    <title>Receipt Book</title>
</head>
<body style=" background-image: url('../../../Images/Back.jpg'); background-repeat: no-repeat; background-attachment: fixed; background-size: 100% 100%;">
    <form id="frmReceipt" runat="server">
        <div class="Lobster-BlodItalic FontSizeHeading AlignCenter">
            Mota Vadala Gau Seva Rahat Trust
        </div>
        <br />
        <br />
        <div class="PlayBoldText FontSizeNormalHeavy AlignCenter">
            Donation Reciept
        </div>

        <div style="position: absolute; top: auto; margin: 0; left: 50%; transform: translate(-50%, 0%);">
            <div class="DIVCenterHorizental">
                <asp:HyperLink runat="server" ID="hlTest" NavigateUrl="https://www.nexuscomputer.in" Target="_blank" Text="">

                </asp:HyperLink>
                <script>
                    function ClickLink() {
                        document.getElementById('hlTest').click();
                    }
                </script>
                <br />
                <br />
                <asp:Label runat="server" ID="lblMessage" Text="" Width="300px" CssClass=" AlignLeft PlayBoldText RedForeColor FontSizeMediumNormal"></asp:Label>
                <br />
                <br />
                <asp:Label runat="server" ID="lblUserID" Text="User ID :" CssClass=" AlignLeft PlayBoldText FontSizeMediumNormal"></asp:Label>
                <br />
                <br />
                <asp:Label runat="server" ID="lblUsername" Text="User Name :" CssClass=" AlignLeft PlayBoldText FontSizeMediumNormal"></asp:Label>
                <br />
                <br />
                <asp:Label runat="server" ID="lblDate" Text="Select Receipt Date :" CssClass=" AlignLeft PlayBoldText FontSizeMediumNormal"></asp:Label>
                <br />
                <br />
                <asp:TextBox runat="server" ID="txtDate" TextMode="Date" Width="300px" Height="40px" CssClass="RoundCornerWithBorder PlayText FontSizeNormal" oninput="this.value = this.value.toUpperCase()"></asp:TextBox>
                <br />
                <br />
                <asp:Label runat="server" ID="lblTitle" Text="Title :" CssClass=" AlignLeft PlayBoldText FontSizeMediumNormal"></asp:Label>
                <br />
                <asp:DropDownList ID="DDLTitle" runat="server" Width="100%" Height="45px" CssClass="RoundCornerWithBorder PlayText FontSizeNormal">
                    <asp:ListItem Value="">Please Select Title</asp:ListItem>
                    <asp:ListItem>SHRIMAN</asp:ListItem>
                    <asp:ListItem>SHRI</asp:ListItem>
                    <asp:ListItem>SHRIMATI</asp:ListItem>
                    <asp:ListItem>MR.</asp:ListItem>
                    <asp:ListItem>MRS.</asp:ListItem>
                    <asp:ListItem>M/S.</asp:ListItem>
                    <asp:ListItem>MASTER</asp:ListItem>
                    <asp:ListItem>MISS.</asp:ListItem>
                </asp:DropDownList>
                <br />
                <br />
                <asp:Label runat="server" ID="lblDonorName" Text="Name :" CssClass=" AlignLeft PlayBoldText FontSizeMediumNormal"></asp:Label>
                <br />
                <asp:TextBox runat="server" ID="txtDonorName" Width="300px" Height="40px" CssClass="RoundCornerWithBorder PlayText FontSizeNormal" oninput="this.value = this.value.toUpperCase()" ></asp:TextBox>
                <br />
                <br />
                <asp:Label runat="server" ID="lblDonorAddress" Text="Address :" CssClass="PlayBoldText FontSizeMediumNormal"></asp:Label>
                <br />
                <asp:TextBox runat="server" ID="txtDonorAddress" TextMode="MultiLine" Width="300px" Height="150px" CssClass="RoundCornerWithBorder PlayText FontSizeNormal" oninput="this.value = this.value.toUpperCase()"></asp:TextBox>
                <br />
                <br />
                <asp:Label runat="server" ID="lblMobileNumber" Text="Mobile (Whatsapp) :" CssClass="PlayBoldText FontSizeMediumNormal"></asp:Label>
                <br />
                <asp:TextBox runat="server" ID="txtMobileNumber" Width="240px" Height="40px" MaxLength="10" CssClass="RoundCornerWithBorder PlayText FontSizeNormal" oninput="this.value = this.value.toUpperCase()"></asp:TextBox>
                <asp:Button runat="server" ID="btnGetData" Width ="50px" Text="?" class="btn PlayBoldText"></asp:Button>
                <br />
                <br />
                <asp:Label runat="server" ID="lblDonorEmail" Text="Email :" CssClass="PlayBoldText FontSizeMediumNormal"></asp:Label>
                <br />
                <asp:TextBox runat="server" ID="txtDonorEmail" Width="300px" Height="40px" CssClass="RoundCornerWithBorder PlayText FontSizeNormal" oninput="this.value = this.value.toUpperCase()"></asp:TextBox>
                <br />
                <br />
                <asp:Label runat="server" ID="lblAmount" Text="Amount :" CssClass="PlayBoldText FontSizeMediumNormal"></asp:Label>
                <br />
                <asp:TextBox runat="server" ID="txtAmount" Width="300px" Height="40px" CssClass="RoundCornerWithBorder PlayText FontSizeNormal" oninput="this.value = this.value.toUpperCase()"></asp:TextBox>
                <br />
                <br />


                <asp:Label runat="server" ID="lblDocumentType" Text="Document Type :" CssClass="PlayBoldText FontSizeMediumNormal"></asp:Label>
                <br />
                <asp:DropDownList ID="DDLDocumentType" runat="server" Width="100%" Height="45px" CssClass="RoundCornerWithBorder PlayText FontSizeNormal" onchange="DisableDocumentNumber()" >
                    <asp:ListItem Value="">Select Document Type</asp:ListItem>
                    <asp:ListItem>1 - PAN CARD</asp:ListItem>
                    <asp:ListItem>2 - AADHAAR CARD</asp:ListItem>
                    <asp:ListItem>4 - PASSPORT</asp:ListItem>
                    <asp:ListItem>6 - DRIVING LICENSE</asp:ListItem>
                    <asp:ListItem>0 - WITHOUT DOCUMENT</asp:ListItem>
                </asp:DropDownList>
                <br />
                <br />
                <asp:Label runat="server" ID="lblDocumentNumber" Text="Document Number :" CssClass="PlayBoldText FontSizeMediumNormal"></asp:Label>
                <br />
                <asp:TextBox runat="server" ID="txtDocumentNumber" Width="300px" Height="40px" CssClass="RoundCornerWithBorder PlayText FontSizeNormal" oninput="this.value = this.value.toUpperCase()"></asp:TextBox>
                <br />
                <br />
                <asp:Label runat="server" ID="lblDonationType" Text="Donation Towards :" CssClass="PlayBoldText FontSizeMediumNormal"></asp:Label>
                <br />
                <asp:DropDownList ID="DDLDonationType" runat="server" Width="100%" Height="45px" CssClass="RoundCornerWithBorder PlayText FontSizeNormal">
                    <asp:ListItem Value="">Select Donation Type</asp:ListItem>
                    <asp:ListItem>JIVDAYA</asp:ListItem>
                    <asp:ListItem>GRASS</asp:ListItem>
                    <asp:ListItem>ANIMAL WELFARE</asp:ListItem>
                    <asp:ListItem>RELIEF OF ANIMALS</asp:ListItem>
                    <asp:ListItem>CORPUS</asp:ListItem>
                    <asp:ListItem>GRANTS</asp:ListItem>
                </asp:DropDownList>
                <br />
                <br />
                <asp:Label runat="server" ID="lblModeofDonation" Text="Mode of Donation :" CssClass="PlayBoldText FontSizeMediumNormal"></asp:Label>
                <br />
                <asp:DropDownList ID="DDLModeOfDonation" runat="server" Width="100%" Height="45px" CssClass="RoundCornerWithBorder PlayText FontSizeNormal" onchange="DisableTransectionNumber()" >
                    <asp:ListItem Value="">Select Mode of Donation</asp:ListItem>
                    <asp:ListItem>CASH</asp:ListItem>
                    <asp:ListItem>IMPS</asp:ListItem>
                    <asp:ListItem>UPI</asp:ListItem>
                    <asp:ListItem>NEFT</asp:ListItem>
                    <asp:ListItem>CHEQUE</asp:ListItem>
                    <asp:ListItem>RTGS</asp:ListItem>
                    <asp:ListItem>FUND TRANSFER</asp:ListItem>
                </asp:DropDownList>
                <br />
                <br />
                <asp:Label runat="server" ID="lblTransectionChaqueNumber" Text="Transection / Chaque Number :" CssClass="PlayBoldText FontSizeMediumNormal"></asp:Label>
                <br />
                <asp:TextBox runat="server" ID="txtTransectionChaqueNumber" Width="300px" Height="40px" CssClass="RoundCornerWithBorder PlayText FontSizeNormal" oninput="this.value = this.value.toUpperCase()"></asp:TextBox>
                <br />
                <br />
                <asp:Label runat="server" ID="lblPaymentDate" Text="Payment Date :" CssClass="PlayBoldText FontSizeMediumNormal"></asp:Label>
                <br />
                <asp:TextBox runat="server" ID="txtPaymentDate" TextMode="Date" Width="300px" Height="40px" CssClass="RoundCornerWithBorder PlayText FontSizeNormal" oninput="this.value = this.value.toUpperCase()" ></asp:TextBox>
                <br />
                <br />
                <asp:Label runat="server" ID="lblBankName" Text="Bank Name :" CssClass="PlayBoldText FontSizeMediumNormal"></asp:Label>
                <br />
                <asp:TextBox runat="server" ID="txtBankName" Width="300px" Height="40px"  CssClass="RoundCornerWithBorder PlayText FontSizeNormal" oninput="this.value = this.value.toUpperCase()"></asp:TextBox>
                <br />
                <br />
                <asp:Label runat="server" ID="lblBranchName" Text="Branch Name :" CssClass="PlayBoldText FontSizeMediumNormal"></asp:Label>
                <br />
                <asp:TextBox runat="server" ID="txtBranchName" Width="300px" Height="40px"  CssClass="RoundCornerWithBorder PlayText FontSizeNormal" oninput="this.value = this.value.toUpperCase()"></asp:TextBox>
                <br />
                <br />

                <asp:Label runat="server" ID="lblDetail" Text="Detail / વિગત :" CssClass="PlayBoldText FontSizeMediumNormal"></asp:Label>
                <br />
                <asp:TextBox runat="server" ID="txtDetail" TextMode="MultiLine" Width="300px"  Height="100px" CssClass="RoundCornerWithBorder PlayText FontSizeNormal" oninput="this.value = this.value.toUpperCase()"></asp:TextBox>
                <br />
                <br />

                <asp:Label runat="server" ID="lblBySupport" Text="By Support / હસ્તે :" CssClass="PlayBoldText FontSizeMediumNormal"></asp:Label>
                <br />
                <asp:TextBox runat="server" ID="txtBySupport" TextMode="MultiLine" Width="300px"  Height="60px" CssClass="RoundCornerWithBorder PlayText FontSizeNormal" oninput="this.value = this.value.toUpperCase()"></asp:TextBox>
                <br />
                <br />
                <div class="AlignCenter">

                    <asp:Button runat="server" ID="btnSubmit" Text="Submit" Width="100%" class="btn Lobster-BlodItalic"></asp:Button>

                </div>
                <br />
                <br />
                <div class="AlignCenter">

                    <asp:Button runat="server" ID="btnReset" Text="Reset" Width="100%" class="btn Lobster-BlodItalic"></asp:Button>

                </div>
                <br />
                <br />

                <div class="AlignCenter">

                    <asp:Button runat="server" ID="btnViewOldReceipt" Text="View Old Receipt" Width="100%" class="btn Lobster-BlodItalic"></asp:Button>

                </div>
                <br />
                <br />
                 <div class="AlignCenter">

                    <asp:Button runat="server" ID="btnBack" Text="Back to Admin Menu" Width="100%" class="btn Lobster-BlodItalic"></asp:Button>

                </div>
                <br />
                <br />

            </div>
        </div>

        <script type="text/javascript">

            function DisableDocumentNumber(DDLDocumentType) {
                var value = document.getElementById("<%=DDLDocumentType.ClientID%>");
                var getvalue = value.options[value.selectedIndex].value;  
                var gettext = value.options[value.selectedIndex].text;  

                //alert("value:-" + " " + getvalue + " " + "Text:-" + " " + gettext);  
                var txtDocumentNumber = document.getElementById('txtDocumentNumber');

                if (gettext == "1 - PAN CARD") {
                    txtDocumentNumber.disabled = false;
                    txtDocumentNumber.setAttribute('maxlength',10);
                    //alert(txtDocumentNumber.disabled);
                   // alert("Found");
                   // return false;
                }

                 if (gettext == "2 - AADHAAR CARD") {
                    txtDocumentNumber.disabled = false;
                    txtDocumentNumber.setAttribute('maxlength',12);
                    //alert(txtDocumentNumber.disabled);
                    //alert("Found");
                   // return false;
                }

                if (gettext == "4 - PASSPORT") {
                    txtDocumentNumber.disabled = false;
                    txtDocumentNumber.setAttribute('maxlength',255);
                    //alert(txtDocumentNumber.disabled);
                    //alert("Found");
                   // return false;
                }

                 if (gettext == "6 - DRIVING LICENSE") {
                    txtDocumentNumber.disabled = false;
                    txtDocumentNumber.setAttribute('maxlength',255);
                    //alert(txtDocumentNumber.disabled);
                    //alert("Found");
                   // return false;
                }

                if (gettext == "0 - WITHOUT DOCUMENT") {
                    txtDocumentNumber.disabled = true;
                    //alert(txtDocumentNumber.disabled);
                    //alert("Found");
                    //return false;
                }
               
                else {
                    txtDocumentNumber.disabled = false;
                    //alert(DDLDocumentType.selectedIndex);
                    //return false;
                }
                                

            }

             function DisableTransectionNumber(DDLModeOfDonation) {
                var value = document.getElementById("<%=DDLModeOfDonation.ClientID%>");
                var getvalue = value.options[value.selectedIndex].value;  
                var gettext = value.options[value.selectedIndex].text;  

               //alert("value:-" + " " + getvalue + " " + "Text:-" + " " + gettext);  
                 var txtTransectionChaqueNumber = document.getElementById('txtTransectionChaqueNumber');
                 var txtBankName = document.getElementById('txtBankName');
                 var txtBranchName = document.getElementById('txtBranchName');

                 if (gettext == "CASH") {
                     txtTransectionChaqueNumber.disabled = true;
                     txtBankName.disabled = true;
                     txtBranchName.disabled = true;
                     //alert(txtTransectionChaqueNumber.disabled);
                     //alert("Found");
                     return false;
                 }
                 else {
                     //alert(txtTransectionChaqueNumber.disabled);
                     txtTransectionChaqueNumber.disabled = false;
                     txtBankName.disabled = false;
                     txtBranchName.disabled = false;
                     //alert(DDLDocumentType.selectedIndex);
                     return false;
                 }
            }

        </script>

    </form>
</body>
</html>

