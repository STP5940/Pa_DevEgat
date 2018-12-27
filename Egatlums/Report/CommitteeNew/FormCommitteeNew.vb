Imports Egatlib
Imports Microsoft.Reporting.WinForms
Public Class FormCommitteeNew
    Private Tmasterrptdt As DataTable
    Private WithEvents Dtpfm As New DateTimePicker
    Private WithEvents Dtpto As New DateTimePicker
    Private Sub FormCommitteeNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        'TxtWhereDate.ShowUpDown = True
        TxtWhereDate.CustomFormat = "MMMMyyyy"
        TxtWhereDate.Format = DateTimePickerFormat.Custom
    End Sub
    Private Sub Tsbreports_Click(sender As Object, e As EventArgs) Handles Tsbreports.Click
        'MsgBox(TxtWhereDate.Value.ToString("yyyy-MM-dd").Substring(0, 7))
        Dim Tcomtext1 As String
        'Tcomtext1 = $"dbo.COM_Committee.Member_id Like '%{TxtWhere.Text}%' OR 
        '             dbo.VT_Member.Title Like '%{TxtWhere.Text}%' OR Member_Firstname Like '%{TxtWhere.Text}%' OR 
        '             Member_Lastname Like '%{TxtWhere.Text}%' OR COM_DESC Like '%{TxtWhere.Text}%'"

        Tcomtext1 = $"SUBSTRING(CONVERT(nvarchar, dbo.COM_Committee.COM_StartDate), 0, 8) = '{TxtWhereDate.Value.ToString("yyyy-MM-dd").Substring(0, 7)}'"

            Tmasterrptdt = New DataTable
        If WhereAll.Checked = True Then
            Tmasterrptdt = SQLCommand("SELECT dbo.COM_Committee.Member_id, dbo.COM_Committee.COM_TYPE, 
                                              SUBSTRING(CONVERT(nvarchar, dbo.COM_Committee.COM_StartDate), 0, 11) As COM_StartDate,
                                              dbo.COM_Type.COM_DESC, dbo.VT_Member.Title, dbo.VT_Member.Member_Firstname, 
                                              dbo.VT_Member.Member_Lastname, dbo.VT_Member.Member_Date, 
                                              dbo.VT_Member.Membertype
                                       FROM dbo.COM_Committee 
                                       INNER JOIN dbo.COM_Type 
                                             ON dbo.COM_Committee.COM_TYPE = dbo.COM_Type.COM_TYPE 
                                       INNER JOIN dbo.VT_Member 
                                             ON dbo.COM_Committee.Member_id = dbo.VT_Member.Member_Id")
        ElseIf WhereDate.Checked = True Then
            Tmasterrptdt = SQLCommand("SELECT dbo.COM_Committee.Member_id, dbo.COM_Committee.COM_TYPE, 
                                              SUBSTRING(CONVERT(nvarchar, dbo.COM_Committee.COM_StartDate), 0, 11) As COM_StartDate,
                                              dbo.COM_Type.COM_DESC, dbo.VT_Member.Title, dbo.VT_Member.Member_Firstname, 
                                              dbo.VT_Member.Member_Lastname, dbo.VT_Member.Member_Date, 
                                              dbo.VT_Member.Membertype
                                       FROM dbo.COM_Committee 
                                       INNER JOIN dbo.COM_Type 
                                             ON dbo.COM_Committee.COM_TYPE = dbo.COM_Type.COM_TYPE 
                                       INNER JOIN dbo.VT_Member 
                                             ON dbo.COM_Committee.Member_id = dbo.VT_Member.Member_Id Where " & Tcomtext1)
        End If

        ReportViewer1.Reset()
        Dim Rds As New ReportDataSource()
        Rds.Name = "DataSet1"
        Rds.Value = Tmasterrptdt
        ReportViewer1.LocalReport.DataSources.Add(Rds)
        ReportViewer1.LocalReport.ReportEmbeddedResource = "Egatlums.RptCommitteenew.rdlc"
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

    '------------- Start Sub Or Function -------------'

    Private Sub Setauthorize()
        If Gbexpau = False Then
            Me.ReportViewer1.ShowExportButton = False
        End If
        If Gbpriau = False Then
            Me.ReportViewer1.ShowPrintButton = False
        End If
    End Sub

    Private Sub WhereDate_CheckedChanged(sender As Object, e As EventArgs) Handles WhereDate.CheckedChanged
        If WhereDate.Checked = True Then
            WhereAll.Checked = False
            TxtWhereDate.Enabled = True
        Else
            WhereAll.Checked = True
            TxtWhereDate.Enabled = False
        End If
    End Sub

    Private Sub WhereAll_CheckedChanged(sender As Object, e As EventArgs) Handles WhereAll.CheckedChanged
        If WhereAll.Checked = True Then
            WhereDate.Checked = False
        Else
            WhereDate.Checked = True
        End If
    End Sub
End Class