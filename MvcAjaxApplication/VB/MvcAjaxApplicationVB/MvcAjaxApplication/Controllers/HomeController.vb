<HandleError()> _
Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        ViewData("Message") = "Welcome to ASP.NET MVC!"

        Return View()
    End Function

    Function About() As ActionResult
        Return View()
    End Function

    Public Function GetStatus() As String
        Return "Status OK at " + DateTime.Now.ToLongTimeString()
    End Function

    Public Function UpdateForm(ByVal textBox1 As String) As String
        If textBox1 <> "Enter text" Then
            Return "You entered: """ + textBox1.ToString() + """ at " + DateTime.Now.ToLongTimeString()
        End If

        Return [String].Empty
    End Function
End Class
