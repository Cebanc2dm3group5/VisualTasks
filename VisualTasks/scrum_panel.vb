Public Class scrum_panel
    Dim projectID As Integer
    Dim userID As Integer

    Dim StoryIDs As Integer()

    Dim tasksTodoIDs As Integer()

    Dim tasksDoingIDs As Integer()

    Dim tasksToVerifyIDs As Integer()

    Dim tasksDoneIDs As Integer()

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
        'load stories
        Try
            Dim conexion As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Scrum.mdb;")
            conexion.Open()

            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT Descripcion, HistoriaID FROM Historia WHERE ProyectoID=" & projectID

            Dim dr As OleDb.OleDbDataReader

            dr = cmd.ExecuteReader

            Dim position As Integer = 0
            While dr.Read
                lstStories.Items.Add(dr(0))
                ReDim Preserve StoryIDs(position)
                StoryIDs(position) = dr(1)
                position += 1
            End While

            dr.Close()

            conexion.Close()
        Catch ex As Exception
            MsgBox("Error de conexion:" & ex.Message)
            Me.Close()
        End Try

    End Sub

    Private Sub btnNewStory_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewStory.Click

        Dim story As String

        Do
            story = InputBox("Nueva historia", "Introduzca una nueva historia", "")
            If story.Trim = "" Then
                MsgBox("Inserta el nombre de la historia")
            End If
        Loop While story.Trim = ""

        'save story
        saveStory(story, 0)
        loadStories()

    End Sub

    Private Sub btnNewTask_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewTask.Click
        Dim storyID As Integer
        'get story ID
        If lstStories.SelectedIndex <> -1 Then
            storyID = StoryIDs(lstStories.SelectedIndex)
            Dim newTask As new_task = New new_task(storyID, isMaster(userID, projectID), projectID, userID)
            If newTask.ShowDialog() = Windows.Forms.DialogResult.OK Then
                loadTasks()
            End If
        End If
    End Sub

    Private Sub loadTasks()
        'load tasks from story
        lstDOING.Items.Clear()
        lstDONE.Items.Clear()
        lstToVerify.Items.Clear()
        lstDONE.Items.Clear()

        Try
            Dim conexion As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Scrum.mdb;")
            conexion.Open()

            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT UsuarioID, Estado, Descripcion FROM Tarea WHERE HistoriaID=" & StoryIDs(lstStories.SelectedIndex)

            Dim dr As OleDb.OleDbDataReader

            dr = cmd.ExecuteReader

            Dim positionTodo As Integer = 0
            Dim positionDoing As Integer = 0
            Dim positionToVerify As Integer = 0
            Dim positionDone As Integer = 0
            While dr.Read
                Dim estado As Integer = dr(1)
                If estado = 1 Then
                    lstTODO.Items.Add(dr(2))
                    ReDim Preserve tasksTodoIDs(positionTodo)
                    tasksTodoIDs(positionTodo) = dr(0)
                    positionTodo += 1
                ElseIf estado = 2 Then
                    lstDOING.Items.Add(dr(2))
                    ReDim Preserve tasksDoingIDs(positionDoing)
                    tasksDoingIDs(positionDoing) = dr(0)
                    positionDoing += 1
                ElseIf estado = 3 Then
                    lstToVerify.Items.Add(dr(2))
                    ReDim Preserve tasksToVerifyIDs(positionToVerify)
                    tasksToVerifyIDs(positionToVerify) = dr(0)
                    positionToVerify += 1
                Else
                    lstTODO.Items.Add(dr(2))
                    ReDim Preserve tasksDoneIDs(positionDone)
                    tasksDoneIDs(positionDone) = dr(0)
                    positionDone += 1
                End If
            End While

            dr.Close()

            conexion.Close()
        Catch ex As Exception
            MsgBox("Error de conexion:" & ex.Message)
            Me.Close()
        End Try
    End Sub

    Private Sub loadAllTasks()
        'TODO - load all tasks
        lstDOING.Items.Clear()
        lstDONE.Items.Clear()
        lstToVerify.Items.Clear()
        lstDONE.Items.Clear()

        Try
            Dim conexion As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Scrum.mdb;")
            conexion.Open()

            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT Tarea.UsuarioID, Tarea.Estado, Tarea.Descripcion FROM Tarea, Historia WHERE Tarea.HistoriaID=Historia.HistoriaID AND Historia.ProyectoID=" & projectID

            Dim dr As OleDb.OleDbDataReader

            dr = cmd.ExecuteReader

            Dim positionTodo As Integer = 0
            Dim positionDoing As Integer = 0
            Dim positionToVerify As Integer = 0
            Dim positionDone As Integer = 0
            While dr.Read
                Dim estado As Integer = dr(1)
                If estado = 1 Then
                    lstTODO.Items.Add(dr(2))
                    ReDim Preserve tasksTodoIDs(positionTodo)
                    tasksTodoIDs(positionTodo) = dr(0)
                    positionTodo += 1
                ElseIf estado = 2 Then
                    lstDOING.Items.Add(dr(2))
                    ReDim Preserve tasksDoingIDs(positionDoing)
                    tasksDoingIDs(positionDoing) = dr(0)
                    positionDoing += 1
                ElseIf estado = 3 Then
                    lstToVerify.Items.Add(dr(2))
                    ReDim Preserve tasksToVerifyIDs(positionToVerify)
                    tasksToVerifyIDs(positionToVerify) = dr(0)
                    positionToVerify += 1
                Else
                    lstTODO.Items.Add(dr(2))
                    ReDim Preserve tasksDoneIDs(positionDone)
                    tasksDoneIDs(positionDone) = dr(0)
                    positionDone += 1
                End If
            End While

            dr.Close()

            conexion.Close()
        Catch ex As Exception
            MsgBox("Error de conexion:" & ex.Message)
            Me.Close()
        End Try
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
            projectUsers.Show()
        End If
    End Sub

    Private Sub initView()
        If isMaster(userID, projectID) Then
            btnNewStory.Enabled = True
            btn3to4.Enabled = True
            btn4to3.Enabled = True
            smiGestion.Enabled = True
        End If
    End Sub



    Private Sub saveStory(ByVal story As String, ByVal puntos As Integer)

        Try

            Dim conexion As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Scrum.mdb;")
            conexion.Open()

            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "INSERT INTO Historia (ProyectoID,Descripcion,Puntos) VALUES (" & projectID & ",'" & story & "'," & puntos & ")"

            cmd.ExecuteNonQuery()

            conexion.Close()

        Catch ex As Exception

            MsgBox("Error de conexion:" & ex.Message)
            Me.Close()

        End Try

    End Sub

End Class