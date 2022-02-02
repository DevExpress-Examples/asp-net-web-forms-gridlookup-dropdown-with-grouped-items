
# GridLookup for Web Forms - How to emulate a dropdown with grouped items

The example illustrates how to create a dropdown with grouped items. The implementation uses the nested grid's <a href="https://docs.devexpress.com/AspNet/js-ASPxClientGridView.ApplySearchPanelFilter(value)">ApplySearchPanelFilter</a> method to filter and search for the input value. The method is executed in the client-side **OnKeyPress** event of the GridLookup.

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

- [SingleColumn.aspx](./CS/DxWebApplication1/SingleColumn.aspx)
- [SingleColumn.cs](./CS/DxWebApplication1/SingleColumn.cs) (VB: [SingleColumn.vb](./VB/DxWebApplication1/SingleColumn.vb))
- [MultiColumn.aspx](./CS/DxWebApplication1/MultiColumn.aspx)
- [MultiColumn.cs](./CS/DxWebApplication1/MultiColumn.cs) (VB: [MultiColumn.vb](./VB/DxWebApplication1/MultiColumn.vb))

<!-- default file list end --> 

<!-- 

