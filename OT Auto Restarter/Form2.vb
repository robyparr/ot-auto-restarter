Public Class Form2

    Private Sub TextBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.Click
        TextBox1.SelectAll()
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RichTextBox1.Select(88, 220)
        RichTextBox1.SelectionColor = Color.Red
        RichTextBox1.DeselectAll()
    End Sub
End Class