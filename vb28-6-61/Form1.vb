Public Class Form1

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtIncomePerMonth.Clear()
        txtLoan.Clear()
        txtPayPerMonth.Clear()


        ListBoxInterrestRate.ClearSelected()
        ListBoxNumYear.ClearSelected()

    End Sub



    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click

        Dim vlone As Integer
        Dim vInterrest As Decimal




        vlone = txtLoan.Text

        vInterrest = ListBoxInterrestRate.SelectedItem

        test.Text = vlone
        test2.Text = vInterrest

    End Sub

    Private Sub txtLoan_TextChanged(sender As Object, e As EventArgs) Handles txtLoan.TextChanged

    End Sub

    Private Sub txtPayPerMonth_TextChanged(sender As Object, e As EventArgs) Handles txtPayPerMonth.TextChanged
        

    End Sub

    Private Sub ListBoxNumYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxNumYear.SelectedIndexChanged

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'get  input to value
        Dim vlone As Integer ' วงเงินกู้
        Dim vInterrest As Decimal ' อัตราดอกเบี้ย
        Dim vTotalLoan As Decimal ' เงินต้นรวม
        Dim vInterrestPerYear As Decimal ' ดอกเบี้ยต่อปี
        Dim vPayMent As Decimal ' ค่าส่งต่อเดือน
        Dim vNumYear As Integer ' จำนวนปี

        'อ่านคำจากแต่ละช่องที่ผู้ใช้เขียน แสดงในเครื่อง
        vlone = txtLoan.Text
        vInterrest = ListBoxInterrestRate.SelectedItem
        vNumYear = ListBoxNumYear.SelectedItem


        'calculateion
        'คำนวณหาดอกเบี้ยต่อปี = วงเงินกู้ * อัตราดอกเบี้ย
        vInterrestPerYear = vlone * vInterrest


        'เงินต้นรวม = วงเงินกู้ + (ดอกเบี้ยต่อ/ปี * จำนวนปี)
        vTotalLoan = vlone + (vInterrestPerYear * vNumYear)


        'ค่าส่งต่อเดือน = เงินต้นรวม / (จำนวนปี * 12 )

        vPayMent = vTotalLoan / (vNumYear * 12)


        'Display to form
        txtPayPerMonth.Text = vPayMent.ToString
        txtPayPerMonth.Enabled = False






    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnTest.Hide()
        test.Hide()
        test2.Hide()


        Me.BackColor = Color.BurlyWood
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles ChkStarEgg.CheckedChanged
        If ChkStarEgg.Checked Then
            MsgBox(ChkStarEgg.Text)
        Else
            MsgBox("ได้ยกเลิก" & ChkStarEgg.Text)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim vTest As Boolean

        vTest = ChkStarEgg.Checked

        If vTest Then
            MsgBox("คุณได้เลือกรายการพิเศษ")
        End If

    End Sub
End Class
