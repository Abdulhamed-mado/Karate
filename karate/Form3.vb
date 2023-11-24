Imports System.Data.SqlClient

Public Class Form3
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim str As String = "Server=LAPTOP-TVMSOSNS\MADONAFO2001;Database=karate;Trusted_Connection=True;
"



        Dim myconn As New SqlConnection(str)
            Dim com As New SqlCommand("insert into club values('" + TextBox3.Text + "' , '" + TextBox5.Text + "' )", myconn)

            Try
                    myconn.Open()
                    com.ExecuteNonQuery()
                    myconn.Close()

                    TextBox3.Text = ""
                    TextBox5.Text = ""
                MsgBox("تم ادخال البيانات")
            Catch ex As Exception
            MsgBox("الرجاء التأكد من  البيانات")

        End Try







        Form3_Load(sender, e)


    End Sub



    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        MsgBox("هل تريد حذف المشترك", MsgBoxStyle.YesNo, "تأكيد")
        If DialogResult.Yes Then
            Dim str As String = "Server=LAPTOP-TVMSOSNS\MADONAFO2001;Database=karate;Trusted_Connection=True;
"



            Dim myconn As New SqlConnection(str)
            Dim com As New SqlCommand("delete FROM club WHERE  ID='" + TextBox3.Text + "'", myconn)
            Try
                myconn.Open()

                com.ExecuteNonQuery()
                myconn.Close()

                TextBox3.Text = ""
                TextBox5.Text = ""
                MsgBox("تم حذف البيانات")
            Catch ex As Exception
                MsgBox("الرجاء التأكد من حذف جميع سجلات الخاصة بالاعبين و المدربين", MsgBoxStyle.Exclamation, "خطأ")

            End Try

        End If
        Form3_Load(sender, e)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim str As String = "Server=LAPTOP-TVMSOSNS\MADONAFO2001;Database=karate;Trusted_Connection=True;
"




        Dim up As String = "UPDATE club set "
        up = up + "Name ='" + TextBox5.Text + "'"
        up = up + "WHERE ID = '" + TextBox3.Text + "' "


            Dim myconn As New SqlConnection(str)
            Dim com As New SqlCommand(up, myconn)

            Try
                myconn.Open()
                com.ExecuteNonQuery()
                myconn.Close()

                TextBox3.Text = ""
                TextBox5.Text = ""
                MsgBox("تم تعديل البيانات")
            Catch ex As Exception
            MsgBox("الرجاء التأكد من البيانات", MsgBoxStyle.Exclamation, "خطأ")

        End Try


        Form3_Load(sender, e)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form2.Show()
        Me.Close()
    End Sub



    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'KarateDataSet27.club' table. You can move, or remove it, as needed.
        Me.ClubTableAdapter.Fill(Me.KarateDataSet27.club)

    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        Dim s As String
        s = DataGridView1.SelectedCells.Item(0).Value.ToString
        Dim str As String = "Server=LAPTOP-TVMSOSNS\MADONAFO2001;Database=karate;Trusted_Connection=True;
"


        Dim myconn As New SqlConnection(str)
        Dim com As New SqlCommand("SELECT * FROM club WHERE  ID='" + s + "'", myconn)

        Try

            myconn.Open()
            Dim myreder As SqlDataReader = com.ExecuteReader()
            myreder.Read()

            TextBox3.Text = myreder("ID")

            TextBox5.Text = myreder("name")
            myconn.Close()

        Catch ex As Exception
            MsgBox("الرجاء التأكد نقر المزدوج على خانة رقم النادي", MsgBoxStyle.Exclamation, "خطأ")

        End Try


    End Sub

    Private Sub textbox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub
End Class