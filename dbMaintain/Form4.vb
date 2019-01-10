Imports System.Data
Imports System.Data.SqlClient

Public Class Form4
    Dim mycon As New SqlConnection


    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mycon.ConnectionString = connectionstring
        If mycon.State = ConnectionState.Closed Then
            mycon.Open()
        End If


        Dim str1 As String = "select * from Region"
        Dim dt1 As New DataTable
        Dim adap1 As New SqlDataAdapter(str1, mycon)
        MsgBox("ไม่ทำงาน")

        adap1.Fill(dt1)

        ComboBox1.DataSource = dt1
        ComboBox1.DisplayMember = "Regiondescription"
        ComboBox1.ValueMember = "RegionId"

    End Sub
End Class