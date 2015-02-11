Public Class scrup_panel
    Dim projectID As Integer
    Dim userID As Integer

    Sub New(ByVal pID As Integer, ByVal uID As Integer)
        InitializeComponent()
        projectID = pID
        userID = uID
    End Sub

    Private Sub scrup_panel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadStories()
        initView()
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
        Dim storyID As Integer
        'TODO - get story ID
        Dim newTask As new_task = New new_task(storyID, isMaster(userID, projectID))
        If newTask.ShowDialog() = Windows.Forms.DialogResult.OK Then
            loadTasks()
        End If
    End Sub

    Private Sub loadTasks()
        'TODO - load tasks from story
    End Sub

    Private Sub loadAllTasks()
        'TODO - load all tasks
    End Sub

    Private Sub btnSeeAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeeAll.Click
        loadAllTasks()
    End Sub

    Private Sub lstStories_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstStories.SelectedIndexChanged
        loadTasks()
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsuariosToolStripMenuItem.Click
        If isMaster(userID, projectID) Then
            Dim projectUsers As project_users = New project_users(projectID)
        End If
    End Sub

    Private Sub initView()
        If isMaster(userID, projectID) Then

        End If
    End Sub

End Class