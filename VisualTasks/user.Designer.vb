<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class user
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(user))
        Dim NameSurnameLabel As System.Windows.Forms.Label
        Dim UserNameLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Me.ScrumDataSet1 = New WindowsApplication1.ScrumDataSet()
        Me.UserBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserTableAdapter1 = New WindowsApplication1.ScrumDataSetTableAdapters.UserTableAdapter()
        Me.TableAdapterManager1 = New WindowsApplication1.ScrumDataSetTableAdapters.TableAdapterManager()
        Me.UserBindingSource1BindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.UserBindingSource1BindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.UserDataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NameSurnameTextBox1 = New System.Windows.Forms.TextBox()
        Me.UserNameTextBox1 = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox1 = New System.Windows.Forms.TextBox()
        Me.AdminCheckBox1 = New System.Windows.Forms.CheckBox()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.btnSalir = New System.Windows.Forms.Button()
        NameSurnameLabel = New System.Windows.Forms.Label()
        UserNameLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        CType(Me.ScrumDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserBindingSource1BindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UserBindingSource1BindingNavigator.SuspendLayout()
        CType(Me.UserDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ScrumDataSet1
        '
        Me.ScrumDataSet1.DataSetName = "ScrumDataSet"
        Me.ScrumDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UserBindingSource1
        '
        Me.UserBindingSource1.DataMember = "User"
        Me.UserBindingSource1.DataSource = Me.ScrumDataSet1
        '
        'UserTableAdapter1
        '
        Me.UserTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.UpdateOrder = WindowsApplication1.ScrumDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager1.UserTableAdapter = Me.UserTableAdapter1
        '
        'UserBindingSource1BindingNavigator
        '
        Me.UserBindingSource1BindingNavigator.AddNewItem = Me.ToolStripButton5
        Me.UserBindingSource1BindingNavigator.BindingSource = Me.UserBindingSource1
        Me.UserBindingSource1BindingNavigator.CountItem = Me.ToolStripLabel1
        Me.UserBindingSource1BindingNavigator.DeleteItem = Me.ToolStripButton6
        Me.UserBindingSource1BindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripSeparator1, Me.ToolStripTextBox1, Me.ToolStripLabel1, Me.ToolStripSeparator2, Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripSeparator3, Me.ToolStripButton5, Me.ToolStripButton6, Me.UserBindingSource1BindingNavigatorSaveItem})
        Me.UserBindingSource1BindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.UserBindingSource1BindingNavigator.MoveFirstItem = Me.ToolStripButton1
        Me.UserBindingSource1BindingNavigator.MoveLastItem = Me.ToolStripButton4
        Me.UserBindingSource1BindingNavigator.MoveNextItem = Me.ToolStripButton3
        Me.UserBindingSource1BindingNavigator.MovePreviousItem = Me.ToolStripButton2
        Me.UserBindingSource1BindingNavigator.Name = "UserBindingSource1BindingNavigator"
        Me.UserBindingSource1BindingNavigator.PositionItem = Me.ToolStripTextBox1
        Me.UserBindingSource1BindingNavigator.Size = New System.Drawing.Size(872, 25)
        Me.UserBindingSource1BindingNavigator.TabIndex = 0
        Me.UserBindingSource1BindingNavigator.Text = "BindingNavigator1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.Name = "BindingNavigatorMoveFirstItem"
        Me.ToolStripButton1.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "Mover primero"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.Name = "BindingNavigatorMovePreviousItem"
        Me.ToolStripButton2.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "Mover anterior"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "BindingNavigatorSeparator"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.AccessibleName = "Posición"
        Me.ToolStripTextBox1.AutoSize = False
        Me.ToolStripTextBox1.Name = "BindingNavigatorPositionItem"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(50, 23)
        Me.ToolStripTextBox1.Text = "0"
        Me.ToolStripTextBox1.ToolTipText = "Posición actual"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "BindingNavigatorCountItem"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(37, 22)
        Me.ToolStripLabel1.Text = "de {0}"
        Me.ToolStripLabel1.ToolTipText = "Número total de elementos"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "BindingNavigatorSeparator"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.Name = "BindingNavigatorMoveNextItem"
        Me.ToolStripButton3.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "Mover siguiente"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.Name = "BindingNavigatorMoveLastItem"
        Me.ToolStripButton4.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton4.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton4.Text = "Mover último"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "BindingNavigatorSeparator"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.Name = "BindingNavigatorAddNewItem"
        Me.ToolStripButton5.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton5.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton5.Text = "Agregar nuevo"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.Name = "BindingNavigatorDeleteItem"
        Me.ToolStripButton6.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton6.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton6.Text = "Eliminar"
        '
        'UserBindingSource1BindingNavigatorSaveItem
        '
        Me.UserBindingSource1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.UserBindingSource1BindingNavigatorSaveItem.Image = CType(resources.GetObject("UserBindingSource1BindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.UserBindingSource1BindingNavigatorSaveItem.Name = "UserBindingSource1BindingNavigatorSaveItem"
        Me.UserBindingSource1BindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.UserBindingSource1BindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'UserDataGridView1
        '
        Me.UserDataGridView1.AutoGenerateColumns = False
        Me.UserDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UserDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewCheckBoxColumn2})
        Me.UserDataGridView1.DataSource = Me.UserBindingSource1
        Me.UserDataGridView1.Location = New System.Drawing.Point(12, 32)
        Me.UserDataGridView1.Name = "UserDataGridView1"
        Me.UserDataGridView1.Size = New System.Drawing.Size(493, 220)
        Me.UserDataGridView1.TabIndex = 1
        '
        'NameSurnameLabel
        '
        NameSurnameLabel.AutoSize = True
        NameSurnameLabel.Location = New System.Drawing.Point(542, 35)
        NameSurnameLabel.Name = "NameSurnameLabel"
        NameSurnameLabel.Size = New System.Drawing.Size(47, 13)
        NameSurnameLabel.TabIndex = 2
        NameSurnameLabel.Text = "Nombre:"
        '
        'NameSurnameTextBox1
        '
        Me.NameSurnameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserBindingSource1, "NameSurname", True))
        Me.NameSurnameTextBox1.Location = New System.Drawing.Point(653, 32)
        Me.NameSurnameTextBox1.Name = "NameSurnameTextBox1"
        Me.NameSurnameTextBox1.Size = New System.Drawing.Size(182, 20)
        Me.NameSurnameTextBox1.TabIndex = 3
        '
        'UserNameLabel
        '
        UserNameLabel.AutoSize = True
        UserNameLabel.Location = New System.Drawing.Point(542, 78)
        UserNameLabel.Name = "UserNameLabel"
        UserNameLabel.Size = New System.Drawing.Size(101, 13)
        UserNameLabel.TabIndex = 4
        UserNameLabel.Text = "Nombre de Usuario:"
        '
        'UserNameTextBox1
        '
        Me.UserNameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserBindingSource1, "UserName", True))
        Me.UserNameTextBox1.Location = New System.Drawing.Point(654, 75)
        Me.UserNameTextBox1.Name = "UserNameTextBox1"
        Me.UserNameTextBox1.Size = New System.Drawing.Size(181, 20)
        Me.UserNameTextBox1.TabIndex = 5
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Location = New System.Drawing.Point(542, 120)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(64, 13)
        PasswordLabel.TabIndex = 6
        PasswordLabel.Text = "Contraseña:"
        '
        'PasswordTextBox1
        '
        Me.PasswordTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserBindingSource1, "Password", True))
        Me.PasswordTextBox1.Location = New System.Drawing.Point(653, 117)
        Me.PasswordTextBox1.Name = "PasswordTextBox1"
        Me.PasswordTextBox1.Size = New System.Drawing.Size(182, 20)
        Me.PasswordTextBox1.TabIndex = 7
        '
        'AdminCheckBox1
        '
        Me.AdminCheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UserBindingSource1, "Admin", True))
        Me.AdminCheckBox1.Location = New System.Drawing.Point(545, 160)
        Me.AdminCheckBox1.Name = "AdminCheckBox1"
        Me.AdminCheckBox1.Size = New System.Drawing.Size(104, 24)
        Me.AdminCheckBox1.TabIndex = 9
        Me.AdminCheckBox1.Text = "Administrador"
        Me.AdminCheckBox1.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 150
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Nombre Usuario"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Nombre de Usuario"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 150
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Contraseña"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Contraseña"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "Administrador"
        Me.DataGridViewCheckBoxColumn2.HeaderText = "Admin"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        Me.DataGridViewCheckBoxColumn2.Width = 50
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(717, 217)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(118, 35)
        Me.btnSalir.TabIndex = 10
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'user
        '
        Me.ClientSize = New System.Drawing.Size(872, 272)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.AdminCheckBox1)
        Me.Controls.Add(PasswordLabel)
        Me.Controls.Add(Me.PasswordTextBox1)
        Me.Controls.Add(UserNameLabel)
        Me.Controls.Add(Me.UserNameTextBox1)
        Me.Controls.Add(NameSurnameLabel)
        Me.Controls.Add(Me.NameSurnameTextBox1)
        Me.Controls.Add(Me.UserDataGridView1)
        Me.Controls.Add(Me.UserBindingSource1BindingNavigator)
        Me.Name = "user"
        Me.Text = "Usuario"
        CType(Me.ScrumDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserBindingSource1BindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UserBindingSource1BindingNavigator.ResumeLayout(False)
        Me.UserBindingSource1BindingNavigator.PerformLayout()
        CType(Me.UserDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ScrumDataSet As WindowsApplication1.ScrumDataSet
    Friend WithEvents UserBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UserTableAdapter As WindowsApplication1.ScrumDataSetTableAdapters.UserTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.ScrumDataSetTableAdapters.TableAdapterManager
    Friend WithEvents UserBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UserBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents UserDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents NameSurnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UserNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AdminCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ScrumDataSet1 As WindowsApplication1.ScrumDataSet
    Friend WithEvents UserBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents UserTableAdapter1 As WindowsApplication1.ScrumDataSetTableAdapters.UserTableAdapter
    Friend WithEvents TableAdapterManager1 As WindowsApplication1.ScrumDataSetTableAdapters.TableAdapterManager
    Friend WithEvents UserBindingSource1BindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton6 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UserBindingSource1BindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents UserDataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents NameSurnameTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents UserNameTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents AdminCheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents btnSalir As System.Windows.Forms.Button
End Class
