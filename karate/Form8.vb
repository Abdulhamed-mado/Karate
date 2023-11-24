Imports System.Data.SqlClient

Public Class Form8



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
            Dim com As New SqlCommand("insert into player values('" + txt1.Text + "' , '" + txt2.Text + "' , '" + txt3.Text + "' , '" + txt4.Text + "' , '" + s + "'  , '" + txt5.Text + "' , '" + "0" + "' , '" + s + "' , '" + sa + "' , '" + "0" + "')", myconn)

            Try
                myconn.Open()
                com.ExecuteNonQuery()
                myconn.Close()

                txt1.Text = ""
                txt2.Text = ""
                txt3.Text = ""
                txt4.Text = ""

                txt5.Text = ""

            MsgBox("تم ادخال البيانات")

        Catch ex As Exception
                MsgBox(ex.ToString)

            End Try







        Form8_Load(sender, e)

    End Sub



    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Dim result As DialogResult = MsgBox("هل تريد حذف اللاعب", MsgBoxStyle.YesNo, "تأكيد")
        If result = DialogResult.Yes Then
            Dim str As String = "Server=LAPTOP-TVMSOSNS\MADONAFO2001;Database=karate;Trusted_Connection=True;
"



            Dim myconn As New SqlConnection(str)
            Dim com As New SqlCommand("delete FROM player WHERE  ID='" + txt1.Text + "'", myconn)
            Try
                myconn.Open()

                com.ExecuteNonQuery()
                myconn.Close()

                txt1.Text = ""
                txt2.Text = ""
                txt3.Text = ""
                txt4.Text = ""
                txt5.Text = ""
                MsgBox("تم حذف البيانات")

            Catch ex As Exception
                MsgBox("الرجاء التأكد من حذف جميع سجلات الخاصة احزمة الاعب", MsgBoxStyle.Exclamation, "خطأ")

            End Try

        End If
        Form8_Load(sender, e)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

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




            Dim up As String = "UPDATE player set "
            up = up + "Name_arabic='" + txt2.Text + "'"
            up = up + ", Name_english='" + txt3.Text + "'"
            up = up + ", pass_num='" + txt4.Text + "'"
            up = up + ", bdate='" + s + "'"
            up = up + ", note='" + txt5.Text + "'"
            up = up + ", club_id='" + sa + "'"

            up = up + "WHERE ID = '" + txt1.Text + "' "


            Dim myconn As New SqlConnection(str)
            Dim com As New SqlCommand(up, myconn)

            Try
                myconn.Open()
                com.ExecuteNonQuery()
                myconn.Close()

                txt1.Text = ""
                txt2.Text = ""
                txt3.Text = ""
                txt4.Text = ""
                txt5.Text = ""
            MsgBox("تم تعديل البيانات")
        Catch ex As Exception
            MsgBox("الرجاء التأكد من البايانات", MsgBoxStyle.Exclamation, "خطأ")

            End Try


        Form8_Load(sender, e)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'KarateDataSet30.player' table. You can move, or remove it, as needed.
        Me.PlayerTableAdapter.Fill(Me.KarateDataSet30.player)
        Dim str As String = "Server=LAPTOP-TVMSOSNS\MADONAFO2001;Database=karate;Trusted_Connection=True;"

        Dim myconn As New SqlConnection(str)
        Dim command As New SqlCommand("SELECT * FROM club ", myconn)
        Dim ade As New SqlDataAdapter(command)

        Dim table As New DataTable
        ade.Fill(table)

        ComboBox1.DataSource = table
        ComboBox1.DisplayMember = "Name"
        ComboBox1.ValueMember = "ID"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Form13.Show()
        Me.Close()

    End Sub



    Private Sub txt3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt3.KeyPress
        If (e.KeyChar >= "ا" And e.KeyChar <= "ي") Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt2.KeyPress
        If (e.KeyChar >= "a" And e.KeyChar <= "z") Or (e.KeyChar >= "A" And e.KeyChar <= "Z") Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)
        Form9.Show()
        Me.Close()

    End Sub





    Private Sub txt1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt1.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        Dim s As String
        s = DataGridView1.SelectedCells.Item(0).Value.ToString


        Dim str As String = "Server=LAPTOP-TVMSOSNS\MADONAFO2001;Database=karate;Trusted_Connection=True;
"


        Dim myconn As New SqlConnection(str)
        Dim com As New SqlCommand("SELECT * FROM player WHERE  ID='" + s + "'", myconn)

        Try

            myconn.Open()
            Dim myreder As SqlDataReader = com.ExecuteReader()
            myreder.Read()

            txt1.Text = myreder("ID")

            txt2.Text = myreder("Name_arabic")
            txt3.Text = myreder("Name_english")
            txt4.Text = myreder("pass_num")
            txt5.Text = myreder("note")
            DateTimePicker2.Value = myreder("bdate")
            ComboBox1.Text = myreder("club_id")

            myconn.Close()

        Catch ex As Exception
            MsgBox("الرجاء التأكد من نقرعلى خانة رقم الاعب", MsgBoxStyle.Exclamation, "خطأ")

        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class