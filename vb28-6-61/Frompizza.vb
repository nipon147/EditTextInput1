Public Class Frompizza

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtCreditNumber.TextChanged

    End Sub


    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles rdoMedium.CheckedChanged
        If rdoMedium.Checked Then
            labelSize.Text = rdoMedium.Text
            labelPrice.Text = "250"

            chkPrice()

            'Dim price As Integer = Val(labelPrice.Text)
            'Dim topping As Integer = Val(LabelToppingPrice.Text)
            'Dim total As Integer


            'total = price + topping

            'LabelToppingPrice.Text = topping.ToString
            'labelTotal.Text = total.ToString

            PictureBoxPizza.Image = Image.FromFile("D:\M\vb28-6-61\pics\pizzaMedium.jpg")
        End If

    End Sub

    Private Sub rdoSmall_CheckedChanged(sender As Object, e As EventArgs) Handles rdoSmall.CheckedChanged
        If rdoSmall.Checked Then
            labelSize.Text = rdoSmall.Text
            labelPrice.Text = "150"

            chkPrice()

            'Dim price As Integer = Val(labelPrice.Text)
            'Dim topping As Integer = Val(LabelToppingPrice.Text)
            'Dim total As Integer


            'total = price + topping

            'LabelToppingPrice.Text = topping.ToString
            'labelTotal.Text = total.ToString

            PictureBoxPizza.Image = Image.FromFile("D:\M\vb28-6-61\pics\pizzaSmall.png")



        End If
    End Sub

    Private Sub Frompizza_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCreditNumber.Enabled = False
        rdoSmall.Checked = True
        rdoCash.Checked = True
        labelSize.Text = rdoSmall.Text
        labelPrice.Text = "150"
        LabelToppingPrice.Text = "0"
        labelTotal.Text = Val(LabelToppingPrice.Text + labelPrice.Text)


        PictureBoxPizza.SizeMode = PictureBoxSizeMode.StretchImage

        PictureBoxPizza.Image = Image.FromFile("D:\M\vb28-6-61\pics\pizzaSmall.png")


    End Sub

    Private Sub rdoLarge_CheckedChanged(sender As Object, e As EventArgs) Handles rdoLarge.CheckedChanged
        If rdoLarge.Checked Then
            labelSize.Text = rdoLarge.Text
            labelPrice.Text = "400"

            chkPrice()

            'Dim price As Integer = Val(labelPrice.Text)
            'Dim topping As Integer = Val(LabelToppingPrice.Text)
            'Dim total As Integer


            'total = price + topping

            'LabelToppingPrice.Text = topping.ToString
            'labelTotal.Text = total.ToString

            PictureBoxPizza.Image = Image.FromFile("D:\M\vb28-6-61\pics\pizzaLarge.png")
        End If
    End Sub

    Private Sub chkBecon_CheckedChanged(sender As Object, e As EventArgs) Handles chkBecon.CheckedChanged
        If chkBecon.Checked Then
            LabelToppingPrice.Text = Val(LabelToppingPrice.Text) + 5
            labelTotal.Text = Val(labelTotal.Text) + 5
        Else
            LabelToppingPrice.Text = Val(LabelToppingPrice.Text) - 5
            labelTotal.Text = Val(labelTotal.Text) - 5
        End If
    End Sub

    Private Sub chkCheese_CheckedChanged(sender As Object, e As EventArgs) Handles chkCheese.CheckedChanged
        If chkCheese.Checked Then
            LabelToppingPrice.Text = Val(LabelToppingPrice.Text) + 5
            labelTotal.Text = Val(labelTotal.Text) + 5
        Else
            LabelToppingPrice.Text = Val(LabelToppingPrice.Text) - 5
            labelTotal.Text = Val(labelTotal.Text) - 5
        End If
    End Sub

    Private Sub chkTuna_CheckedChanged(sender As Object, e As EventArgs) Handles chkTuna.CheckedChanged
        If chkTuna.Checked Then
            LabelToppingPrice.Text = Val(LabelToppingPrice.Text) + 5
            labelTotal.Text = Val(labelTotal.Text) + 5
        Else
            LabelToppingPrice.Text = Val(LabelToppingPrice.Text) - 5
            labelTotal.Text = Val(labelTotal.Text) - 5
        End If
    End Sub

    Private Sub chkBerry_CheckedChanged(sender As Object, e As EventArgs) Handles chkBerry.CheckedChanged
        If chkBerry.Checked Then
            LabelToppingPrice.Text = Val(LabelToppingPrice.Text) + 5
            labelTotal.Text = Val(labelTotal.Text) + 5
        Else
            LabelToppingPrice.Text = Val(LabelToppingPrice.Text) - 5
            labelTotal.Text = Val(labelTotal.Text) - 5
        End If
    End Sub

    Sub chkPrice()

        Dim price As Integer = Val(labelPrice.Text)
        Dim topping As Integer = Val(LabelToppingPrice.Text)
        Dim total As Integer


        total = price + topping

        LabelToppingPrice.Text = topping.ToString
        labelTotal.Text = total.ToString
    End Sub

    Private Sub rdoCreditCard_CheckedChanged(sender As Object, e As EventArgs) Handles rdoCreditCard.CheckedChanged
        If rdoCreditCard.Checked Then
            txtCreditNumber.Enabled = True
            txtCreditNumber.Text = ""
        Else
            txtCreditNumber.Enabled = False
            txtCreditNumber.Text = ""
            txtCreditNumber.Clear()

        End If
    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub rdoCash_CheckedChanged(sender As Object, e As EventArgs) Handles rdoCash.CheckedChanged
        If rdoCash.Checked Then
            txtCreditNumber.Enabled = True
            txtCreditNumber.Text = ""
        Else
            txtCreditNumber.Enabled = False
            txtCreditNumber.Text = ""
        End If
    End Sub
End Class