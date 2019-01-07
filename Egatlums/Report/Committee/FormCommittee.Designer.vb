<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCommittee
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Tsbreports = New System.Windows.Forms.ToolStripButton()
        Me.CbListArea = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabel6 = New System.Windows.Forms.ToolStripLabel()
        Me.Dtpto = New Egatlib.Ctrltoolstripdatetime.TSDatePicker()
        Me.TextTo = New System.Windows.Forms.ToolStripLabel()
        Me.Tsbclose = New System.Windows.Forms.ToolStripButton()
        Me.Dtpfm = New Egatlib.Ctrltoolstripdatetime.TSDatePicker()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ExportList = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.FilterDate = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabel9 = New System.Windows.Forms.ToolStripLabel()
        Me.TextDate = New System.Windows.Forms.ToolStripLabel()
        Me.TextMonth = New System.Windows.Forms.ToolStripLabel()
        Me.DtpMonth = New Egatlib.Ctrltoolstripdatetime.TSDatePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
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
        'CbListArea
        '
        Me.CbListArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbListArea.Name = "CbListArea"
        Me.CbListArea.Size = New System.Drawing.Size(121, 23)
        '
        'ToolStripLabel6
        '
        Me.ToolStripLabel6.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.ToolStripLabel6.Name = "ToolStripLabel6"
        Me.ToolStripLabel6.Size = New System.Drawing.Size(49, 48)
        Me.ToolStripLabel6.Text = "พื้นที่   "
        '
        'Dtpto
        '
        Me.Dtpto.Name = "Dtpto"
        Me.Dtpto.Size = New System.Drawing.Size(150, 48)
        '
        'TextTo
        '
        Me.TextTo.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.TextTo.Name = "TextTo"
        Me.TextTo.Size = New System.Drawing.Size(24, 48)
        Me.TextTo.Text = "ถึง"
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
        'Dtpfm
        '
        Me.Dtpfm.Name = "Dtpfm"
        Me.Dtpfm.Size = New System.Drawing.Size(150, 48)
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
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tsbclose, Me.Tsbreports, Me.ToolStripLabel4, Me.ExportList, Me.ToolStripLabel1, Me.ToolStripSeparator2, Me.ToolStripLabel2, Me.ToolStripLabel6, Me.CbListArea, Me.ToolStripLabel3, Me.ToolStripSeparator1, Me.ToolStripLabel9, Me.FilterDate, Me.TextDate, Me.Dtpfm, Me.TextTo, Me.Dtpto, Me.TextMonth, Me.DtpMonth})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 23)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1053, 51)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ExportList
        '
        Me.ExportList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ExportList.Name = "ExportList"
        Me.ExportList.Size = New System.Drawing.Size(121, 51)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(13, 48)
        Me.ToolStripLabel1.Text = " "
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 51)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(13, 48)
        Me.ToolStripLabel2.Text = " "
        '
        'FilterDate
        '
        Me.FilterDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FilterDate.Name = "FilterDate"
        Me.FilterDate.Size = New System.Drawing.Size(121, 51)
        '
        'ToolStripLabel9
        '
        Me.ToolStripLabel9.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel9.Name = "ToolStripLabel9"
        Me.ToolStripLabel9.Size = New System.Drawing.Size(13, 48)
        Me.ToolStripLabel9.Text = " "
        '
        'TextDate
        '
        Me.TextDate.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.TextDate.Name = "TextDate"
        Me.TextDate.Size = New System.Drawing.Size(65, 48)
        Me.TextDate.Text = "ตั้งแต่วันที่"
        '
        'TextMonth
        '
        Me.TextMonth.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.TextMonth.Name = "TextMonth"
        Me.TextMonth.Size = New System.Drawing.Size(39, 48)
        Me.TextMonth.Text = "เดือน"
        '
        'DtpMonth
        '
        Me.DtpMonth.Name = "DtpMonth"
        Me.DtpMonth.Size = New System.Drawing.Size(150, 48)
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
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "เงื่อนไขในการแสดงรายงาน"
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
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(65, 48)
        Me.ToolStripLabel4.Text = "รากงาน   "
        '
        'FormCommittee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1059, 577)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormCommittee"
        Me.Text = "FormCommittee"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Tsbreports As ToolStripButton
    Friend WithEvents CbListArea As ToolStripComboBox
    Friend WithEvents ToolStripLabel6 As ToolStripLabel
    Friend Dtpto As Egatlib.Ctrltoolstripdatetime.TSDatePicker
    Friend WithEvents TextTo As ToolStripLabel
    Friend WithEvents Tsbclose As ToolStripButton
    Friend Dtpfm As Egatlib.Ctrltoolstripdatetime.TSDatePicker
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ExportList As ToolStripComboBox
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend DtpMonth As Egatlib.Ctrltoolstripdatetime.TSDatePicker
    Friend WithEvents FilterDate As ToolStripComboBox
    Friend WithEvents ToolStripLabel9 As ToolStripLabel
    Friend WithEvents TextDate As ToolStripLabel
    Friend WithEvents TextMonth As ToolStripLabel
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripLabel4 As ToolStripLabel
End Class
