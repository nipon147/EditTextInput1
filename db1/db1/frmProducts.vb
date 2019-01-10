'
'
'เหลือ
'1.เช็คตัวเลข่องราคา
'2.เพิ่ม ปุ่ม 
'3.เพิ่ม ปุ่ม เลื่อนดูข้อมูล
'4.เปลี่ยนจากอ่านข้อความจากกริด เป็นอ่านจาก DB








Imports System.Data
Imports System.Data.SqlClient

Public Class frmProducts
    Dim clickBunttonName As String = ""

    Private Sub frmProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NorthwindDataSet.Products' table. You can move, or remove it, as needed.
        Me.ProductsTableAdapter.Fill(Me.NorthwindDataSet.Products)


        txtProductId.Text = Convert.ToInt32(DataGridView1.Rows(0).Cells(0).Value.ToString)

        txtProductName.Text = DataGridView1.Rows(0).Cells(1).Value.ToString

        txtUnitPrice.Text = Convert.ToDecimal(DataGridView1.Rows(0).Cells(3).Value.ToString)

        txtProductName.Enabled = False
        txtUnitPrice.Enabled = False

        lbl1.Visible = False
        txtProductId.Visible = False
        btnSave.Enabled = False
        btnNew.Enabled = True



    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        'ตรวจสอบความถูกต้องของข้อมูลรับเข้า ถ้าไม่ถูกต้องก็แจ้งผู้ใช้ แล้วไม่ทำต่อ
        If txtProductName.Text = "" Then
            MessageBox.Show("โปรดป้อนชื่อสินค้า", "ข้อความ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtProductName.Focus()
            Exit Sub
        End If

        If txtUnitPrice.Text = "" Then
            MessageBox.Show("โปรดป้อนราคา", "ข้อความ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtUnitPrice.Focus()
            Exit Sub

        End If

        Dim pname As String = txtProductName.Text.Trim
        Dim pprice As Integer = Val(txtUnitPrice.Text)


        'สร้่างอ็อบเจคสำหรับจัดการข้อมุล
        '1.การเชื่อมต่อ connection
        '2.คำสั่ง sql ที่ต้องการส่งไปยัง DB
        '3.อ็อบเจค Command / Adapter ที่เป็นผู้ส่ง (2)
        '4.อ็อบเจคสำหรับเก็บข้อมูล กรณีคำสั่ง2 เป็น Select

        Dim mycon As New SqlConnection
        mycon.ConnectionString = "Data Source=(local);Initial Catalog=Northwind;Integrated Security=True"
        mycon.Open()

        'ตรวจสอบว่าผู้ใช้กดปุ่มใดไว้ ก่อนทำการบันทึกตามเงื่อนไข เพิ่มใหม่/แก้ไขข้อมูลเก่า
        Select Case clickBunttonName
            Case "NewClick"
                Dim strInsert As String
                strInsert = "insert into products(ProductName,UnitPrice) values(' " & pname.ToString & "'," & pprice.ToString & ")"

                Try

                    Dim com1 As New SqlCommand(strInsert, mycon)
                    Dim rec As Integer
                    rec = com1.ExecuteNonQuery()

                    If rec > 0 Then

                        'จัดการปรับการแสดงผล / แจ้งผลการบันทึกแก่ผู้ใช้

                        MessageBox.Show("เพิ่มข้อมูลเรียบร้อย", "ข้อความ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtProductName.Text = ""
                        txtUnitPrice.Text = ""
                        txtProductName.Focus()
                        Me.ProductsTableAdapter.Fill(Me.NorthwindDataSet.Products)


                    End If



                Catch ex As Exception
                    MessageBox.Show(ex.Message, "ข้อความ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try


            Case "GridClick"

                Dim pid As String = txtProductId.Text.Trim
                Dim strUpdate As String
                strUpdate = "update products set ProductName = '" & pname.ToString & "',UnitPrice = " & pprice.ToString & " where productID = '" & pid.ToString & "'"



                Try


                    Dim com1 As New SqlCommand(strUpdate, mycon)
                    Dim rec As Integer
                    rec = com1.ExecuteNonQuery()

                    If rec > 0 Then

                        'จัดการปรับการแสดงผล / แจ้งผลการบันทึกแก่ผู้ใช้

                        MessageBox.Show("แก้ไขข้อมูลเรียบร้อย", "ข้อความ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtProductName.Text = ""
                        txtUnitPrice.Text = ""
                        txtProductName.Focus()
                        Me.ProductsTableAdapter.Fill(Me.NorthwindDataSet.Products)


                    End If



                Catch ex As Exception
                    MessageBox.Show(ex.Message, "ข้อความ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try


        End Select


    End Sub



    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click

        txtProductName.Enabled = True
        txtProductName.Focus()

        ' If txtProductName.Text = "" Then
        ' MessageBox.Show("โปรดป้อนชื่อสินค้า", "ข้อความ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ' txtProductName.Focus()
        ' Exit Sub
        ' End If

        Dim mycon As New SqlConnection
        mycon.ConnectionString = "Data Source=(local);Initial Catalog=Northwind;Integrated Security=True"
        mycon.Open()


        Dim pname As String = txtProductName.Text.Trim
        Dim strSelect As String

        If pname = "" Then

            strSelect = "Select productId,productName,UnitPrice from products"
        Else

            strSelect = "Select productId,productName,UnitPrice from products where productname like '%" & pname.ToString & "%'"

        End If

        Dim myAdap As New SqlDataAdapter(strSelect, mycon)
        Dim dt1 As New DataTable



        myAdap.Fill(dt1)


        DataGridView1.DataSource = dt1



    End Sub


    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click

        clickBunttonName = "GridClick"

        btnSave.Enabled = True
        txtProductName.Enabled = True
        txtUnitPrice.Enabled = True
        btnNew.Enabled = True

        Dim rowIndex As String
        rowIndex = DataGridView1.CurrentRow.Index

        Dim Xid As Integer
        Dim xName As String
        Dim xprice As Decimal

        Xid = Convert.ToInt32(DataGridView1.Rows(rowIndex).Cells(0).Value.ToString)

        xName = DataGridView1.Rows(rowIndex).Cells(1).Value.ToString

        xprice = Convert.ToDecimal(DataGridView1.Rows(rowIndex).Cells(3).Value.ToString)

        lbl1.Visible = True
        txtProductId.Visible = True
        lbl1.Enabled = False
        txtProductId.Enabled = False



        txtProductId.Text = Xid.ToString
        txtProductName.Text = xName.ToString
        txtUnitPrice.Text = xprice.ToString


    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click

        clickBunttonName = "NewClick"

        txtProductName.Enabled = True
        txtUnitPrice.Enabled = True

        txtProductId.Clear()
        txtProductName.Clear()
        txtUnitPrice.Clear()

        txtProductName.Focus()

        btnSave.Enabled = True
        btnNew.Enabled = False


    End Sub




    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtProductId.Clear()
        txtProductName.Clear()
        txtUnitPrice.Clear()

        txtProductId.Enabled = False
        txtProductId.Enabled = False
        txtUnitPrice.Enabled = False

        btnNew.Enabled = True

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim pID As String
        pID = txtProductId.Text


        If (MessageBox.Show("ยืนยันการลบหมายเลข:" & pID.ToString, "ข้อความ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes) Then


            Dim mycon As New SqlConnection
            mycon.ConnectionString = "Data Source=(local);Initial Catalog=Northwind;Integrated Security=True"
            mycon.Open()

            Dim strDelete As String
            strDelete = "DELETE FROM products WHERE ProductID = " & pID.ToString

            Dim com1 As New SqlCommand(strDelete, mycon)

            Dim numrow As Integer
            numrow = com1.ExecuteNonQuery

            If numrow > 0 Then
                MessageBox.Show("ข้อความถูกลบเรียบร้อย", "ข้อความ", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else

                MsgBox("ไม่สามารถลบข้อมูลได้")

            End If

            Me.ProductsTableAdapter.Fill(Me.NorthwindDataSet.Products)


            txtProductId.Clear()
            txtProductName.Clear()
            txtProductName.Enabled = False
            txtUnitPrice.Clear()
            txtProductId.Enabled = False

        End If

    End Sub

    Private Sub txtUnitPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUnitPrice.KeyPress


        'Dim x1 As Integer
        'x1 = Asc(e.KeyChar)

        'If (x1 < 48) Or (x1 > 57) Then
        '    If (x1 = 8) Then
        '        e.Handled = False
        '    Else

        '        e.Handled = True

        '    End If
        'End If

    End Sub







    Dim errProvider As New ErrorProvider

    Private Sub txt_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtUnitPrice.Validating, txtProductName.Validating
        Dim txt As TextBox = DirectCast(sender, TextBox)
        If (txt.Text.Length > 0) Then
            'ถ้ามีข้อมูล ก็ไม่แสดง error.
            errProvider.SetError(txt, "")
        Else
            'ถ้าช่องว่าง(ไม่กรอกอะไร) show an error.
            errProvider.SetError(txt, "โปรดกรอกข้อมูล")
        End If

    End Sub
    
    Private Sub txtProductId_TextChanged(sender As Object, e As EventArgs) Handles txtProductId.TextChanged

    End Sub

    Private Sub txtUnitPrice_TextChanged(sender As Object, e As EventArgs) Handles txtUnitPrice.TextChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub lbl1_Click(sender As Object, e As EventArgs) Handles lbl1.Click

    End Sub
End Class