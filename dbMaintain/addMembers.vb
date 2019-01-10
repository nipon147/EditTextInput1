Imports System.Data
Imports System.Data.SqlClient

Public Class addMembers
    Dim mycon As New SqlConnection


    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click

        Dim xName As String
        Dim xStatus As Boolean


        If txtname.Text = "" Then
            MsgBox("Please Enter Name")
            txtname.Focus()
            Exit Sub
        Else
            xName = txtname.Text.Trim
        End If
        If chkAdmin.Checked Then
            xStatus = True
        Else
            xStatus = False

        End If

        Dim str2 As String

        str2 = "insert into members(username,status) values(@pName,@pstatus)"



        If mycon.State = ConnectionState.Closed Then
            mycon.Open()
        End If

        Try
            Dim com1 As New SqlCommand
            With com1
                .CommandText = str2
                .Connection = mycon
                .Parameters.Add("@pName", SqlDbType.NChar)
                .Parameters.Add("@pstatus", SqlDbType.Decimal)
                .Parameters("@pName").Value = xName
                .Parameters("@pstatus1").Value = xStatus
            End With

            Dim rec As Integer
            rec = com1.ExecuteNonQuery()
            If rec > 0 Then

                MsgBox("Insert Success!")
            Else
                MsgBox("Insert Error !")
            End If

        Catch ex As Exception
            MsgBox("พบข้อผิดพลาด:" & ex.ToString)
        End Try
       


    End Sub

    Private Sub addMembers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mycon.ConnectionString = connectionstring
    End Sub
End Class