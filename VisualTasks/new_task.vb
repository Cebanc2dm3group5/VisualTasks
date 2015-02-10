Public Class new_task

    Private storyID As Integer

    Sub New(ByVal ID As Integer)
        InitializeComponent()
        storyID = ID
    End Sub


    Private Sub btnSaveTask_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveTask.Click
        SaveTask()
    End Sub

    Private Sub SaveTask()
        'TODO - save task

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

End Class