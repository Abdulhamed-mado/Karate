Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class Form11
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form14.Show()
        Me.Close()


    End Sub

    Private Sub Form11_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim str As String = "Server=LAPTOP-TVMSOSNS\MADONAFO2001;Database=karate;Trusted_Connection=True;"
        Dim myconn As New SqlConnection(str)
        Dim com As New SqlCommand("SELECT * FROM ref  ", myconn)
        Dim da As New SqlDataAdapter(com)
        Dim dt As New DataTable
        da.Fill(dt)
        With ReportViewer1.LocalReport
            .DataSources.Clear()
            .ReportPath = "Report3.rdlc"
            .DataSources.Add(New ReportDataSource("DataSet1", dt))
        End With

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim str As String = "Server=LAPTOP-TVMSOSNS\MADONAFO2001;Database=karate;Trusted_Connection=True;"
        Dim sa As String = ComboBox1.Text

        Dim myconn As New SqlConnection(str)
        Dim com As New SqlCommand("SELECT * FROM ref where degree='" + sa + "' ", myconn)
        Dim da As New SqlDataAdapter(com)
        Dim dt As New DataTable
        da.Fill(dt)
        With ReportViewer1.LocalReport
            .DataSources.Clear()
            .ReportPath = "Report3.rdlc"
            .DataSources.Add(New ReportDataSource("DataSet1", dt))
        End With

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim str As String = "Server=LAPTOP-TVMSOSNS\MADONAFO2001;Database=karate;Trusted_Connection=True;"


        Dim myconn As New SqlConnection(str)
        Dim com As New SqlCommand("SELECT * FROM ref_degree where ID='" + txt1.Text + "' ", myconn)
        Dim da As New SqlDataAdapter(com)
        Dim dt As New DataTable
        da.Fill(dt)
        With ReportViewer1.LocalReport
            .DataSources.Clear()
            .ReportPath = "Report5.rdlc"
            .DataSources.Add(New ReportDataSource("DataSet1", dt))
        End With

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub txt1_TextChanged(sender As Object, e As EventArgs) Handles txt1.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class