<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class scrup_panel
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
        Me.lstTODO = New System.Windows.Forms.ListBox()
        Me.lstDOING = New System.Windows.Forms.ListBox()
        Me.lstDONE = New System.Windows.Forms.ListBox()
        Me.btn1to2 = New System.Windows.Forms.Button()
        Me.btn2to3 = New System.Windows.Forms.Button()
        Me.btn2to1 = New System.Windows.Forms.Button()
        Me.btn3to2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lstStories = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.btn4to3 = New System.Windows.Forms.Button()
        Me.btn3to4 = New System.Windows.Forms.Button()
        Me.btnNewTask = New System.Windows.Forms.Button()
        Me.btnNewStory = New System.Windows.Forms.Button()
        Me.btnSeeAll = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GestionarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstTODO
        '
        Me.lstTODO.FormattingEnabled = True
        Me.lstTODO.Location = New System.Drawing.Point(292, 41)
        Me.lstTODO.Name = "lstTODO"
        Me.lstTODO.Size = New System.Drawing.Size(205, 277)
        Me.lstTODO.TabIndex = 0
        '
        'lstDOING
        '
        Me.lstDOING.FormattingEnabled = True
        Me.lstDOING.Location = New System.Drawing.Point(548, 41)
        Me.lstDOING.Name = "lstDOING"
        Me.lstDOING.Size = New System.Drawing.Size(205, 277)
        Me.lstDOING.TabIndex = 1
        '
        'lstDONE
        '
        Me.lstDONE.FormattingEnabled = True
        Me.lstDONE.Location = New System.Drawing.Point(802, 41)
        Me.lstDONE.Name = "lstDONE"
        Me.lstDONE.Size = New System.Drawing.Size(205, 277)
        Me.lstDONE.TabIndex = 2
        '
        'btn1to2
        '
        Me.btn1to2.Location = New System.Drawing.Point(503, 84)
        Me.btn1to2.Name = "btn1to2"
        Me.btn1to2.Size = New System.Drawing.Size(36, 53)
        Me.btn1to2.TabIndex = 3
        Me.btn1to2.Text = "->"
        Me.btn1to2.UseVisualStyleBackColor = True
        '
        'btn2to3
        '
        Me.btn2to3.Location = New System.Drawing.Point(759, 84)
        Me.btn2to3.Name = "btn2to3"
        Me.btn2to3.Size = New System.Drawing.Size(36, 53)
        Me.btn2to3.TabIndex = 4
        Me.btn2to3.Text = "->"
        Me.btn2to3.UseVisualStyleBackColor = True
        '
        'btn2to1
        '
        Me.btn2to1.Location = New System.Drawing.Point(503, 200)
        Me.btn2to1.Name = "btn2to1"
        Me.btn2to1.Size = New System.Drawing.Size(36, 53)
        Me.btn2to1.TabIndex = 5
        Me.btn2to1.Text = "<-"
        Me.btn2to1.UseVisualStyleBackColor = True
        '
        'btn3to2
        '
        Me.btn3to2.Location = New System.Drawing.Point(760, 200)
        Me.btn3to2.Name = "btn3to2"
        Me.btn3to2.Size = New System.Drawing.Size(36, 53)
        Me.btn3to2.TabIndex = 6
        Me.btn3to2.Text = "<-"
        Me.btn3to2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(356, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 24)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "TO-DO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(611, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 24)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "DOING"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(845, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 24)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "TO-VERIFY"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(81, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 24)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "STORIES"
        '
        'lstStories
        '
        Me.lstStories.FormattingEnabled = True
        Me.lstStories.Location = New System.Drawing.Point(28, 41)
        Me.lstStories.Name = "lstStories"
        Me.lstStories.Size = New System.Drawing.Size(205, 277)
        Me.lstStories.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(1116, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 24)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "DONE"
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(1060, 41)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(202, 277)
        Me.ListBox2.TabIndex = 13
        '
        'btn4to3
        '
        Me.btn4to3.Location = New System.Drawing.Point(1014, 200)
        Me.btn4to3.Name = "btn4to3"
        Me.btn4to3.Size = New System.Drawing.Size(36, 53)
        Me.btn4to3.TabIndex = 16
        Me.btn4to3.Text = "<-"
        Me.btn4to3.UseVisualStyleBackColor = True
        '
        'btn3to4
        '
        Me.btn3to4.Location = New System.Drawing.Point(1013, 84)
        Me.btn3to4.Name = "btn3to4"
        Me.btn3to4.Size = New System.Drawing.Size(36, 53)
        Me.btn3to4.TabIndex = 15
        Me.btn3to4.Text = "->"
        Me.btn3to4.UseVisualStyleBackColor = True
        '
        'btnNewTask
        '
        Me.btnNewTask.Location = New System.Drawing.Point(239, 145)
        Me.btnNewTask.Name = "btnNewTask"
        Me.btnNewTask.Size = New System.Drawing.Size(47, 53)
        Me.btnNewTask.TabIndex = 17
        Me.btnNewTask.Text = "+ Task"
        Me.btnNewTask.UseVisualStyleBackColor = True
        '
        'btnNewStory
        '
        Me.btnNewStory.Enabled = False
        Me.btnNewStory.Location = New System.Drawing.Point(28, 324)
        Me.btnNewStory.Name = "btnNewStory"
        Me.btnNewStory.Size = New System.Drawing.Size(98, 53)
        Me.btnNewStory.TabIndex = 18
        Me.btnNewStory.Text = "+ Story"
        Me.btnNewStory.UseVisualStyleBackColor = True
        '
        'btnSeeAll
        '
        Me.btnSeeAll.Location = New System.Drawing.Point(132, 324)
        Me.btnSeeAll.Name = "btnSeeAll"
        Me.btnSeeAll.Size = New System.Drawing.Size(101, 53)
        Me.btnSeeAll.TabIndex = 19
        Me.btnSeeAll.Text = "Ver todos"
        Me.btnSeeAll.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestionarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1281, 24)
        Me.MenuStrip1.TabIndex = 20
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GestionarToolStripMenuItem
        '
        Me.GestionarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuariosToolStripMenuItem})
        Me.GestionarToolStripMenuItem.Name = "GestionarToolStripMenuItem"
        Me.GestionarToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.GestionarToolStripMenuItem.Text = "Gestionar"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'scrup_panel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1281, 403)
        Me.Controls.Add(Me.btnSeeAll)
        Me.Controls.Add(Me.btnNewStory)
        Me.Controls.Add(Me.btnNewTask)
        Me.Controls.Add(Me.btn4to3)
        Me.Controls.Add(Me.btn3to4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lstStories)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn3to2)
        Me.Controls.Add(Me.btn2to1)
        Me.Controls.Add(Me.btn2to3)
        Me.Controls.Add(Me.btn1to2)
        Me.Controls.Add(Me.lstDONE)
        Me.Controls.Add(Me.lstDOING)
        Me.Controls.Add(Me.lstTODO)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "scrup_panel"
        Me.Text = "SCRUM"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstTODO As System.Windows.Forms.ListBox
    Friend WithEvents lstDOING As System.Windows.Forms.ListBox
    Friend WithEvents lstDONE As System.Windows.Forms.ListBox
    Friend WithEvents btn1to2 As System.Windows.Forms.Button
    Friend WithEvents btn2to3 As System.Windows.Forms.Button
    Friend WithEvents btn2to1 As System.Windows.Forms.Button
    Friend WithEvents btn3to2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lstStories As System.Windows.Forms.ListBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents btn4to3 As System.Windows.Forms.Button
    Friend WithEvents btn3to4 As System.Windows.Forms.Button
    Friend WithEvents btnNewTask As System.Windows.Forms.Button
    Friend WithEvents btnNewStory As System.Windows.Forms.Button
    Friend WithEvents btnSeeAll As System.Windows.Forms.Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents GestionarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
