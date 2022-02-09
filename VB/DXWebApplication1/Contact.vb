Imports System.Collections.Generic

Namespace DXWebApplication1

    Public Class Contact

        Public Property ContactId As Integer

        Public Property ContactName As String

        Public Property Region As String

        Public Shared Function GetContacts() As List(Of Contact)
            Dim list As List(Of Contact) = New List(Of Contact)()
            list.Add(New Contact With {.ContactId = 1, .ContactName = "John", .Region = "USA"})
            list.Add(New Contact With {.ContactId = 2, .ContactName = "Mark", .Region = "USA"})
            list.Add(New Contact With {.ContactId = 3, .ContactName = "Christian", .Region = "Africa"})
            list.Add(New Contact With {.ContactId = 4, .ContactName = "Will", .Region = "Europe"})
            list.Add(New Contact With {.ContactId = 5, .ContactName = "Sasha", .Region = "USA"})
            list.Add(New Contact With {.ContactId = 6, .ContactName = "Anthony", .Region = "Asia"})
            list.Add(New Contact With {.ContactId = 7, .ContactName = "Catherine", .Region = "Europe"})
            list.Add(New Contact With {.ContactId = 8, .ContactName = "Lloyd", .Region = "Africa"})
            list.Add(New Contact With {.ContactId = 9, .ContactName = "Jose", .Region = "Asia"})
            list.Add(New Contact With {.ContactId = 10, .ContactName = "Harold", .Region = "China"})
            Return list
        End Function
    End Class
End Namespace
