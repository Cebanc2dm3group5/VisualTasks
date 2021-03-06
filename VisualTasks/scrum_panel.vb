﻿Public Class scrum_panel
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
        loadTitle()
        loadStories()
        initView()
    End Sub
    Private Sub loadTitle()
        Try
            Dim conexion As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Scrum.mdb;")
            conexion.Open()

            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT NombreProyecto FROM Proyecto WHERE ProyectoID=" & projectID

            Dim dr As OleDb.OleDbDataReader

            dr = cmd.ExecuteReader

            While dr.Read
                Me.Text = dr(0)
            End While

            dr.Close()

            conexion.Close()
        Catch ex As Exception
            MsgBox("Error de conexion:" & ex.Message)
            Me.Close()
        End Try
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
            calculateProjectPoints()
            conexion.Close()
        Catch ex As Exception
            MsgBox("Error de conexion:" & ex.Message)
            Me.Close()
        End Try

    End Sub

    Private Sub btnNewStory_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewStory.Click

        Dim story As String

        story = InputBox("Nueva historia", "Introduzca una nueva historia", "")
        If story.Trim = "" Then
            MsgBox("El nombre de la historia está vacío y no se guardará")
        End If

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
        lstTODO.Items.Clear()
        lstToVerify.Items.Clear()
        lstDONE.Items.Clear()

        ReDim tasksDoingIDs(0)
        ReDim tasksDoneIDs(0)
        ReDim tasksTodoIDs(0)
        ReDim tasksToVerifyIDs(0)

        Dim texto As String

        Try
            Dim conexion As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Scrum.mdb;")
            conexion.Open()

            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT UsuarioID, Estado, Descripcion, TareaID FROM Tarea WHERE HistoriaID=" & StoryIDs(lstStories.SelectedIndex)

            Dim dr As OleDb.OleDbDataReader

            dr = cmd.ExecuteReader

            Dim positionTodo As Integer = 0
            Dim positionDoing As Integer = 0
            Dim positionToVerify As Integer = 0
            Dim positionDone As Integer = 0
            While dr.Read
                texto = ""
                Dim estado As Integer = dr(1)
                If estado = 1 Then
                    If dr(0) = userID Then
                        texto = "**"
                    End If
                    texto += dr(2)
                    lstTODO.Items.Add(texto)
                    ReDim Preserve tasksTodoIDs(positionTodo)
                    tasksTodoIDs(positionTodo) = dr(3)
                    positionTodo += 1
                ElseIf estado = 2 Then
                    If dr(0) = userID Then
                        texto = "**"
                    End If
                    texto += dr(2)
                    lstDOING.Items.Add(texto)
                    ReDim Preserve tasksDoingIDs(positionDoing)
                    tasksDoingIDs(positionDoing) = dr(3)
                    positionDoing += 1
                ElseIf estado = 3 Then
                    If dr(0) = userID Then
                        texto = "**"
                    End If
                    texto += dr(2)
                    lstToVerify.Items.Add(texto)
                    ReDim Preserve tasksToVerifyIDs(positionToVerify)
                    tasksToVerifyIDs(positionToVerify) = dr(3)
                    positionToVerify += 1
                ElseIf estado = 4 Then
                    If dr(0) = userID Then
                        texto = "**"
                    End If
                    texto += dr(2)
                    lstDONE.Items.Add(texto)
                    ReDim Preserve tasksDoneIDs(positionDone)
                    tasksDoneIDs(positionDone) = dr(3)
                    positionDone += 1
                End If
            End While

            dr.Close()

            conexion.Close()

            calculateProjectPoints()

        Catch ex As Exception
            MsgBox("Error de conexion:" & ex.Message)
            Me.Close()
        End Try
    End Sub

    Private Sub loadAllTasks()
        'TODO - load all tasks
        lstDOING.Items.Clear()
        lstTODO.Items.Clear()
        lstToVerify.Items.Clear()
        lstDONE.Items.Clear()

        ReDim tasksDoingIDs(0)
        ReDim tasksDoneIDs(0)
        ReDim tasksTodoIDs(0)
        ReDim tasksToVerifyIDs(0)

        Dim texto As String

        Try
            Dim conexion As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Scrum.mdb;")
            conexion.Open()

            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT Tarea.UsuarioID, Tarea.Estado, Tarea.Descripcion, Tarea.TareaID FROM Tarea, Historia WHERE Tarea.HistoriaID=Historia.HistoriaID AND Historia.ProyectoID=" & projectID

            Dim dr As OleDb.OleDbDataReader

            dr = cmd.ExecuteReader

            Dim positionTodo As Integer = 0
            Dim positionDoing As Integer = 0
            Dim positionToVerify As Integer = 0
            Dim positionDone As Integer = 0
            While dr.Read
                texto = ""
                Dim estado As Integer = dr(1)
                If estado = 1 Then
                    If dr(0) = userID Then
                        texto = "**"
                    End If
                    texto += dr(2)
                    lstTODO.Items.Add(texto)
                    ReDim Preserve tasksTodoIDs(positionTodo)
                    tasksTodoIDs(positionTodo) = dr(3)
                    positionTodo += 1
                ElseIf estado = 2 Then
                    If dr(0) = userID Then
                        texto = "**"
                    End If
                    texto += dr(2)
                    lstDOING.Items.Add(texto)
                    ReDim Preserve tasksDoingIDs(positionDoing)
                    tasksDoingIDs(positionDoing) = dr(3)
                    positionDoing += 1
                ElseIf estado = 3 Then
                    If dr(0) = userID Then
                        texto = "**"
                    End If
                    texto += dr(2)
                    lstToVerify.Items.Add(texto)
                    ReDim Preserve tasksToVerifyIDs(positionToVerify)
                    tasksToVerifyIDs(positionToVerify) = dr(3)
                    positionToVerify += 1
                ElseIf estado = 4 Then
                    If dr(0) = userID Then
                        texto = "**"
                    End If
                    texto += dr(2)
                    lstDONE.Items.Add(texto)
                    ReDim Preserve tasksDoneIDs(positionDone)
                    tasksDoneIDs(positionDone) = dr(3)
                    positionDone += 1
                End If
            End While

            dr.Close()
            calculateProjectPoints()
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
            cmd.CommandText = "INSERT INTO Historia (ProyectoID,Descripcion) VALUES (" & projectID & ",'" & story & "')"

            cmd.ExecuteNonQuery()

            conexion.Close()

        Catch ex As Exception

            MsgBox("Error de conexion:" & ex.Message)
            Me.Close()

        End Try

    End Sub

    Private Sub setTaskEstado(ByVal taskID As Integer, ByVal estado As Integer)
        Try
            Dim conexion As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Scrum.mdb;")
            conexion.Open()

            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "UPDATE Tarea SET Estado=" & estado & " WHERE TareaID=" & taskID

            cmd.ExecuteNonQuery()
            conexion.Close()
        Catch ex As Exception
            MsgBox("Error de conexion:" & ex.Message)
            Me.Close()
        End Try
        loadTasks()
    End Sub

    Private Sub btn1to2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1to2.Click
        If lstTODO.SelectedIndex <> -1 Then
            setTaskEstado(tasksTodoIDs(lstTODO.SelectedIndex), 2)
        End If
    End Sub

    Private Sub btn2to1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2to1.Click
        If lstDOING.SelectedIndex <> -1 Then
            setTaskEstado(tasksDoingIDs(lstDOING.SelectedIndex), 1)
        End If
    End Sub

    Private Sub btn2to3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2to3.Click
        If lstDOING.SelectedIndex <> -1 Then
            setTaskEstado(tasksDoingIDs(lstDOING.SelectedIndex), 3)
        End If
    End Sub

    Private Sub btn3to2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn3to2.Click
        If lstToVerify.SelectedIndex <> -1 Then
            setTaskEstado(tasksToVerifyIDs(lstToVerify.SelectedIndex), 2)
        End If
    End Sub

    Private Sub btn3to4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn3to4.Click
        If lstToVerify.SelectedIndex <> -1 Then
            setTaskEstado(tasksToVerifyIDs(lstToVerify.SelectedIndex), 4)
        End If
    End Sub

    Private Sub btn4to3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn4to3.Click
        If lstDONE.SelectedIndex <> -1 Then
            setTaskEstado(tasksDoneIDs(lstDONE.SelectedIndex), 3)
        End If
    End Sub

    Private Sub calculateProjectPoints()
        Try
            Dim conexion As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Scrum.mdb;")
            conexion.Open()

            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT Tarea.Estado, Tarea.Puntos FROM Tarea, Historia WHERE Tarea.HistoriaID=Historia.HistoriaID and Historia.ProyectoID=" & projectID

            Dim dr As OleDb.OleDbDataReader

            dr = cmd.ExecuteReader

            Dim totalPuntos As Integer = 0
            While dr.Read
                totalPuntos += dr(1)
            End While
            dr.Close()

            cmd.CommandText = "SELECT Tarea.Estado, Tarea.Puntos FROM Tarea, Historia WHERE Tarea.HistoriaID=Historia.HistoriaID and Historia.ProyectoID=" & projectID & " AND Tarea.Estado=4"
            dr = cmd.ExecuteReader

            Dim completadosPuntos As Integer = 0
            While dr.Read
                If dr(0) = 4 Then
                    completadosPuntos += dr(1)
                End If
            End While

            dr.Close()

            conexion.Close()

            lblPoints.Text = completadosPuntos & "/" & totalPuntos
        Catch ex As Exception
            MsgBox("Error de conexion:" & ex.Message)
            Me.Close()
        End Try
    End Sub
End Class