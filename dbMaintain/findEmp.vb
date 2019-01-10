Imports System.Data
Imports System.Data.SqlClient
Public Class findEmp

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub



    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        Dim dt1 As New DataTable
        Dim mycon As New SqlConnection
        mycon.ConnectionString = "Data Source=(local);initial catalog=NorthWind;Integrated Security=True"
        mycon.Open()

        Dim xName As String = txtName.Text.Trim

        Dim StrAll As String = "SELECT EmployeeID,FirstName+' '+ LastName as Name,Title,Address,City,Country FROM Employees "
        Dim strselect As String

        If rdoAll.Checked Then
            strselect = StrAll
        Else

            If txtName.Text = "" Then
                MsgBox("โปรดป้อนรหัส")
                txtName.Focus()
                Exit Sub
            End If
            strselect = StrAll & " where FirstName like '%" & xName & "%' "
        End If


        Dim adap1 As New SqlDataAdapter(strselect, mycon)
        adap1.Fill(dt1)



        If dt1.Rows.Count > 0 Then
            DataGridView1.DataSource = dt1

        End If
    End Sub
End Class