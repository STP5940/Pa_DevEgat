Imports Egatlib
Imports Microsoft.Reporting.WinForms
Public Class Formsystemlogsrpt
    Private Tmasterrptdt As DataTable
    Private WithEvents Dtpfm As New DateTimePicker
    Private WithEvents Dtpto As New DateTimePicker
    Private Sub Formsystemlogsrpt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Controls.Add(Dtpfm)
        Dtpfm.Value = Now
        Dtpfm.Width = 160
        Me.ToolStrip1.Items.Insert(8, New ToolStripControlHost(Dtpfm))
        Controls.Add(Dtpto)
        Dtpto.Value = Now
        Dtpto.Width = 160
        Me.ToolStrip1.Items.Insert(10, New ToolStripControlHost(Dtpto))
        Setauthorize()
        Dtpfm.Visible = False
        Dtpto.Visible = False
        Loadusergrouprptinf()
        Loaduserbygrouprptinf()
    End Sub
    Private Sub Tstcnottime_CheckedChanged(sender As Object, e As EventArgs) Handles Tstcnottime.CheckedChanged
        If Tstcnottime.Checked = True Then
            Dtpfm.Enabled = False
            Dtpto.Enabled = False
            Dtpfm.Visible = False
            Dtpto.Visible = False
            ToolStripLabel3.Visible = False
            ToolStripLabel4.Visible = False
        Else
            Dtpfm.Enabled = True
            Dtpto.Enabled = True
            Dtpfm.Visible = True
            Dtpto.Visible = True
            ToolStripLabel3.Visible = True
            ToolStripLabel4.Visible = True
        End If
    End Sub
    Private Sub Tscbusergroup_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Tscbusergroup.KeyPress
        e.Handled = True
    End Sub
    Private Sub Tsbreports_Click(sender As Object, e As EventArgs) Handles Tsbreports.Click
        If Validinput() = False Then
            Informmessage("กรูณาตรวจสอบข้อมูลกลุ่มผู้ใช้ให้ถูกต้อง")
            Exit Sub
        End If
        Dim Tcomtext1, Tcomtext2, Tcomtext3 As String
        If Tscbusergroup.ComboBox.Text = "ทั้งหมด" Then
            Tcomtext1 = ""
        Else
            Tcomtext1 = " AND Updateby_Usrgrpid = '" & Tscbusergroup.ComboBox.SelectedValue & "'"
        End If
        If Tscbuser.ComboBox.Text = "ทั้งหมด" Then
            Tcomtext2 = ""
        Else
            Tcomtext2 = " AND Updateby_Usrid = '" & Tscbusergroup.ComboBox.SelectedValue & "'"
        End If
        If Tstcnottime.Checked = True Then
            Tcomtext3 = ""
        Else
            If Dtpfm.Value > Dtpto.Value Then
                Informmessage("วันที่เริ่มต้นต้องมีค่าน้อยกว่าวันที่สิ้นสุด")
                Exit Sub
            End If
            Tcomtext3 = " AND Upddate BETWEEN '" & Formatshortdatesave(Dtpfm.Value) & "' AND '" & Formatshortdatesave(Dtpto.Value) & "'"
        End If
        Tmasterrptdt = New DataTable
        Tmasterrptdt = SQLCommand("SELECT Updateby_Usrgrpid,Usrgroup_Name,Updateby_Usrid,Updateby_Usrname,Menu_Id,Menu_Th,Doc_Id,Update_Type,
                                    Update_Details,Update_Time,Updatefrom_Comname,Updateform_Usrprofile FROM VT_Sys_Syslog 
                                    WHERE Updateby_Usrgrpid <> '000' " & Tcomtext1 & Tcomtext2 & Tcomtext3)
        ReportViewer1.Reset()
        Dim Rds As New ReportDataSource()
        Rds.Name = "DataSet1"
        Rds.Value = Tmasterrptdt
        ReportViewer1.LocalReport.DataSources.Add(Rds)
        ReportViewer1.LocalReport.ReportEmbeddedResource = "Egatlums.Rptuserlogs.rdlc"
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
    Private Sub Loadusergrouprptinf()
        Dim Usergrouprptdt As DataTable = Loadusergrouprpt()
        Tscbusergroup.ComboBox.DataSource = Usergrouprptdt
        Tscbusergroup.ComboBox.ValueMember = "Usrgroup_Id"
        Tscbusergroup.ComboBox.DisplayMember = "Usrgroup_Name"
    End Sub
    Private Sub Loaduserbygrouprptinf()
        Dim Userbygrouprptdt As New DataTable
        If Tscbusergroup.Text = "ทั้งหมด" Then
            Userbygrouprptdt = Loaduserbygrouprpt("All")
        Else
            Userbygrouprptdt = Loaduserbygrouprpt(Tscbusergroup.ComboBox.SelectedValue)
        End If
        Tscbuser.ComboBox.DataSource = Userbygrouprptdt
        Tscbuser.ComboBox.ValueMember = "Usr_Id"
        Tscbuser.ComboBox.DisplayMember = "Usr_Name"
    End Sub
    Private Function Validinput() As Boolean
        Dim Valid As Boolean = False
        If Tscbusergroup.Text <> "" Then
            Valid = True
        Else
            Valid = False
        End If
        Return Valid
    End Function
    Private Sub Setauthorize()
        If Gbexpau = False Then
            Me.ReportViewer1.ShowExportButton = False
        End If
        If Gbpriau = False Then
            Me.ReportViewer1.ShowPrintButton = False
        End If
    End Sub
End Class