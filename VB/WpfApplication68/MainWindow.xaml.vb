Imports System.Collections.Generic
Imports System.Windows

Namespace WpfApplication68
    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()
        End Sub
    End Class

    Public NotInheritable Class Helper

        Private Sub New()
        End Sub

        Public Shared ReadOnly Property Data() As List(Of Employee)
            Get
                Dim stuff As New List(Of Employee)()
                stuff.Add(New Employee() With { _
                    .ID = 1, _
                    .ParentID = 0, _
                    .Name = "Gregory S. Price", _
                    .Department = "", _
                    .Position = "President" _
                })
                stuff.Add(New Employee() With { _
                    .ID = 2, _
                    .ParentID = 1, _
                    .Name = "Irma R. Marshall", _
                    .Department = "Marketing", _
                    .Position = "Vice President" _
                })
                stuff.Add(New Employee() With { _
                    .ID = 3, _
                    .ParentID = 1, _
                    .Name = "John C. Powell", _
                    .Department = "Operations", _
                    .Position = "Vice President" _
                })
                stuff.Add(New Employee() With { _
                    .ID = 4, _
                    .ParentID = 1, _
                    .Name = "Christian P. Laclair", _
                    .Department = "Production", _
                    .Position = "Vice President" _
                })
                stuff.Add(New Employee() With { _
                    .ID = 5, _
                    .ParentID = 1, _
                    .Name = "Karen J. Kelly", _
                    .Department = "Finance", _
                    .Position = "Vice President" _
                })

                stuff.Add(New Employee() With { _
                    .ID = 6, _
                    .ParentID = 2, _
                    .Name = "Brian C. Cowling", _
                    .Department = "Marketing", _
                    .Position = "Manager" _
                })
                stuff.Add(New Employee() With { _
                    .ID = 7, _
                    .ParentID = 2, _
                    .Name = "Thomas C. Dawson", _
                    .Department = "Marketing", _
                    .Position = "Manager" _
                })
                stuff.Add(New Employee() With { _
                    .ID = 8, _
                    .ParentID = 2, _
                    .Name = "Angel M. Wilson", _
                    .Department = "Marketing", _
                    .Position = "Manager" _
                })
                stuff.Add(New Employee() With { _
                    .ID = 9, _
                    .ParentID = 2, _
                    .Name = "Bryan R. Henderson", _
                    .Department = "Marketing", _
                    .Position = "Manager" _
                })

                stuff.Add(New Employee() With { _
                    .ID = 10, _
                    .ParentID = 3, _
                    .Name = "Harold S. Brandes", _
                    .Department = "Operations", _
                    .Position = "Manager" _
                })
                stuff.Add(New Employee() With { _
                    .ID = 11, _
                    .ParentID = 3, _
                    .Name = "Michael S. Blevins", _
                    .Department = "Operations", _
                    .Position = "Manager" _
                })
                stuff.Add(New Employee() With { _
                    .ID = 12, _
                    .ParentID = 3, _
                    .Name = "Jan K. Sisk", _
                    .Department = "Operations", _
                    .Position = "Manager" _
                })
                stuff.Add(New Employee() With { _
                    .ID = 13, _
                    .ParentID = 3, _
                    .Name = "Sidney L. Holder", _
                    .Department = "Operations", _
                    .Position = "Manager" _
                })

                stuff.Add(New Employee() With { _
                    .ID = 14, _
                    .ParentID = 4, _
                    .Name = "James L. Kelsey", _
                    .Department = "Production", _
                    .Position = "Manager" _
                })
                stuff.Add(New Employee() With { _
                    .ID = 15, _
                    .ParentID = 4, _
                    .Name = "Howard M. Carpenter", _
                    .Department = "Production", _
                    .Position = "Manager" _
                })
                stuff.Add(New Employee() With { _
                    .ID = 16, _
                    .ParentID = 4, _
                    .Name = "Jennifer T. Tapia", _
                    .Department = "Production", _
                    .Position = "Manager" _
                })

                stuff.Add(New Employee() With { _
                    .ID = 17, _
                    .ParentID = 5, _
                    .Name = "Judith P. Underhill", _
                    .Department = "Finance", _
                    .Position = "Manager" _
                })
                stuff.Add(New Employee() With { _
                    .ID = 18, _
                    .ParentID = 5, _
                    .Name = "Russell E. Belton", _
                    .Department = "Finance", _
                    .Position = "Manager" _
                })
                Return stuff
            End Get
        End Property
    End Class

    Public Class Employee
        Public Property ID() As Integer
        Public Property ParentID() As Integer
        Public Property Name() As String
        Public Property Position() As String
        Public Property Department() As String
    End Class
End Namespace