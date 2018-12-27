<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCommitteeNew
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
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.Tstcnotdate = New Egatlib.Ctrltoolstripcheckbox()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.Tstcnottime = New Egatlib.Ctrltoolstripcheckbox()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
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
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "เงื่อนไขในการแสดงรายงาน"
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Egatlums.RptNewmember.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(3, 74)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ShowContextMenu = False
        Me.ReportViewer1.Size = New System.Drawing.Size(1053, 500)
        Me.ReportViewer1.TabIndex = 1
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tsbclose, Me.Tsbreports, Me.ToolStripSeparator1, Me.ToolStripLabel2, Me.Tstcnotdate, Me.ToolStripLabel4, Me.Tstcnottime, Me.ToolStripLabel1})
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
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 51)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(13, 48)
        Me.ToolStripLabel2.Text = " "
        '
        'Tstcnotdate
        '
        Me.Tstcnotdate.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Tstcnotdate.BackColor = System.Drawing.Color.Transparent
        Me.Tstcnotdate.Checked = False
        Me.Tstcnotdate.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tstcnotdate.Name = "Tstcnotdate"
        Me.Tstcnotdate.Size = New System.Drawing.Size(131, 48)
        Me.Tstcnotdate.Text = "รายชื่อประจำเดือน"
        Me.Tstcnotdate.ToolStripCheckBoxEnabled = True
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(13, 48)
        Me.ToolStripLabel4.Text = " "
        '
        'Tstcnottime
        '
        Me.Tstcnottime.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Tstcnottime.BackColor = System.Drawing.Color.Transparent
        Me.Tstcnottime.Checked = True
        Me.Tstcnottime.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tstcnottime.Name = "Tstcnottime"
        Me.Tstcnottime.Size = New System.Drawing.Size(107, 48)
        Me.Tstcnottime.Text = "รายชื่อทั้งหมด"
        Me.Tstcnottime.ToolStripCheckBoxEnabled = True
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(55, 48)
        Me.ToolStripLabel1.Text = "ค้นหา   "
        '
        'FormCommitteeNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1059, 577)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormCommitteeNew"
        Me.Text = "รายงานสมัครใหม่ (อนุกรรมการ สร.กฟผ.)"
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
    Friend WithEvents Tstcnottime As Egatlib.Ctrltoolstripcheckbox
    Friend WithEvents ToolStripLabel4 As ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents Tstcnotdate As Egatlib.Ctrltoolstripcheckbox
End Class
