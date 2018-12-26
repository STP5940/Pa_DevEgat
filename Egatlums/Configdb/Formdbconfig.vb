Imports Egatlib
Public Class Formdbconfig
    Private Tstserversql, Tstportsql, Tstusernamesql, Tstpwdsql, Tstdbnamesql As String

    Private Sub Formdbconfig_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try

            If Dbname = "Temp" Then
                Informmessage("ยังไม่ได้ทำการตั้งค่าฐานข้อมูล")
                Exit Sub
            End If
            If Testconnection() = False Then
                Informmessage("ไม่สามารถเชื่อมต่อฐานข้อมูลได้")
                Exit Sub
            End If
            Tbxservers.Text = Servername
            Tbxusername.Text = Username
            Tbxpassword.Text = Password
            Tbxdatabase.Text = Dbname
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Btest_Click(sender As Object, e As EventArgs) Handles Btest.Click
        Try
            Tstserversql = Tbxservers.Text
            Tstusernamesql = Tbxusername.Text
            Tstpwdsql = Tbxpassword.Text
            Tstdbnamesql = Tbxdatabase.Text
            Try
                Conn.ConnectionString = "Server = '" & Tstserversql & "';  " _
                                             & "Database = '" & Tstdbnamesql & "'; " _
                                             & "User id = '" & Tstusernamesql & "'; " _
                                             & "Password = '" & Tstpwdsql & "'"
                Conn.Open()
                MsgBox("Test connection successful", MsgBoxStyle.Information, "Database Settings")
            Catch ex As Exception
                MsgBox("The system failed to establish a connection", MsgBoxStyle.Information, "Database Settings")
            End Try
            Call DisconnMy()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Bsave_Click(sender As Object, e As EventArgs) Handles Bsave.Click
        Try
            Tstserversql = Tbxservers.Text
            Tstusernamesql = Tbxusername.Text
            Tstpwdsql = Tbxpassword.Text
            Tstdbnamesql = Tbxdatabase.Text
            Try
                Conn.ConnectionString = "Server = '" & Tstserversql & "';  " _
                                         & "Database = '" & Tstdbnamesql & "'; " _
                                         & "User id = '" & Tstusernamesql & "'; " _
                                         & "Password = '" & Tstpwdsql & "'"
                Conn.Open()
                Dbname = Tbxdatabase.Text
                Servername = Tbxservers.Text
                Username = Tbxusername.Text
                Password = Tbxpassword.Text
                Call Savedata()
                Process.GetCurrentProcess.Kill()
                Me.Close()
            Catch ex As Exception
                MsgBox("The system failed to establish a connection", MsgBoxStyle.Information, "Database Settings")
            End Try
            Call DisconnMy()
        Catch ex As Exception
        End Try
    End Sub
    Private Function Testconnection() As Boolean
        Dim Tmpstatus As Boolean
        Tmpstatus = False
        Try
            Conn.ConnectionString = "Server = '" & Servername & "';  " _
                                         & "Database = '" & Dbname & "'; " _
                                         & "User id = '" & Username & "'; " _
                                         & "Password = '" & Password & "'"
            Conn.Open()
            Tmpstatus = True
        Catch ex As Exception
            Tmpstatus = False
        End Try
        Call DisconnMy()
        Return Tmpstatus
    End Function
    Private Sub Bcancel_Click(sender As Object, e As EventArgs) Handles Bcancel.Click
        Me.Close()
    End Sub


End Class