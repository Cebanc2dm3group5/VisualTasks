Public Class new_project
    Dim userIDs As Integer()
    Dim selectedUserID As Integer
    Dim title As String = ""
    Dim description As String = ""
    Private Sub new_project_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadUserCombo()
    End Sub

    Private Sub loadUserCombo()
        'load users from DDBB
        cmbMaster.Items.Clear()
        'load projects
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
                cmbMaster.Items.Add(dr(0))
                ReDim userIDs(position)
                userIDs(position) = dr(1)
                position += 1
            End While

            dr.Close()

            conexion.Close()
        Catch ex As Exception
            MsgBox("Error de conexion:" & ex.Message)
            Me.Close()
        End Try
    End Sub

    Private Sub btnAccept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAccept.Click
        title = txtTitle.Text
        description = txtDescripcion.Text
        Dim userID As Integer = -1

        If cmbMaster.SelectedIndex <> -1 Then
            userID = userIDs(cmbMaster.SelectedIndex)
        End If

        'save project
        If title <> "" And description <> "" And userID <> -1 Then
            Try
                Dim conexion As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Scrum.mdb;")
                conexion.Open()

                Dim cmd As New OleDb.OleDbCommand
                cmd.Connection = conexion
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "INSERT INTO Proyecto (NombreProyecto, Descripcion, ScrumMaster) VALUES ('" & title & "', '" & description & "', " & userID & ")"

                cmd.ExecuteNonQuery()

                conexion.Close()
            Catch ex As Exception
                MsgBox("Error de conexion:" & ex.Message)
                Me.Close()
            End Try

            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Else
            MsgBox("Introduce todos los datos")
        End If
    End Sub

    Private Sub cmbMaster_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMaster.SelectedIndexChanged

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
End Class