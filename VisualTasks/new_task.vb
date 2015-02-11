Public Class new_task

    Private storyID As Integer
    Private isMaster As Boolean

    Sub New(ByVal sID As Integer, ByVal master As Boolean)
        InitializeComponent()
        storyID = sID
        isMaster = master
    End Sub


    Private Sub btnSaveTask_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveTask.Click
        SaveTask()
    End Sub

    Private Sub SaveTask()
        'TODO - save task

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub new_task_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If isMaster Then
            loadAllUsersCombo()
        Else
            loadUserCombo()
            cmbUser.Enabled = False
        End If
    End Sub

    Private Sub loadAllUsersCombo()
        'TODO - load all users in combo
    End Sub

    Private Sub loadUserCombo()
        'TODO - load current user in combo
    End Sub

End Class