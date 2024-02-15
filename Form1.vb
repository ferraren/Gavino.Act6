Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MessageBox.Show("please complete the entry first1!")
        Else
            Try
                Dim a, b As Integer
                a = TextBox1.Text
                b = TextBox2.Text
                lblResult.Text = a / b
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
        End If
    End Sub
End Class
