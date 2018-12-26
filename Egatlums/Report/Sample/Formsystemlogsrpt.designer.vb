<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formsystemlogsrpt
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Tsbclose = New System.Windows.Forms.ToolStripButton()
        Me.Tsbreports = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.Tscbusergroup = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.Tscbuser = New System.Windows.Forms.ToolStripComboBox()
        Me.Tstcnottime = New Egatlib.Ctrltoolstripcheckbox()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
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
        Me.GroupBox1.Size = New System.Drawing.Size(1008, 729)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "เงื่อนไขในการแสดงรายงาน"
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer1.Location = New System.Drawing.Point(3, 74)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ShowContextMenu = False
        Me.ReportViewer1.Size = New System.Drawing.Size(1002, 652)
        Me.ReportViewer1.TabIndex = 1
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tsbclose, Me.Tsbreports, Me.ToolStripLabel1, Me.Tscbusergroup, Me.ToolStripLabel2, Me.Tscbuser, Me.Tstcnottime, Me.ToolStripLabel3, Me.ToolStripLabel4})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 23)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1002, 51)
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
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(58, 48)
        Me.ToolStripLabel1.Text = "กลุ่มผู้ใช้"
        '
        'Tscbusergroup
        '
        Me.Tscbusergroup.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        Me.Tscbusergroup.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tscbusergroup.Name = "Tscbusergroup"
        Me.Tscbusergroup.Size = New System.Drawing.Size(121, 51)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(58, 48)
        Me.ToolStripLabel2.Text = "กลุ่มผู้ใช้"
        '
        'Tscbuser
        '
        Me.Tscbuser.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        Me.Tscbuser.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tscbuser.Name = "Tscbuser"
        Me.Tscbuser.Size = New System.Drawing.Size(121, 51)
        '
        'Tstcnottime
        '
        Me.Tstcnottime.BackColor = System.Drawing.Color.Transparent
        Me.Tstcnottime.Checked = True
        Me.Tstcnottime.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tstcnottime.Name = "Tstcnottime"
        Me.Tstcnottime.Size = New System.Drawing.Size(110, 48)
        Me.Tstcnottime.Text = "ไม่ระบุช่วงเวลา"
        Me.Tstcnottime.ToolStripCheckBoxEnabled = True
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(33, 48)
        Me.ToolStripLabel3.Text = "จาก"
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(24, 48)
        Me.ToolStripLabel4.Text = "ถึง"
        '
        'Formsystemlogsrpt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Formsystemlogsrpt"
        Me.Tag = "R103"
        Me.Text = "รายงาน Logs(Formsystemlogsrpt)"
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
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents Tscbusergroup As ToolStripComboBox
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents Tscbuser As ToolStripComboBox
    Friend WithEvents Tstcnottime As Egatlib.Ctrltoolstripcheckbox
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents ToolStripLabel4 As ToolStripLabel
End Class
