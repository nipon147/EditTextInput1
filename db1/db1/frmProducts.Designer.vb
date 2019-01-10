<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProducts
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.txtProductId = New System.Windows.Forms.TextBox()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.txtUnitPrice = New System.Windows.Forms.TextBox()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ProductIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoryIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitsInStockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NorthwindDataSet = New db1.NorthwindDataSet()
        Me.ProductsTableAdapter = New db1.NorthwindDataSetTableAdapters.ProductsTableAdapter()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NorthwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtProductId
        '
        Me.txtProductId.Location = New System.Drawing.Point(149, 65)
        Me.txtProductId.Name = "txtProductId"
        Me.txtProductId.Size = New System.Drawing.Size(123, 20)
        Me.txtProductId.TabIndex = 0
        '
        'txtProductName
        '
        Me.txtProductName.Location = New System.Drawing.Point(149, 111)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(181, 20)
        Me.txtProductName.TabIndex = 1
        '
        'txtUnitPrice
        '
        Me.txtUnitPrice.Location = New System.Drawing.Point(149, 161)
        Me.txtUnitPrice.Name = "txtUnitPrice"
        Me.txtUnitPrice.Size = New System.Drawing.Size(123, 20)
        Me.txtUnitPrice.TabIndex = 2
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl1.Location = New System.Drawing.Point(46, 63)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(66, 20)
        Me.lbl1.TabIndex = 3
        Me.lbl1.Text = "รหัสสินค้า"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(46, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "ชื่่อสินค้า"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(46, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "ราคาต่อหน่วย"
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSave.Location = New System.Drawing.Point(290, 154)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(98, 30)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "บันทึกข้อมูล"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductIDDataGridViewTextBoxColumn, Me.ProductNameDataGridViewTextBoxColumn, Me.CategoryIDDataGridViewTextBoxColumn, Me.UnitPriceDataGridViewTextBoxColumn, Me.UnitsInStockDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ProductsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(50, 235)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(463, 150)
        Me.DataGridView1.TabIndex = 8
        '
        'ProductIDDataGridViewTextBoxColumn
        '
        Me.ProductIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID"
        Me.ProductIDDataGridViewTextBoxColumn.HeaderText = "รหัสสินค้า"
        Me.ProductIDDataGridViewTextBoxColumn.Name = "ProductIDDataGridViewTextBoxColumn"
        Me.ProductIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProductNameDataGridViewTextBoxColumn
        '
        Me.ProductNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName"
        Me.ProductNameDataGridViewTextBoxColumn.HeaderText = "ProductName"
        Me.ProductNameDataGridViewTextBoxColumn.Name = "ProductNameDataGridViewTextBoxColumn"
        Me.ProductNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CategoryIDDataGridViewTextBoxColumn
        '
        Me.CategoryIDDataGridViewTextBoxColumn.DataPropertyName = "CategoryID"
        Me.CategoryIDDataGridViewTextBoxColumn.HeaderText = "CategoryID"
        Me.CategoryIDDataGridViewTextBoxColumn.Name = "CategoryIDDataGridViewTextBoxColumn"
        Me.CategoryIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UnitPriceDataGridViewTextBoxColumn
        '
        Me.UnitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice"
        Me.UnitPriceDataGridViewTextBoxColumn.HeaderText = "UnitPrice"
        Me.UnitPriceDataGridViewTextBoxColumn.Name = "UnitPriceDataGridViewTextBoxColumn"
        Me.UnitPriceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UnitsInStockDataGridViewTextBoxColumn
        '
        Me.UnitsInStockDataGridViewTextBoxColumn.DataPropertyName = "UnitsInStock"
        Me.UnitsInStockDataGridViewTextBoxColumn.HeaderText = "UnitInStock"
        Me.UnitsInStockDataGridViewTextBoxColumn.Name = "UnitsInStockDataGridViewTextBoxColumn"
        Me.UnitsInStockDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProductsBindingSource
        '
        Me.ProductsBindingSource.DataMember = "Products"
        Me.ProductsBindingSource.DataSource = Me.NorthwindDataSet
        '
        'NorthwindDataSet
        '
        Me.NorthwindDataSet.DataSetName = "NorthwindDataSet"
        Me.NorthwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductsTableAdapter
        '
        Me.ProductsTableAdapter.ClearBeforeFill = True
        '
        'btnFind
        '
        Me.btnFind.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnFind.Location = New System.Drawing.Point(353, 104)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(98, 30)
        Me.btnFind.TabIndex = 9
        Me.btnFind.Text = "ค้นหาสินค้า"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnNew.Location = New System.Drawing.Point(415, 154)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(98, 30)
        Me.btnNew.TabIndex = 10
        Me.btnNew.Text = "เพิ่มข้อมูล"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(415, 199)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(98, 30)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "ยกเลิก"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(531, 154)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(98, 30)
        Me.btnDelete.TabIndex = 12
        Me.btnDelete.Text = "ลบข้อมูล"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'frmProducts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 397)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnFind)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.txtUnitPrice)
        Me.Controls.Add(Me.txtProductName)
        Me.Controls.Add(Me.txtProductId)
        Me.Name = "frmProducts"
        Me.Text = "จัดการข้อมูลสินค้า"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NorthwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtProductId As System.Windows.Forms.TextBox
    Friend WithEvents txtProductName As System.Windows.Forms.TextBox
    Friend WithEvents txtUnitPrice As System.Windows.Forms.TextBox
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents NorthwindDataSet As db1.NorthwindDataSet
    Friend WithEvents ProductsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductsTableAdapter As db1.NorthwindDataSetTableAdapters.ProductsTableAdapter
    Friend WithEvents ProductIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CategoryIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnitPriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnitsInStockDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnFind As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
End Class
