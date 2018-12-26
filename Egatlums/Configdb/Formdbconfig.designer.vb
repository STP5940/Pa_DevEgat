<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formdbconfig
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Bsave = New Egatlib.Ctrlbutton()
        Me.Bcancel = New Egatlib.Ctrlbutton()
        Me.Btest = New Egatlib.Ctrlbutton()
        Me.Tbxpassword = New Egatlib.Ctrlnormtextbox()
        Me.Ctrlgenlabel4 = New Egatlib.Ctrllabel()
        Me.Tbxusername = New Egatlib.Ctrlnormtextbox()
        Me.Tbxdatabase = New Egatlib.Ctrlnormtextbox()
        Me.Tbxservers = New Egatlib.Ctrlnormtextbox()
        Me.Ctrlgenlabel3 = New Egatlib.Ctrllabel()
        Me.Ctrlgenlabel2 = New Egatlib.Ctrllabel()
        Me.Ctrlgenlabel1 = New Egatlib.Ctrllabel()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(384, 354)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.TabPage1.Controls.Add(Me.Bsave)
        Me.TabPage1.Controls.Add(Me.Bcancel)
        Me.TabPage1.Controls.Add(Me.Btest)
        Me.TabPage1.Controls.Add(Me.Tbxpassword)
        Me.TabPage1.Controls.Add(Me.Ctrlgenlabel4)
        Me.TabPage1.Controls.Add(Me.Tbxusername)
        Me.TabPage1.Controls.Add(Me.Tbxdatabase)
        Me.TabPage1.Controls.Add(Me.Tbxservers)
        Me.TabPage1.Controls.Add(Me.Ctrlgenlabel3)
        Me.TabPage1.Controls.Add(Me.Ctrlgenlabel2)
        Me.TabPage1.Controls.Add(Me.Ctrlgenlabel1)
        Me.TabPage1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(376, 328)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "ตั้งค่าฐานข้อมูล"
        '
        'Bsave
        '
        Me.Bsave.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Bsave.Location = New System.Drawing.Point(146, 254)
        Me.Bsave.Name = "Bsave"
        Me.Bsave.Size = New System.Drawing.Size(80, 35)
        Me.Bsave.TabIndex = 12
        Me.Bsave.Text = "บันทึก"
        Me.Bsave.UseVisualStyleBackColor = True
        '
        'Bcancel
        '
        Me.Bcancel.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Bcancel.Location = New System.Drawing.Point(258, 254)
        Me.Bcancel.Name = "Bcancel"
        Me.Bcancel.Size = New System.Drawing.Size(80, 35)
        Me.Bcancel.TabIndex = 11
        Me.Bcancel.Text = "ยกเลิก"
        Me.Bcancel.UseVisualStyleBackColor = True
        '
        'Btest
        '
        Me.Btest.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Btest.Location = New System.Drawing.Point(34, 254)
        Me.Btest.Name = "Btest"
        Me.Btest.Size = New System.Drawing.Size(80, 35)
        Me.Btest.TabIndex = 10
        Me.Btest.Text = "ทดสอบ"
        Me.Btest.UseVisualStyleBackColor = True
        '
        'Tbxpassword
        '
        Me.Tbxpassword.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Tbxpassword.Location = New System.Drawing.Point(76, 195)
        Me.Tbxpassword.Name = "Tbxpassword"
        Me.Tbxpassword.Size = New System.Drawing.Size(262, 27)
        Me.Tbxpassword.TabIndex = 9
        Me.Tbxpassword.Text = "Password"
        '
        'Ctrlgenlabel4
        '
        Me.Ctrlgenlabel4.AutoSize = True
        Me.Ctrlgenlabel4.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Ctrlgenlabel4.Location = New System.Drawing.Point(30, 66)
        Me.Ctrlgenlabel4.Name = "Ctrlgenlabel4"
        Me.Ctrlgenlabel4.Size = New System.Drawing.Size(72, 20)
        Me.Ctrlgenlabel4.TabIndex = 8
        Me.Ctrlgenlabel4.Text = "Database"
        '
        'Tbxusername
        '
        Me.Tbxusername.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Tbxusername.Location = New System.Drawing.Point(76, 142)
        Me.Tbxusername.Name = "Tbxusername"
        Me.Tbxusername.Size = New System.Drawing.Size(262, 27)
        Me.Tbxusername.TabIndex = 7
        Me.Tbxusername.Text = "SA"
        '
        'Tbxdatabase
        '
        Me.Tbxdatabase.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Tbxdatabase.Location = New System.Drawing.Point(76, 89)
        Me.Tbxdatabase.Name = "Tbxdatabase"
        Me.Tbxdatabase.Size = New System.Drawing.Size(262, 27)
        Me.Tbxdatabase.TabIndex = 6
        Me.Tbxdatabase.Text = "EGATLUDB"
        '
        'Tbxservers
        '
        Me.Tbxservers.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Tbxservers.Location = New System.Drawing.Point(76, 36)
        Me.Tbxservers.Name = "Tbxservers"
        Me.Tbxservers.Size = New System.Drawing.Size(262, 27)
        Me.Tbxservers.TabIndex = 5
        Me.Tbxservers.Text = "Servername"
        '
        'Ctrlgenlabel3
        '
        Me.Ctrlgenlabel3.AutoSize = True
        Me.Ctrlgenlabel3.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Ctrlgenlabel3.Location = New System.Drawing.Point(30, 172)
        Me.Ctrlgenlabel3.Name = "Ctrlgenlabel3"
        Me.Ctrlgenlabel3.Size = New System.Drawing.Size(70, 20)
        Me.Ctrlgenlabel3.TabIndex = 4
        Me.Ctrlgenlabel3.Text = "Password"
        '
        'Ctrlgenlabel2
        '
        Me.Ctrlgenlabel2.AutoSize = True
        Me.Ctrlgenlabel2.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Ctrlgenlabel2.Location = New System.Drawing.Point(30, 119)
        Me.Ctrlgenlabel2.Name = "Ctrlgenlabel2"
        Me.Ctrlgenlabel2.Size = New System.Drawing.Size(79, 20)
        Me.Ctrlgenlabel2.TabIndex = 2
        Me.Ctrlgenlabel2.Text = "User name"
        '
        'Ctrlgenlabel1
        '
        Me.Ctrlgenlabel1.AutoSize = True
        Me.Ctrlgenlabel1.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Ctrlgenlabel1.Location = New System.Drawing.Point(30, 13)
        Me.Ctrlgenlabel1.Name = "Ctrlgenlabel1"
        Me.Ctrlgenlabel1.Size = New System.Drawing.Size(82, 20)
        Me.Ctrlgenlabel1.TabIndex = 0
        Me.Ctrlgenlabel1.Text = "Server host"
        '
        'Formdbconfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 354)
        Me.ControlBox = False
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Formdbconfig"
        Me.Text = "Formdbconfig"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Tbxpassword As Egatlib.Ctrlnormtextbox
    Friend WithEvents Ctrlgenlabel4 As Egatlib.Ctrllabel
    Friend WithEvents Tbxusername As Egatlib.Ctrlnormtextbox
    Friend WithEvents Tbxdatabase As Egatlib.Ctrlnormtextbox
    Friend WithEvents Tbxservers As Egatlib.Ctrlnormtextbox
    Friend WithEvents Ctrlgenlabel3 As Egatlib.Ctrllabel
    Friend WithEvents Ctrlgenlabel2 As Egatlib.Ctrllabel
    Friend WithEvents Ctrlgenlabel1 As Egatlib.Ctrllabel
    Friend WithEvents Bsave As Egatlib.Ctrlbutton
    Friend WithEvents Bcancel As Egatlib.Ctrlbutton
    Friend WithEvents Btest As Egatlib.Ctrlbutton
End Class
