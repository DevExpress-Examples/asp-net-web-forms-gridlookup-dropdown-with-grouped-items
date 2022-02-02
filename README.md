<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1064526)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# GridLookup for Web Forms - How to emulate a dropdown with grouped items

The example illustrates how to create a dropdown with grouped items using the ASPxGridLookup. The implementation uses the nested grid's <a href="https://docs.devexpress.com/AspNet/js-ASPxClientGridView.ApplySearchPanelFilter(value)">ApplySearchPanelFilter</a> method to filter and search for the input value. The method is executed in the client-side **OnKeyPress** event of the GridLookup.

```cs
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

```


<!-- default file list -->

## Files to Look At

- [SingleColumn.aspx](./CS/DXWebApplication1/SingleColumn.aspx)
- [SingleColumn.cs](./CS/DXWebApplication1/SingleColumn.aspx.cs) (VB: [SingleColumn.vb](./VB/DXWebApplication1/SingleColumn.aspx.vb))
- [MultiColumn.aspx](./CS/DXWebApplication1/MultiColumn.aspx)
- [MultiColumn.cs](./CS/DXWebApplication1/MultiColumn.aspx.cs) (VB: [MultiColumn.vb](./VB/DXWebApplication1/MultiColumn.aspx.vb))

<!-- default file list end --> 

<!-- 

