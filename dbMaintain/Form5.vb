Imports System.Data
Imports System.Data.SqlClient

Public Class Form5
    Dim mycon As New SqlConnection
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Label5.Text = "ยังไม่จบการศึกษา"
        CheckBox1.Checked = False

        mycon.ConnectionString = connectionstring
        If mycon.State = ConnectionState.Closed Then
            mycon.Open()
        End If


        Dim str1 As String = "select * from Region"
        Dim dt1 As New DataTable
        Dim adap1 As New SqlDataAdapter(str1, mycon)


        adap1.Fill(dt1)

        ComboBox1.DataSource = dt1
        ComboBox1.DisplayMember = "Regiondescription"
        ComboBox1.ValueMember = "RegionId"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Label4.Text = ComboBox1.Text.Trim & " : " & ComboBox1.SelectedIndex


    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            Label5.Text = CheckBox1.Text
        Else
            Label5.Text = "ยังไม่จบการศึกษา"
        End If
    End Sub
End Class