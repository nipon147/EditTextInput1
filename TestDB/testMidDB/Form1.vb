Imports System.Data
Imports System.Data.SqlClient

Public Class Form1
    Dim clickBunttonName As String = ""

    Dim mycon As New SqlConnection
    Private Sub btnFound_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        

        Dim MemId As String = txt1.Text.Trim
        Dim mycon As New SqlConnection

        Dim strSelect As String
        strSelect = "Select * from members Where memberID = '" & MemId.ToString & "'"

        mycon.ConnectionString = "Data Source=(local);Initial Catalog=TestDB;Integrated Security=True"
        mycon.Open()

        Dim adp1 As New SqlDataAdapter(strSelect, mycon)
        Dim dt1 As New DataTable
        adp1.Fill(dt1)

        If dt1.Rows.Count > 0 Then

            txt2.Text = dt1.Rows(0).Item(1).ToString
            txt3.Text = dt1.Rows(0).Item(2).ToString

        Else
            MsgBox("Data not Found")

        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txt1.Clear()
        txt2.Clear()
        txt3.Clear()

        txt1.Enabled = True
        txt2.Enabled = True
        txt3.Enabled = True

        txt1.Focus()

    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt1.Enabled = True
        txt1.Focus()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim XMemberID As String
        XMemberID = txt1.Text.Trim



        Dim XMemberName As String
        XMemberName = txt2.Text.Trim


        Dim XPassword As String
        XPassword = Val(txt3.Text)

        Dim strUpdate As String
        strUpdate =  update member set membername = " & XMemberName.ToString & ",password = ' " & XPassword.ToString & " ' where id = " & XmemberID.ToString

        Dim com1 As New SqlCommand(strUpdate, mycon)
        Dim recnum As Integer

        recnum = com1.ExecuteNonQuery()

        If recnum > 0 Then
            MsgBox("ปรับปรุงเรียบร้อยแล้ว")
        End If




    End Sub

    Private Sub txt1_TextChanged(sender As Object, e As EventArgs) Handles txt1.TextChanged

    End Sub
End Class
