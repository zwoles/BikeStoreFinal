<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductMaintenance
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ProductIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Color = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ListPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RowguidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BikeStoreDataSet = New BikeStore.BikeStoreDataSet()
        Me.ProductTableAdapter = New BikeStore.BikeStoreDataSetTableAdapters.ProductTableAdapter()
        Me.btnAddProduct = New System.Windows.Forms.Button()
        Me.btnRemoveProd = New System.Windows.Forms.Button()
        Me.lblProdID = New System.Windows.Forms.Label()
        Me.lblColor = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblListPrice = New System.Windows.Forms.Label()
        Me.txtProdColor = New System.Windows.Forms.TextBox()
        Me.txtProdName = New System.Windows.Forms.TextBox()
        Me.txtListPrice = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.mskProductID = New System.Windows.Forms.MaskedTextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BikeStoreDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductIDDataGridViewTextBoxColumn, Me.Color, Me.NameDataGridViewTextBoxColumn, Me.ColorDataGridViewTextBoxColumn, Me.ListPriceDataGridViewTextBoxColumn, Me.RowguidDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ProductBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(18, 14)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(608, 352)
        Me.DataGridView1.TabIndex = 0
        '
        'ProductIDDataGridViewTextBoxColumn
        '
        Me.ProductIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID"
        Me.ProductIDDataGridViewTextBoxColumn.HeaderText = "ProductID"
        Me.ProductIDDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.ProductIDDataGridViewTextBoxColumn.Name = "ProductIDDataGridViewTextBoxColumn"
        Me.ProductIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProductIDDataGridViewTextBoxColumn.Width = 150
        '
        'Color
        '
        Me.Color.DataPropertyName = "Color"
        Me.Color.HeaderText = "Color"
        Me.Color.MinimumWidth = 8
        Me.Color.Name = "Color"
        Me.Color.Width = 150
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.Width = 150
        '
        'ColorDataGridViewTextBoxColumn
        '
        Me.ColorDataGridViewTextBoxColumn.DataPropertyName = "Color"
        Me.ColorDataGridViewTextBoxColumn.HeaderText = "Color"
        Me.ColorDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.ColorDataGridViewTextBoxColumn.Name = "ColorDataGridViewTextBoxColumn"
        Me.ColorDataGridViewTextBoxColumn.Width = 150
        '
        'ListPriceDataGridViewTextBoxColumn
        '
        Me.ListPriceDataGridViewTextBoxColumn.DataPropertyName = "ListPrice"
        Me.ListPriceDataGridViewTextBoxColumn.HeaderText = "ListPrice"
        Me.ListPriceDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.ListPriceDataGridViewTextBoxColumn.Name = "ListPriceDataGridViewTextBoxColumn"
        Me.ListPriceDataGridViewTextBoxColumn.Width = 150
        '
        'RowguidDataGridViewTextBoxColumn
        '
        Me.RowguidDataGridViewTextBoxColumn.DataPropertyName = "rowguid"
        Me.RowguidDataGridViewTextBoxColumn.HeaderText = "rowguid"
        Me.RowguidDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.RowguidDataGridViewTextBoxColumn.Name = "RowguidDataGridViewTextBoxColumn"
        Me.RowguidDataGridViewTextBoxColumn.Width = 150
        '
        'ProductBindingSource
        '
        Me.ProductBindingSource.DataMember = "Product"
        Me.ProductBindingSource.DataSource = Me.BikeStoreDataSet
        '
        'BikeStoreDataSet
        '
        Me.BikeStoreDataSet.DataSetName = "BikeStoreDataSet"
        Me.BikeStoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductTableAdapter
        '
        Me.ProductTableAdapter.ClearBeforeFill = True
        '
        'btnAddProduct
        '
        Me.btnAddProduct.Location = New System.Drawing.Point(18, 389)
        Me.btnAddProduct.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddProduct.Name = "btnAddProduct"
        Me.btnAddProduct.Size = New System.Drawing.Size(125, 24)
        Me.btnAddProduct.TabIndex = 1
        Me.btnAddProduct.Text = "Click to Add Product"
        Me.btnAddProduct.UseVisualStyleBackColor = True
        '
        'btnRemoveProd
        '
        Me.btnRemoveProd.Location = New System.Drawing.Point(148, 389)
        Me.btnRemoveProd.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRemoveProd.Name = "btnRemoveProd"
        Me.btnRemoveProd.Size = New System.Drawing.Size(154, 24)
        Me.btnRemoveProd.TabIndex = 2
        Me.btnRemoveProd.Text = "Click to Remove Product"
        Me.btnRemoveProd.UseVisualStyleBackColor = True
        '
        'lblProdID
        '
        Me.lblProdID.AutoSize = True
        Me.lblProdID.Location = New System.Drawing.Point(15, 432)
        Me.lblProdID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblProdID.Name = "lblProdID"
        Me.lblProdID.Size = New System.Drawing.Size(114, 13)
        Me.lblProdID.TabIndex = 3
        Me.lblProdID.Text = "Enter New Product ID:"
        '
        'lblColor
        '
        Me.lblColor.AutoSize = True
        Me.lblColor.Location = New System.Drawing.Point(15, 460)
        Me.lblColor.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(127, 13)
        Me.lblColor.TabIndex = 4
        Me.lblColor.Text = "Enter New Product Color:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(15, 487)
        Me.lblName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(131, 13)
        Me.lblName.TabIndex = 5
        Me.lblName.Text = "Enter New Product Name:"
        '
        'lblListPrice
        '
        Me.lblListPrice.AutoSize = True
        Me.lblListPrice.Location = New System.Drawing.Point(15, 513)
        Me.lblListPrice.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblListPrice.Name = "lblListPrice"
        Me.lblListPrice.Size = New System.Drawing.Size(146, 13)
        Me.lblListPrice.TabIndex = 6
        Me.lblListPrice.Text = "Enter New Product List Price:"
        '
        'txtProdColor
        '
        Me.txtProdColor.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "Color", True))
        Me.txtProdColor.Location = New System.Drawing.Point(163, 456)
        Me.txtProdColor.Margin = New System.Windows.Forms.Padding(2)
        Me.txtProdColor.Name = "txtProdColor"
        Me.txtProdColor.Size = New System.Drawing.Size(140, 20)
        Me.txtProdColor.TabIndex = 8
        '
        'txtProdName
        '
        Me.txtProdName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "Name", True))
        Me.txtProdName.Location = New System.Drawing.Point(163, 483)
        Me.txtProdName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtProdName.Name = "txtProdName"
        Me.txtProdName.Size = New System.Drawing.Size(140, 20)
        Me.txtProdName.TabIndex = 9
        '
        'txtListPrice
        '
        Me.txtListPrice.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "ListPrice", True))
        Me.txtListPrice.Location = New System.Drawing.Point(163, 509)
        Me.txtListPrice.Margin = New System.Windows.Forms.Padding(2)
        Me.txtListPrice.Name = "txtListPrice"
        Me.txtListPrice.Size = New System.Drawing.Size(140, 20)
        Me.txtListPrice.TabIndex = 10
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(18, 551)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(81, 24)
        Me.btnClear.TabIndex = 11
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(117, 551)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(89, 24)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(457, 389)
        Me.btnPrevious.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(116, 21)
        Me.btnPrevious.TabIndex = 18
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(323, 389)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(116, 21)
        Me.btnNext.TabIndex = 17
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'mskProductID
        '
        Me.mskProductID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "ProductID", True))
        Me.mskProductID.Location = New System.Drawing.Point(163, 429)
        Me.mskProductID.Mask = "0000"
        Me.mskProductID.Name = "mskProductID"
        Me.mskProductID.Size = New System.Drawing.Size(139, 20)
        Me.mskProductID.TabIndex = 19
        Me.mskProductID.ValidatingType = GetType(Integer)
        '
        'frmProductMaintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(673, 601)
        Me.Controls.Add(Me.mskProductID)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtListPrice)
        Me.Controls.Add(Me.txtProdName)
        Me.Controls.Add(Me.txtProdColor)
        Me.Controls.Add(Me.lblListPrice)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblColor)
        Me.Controls.Add(Me.lblProdID)
        Me.Controls.Add(Me.btnRemoveProd)
        Me.Controls.Add(Me.btnAddProduct)
        Me.Controls.Add(Me.DataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmProductMaintenance"
        Me.Text = "Product Maintenance"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BikeStoreDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BikeStoreDataSet As BikeStoreDataSet
    Friend WithEvents ProductBindingSource As BindingSource
    Friend WithEvents ProductTableAdapter As BikeStoreDataSetTableAdapters.ProductTableAdapter
    Friend WithEvents ProductIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Color As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ColorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ListPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RowguidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnAddProduct As Button
    Friend WithEvents btnRemoveProd As Button
    Friend WithEvents lblProdID As Label
    Friend WithEvents lblColor As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblListPrice As Label
    Friend WithEvents txtProdColor As TextBox
    Friend WithEvents txtProdName As TextBox
    Friend WithEvents txtListPrice As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents mskProductID As MaskedTextBox
End Class
