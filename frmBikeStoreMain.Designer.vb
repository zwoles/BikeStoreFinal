<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBikeStoreMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBikeStoreMain))
        Me.ProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BikeStoreDataSet = New BikeStore.BikeStoreDataSet()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerTableAdapter = New BikeStore.BikeStoreDataSetTableAdapters.CustomerTableAdapter()
        Me.TableAdapterManager = New BikeStore.BikeStoreDataSetTableAdapters.TableAdapterManager()
        Me.CustomerBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CustomerBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ProductTableAdapter = New BikeStore.BikeStoreDataSetTableAdapters.ProductTableAdapter()
        Me.ProductBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.FKSalesOrderDetailProductProductIDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalesOrderDetailTableAdapter = New BikeStore.BikeStoreDataSetTableAdapters.SalesOrderDetailTableAdapter()
        Me.FKSalesOrderDetailProductProductIDBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalesOrderDetailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.grpLogin = New System.Windows.Forms.GroupBox()
        Me.cbPW = New System.Windows.Forms.CheckBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPW = New System.Windows.Forms.TextBox()
        Me.grpMain = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ProductIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StandardCostDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ListPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SizeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WeightDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductCategoryIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductModelIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SellStartDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SellEndDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiscontinuedDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ThumbNailPhotoDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ThumbnailPhotoFileNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RowguidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModifiedDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModifiedDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FKSalesOrderDetailProductProductIDBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.mskCustomerID = New System.Windows.Forms.MaskedTextBox()
        Me.mskQuantity = New System.Windows.Forms.MaskedTextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.btnAddToCart = New System.Windows.Forms.Button()
        Me.btnSearch1 = New System.Windows.Forms.Button()
        Me.txtProduct = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.btnProductMaintenance = New System.Windows.Forms.Button()
        Me.btnCustomerMaintenance = New System.Windows.Forms.Button()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.FKSalesOrderDetailProductProductIDBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.FKSalesOrderDetailProductProductIDBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblTotalPrice = New System.Windows.Forms.Label()
        Me.lstCart = New System.Windows.Forms.ListBox()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.grpCart = New System.Windows.Forms.GroupBox()
        Me.btnClearCart = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BikeStoreDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CustomerBindingNavigator.SuspendLayout()
        CType(Me.ProductBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKSalesOrderDetailProductProductIDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKSalesOrderDetailProductProductIDBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesOrderDetailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLogin.SuspendLayout()
        Me.grpMain.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKSalesOrderDetailProductProductIDBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        CType(Me.FKSalesOrderDetailProductProductIDBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKSalesOrderDetailProductProductIDBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCart.SuspendLayout()
        Me.SuspendLayout()
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
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "Customer"
        Me.CustomerBindingSource.DataSource = Me.BikeStoreDataSet
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AddressTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BuildVersionTableAdapter = Nothing
        Me.TableAdapterManager.CustomerAddressTableAdapter = Nothing
        Me.TableAdapterManager.CustomerTableAdapter = Me.CustomerTableAdapter
        Me.TableAdapterManager.ErrorLogTableAdapter = Nothing
        Me.TableAdapterManager.ProductCategoryTableAdapter = Nothing
        Me.TableAdapterManager.ProductDescriptionTableAdapter = Nothing
        Me.TableAdapterManager.ProductModelProductDescriptionTableAdapter = Nothing
        Me.TableAdapterManager.ProductModelTableAdapter = Nothing
        Me.TableAdapterManager.ProductTableAdapter = Nothing
        Me.TableAdapterManager.SalesOrderDetailTableAdapter = Nothing
        Me.TableAdapterManager.SalesOrderHeaderTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = BikeStore.BikeStoreDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CustomerBindingNavigator
        '
        Me.CustomerBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CustomerBindingNavigator.BindingSource = Me.CustomerBindingSource
        Me.CustomerBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CustomerBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CustomerBindingNavigator.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.CustomerBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CustomerBindingNavigatorSaveItem})
        Me.CustomerBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CustomerBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CustomerBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CustomerBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CustomerBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CustomerBindingNavigator.Name = "CustomerBindingNavigator"
        Me.CustomerBindingNavigator.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.CustomerBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CustomerBindingNavigator.Size = New System.Drawing.Size(1187, 31)
        Me.CustomerBindingNavigator.TabIndex = 1
        Me.CustomerBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 28)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 31)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(35, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 31)
        '
        'CustomerBindingNavigatorSaveItem
        '
        Me.CustomerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CustomerBindingNavigatorSaveItem.Image = CType(resources.GetObject("CustomerBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CustomerBindingNavigatorSaveItem.Name = "CustomerBindingNavigatorSaveItem"
        Me.CustomerBindingNavigatorSaveItem.Size = New System.Drawing.Size(28, 28)
        Me.CustomerBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ProductTableAdapter
        '
        Me.ProductTableAdapter.ClearBeforeFill = True
        '
        'ProductBindingSource1
        '
        Me.ProductBindingSource1.DataMember = "Product"
        Me.ProductBindingSource1.DataSource = Me.BikeStoreDataSet
        '
        'FKSalesOrderDetailProductProductIDBindingSource
        '
        Me.FKSalesOrderDetailProductProductIDBindingSource.DataMember = "FK_SalesOrderDetail_Product_ProductID"
        Me.FKSalesOrderDetailProductProductIDBindingSource.DataSource = Me.ProductBindingSource1
        '
        'SalesOrderDetailTableAdapter
        '
        Me.SalesOrderDetailTableAdapter.ClearBeforeFill = True
        '
        'FKSalesOrderDetailProductProductIDBindingSource1
        '
        Me.FKSalesOrderDetailProductProductIDBindingSource1.DataMember = "FK_SalesOrderDetail_Product_ProductID"
        Me.FKSalesOrderDetailProductProductIDBindingSource1.DataSource = Me.ProductBindingSource
        '
        'SalesOrderDetailBindingSource
        '
        Me.SalesOrderDetailBindingSource.DataMember = "SalesOrderDetail"
        Me.SalesOrderDetailBindingSource.DataSource = Me.BikeStoreDataSet
        '
        'grpLogin
        '
        Me.grpLogin.Controls.Add(Me.cbPW)
        Me.grpLogin.Controls.Add(Me.btnExit)
        Me.grpLogin.Controls.Add(Me.btnClear)
        Me.grpLogin.Controls.Add(Me.btnLogin)
        Me.grpLogin.Controls.Add(Me.Label1)
        Me.grpLogin.Controls.Add(Me.Label2)
        Me.grpLogin.Controls.Add(Me.txtUsername)
        Me.grpLogin.Controls.Add(Me.txtPW)
        Me.grpLogin.Location = New System.Drawing.Point(12, 34)
        Me.grpLogin.Name = "grpLogin"
        Me.grpLogin.Size = New System.Drawing.Size(1175, 553)
        Me.grpLogin.TabIndex = 2
        Me.grpLogin.TabStop = False
        '
        'cbPW
        '
        Me.cbPW.AutoSize = True
        Me.cbPW.Location = New System.Drawing.Point(465, 201)
        Me.cbPW.Name = "cbPW"
        Me.cbPW.Size = New System.Drawing.Size(102, 17)
        Me.cbPW.TabIndex = 14
        Me.cbPW.Text = "Show Password"
        Me.cbPW.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(548, 229)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(67, 31)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(458, 229)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(67, 31)
        Me.btnClear.TabIndex = 12
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(368, 229)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(67, 31)
        Me.btnLogin.TabIndex = 11
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(368, 176)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 15)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Password"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(368, 132)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 15)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "User Name"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(465, 132)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(2)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(151, 20)
        Me.txtUsername.TabIndex = 8
        '
        'txtPW
        '
        Me.txtPW.Location = New System.Drawing.Point(465, 176)
        Me.txtPW.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPW.Name = "txtPW"
        Me.txtPW.Size = New System.Drawing.Size(151, 20)
        Me.txtPW.TabIndex = 7
        '
        'grpMain
        '
        Me.grpMain.Controls.Add(Me.GroupBox4)
        Me.grpMain.Controls.Add(Me.TabControl2)
        Me.grpMain.Location = New System.Drawing.Point(12, 34)
        Me.grpMain.Name = "grpMain"
        Me.grpMain.Size = New System.Drawing.Size(1120, 289)
        Me.grpMain.TabIndex = 3
        Me.grpMain.TabStop = False
        Me.grpMain.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.DataGridView1)
        Me.GroupBox4.Controls.Add(Me.DataGridView2)
        Me.GroupBox4.Location = New System.Drawing.Point(493, 53)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(527, 227)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductIDDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.StandardCostDataGridViewTextBoxColumn, Me.ListPriceDataGridViewTextBoxColumn, Me.SizeDataGridViewTextBoxColumn, Me.WeightDataGridViewTextBoxColumn, Me.ProductCategoryIDDataGridViewTextBoxColumn, Me.ProductModelIDDataGridViewTextBoxColumn, Me.SellStartDateDataGridViewTextBoxColumn, Me.SellEndDateDataGridViewTextBoxColumn, Me.DiscontinuedDateDataGridViewTextBoxColumn, Me.ThumbNailPhotoDataGridViewImageColumn, Me.ThumbnailPhotoFileNameDataGridViewTextBoxColumn, Me.RowguidDataGridViewTextBoxColumn, Me.ModifiedDateDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ProductBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(6, 129)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.Size = New System.Drawing.Size(521, 98)
        Me.DataGridView1.TabIndex = 1
        Me.DataGridView1.Visible = False
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
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.Width = 150
        '
        'StandardCostDataGridViewTextBoxColumn
        '
        Me.StandardCostDataGridViewTextBoxColumn.DataPropertyName = "StandardCost"
        Me.StandardCostDataGridViewTextBoxColumn.HeaderText = "StandardCost"
        Me.StandardCostDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.StandardCostDataGridViewTextBoxColumn.Name = "StandardCostDataGridViewTextBoxColumn"
        Me.StandardCostDataGridViewTextBoxColumn.Width = 150
        '
        'ListPriceDataGridViewTextBoxColumn
        '
        Me.ListPriceDataGridViewTextBoxColumn.DataPropertyName = "ListPrice"
        Me.ListPriceDataGridViewTextBoxColumn.HeaderText = "ListPrice"
        Me.ListPriceDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.ListPriceDataGridViewTextBoxColumn.Name = "ListPriceDataGridViewTextBoxColumn"
        Me.ListPriceDataGridViewTextBoxColumn.Width = 150
        '
        'SizeDataGridViewTextBoxColumn
        '
        Me.SizeDataGridViewTextBoxColumn.DataPropertyName = "Size"
        Me.SizeDataGridViewTextBoxColumn.HeaderText = "Size"
        Me.SizeDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.SizeDataGridViewTextBoxColumn.Name = "SizeDataGridViewTextBoxColumn"
        Me.SizeDataGridViewTextBoxColumn.Width = 150
        '
        'WeightDataGridViewTextBoxColumn
        '
        Me.WeightDataGridViewTextBoxColumn.DataPropertyName = "Weight"
        Me.WeightDataGridViewTextBoxColumn.HeaderText = "Weight"
        Me.WeightDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.WeightDataGridViewTextBoxColumn.Name = "WeightDataGridViewTextBoxColumn"
        Me.WeightDataGridViewTextBoxColumn.Width = 150
        '
        'ProductCategoryIDDataGridViewTextBoxColumn
        '
        Me.ProductCategoryIDDataGridViewTextBoxColumn.DataPropertyName = "ProductCategoryID"
        Me.ProductCategoryIDDataGridViewTextBoxColumn.HeaderText = "ProductCategoryID"
        Me.ProductCategoryIDDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.ProductCategoryIDDataGridViewTextBoxColumn.Name = "ProductCategoryIDDataGridViewTextBoxColumn"
        Me.ProductCategoryIDDataGridViewTextBoxColumn.Width = 150
        '
        'ProductModelIDDataGridViewTextBoxColumn
        '
        Me.ProductModelIDDataGridViewTextBoxColumn.DataPropertyName = "ProductModelID"
        Me.ProductModelIDDataGridViewTextBoxColumn.HeaderText = "ProductModelID"
        Me.ProductModelIDDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.ProductModelIDDataGridViewTextBoxColumn.Name = "ProductModelIDDataGridViewTextBoxColumn"
        Me.ProductModelIDDataGridViewTextBoxColumn.Width = 150
        '
        'SellStartDateDataGridViewTextBoxColumn
        '
        Me.SellStartDateDataGridViewTextBoxColumn.DataPropertyName = "SellStartDate"
        Me.SellStartDateDataGridViewTextBoxColumn.HeaderText = "SellStartDate"
        Me.SellStartDateDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.SellStartDateDataGridViewTextBoxColumn.Name = "SellStartDateDataGridViewTextBoxColumn"
        Me.SellStartDateDataGridViewTextBoxColumn.Width = 150
        '
        'SellEndDateDataGridViewTextBoxColumn
        '
        Me.SellEndDateDataGridViewTextBoxColumn.DataPropertyName = "SellEndDate"
        Me.SellEndDateDataGridViewTextBoxColumn.HeaderText = "SellEndDate"
        Me.SellEndDateDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.SellEndDateDataGridViewTextBoxColumn.Name = "SellEndDateDataGridViewTextBoxColumn"
        Me.SellEndDateDataGridViewTextBoxColumn.Width = 150
        '
        'DiscontinuedDateDataGridViewTextBoxColumn
        '
        Me.DiscontinuedDateDataGridViewTextBoxColumn.DataPropertyName = "DiscontinuedDate"
        Me.DiscontinuedDateDataGridViewTextBoxColumn.HeaderText = "DiscontinuedDate"
        Me.DiscontinuedDateDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.DiscontinuedDateDataGridViewTextBoxColumn.Name = "DiscontinuedDateDataGridViewTextBoxColumn"
        Me.DiscontinuedDateDataGridViewTextBoxColumn.Width = 150
        '
        'ThumbNailPhotoDataGridViewImageColumn
        '
        Me.ThumbNailPhotoDataGridViewImageColumn.DataPropertyName = "ThumbNailPhoto"
        Me.ThumbNailPhotoDataGridViewImageColumn.HeaderText = "ThumbNailPhoto"
        Me.ThumbNailPhotoDataGridViewImageColumn.MinimumWidth = 8
        Me.ThumbNailPhotoDataGridViewImageColumn.Name = "ThumbNailPhotoDataGridViewImageColumn"
        Me.ThumbNailPhotoDataGridViewImageColumn.Width = 150
        '
        'ThumbnailPhotoFileNameDataGridViewTextBoxColumn
        '
        Me.ThumbnailPhotoFileNameDataGridViewTextBoxColumn.DataPropertyName = "ThumbnailPhotoFileName"
        Me.ThumbnailPhotoFileNameDataGridViewTextBoxColumn.HeaderText = "ThumbnailPhotoFileName"
        Me.ThumbnailPhotoFileNameDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.ThumbnailPhotoFileNameDataGridViewTextBoxColumn.Name = "ThumbnailPhotoFileNameDataGridViewTextBoxColumn"
        Me.ThumbnailPhotoFileNameDataGridViewTextBoxColumn.Width = 150
        '
        'RowguidDataGridViewTextBoxColumn
        '
        Me.RowguidDataGridViewTextBoxColumn.DataPropertyName = "rowguid"
        Me.RowguidDataGridViewTextBoxColumn.HeaderText = "rowguid"
        Me.RowguidDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.RowguidDataGridViewTextBoxColumn.Name = "RowguidDataGridViewTextBoxColumn"
        Me.RowguidDataGridViewTextBoxColumn.Width = 150
        '
        'ModifiedDateDataGridViewTextBoxColumn
        '
        Me.ModifiedDateDataGridViewTextBoxColumn.DataPropertyName = "ModifiedDate"
        Me.ModifiedDateDataGridViewTextBoxColumn.HeaderText = "ModifiedDate"
        Me.ModifiedDateDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.ModifiedDateDataGridViewTextBoxColumn.Name = "ModifiedDateDataGridViewTextBoxColumn"
        Me.ModifiedDateDataGridViewTextBoxColumn.Width = 150
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.ModifiedDate, Me.OrderQty})
        Me.DataGridView2.DataSource = Me.FKSalesOrderDetailProductProductIDBindingSource4
        Me.DataGridView2.Location = New System.Drawing.Point(6, 0)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersWidth = 62
        Me.DataGridView2.Size = New System.Drawing.Size(521, 111)
        Me.DataGridView2.TabIndex = 0
        Me.DataGridView2.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ProductID"
        Me.DataGridViewTextBoxColumn4.HeaderText = "ProductID"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 150
        '
        'ModifiedDate
        '
        Me.ModifiedDate.DataPropertyName = "ModifiedDate"
        Me.ModifiedDate.HeaderText = "ModifiedDate"
        Me.ModifiedDate.MinimumWidth = 8
        Me.ModifiedDate.Name = "ModifiedDate"
        Me.ModifiedDate.Width = 150
        '
        'OrderQty
        '
        Me.OrderQty.DataPropertyName = "OrderQty"
        Me.OrderQty.HeaderText = "OrderQty"
        Me.OrderQty.MinimumWidth = 8
        Me.OrderQty.Name = "OrderQty"
        Me.OrderQty.Width = 150
        '
        'FKSalesOrderDetailProductProductIDBindingSource4
        '
        Me.FKSalesOrderDetailProductProductIDBindingSource4.DataMember = "FK_SalesOrderDetail_Product_ProductID"
        Me.FKSalesOrderDetailProductProductIDBindingSource4.DataSource = Me.ProductBindingSource
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage1)
        Me.TabControl2.Controls.Add(Me.TabPage5)
        Me.TabControl2.Controls.Add(Me.TabPage6)
        Me.TabControl2.Location = New System.Drawing.Point(73, 31)
        Me.TabControl2.Margin = New System.Windows.Forms.Padding(2)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(415, 272)
        Me.TabControl2.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.mskCustomerID)
        Me.TabPage1.Controls.Add(Me.mskQuantity)
        Me.TabPage1.Controls.Add(Me.btnSubmit)
        Me.TabPage1.Controls.Add(Me.txtPrice)
        Me.TabPage1.Controls.Add(Me.lblPrice)
        Me.TabPage1.Controls.Add(Me.btnAddToCart)
        Me.TabPage1.Controls.Add(Me.btnSearch1)
        Me.TabPage1.Controls.Add(Me.txtProduct)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Size = New System.Drawing.Size(407, 246)
        Me.TabPage1.TabIndex = 1
        Me.TabPage1.Text = "Order"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'mskCustomerID
        '
        Me.mskCustomerID.Location = New System.Drawing.Point(162, 147)
        Me.mskCustomerID.Mask = "00000"
        Me.mskCustomerID.Name = "mskCustomerID"
        Me.mskCustomerID.Size = New System.Drawing.Size(113, 20)
        Me.mskCustomerID.TabIndex = 14
        Me.mskCustomerID.ValidatingType = GetType(Integer)
        '
        'mskQuantity
        '
        Me.mskQuantity.Location = New System.Drawing.Point(162, 122)
        Me.mskQuantity.Mask = "000"
        Me.mskQuantity.Name = "mskQuantity"
        Me.mskQuantity.Size = New System.Drawing.Size(113, 20)
        Me.mskQuantity.TabIndex = 13
        Me.mskQuantity.ValidatingType = GetType(Integer)
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(177, 190)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(76, 24)
        Me.btnSubmit.TabIndex = 12
        Me.btnSubmit.Text = "Submit Order"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'txtPrice
        '
        Me.txtPrice.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "ListPrice", True))
        Me.txtPrice.Location = New System.Drawing.Point(162, 90)
        Me.txtPrice.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(113, 20)
        Me.txtPrice.TabIndex = 11
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(47, 90)
        Me.lblPrice.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(74, 13)
        Me.lblPrice.TabIndex = 10
        Me.lblPrice.Text = "Product Price:"
        '
        'btnAddToCart
        '
        Me.btnAddToCart.Location = New System.Drawing.Point(69, 190)
        Me.btnAddToCart.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddToCart.Name = "btnAddToCart"
        Me.btnAddToCart.Size = New System.Drawing.Size(75, 24)
        Me.btnAddToCart.TabIndex = 9
        Me.btnAddToCart.Text = "Add To Cart"
        Me.btnAddToCart.UseVisualStyleBackColor = True
        '
        'btnSearch1
        '
        Me.btnSearch1.Location = New System.Drawing.Point(120, 46)
        Me.btnSearch1.Name = "btnSearch1"
        Me.btnSearch1.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch1.TabIndex = 8
        Me.btnSearch1.Text = "Search"
        Me.btnSearch1.UseVisualStyleBackColor = True
        '
        'txtProduct
        '
        Me.txtProduct.Location = New System.Drawing.Point(162, 18)
        Me.txtProduct.Margin = New System.Windows.Forms.Padding(2)
        Me.txtProduct.Name = "txtProduct"
        Me.txtProduct.Size = New System.Drawing.Size(113, 20)
        Me.txtProduct.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(47, 147)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Enter Customer ID:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(47, 120)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Enter Quantity:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(47, 20)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Enter Product:"
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.btnProductMaintenance)
        Me.TabPage5.Controls.Add(Me.btnCustomerMaintenance)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage5.Size = New System.Drawing.Size(407, 246)
        Me.TabPage5.TabIndex = 2
        Me.TabPage5.Text = "Maintenance"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'btnProductMaintenance
        '
        Me.btnProductMaintenance.Location = New System.Drawing.Point(225, 27)
        Me.btnProductMaintenance.Margin = New System.Windows.Forms.Padding(2)
        Me.btnProductMaintenance.Name = "btnProductMaintenance"
        Me.btnProductMaintenance.Size = New System.Drawing.Size(100, 68)
        Me.btnProductMaintenance.TabIndex = 1
        Me.btnProductMaintenance.Text = "Product Maintenance"
        Me.btnProductMaintenance.UseVisualStyleBackColor = True
        '
        'btnCustomerMaintenance
        '
        Me.btnCustomerMaintenance.Location = New System.Drawing.Point(64, 27)
        Me.btnCustomerMaintenance.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCustomerMaintenance.Name = "btnCustomerMaintenance"
        Me.btnCustomerMaintenance.Size = New System.Drawing.Size(100, 68)
        Me.btnCustomerMaintenance.TabIndex = 0
        Me.btnCustomerMaintenance.Text = "Customer Maintenance"
        Me.btnCustomerMaintenance.UseVisualStyleBackColor = True
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.Button6)
        Me.TabPage6.Controls.Add(Me.Label8)
        Me.TabPage6.Controls.Add(Me.DateTimePicker1)
        Me.TabPage6.Controls.Add(Me.Label9)
        Me.TabPage6.Controls.Add(Me.DateTimePicker2)
        Me.TabPage6.Controls.Add(Me.TextBox11)
        Me.TabPage6.Controls.Add(Me.Label10)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage6.Size = New System.Drawing.Size(407, 246)
        Me.TabPage6.TabIndex = 3
        Me.TabPage6.Text = "Report"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(91, 129)
        Me.Button6.Margin = New System.Windows.Forms.Padding(2)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(79, 31)
        Me.Button6.TabIndex = 6
        Me.Button6.Text = "Search"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(24, 98)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Choose End Date:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(134, 98)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(2)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(106, 20)
        Me.DateTimePicker1.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(24, 64)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 13)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Choose Start Date:"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(134, 64)
        Me.DateTimePicker2.Margin = New System.Windows.Forms.Padding(2)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(106, 20)
        Me.DateTimePicker2.TabIndex = 2
        '
        'TextBox11
        '
        Me.TextBox11.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "Name", True))
        Me.TextBox11.Location = New System.Drawing.Point(134, 29)
        Me.TextBox11.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(106, 20)
        Me.TextBox11.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(24, 31)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(106, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Enter Product Name:"
        '
        'FKSalesOrderDetailProductProductIDBindingSource3
        '
        Me.FKSalesOrderDetailProductProductIDBindingSource3.DataMember = "FK_SalesOrderDetail_Product_ProductID"
        Me.FKSalesOrderDetailProductProductIDBindingSource3.DataSource = Me.ProductBindingSource
        '
        'FKSalesOrderDetailProductProductIDBindingSource2
        '
        Me.FKSalesOrderDetailProductProductIDBindingSource2.DataMember = "FK_SalesOrderDetail_Product_ProductID"
        Me.FKSalesOrderDetailProductProductIDBindingSource2.DataSource = Me.ProductBindingSource
        '
        'ProductBindingSource2
        '
        Me.ProductBindingSource2.DataMember = "Product"
        Me.ProductBindingSource2.DataSource = Me.BikeStoreDataSet
        '
        'lblTotalPrice
        '
        Me.lblTotalPrice.Location = New System.Drawing.Point(8, 224)
        Me.lblTotalPrice.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTotalPrice.Name = "lblTotalPrice"
        Me.lblTotalPrice.Size = New System.Drawing.Size(71, 17)
        Me.lblTotalPrice.TabIndex = 7
        Me.lblTotalPrice.Text = "Total Price:"
        '
        'lstCart
        '
        Me.lstCart.FormattingEnabled = True
        Me.lstCart.Location = New System.Drawing.Point(11, 16)
        Me.lstCart.Margin = New System.Windows.Forms.Padding(2)
        Me.lstCart.Name = "lstCart"
        Me.lstCart.Size = New System.Drawing.Size(196, 199)
        Me.lstCart.TabIndex = 8
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(210, 16)
        Me.btnRemove.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(101, 24)
        Me.btnRemove.TabIndex = 9
        Me.btnRemove.Text = "Remove From Cart"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'grpCart
        '
        Me.grpCart.Controls.Add(Me.btnClearCart)
        Me.grpCart.Controls.Add(Me.lblTotal)
        Me.grpCart.Controls.Add(Me.lstCart)
        Me.grpCart.Controls.Add(Me.btnRemove)
        Me.grpCart.Controls.Add(Me.lblTotalPrice)
        Me.grpCart.Location = New System.Drawing.Point(12, 328)
        Me.grpCart.Margin = New System.Windows.Forms.Padding(2)
        Me.grpCart.Name = "grpCart"
        Me.grpCart.Padding = New System.Windows.Forms.Padding(2)
        Me.grpCart.Size = New System.Drawing.Size(401, 249)
        Me.grpCart.TabIndex = 10
        Me.grpCart.TabStop = False
        Me.grpCart.Text = "Shopping Cart"
        Me.grpCart.Visible = False
        '
        'btnClearCart
        '
        Me.btnClearCart.Location = New System.Drawing.Point(210, 45)
        Me.btnClearCart.Name = "btnClearCart"
        Me.btnClearCart.Size = New System.Drawing.Size(101, 23)
        Me.btnClearCart.TabIndex = 11
        Me.btnClearCart.Text = "Clear Cart"
        Me.btnClearCart.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Location = New System.Drawing.Point(74, 223)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(133, 23)
        Me.lblTotal.TabIndex = 10
        '
        'frmBikeStoreMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1187, 619)
        Me.Controls.Add(Me.grpCart)
        Me.Controls.Add(Me.grpLogin)
        Me.Controls.Add(Me.grpMain)
        Me.Controls.Add(Me.CustomerBindingNavigator)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmBikeStoreMain"
        Me.Text = "Bike Store"
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BikeStoreDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CustomerBindingNavigator.ResumeLayout(False)
        Me.CustomerBindingNavigator.PerformLayout()
        CType(Me.ProductBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKSalesOrderDetailProductProductIDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKSalesOrderDetailProductProductIDBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesOrderDetailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLogin.ResumeLayout(False)
        Me.grpLogin.PerformLayout()
        Me.grpMain.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKSalesOrderDetailProductProductIDBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        CType(Me.FKSalesOrderDetailProductProductIDBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKSalesOrderDetailProductProductIDBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCart.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BikeStoreDataSet As BikeStoreDataSet
    Friend WithEvents CustomerBindingSource As BindingSource
    Friend WithEvents CustomerTableAdapter As BikeStoreDataSetTableAdapters.CustomerTableAdapter
    Friend WithEvents TableAdapterManager As BikeStoreDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CustomerBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents CustomerBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ProductBindingSource As BindingSource
    Friend WithEvents ProductTableAdapter As BikeStoreDataSetTableAdapters.ProductTableAdapter
    Friend WithEvents ProductBindingSource1 As BindingSource
    Friend WithEvents FKSalesOrderDetailProductProductIDBindingSource As BindingSource
    Friend WithEvents SalesOrderDetailTableAdapter As BikeStoreDataSetTableAdapters.SalesOrderDetailTableAdapter
    Friend WithEvents FKSalesOrderDetailProductProductIDBindingSource1 As BindingSource
    Friend WithEvents SalesOrderDetailBindingSource As BindingSource
    Friend WithEvents grpLogin As GroupBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnLogin As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPW As TextBox
    Friend WithEvents grpMain As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents txtProduct As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents btnProductMaintenance As Button
    Friend WithEvents btnCustomerMaintenance As Button
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents Button6 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents FKSalesOrderDetailProductProductIDBindingSource3 As BindingSource
    Friend WithEvents FKSalesOrderDetailProductProductIDBindingSource2 As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents ModifiedDate As DataGridViewTextBoxColumn
    Friend WithEvents OrderQty As DataGridViewTextBoxColumn
    Friend WithEvents FKSalesOrderDetailProductProductIDBindingSource4 As BindingSource
    Friend WithEvents ProductBindingSource2 As BindingSource
    Friend WithEvents btnSearch1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ProductIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StandardCostDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ListPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SizeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WeightDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductCategoryIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductModelIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SellStartDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SellEndDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiscontinuedDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ThumbNailPhotoDataGridViewImageColumn As DataGridViewImageColumn
    Friend WithEvents ThumbnailPhotoFileNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RowguidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ModifiedDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents cbPW As CheckBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents lblPrice As Label
    Friend WithEvents btnAddToCart As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents lblTotalPrice As Label
    Friend WithEvents lstCart As ListBox
    Friend WithEvents btnRemove As Button
    Friend WithEvents grpCart As GroupBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents mskQuantity As MaskedTextBox
    Friend WithEvents mskCustomerID As MaskedTextBox
    Friend WithEvents btnClearCart As Button
End Class
