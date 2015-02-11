<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class project_users
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
        Me.lstUsers = New System.Windows.Forms.ListBox()
        Me.cmbUser = New System.Windows.Forms.ComboBox()
        Me.btnAddUser = New System.Windows.Forms.Button()
        Me.btnDeleteUserProject = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstUsers
        '
        Me.lstUsers.FormattingEnabled = True
        Me.lstUsers.Location = New System.Drawing.Point(12, 12)
        Me.lstUsers.Name = "lstUsers"
        Me.lstUsers.Size = New System.Drawing.Size(159, 238)
        Me.lstUsers.TabIndex = 0
        '
        'cmbUser
        '
        Me.cmbUser.FormattingEnabled = True
        Me.cmbUser.Location = New System.Drawing.Point(200, 42)
        Me.cmbUser.Name = "cmbUser"
        Me.cmbUser.Size = New System.Drawing.Size(121, 21)
        Me.cmbUser.TabIndex = 5
        '
        'btnAddUser
        '
        Me.btnAddUser.Location = New System.Drawing.Point(226, 84)
        Me.btnAddUser.Name = "btnAddUser"
        Me.btnAddUser.Size = New System.Drawing.Size(63, 55)
        Me.btnAddUser.TabIndex = 8
        Me.btnAddUser.Text = "Añadir"
        Me.btnAddUser.UseVisualStyleBackColor = True
        '
        'btnDeleteUserProject
        '
        Me.btnDeleteUserProject.Location = New System.Drawing.Point(226, 158)
        Me.btnDeleteUserProject.Name = "btnDeleteUserProject"
        Me.btnDeleteUserProject.Size = New System.Drawing.Size(63, 55)
        Me.btnDeleteUserProject.TabIndex = 9
        Me.btnDeleteUserProject.Text = "Expulsar"
        Me.btnDeleteUserProject.UseVisualStyleBackColor = True
        '
        'project_users
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 262)
        Me.Controls.Add(Me.btnDeleteUserProject)
        Me.Controls.Add(Me.btnAddUser)
        Me.Controls.Add(Me.cmbUser)
        Me.Controls.Add(Me.lstUsers)
        Me.Name = "project_users"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Usuarios del proyecto"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstUsers As System.Windows.Forms.ListBox
    Friend WithEvents cmbUser As System.Windows.Forms.ComboBox
    Friend WithEvents btnAddUser As System.Windows.Forms.Button
    Friend WithEvents btnDeleteUserProject As System.Windows.Forms.Button
End Class
