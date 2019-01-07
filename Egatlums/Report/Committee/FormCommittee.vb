Imports Egatlib
Imports Microsoft.Reporting.WinForms
Public Class FormCommittee
    Private Sub Tsbreports_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FormCommittee_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' ============  Add list to ComboBox ExportList  ============ '
        Dim _ListReport() As String = {"เลือกรายการ", "สมัครใหม่", "การสิ้นสภาพ", "คำสั่งแต่งตั้ง", "ยอดสรุปอนุกรรมการ"}
        For i = 0 To _ListReport.Length - 1
            ExportList.Items.Add(_ListReport(i))
        Next
        ExportList.SelectedIndex = 0

        ' ============  Add list to ComboBox ExportList  ============ '
        Dim _ListDate() As String = {"รายชื่อทั้งหมด", "กำหนดช่วงเวลา", "รายชื่อประจำเดือน"}
        For i = 0 To _ListDate.Length - 1
            FilterDate.Items.Add(_ListDate(i))
        Next
        FilterDate.SelectedIndex = 0

        CreateListBox("SELECT Area_name FROM COM_Area", "Area_name")
    End Sub

    ' <==========================================>
    '<====   Start Sub Or Function $Pa_Dev>   ====>
    ' <==========================================>

    ' ============  Add list to ComboBox CbListArea  ============ '
    Private Sub CreateListBox(SqlCommandList As String, NameColumn As String)
        Dim Tcom_area = New DataTable
        Tcom_area = SQLCommand(SqlCommandList)

        Dim _ListNameArea(Tcom_area.Rows.Count) As String
        For i = 0 To _ListNameArea.Length - 1
            _ListNameArea(i) = If(i = 0, "เลือกทั้งหมด", Tcom_area(i - 1)(NameColumn))
            CbListArea.Items.Add(_ListNameArea(i))
        Next
        CbListArea.SelectedIndex = 0
    End Sub

    Private Sub FilterDate_Click(sender As Object, e As EventArgs) Handles FilterDate.SelectedIndexChanged
        Select Case FilterDate.SelectedIndex
            Case 0
                TextDate.Visible = False
                Dtpfm.Visible = False
                TextTo.Visible = False
                Dtpto.Visible = False
                TextMonth.Visible = False
                DtpMonth.Visible = False
            Case 1
                TextDate.Visible = True
                Dtpfm.Visible = True
                TextTo.Visible = True
                Dtpto.Visible = True
                TextMonth.Visible = False
                DtpMonth.Visible = False
            Case 2
                TextDate.Visible = False
                Dtpfm.Visible = False
                TextTo.Visible = False
                Dtpto.Visible = False
                TextMonth.Visible = True
                DtpMonth.Visible = True
            Case Else
                Informmessage("Select Item Error")
        End Select
    End Sub
End Class