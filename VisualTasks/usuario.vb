Public Class usuario


    Private Function userExists(ByVal UserName As String) As Boolean

        Dim exists As Boolean = False

        Try

            Dim conexion As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Scrum.mdb;Persist Security Info=False;")
            Dim comando As New OleDb.OleDbCommand

            conexion.Open()
            comando.Connection = conexion
            comando.CommandType = CommandType.Text

            comando.CommandText = "SELECT COUNT(*) FROM Usuario WHERE NombreUsuario = '" & UserName & "'"
            Dim numUser As Integer = comando.ExecuteScalar()

            If numUser > 0 Then
                exists = True
            End If

            conexion.Close()

        Catch ex As Exception

            MsgBox(Err.Number & " " & Err.Description)

        End Try

        Return exists

    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        saveUser()

    End Sub

    Private Sub loadUsers()

        Try

            dgvUsers.Rows.Clear()

            Dim conexion As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Scrum.mdb;Persist Security Info=False;")
            Dim comando As New OleDb.OleDbCommand

            conexion.Open()
            comando.Connection = conexion
            comando.CommandType = CommandType.Text

            comando.CommandText = "SELECT * FROM Usuario"

            Dim dr As OleDb.OleDbDataReader

            dr = comando.ExecuteReader

            While dr.Read
                dgvUsers.Rows.Add(dr(0), dr(1), dr(2), dr(3), dr(4))
            End While

            dgvUsers.Rows(0).Selected = True

            conexion.Close()

            txtContrasena.Text = ""
            txtNombre.Text = ""
            txtNombreUsuario.Text = ""
            chcAdmin.Checked = False

        Catch ex As Exception

            MsgBox(Err.Number & " " & Err.Description)
            Me.Close()

        End Try

    End Sub

    Private Sub usuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadUsers()
    End Sub

    Private Sub saveUser()

        If txtNombre.Text.Trim = "" Or txtNombreUsuario.Text.Trim = "" Or txtContrasena.Text.Trim = "" Then

            MsgBox("Introduce todos los datos")

        ElseIf userExists(txtNombreUsuario.Text) = True Then


            MsgBox("Este nombre de usuario ya existe")

        Else

            Try

                Dim conexion As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Scrum.mdb;")
                conexion.Open()

                Dim cmd As New OleDb.OleDbCommand
                cmd.Connection = conexion
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "INSERT INTO Usuario (NombreApellido,NombreUsuario,Contrasena,Administrador) VALUES ('" & txtNombre.Text & "','" & txtNombreUsuario.Text & "','" & txtContrasena.Text & "'," & chcAdmin.Checked & ")"

                cmd.ExecuteNonQuery()

                conexion.Close()

                loadUsers()

            Catch ex As Exception

                MsgBox("Error de conexion:" & ex.Message)
                Me.Close()

            End Try

        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Dim UsuarioID As Integer

        UsuarioID = dgvUsers.CurrentRow.Cells(0).Value()

        If UsuarioID < 1 Then

            MsgBox("Seleccione un usuario")

        ElseIf UsuarioID = 1 Then

            MsgBox("El usuario admin no se puede eliminar")

        Else

            deleteUsuario(UsuarioID)

            loadUsers()

        End If

    End Sub

    Private Sub deleteUsuario(ByVal UsuarioID As Integer)

        Try

            Dim conexion As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Scrum.mdb;")
            conexion.Open()

            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "DELETE FROM Usuario where UsuarioID = " & UsuarioID

            cmd.ExecuteNonQuery()

            conexion.Close()

        Catch ex As Exception

            MsgBox("Error de conexion:" & ex.Message)
            Me.Close()

        End Try

    End Sub

    Private Sub SALIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SALIR.Click

        Me.Close()

    End Sub

    Private Sub dgvUsers_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvUsers.CellContentClick

    End Sub
End Class