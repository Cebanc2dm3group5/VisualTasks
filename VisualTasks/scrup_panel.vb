Public Class scrup_panel


    Private Sub scrup_panel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadStories()
    End Sub

    Private Sub loadStories()
        lstStories.Items.Clear()
        'TODO - load stories
    End Sub

    Private Sub btnNewStory_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewStory.Click
        Dim story As String = InputBox("Nueva historia", "Introduzca una nueva historia", "")
        If story <> "" Then
            'TODO - save story

            loadStories()
        End If
    End Sub

    Private Sub btnNewTask_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewTask.Click

    End Sub
End Class