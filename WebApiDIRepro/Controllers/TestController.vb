Imports System.Net
Imports System.Web.Http
Imports WebApiCs

Namespace Controllers
    Public Class TestController
        Inherits ApiController

        Protected _valueRepo As IValueRepo

        Public Sub New(ByVal valueRepo As IValueRepo)
            _valueRepo = valueRepo
        End Sub

        ' GET: api/Test
        Public Function GetValues() As IEnumerable(Of String)
            Return _valueRepo.GetValues()
        End Function

        ' GET: api/Test/5
        Public Function GetValue(ByVal id As Integer) As String
            Return _valueRepo.GetValue(id)
        End Function

        ' POST: api/Test
        Public Sub PostValue(<FromBody()> ByVal value As String)

        End Sub

        ' PUT: api/Test/5
        Public Sub PutValue(ByVal id As Integer, <FromBody()> ByVal value As String)

        End Sub

        ' DELETE: api/Test/5
        Public Sub DeleteValue(ByVal id As Integer)

        End Sub
    End Class
End Namespace