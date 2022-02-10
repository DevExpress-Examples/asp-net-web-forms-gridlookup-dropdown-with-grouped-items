<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/454625952/21.1.6%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1064526)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# GridLookup for Web Forms - How to emulate a dropdown with grouped items
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/454625952/SingleColumn.aspx)**
<!-- run online end -->


The example illustrates how to create a dropdown with grouped items. 

![image](https://user-images.githubusercontent.com/69703500/152309609-d46559e1-f75a-4a28-aa90-3f3d4db712e6.png)


The implementation uses the nested grid's <a href="https://docs.devexpress.com/AspNet/js-ASPxClientGridView.ApplySearchPanelFilter(value)">ApplySearchPanelFilter</a> method to filter and search the data columns. The method is executed in the client-side **OnKeyPress** event of the GridLookup to simulate incremental filtering. Use the client-side <a href="https://docs.devexpress.com/AspNet/js-ASPxClientUtils.GetKeyCode.static(htmlEvent)">ASPxClientUtils.GetKeyCode</a> method to get the key pressed. To prevent multiple callback requests when keys are pressed in succession, use JavaScript's **setTimeout** and **clearTimeout** methods. Please note that the Enter key and Arrow keys will send a callback request when they are pressed in the OnKeyPress event. In this case, check for the key pressed in the event and prevent filtering to avoid sending callback requests.

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

The nested GridView may not look visually pleasing. In this case, apply custom CSS classes to make it look like a standard dropdown.

# For single column implementation

```cs
        .groupRow {
            font-weight: bold;
            color: black;
            background-color: lightgreen;
        }

        .dataRow td.dxgvIndentCell {
            display: none;
        }
```

# For multi-column implementation

```cs
        .groupRow {
           font-weight: bold;
            color: black;
            background-color: lightgreen;
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

