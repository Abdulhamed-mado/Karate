Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class Form12
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form14.Show()
        Me.Close()


    End Sub

    Private Sub Form12_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim str As String = "Server=LAPTOP-TVMSOSNS\MADONAFO2001;Database=karate;Trusted_Connection=True;"
        Dim myconn As New SqlConnection(str)

        Dim command As New SqlCommand("SELECT * FROM club ", myconn)
        Dim ade As New SqlDataAdapter(command)

        Dim table As New DataTable
        ade.Fill(table)

        ComboBox2.DataSource = table
        ComboBox2.DisplayMember = "Name"
        ComboBox2.ValueMember = "ID"


        Dim com As New SqlCommand("SELECT * FROM sensi  ", myconn)
        Dim da As New SqlDataAdapter(com)
        Dim dt As New DataTable
        da.Fill(dt)
        With ReportViewer1.LocalReport
            .DataSources.Clear()
            .ReportPath = "Report4.rdlc"
            .DataSources.Add(New ReportDataSource("DataSet1", dt))
        End With

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim str As String = "Server=LAPTOP-TVMSOSNS\MADONAFO2001;Database=karate;Trusted_Connection=True;"
        Dim sa As String = ComboBox1.SelectedIndex

        Dim myconn As New SqlConnection(str)
        Dim com As New SqlCommand("SELECT * FROM sensi where degree='" + sa + "' ", myconn)
        Dim da As New SqlDataAdapter(com)
        Dim dt As New DataTable
        da.Fill(dt)
        With ReportViewer1.LocalReport
            .DataSources.Clear()
            .ReportPath = "Report4.rdlc"
            .DataSources.Add(New ReportDataSource("DataSet1", dt))
        End With

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim str As String = "Server=LAPTOP-TVMSOSNS\MADONAFO2001;Database=karate;Trusted_Connection=True;"
        Dim sa As String = ComboBox2.Text

        Dim myconn As New SqlConnection(str)
        Dim com As New SqlCommand("SELECT * FROM sensi where club_id='" + sa + "' ", myconn)
        Dim da As New SqlDataAdapter(com)
        Dim dt As New DataTable
        da.Fill(dt)
        With ReportViewer1.LocalReport
            .DataSources.Clear()
            .ReportPath = "Report4.rdlc"
            .DataSources.Add(New ReportDataSource("DataSet1", dt))
        End With

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim str As String = "Server=LAPTOP-TVMSOSNS\MADONAFO2001;Database=karate;Trusted_Connection=True;"


        Dim myconn As New SqlConnection(str)
        Dim com As New SqlCommand("SELECT * FROM sensi_degree where ID='" + txt1.Text + "' ", myconn)
        Dim da As New SqlDataAdapter(com)
        Dim dt As New DataTable
        da.Fill(dt)
        With ReportViewer1.LocalReport
            .DataSources.Clear()
            .ReportPath = "Report6.rdlc"
            .DataSources.Add(New ReportDataSource("DataSet1", dt))
        End With

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim str As String = "Server=LAPTOP-TVMSOSNS\MADONAFO2001;Database=karate;Trusted_Connection=True;"
        Dim sa As String = ComboBox1.Text

        Dim myconn As New SqlConnection(str)
        Dim com As New SqlCommand("SELECT * FROM sensi where degree='" + sa + "' ", myconn)
        Dim da As New SqlDataAdapter(com)
        Dim dt As New DataTable
        da.Fill(dt)
        With ReportViewer1.LocalReport
            .DataSources.Clear()
            .ReportPath = "Report4.rdlc"
            .DataSources.Add(New ReportDataSource("DataSet1", dt))
        End With

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class