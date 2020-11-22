Public Class TELA1
    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        WebBrowser1.Document.GetElementById("id_userLoginId").SetAttribute("value", "EMAIL DA NETFLIX")
        WebBrowser1.Document.GetElementById("id_password").SetAttribute("value", "SENHA DA NETFLIX")
        WebBrowser1.Document.Forms(0).InvokeMember("submit")
    End Sub
End Class