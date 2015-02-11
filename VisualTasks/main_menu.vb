Public Class main_menu

    Private userID As Integer
    Private projectIDs As Integer()

    Sub New(ByVal ID As Integer)
        MyBase.New()
        InitializeComponent()
        userID = ID
        If isAdmin(userID) Then
            btnAdmin.Enabled = True
        End If
    End Sub

    Private Sub main_menu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadProjects()
    End Sub

    Private Sub lstProjects_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstProjects.DoubleClick

    End Sub

    Private Sub loadProjects()
        lstProjects.Items.Clear()
        'load projects
        Try
            Dim conexion As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Scrum.mdb;")
            conexion.Open()

            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT NombreProyecto, ProyectoID FROM Proyecto"

            Dim dr As OleDb.OleDbDataReader

            dr = cmd.ExecuteReader

            Dim position As Integer = 0
            While dr.Read
                lstProjects.Items.Add(dr(0))
                ReDim projectIDs(position)
                projectIDs(position) = dr(1)
                position += 1
            End While

            dr.Close()

            conexion.Close()
        Catch ex As Exception
            MsgBox("Error de conexion:" & ex.Message)
            Me.Close()
        End Try


    End Sub


    Private Sub btnNewProject_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewProject.Click
        Dim newProject As new_project = New new_project()
        If newProject.ShowDialog() = Windows.Forms.DialogResult.OK Then
            loadProjects()
        End If

    End Sub

    Private Sub btnDeleteProject_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteProject.Click
        'delete project
        If lstProjects.SelectedIndex <> -1 Then
            Try
                Dim conexion As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Scrum.mdb;")
                conexion.Open()

                Dim cmd As New OleDb.OleDbCommand
                cmd.Connection = conexion
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "DELETE FROM Proyecto WHERE ProyectoID = " & projectIDs(lstProjects.SelectedIndex)
                cmd.ExecuteNonQuery()
                conexion.Close()
            Catch ex As Exception
                MsgBox("Error de conexion:" & ex.Message)
                Me.Close()
            End Try

            loadProjects()
        End If
    End Sub

    Private Sub btnAdmin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdmin.Click

        Me.Hide()
        usuario.Show()

    End Sub
End Class