﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCommitteeAppoint
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Tsbclose = New System.Windows.Forms.ToolStripButton()
        Me.Tsbreports = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.TstclistAll = New Egatlib.Ctrltoolstripcheckbox()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.TstclistNow = New Egatlib.Ctrltoolstripcheckbox()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.TstclistDate = New Egatlib.Ctrltoolstripcheckbox()
        Me.Dtpfm = New Egatlib.Ctrltoolstripdatetime.TSDatePicker()
        Me.ToolStripLabel5 = New System.Windows.Forms.ToolStripLabel()
        Me.Dtpto = New Egatlib.Ctrltoolstripdatetime.TSDatePicker()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel7 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel6 = New System.Windows.Forms.ToolStripLabel()
        Me.CbListArea = New System.Windows.Forms.ToolStripComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox1.Controls.Add(Me.ReportViewer1)
        Me.GroupBox1.Controls.Add(Me.ToolStrip1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1059, 577)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "เงื่อนไขในการแสดงรายงาน"
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Egatlums.RptCommitteecancel.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(3, 74)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ShowContextMenu = False
        Me.ReportViewer1.Size = New System.Drawing.Size(1053, 500)
        Me.ReportViewer1.TabIndex = 1
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tsbclose, Me.Tsbreports, Me.ToolStripLabel1, Me.TstclistAll, Me.ToolStripLabel4, Me.TstclistNow, Me.ToolStripLabel2, Me.TstclistDate, Me.Dtpfm, Me.ToolStripLabel5, Me.Dtpto, Me.ToolStripLabel3, Me.ToolStripSeparator1, Me.ToolStripLabel7, Me.ToolStripLabel6, Me.CbListArea})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 23)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1053, 51)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Tsbclose
        '
        Me.Tsbclose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Tsbclose.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tsbclose.Image = Global.Egatlums.My.Resources.Resources.Close
        Me.Tsbclose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Tsbclose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tsbclose.Name = "Tsbclose"
        Me.Tsbclose.Size = New System.Drawing.Size(31, 48)
        Me.Tsbclose.Text = "ปิด"
        Me.Tsbclose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Tsbreports
        '
        Me.Tsbreports.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Tsbreports.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tsbreports.Image = Global.Egatlums.My.Resources.Resources.Reports
        Me.Tsbreports.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Tsbreports.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tsbreports.Name = "Tsbreports"
        Me.Tsbreports.Size = New System.Drawing.Size(56, 48)
        Me.Tsbreports.Text = "รายงาน"
        Me.Tsbreports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(55, 48)
        Me.ToolStripLabel1.Text = "ค้นหา   "
        '
        'TstclistAll
        '
        Me.TstclistAll.BackColor = System.Drawing.Color.Transparent
        Me.TstclistAll.Checked = False
        Me.TstclistAll.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TstclistAll.Name = "TstclistAll"
        Me.TstclistAll.Size = New System.Drawing.Size(107, 48)
        Me.TstclistAll.Text = "รายชื่อทั้งหมด"
        Me.TstclistAll.ToolStripCheckBoxEnabled = True
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(13, 48)
        Me.ToolStripLabel4.Text = " "
        '
        'TstclistNow
        '
        Me.TstclistNow.BackColor = System.Drawing.Color.Transparent
        Me.TstclistNow.Checked = True
        Me.TstclistNow.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TstclistNow.Name = "TstclistNow"
        Me.TstclistNow.Size = New System.Drawing.Size(147, 48)
        Me.TstclistNow.Text = "รายชื่อในวาระปัจจุบัน"
        Me.TstclistNow.ToolStripCheckBoxEnabled = True
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(13, 48)
        Me.ToolStripLabel2.Text = " "
        '
        'TstclistDate
        '
        Me.TstclistDate.BackColor = System.Drawing.Color.Transparent
        Me.TstclistDate.Checked = False
        Me.TstclistDate.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TstclistDate.Name = "TstclistDate"
        Me.TstclistDate.Size = New System.Drawing.Size(122, 48)
        Me.TstclistDate.Text = "รายชื่อตั้งแต่วันที่"
        Me.TstclistDate.ToolStripCheckBoxEnabled = True
        '
        'Dtpfm
        '
        Me.Dtpfm.Name = "Dtpfm"
        Me.Dtpfm.Size = New System.Drawing.Size(150, 48)
        '
        'ToolStripLabel5
        '
        Me.ToolStripLabel5.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.ToolStripLabel5.Name = "ToolStripLabel5"
        Me.ToolStripLabel5.Size = New System.Drawing.Size(24, 48)
        Me.ToolStripLabel5.Text = "ถึง"
        '
        'Dtpto
        '
        Me.Dtpto.Name = "Dtpto"
        Me.Dtpto.Size = New System.Drawing.Size(150, 48)
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(13, 48)
        Me.ToolStripLabel3.Text = " "
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 51)
        '
        'ToolStripLabel7
        '
        Me.ToolStripLabel7.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel7.Name = "ToolStripLabel7"
        Me.ToolStripLabel7.Size = New System.Drawing.Size(13, 48)
        Me.ToolStripLabel7.Text = " "
        '
        'ToolStripLabel6
        '
        Me.ToolStripLabel6.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.ToolStripLabel6.Name = "ToolStripLabel6"
        Me.ToolStripLabel6.Size = New System.Drawing.Size(84, 48)
        Me.ToolStripLabel6.Text = "ประจำพื้นที่   "
        '
        'CbListArea
        '
        Me.CbListArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbListArea.Name = "CbListArea"
        Me.CbListArea.Size = New System.Drawing.Size(121, 23)
        '
        'FormCommitteeAppoint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1059, 577)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormCommitteeAppoint"
        Me.Text = "รายงานคำสั่งแต่งตั้งอนุกรรมการ"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents Tsbclose As ToolStripButton
    Friend WithEvents Tsbreports As ToolStripButton
    Friend WithEvents ToolStripLabel5 As ToolStripLabel
    Friend WithEvents TstclistDate As Egatlib.Ctrltoolstripcheckbox
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents TstclistNow As Egatlib.Ctrltoolstripcheckbox
    Friend WithEvents ToolStripLabel4 As ToolStripLabel
    Friend WithEvents TstclistAll As Egatlib.Ctrltoolstripcheckbox
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents CbListArea As ToolStripComboBox
    Friend WithEvents ToolStripLabel6 As ToolStripLabel
    Friend WithEvents ToolStripLabel7 As ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend Dtpfm As Egatlib.Ctrltoolstripdatetime.TSDatePicker
    Friend Dtpto As Egatlib.Ctrltoolstripdatetime.TSDatePicker
End Class
