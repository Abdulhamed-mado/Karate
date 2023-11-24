Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class Form10
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form14.Show()
        Me.Close()


    End Sub

    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim str As String = "Server=LAPTOP-TVMSOSNS\MADONAFO2001;Database=karate;Trusted_Connection=True;"
        Dim myconn As New SqlConnection(str)
        Dim com As New SqlCommand("SELECT * FROM club  ", myconn)
        Dim da As New SqlDataAdapter(com)
        Dim dt As New DataTable
        da.Fill(dt)
        With ReportViewer1.LocalReport
            .DataSources.Clear()
            .ReportPath = "Report1.rdlc"
            .DataSources.Add(New ReportDataSource("DataSet1", dt))
        End With

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class