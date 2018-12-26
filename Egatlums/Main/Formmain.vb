Imports System.Windows.Forms
Imports Egatlib
Public Class Formmain
    Private Sub ReportToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ReportToolStripMenuItem1.Click
        Showformonpanel(Formsystemlogsrpt, Panel1)
    End Sub
    Private Sub ReportToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ReportToolStripMenuItem2.Click
        Showformonpanel(FormNewMemberrpt, Panel1)
    End Sub

    Private Sub CofigDatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CofigDatabaseToolStripMenuItem.Click
        Showdiaformcenter(Formdbconfig, Me)
    End Sub
    Private Sub Formmain_Load(sender As Object, e As EventArgs) Handles Me.Load
        Getdata()
        If Dbname = "Temp" Then
            Informmessage("ยังไม่ได้ทำการตั้งค่าฐานข้อมูล")
            Exit Sub
        End If
        Gbusergroupid = "100"
        Gbuserid = "10001"
        Gbusername = "Users"
        Gbcompanyname = "กฟผ"
        Gbcomid = "100"
        Gbreaau = True
        Gbwriau = True
        Gbcreau = True
        Gbdelau = True
        Gbseaau = True
        Gbpriau = True
        Gbexpau = True
        Gbcomputername = My.Computer.Name
        Gbusrprofname = My.User.Name
    End Sub

    Private Sub CommitteeNewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CommitteeNewToolStripMenuItem.Click
        Showformonpanel(FormCommitteeNew, Panel1)
    End Sub

    Private Sub CommitteeCancelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CommitteeCancelToolStripMenuItem.Click
        Showformonpanel(FormCommitteeCancel, Panel1)
    End Sub

    Private Sub CommitteeAppointToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CommitteeAppointToolStripMenuItem.Click
        Showformonpanel(FormCommitteeAppoint, Panel1)
    End Sub

    Private Sub CommitteeNoteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CommitteeNoteToolStripMenuItem.Click
        Showformonpanel(FormCommitteeNote, Panel1)
    End Sub

    Private Sub CommitteeTerminateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CommitteeTerminateToolStripMenuItem.Click
        Showformonpanel(FormCommitteeTerminate, Panel1)
    End Sub

    Private Sub CommitteeTeamToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CommitteeTeamToolStripMenuItem.Click
        Showformonpanel(FormCommitteeTeam, Panel1)
    End Sub

    Private Sub CommitteeReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CommitteeReportToolStripMenuItem.Click
        Showformonpanel(FormCommitteeReport, Panel1)
    End Sub
End Class
