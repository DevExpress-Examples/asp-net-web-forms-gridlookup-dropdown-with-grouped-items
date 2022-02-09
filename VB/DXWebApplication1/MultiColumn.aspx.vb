Imports System
Imports System.Web.UI
Imports System.Web.UI.WebControls

Namespace DXWebApplication1

    Public Partial Class MultiColumn
        Inherits Page

        Protected Sub gridLookup_Init(ByVal sender As Object, ByVal e As EventArgs)
            gridLookup.GridView.Width = 500
        End Sub

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
            gridLookup.DataSource = Contact.GetContacts()
            gridLookup.DataBind()
        End Sub
    End Class
End Namespace
