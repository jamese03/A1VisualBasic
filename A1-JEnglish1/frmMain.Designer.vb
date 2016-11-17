<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim lblFirstName As System.Windows.Forms.Label
        Dim lblLastName As System.Windows.Forms.Label
        Dim lblAdress As System.Windows.Forms.Label
        Dim lblCity As System.Windows.Forms.Label
        Dim lblZip As System.Windows.Forms.Label
        Dim lblState As System.Windows.Forms.Label
        Me._customers_F2012DataSet = New A1_JEnglish._customers_F2012DataSet()
        Me.CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnUpdateDatabase = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.TableAdapterManager = New A1_JEnglish._customers_F2012DataSetTableAdapters.TableAdapterManager()
        Me.CustomersTableAdapter = New A1_JEnglish._customers_F2012DataSetTableAdapters.CustomersTableAdapter()
        Me.cboState = New System.Windows.Forms.ComboBox()
        Me.StatesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblCustomer = New System.Windows.Forms.Label()
        Me.cboCustomer = New System.Windows.Forms.ComboBox()
        Me.StatesTableAdapter = New A1_JEnglish._customers_F2012DataSetTableAdapters.StatesTableAdapter()
        lblFirstName = New System.Windows.Forms.Label()
        lblLastName = New System.Windows.Forms.Label()
        lblAdress = New System.Windows.Forms.Label()
        lblCity = New System.Windows.Forms.Label()
        lblZip = New System.Windows.Forms.Label()
        lblState = New System.Windows.Forms.Label()
        CType(Me._customers_F2012DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblFirstName
        '
        lblFirstName.AutoSize = True
        lblFirstName.Location = New System.Drawing.Point(50, 86)
        lblFirstName.Name = "lblFirstName"
        lblFirstName.Size = New System.Drawing.Size(60, 13)
        lblFirstName.TabIndex = 3
        lblFirstName.Text = "First Name:"
        AddHandler lblFirstName.Click, AddressOf Me.FirstNameLabel_Click
        '
        'lblLastName
        '
        lblLastName.AutoSize = True
        lblLastName.Location = New System.Drawing.Point(267, 86)
        lblLastName.Name = "lblLastName"
        lblLastName.Size = New System.Drawing.Size(61, 13)
        lblLastName.TabIndex = 5
        lblLastName.Text = "Last Name:"
        '
        'lblAdress
        '
        lblAdress.AutoSize = True
        lblAdress.Location = New System.Drawing.Point(50, 118)
        lblAdress.Name = "lblAdress"
        lblAdress.Size = New System.Drawing.Size(48, 13)
        lblAdress.TabIndex = 7
        lblAdress.Text = "Address:"
        '
        'lblCity
        '
        lblCity.AutoSize = True
        lblCity.Location = New System.Drawing.Point(50, 154)
        lblCity.Name = "lblCity"
        lblCity.Size = New System.Drawing.Size(27, 13)
        lblCity.TabIndex = 9
        lblCity.Text = "City:"
        '
        'lblZip
        '
        lblZip.AutoSize = True
        lblZip.Location = New System.Drawing.Point(280, 202)
        lblZip.Name = "lblZip"
        lblZip.Size = New System.Drawing.Size(53, 13)
        lblZip.TabIndex = 13
        lblZip.Text = "Zip Code:"
        '
        'lblState
        '
        lblState.AutoSize = True
        lblState.Location = New System.Drawing.Point(50, 202)
        lblState.Name = "lblState"
        lblState.Size = New System.Drawing.Size(35, 13)
        lblState.TabIndex = 20
        lblState.Text = "State:"
        '
        '_customers_F2012DataSet
        '
        Me._customers_F2012DataSet.DataSetName = "_customers_F2012DataSet"
        Me._customers_F2012DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomersBindingSource
        '
        Me.CustomersBindingSource.DataMember = "Customers"
        Me.CustomersBindingSource.DataSource = Me._customers_F2012DataSet
        '
        'txtFirstName
        '
        Me.txtFirstName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "FirstName", True))
        Me.txtFirstName.Location = New System.Drawing.Point(117, 83)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(100, 20)
        Me.txtFirstName.TabIndex = 4
        '
        'txtLastName
        '
        Me.txtLastName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "LastName", True))
        Me.txtLastName.Location = New System.Drawing.Point(334, 83)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(100, 20)
        Me.txtLastName.TabIndex = 6
        '
        'txtAddress
        '
        Me.txtAddress.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Address", True))
        Me.txtAddress.Location = New System.Drawing.Point(117, 115)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(317, 20)
        Me.txtAddress.TabIndex = 8
        '
        'txtCity
        '
        Me.txtCity.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "City", True))
        Me.txtCity.Location = New System.Drawing.Point(117, 151)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(317, 20)
        Me.txtCity.TabIndex = 10
        '
        'txtZip
        '
        Me.txtZip.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Zip", True))
        Me.txtZip.Location = New System.Drawing.Point(334, 194)
        Me.txtZip.MaxLength = 5
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(100, 20)
        Me.txtZip.TabIndex = 14
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(53, 305)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 15
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Location = New System.Drawing.Point(142, 304)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 16
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(359, 304)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 17
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Enabled = False
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnCancel.Location = New System.Drawing.Point(253, 304)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 18
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnUpdateDatabase
        '
        Me.btnUpdateDatabase.Enabled = False
        Me.btnUpdateDatabase.Location = New System.Drawing.Point(53, 357)
        Me.btnUpdateDatabase.Name = "btnUpdateDatabase"
        Me.btnUpdateDatabase.Size = New System.Drawing.Size(126, 23)
        Me.btnUpdateDatabase.TabIndex = 19
        Me.btnUpdateDatabase.Text = "Update Database"
        Me.btnUpdateDatabase.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(306, 357)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 20
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CustomersTableAdapter = Me.CustomersTableAdapter
        Me.TableAdapterManager.StatesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = A1_JEnglish._customers_F2012DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CustomersTableAdapter
        '
        Me.CustomersTableAdapter.ClearBeforeFill = True
        '
        'cboState
        '
        Me.cboState.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CustomersBindingSource, "State", True))
        Me.cboState.DataSource = Me.StatesBindingSource
        Me.cboState.DisplayMember = "StateName"
        Me.cboState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboState.FormattingEnabled = True
        Me.cboState.Location = New System.Drawing.Point(117, 199)
        Me.cboState.Name = "cboState"
        Me.cboState.Size = New System.Drawing.Size(100, 21)
        Me.cboState.TabIndex = 21
        Me.cboState.ValueMember = "StateCode"
        '
        'StatesBindingSource
        '
        Me.StatesBindingSource.DataMember = "States"
        Me.StatesBindingSource.DataSource = Me._customers_F2012DataSet
        '
        'lblCustomer
        '
        Me.lblCustomer.AutoSize = True
        Me.lblCustomer.Location = New System.Drawing.Point(47, 23)
        Me.lblCustomer.Name = "lblCustomer"
        Me.lblCustomer.Size = New System.Drawing.Size(51, 13)
        Me.lblCustomer.TabIndex = 22
        Me.lblCustomer.Text = "Customer"
        '
        'cboCustomer
        '
        Me.cboCustomer.DataSource = Me.CustomersBindingSource
        Me.cboCustomer.DisplayMember = "FullName"
        Me.cboCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCustomer.FormattingEnabled = True
        Me.cboCustomer.Location = New System.Drawing.Point(117, 20)
        Me.cboCustomer.Name = "cboCustomer"
        Me.cboCustomer.Size = New System.Drawing.Size(317, 21)
        Me.cboCustomer.TabIndex = 23
        '
        'StatesTableAdapter
        '
        Me.StatesTableAdapter.ClearBeforeFill = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 435)
        Me.Controls.Add(Me.cboCustomer)
        Me.Controls.Add(Me.lblCustomer)
        Me.Controls.Add(lblState)
        Me.Controls.Add(Me.cboState)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnUpdateDatabase)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(lblFirstName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(lblLastName)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(lblAdress)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(lblCity)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(lblZip)
        Me.Controls.Add(Me.txtZip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmMain"
        Me.Text = "JEnglish - Customer Database Program"
        CType(Me._customers_F2012DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents _customers_F2012DataSet As A1_JEnglish._customers_F2012DataSet
    Friend WithEvents CustomersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents txtZip As System.Windows.Forms.TextBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnUpdateDatabase As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents TableAdapterManager As A1_JEnglish._customers_F2012DataSetTableAdapters.TableAdapterManager
    Friend WithEvents cboState As System.Windows.Forms.ComboBox
    Friend WithEvents lblCustomer As System.Windows.Forms.Label
    Friend WithEvents cboCustomer As System.Windows.Forms.ComboBox
    Friend WithEvents StatesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StatesTableAdapter As A1_JEnglish._customers_F2012DataSetTableAdapters.StatesTableAdapter
    Friend WithEvents CustomersTableAdapter As A1_JEnglish._customers_F2012DataSetTableAdapters.CustomersTableAdapter

End Class
