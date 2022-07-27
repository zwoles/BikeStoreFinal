<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCustomerMaintenance
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.FirstName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MiddleName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Phone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameStyleDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MiddleNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SuffixDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CompanyNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalesPersonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailAddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PasswordHashDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PasswordSaltDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RowguidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModifiedDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BikeStoreDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BikeStoreDataSet = New BikeStore.BikeStoreDataSet()
        Me.ProductModelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductModelTableAdapter = New BikeStore.BikeStoreDataSetTableAdapters.ProductModelTableAdapter()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerTableAdapter = New BikeStore.BikeStoreDataSetTableAdapters.CustomerTableAdapter()
        Me.CustomerBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnAddCust = New System.Windows.Forms.Button()
        Me.btnRemCust = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblMiddleName = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtMiddleName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblTelephone = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.mskPhone = New System.Windows.Forms.MaskedTextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BikeStoreDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BikeStoreDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductModelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FirstName, Me.MiddleName, Me.LastName, Me.EmailAddress, Me.Phone, Me.CustomerIDDataGridViewTextBoxColumn, Me.NameStyleDataGridViewCheckBoxColumn, Me.TitleDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.MiddleNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.SuffixDataGridViewTextBoxColumn, Me.CompanyNameDataGridViewTextBoxColumn, Me.SalesPersonDataGridViewTextBoxColumn, Me.EmailAddressDataGridViewTextBoxColumn, Me.PhoneDataGridViewTextBoxColumn, Me.PasswordHashDataGridViewTextBoxColumn, Me.PasswordSaltDataGridViewTextBoxColumn, Me.RowguidDataGridViewTextBoxColumn, Me.ModifiedDateDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CustomerBindingSource2
        Me.DataGridView1.Location = New System.Drawing.Point(27, 23)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(605, 288)
        Me.DataGridView1.TabIndex = 0
        '
        'FirstName
        '
        Me.FirstName.DataPropertyName = "FirstName"
        Me.FirstName.HeaderText = "FirstName"
        Me.FirstName.MinimumWidth = 8
        Me.FirstName.Name = "FirstName"
        Me.FirstName.Width = 150
        '
        'MiddleName
        '
        Me.MiddleName.DataPropertyName = "MiddleName"
        Me.MiddleName.HeaderText = "MiddleName"
        Me.MiddleName.MinimumWidth = 8
        Me.MiddleName.Name = "MiddleName"
        Me.MiddleName.Width = 150
        '
        'LastName
        '
        Me.LastName.DataPropertyName = "LastName"
        Me.LastName.HeaderText = "LastName"
        Me.LastName.MinimumWidth = 8
        Me.LastName.Name = "LastName"
        Me.LastName.Width = 150
        '
        'EmailAddress
        '
        Me.EmailAddress.DataPropertyName = "EmailAddress"
        Me.EmailAddress.HeaderText = "EmailAddress"
        Me.EmailAddress.MinimumWidth = 8
        Me.EmailAddress.Name = "EmailAddress"
        Me.EmailAddress.Width = 150
        '
        'Phone
        '
        Me.Phone.DataPropertyName = "Phone"
        Me.Phone.HeaderText = "Phone"
        Me.Phone.MinimumWidth = 8
        Me.Phone.Name = "Phone"
        Me.Phone.Width = 150
        '
        'CustomerIDDataGridViewTextBoxColumn
        '
        Me.CustomerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID"
        Me.CustomerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID"
        Me.CustomerIDDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.CustomerIDDataGridViewTextBoxColumn.Name = "CustomerIDDataGridViewTextBoxColumn"
        Me.CustomerIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.CustomerIDDataGridViewTextBoxColumn.Width = 150
        '
        'NameStyleDataGridViewCheckBoxColumn
        '
        Me.NameStyleDataGridViewCheckBoxColumn.DataPropertyName = "NameStyle"
        Me.NameStyleDataGridViewCheckBoxColumn.HeaderText = "NameStyle"
        Me.NameStyleDataGridViewCheckBoxColumn.MinimumWidth = 8
        Me.NameStyleDataGridViewCheckBoxColumn.Name = "NameStyleDataGridViewCheckBoxColumn"
        Me.NameStyleDataGridViewCheckBoxColumn.Width = 150
        '
        'TitleDataGridViewTextBoxColumn
        '
        Me.TitleDataGridViewTextBoxColumn.DataPropertyName = "Title"
        Me.TitleDataGridViewTextBoxColumn.HeaderText = "Title"
        Me.TitleDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TitleDataGridViewTextBoxColumn.Name = "TitleDataGridViewTextBoxColumn"
        Me.TitleDataGridViewTextBoxColumn.Width = 150
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        Me.FirstNameDataGridViewTextBoxColumn.Width = 150
        '
        'MiddleNameDataGridViewTextBoxColumn
        '
        Me.MiddleNameDataGridViewTextBoxColumn.DataPropertyName = "MiddleName"
        Me.MiddleNameDataGridViewTextBoxColumn.HeaderText = "MiddleName"
        Me.MiddleNameDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.MiddleNameDataGridViewTextBoxColumn.Name = "MiddleNameDataGridViewTextBoxColumn"
        Me.MiddleNameDataGridViewTextBoxColumn.Width = 150
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "LastName"
        Me.LastNameDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        Me.LastNameDataGridViewTextBoxColumn.Width = 150
        '
        'SuffixDataGridViewTextBoxColumn
        '
        Me.SuffixDataGridViewTextBoxColumn.DataPropertyName = "Suffix"
        Me.SuffixDataGridViewTextBoxColumn.HeaderText = "Suffix"
        Me.SuffixDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.SuffixDataGridViewTextBoxColumn.Name = "SuffixDataGridViewTextBoxColumn"
        Me.SuffixDataGridViewTextBoxColumn.Width = 150
        '
        'CompanyNameDataGridViewTextBoxColumn
        '
        Me.CompanyNameDataGridViewTextBoxColumn.DataPropertyName = "CompanyName"
        Me.CompanyNameDataGridViewTextBoxColumn.HeaderText = "CompanyName"
        Me.CompanyNameDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.CompanyNameDataGridViewTextBoxColumn.Name = "CompanyNameDataGridViewTextBoxColumn"
        Me.CompanyNameDataGridViewTextBoxColumn.Width = 150
        '
        'SalesPersonDataGridViewTextBoxColumn
        '
        Me.SalesPersonDataGridViewTextBoxColumn.DataPropertyName = "SalesPerson"
        Me.SalesPersonDataGridViewTextBoxColumn.HeaderText = "SalesPerson"
        Me.SalesPersonDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.SalesPersonDataGridViewTextBoxColumn.Name = "SalesPersonDataGridViewTextBoxColumn"
        Me.SalesPersonDataGridViewTextBoxColumn.Width = 150
        '
        'EmailAddressDataGridViewTextBoxColumn
        '
        Me.EmailAddressDataGridViewTextBoxColumn.DataPropertyName = "EmailAddress"
        Me.EmailAddressDataGridViewTextBoxColumn.HeaderText = "EmailAddress"
        Me.EmailAddressDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.EmailAddressDataGridViewTextBoxColumn.Name = "EmailAddressDataGridViewTextBoxColumn"
        Me.EmailAddressDataGridViewTextBoxColumn.Width = 150
        '
        'PhoneDataGridViewTextBoxColumn
        '
        Me.PhoneDataGridViewTextBoxColumn.DataPropertyName = "Phone"
        Me.PhoneDataGridViewTextBoxColumn.HeaderText = "Phone"
        Me.PhoneDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.PhoneDataGridViewTextBoxColumn.Name = "PhoneDataGridViewTextBoxColumn"
        Me.PhoneDataGridViewTextBoxColumn.Width = 150
        '
        'PasswordHashDataGridViewTextBoxColumn
        '
        Me.PasswordHashDataGridViewTextBoxColumn.DataPropertyName = "PasswordHash"
        Me.PasswordHashDataGridViewTextBoxColumn.HeaderText = "PasswordHash"
        Me.PasswordHashDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.PasswordHashDataGridViewTextBoxColumn.Name = "PasswordHashDataGridViewTextBoxColumn"
        Me.PasswordHashDataGridViewTextBoxColumn.Width = 150
        '
        'PasswordSaltDataGridViewTextBoxColumn
        '
        Me.PasswordSaltDataGridViewTextBoxColumn.DataPropertyName = "PasswordSalt"
        Me.PasswordSaltDataGridViewTextBoxColumn.HeaderText = "PasswordSalt"
        Me.PasswordSaltDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.PasswordSaltDataGridViewTextBoxColumn.Name = "PasswordSaltDataGridViewTextBoxColumn"
        Me.PasswordSaltDataGridViewTextBoxColumn.Width = 150
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
        'CustomerBindingSource2
        '
        Me.CustomerBindingSource2.DataMember = "Customer"
        Me.CustomerBindingSource2.DataSource = Me.BikeStoreDataSetBindingSource
        '
        'BikeStoreDataSetBindingSource
        '
        Me.BikeStoreDataSetBindingSource.DataSource = Me.BikeStoreDataSet
        Me.BikeStoreDataSetBindingSource.Position = 0
        '
        'BikeStoreDataSet
        '
        Me.BikeStoreDataSet.DataSetName = "BikeStoreDataSet"
        Me.BikeStoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductModelBindingSource
        '
        Me.ProductModelBindingSource.DataMember = "ProductModel"
        Me.ProductModelBindingSource.DataSource = Me.BikeStoreDataSetBindingSource
        '
        'ProductModelTableAdapter
        '
        Me.ProductModelTableAdapter.ClearBeforeFill = True
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
        'CustomerBindingSource1
        '
        Me.CustomerBindingSource1.DataMember = "Customer"
        Me.CustomerBindingSource1.DataSource = Me.BikeStoreDataSet
        '
        'btnAddCust
        '
        Me.btnAddCust.Location = New System.Drawing.Point(8, 335)
        Me.btnAddCust.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddCust.Name = "btnAddCust"
        Me.btnAddCust.Size = New System.Drawing.Size(112, 21)
        Me.btnAddCust.TabIndex = 1
        Me.btnAddCust.Text = "Click to Add Customer"
        Me.btnAddCust.UseVisualStyleBackColor = True
        '
        'btnRemCust
        '
        Me.btnRemCust.Location = New System.Drawing.Point(133, 335)
        Me.btnRemCust.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRemCust.Name = "btnRemCust"
        Me.btnRemCust.Size = New System.Drawing.Size(116, 21)
        Me.btnRemCust.TabIndex = 2
        Me.btnRemCust.Text = "Click to Remove Customer"
        Me.btnRemCust.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(27, 490)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(93, 27)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(133, 490)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(93, 27)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(11, 369)
        Me.lblFirstName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(160, 13)
        Me.lblFirstName.TabIndex = 5
        Me.lblFirstName.Text = "Enter New Customer First Name:"
        '
        'lblMiddleName
        '
        Me.lblMiddleName.AutoSize = True
        Me.lblMiddleName.Location = New System.Drawing.Point(11, 393)
        Me.lblMiddleName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMiddleName.Name = "lblMiddleName"
        Me.lblMiddleName.Size = New System.Drawing.Size(172, 13)
        Me.lblMiddleName.TabIndex = 6
        Me.lblMiddleName.Text = "Enter New Customer Middle Name:"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(11, 417)
        Me.lblLastName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(161, 13)
        Me.lblLastName.TabIndex = 7
        Me.lblLastName.Text = "Enter New Customer Last Name:"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(11, 441)
        Me.lblEmail.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(139, 13)
        Me.lblEmail.TabIndex = 8
        Me.lblEmail.Text = "Enter New Customer E-Mail:"
        '
        'txtFirstName
        '
        Me.txtFirstName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "FirstName", True))
        Me.txtFirstName.Location = New System.Drawing.Point(217, 369)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(140, 20)
        Me.txtFirstName.TabIndex = 9
        '
        'txtMiddleName
        '
        Me.txtMiddleName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "MiddleName", True))
        Me.txtMiddleName.Location = New System.Drawing.Point(217, 393)
        Me.txtMiddleName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.Size = New System.Drawing.Size(140, 20)
        Me.txtMiddleName.TabIndex = 10
        '
        'txtLastName
        '
        Me.txtLastName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "LastName", True))
        Me.txtLastName.Location = New System.Drawing.Point(217, 418)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(140, 20)
        Me.txtLastName.TabIndex = 11
        '
        'txtEmail
        '
        Me.txtEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "EmailAddress", True))
        Me.txtEmail.Location = New System.Drawing.Point(217, 441)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(140, 20)
        Me.txtEmail.TabIndex = 12
        '
        'lblTelephone
        '
        Me.lblTelephone.AutoSize = True
        Me.lblTelephone.Location = New System.Drawing.Point(11, 465)
        Me.lblTelephone.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTelephone.Name = "lblTelephone"
        Me.lblTelephone.Size = New System.Drawing.Size(161, 13)
        Me.lblTelephone.TabIndex = 13
        Me.lblTelephone.Text = "Enter New Customer Telephone:"
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(267, 335)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(116, 21)
        Me.btnNext.TabIndex = 15
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(401, 335)
        Me.btnPrevious.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(116, 21)
        Me.btnPrevious.TabIndex = 16
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'mskPhone
        '
        Me.mskPhone.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Phone", True))
        Me.mskPhone.Location = New System.Drawing.Point(217, 465)
        Me.mskPhone.Mask = "(999) 000-0000"
        Me.mskPhone.Name = "mskPhone"
        Me.mskPhone.Size = New System.Drawing.Size(140, 20)
        Me.mskPhone.TabIndex = 17
        '
        'frmCustomerMaintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(678, 552)
        Me.Controls.Add(Me.mskPhone)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.lblTelephone)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtMiddleName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lblMiddleName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnRemCust)
        Me.Controls.Add(Me.btnAddCust)
        Me.Controls.Add(Me.DataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmCustomerMaintenance"
        Me.Text = "Customer Maintenance"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BikeStoreDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BikeStoreDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductModelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BikeStoreDataSetBindingSource As BindingSource
    Friend WithEvents BikeStoreDataSet As BikeStoreDataSet
    Friend WithEvents ProductModelBindingSource As BindingSource
    Friend WithEvents ProductModelTableAdapter As BikeStoreDataSetTableAdapters.ProductModelTableAdapter
    Friend WithEvents CustomerBindingSource As BindingSource
    Friend WithEvents CustomerTableAdapter As BikeStoreDataSetTableAdapters.CustomerTableAdapter
    Friend WithEvents CustomerBindingSource2 As BindingSource
    Friend WithEvents CustomerBindingSource1 As BindingSource
    Friend WithEvents btnAddCust As Button
    Friend WithEvents btnRemCust As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblMiddleName As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents FirstName As DataGridViewTextBoxColumn
    Friend WithEvents MiddleName As DataGridViewTextBoxColumn
    Friend WithEvents LastName As DataGridViewTextBoxColumn
    Friend WithEvents EmailAddress As DataGridViewTextBoxColumn
    Friend WithEvents Phone As DataGridViewTextBoxColumn
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtMiddleName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblTelephone As Label
    Friend WithEvents CustomerIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameStyleDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents TitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MiddleNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SuffixDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CompanyNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SalesPersonDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailAddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PasswordHashDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PasswordSaltDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RowguidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ModifiedDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents mskPhone As MaskedTextBox
End Class
