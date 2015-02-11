<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class new_task
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
        Me.btnSaveTask = New System.Windows.Forms.Button()
        Me.txtTaskName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbUser = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnSaveTask
        '
        Me.btnSaveTask.Location = New System.Drawing.Point(249, 38)
        Me.btnSaveTask.Name = "btnSaveTask"
        Me.btnSaveTask.Size = New System.Drawing.Size(139, 41)
        Me.btnSaveTask.TabIndex = 0
        Me.btnSaveTask.Text = "Guardar"
        Me.btnSaveTask.UseVisualStyleBackColor = True
        '
        'txtTaskName
        '
        Me.txtTaskName.Location = New System.Drawing.Point(12, 12)
        Me.txtTaskName.Name = "txtTaskName"
        Me.txtTaskName.Size = New System.Drawing.Size(376, 20)
        Me.txtTaskName.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Asignar a"
        '
        'cmbUser
        '
        Me.cmbUser.FormattingEnabled = True
        Me.cmbUser.Location = New System.Drawing.Point(85, 49)
        Me.cmbUser.Name = "cmbUser"
        Me.cmbUser.Size = New System.Drawing.Size(121, 21)
        Me.cmbUser.TabIndex = 6
        '
        'new_task
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 87)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbUser)
        Me.Controls.Add(Me.txtTaskName)
        Me.Controls.Add(Me.btnSaveTask)
        Me.Name = "new_task"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nueva tarea"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSaveTask As System.Windows.Forms.Button
    Friend WithEvents txtTaskName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbUser As System.Windows.Forms.ComboBox
End Class
