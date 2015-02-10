<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main_menu
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
        Me.lstProjects = New System.Windows.Forms.ListBox()
        Me.btnAdmin = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnNewProject = New System.Windows.Forms.Button()
        Me.btnDeleteProject = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstProjects
        '
        Me.lstProjects.FormattingEnabled = True
        Me.lstProjects.Location = New System.Drawing.Point(12, 64)
        Me.lstProjects.Name = "lstProjects"
        Me.lstProjects.Size = New System.Drawing.Size(338, 186)
        Me.lstProjects.TabIndex = 0
        '
        'btnAdmin
        '
        Me.btnAdmin.Enabled = False
        Me.btnAdmin.Location = New System.Drawing.Point(12, 419)
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.Size = New System.Drawing.Size(338, 51)
        Me.btnAdmin.TabIndex = 1
        Me.btnAdmin.Text = "Administración"
        Me.btnAdmin.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(56, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(260, 31)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Elige tu proyecto..."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 317)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(282, 31)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "... o crea uno nuevo!"
        '
        'btnNewProject
        '
        Me.btnNewProject.Location = New System.Drawing.Point(13, 362)
        Me.btnNewProject.Name = "btnNewProject"
        Me.btnNewProject.Size = New System.Drawing.Size(338, 51)
        Me.btnNewProject.TabIndex = 4
        Me.btnNewProject.Text = "Nuevo proyecto"
        Me.btnNewProject.UseVisualStyleBackColor = True
        '
        'btnDeleteProject
        '
        Me.btnDeleteProject.Location = New System.Drawing.Point(12, 256)
        Me.btnDeleteProject.Name = "btnDeleteProject"
        Me.btnDeleteProject.Size = New System.Drawing.Size(338, 51)
        Me.btnDeleteProject.TabIndex = 5
        Me.btnDeleteProject.Text = "Eliminar proyecto"
        Me.btnDeleteProject.UseVisualStyleBackColor = True
        '
        'main_menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(363, 492)
        Me.Controls.Add(Me.btnDeleteProject)
        Me.Controls.Add(Me.btnNewProject)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAdmin)
        Me.Controls.Add(Me.lstProjects)
        Me.Name = "main_menu"
        Me.Text = "VisualTask menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstProjects As System.Windows.Forms.ListBox
    Friend WithEvents btnAdmin As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnNewProject As System.Windows.Forms.Button
    Friend WithEvents btnDeleteProject As System.Windows.Forms.Button
End Class
