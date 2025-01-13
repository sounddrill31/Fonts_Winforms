Public Class Form1
    Public Sub setStyle()
        Dim style = FontStyle.Regular
        If CheckBox1.Checked Then
            style = style Or FontStyle.Bold
        End If
        If CheckBox2.Checked Then
            style = style Or FontStyle.Italic
        End If
        If CheckBox3.Checked Then
            style = style Or FontStyle.Underline
        End If
        TextBox1.Font = New Drawing.Font(TextBox1.Font, style)
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        setStyle()
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        setStyle()
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        setStyle()
    End Sub
End Class


