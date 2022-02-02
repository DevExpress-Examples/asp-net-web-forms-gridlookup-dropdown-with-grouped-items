<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SingleColumn.aspx.cs" Inherits="DXWebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
        <style>
        .groupRow {
            font-weight: bold;
            color: black;
            background-color: lightgreen;
        }

        .dataRow td.dxgvIndentCell {
            display: none;
        }
    </style>
    <script>
        var timeout = 0;
        function OnKeyPress(s, e) {

            var keyCode = ASPxClientUtils.GetKeyCode(e.htmlEvent);

            if (keyCode == 13)
                return;

            s.ShowDropDown();

            if (timeout) {
                clearTimeout(timeout);
            }

            timeout = setTimeout(function () {
                var filter = s.GetInputElement().value;

                if (keyCode == 37 || keyCode == 38 || keyCode == 39 || keyCode == 40) {
                    return;
                }

                s.GetGridView().ApplySearchPanelFilter(filter)

            }, 500);
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
         <dx:ASPxGridLookup ID="gridLookup" runat="server" KeyFieldName="ContactId"  Width="300px" ClientInstanceName="gridLookup" TextFormatString="{0}" IncrementalFilteringMode="None" OnInit="gridLookup_Init">
            <ClientSideEvents KeyUp="OnKeyPress" />
           <GridViewProperties>
               <Settings GridLines="None" />
               <SettingsBehavior EnableRowHotTrack="true" />
           </GridViewProperties>
            <Columns>
                <dx:GridViewDataColumn FieldName="ContactName"/>
                <dx:GridViewDataColumn FieldName="Region" GroupIndex="0"  />
            </Columns>
            <GridViewStyles>
                <GroupRow CssClass="groupRow" />
                <Row CssClass="dataRow" />
            </GridViewStyles>
            <GridViewProperties>
                <Settings ShowColumnHeaders="false" ShowGroupButtons="false" GroupFormat="{1}" />
                <SettingsBehavior AutoExpandAllGroups="true" />
                <SettingsPager Mode="ShowAllRecords" />
            </GridViewProperties>
        </dx:ASPxGridLookup>

    </form>
</body>
</html>
