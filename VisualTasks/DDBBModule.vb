Module DDBBModule

    Function isAdmin(ByVal userID As Integer) As Boolean
        'check if user is admin
        Dim admin As Boolean = False
        Try
            Dim conexion As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Scrum.mdb;")
            conexion.Open()

            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT Administrador FROM Usuario WHERE UsuarioID = " & userID

            Dim dr As OleDb.OleDbDataReader

            dr = cmd.ExecuteReader

            If dr.Read Then
                admin = dr(0)
            End If

            dr.Close()

            conexion.Close()
        Catch ex As Exception
            MsgBox("Error de conexion:" & ex.Message)
        End Try


        Return admin
    End Function

    Function isMaster(ByVal userID As Integer, ByVal projectID As Integer) As Boolean
        'check if user is projects master
        Dim master As Boolean = False
        Try
            Dim conexion As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Scrum.mdb;")
            conexion.Open()

            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT ScrumMaster FROM Proyecto WHERE ProyectoID = " & projectID

            Dim dr As OleDb.OleDbDataReader

            dr = cmd.ExecuteReader

            If dr.Read Then
                If dr(0) = userID Then
                    master = True
                Else
                    master = False
                End If
            End If

                dr.Close()

                conexion.Close()
        Catch ex As Exception
            MsgBox("Error de conexion:" & ex.Message)
        End Try


        Return master
    End Function

End Module
