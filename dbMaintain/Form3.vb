Public Class Form3

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Label4.Text = ComboBox1.SelectedValue
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NorthwindDataSet._Region' table. You can move, or remove it, as needed.
        Me.RegionTableAdapter.Fill(Me.NorthwindDataSet._Region)

        Label4.Text = "ยังไม่จบการศึกษา"
        CheckBox1.Checked = False


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Label4.Text = ComboBox1.SelectedValue.ToString


    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            Label4.Text = CheckBox1.Text
            TextBox1.Enabled = False
        Else
            Label4.Text = "ยังไม่จบการศึกษา"
            TextBox1.Enabled = True
            TextBox2.Enabled = True
        End If

    End Sub
End Class