﻿Imports Egatlib
Imports Microsoft.Reporting.WinForms
Public Class FormCommitteeCancel
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

        CreateListStatus("SELECT COM_Status FROM COM_Status", "COM_Status")
        Setauthorize()
    End Sub
    Private Sub Tsbreports_Click(sender As Object, e As EventArgs) Handles Tsbreports.Click

        ' ============  Not Checked CheckBox  ============ '
        If TstclistDate.Checked = False AndAlso TstclistNow.Checked = False AndAlso TstclistAll.Checked = False Then
            TstclistNow.Checked = True
        End If

        Dim TcomlistNow, TcomlistDate As String
        ' ============  Where for TstclistNow Checked Is Committee Current agenda  ============ '
        TcomlistNow = $"convert(varchar, getdate(), 23) BETWEEN dbo.COM_Committee.COM_StartDate AND dbo.COM_Committee.COM_EndDate"

        ' ============  Where for TcomlistDate Checked Is Search for DateStaet to Date Stop  ============ '
        TcomlistDate = $"(SUBSTRING(CONVERT(nvarchar, dbo.COM_Committee.COM_StartDate), 0, 8) 
                          BETWEEN  '{Dtpfm.Value.ToString("yyyy-MM-dd").Substring(0, 7)}' 
                             AND '{Dtpto.Value.ToString("yyyy-MM-dd").Substring(0, 7)}') 
                         AND 
                         (SUBSTRING(CONVERT(nvarchar, dbo.COM_Committee.COM_EndDate), 0, 8)  
                          BETWEEN  '{Dtpfm.Value.ToString("yyyy-MM-dd").Substring(0, 7)}' 
                             AND '{Dtpto.Value.ToString("yyyy-MM-dd").Substring(0, 7)}')"

        ' ============  Select List Area  ============ '
        Dim WhereStatus As String = If(ReIDStatus("SELECT COM_Status_id FROM COM_Status", "COM_Status_id", CbListArea.SelectedIndex) <> "All",
                       $"AND dbo.COM_Status.COM_Status_id = '{ReIDStatus("SELECT COM_Status_id FROM COM_Status", "COM_Status_id",
                       CbListArea.SelectedIndex)}'", "")

        Tmasterrptdt = New DataTable

        If TstclistAll.Checked = True Then
            Tmasterrptdt = SQLCommand($"SELECT dbo.COM_Committee.Member_id, dbo.COM_Committee.COM_TYPE, dbo.VT_Member.Membertype,
                                              SUBSTRING(CONVERT(nvarchar, dbo.COM_Committee.COM_StartDate), 0, 11) As COM_StartDate,
                                              SUBSTRING(CONVERT(nvarchar, dbo.COM_Committee.COM_EndDate), 0, 11) As COM_EndDate, 
							                  dbo.COM_Type.COM_DESC, dbo.VT_Member.Title, dbo.VT_Member.Member_Firstname, 
                                              dbo.VT_Member.Member_Lastname, dbo.VT_Member.Member_Date, dbo.VT_Member.Memberstatus_Id,
											  dbo.COM_Committee.COM_Approve,dbo.COM_Committee.COM_active,dbo.COM_Committee.COM_Status_id, 
											  dbo.COM_Status.COM_Status
						               FROM dbo.COM_Committee 
						               INNER JOIN dbo.COM_Type 
							                 ON dbo.COM_Committee.COM_TYPE = dbo.COM_Type.COM_TYPE 
					                   INNER JOIN dbo.VT_Member 
						                     ON dbo.COM_Committee.Member_id = dbo.VT_Member.Member_Id  
									   INNER JOIN dbo.COM_Status 
										     ON dbo.COM_Committee.COM_Status_id = dbo.COM_Status.COM_Status_id
                                       Where dbo.COM_Committee.COM_Approve = '1' AND dbo.COM_Committee.COM_active = '0' {WhereStatus}")
        End If

        If TstclistNow.Checked = True Then
            Tmasterrptdt = SQLCommand($"SELECT dbo.COM_Committee.Member_id, dbo.COM_Committee.COM_TYPE, dbo.VT_Member.Membertype,
                                              SUBSTRING(CONVERT(nvarchar, dbo.COM_Committee.COM_StartDate), 0, 11) As COM_StartDate,
                                              SUBSTRING(CONVERT(nvarchar, dbo.COM_Committee.COM_EndDate), 0, 11) As COM_EndDate, 
							                  dbo.COM_Type.COM_DESC, dbo.VT_Member.Title, dbo.VT_Member.Member_Firstname, 
                                              dbo.VT_Member.Member_Lastname, dbo.VT_Member.Member_Date, dbo.VT_Member.Memberstatus_Id,
											  dbo.COM_Committee.COM_Approve,dbo.COM_Committee.COM_active,dbo.COM_Committee.COM_Status_id, 
											  dbo.COM_Status.COM_Status
						               FROM dbo.COM_Committee 
						               INNER JOIN dbo.COM_Type 
							                 ON dbo.COM_Committee.COM_TYPE = dbo.COM_Type.COM_TYPE 
					                   INNER JOIN dbo.VT_Member 
						                     ON dbo.COM_Committee.Member_id = dbo.VT_Member.Member_Id  
									   INNER JOIN dbo.COM_Status 
										     ON dbo.COM_Committee.COM_Status_id = dbo.COM_Status.COM_Status_id
                                       Where dbo.COM_Committee.COM_Approve = '1' AND dbo.COM_Committee.COM_active = '0' AND {TcomlistNow} {WhereStatus}")

        End If

        If TstclistDate.Checked = True Then
            Tmasterrptdt = SQLCommand($"SELECT dbo.COM_Committee.Member_id, dbo.COM_Committee.COM_TYPE, dbo.VT_Member.Membertype,
                                              SUBSTRING(CONVERT(nvarchar, dbo.COM_Committee.COM_StartDate), 0, 11) As COM_StartDate,
                                              SUBSTRING(CONVERT(nvarchar, dbo.COM_Committee.COM_EndDate), 0, 11) As COM_EndDate, 
							                  dbo.COM_Type.COM_DESC, dbo.VT_Member.Title, dbo.VT_Member.Member_Firstname, 
                                              dbo.VT_Member.Member_Lastname, dbo.VT_Member.Member_Date, dbo.VT_Member.Memberstatus_Id,
											  dbo.COM_Committee.COM_Approve,dbo.COM_Committee.COM_active,dbo.COM_Committee.COM_Status_id, 
											  dbo.COM_Status.COM_Status
						               FROM dbo.COM_Committee 
						               INNER JOIN dbo.COM_Type 
							                 ON dbo.COM_Committee.COM_TYPE = dbo.COM_Type.COM_TYPE 
					                   INNER JOIN dbo.VT_Member 
						                     ON dbo.COM_Committee.Member_id = dbo.VT_Member.Member_Id  
									   INNER JOIN dbo.COM_Status 
										     ON dbo.COM_Committee.COM_Status_id = dbo.COM_Status.COM_Status_id
                                       Where dbo.COM_Committee.COM_Approve = '1' AND dbo.COM_Committee.COM_active = '0' AND {TcomlistDate} {WhereStatus}")
        End If

        ReportViewer1.Reset()
        Dim Rds As New ReportDataSource()
        Rds.Name = "DataSet1"
        Rds.Value = Tmasterrptdt
        ReportViewer1.LocalReport.DataSources.Add(Rds)
        ReportViewer1.LocalReport.ReportEmbeddedResource = "Egatlums.RptCommitteecancel.rdlc"
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
    Private Sub CreateListStatus(SqlCommandList As String, NameColumn As String)
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
    Private Function ReIDStatus(SqlCommandList As String, NameColumn As String, Optional Order As Integer = 0)
        Dim PointArea As String = "All"
        Dim Tcom_area = New DataTable
        Tcom_area = SQLCommand(SqlCommandList)
        If Order <> 0 Then
            PointArea = Tcom_area(Order - 1)(NameColumn)
        End If
        Return PointArea
    End Function
End Class