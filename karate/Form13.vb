Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class Form13
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form14.Show()
        Me.Close()


    End Sub

    Private Sub Form13_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim str As String = "Server=LAPTOP-TVMSOSNS\MADONAFO2001;Database=karate;Trusted_Connection=True;"
        Dim myconn As New SqlConnection(str)

        Dim command As New SqlCommand("SELECT * FROM club ", myconn)
        Dim ade As New SqlDataAdapter(command)

        Dim table As New DataTable
        ade.Fill(table)

        ComboBox2.DataSource = table
        ComboBox2.DisplayMember = "Name"
        ComboBox2.ValueMember = "ID"


        Dim com As New SqlCommand("SELECT * FROM player  ", myconn)
        Dim da As New SqlDataAdapter(com)
        Dim dt As New DataTable
        da.Fill(dt)
        With ReportViewer1.LocalReport
            .DataSources.Clear()
            .ReportPath = "Report2.rdlc"
            .DataSources.Add(New ReportDataSource("DataSet1", dt))
        End With

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim str As String = "Server=LAPTOP-TVMSOSNS\MADONAFO2001;Database=karate;Trusted_Connection=True;"
        Dim sa As String = ComboBox1.Text

        Dim myconn As New SqlConnection(str)
        Dim com As New SqlCommand("SELECT * FROM player where belt='" + sa + "' ", myconn)
        Dim da As New SqlDataAdapter(com)
        Dim dt As New DataTable
        da.Fill(dt)
        With ReportViewer1.LocalReport
            .DataSources.Clear()
            .ReportPath = "Report2.rdlc"
            .DataSources.Add(New ReportDataSource("DataSet1", dt))
        End With

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim str As String = "Server=LAPTOP-TVMSOSNS\MADONAFO2001;Database=karate;Trusted_Connection=True;"
        Dim sa As String = ComboBox2.Text

        Dim myconn As New SqlConnection(str)
        Dim com As New SqlCommand("SELECT * FROM player where club_id='" + sa + "' ", myconn)
        Dim da As New SqlDataAdapter(com)
        Dim dt As New DataTable
        da.Fill(dt)
        With ReportViewer1.LocalReport
            .DataSources.Clear()
            .ReportPath = "Report2.rdlc"
            .DataSources.Add(New ReportDataSource("DataSet1", dt))
        End With

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim str As String = "Server=LAPTOP-TVMSOSNS\MADONAFO2001;Database=karate;Trusted_Connection=True;"


        Dim myconn As New SqlConnection(str)
        Dim com As New SqlCommand("SELECT * FROM player_belt where ID='" + txt1.Text + "' ", myconn)
        Dim da As New SqlDataAdapter(com)
        Dim dt As New DataTable
        da.Fill(dt)
        With ReportViewer1.LocalReport
            .DataSources.Clear()
            .ReportPath = "Report7.rdlc"
            .DataSources.Add(New ReportDataSource("DataSet1", dt))
        End With

        Me.ReportViewer1.RefreshReport()
    End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim str As String = "Server=LAPTOP-TVMSOSNS\MADONAFO2001;Database=karate;Trusted_Connection=True;"
        Dim y As Integer
        y = DateTimePicker2.Value.Year
        Dim s As String = y

        Dim myconn As New SqlConnection(str)
        Dim com As New SqlCommand("select * from player where YEAR(bdate)='" + s + "' ", myconn)
        Dim da As New SqlDataAdapter(com)
        Dim dt As New DataTable
        da.Fill(dt)
        With ReportViewer1.LocalReport
            .DataSources.Clear()
            .ReportPath = "Report2.rdlc"
            .DataSources.Add(New ReportDataSource("DataSet1", dt))
        End With

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class