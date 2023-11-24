Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "user1" And TextBox2.Text = "1234" Then
            Me.Hide()

            Form2.Show()
        ElseIf TextBox1.Text = "user2" And TextBox2.Text = "4567" Then
            Me.Hide()

            Form2.Show()
        Else
            Label3.Text = "الرجاء التأكد من البيانات "
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub
End Class
