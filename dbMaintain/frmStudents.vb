﻿Imports System.Data
Imports System.Data.SqlClient

Public Class frmStudent


    Private Sub frmStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

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

        Dim xid As String = txtId.Text.Trim
        Dim xName As String = txtName.Text.Trim
        Dim xpassword As String = txtPassword.Text.Trim

        Dim str1 As String = "INSERT INTO student VALUES (" & xid & ",'" & xName & "'," & xpassword & ")"
        MsgBox(str1)

        Dim com1 As New SqlCommand
        com1.CommandText = str1
        com1.Connection = mycon

        Dim rec As Integer
        rec = com1.ExecuteNonQuery()


        If rec > 0 Then
            MessageBox.Show("บันทึกเรียบร้อย", "ข้อความ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtId.Clear()
            txtName.Clear()
            txtPassword.Clear()
            txtId.Focus()

        End If




    End Sub
End Class