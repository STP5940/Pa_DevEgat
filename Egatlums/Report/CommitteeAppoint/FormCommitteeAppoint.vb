Imports Egatlib
Imports Microsoft.Reporting.WinForms
Public Class FormCommitteeAppoint
    Private Tmasterrptdt As DataTable
    Private WithEvents Dtpfm As New DateTimePicker
    Private WithEvents Dtpto As New DateTimePicker

    Private Sub FormCommitteeCancel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        ' ============  Start Date Search  ============ '
        Dtpfm.CustomFormat = "MMMMyyyy"
        Dtpfm.Format = DateTimePickerFormat.Custom
        Controls.Add(Dtpfm)
        Dtpfm.Value = Now
        Dtpfm.Width = 160
        Me.ToolStrip1.Items.Insert(9, New ToolStripControlHost(Dtpfm))
        Me.ToolStrip1.Items(9).Alignment = ToolStripItemAlignment.Right
        Dtpfm.Visible = False

        ' ============  To Date Search  ============ '
        Dtpto.CustomFormat = "MMMMyyyy"
        Dtpto.Format = DateTimePickerFormat.Custom
        Controls.Add(Dtpto)
        Dtpto.Value = Now
        Dtpto.Width = 160
        Me.ToolStrip1.Items.Insert(8, New ToolStripControlHost(Dtpto))
        Me.ToolStrip1.Items(8).Alignment = ToolStripItemAlignment.Right
        Dtpto.Visible = False

        CreateListArea("SELECT Area_name FROM COM_Area", "Area_name")
        Setauthorize()
    End Sub
    Private Sub Tsbreports_Click(sender As Object, e As EventArgs) Handles Tsbreports.Click

        Dim TcomlistNow, TcomlistDate, CmteType, Approve As String

        ' ============  Not Checked CheckBox  ============ '
        If TstclistDate.Checked = False AndAlso TstclistNow.Checked = False AndAlso TstclistAll.Checked = False Then
            TstclistNow.Checked = True
        End If

        ' ============  Set Type Committee WHERE COM_Type.COM_TYPE ============ '
        CmteType = "03"

        ' ============  Set Approve 1  Or 0  ============ '
        Approve = "1"

        ' ============  Select List Area  ============ '
        Dim WhereArea As String = If(ReIDArea("SELECT Area_id FROM COM_Area", "Area_id", CbListArea.SelectedIndex) <> "All",
                       $"And (COM_Area.Area_id = '{ReIDArea("SELECT Area_id FROM COM_Area", "Area_id", CbListArea.SelectedIndex)}')", "")

        ' ============  Where for TstclistNow Checked Is Committee Current agenda  ============ '
        TcomlistNow = $"convert(varchar, getdate(), 23) BETWEEN dbo.COM_Committee.COM_StartDate AND dbo.COM_Committee.COM_EndDate {WhereArea}"

        ' ============  Where for TcomlistDate Checked Is Search for DateStaet to Date Stop  ============ '
        TcomlistDate = $"(SUBSTRING(CONVERT(nvarchar, dbo.COM_Committee.COM_StartDate), 0, 8) 
                             BETWEEN  '{Dtpfm.Value.ToString("yyyy-MM-dd").Substring(0, 7)}' 
                             AND '{Dtpto.Value.ToString("yyyy-MM-dd").Substring(0, 7)}') 
                         AND 
                         (SUBSTRING(CONVERT(nvarchar, dbo.COM_Committee.COM_EndDate), 0, 8)  
                             BETWEEN  '{Dtpfm.Value.ToString("yyyy-MM-dd").Substring(0, 7)}' 
                             AND '{Dtpto.Value.ToString("yyyy-MM-dd").Substring(0, 7)}') {WhereArea}"

        ' ============  Category Show Data for Report  ============ '
        Tmasterrptdt = New DataTable
        If TstclistAll.Checked = True Then ' Show All Committee
            Tmasterrptdt = SQLCommand($"SELECT dbo.COM_Committee.Member_id, dbo.COM_Committee.COM_TYPE, 
                                              SUBSTRING(CONVERT(nvarchar, dbo.COM_Committee.COM_StartDate), 0, 11) As COM_StartDate,
                                              SUBSTRING(CONVERT(nvarchar, dbo.COM_Committee.COM_EndDate), 0, 11) As COM_EndDate, 
                                              dbo.COM_Type.COM_DESC, dbo.VT_Member.Title, dbo.VT_Member.Member_Firstname, 
                                              dbo.VT_Member.Member_Lastname, dbo.VT_Member.Member_Date, dbo.COM_Committee.COM_Approve, 
                                              dbo.COM_Committee.Area_id, dbo.COM_Area.Area_name
                                       FROM dbo.COM_Committee 
                                       INNER JOIN dbo.COM_Type 
                                             ON dbo.COM_Committee.COM_TYPE = dbo.COM_Type.COM_TYPE 
                                       INNER JOIN dbo.VT_Member 
                                             ON dbo.COM_Committee.Member_id = dbo.VT_Member.Member_Id 
                                       INNER JOIN dbo.COM_Area 
                                             ON dbo.COM_Committee.Area_id = dbo.COM_Area.Area_id
                                       WHERE (dbo.COM_Committee.COM_Approve = '{Approve}') 
                                             AND (dbo.COM_Type.COM_TYPE = '{CmteType}') {WhereArea}")
        End If
        If TstclistNow.Checked = True Then ' Show Committee Current version
            Tmasterrptdt = SQLCommand($"SELECT dbo.COM_Committee.Member_id, dbo.COM_Committee.COM_TYPE, 
                                              SUBSTRING(CONVERT(nvarchar, dbo.COM_Committee.COM_StartDate), 0, 11) As COM_StartDate,
                                              SUBSTRING(CONVERT(nvarchar, dbo.COM_Committee.COM_EndDate), 0, 11) As COM_EndDate, 
                                              dbo.COM_Type.COM_DESC, dbo.VT_Member.Title, dbo.VT_Member.Member_Firstname, 
                                              dbo.VT_Member.Member_Lastname, dbo.VT_Member.Member_Date, dbo.COM_Committee.COM_Approve, 
                                              dbo.COM_Committee.Area_id, dbo.COM_Area.Area_name
                                       FROM dbo.COM_Committee 
                                       INNER JOIN dbo.COM_Type 
                                             ON dbo.COM_Committee.COM_TYPE = dbo.COM_Type.COM_TYPE 
                                       INNER JOIN dbo.VT_Member 
                                             ON dbo.COM_Committee.Member_id = dbo.VT_Member.Member_Id 
                                       INNER JOIN dbo.COM_Area 
                                             ON dbo.COM_Committee.Area_id = dbo.COM_Area.Area_id
                                       WHERE (dbo.COM_Committee.COM_Approve = '{Approve}') 
                                             AND (dbo.COM_Type.COM_TYPE = '{CmteType}') AND {TcomlistNow}")

        End If
        If TstclistDate.Checked = True Then ' Show Committee DateStart to DateEnd
            Tmasterrptdt = SQLCommand($"SELECT dbo.COM_Committee.Member_id, dbo.COM_Committee.COM_TYPE, 
                                              SUBSTRING(CONVERT(nvarchar, dbo.COM_Committee.COM_StartDate), 0, 11) As COM_StartDate,
                                              SUBSTRING(CONVERT(nvarchar, dbo.COM_Committee.COM_EndDate), 0, 11) As COM_EndDate, 
                                              dbo.COM_Type.COM_DESC, dbo.VT_Member.Title, dbo.VT_Member.Member_Firstname, 
                                              dbo.VT_Member.Member_Lastname, dbo.VT_Member.Member_Date, dbo.COM_Committee.COM_Approve, 
                                              dbo.COM_Committee.Area_id, dbo.COM_Area.Area_name
                                       FROM dbo.COM_Committee 
                                       INNER JOIN dbo.COM_Type 
                                             ON dbo.COM_Committee.COM_TYPE = dbo.COM_Type.COM_TYPE 
                                       INNER JOIN dbo.VT_Member 
                                             ON dbo.COM_Committee.Member_id = dbo.VT_Member.Member_Id 
                                       INNER JOIN dbo.COM_Area 
                                             ON dbo.COM_Committee.Area_id = dbo.COM_Area.Area_id
                                       WHERE (dbo.COM_Committee.COM_Approve = '{Approve}') 
                                             AND (dbo.COM_Type.COM_TYPE = '{CmteType}') AND {TcomlistDate}")
        End If

        ReportViewer1.Reset()
        Dim Rds As New ReportDataSource()
        Rds.Name = "DataSet1"
        Rds.Value = Tmasterrptdt
        ReportViewer1.LocalReport.DataSources.Add(Rds)
        ReportViewer1.LocalReport.ReportEmbeddedResource = "Egatlums.RptCommitteeappoint.rdlc"
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
    Private Sub TstclistAll_Click(sender As Object, e As EventArgs) Handles TstclistAll.CheckedChanged
        If TstclistAll.Checked = True Then
            TstclistNow.Checked = False
            TstclistDate.Checked = False
        End If
    End Sub
    Private Sub TstclistNow_Click(sender As Object, e As EventArgs) Handles TstclistNow.CheckedChanged
        If TstclistNow.Checked = True Then
            TstclistAll.Checked = False
            TstclistDate.Checked = False
        End If
    End Sub
    Private Sub TstclistDate_Click(sender As Object, e As EventArgs) Handles TstclistDate.CheckedChanged
        If TstclistDate.Checked = True Then
            TstclistAll.Checked = False
            TstclistNow.Checked = False
            Dtpfm.Enabled = True
            Dtpfm.Visible = True
            Dtpto.Enabled = True
            Dtpto.Visible = True
            ToolStripLabel4.Visible = False
            ToolStripLabel5.Visible = True
        Else
            Dtpfm.Enabled = False
            Dtpfm.Visible = False
            Dtpto.Enabled = False
            Dtpto.Visible = False
            ToolStripLabel4.Visible = True
            ToolStripLabel5.Visible = False
        End If
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

    ' ============  Add list to ComboBox CbListArea  ============ '
    Private Sub CreateListArea(SqlCommandList As String, NameColumn As String)
        Dim Tcom_area = New DataTable
        Tcom_area = SQLCommand(SqlCommandList)

        Dim _ListNameArea(Tcom_area.Rows.Count) As String
        For i = 0 To _ListNameArea.Length - 1
            _ListNameArea(i) = If(i = 0, "เลือกทั้งหมด", Tcom_area(i - 1)(NameColumn))
            CbListArea.Items.Add(_ListNameArea(i))
        Next
        CbListArea.SelectedIndex = 0
    End Sub

    ' ============  Return ID for Select ComboBox CbListArea  ============ '
    Private Function ReIDArea(SqlCommandList As String, NameColumn As String, Optional Order As Integer = 0)
        Dim PointArea As String = "All"
        Dim Tcom_area = New DataTable
        Tcom_area = SQLCommand(SqlCommandList)
        If Order <> 0 Then
            PointArea = Tcom_area(Order - 1)(NameColumn)
        End If
        Return PointArea
    End Function

End Class