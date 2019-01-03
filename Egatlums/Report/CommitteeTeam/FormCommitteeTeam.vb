Imports Egatlib
Imports Microsoft.Reporting.WinForms
Public Class FormCommitteeTeam
    Private Tmasterrptdt As DataTable
    Private WithEvents Dtpfm As New DateTimePicker
    'Private WithEvents Dtpto As New DateTimePicker
    Private Sub FormCommitteeTeam_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        ' ============  Month Search  ============ '
        Dtpfm.CustomFormat = "MMMMyyyy"
        Dtpfm.Format = DateTimePickerFormat.Custom
        Controls.Add(Dtpfm)
        Dtpfm.Value = Now
        Dtpfm.Width = 160
        Me.ToolStrip1.Items.Insert(4, New ToolStripControlHost(Dtpfm))
        Me.ToolStrip1.Items(4).Alignment = ToolStripItemAlignment.Right
        Tstcnotdate.Checked = True

        Setauthorize()
    End Sub
    Private Sub Tsbreports_Click(sender As Object, e As EventArgs) Handles Tsbreports.Click
        Dim Tcomtext1 As String

        Tcomtext1 = $"SUBSTRING(CONVERT(nvarchar, dbo.COM_Committee.COM_StartDate), 0, 8) = '{Dtpfm.Value.ToString("yyyy-MM-dd").Substring(0, 7)}'"

        Dim TcomlistNow As String
        ' ============  Where for TstclistNow Checked Is Committee Current agenda  ============ '

        TcomlistNow = $"'{Dtpfm.Value.ToString("yyyy-MM-dd").Substring(0, 7)}' 
                      BETWEEN SUBSTRING(CONVERT(nvarchar, dbo.COM_Committee.COM_StartDate), 0, 8)  
                      AND SUBSTRING(CONVERT(nvarchar, dbo.COM_Committee.COM_EndDate), 0, 8)"

        Tmasterrptdt = New DataTable
        Tmasterrptdt = SQLCommand($"SELECT dbo.COM_Committee.Member_id, dbo.COM_Committee.COM_TYPE,
                                              dbo.COM_Committee.COM_StartDate, dbo.COM_Committee.COM_EndDate,
                                              dbo.COM_Type.COM_DESC, dbo.VT_Member.Title, dbo.VT_Member.Member_Firstname, 
                                              dbo.VT_Member.Member_Lastname, dbo.VT_Member.Member_Date, 
                                              dbo.VT_Member.Membertype
                                       FROM dbo.COM_Committee 
                                       INNER JOIN dbo.COM_Type 
                                             ON dbo.COM_Committee.COM_TYPE = dbo.COM_Type.COM_TYPE 
                                       INNER JOIN dbo.VT_Member 
                                             ON dbo.COM_Committee.Member_id = dbo.VT_Member.Member_Id Where {TcomlistNow} ")

        ReportViewer1.Reset()
        Dim Rds As New ReportDataSource()
        Rds.Name = "DataSet1"
        Rds.Value = Tmasterrptdt
        ReportViewer1.LocalReport.DataSources.Add(Rds)
        ReportViewer1.LocalReport.ReportEmbeddedResource = "Egatlums.RptCommitteeteam.rdlc"
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


    ' <==========================================>
    '<====   Start Sub Or Function $Pa_Dev>   ====>
    ' <==========================================>

    ' ============  Set authentication  ============ '
    Private Sub Setauthorize()
        If Gbexpau = False Then
            Me.ReportViewer1.ShowExportButton = False
        End If
        If Gbpriau = False Then
            Me.ReportViewer1.ShowPrintButton = False
        End If
    End Sub
End Class