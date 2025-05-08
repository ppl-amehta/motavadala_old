<%@ Page Language="VB" AutoEventWireup="false" CodeFile="ViewOldReceipt.aspx.vb" Inherits="ViewOldReceipt" %>

<%@ Register assembly="DevExpress.Web.v24.1, Version=24.1.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    
     <link href="CSS\aos.css" rel="stylesheet" type="text/css" />
    <link href="CSS\Button.css" rel="stylesheet" type="text/css" />
    <link href="CSS\Color.css" rel="stylesheet" type="text/css" />
    <link href="CSS\Font.css" rel="stylesheet" type="text/css" />
    <link href="CSS\Main.css" rel="stylesheet" type="text/css" />
    <title>Old Receipt</title>
</head>
<body style="background-size: 100% 100%; background-image: url('../../Images/Back.jpg'); background-repeat: no-repeat; background-attachment: fixed">
    
    <form id="frmViewOldReceipt" runat="server">

       <div class="Lobster-BlodItalic FontSizeHeading AlignCenter">
            Mota Vadala Gau Seva Rahat Trust
        </div>
        <br />
        <br />
        <div class="PlayBoldText FontSizeNormalHeavy AlignCenter">
            
             <asp:Label runat="server" ID="lblUser" Text="Old Reciept's By :" CssClass="AlignLeft PlayBoldText FontSizeNormalHeavy RedForeColor"></asp:Label>
        </div>
        <br />
        <br />

        <div>
            <asp:Label runat="server" ID="lblMessage" Text="" CssClass="AlignLeft PlayBoldText FontSizeMediumNormal RedForeColor"></asp:Label>
        </div>

        <div>
            <asp:DropDownList ID="DDLYear" runat="server" Width="350px" Height="45px" CssClass="RoundCornerWithBorder PlayText FontSizeNormal">
                <asp:ListItem Value="">Please Select Financial Year</asp:ListItem>
                <asp:ListItem>2022_2023</asp:ListItem>
                <asp:ListItem>2023_2024</asp:ListItem>
                <asp:ListItem>2024_2025</asp:ListItem>
                <asp:ListItem>2025_2026</asp:ListItem>
            </asp:DropDownList>

            <asp:Button runat="server" ID="btnLoadData" Text="Load Data" class="btn Lobster-BlodItalic"></asp:Button>
        </div>

        <div>

            <dx:ASPxGridView ID="ASPxGridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" KeyFieldName="UID" Width="100%" Theme="RedWine">
                <Settings ShowFilterBar="Visible" ShowFilterRow="True" ShowGroupPanel="True" ShowHeaderFilterButton="True" ShowFooter="True" />
                <SettingsDataSecurity AllowInsert="False" AllowEdit="true" AllowDelete="False" />
                <SettingsPopup>
                    <FilterControl AutoUpdatePosition="False"></FilterControl>
                </SettingsPopup>
                <EditFormLayoutProperties ColCount="2" ColumnCount="2">
                    <Items>
                       <dx:GridViewColumnLayoutItem ColSpan="1" ColumnName="CashDepositBank" Caption="Cash/Cheque Deposit in Bank" Width="600px">
                        </dx:GridViewColumnLayoutItem>
                        <dx:EditModeCommandLayoutItem ColSpan="2" ColumnSpan="2" HorizontalAlign="Left">
                        </dx:EditModeCommandLayoutItem>
                    </Items>
                </EditFormLayoutProperties>
                
                <SettingsCommandButton>
                    <EditButton>
                        <Image ToolTip="Edit" Width="24px" Height="24px" Url="../Images/edit.png" />
                    </EditButton>
                    <UpdateButton RenderMode="Image">
                        <Image ToolTip="Save changes and close Edit Form" Url="../Images/update.png" />
                    </UpdateButton>
                    <CancelButton RenderMode="Image">
                        <Image ToolTip="Close Edit Form without saving changes" Url="../Images/cancel.png" />
                    </CancelButton>
                </SettingsCommandButton>

                <Columns>
                    <dx:GridViewCommandColumn VisibleIndex="0" ShowEditButton="True"  ButtonRenderMode="Image">
                         <CustomButtons>
                            <dx:GridViewCommandColumnCustomButton ID="DOWNLOAD" Image-Width="24px" Image-Height="24px">
                                <Image ToolTip="Create New PDF And Download PDF" Url="../Images/PDF_Download.jpg" />
                            </dx:GridViewCommandColumnCustomButton>
                        </CustomButtons>

                    </dx:GridViewCommandColumn>
                    <dx:GridViewDataTextColumn FieldName="UID" ReadOnly="True" VisibleIndex="1" Visible="False">
                        <HeaderStyle Font-Bold="True" Font-Names="Play" Font-Size="Medium" />
                    </dx:GridViewDataTextColumn> 
                    <dx:GridViewDataTextColumn FieldName="UserDataMasterID" VisibleIndex="2" Visible="False">
                        <HeaderStyle Font-Bold="True" Font-Names="Play" Font-Size="Medium" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="ReceiptNumber" VisibleIndex="4">
                        <HeaderStyle Font-Bold="True" Font-Names="Play" Font-Size="Medium" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataDateColumn FieldName="ReceiptDate" VisibleIndex="5">
                        <HeaderStyle Font-Bold="True" Font-Names="Play" Font-Size="Medium" />
                    </dx:GridViewDataDateColumn>
                    <dx:GridViewDataTextColumn FieldName="ReceiptTime" VisibleIndex="6">
                        <HeaderStyle Font-Bold="True" Font-Names="Play" Font-Size="Medium" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="Title" VisibleIndex="7">
                        <HeaderStyle Font-Bold="True" Font-Names="Play" Font-Size="Medium" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="DonorName" VisibleIndex="8">
                        <HeaderStyle Font-Bold="True" Font-Names="Play" Font-Size="Medium" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="DonorAddress" VisibleIndex="9">
                        <HeaderStyle Font-Bold="True" Font-Names="Play" Font-Size="Medium" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="DonorMobile" VisibleIndex="10">
                        <HeaderStyle Font-Bold="True" Font-Names="Play" Font-Size="Medium" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="DonorEmail" VisibleIndex="11">
                        <HeaderStyle Font-Bold="True" Font-Names="Play" Font-Size="Medium" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="DonationAmount" VisibleIndex="12">
                        <HeaderStyle Font-Bold="True" Font-Names="Play" Font-Size="Medium" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="DocumentType" VisibleIndex="13">
                        <HeaderStyle Font-Bold="True" Font-Names="Play" Font-Size="Medium" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="DocumentNumber" VisibleIndex="14">
                        <HeaderStyle Font-Bold="True" Font-Names="Play" Font-Size="Medium" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="DonationType" VisibleIndex="15">
                        <HeaderStyle Font-Bold="True" Font-Names="Play" Font-Size="Medium" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="ModeOfDonation" VisibleIndex="16">
                        <HeaderStyle Font-Bold="True" Font-Names="Play" Font-Size="Medium" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="TransectionChaqueNumber" VisibleIndex="17">
                        <HeaderStyle Font-Bold="True" Font-Names="Play" Font-Size="Medium" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataDateColumn FieldName="PaymentDate" VisibleIndex="18">
                        <HeaderStyle Font-Bold="True" Font-Names="Play" Font-Size="Medium" />
                    </dx:GridViewDataDateColumn>
                    <dx:GridViewDataTextColumn FieldName="BankName" VisibleIndex="19">
                        <HeaderStyle Font-Bold="True" Font-Names="Play" Font-Size="Medium" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="BranchName" VisibleIndex="20">
                        <HeaderStyle Font-Bold="True" Font-Names="Play" Font-Size="Medium" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="Details" VisibleIndex="21">
                        <HeaderStyle Font-Bold="True" Font-Names="Play" Font-Size="Medium" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="BySupport" VisibleIndex="22" Caption="SupportBy">
                        <HeaderStyle Font-Bold="True" Font-Names="Play" Font-Size="Medium" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataDateColumn FieldName="CashDepositBank" VisibleIndex="23" Caption="Cash/Cheque Deposit in Bank">
                        <EditFormSettings Caption="Cash/Cheque Deposit in Bank"></EditFormSettings>

                        <HeaderStyle Font-Bold="True" Font-Names="Play" Font-Size="Medium" />
                    </dx:GridViewDataDateColumn>

                    <dx:GridViewDataTextColumn FieldName="UserName" Visible="False" VisibleIndex="3">
                        <HeaderStyle Font-Bold="True" Font-Names="Play" Font-Size="Medium" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="DELETED" Visible="False" VisibleIndex="24">
                        <HeaderStyle Font-Bold="True" Font-Names="Play" Font-Size="Medium" />
                    </dx:GridViewDataTextColumn>
                </Columns>
                <TotalSummary>
                    <dx:ASPxSummaryItem FieldName="UID" SummaryType="Count" />
                    <dx:ASPxSummaryItem SummaryType="Sum" FieldName="DonationAmount"></dx:ASPxSummaryItem>
                </TotalSummary>
                <SettingsDetail ExportMode="All" />
                <SettingsExport EnableClientSideExportAPI="true" ExcelExportMode="WYSIWYG" Landscape="true" SplitDataCellAcrossPages="false" LeftMargin="25" RightMargin="25" TopMargin="25" BottomMargin="25" PaperKind="A4" />
            </dx:ASPxGridView>
            <dx:ASPxGridViewExporter ID="ASPxGridViewExporter1" runat="server"
                GridViewID="ASPxGridView1">
            </dx:ASPxGridViewExporter>

            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:MotaVadala_MSSQL_ConnectionString %>" 
                SelectCommand="SELECT * FROM [2022_2023] WHERE ([UserDataMasterID] = @UserDataMasterID)" 
                ConflictDetection="CompareAllValues" 
                DeleteCommand="DELETE FROM [2022_2023] WHERE [UID] = @original_UID AND (([UserDataMasterID] = @original_UserDataMasterID) OR ([UserDataMasterID] IS NULL AND @original_UserDataMasterID IS NULL)) AND (([UserName] = @original_UserName) OR ([UserName] IS NULL AND @original_UserName IS NULL)) AND (([ReceiptDate] = @original_ReceiptDate) OR ([ReceiptDate] IS NULL AND @original_ReceiptDate IS NULL)) AND (([ReceiptTime] = @original_ReceiptTime) OR ([ReceiptTime] IS NULL AND @original_ReceiptTime IS NULL)) AND (([ReceiptNumber] = @original_ReceiptNumber) OR ([ReceiptNumber] IS NULL AND @original_ReceiptNumber IS NULL)) AND (([Title] = @original_Title) OR ([Title] IS NULL AND @original_Title IS NULL)) AND (([DonorName] = @original_DonorName) OR ([DonorName] IS NULL AND @original_DonorName IS NULL)) AND (([DonorAddress] = @original_DonorAddress) OR ([DonorAddress] IS NULL AND @original_DonorAddress IS NULL)) AND (([DonorMobile] = @original_DonorMobile) OR ([DonorMobile] IS NULL AND @original_DonorMobile IS NULL)) AND (([DonorEmail] = @original_DonorEmail) OR ([DonorEmail] IS NULL AND @original_DonorEmail IS NULL)) AND (([DonationAmount] = @original_DonationAmount) OR ([DonationAmount] IS NULL AND @original_DonationAmount IS NULL)) AND (([DocumentType] = @original_DocumentType) OR ([DocumentType] IS NULL AND @original_DocumentType IS NULL)) AND (([DocumentNumber] = @original_DocumentNumber) OR ([DocumentNumber] IS NULL AND @original_DocumentNumber IS NULL)) AND (([DonationType] = @original_DonationType) OR ([DonationType] IS NULL AND @original_DonationType IS NULL)) AND (([ModeOfDonation] = @original_ModeOfDonation) OR ([ModeOfDonation] IS NULL AND @original_ModeOfDonation IS NULL)) AND (([TransectionChaqueNumber] = @original_TransectionChaqueNumber) OR ([TransectionChaqueNumber] IS NULL AND @original_TransectionChaqueNumber IS NULL)) AND (([PaymentDate] = @original_PaymentDate) OR ([PaymentDate] IS NULL AND @original_PaymentDate IS NULL)) AND (([BankName] = @original_BankName) OR ([BankName] IS NULL AND @original_BankName IS NULL)) AND (([BranchName] = @original_BranchName) OR ([BranchName] IS NULL AND @original_BranchName IS NULL)) AND (([Details] = @original_Details) OR ([Details] IS NULL AND @original_Details IS NULL)) AND (([BySupport] = @original_BySupport) OR ([BySupport] IS NULL AND @original_BySupport IS NULL)) AND (([CashDepositBank] = @original_CashDepositBank) OR ([CashDepositBank] IS NULL AND @original_CashDepositBank IS NULL)) AND (([DELETED] = @original_DELETED) OR ([DELETED] IS NULL AND @original_DELETED IS NULL))" 
                InsertCommand="INSERT INTO [2022_2023] ([UID], [UserDataMasterID], [UserName], [ReceiptDate], [ReceiptTime], [ReceiptNumber], [Title], [DonorName], [DonorAddress], [DonorMobile], [DonorEmail], [DonationAmount], [DocumentType], [DocumentNumber], [DonationType], [ModeOfDonation], [TransectionChaqueNumber], [PaymentDate], [BankName], [BranchName], [Details], [BySupport], [CashDepositBank], [DELETED]) VALUES (@UID, @UserDataMasterID, @UserName, @ReceiptDate, @ReceiptTime, @ReceiptNumber, @Title, @DonorName, @DonorAddress, @DonorMobile, @DonorEmail, @DonationAmount, @DocumentType, @DocumentNumber, @DonationType, @ModeOfDonation, @TransectionChaqueNumber, @PaymentDate, @BankName, @BranchName, @Details, @BySupport, @CashDepositBank, @DELETED)" 
                OldValuesParameterFormatString="original_{0}" 
                UpdateCommand="UPDATE [2022_2023] SET [UserDataMasterID] = @UserDataMasterID, [UserName] = @UserName, [ReceiptDate] = @ReceiptDate, [ReceiptTime] = @ReceiptTime, [ReceiptNumber] = @ReceiptNumber, [Title] = @Title, [DonorName] = @DonorName, [DonorAddress] = @DonorAddress, [DonorMobile] = @DonorMobile, [DonorEmail] = @DonorEmail, [DonationAmount] = @DonationAmount, [DocumentType] = @DocumentType, [DocumentNumber] = @DocumentNumber, [DonationType] = @DonationType, [ModeOfDonation] = @ModeOfDonation, [TransectionChaqueNumber] = @TransectionChaqueNumber, [PaymentDate] = @PaymentDate, [BankName] = @BankName, [BranchName] = @BranchName, [Details] = @Details, [BySupport] = @BySupport, [CashDepositBank] = @CashDepositBank, [DELETED] = @DELETED WHERE [UID] = @original_UID ">
                <DeleteParameters>
                    <asp:Parameter Name="original_UID" Type="Int32"></asp:Parameter>
                    <asp:Parameter Name="original_UserDataMasterID" Type="Int32"></asp:Parameter>
                    <asp:Parameter Name="original_UserName" Type="String"></asp:Parameter>
                    <asp:Parameter DbType="Date" Name="original_ReceiptDate"></asp:Parameter>
                    <asp:Parameter Name="original_ReceiptTime" Type="String"></asp:Parameter>
                    <asp:Parameter Name="original_ReceiptNumber" Type="String"></asp:Parameter>
                    <asp:Parameter Name="original_Title" Type="String"></asp:Parameter>
                    <asp:Parameter Name="original_DonorName" Type="String"></asp:Parameter>
                    <asp:Parameter Name="original_DonorAddress" Type="String"></asp:Parameter>
                    <asp:Parameter Name="original_DonorMobile" Type="String"></asp:Parameter>
                    <asp:Parameter Name="original_DonorEmail" Type="String"></asp:Parameter>
                    <asp:Parameter Name="original_DonationAmount" Type="Single"></asp:Parameter>
                    <asp:Parameter Name="original_DocumentType" Type="String"></asp:Parameter>
                    <asp:Parameter Name="original_DocumentNumber" Type="String"></asp:Parameter>
                    <asp:Parameter Name="original_DonationType" Type="String"></asp:Parameter>
                    <asp:Parameter Name="original_ModeOfDonation" Type="String"></asp:Parameter>
                    <asp:Parameter Name="original_TransectionChaqueNumber" Type="String"></asp:Parameter>
                    <asp:Parameter DbType="Date" Name="original_PaymentDate"></asp:Parameter>
                    <asp:Parameter Name="original_BankName" Type="String"></asp:Parameter>
                    <asp:Parameter Name="original_BranchName" Type="String"></asp:Parameter>
                    <asp:Parameter Name="original_Details" Type="String"></asp:Parameter>
                    <asp:Parameter Name="original_BySupport" Type="String"></asp:Parameter>
                    <asp:Parameter Name="original_CashDepositBank" DbType="Date"></asp:Parameter>
                    <asp:Parameter Name="original_DELETED" Type="String"></asp:Parameter>
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="UID" Type="Int32"></asp:Parameter>
                    <asp:Parameter Name="UserDataMasterID" Type="Int32"></asp:Parameter>
                    <asp:Parameter Name="UserName" Type="String"></asp:Parameter>
                    <asp:Parameter DbType="Date" Name="ReceiptDate"></asp:Parameter>
                    <asp:Parameter Name="ReceiptTime" Type="String"></asp:Parameter>
                    <asp:Parameter Name="ReceiptNumber" Type="String"></asp:Parameter>
                    <asp:Parameter Name="Title" Type="String"></asp:Parameter>
                    <asp:Parameter Name="DonorName" Type="String"></asp:Parameter>
                    <asp:Parameter Name="DonorAddress" Type="String"></asp:Parameter>
                    <asp:Parameter Name="DonorMobile" Type="String"></asp:Parameter>
                    <asp:Parameter Name="DonorEmail" Type="String"></asp:Parameter>
                    <asp:Parameter Name="DonationAmount" Type="Single"></asp:Parameter>
                    <asp:Parameter Name="DocumentType" Type="String"></asp:Parameter>
                    <asp:Parameter Name="DocumentNumber" Type="String"></asp:Parameter>
                    <asp:Parameter Name="DonationType" Type="String"></asp:Parameter>
                    <asp:Parameter Name="ModeOfDonation" Type="String"></asp:Parameter>
                    <asp:Parameter Name="TransectionChaqueNumber" Type="String"></asp:Parameter>
                    <asp:Parameter DbType="Date" Name="PaymentDate"></asp:Parameter>
                    <asp:Parameter Name="BankName" Type="String"></asp:Parameter>
                    <asp:Parameter Name="BranchName" Type="String"></asp:Parameter>
                    <asp:Parameter Name="Details" Type="String"></asp:Parameter>
                    <asp:Parameter Name="BySupport" Type="String"></asp:Parameter>
                    <asp:Parameter Name="CashDepositBank" DbType="Date"></asp:Parameter>
                    <asp:Parameter Name="DELETED" Type="String"></asp:Parameter>
                </InsertParameters>
                <SelectParameters>
                    <asp:SessionParameter SessionField="UID" DefaultValue="0" Name="UserDataMasterID" Type="Int32"></asp:SessionParameter>
                </SelectParameters>
                <UpdateParameters>
                    <asp:Parameter Name="UserDataMasterID" Type="Int32"></asp:Parameter>
                    <asp:Parameter Name="UserName" Type="String"></asp:Parameter>
                    <asp:Parameter DbType="Date" Name="ReceiptDate"></asp:Parameter>
                    <asp:Parameter Name="ReceiptTime" Type="String"></asp:Parameter>
                    <asp:Parameter Name="ReceiptNumber" Type="String"></asp:Parameter>
                    <asp:Parameter Name="Title" Type="String"></asp:Parameter>
                    <asp:Parameter Name="DonorName" Type="String"></asp:Parameter>
                    <asp:Parameter Name="DonorAddress" Type="String"></asp:Parameter>
                    <asp:Parameter Name="DonorMobile" Type="String"></asp:Parameter>
                    <asp:Parameter Name="DonorEmail" Type="String"></asp:Parameter>
                    <asp:Parameter Name="DonationAmount" Type="Single"></asp:Parameter>
                    <asp:Parameter Name="DocumentType" Type="String"></asp:Parameter>
                    <asp:Parameter Name="DocumentNumber" Type="String"></asp:Parameter>
                    <asp:Parameter Name="DonationType" Type="String"></asp:Parameter>
                    <asp:Parameter Name="ModeOfDonation" Type="String"></asp:Parameter>
                    <asp:Parameter Name="TransectionChaqueNumber" Type="String"></asp:Parameter>
                    <asp:Parameter DbType="Date" Name="PaymentDate"></asp:Parameter>
                    <asp:Parameter Name="BankName" Type="String"></asp:Parameter>
                    <asp:Parameter Name="BranchName" Type="String"></asp:Parameter>
                    <asp:Parameter Name="Details" Type="String"></asp:Parameter>
                    <asp:Parameter Name="BySupport" Type="String"></asp:Parameter>
                    <asp:Parameter Name="CashDepositBank" DbType="Date"></asp:Parameter>
                    <asp:Parameter Name="DELETED" Type="String"></asp:Parameter>
                    <asp:Parameter Name="original_UID" Type="Int32"></asp:Parameter>
                    <asp:Parameter Name="original_UserDataMasterID" Type="Int32"></asp:Parameter>
                    <asp:Parameter Name="original_UserName" Type="String"></asp:Parameter>
                    <asp:Parameter DbType="Date" Name="original_ReceiptDate"></asp:Parameter>
                    <asp:Parameter Name="original_ReceiptTime" Type="String"></asp:Parameter>
                    <asp:Parameter Name="original_ReceiptNumber" Type="String"></asp:Parameter>
                    <asp:Parameter Name="original_Title" Type="String"></asp:Parameter>
                    <asp:Parameter Name="original_DonorName" Type="String"></asp:Parameter>
                    <asp:Parameter Name="original_DonorAddress" Type="String"></asp:Parameter>
                    <asp:Parameter Name="original_DonorMobile" Type="String"></asp:Parameter>
                    <asp:Parameter Name="original_DonorEmail" Type="String"></asp:Parameter>
                    <asp:Parameter Name="original_DonationAmount" Type="Single"></asp:Parameter>
                    <asp:Parameter Name="original_DocumentType" Type="String"></asp:Parameter>
                    <asp:Parameter Name="original_DocumentNumber" Type="String"></asp:Parameter>
                    <asp:Parameter Name="original_DonationType" Type="String"></asp:Parameter>
                    <asp:Parameter Name="original_ModeOfDonation" Type="String"></asp:Parameter>
                    <asp:Parameter Name="original_TransectionChaqueNumber" Type="String"></asp:Parameter>
                    <asp:Parameter DbType="Date" Name="original_PaymentDate"></asp:Parameter>
                    <asp:Parameter Name="original_BankName" Type="String"></asp:Parameter>
                    <asp:Parameter Name="original_BranchName" Type="String"></asp:Parameter>
                    <asp:Parameter Name="original_Details" Type="String"></asp:Parameter>
                    <asp:Parameter Name="original_BySupport" Type="String"></asp:Parameter>
                    <asp:Parameter Name="original_CashDepositBank" DbType="Date"></asp:Parameter>
                    <asp:Parameter Name="original_DELETED" Type="String"></asp:Parameter>
                </UpdateParameters>
            </asp:SqlDataSource>

        </div>

        <br />
        <br />

        <div class="DIVCenterHorizental">
             <asp:Button runat="server" ID="btnBack" Text="Back" class="btn Lobster-BlodItalic"></asp:Button>
        </div>

    </form>
</body>
</html>