Imports Egatlib
Imports Microsoft.Reporting.WinForms
Public Class FormCommitteeTerminate
    Private Tmasterrptdt As DataTable
    Private WithEvents Dtpfm As New DateTimePicker
    Private WithEvents Dtpto As New DateTimePicker
    Private Sub FormCommitteeTerminate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub
    Private Sub Tsbreports_Click(sender As Object, e As EventArgs) Handles Tsbreports.Click
        Dim Tcomtext1 As String
        Tcomtext1 = "Member_Firstname Like '%" & TxtWhere.Text & "%'" & " OR Member_Lastname Like '%" & TxtWhere.Text & "%'"

        Tmasterrptdt = New DataTable
        If TxtWhere.Text = "" Then
            Tmasterrptdt = SQLCommand("SELECT Member_id,Title,Member_Firstname,Member_Lastname,Member_date FROM VT_Member")
        Else
            Tmasterrptdt = SQLCommand("SELECT Member_id,Title,Member_Firstname,Member_Lastname,Member_date FROM VT_Member Where " & Tcomtext1)
        End If

        ReportViewer1.Reset()
        Dim Rds As New ReportDataSource()
        Rds.Name = "DataSet1"
        Rds.Value = Tmasterrptdt
        ReportViewer1.LocalReport.DataSources.Add(Rds)
        ReportViewer1.LocalReport.ReportEmbeddedResource = "Egatlums.RptNewmember.rdlc"
        Me.ReportViewer1.RefreshReport()
        ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        ReportViewer1.ZoomMode = ZoomMode.Percent
        ReportViewer1.ZoomPercent = 100
        Dim Par1 As ReportParameter
        Par1 = New ReportParameter("User", Gbusername, True)
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {Par1})
        Me.ReportViewer1.RefreshReport()
    End Sub
    Private Sub Tsbclose_Click(sender As Object, e As EventArgs) Handles Tsbclose.Click
        Me.Close()
    End Sub


    '------------- Sub Or Function -------------'

    Private Sub Setauthorize()
        If Gbexpau = False Then
            Me.ReportViewer1.ShowExportButton = False
        End If
        If Gbpriau = False Then
            Me.ReportViewer1.ShowPrintButton = False
        End If
    End Sub
End Class