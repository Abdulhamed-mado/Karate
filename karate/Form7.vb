Imports System.Data.SqlClient
Public Class Form7
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click



        Dim d As Integer
            Dim m As Integer
            Dim y As Integer
            d = DateTimePicker2.Value.Day
            m = DateTimePicker2.Value.Month
            y = DateTimePicker2.Value.Year
            Dim s As String = m & "-" & d & "-" & y




            Dim sa As String = ComboBox1.Text

            Dim str As String = "Server=LAPTOP-TVMSOSNS\MADONAFO2001;Database=karate;Trusted_Connection=True;
"



            Dim myconn As New SqlConnection(str)
            Dim com As New SqlCommand("insert into sensi_degree values('" + sa + "' , '" + s + "' , '" + TextBox1.Text + "' , '" + TextBox2.Text + "', '" + TextBox3.Text + "' )", myconn)

            Dim up As String = "UPDATE sensi set "
            up = up + "degree='" + sa + "'"
            up = up + ",d_date='" + s + "'"
            up = up + ",d_ID='" + TextBox3.Text + "'"

            up = up + "WHERE ID = '" + TextBox2.Text + "' "

            Dim comm As New SqlCommand(up, myconn)

            Try
                myconn.Open()
                com.ExecuteNonQuery()
                comm.ExecuteNonQuery()

                myconn.Close()

                TextBox3.Text = ""
                TextBox2.Text = ""

                TextBox1.Text = ""
                Form7_Load(sender, e)


            MsgBox("تم ادخال البيانات")
        Catch ex As Exception
            MsgBox("الرجاء التأكد من البيانات", MsgBoxStyle.Exclamation, "خطأ")

            End Try







        Form7_Load(sender, e)


    End Sub





    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click



        Dim sa As String = ComboBox1.Text

        Dim d As Integer
        Dim m As Integer
        Dim y As Integer
        d = DateTimePicker2.Value.Day
        m = DateTimePicker2.Value.Month
        y = DateTimePicker2.Value.Year
        Dim s As String = m & "-" & d & "-" & y

        Dim str As String = "Server=LAPTOP-TVMSOSNS\MADONAFO2001;Database=karate;Trusted_Connection=True;
"



        Dim up As String = "UPDATE sensi_degree set "
        up = up + "degree='" + sa + "'"
        up = up + ",d_date='" + s + "'"
        up = up + ",note='" + TextBox1.Text + "'"
        up = up + ",ID='" + TextBox2.Text + "'"

        up = up + "WHERE d_ID = '" + TextBox3.Text + "'  "


        Dim myconn As New SqlConnection(str)
        Dim com As New SqlCommand(up, myconn)

        Dim update As String = "UPDATE sensi set "
        update = update + "degree='" + sa + "'"
        update = update + ",d_date='" + s + "'"

        update = update + "WHERE d_ID = '" + TextBox3.Text + "'  "
        Dim comm As New SqlCommand(update, myconn)
        Try
            myconn.Open()
            com.ExecuteNonQuery()
            comm.ExecuteNonQuery()

            myconn.Close()

            TextBox3.Text = ""
            MsgBox("تم تعديل البيانات")
        Catch ex As Exception
            MsgBox("الرجاء التأكد من ادخال البيانات", MsgBoxStyle.Exclamation, "خطأ")

        End Try

        Form7_Load(sender, e)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub textbox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'KarateDataSet41.sensi_degree6_view' table. You can move, or remove it, as needed.
        Me.Sensi_degree6_viewTableAdapter.Fill(Me.KarateDataSet41.sensi_degree6_view)
        'TODO: This line of code loads data into the 'KarateDataSet37.sensi_degree3_view' table. You can move, or remove it, as needed.
        Me.Sensi_degree3_viewTableAdapter.Fill(Me.KarateDataSet37.sensi_degree3_view)



    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick

        Dim s As String
        s = DataGridView1.SelectedCells.Item(0).Value.ToString



        Dim str As String = "Server=LAPTOP-TVMSOSNS\MADONAFO2001;Database=karate;Trusted_Connection=True;
"


        Dim myconn As New SqlConnection(str)
        Dim com As New SqlCommand("SELECT * FROM sensi_degree WHERE  d_ID='" + s + "' ", myconn)

        Try

            myconn.Open()
            Dim myreder As SqlDataReader = com.ExecuteReader()
            myreder.Read()

            TextBox3.Text = myreder("d_ID")
            TextBox2.Text = myreder("ID")

            TextBox1.Text = myreder("note")
            DateTimePicker2.Value = myreder("d_date")
            ComboBox1.Text = myreder("degree")

            myconn.Close()

        Catch ex As Exception
            MsgBox("الرجاء التأكد من نقر المزدوج على خانة رقم القرار", MsgBoxStyle.Exclamation, "خطأ")

        End Try

    End Sub
    Private Sub textbox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim result As DialogResult = MsgBox("هل تريد حذف الحكم", MsgBoxStyle.YesNo, "تأكيد")
        If result = DialogResult.Yes Then
            Dim t As Date = Today.Date
            Dim d As Integer
            Dim m As Integer
            Dim y As Integer
            d = t.Date.Day
            m = t.Date.Month
            y = t.Date.Year
            Dim s As String = m & "-" & d & "-" & y


            Dim str As String = "Server=LAPTOP-TVMSOSNS\MADONAFO2001;Database=karate;Trusted_Connection=True;
"



            Dim myconn As New SqlConnection(str)
            Dim com As New SqlCommand("delete FROM sensi_degree WHERE  d_ID='" + TextBox3.Text + "'", myconn)

            Dim update As String = "UPDATE sensi set "
            update = update + "degree='" + "0" + "'"
            update = update + ",d_date='" + s + "'"

            update = update + "WHERE d_ID = '" + TextBox3.Text + "'  "
            Dim comm As New SqlCommand(update, myconn)

            Try




                myconn.Open()

                com.ExecuteNonQuery()
                comm.ExecuteNonQuery()

                myconn.Close()

                TextBox3.Text = ""
                TextBox1.Text = ""
                TextBox2.Text = ""

                MsgBox("تم حذف البيانات")
            Catch ex As Exception
                MsgBox("الرجاء التأكد ارقم القرار", MsgBoxStyle.Exclamation, "خطأ")

            End Try

        End If
        Form7_Load(sender, e)

    End Sub


End Class