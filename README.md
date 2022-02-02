<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/454625952/21.1.6%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1064526)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# GridLookup for Web Forms - How to emulate a dropdown with grouped items
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/454625952/)**
<!-- run online end -->


The example illustrates how to create a dropdown with grouped items. The implementation uses the nested grid's <a href="https://docs.devexpress.com/AspNet/js-ASPxClientGridView.ApplySearchPanelFilter(value)">ApplySearchPanelFilter</a> method to filter and search the data columns. The method is executed in the client-side **OnKeyPress** event of the GridLookup.

# JavaScript
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
- [SingleColumn.cs](./CS/DXWebApplication1/SingleColumn.aspx.cs)
- [MultiColumn.aspx](./CS/DXWebApplication1/MultiColumn.aspx)
- [MultiColumn.cs](./CS/DXWebApplication1/MultiColumn.aspx.cs)

<!-- default file list end --> 

<!-- 

