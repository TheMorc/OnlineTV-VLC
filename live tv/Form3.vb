Public Class con
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        type("loaded dev console(CTRL + C)")
    End Sub

    Public Sub type(v As String)
        RichTextBox1.Text = RichTextBox1.Text + vbNewLine + v
    End Sub
End Class