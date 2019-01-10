Public Class fmFood

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim foodprice As Integer
        Dim topping As Integer
        Dim total As Integer



        foodprice = 40
        topping = 15



        If CheckBox1.Checked Then
            total = foodprice + topping

            LblDisplay.Text = ListBox1.SelectedItem + CheckBox1.Text + " รวมเป็นเงิน " & total.ToString

        Else
            total = foodprice

            LblDisplay.Text = ListBox1.SelectedItem + " รวมเป็นเงิน " & total.ToString




        End If


    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Dim foodprice As Integer
        Dim topping As Integer
        Dim total As Integer



        foodprice = 40
        topping = 15



        If CheckBox1.Checked Then
            total = foodprice + topping

            LblDisplay.Text = ListBox1.SelectedItem + CheckBox1.Text + " รวมเป็นเงิน " & total.ToString

        Else

            total = foodprice

            LblDisplay.Text = ListBox1.SelectedItem + " รวมเป็นเงิน " & total.ToString

        End If

    End Sub
End Class