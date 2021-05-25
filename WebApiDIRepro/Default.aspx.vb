Imports WebApiCs

Public Class _Default
    Inherits Page

    Property Value As String


    Protected _valueRepo As IValueRepo

    Public Sub New(ByVal valueRepo As IValueRepo)
        _valueRepo = valueRepo
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Value = _valueRepo.GetValue(1)
    End Sub
End Class