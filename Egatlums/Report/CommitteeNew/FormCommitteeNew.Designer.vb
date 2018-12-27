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
        Me.WhereDate = New System.Windows.Forms.CheckBox()
        Me.WhereAll = New System.Windows.Forms.CheckBox()
        Me.TxtWhereDate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtWhere = New System.Windows.Forms.TextBox()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Tsbclose = New System.Windows.Forms.ToolStripButton()
        Me.Tsbreports = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox1.Controls.Add(Me.WhereDate)
        Me.GroupBox1.Controls.Add(Me.WhereAll)
        Me.GroupBox1.Controls.Add(Me.TxtWhereDate)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TxtWhere)
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
        'WhereDate
        '
        Me.WhereDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WhereDate.AutoSize = True
        Me.WhereDate.BackColor = System.Drawing.Color.WhiteSmoke
        Me.WhereDate.Location = New System.Drawing.Point(668, 38)
        Me.WhereDate.Name = "WhereDate"
        Me.WhereDate.Size = New System.Drawing.Size(111, 24)
        Me.WhereDate.TabIndex = 6
        Me.WhereDate.Text = "ค้นหาจากวันที่"
        Me.WhereDate.UseVisualStyleBackColor = False
        '
        'WhereAll
        '
        Me.WhereAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WhereAll.AutoSize = True
        Me.WhereAll.BackColor = System.Drawing.Color.WhiteSmoke
        Me.WhereAll.Checked = True
        Me.WhereAll.CheckState = System.Windows.Forms.CheckState.Checked
        Me.WhereAll.Location = New System.Drawing.Point(593, 38)
        Me.WhereAll.Name = "WhereAll"
        Me.WhereAll.Size = New System.Drawing.Size(69, 24)
        Me.WhereAll.TabIndex = 5
        Me.WhereAll.Text = "ทั้งหมด"
        Me.WhereAll.UseVisualStyleBackColor = False
        '
        'TxtWhereDate
        '
        Me.TxtWhereDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtWhereDate.CustomFormat = "MMMM yyyy"
        Me.TxtWhereDate.Enabled = False
        Me.TxtWhereDate.Location = New System.Drawing.Point(785, 36)
        Me.TxtWhereDate.Name = "TxtWhereDate"
        Me.TxtWhereDate.Size = New System.Drawing.Size(167, 27)
        Me.TxtWhereDate.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(535, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ค้นหา"
        '
        'TxtWhere
        '
        Me.TxtWhere.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtWhere.Location = New System.Drawing.Point(951, 36)
        Me.TxtWhere.Name = "TxtWhere"
        Me.TxtWhere.Size = New System.Drawing.Size(10, 27)
        Me.TxtWhere.TabIndex = 2
        Me.TxtWhere.Visible = False
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
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tsbclose, Me.Tsbreports})
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
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtWhere As TextBox
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents Tsbclose As ToolStripButton
    Friend WithEvents Tsbreports As ToolStripButton
    Friend WithEvents TxtWhereDate As DateTimePicker
    Friend WithEvents WhereDate As CheckBox
    Friend WithEvents WhereAll As CheckBox
End Class
