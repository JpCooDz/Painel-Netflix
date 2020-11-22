Public Class Escolhertela
    Private Sub Escolhertela_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = False
        Button4.Enabled = False

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TELA1.Show()
        Hide()
    End Sub
End Class