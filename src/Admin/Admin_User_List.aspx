<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Admin_User_List.aspx.vb" Inherits="Admin_User_List" %>

<%@ Register assembly="DevExpress.Web.v24.1, Version=24.1.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    
    
    <link href="\CSS\aos.css" rel="stylesheet" type="text/css" />
    <link href="\CSS\Button.css" rel="stylesheet" type="text/css" />
    <link href="\CSS\Color.css" rel="stylesheet" type="text/css" />
    <link href="\CSS\Font.css" rel="stylesheet" type="text/css" />
    <link href="\CSS\Main.css" rel="stylesheet" type="text/css" />
    
    <title>User list</title>

</head>

<body style=" background-image: url('../../../Images/Back.jpg'); background-repeat: no-repeat; background-attachment: fixed; background-size: 100% 100%;">
    
    <form id="frmUserList" runat="server">

        <div class="Lobster-BlodItalic FontSizeHeading AlignCenter">
            Mota Vadala Gau Seva Rahat Trust
        </div>
        <br />
        <br />
        <div class="PlayBoldText FontSizeNormalHeavy AlignCenter">
            User List
        </div>
         <br />
        <br />
        <div>
            <asp:Label runat="server" ID="lblMessage" Text="" CssClass="AlignLeft PlayBoldText FontSizeMediumNormal RedForeColor"></asp:Label>
        </div>

        <div>

            <dx:ASPxGridView ID="ASPxGridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" KeyFieldName="UID" Width="100%" Theme="RedWine">
                <Settings ShowFilterBar="Visible" ShowFilterRow="True" ShowGroupPanel="True" ShowHeaderFilterButton="True" ShowFooter="True" />
                <SettingsDataSecurity AllowInsert="False" />
                <SettingsPopup>
                    <FilterControl AutoUpdatePosition="False"></FilterControl>
                </SettingsPopup>
                <EditFormLayoutProperties ColCount="2" ColumnCount="2">
                    <Items>
                        <dx:GridViewColumnLayoutItem ColSpan="1" ColumnName="ContactPersonName">
                        </dx:GridViewColumnLayoutItem>
                        <dx:GridViewColumnLayoutItem ColSpan="1" ColumnName="Mobile">
                        </dx:GridViewColumnLayoutItem>
                        <dx:GridViewColumnLayoutItem ColSpan="1" ColumnName="Address">
                        </dx:GridViewColumnLayoutItem>
                        <dx:GridViewColumnLayoutItem ColSpan="1" ColumnName="City">
                        </dx:GridViewColumnLayoutItem>
                        <dx:GridViewColumnLayoutItem ColSpan="1" ColumnName="Pincode">
                        </dx:GridViewColumnLayoutItem>
                        <dx:GridViewColumnLayoutItem ColSpan="1" ColumnName="State">
                        </dx:GridViewColumnLayoutItem>
                        <dx:GridViewColumnLayoutItem ColSpan="1" ColumnName="Country">
                        </dx:GridViewColumnLayoutItem>
                        <dx:GridViewColumnLayoutItem ColSpan="1" ColumnName="Email">
                        </dx:GridViewColumnLayoutItem>
                        <dx:GridViewColumnLayoutItem ColSpan="1" ColumnName="Remarks">
                        </dx:GridViewColumnLayoutItem>
                        <dx:GridViewColumnLayoutItem ColSpan="1" ColumnName="UserName">
                        </dx:GridViewColumnLayoutItem>
                        <dx:GridViewColumnLayoutItem ColSpan="1" ColumnName="Password">
                        </dx:GridViewColumnLayoutItem>
                        <dx:GridViewColumnLayoutItem ColSpan="1" ColumnName="Activated">
                        </dx:GridViewColumnLayoutItem>
                        <dx:GridViewColumnLayoutItem ColSpan="1" ColumnName="UserRole">
                        </dx:GridViewColumnLayoutItem>
                        <dx:EditModeCommandLayoutItem ColSpan="2" ColumnSpan="2" HorizontalAlign="Right">
                        </dx:EditModeCommandLayoutItem>
                    </Items>
                </EditFormLayoutProperties>
                <Columns>
                    <dx:GridViewCommandColumn ShowEditButton="True" VisibleIndex="0" ButtonRenderMode="Button">
                        <HeaderStyle CssClass="PlayBoldText FontSizeMedium" />
                        <CellStyle CssClass="PlayText FontSizeMedium">
                        </CellStyle>
                        <FooterCellStyle CssClass="PlayText FontSizeMedium">
                        </FooterCellStyle>
                    </dx:GridViewCommandColumn>
                    <dx:GridViewDataTextColumn FieldName="UID" ReadOnly="True" VisibleIndex="1">
                        <EditFormSettings Visible="False" />
                        <EditCellStyle CssClass="PlayText FontSizeMedium">
                        </EditCellStyle>
                        <HeaderStyle CssClass="PlayBoldText FontSizeMedium" />
                        <CellStyle CssClass="PlayText FontSizeMedium">
                        </CellStyle>
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="ContactPersonName" VisibleIndex="2">
                        <EditCellStyle CssClass="PlayText FontSizeMedium">
                        </EditCellStyle>
                        <HeaderStyle CssClass="PlayBoldText FontSizeMedium" />
                        <CellStyle CssClass="PlayText FontSizeMedium">
                        </CellStyle>
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="Mobile" VisibleIndex="3">
                        <EditCellStyle CssClass="PlayText FontSizeMedium">
                        </EditCellStyle>
                        <HeaderStyle CssClass="PlayBoldText FontSizeMedium" />
                        <CellStyle CssClass="PlayText FontSizeMedium">
                        </CellStyle>
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="Address" VisibleIndex="4">
                        <EditCellStyle CssClass="PlayText FontSizeMedium">
                        </EditCellStyle>
                        <HeaderStyle CssClass="PlayBoldText FontSizeMedium" />
                        <CellStyle CssClass="PlayText FontSizeMedium">
                        </CellStyle>
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="City" VisibleIndex="5">
                        <EditCellStyle CssClass="PlayText FontSizeMedium">
                        </EditCellStyle>
                        <HeaderStyle CssClass="PlayBoldText FontSizeMedium" />
                        <CellStyle CssClass="PlayText FontSizeMedium">
                        </CellStyle>
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="Pincode" VisibleIndex="6">
                        <EditCellStyle CssClass="PlayText FontSizeMedium">
                        </EditCellStyle>
                        <HeaderStyle CssClass="PlayBoldText FontSizeMedium" />
                        <CellStyle CssClass="PlayText FontSizeMedium">
                        </CellStyle>
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="State" VisibleIndex="7">
                        <EditCellStyle CssClass="PlayText FontSizeMedium">
                        </EditCellStyle>
                        <HeaderStyle CssClass="PlayBoldText FontSizeMedium" />
                        <CellStyle CssClass="PlayText FontSizeMedium">
                        </CellStyle>
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="Country" VisibleIndex="8">
                        <EditCellStyle CssClass="PlayText FontSizeMedium">
                        </EditCellStyle>
                        <HeaderStyle CssClass="PlayBoldText FontSizeMedium" />
                        <CellStyle CssClass="PlayText FontSizeMedium">
                        </CellStyle>
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="Email" VisibleIndex="9">
                        <EditCellStyle CssClass="PlayText FontSizeMedium">
                        </EditCellStyle>
                        <HeaderStyle CssClass="PlayBoldText FontSizeMedium" />
                        <CellStyle CssClass="PlayText FontSizeMedium">
                        </CellStyle>
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="Remarks" VisibleIndex="10">
                        <EditCellStyle CssClass="PlayText FontSizeMedium">
                        </EditCellStyle>
                        <HeaderStyle CssClass="PlayBoldText FontSizeMedium" />
                        <CellStyle CssClass="PlayText FontSizeMedium">
                        </CellStyle>
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="UserName" VisibleIndex="11">
                        <EditCellStyle CssClass="PlayText FontSizeMedium">
                        </EditCellStyle>
                        <HeaderStyle CssClass="PlayBoldText FontSizeMedium" />
                        <CellStyle CssClass="PlayText FontSizeMedium">
                        </CellStyle>
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="Password" VisibleIndex="12">
                        <EditCellStyle CssClass="PlayText FontSizeMedium">
                        </EditCellStyle>
                        <HeaderStyle CssClass="PlayBoldText FontSizeMedium" />
                        <CellStyle CssClass="PlayText FontSizeMedium">
                        </CellStyle>
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataComboBoxColumn FieldName="Activated" UnboundType="String" VisibleIndex="13">
                        <PropertiesComboBox>
                            <Items>
                                <dx:ListEditItem Text="YES" Value="YES" />
                                <dx:ListEditItem Text="NO" Value="NO" />
                            </Items>
                        </PropertiesComboBox>
                        <EditCellStyle CssClass="PlayText FontSizeMedium">
                        </EditCellStyle>
                        <HeaderStyle CssClass="PlayBoldText FontSizeMedium" />
                        <CellStyle CssClass="PlayText FontSizeMedium">
                        </CellStyle>
                    </dx:GridViewDataComboBoxColumn>
                    <dx:GridViewDataComboBoxColumn FieldName="UserRole" UnboundType="String" VisibleIndex="14">
                        <PropertiesComboBox>
                            <Items>
                                <dx:ListEditItem Text="RBU" Value="RBU" />
                                <dx:ListEditItem Text="ADMIN" Value="ADMIN" />
                            </Items>
                        </PropertiesComboBox>
                        <EditCellStyle CssClass="PlayText FontSizeMedium">
                        </EditCellStyle>
                        <HeaderStyle CssClass="PlayBoldText FontSizeMedium" />
                        <CellStyle CssClass="PlayText FontSizeMedium">
                        </CellStyle>
                    </dx:GridViewDataComboBoxColumn>
                </Columns>
                <TotalSummary>
                    <dx:ASPxSummaryItem FieldName="UID" SummaryType="Count" />
                </TotalSummary>
                <SettingsDetail ExportMode="All" />
                <SettingsExport EnableClientSideExportAPI="true" ExcelExportMode="WYSIWYG" Landscape="true" SplitDataCellAcrossPages="false" LeftMargin="25" RightMargin="25" TopMargin="25" BottomMargin="25" PaperKind="A4" />
            </dx:ASPxGridView>
            <dx:ASPxGridViewExporter ID="ASPxGridViewExporter1" runat="server"
                GridViewID="ASPxGridView1">
            </dx:ASPxGridViewExporter>

            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:MotaVadala_MSSQL_ConnectionString %>" DeleteCommand="DELETE FROM [UserData] WHERE [UID] = @UID" InsertCommand="INSERT INTO [UserData] ([ContactPersonName], [Mobile], [Address], [City], [Pincode], [State], [Country], [Email], [Remarks], [UserName], [Password], [Activated], [UserRole]) VALUES (@ContactPersonName, @Mobile, @Address, @City, @Pincode, @State, @Country, @Email, @Remarks, @UserName, @Password, @Activated, @UserRole)" SelectCommand="SELECT * FROM [UserData] ORDER BY [UID]" UpdateCommand="UPDATE [UserData] SET [ContactPersonName] = @ContactPersonName, [Mobile] = @Mobile, [Address] = @Address, [City] = @City, [Pincode] = @Pincode, [State] = @State, [Country] = @Country, [Email] = @Email, [Remarks] = @Remarks, [UserName] = @UserName, [Password] = @Password, [Activated] = @Activated, [UserRole] = @UserRole WHERE [UID] = @UID">
                <DeleteParameters>
                    <asp:Parameter Name="UID" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="ContactPersonName" Type="String" />
                    <asp:Parameter Name="Mobile" Type="String" />
                    <asp:Parameter Name="Address" Type="String" />
                    <asp:Parameter Name="City" Type="String" />
                    <asp:Parameter Name="Pincode" Type="String" />
                    <asp:Parameter Name="State" Type="String" />
                    <asp:Parameter Name="Country" Type="String" />
                    <asp:Parameter Name="Email" Type="String" />
                    <asp:Parameter Name="Remarks" Type="String" />
                    <asp:Parameter Name="UserName" Type="String" />
                    <asp:Parameter Name="Password" Type="String" />
                    <asp:Parameter Name="Activated" Type="String" />
                    <asp:Parameter Name="UserRole" Type="String" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="ContactPersonName" Type="String" />
                    <asp:Parameter Name="Mobile" Type="String" />
                    <asp:Parameter Name="Address" Type="String" />
                    <asp:Parameter Name="City" Type="String" />
                    <asp:Parameter Name="Pincode" Type="String" />
                    <asp:Parameter Name="State" Type="String" />
                    <asp:Parameter Name="Country" Type="String" />
                    <asp:Parameter Name="Email" Type="String" />
                    <asp:Parameter Name="Remarks" Type="String" />
                    <asp:Parameter Name="UserName" Type="String" />
                    <asp:Parameter Name="Password" Type="String" />
                    <asp:Parameter Name="Activated" Type="String" />
                    <asp:Parameter Name="UserRole" Type="String" />
                    <asp:Parameter Name="UID" Type="Int32" />
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
                    <asp:Button runat="server" ID="btnBak" Text="Back to Admin Menu" class="btn Lobster-BlodItalic DIVCenterHorizental"></asp:Button>
                    <br />
                    <br />

                </div>

            </div>

        </div>

    </form>
</body>
</html>
