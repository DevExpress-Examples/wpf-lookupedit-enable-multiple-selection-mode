Imports System.Collections.Generic
Imports System.Windows

Namespace WpfApplication68

    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub
    End Class

    Public Module Helper

        Public ReadOnly Property Data As List(Of Employee)
            Get
                Dim staff As List(Of Employee) = New List(Of Employee) From {New Employee() With {.Name = "Gregory S. Price", .Department = "", .Position = "President"}, New Employee() With {.Name = "Irma R. Marshall", .Department = "Marketing", .Position = "Vice President"}, New Employee() With {.Name = "John C. Powell", .Department = "Operations", .Position = "Vice President"}, New Employee() With {.Name = "Christian P. Laclair", .Department = "Production", .Position = "Vice President"}, New Employee() With {.Name = "Karen J. Kelly", .Department = "Finance", .Position = "Vice President"}, New Employee() With {.Name = "Brian C. Cowling", .Department = "Marketing", .Position = "Manager"}, New Employee() With {.Name = "Thomas C. Dawson", .Department = "Marketing", .Position = "Manager"}, New Employee() With {.Name = "Angel M. Wilson", .Department = "Marketing", .Position = "Manager"}, New Employee() With {.Name = "Bryan R. Henderson", .Department = "Marketing", .Position = "Manager"}, New Employee() With {.Name = "Harold S. Brandes", .Department = "Operations", .Position = "Manager"}, New Employee() With {.Name = "Michael S. Blevins", .Department = "Operations", .Position = "Manager"}, New Employee() With {.Name = "Jan K. Sisk", .Department = "Operations", .Position = "Manager"}, New Employee() With {.Name = "Sidney L. Holder", .Department = "Operations", .Position = "Manager"}, New Employee() With {.Name = "James L. Kelsey", .Department = "Production", .Position = "Manager"}, New Employee() With {.Name = "Howard M. Carpenter", .Department = "Production", .Position = "Manager"}, New Employee() With {.Name = "Jennifer T. Tapia", .Department = "Production", .Position = "Manager"}, New Employee() With {.Name = "Judith P. Underhill", .Department = "Finance", .Position = "Manager"}, New Employee() With {.Name = "Russell E. Belton", .Department = "Finance", .Position = "Manager"}}
                Return staff
            End Get
        End Property
    End Module

    Public Class Employee

        Public Property Name As String

        Public Property Position As String

        Public Property Department As String
    End Class
End Namespace
