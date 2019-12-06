Public Class frmAbout

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub frmAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label3.Text = "Version: " + My.Application.Info.Version.ToString()
    End Sub
End Class