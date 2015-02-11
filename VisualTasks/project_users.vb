Public Class project_users
    Dim projectID As Integer
    Dim userComboIDs As Integer()
    Dim userProjectIDs As Integer()
    Private Sub project_users_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadProjectUsers()
        loadUserCombo()
    End Sub

    Sub New(ByVal ID As Integer)
        InitializeComponent()
        projectID = ID
    End Sub

    Private Sub loadProjectUsers()
        lstUsers.Items.Clear()

        'load project users
        Try
            Dim conexion As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Scrum.mdb;")
            conexion.Open()

            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT Usuario.NombreUsuario, Usuario.UsuarioID FROM Usuario, UsuarioProyecto WHERE Usuario.UsuarioID=UsuarioProyecto.UsuarioID AND UsuarioProyecto.ProyectoID=" & projectID

            Dim dr As OleDb.OleDbDataReader

            dr = cmd.ExecuteReader

            Dim position As Integer = 0
            While dr.Read
                lstUsers.Items.Add(dr(0))
                ReDim Preserve userProjectIDs(position)
                userProjectIDs(position) = dr(1)
                position += 1
            End While

            dr.Close()

            conexion.Close()
        Catch ex As Exception
            MsgBox("Error de conexion:" & ex.Message)
            Me.Close()
        End Try
    End Sub


    Private Sub btnAddUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddUser.Click
        'TODO - add user to project
        If cmbUser.SelectedIndex <> -1 Then
            Try
                Dim conexion As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Scrum.mdb;")
                conexion.Open()

                Dim cmd As New OleDb.OleDbCommand
                cmd.Connection = conexion
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "INSERT INTO UsuarioProyecto (UsuarioID, ProyectoID) VALUES (" & userComboIDs(cmbUser.SelectedIndex) & ", " & projectID & ")"
                cmd.ExecuteNonQuery()
                conexion.Close()
            Catch ex As Exception
                MsgBox("Error de conexion:" & ex.Message)
                Me.Close()
            End Try

            loadProjectUsers()
        End If
    End Sub

    Private Sub loadUserCombo()
        'load user combo
        cmbUser.Items.Clear()

        Try
            Dim conexion As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Scrum.mdb;")
            conexion.Open()

            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT NombreUsuario, UsuarioID FROM Usuario"

            Dim dr As OleDb.OleDbDataReader

            dr = cmd.ExecuteReader

            Dim position As Integer = 0
            While dr.Read
                cmbUser.Items.Add(dr(0))
                ReDim Preserve userComboIDs(position)
                userComboIDs(position) = dr(1)
                position += 1
            End While

            dr.Close()

            conexion.Close()
        Catch ex As Exception
            MsgBox("Error de conexion:" & ex.Message)
            Me.Close()
        End Try
    End Sub

    Private Sub btnDeleteUserProject_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteUserProject.Click
        'TODO - delete user from project
        If lstUsers.SelectedIndex <> -1 Then
            If Not isMaster(userProjectIDs(lstUsers.SelectedIndex), projectID) Then
                Try
                    Dim conexion As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Scrum.mdb;")
                    conexion.Open()

                    Dim cmd As New OleDb.OleDbCommand
                    cmd.Connection = conexion
                    cmd.CommandType = CommandType.Text
                    cmd.CommandText = "DELETE FROM UsuarioProyecto WHERE ProyectoID = " & projectID & " AND UsuarioID = " & userProjectIDs(lstUsers.SelectedIndex)
                    cmd.ExecuteNonQuery()
                    conexion.Close()
                Catch ex As Exception
                    MsgBox("Error de conexion:" & ex.Message)
                    Me.Close()
                End Try

                loadProjectUsers()
            End If
        End If
    End Sub
End Class