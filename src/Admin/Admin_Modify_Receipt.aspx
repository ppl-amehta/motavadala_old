<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Admin_Modify_Receipt.aspx.vb" Inherits="Admin_Modify_Receipt" %>

<%@ Register assembly="DevExpress.Web.v24.1, Version=24.1.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>


<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    
    <link href="\CSS\aos.css" rel="stylesheet" type="text/css" />
    <link href="\CSS\Button.css" rel="stylesheet" type="text/css" />
    <link href="\CSS\Color.css" rel="stylesheet" type="text/css" />
    <link href="\CSS\Font.css" rel="stylesheet" type="text/css" />
    <link href="\CSS\Main.css" rel="stylesheet" type="text/css" />
    
    <title>Modify Receipt</title>

</head>

<body style=" background-image: url('../../../Images/Back.jpg'); background-repeat: no-repeat; background-attachment: fixed; background-size: 100% 100%;">
    
    <form id="frmModifyReceipt" runat="server">

        <div class="Lobster-BlodItalic FontSizeHeading AlignCenter">
            Mota Vadala Gau Seva Rahat Trust
        </div>
        <br />
        <br />
        <div class="PlayBoldText FontSizeNormalHeavy AlignCenter">
            Modify Old Receipt
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

            <dx:ASPxGridView ID="ASPxGridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1"  KeyFieldName="UID" Width="100%" Theme="RedWine">
                <Settings ShowFilterRow="True" ShowFilterRowMenu="True" ShowHeaderFilterButton="True" ShowFooter="True" ShowGroupPanel="True" ShowFilterBar="Visible"></Settings>

                <SettingsDataSecurity AllowInsert="False" AllowEdit="true" AllowDelete="False"></SettingsDataSecurity>
                <SettingsPopup>
                    <FilterControl AutoUpdatePosition="False"></FilterControl>
                </SettingsPopup>
                <EditFormLayoutProperties ColCount="3" ColumnCount="3">
                    <Items>
                        <dx:GridViewColumnLayoutItem ColSpan="1" ColumnName="Title">
                        </dx:GridViewColumnLayoutItem>
                        <dx:GridViewColumnLayoutItem ColSpan="1" ColumnName="DonorName">
                        </dx:GridViewColumnLayoutItem>
                        <dx:GridViewColumnLayoutItem ColSpan="1" ColumnName="DonorAddress">
                        </dx:GridViewColumnLayoutItem>
                        <dx:GridViewColumnLayoutItem ColSpan="1" ColumnName="DonorMobile">
                        </dx:GridViewColumnLayoutItem>
                        <dx:GridViewColumnLayoutItem ColSpan="1" ColumnName="DonorEmail">
                        </dx:GridViewColumnLayoutItem>
                        <dx:GridViewColumnLayoutItem ColSpan="1" ColumnName="DonationAmount">
                        </dx:GridViewColumnLayoutItem>
                        <dx:GridViewColumnLayoutItem ColSpan="1" ColumnName="DocumentType">
                        </dx:GridViewColumnLayoutItem>
                        <dx:GridViewColumnLayoutItem ColSpan="1" ColumnName="DocumentNumber">
                        </dx:GridViewColumnLayoutItem>
                        <dx:GridViewColumnLayoutItem ColSpan="1" ColumnName="DonationType">
                        </dx:GridViewColumnLayoutItem>
                        <dx:GridViewColumnLayoutItem ColSpan="1" ColumnName="ModeOfDonation">
                        </dx:GridViewColumnLayoutItem>
                        <dx:GridViewColumnLayoutItem ColSpan="1" ColumnName="TransectionChaqueNumber">
                        </dx:GridViewColumnLayoutItem>
                        <dx:GridViewColumnLayoutItem ColSpan="1" ColumnName="PaymentDate">
                        </dx:GridViewColumnLayoutItem>
                        <dx:GridViewColumnLayoutItem ColSpan="1" ColumnName="BankName">
                        </dx:GridViewColumnLayoutItem>
                        <dx:GridViewColumnLayoutItem ColSpan="1" ColumnName="BranchName">
                        </dx:GridViewColumnLayoutItem>
                         <dx:GridViewColumnLayoutItem ColSpan="1" ColumnName="Details">
                        </dx:GridViewColumnLayoutItem>
                         <dx:GridViewColumnLayoutItem ColSpan="1" ColumnName="BySupport">
                        </dx:GridViewColumnLayoutItem>
                         <dx:GridViewColumnLayoutItem ColSpan="1" ColumnName="CashDepositBank" Caption="Cash/Cheque Deposit in Bank">
                        </dx:GridViewColumnLayoutItem>
                        <dx:EditModeCommandLayoutItem ColSpan="3" ColumnSpan="3" HorizontalAlign="Left">
                        </dx:EditModeCommandLayoutItem>
                    </Items>
                </EditFormLayoutProperties>

                <SettingsCommandButton>
                    <EditButton>
                        <Image ToolTip="Edit" Width="24px" Height="24px" Url="../../../Images/edit.png" />
                    </EditButton>
                    <UpdateButton RenderMode="Image">
                        <Image ToolTip="Save changes and close Edit Form" Url="../../../Images/update.png" />
                    </UpdateButton>
                    <CancelButton RenderMode="Image">
                        <Image ToolTip="Close Edit Form without saving changes" Url="../../../Images/cancel.png" />
                    </CancelButton>
                </SettingsCommandButton>

                <Columns>
                    <dx:GridViewCommandColumn ShowEditButton="True" VisibleIndex="0" ButtonRenderMode="Image">
                        <CustomButtons>
                            <dx:GridViewCommandColumnCustomButton ID="DOWNLOAD" Image-Width="24px" Image-Height="24px">
                                <Image ToolTip="Create New PDF And Download PDF" Url="../../../Images/PDF_Download.jpg" />
                            </dx:GridViewCommandColumnCustomButton>
                            <dx:GridViewCommandColumnCustomButton ID="Email" Image-Width="24px" Image-Height="24px">
                                <Image ToolTip="Create New PDF And Send Email" Url="../../../Images/Email.png" />
                            </dx:GridViewCommandColumnCustomButton>
                            <dx:GridViewCommandColumnCustomButton ID="Whatsapp" Image-Width="24px" Image-Height="24px">
                                <Image ToolTip="Send Whatsapp Message" Url="../../../Images/Whatsapp.png" />
                            </dx:GridViewCommandColumnCustomButton>
                            <dx:GridViewCommandColumnCustomButton ID="CancelReceipt" Image-Width="24px" Image-Height="24px">
                                <Image ToolTip="Cancel Receipt" Url="../../../Images/Cancel_Receipt.png" />
                            </dx:GridViewCommandColumnCustomButton>
                        </CustomButtons>

                      <%--  <HeaderStyle CssClass="PlayBoldText FontSizeMedium" />
                        <CellStyle CssClass="PlayText FontSizeMedium">
                        </CellStyle>
                        <FooterCellStyle CssClass="PlayText FontSizeMedium">
                        </FooterCellStyle>--%>
                    </dx:GridViewCommandColumn>
                    <dx:GridViewDataTextColumn FieldName="UID" ReadOnly="True" Visible="false" VisibleIndex="1">
                        <EditFormSettings Visible="False" />
                        <EditCellStyle CssClass="PlayText FontSizeMedium">
                        </EditCellStyle>
                        <HeaderStyle CssClass="PlayBoldText FontSizeMedium" />
                        <CellStyle CssClass="PlayText FontSizeMedium">
                        </CellStyle>
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="UserDataMasterID" ReadOnly="True" Visible="false" VisibleIndex="2">
                        <EditFormSettings Visible="False" />
                        <EditCellStyle CssClass="PlayText FontSizeMedium">
                        </EditCellStyle>
                        <HeaderStyle CssClass="PlayBoldText FontSizeMedium" />
                        <CellStyle CssClass="PlayText FontSizeMedium">
                        </CellStyle>
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="UserName" ReadOnly="True" VisibleIndex="3">
                        <EditFormSettings Visible="False" />
                        <EditCellStyle CssClass="PlayText FontSizeMedium">
                        </EditCellStyle>
                        <HeaderStyle CssClass="PlayBoldText FontSizeMedium" />
                        <CellStyle CssClass="PlayText FontSizeMedium">
                        </CellStyle>
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataDateColumn FieldName="ReceiptDate" VisibleIndex="4">
                        <EditFormSettings Visible="False" />
                        <EditCellStyle CssClass="PlayText FontSizeMedium">
                        </EditCellStyle>
                        <HeaderStyle CssClass="PlayBoldText FontSizeMedium" />
                        <CellStyle CssClass="PlayText FontSizeMedium">
                        </CellStyle>
                    </dx:GridViewDataDateColumn>
                       <dx:GridViewDataDateColumn FieldName="ReceiptTime" VisibleIndex="5">
                        <EditFormSettings Visible="False" />
                        <EditCellStyle CssClass="PlayText FontSizeMedium">
                        </EditCellStyle>
                        <HeaderStyle CssClass="PlayBoldText FontSizeMedium" />
                        <CellStyle CssClass="PlayText FontSizeMedium">
                        </CellStyle>
                    </dx:GridViewDataDateColumn>
                    <dx:GridViewDataTextColumn FieldName="ReceiptNumber" VisibleIndex="6">
                        <EditFormSettings Visible="False" />
                        <EditCellStyle CssClass="PlayText FontSizeMedium">
                        </EditCellStyle>
                        <HeaderStyle CssClass="PlayBoldText FontSizeMedium" />
                        <CellStyle CssClass="PlayText FontSizeMedium">
                        </CellStyle>
                    </dx:GridViewDataTextColumn>
 					<dx:GridViewDataComboBoxColumn FieldName="Title" UnboundType="String" VisibleIndex="7">
                        <PropertiesComboBox>
                            <Items>
                                <dx:ListEditItem Text="" Value="" />
                                <dx:ListEditItem Text="SHREE" Value="SHREE" />
                                <dx:ListEditItem Text="SHREEMATI" Value="SHREEMATI" />
                                <dx:ListEditItem Text="MR." Value="MR." />
                                <dx:ListEditItem Text="MRS." Value="MRS." />
                                <dx:ListEditItem Text="M/S." Value="M/S." />
                                <dx:ListEditItem Text="MASTER" Value="MASTER" />
                                <dx:ListEditItem Text="MISS." Value="MISS." />
                            </Items>
                        </PropertiesComboBox>
                        <EditCellStyle CssClass="PlayText FontSizeMedium">
                        </EditCellStyle>
                        <HeaderStyle CssClass="PlayBoldText FontSizeMedium" />
                        <CellStyle CssClass="PlayText FontSizeMedium">
                        </CellStyle>
                    </dx:GridViewDataComboBoxColumn>
                    <dx:GridViewDataTextColumn FieldName="DonorName" VisibleIndex="8">
                        <EditCellStyle CssClass="PlayText FontSizeMedium">
                        </EditCellStyle>
                        <HeaderStyle CssClass="PlayBoldText FontSizeMedium" />
                        <CellStyle CssClass="PlayText FontSizeMedium">
                        </CellStyle>
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="DonorAddress" VisibleIndex="9">
                        <EditCellStyle CssClass="PlayText FontSizeMedium">
                        </EditCellStyle>
                        <HeaderStyle CssClass="PlayBoldText FontSizeMedium" />
                        <CellStyle CssClass="PlayText FontSizeMedium">
                        </CellStyle>
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="DonorMobile" VisibleIndex="10">
                        <EditCellStyle CssClass="PlayText FontSizeMedium">
                        </EditCellStyle>
                        <HeaderStyle CssClass="PlayBoldText FontSizeMedium" />
                        <CellStyle CssClass="PlayText FontSizeMedium">
                        </CellStyle>
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="DonorEmail" VisibleIndex="11">
                        <EditCellStyle CssClass="PlayText FontSizeMedium">
                        </EditCellStyle>
                        <HeaderStyle CssClass="PlayBoldText FontSizeMedium" />
                        <CellStyle CssClass="PlayText FontSizeMedium">
                        </CellStyle>
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="DonationAmount" VisibleIndex="12">
                        <EditCellStyle CssClass="PlayText FontSizeMedium">
                        </EditCellStyle>
                        <HeaderStyle CssClass="PlayBoldText FontSizeMedium" />
                        <CellStyle CssClass="PlayText FontSizeMedium">
                        </CellStyle>
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataComboBoxColumn FieldName="DocumentType" UnboundType="String" VisibleIndex="13">
                        <PropertiesComboBox>
                            <Items>
                                <dx:ListEditItem Text="" Value="" />
                                <dx:ListEditItem Text="1 - PAN CARD" Value="1 - PAN CARD" />
                                <dx:ListEditItem Text="2 - AADHAAR CARD" Value="2 - AADHAAR CARD" />
                                <dx:ListEditItem Text="4 - PASSPORT" Value="4 - PASSPORT" />
                                <dx:ListEditItem Text="6 - DRIVING LICENSE" Value="6 - DRIVING LICENSE" />
                                <dx:ListEditItem Text="0 - WITHOUT DOCUMENT" Value="0 - WITHOUT DOCUMENT" />
                            </Items>
                        </PropertiesComboBox>
                        <EditCellStyle CssClass="PlayText FontSizeMedium">
                        </EditCellStyle>
                        <HeaderStyle CssClass="PlayBoldText FontSizeMedium" />
                        <CellStyle CssClass="PlayText FontSizeMedium">
                        </CellStyle>
                    </dx:GridViewDataComboBoxColumn>
                    <dx:GridViewDataTextColumn FieldName="DocumentNumber" VisibleIndex="14">
                        <EditCellStyle CssClass="PlayText FontSizeMedium">
                        </EditCellStyle>
                        <HeaderStyle CssClass="PlayBoldText FontSizeMedium" />
                        <CellStyle CssClass="PlayText FontSizeMedium">
                        </CellStyle>
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataComboBoxColumn FieldName="DonationType" UnboundType="String" VisibleIndex="15">
                        <PropertiesComboBox>
                            <Items>
                                <dx:ListEditItem Text="" Value="" />
                                <dx:ListEditItem Text="JIVDAYA" Value="JIVDAYA" />
                                <dx:ListEditItem Text="GRASS" Value="GRASS" />
                                <dx:ListEditItem Text="ANIMAL WELFARE" Value="ANIMAL WELFARE" />
                                <dx:ListEditItem Text="RELIEF OF ANIMALS" Value="RELIEF OF ANIMALS" />
                                <dx:ListEditItem Text="CORPUS" Value="CORPUS" />
                                <dx:ListEditItem Text="GRANTS" Value="GRANTS" />
                                <dx:ListEditItem Text="ADOPTION OF ANIMALS" Value="GRANTS" />
                            </Items>
                        </PropertiesComboBox>
                        <EditCellStyle CssClass="PlayText FontSizeMedium">
                        </EditCellStyle>
                        <HeaderStyle CssClass="PlayBoldText FontSizeMedium" />
                        <CellStyle CssClass="PlayText FontSizeMedium">
                        </CellStyle>
                    </dx:GridViewDataComboBoxColumn>

                    <dx:GridViewDataComboBoxColumn FieldName="ModeOfDonation" UnboundType="String" VisibleIndex="16">
                        <PropertiesComboBox>
                            <Items>
                                <dx:ListEditItem Text="" Value="" />
                                <dx:ListEditItem Text="CASH" Value="CASH" />
                                <dx:ListEditItem Text="IMPS" Value="IMPS" />
                                <dx:ListEditItem Text="UPI" Value="UPI" />
                                <dx:ListEditItem Text="NEFT" Value="NEFT" />
                                <dx:ListEditItem Text="CHEQUE" Value="CHEQUE" />
                                <dx:ListEditItem Text="RTGS" Value="RTGS" />
                                <dx:ListEditItem Text="FUND TRANSFER" Value="FUND TRANSFER" />
                            </Items>
                        </PropertiesComboBox>
                        <EditCellStyle CssClass="PlayText FontSizeMedium">
                        </EditCellStyle>
                        <HeaderStyle CssClass="PlayBoldText FontSizeMedium" />
                        <CellStyle CssClass="PlayText FontSizeMedium">
                        </CellStyle>
                    </dx:GridViewDataComboBoxColumn>
                    <dx:GridViewDataTextColumn FieldName="TransectionChaqueNumber" VisibleIndex="17">
                        <EditCellStyle CssClass="PlayText FontSizeMedium">
                        </EditCellStyle>
                        <HeaderStyle CssClass="PlayBoldText FontSizeMedium" />
                        <CellStyle CssClass="PlayText FontSizeMedium">
                        </CellStyle>
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataDateColumn FieldName="PaymentDate" VisibleIndex="18">
                        <EditCellStyle CssClass="PlayText FontSizeMedium">
                        </EditCellStyle>
                        <HeaderStyle CssClass="PlayBoldText FontSizeMedium" />
                        <CellStyle CssClass="PlayText FontSizeMedium">
                        </CellStyle>
                    </dx:GridViewDataDateColumn>
                    <dx:GridViewDataTextColumn FieldName="BankName" VisibleIndex="19">
                        <EditCellStyle CssClass="PlayText FontSizeMedium">
                        </EditCellStyle>
                        <HeaderStyle CssClass="PlayBoldText FontSizeMedium" />
                        <CellStyle CssClass="PlayText FontSizeMedium">
                        </CellStyle>
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="BranchName" VisibleIndex="20">
                        <EditCellStyle CssClass="PlayText FontSizeMedium">
                        </EditCellStyle>
                        <HeaderStyle CssClass="PlayBoldText FontSizeMedium" />
                        <CellStyle CssClass="PlayText FontSizeMedium">
                        </CellStyle>
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="Details" VisibleIndex="21">
                        <EditCellStyle CssClass="PlayText FontSizeMedium">
                        </EditCellStyle>
                        <HeaderStyle CssClass="PlayBoldText FontSizeMedium" />
                        <CellStyle CssClass="PlayText FontSizeMedium">
                        </CellStyle>
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="BySupport" VisibleIndex="22" Caption="Support By">
                        <EditCellStyle CssClass="PlayText FontSizeMedium">
                        </EditCellStyle>
                        <HeaderStyle CssClass="PlayBoldText FontSizeMedium" />
                        <CellStyle CssClass="PlayText FontSizeMedium">
                        </CellStyle>
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataDateColumn FieldName="CashDepositBank" VisibleIndex="23" Caption="Cash/Cheque Deposit in Bank">
                        <EditCellStyle CssClass="PlayText FontSizeMedium">
                        </EditCellStyle>
                        <HeaderStyle CssClass="PlayBoldText FontSizeMedium" />
                        <CellStyle CssClass="PlayText FontSizeMedium">
                        </CellStyle>
                    </dx:GridViewDataDateColumn>
                    <dx:GridViewDataTextColumn FieldName="DELETED" VisibleIndex="24"></dx:GridViewDataTextColumn>
                    
                </Columns>
                <TotalSummary>
                    <dx:ASPxSummaryItem SummaryType="Count" FieldName="ReceiptNumber"></dx:ASPxSummaryItem>
                    <dx:ASPxSummaryItem SummaryType="Sum" FieldName="DonationAmount"></dx:ASPxSummaryItem>
                </TotalSummary>
                <FormatConditions>
                    <dx:GridViewFormatConditionHighlight ApplyToRow="True" Expression="[DELETED] Is Not Null" Format="Custom" FieldName="DELETED">
                        <RowStyle BackColor="Red" Font-Bold="True" Font-Strikeout="True" ForeColor="White"></RowStyle>
                    </dx:GridViewFormatConditionHighlight>
                </FormatConditions>
            </dx:ASPxGridView>

            <asp:SqlDataSource runat="server" ID="SqlDataSource1" ConflictDetection="CompareAllValues" ConnectionString='<%$ ConnectionStrings:MotaVadala_MSSQL_ConnectionString %>' DeleteCommand="DELETE FROM [2022_2023] WHERE [UID] = @original_UID AND (([UserDataMasterID] = @original_UserDataMasterID) OR ([UserDataMasterID] IS NULL AND @original_UserDataMasterID IS NULL)) AND (([UserName] = @original_UserName) OR ([UserName] IS NULL AND @original_UserName IS NULL)) AND (([ReceiptDate] = @original_ReceiptDate) OR ([ReceiptDate] IS NULL AND @original_ReceiptDate IS NULL)) AND (([ReceiptTime] = @original_ReceiptTime) OR ([ReceiptTime] IS NULL AND @original_ReceiptTime IS NULL)) AND (([ReceiptNumber] = @original_ReceiptNumber) OR ([ReceiptNumber] IS NULL AND @original_ReceiptNumber IS NULL)) AND (([Title] = @original_Title) OR ([Title] IS NULL AND @original_Title IS NULL)) AND (([DonorName] = @original_DonorName) OR ([DonorName] IS NULL AND @original_DonorName IS NULL)) AND (([DonorAddress] = @original_DonorAddress) OR ([DonorAddress] IS NULL AND @original_DonorAddress IS NULL)) AND (([DonorMobile] = @original_DonorMobile) OR ([DonorMobile] IS NULL AND @original_DonorMobile IS NULL)) AND (([DonorEmail] = @original_DonorEmail) OR ([DonorEmail] IS NULL AND @original_DonorEmail IS NULL)) AND (([DonationAmount] = @original_DonationAmount) OR ([DonationAmount] IS NULL AND @original_DonationAmount IS NULL)) AND (([DocumentType] = @original_DocumentType) OR ([DocumentType] IS NULL AND @original_DocumentType IS NULL)) AND (([DocumentNumber] = @original_DocumentNumber) OR ([DocumentNumber] IS NULL AND @original_DocumentNumber IS NULL)) AND (([DonationType] = @original_DonationType) OR ([DonationType] IS NULL AND @original_DonationType IS NULL)) AND (([ModeOfDonation] = @original_ModeOfDonation) OR ([ModeOfDonation] IS NULL AND @original_ModeOfDonation IS NULL)) AND (([TransectionChaqueNumber] = @original_TransectionChaqueNumber) OR ([TransectionChaqueNumber] IS NULL AND @original_TransectionChaqueNumber IS NULL)) AND (([PaymentDate] = @original_PaymentDate) OR ([PaymentDate] IS NULL AND @original_PaymentDate IS NULL)) AND (([BankName] = @original_BankName) OR ([BankName] IS NULL AND @original_BankName IS NULL)) AND (([BranchName] = @original_BranchName) OR ([BranchName] IS NULL AND @original_BranchName IS NULL)) AND (([Details] = @original_Details) OR ([Details] IS NULL AND @original_Details IS NULL)) AND (([BySupport] = @original_BySupport) OR ([BySupport] IS NULL AND @original_BySupport IS NULL)) AND (([CashDepositBank] = @original_CashDepositBank) OR ([CashDepositBank] IS NULL AND @original_CashDepositBank IS NULL)) AND (([DELETED] = @original_DELETED) OR ([DELETED] IS NULL AND @original_DELETED IS NULL))" InsertCommand="INSERT INTO [2022_2023] ([UID], [UserDataMasterID], [UserName], [ReceiptDate], [ReceiptTime], [ReceiptNumber], [Title], [DonorName], [DonorAddress], [DonorMobile], [DonorEmail], [DonationAmount], [DocumentType], [DocumentNumber], [DonationType], [ModeOfDonation], [TransectionChaqueNumber], [PaymentDate], [BankName], [BranchName], [Details], [BySupport], [CashDepositBank], [DELETED]) VALUES (@UID, @UserDataMasterID, @UserName, @ReceiptDate, @ReceiptTime, @ReceiptNumber, @Title, @DonorName, @DonorAddress, @DonorMobile, @DonorEmail, @DonationAmount, @DocumentType, @DocumentNumber, @DonationType, @ModeOfDonation, @TransectionChaqueNumber, @PaymentDate, @BankName, @BranchName, @Details, @BySupport, @CashDepositBank, @DELETED)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [2022_2023]" UpdateCommand="UPDATE [2022_2023] SET [UserDataMasterID] = @UserDataMasterID, [UserName] = @UserName, [ReceiptDate] = @ReceiptDate, [ReceiptTime] = @ReceiptTime, [ReceiptNumber] = @ReceiptNumber, [Title] = @Title, [DonorName] = @DonorName, [DonorAddress] = @DonorAddress, [DonorMobile] = @DonorMobile, [DonorEmail] = @DonorEmail, [DonationAmount] = @DonationAmount, [DocumentType] = @DocumentType, [DocumentNumber] = @DocumentNumber, [DonationType] = @DonationType, [ModeOfDonation] = @ModeOfDonation, [TransectionChaqueNumber] = @TransectionChaqueNumber, [PaymentDate] = @PaymentDate, [BankName] = @BankName, [BranchName] = @BranchName, [Details] = @Details, [BySupport] = @BySupport, [CashDepositBank] = @CashDepositBank, [DELETED] = @DELETED WHERE [UID] = @original_UID AND (([UserDataMasterID] = @original_UserDataMasterID) OR ([UserDataMasterID] IS NULL AND @original_UserDataMasterID IS NULL)) AND (([UserName] = @original_UserName) OR ([UserName] IS NULL AND @original_UserName IS NULL)) AND (([ReceiptDate] = @original_ReceiptDate) OR ([ReceiptDate] IS NULL AND @original_ReceiptDate IS NULL)) AND (([ReceiptTime] = @original_ReceiptTime) OR ([ReceiptTime] IS NULL AND @original_ReceiptTime IS NULL)) AND (([ReceiptNumber] = @original_ReceiptNumber) OR ([ReceiptNumber] IS NULL AND @original_ReceiptNumber IS NULL)) AND (([Title] = @original_Title) OR ([Title] IS NULL AND @original_Title IS NULL)) AND (([DonorName] = @original_DonorName) OR ([DonorName] IS NULL AND @original_DonorName IS NULL)) AND (([DonorAddress] = @original_DonorAddress) OR ([DonorAddress] IS NULL AND @original_DonorAddress IS NULL)) AND (([DonorMobile] = @original_DonorMobile) OR ([DonorMobile] IS NULL AND @original_DonorMobile IS NULL)) AND (([DonorEmail] = @original_DonorEmail) OR ([DonorEmail] IS NULL AND @original_DonorEmail IS NULL)) AND (([DonationAmount] = @original_DonationAmount) OR ([DonationAmount] IS NULL AND @original_DonationAmount IS NULL)) AND (([DocumentType] = @original_DocumentType) OR ([DocumentType] IS NULL AND @original_DocumentType IS NULL)) AND (([DocumentNumber] = @original_DocumentNumber) OR ([DocumentNumber] IS NULL AND @original_DocumentNumber IS NULL)) AND (([DonationType] = @original_DonationType) OR ([DonationType] IS NULL AND @original_DonationType IS NULL)) AND (([ModeOfDonation] = @original_ModeOfDonation) OR ([ModeOfDonation] IS NULL AND @original_ModeOfDonation IS NULL)) AND (([TransectionChaqueNumber] = @original_TransectionChaqueNumber) OR ([TransectionChaqueNumber] IS NULL AND @original_TransectionChaqueNumber IS NULL)) AND (([PaymentDate] = @original_PaymentDate) OR ([PaymentDate] IS NULL AND @original_PaymentDate IS NULL)) AND (([BankName] = @original_BankName) OR ([BankName] IS NULL AND @original_BankName IS NULL)) AND (([BranchName] = @original_BranchName) OR ([BranchName] IS NULL AND @original_BranchName IS NULL)) AND (([Details] = @original_Details) OR ([Details] IS NULL AND @original_Details IS NULL)) AND (([BySupport] = @original_BySupport) OR ([BySupport] IS NULL AND @original_BySupport IS NULL)) AND (([CashDepositBank] = @original_CashDepositBank) OR ([CashDepositBank] IS NULL AND @original_CashDepositBank IS NULL)) AND (([DELETED] = @original_DELETED) OR ([DELETED] IS NULL AND @original_DELETED IS NULL))">
                <DeleteParameters>
                    <asp:Parameter Name="original_UID" Type="Int32"></asp:Parameter>
                    <asp:Parameter Name="original_UserDataMasterID" Type="Int32"></asp:Parameter>
                    <asp:Parameter Name="original_UserName" Type="String"></asp:Parameter>
                    <asp:Parameter Name="original_ReceiptDate" DbType="Date"></asp:Parameter>
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
                    <asp:Parameter Name="ReceiptDate" DbType="Date"></asp:Parameter>
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
                <UpdateParameters>
                    <asp:Parameter Name="UserDataMasterID" Type="Int32"></asp:Parameter>
                    <asp:Parameter Name="UserName" Type="String"></asp:Parameter>
                    <asp:Parameter Name="ReceiptDate" DbType="Date"></asp:Parameter>
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
                    <asp:Parameter Name="original_PaymentDate" DbType="Date"></asp:Parameter>
                    <asp:Parameter Name="original_BankName" Type="String"></asp:Parameter>
                    <asp:Parameter Name="original_BranchName" Type="String"></asp:Parameter>
                    <asp:Parameter Name="original_Details" Type="String"></asp:Parameter>
                    <asp:Parameter Name="original_BySupport" Type="String"></asp:Parameter>
                    <asp:Parameter Name="original_CashDepositBank" DbType="Date"></asp:Parameter>
                    <asp:Parameter Name="original_DELETED" Type="String"></asp:Parameter>
                </UpdateParameters>
            </asp:SqlDataSource>
        </div>
        <div style="position: absolute; top: auto; margin: 0; left: 50%; transform: translate(-50%, 0%);">

            <div class="DIVCenterHorizental">

                <div>

                    <br />
                    <br />
                    <asp:Button runat="server" ID="btnExport2PDF" Text="Export Data in PDF Format" class="btn Lobster-BlodItalic"></asp:Button>

                </div>

                <div>

                    <br />
                    <br />
                    <asp:Button runat="server" ID="btnExport2Excel" Text="Export Data in Excel Format" class="btn Lobster-BlodItalic"></asp:Button>

                </div>
                <div>

                    <br />
                    <br />
                    <asp:Button runat="server" ID="btnBack" Text="Back to Admin Menu" class="btn Lobster-BlodItalic DIVCenterHorizental"></asp:Button>
                    <br />
                    <br />

                </div>

            </div>

        </div>

    </form>
</body>
</html>
