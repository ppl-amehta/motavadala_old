<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Admin_Donation_Register.aspx.vb" Inherits="Admin_Donation_Register" %>

<%@ Register Assembly="DevExpress.Web.v24.1, Version=24.1.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    
    <link href="\CSS\aos.css" rel="stylesheet" type="text/css" />
    <link href="\CSS\Button.css" rel="stylesheet" type="text/css" />
    <link href="\CSS\Color.css" rel="stylesheet" type="text/css" />
    <link href="\CSS\Font.css" rel="stylesheet" type="text/css" />
    <link href="\CSS\Main.css" rel="stylesheet" type="text/css" />

    <title>Donation Register</title>
</head>
<body style=" background-image: url('../../../Images/Back.jpg'); background-repeat: no-repeat; background-attachment: fixed; background-size: 100% 100%;">
  
    <form id="frmDonationRegister" runat="server">
     
        <div class="Lobster-BlodItalic FontSizeHeading AlignCenter">
            Mota Vadala Gau Seva Rahat Trust
        </div>

        <br />
        <br />

        <div class="PlayBoldText FontSizeNormalHeavy AlignCenter">
            Donation Register
        </div>

         <div >
            <div>
                <br />
                <br />
                <asp:Label runat="server" ID="lblMessage" Text="" CssClass=" AlignLeft PlayBoldText FontSizeMediumNormal RedForeColor"></asp:Label>
                <br />
                <br />
                <table>
                    <tr>
                        <th>
                            <asp:Label runat="server" ID="lblFinancialYear" Text="Financial Year" CssClass=" AlignLeft PlayBoldText FontSizeMediumNormal"></asp:Label>
                        </th>
                        <th>
                            <asp:Label runat="server" ID="lblStartDate" Text="Start Date" CssClass=" AlignLeft PlayBoldText FontSizeMediumNormal"></asp:Label>
                        </th>
                        <th>
                            <asp:Label runat="server" ID="lblEndDate" Text="End Date" CssClass=" AlignLeft PlayBoldText FontSizeMediumNormal"></asp:Label>
                        </th>
                        <th>

                        </th>
                    </tr>
                    <tr>
                        <td>
                            <asp:DropDownList ID="DDLYear" runat="server" Width="350px" Height="45px" CssClass="RoundCornerWithBorder PlayText FontSizeNormal">
                                <asp:ListItem Value="">Please Select Financial Year</asp:ListItem>
                                <asp:ListItem>2022_2023</asp:ListItem>
                                <asp:ListItem>2023_2024</asp:ListItem>
                                <asp:ListItem>2024_2025</asp:ListItem>
                                <asp:ListItem>2025_2026</asp:ListItem>
                            </asp:DropDownList>

                        </td>
                        <td>
                            <asp:TextBox runat="server" ID="txtStartDate" TextMode="Date" Width="300px" Height="40px" CssClass="RoundCornerWithBorder PlayText FontSizeNormal" oninput="this.value = this.value.toUpperCase()"></asp:TextBox>
                        </td>
                        <td>
                            <asp:TextBox runat="server" ID="txtEndDate" TextMode="Date" Width="300px" Height="40px" CssClass="RoundCornerWithBorder PlayText FontSizeNormal" oninput="this.value = this.value.toUpperCase()"></asp:TextBox>
                        </td>
                         <td>
                            <asp:Button runat="server" ID="btnLoadData" Text="Load Data" class="btn Lobster-BlodItalic"></asp:Button>
                        </td>

                    </tr>
                    
                </table>

                
                
                <br />
                <br />
                <dx:ASPxGridView ID="ASPxGridView1" runat="server" Width="100%" Theme="RedWine" EnableTheming="True" KeyFieldName="UID" EnableRowsCache="false">
                    <SettingsPager Visible="false" Mode="ShowAllRecords"></SettingsPager>

                    <Settings ShowFilterBar="Visible" ShowFilterRowMenu="True" ShowFooter="True" ShowFilterRow="True" ShowGroupPanel="True" ShowGroupFooter="VisibleIfExpanded" ShowHeaderFilterButton="True"></Settings>

                    <SettingsBehavior AllowSelectByRowClick="True" AllowSelectSingleRowOnly="True" AutoExpandAllGroups="True"></SettingsBehavior>

                    <SettingsDataSecurity AllowEdit="False" AllowInsert="False" AllowDelete="False"></SettingsDataSecurity>

                    <Columns>

                        <dx:GridViewDataTextColumn FieldName="Sr." ReadOnly="True" Visible="true" VisibleIndex="1">
                            <HeaderStyle CssClass="PlayBoldText FontSizeMedium" />
                            <CellStyle CssClass="PlayText FontSizeMedium">
                            </CellStyle>
                        </dx:GridViewDataTextColumn>

                        <dx:GridViewDataTextColumn FieldName="ReceiptDate" ReadOnly="True" Visible="true" VisibleIndex="2">
                            <HeaderStyle CssClass="PlayBoldText FontSizeMedium" />
                            <CellStyle CssClass="PlayText FontSizeMedium">
                            </CellStyle>
                        </dx:GridViewDataTextColumn>

                        <dx:GridViewDataTextColumn FieldName="Receipt Number" ReadOnly="True" Visible="true" VisibleIndex="3">
                            <HeaderStyle CssClass="PlayBoldText FontSizeMedium" />
                            <CellStyle CssClass="PlayText FontSizeMedium">
                            </CellStyle>
                        </dx:GridViewDataTextColumn>
                        
                        <dx:GridViewDataTextColumn FieldName="Donor's Name" ReadOnly="True" Visible="true" VisibleIndex="4">
                            <HeaderStyle CssClass="PlayBoldText FontSizeMedium" />
                            <CellStyle CssClass="PlayText FontSizeMedium">
                            </CellStyle>
                        </dx:GridViewDataTextColumn>

                        <dx:GridViewDataTextColumn FieldName="Amount" ReadOnly="True" Visible="true" VisibleIndex="5">
                            <HeaderStyle CssClass="PlayBoldText FontSizeMedium" />
                            <CellStyle CssClass="PlayText FontSizeMedium">
                            </CellStyle>
                        </dx:GridViewDataTextColumn>

                        <dx:GridViewDataTextColumn FieldName="Cash" ReadOnly="True" Visible="true" VisibleIndex="6">
                            <HeaderStyle CssClass="PlayBoldText FontSizeMedium" />
                            <CellStyle CssClass="PlayText FontSizeMedium">
                            </CellStyle>
                        </dx:GridViewDataTextColumn>
                        
                        <dx:GridViewDataTextColumn FieldName="Chaque/Other" ReadOnly="True" Visible="true" VisibleIndex="7">
                            <HeaderStyle CssClass="PlayBoldText FontSizeMedium" />
                            <CellStyle CssClass="PlayText FontSizeMedium">
                            </CellStyle>
                        </dx:GridViewDataTextColumn>

                        <dx:GridViewDataTextColumn FieldName="Transection Mode" ReadOnly="True" Visible="true" VisibleIndex="8">
                            <HeaderStyle CssClass="PlayBoldText FontSizeMedium" />
                            <CellStyle CssClass="PlayText FontSizeMedium">
                            </CellStyle>
                        </dx:GridViewDataTextColumn>

                    </Columns>
                    <%-- <FormatConditions>
                        <dx:GridViewFormatConditionHighlight ApplyToRow="True" Expression="[DELETED] Is Not Null" Format="Custom" FieldName="DELETED">
                            <RowStyle BackColor="Red" Font-Bold="True" Font-Strikeout="True" ForeColor="White"></RowStyle>
                        </dx:GridViewFormatConditionHighlight>
                    </FormatConditions>--%>
                    <Columns>
                        <dx:GridViewCommandColumn ShowClearFilterButton="True" VisibleIndex="0"></dx:GridViewCommandColumn>
                    </Columns>
                <TotalSummary>
                    <dx:ASPxSummaryItem FieldName="Sr." SummaryType="Count" DisplayFormat="{0}" />
                    <dx:ASPxSummaryItem SummaryType="Sum" FieldName="Amount"></dx:ASPxSummaryItem>
                    <dx:ASPxSummaryItem SummaryType="Sum" FieldName="Cash"></dx:ASPxSummaryItem>
                    <dx:ASPxSummaryItem SummaryType="Sum" FieldName="Cheque/Other"></dx:ASPxSummaryItem>
                </TotalSummary>
                    <GroupSummary>
                        <dx:ASPxSummaryItem SummaryType="Sum" ShowInGroupFooterColumn="Cash"  FieldName="Cash" />
                    </GroupSummary>

                </dx:ASPxGridView>

                <%--<asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString='<%$ ConnectionStrings:MotaVadala_MSSQL_ConnectionString %>' SelectCommand="SELECT * FROM [2022_2023]"></asp:SqlDataSource>--%>
                <br />
                <br />
                <asp:Button runat="server" ID="btnExcel" Text="Export 2 Excel" class="btn Lobster-BlodItalic DIVCenterHorizental"></asp:Button>
                 <br />
                
                   <br />
                <asp:Button runat="server" ID="btnPDF" Text="Export 2 PDF" class="btn Lobster-BlodItalic DIVCenterHorizental"></asp:Button>
                 <br />
                <br />
                  <asp:Button runat="server" ID="btnBack" Text="Back to Report" class="btn Lobster-BlodItalic DIVCenterHorizental"></asp:Button>
            </div>
        </div>

    </form>

</body>
</html>