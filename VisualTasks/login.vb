Public Class login

    Private Sub login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text


        'Open main menu with userID if auth succeded
        Dim userID As Integer = authUser(username, password)
        If userID <> -1 Then
            Dim menu As main_menu = New main_menu(userID)
            menu.Show()
            Me.Close()
        End If

    End Sub

    Private Function authUser(ByVal username As String, ByVal password As String) As Integer
        'check user
        Dim id As Integer = -1
        Try
            Dim conexion As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Scrum.mdb;")
            conexion.Open()

            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT UsuarioID FROM Usuario WHERE NombreUsuario='" & username & "'"

            Dim dr As OleDb.OleDbDataReader

            dr = cmd.ExecuteReader

            If dr.Read Then
                id = dr(0)
            End If

            dr.Close()

            conexion.Close()
        Catch ex As Exception
            MsgBox("Error de conexion:" & ex.Message)
            Me.Close()
        End Try

        Return id
    End Function

    Private Sub txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUsername.TextChanged, txtPassword.TextChanged
        If txtUsername.Text <> "" And txtPassword.Text <> "" Then
            btnLogin.Enabled = True
        Else
            btnLogin.Enabled = False
        End If
    End Sub
End Class
