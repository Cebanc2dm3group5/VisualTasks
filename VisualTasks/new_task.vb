Public Class new_task

    Private storyID As Integer
    Private isMaster As Boolean
    Private projectID As Integer
    Private usuarios() As Integer
    Private usuarioID As Integer

    Sub New(ByVal sID As Integer, ByVal master As Boolean, ByVal proID As Integer, ByVal userID As Integer)
        InitializeComponent()
        storyID = sID
        isMaster = master
        projectID = proID
        usuarioID = userID
    End Sub


    Private Sub btnSaveTask_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveTask.Click
        SaveTask()
    End Sub

    Private Sub SaveTask()
        'save task

        Dim taskName As String = txtTaskName.Text
        Dim points As Integer
        If txtPuntos.Text.Trim = "" Then
            points = 0
        Else
            points = CInt(txtPuntos.Text)
        End If

        If taskName.Trim = "" Or usuarioID < 1 Then

            MsgBox("Introduce todos los datos")

        ElseIf points < 1 Or points > 10 Then

            MsgBox("Introduce puntos entre 1 y 10")

        Else

            Try

                Dim conexion As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Scrum.mdb;")
                conexion.Open()

                Dim cmd As New OleDb.OleDbCommand
                cmd.Connection = conexion
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "INSERT INTO Tarea (HistoriaID,UsuarioID,Estado,Descripcion) VALUES (" & storyID & "," & usuarioID & "," & 1 & ",'" & taskName & "')"

                cmd.ExecuteNonQuery()

                conexion.Close()

                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()

            Catch ex As Exception

                MsgBox("Error de conexion:" & ex.Message)
                Me.Close()

            End Try

        End If
    End Sub

    Private Sub new_task_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If isMaster = True Then
            loadUserCombo()
        Else
            cmbUser.Enabled = False
        End If

    End Sub


    Private Sub loadUserCombo()

        'Load User
        'TODO Comprobar
        Try

            cmbUser.Items.Clear()

            Dim conexion As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Scrum.mdb;Persist Security Info=False;")
            Dim comando As New OleDb.OleDbCommand

            conexion.Open()
            comando.Connection = conexion
            comando.CommandType = CommandType.Text

            comando.CommandText = "SELECT Usuario.NombreUsuario, Usuario.UsuarioID FROM UsuarioProyecto, Usuario WHERE UsuarioProyecto.UsuarioID = Usuario.UsuarioID AND ProyectoID = " & projectID

            Dim dr As OleDb.OleDbDataReader

            dr = comando.ExecuteReader

            Dim i As Integer = 0

            While dr.Read

                ReDim Preserve usuarios(i)
                usuarios(i) = dr(1)
                cmbUser.Items.Add(dr(0))

                i += 1

            End While

            conexion.Close()

        Catch ex As Exception

            MsgBox(Err.Number & " " & Err.Description)
            Me.Close()

        End Try
    End Sub

    Private Sub cmbUser_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbUser.SelectedIndexChanged

        'Select UserID
        usuarioID = usuarios(cmbUser.SelectedIndex)

    End Sub
End Class