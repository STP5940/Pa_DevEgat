<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formmain
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CofigDatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ReportToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FormToolStripMenuItem, Me.ReportToolStripMenuItem, Me.CofigDatabaseToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1008, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'FormToolStripMenuItem
        '
        Me.FormToolStripMenuItem.Name = "FormToolStripMenuItem"
        Me.FormToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.FormToolStripMenuItem.Text = "Form"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReportToolStripMenuItem1, Me.ReportToolStripMenuItem2})
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.ReportToolStripMenuItem.Text = "Report"
        '
        'ReportToolStripMenuItem1
        '
        Me.ReportToolStripMenuItem1.Name = "ReportToolStripMenuItem1"
        Me.ReportToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.ReportToolStripMenuItem1.Text = "Report sample"
        '
        'CofigDatabaseToolStripMenuItem
        '
        Me.CofigDatabaseToolStripMenuItem.Name = "CofigDatabaseToolStripMenuItem"
        Me.CofigDatabaseToolStripMenuItem.Size = New System.Drawing.Size(99, 20)
        Me.CofigDatabaseToolStripMenuItem.Text = "Cofig Database"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1008, 705)
        Me.Panel1.TabIndex = 9
        '
        'ReportToolStripMenuItem2
        '
        Me.ReportToolStripMenuItem2.Name = "ReportToolStripMenuItem2"
        Me.ReportToolStripMenuItem2.Size = New System.Drawing.Size(152, 22)
        Me.ReportToolStripMenuItem2.Text = "New members"
        '
        'Formmain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "Formmain"
        Me.Text = "Formmain"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents FormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CofigDatabaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem2 As ToolStripMenuItem
End Class
