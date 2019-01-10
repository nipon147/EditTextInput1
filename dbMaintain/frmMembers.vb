Imports System.Data
Imports System.Data.SqlClient
Public Class fmAddMember





    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim mycon As New SqlConnection
        mycon.ConnectionString = "Data Source=(local);initial catalog=TestDB;Integrated Security=True"
        mycon.Open()

        If txtId.Text = "" Then
            MsgBox("โปรดป้อนรหัส")
            txtId.Focus()
            Exit Sub
        End If
        If txtName.Text = "" Then
            MsgBox("โปรดป้อนรหัส")
            txtName.Focus()
            Exit Sub
        End If
        If txtPassword.Text = "" Then
            MsgBox("โปรดป้อนรหัส")
            txtPassword.Focus()
            Exit Sub
        End If

        Dim xId As String = txtId.Text.Trim
        Dim xName As String = txtName.Text.Trim
        Dim xPassword As String = txtPassword.Text.Trim

        Dim str1 As String = "INSERT INTO members VALUES ('" & xId & "','" & xName & " ','" & xPassword & "')"
        MsgBox(str1)

        Dim com1 As New SqlCommand
        com1.CommandText = str1
        com1.Connection = mycon



        Dim rec As Integer
        rec = com1.ExecuteNonQuery()


        If rec > 0 Then
            MessageBox.Show("ข้อความ", "บันทึกเรียบร้อย", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtId.Clear()
            txtName.Clear()
            txtPassword.Clear()
            txtId.Focus()

        End If
        com1.ExecuteNonQuery()








    End Sub
End Class
