Public Class project_users
    Dim projectID As Integer
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

        'TODO - load project users
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstUsers.SelectedIndexChanged

    End Sub

    Private Sub btnAddUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddUser.Click
        'TODO - add user to project

        loadProjectUsers()
    End Sub

    Private Sub loadUserCombo()
        'TODO - load user combo
    End Sub

    Private Sub btnDeleteUserProject_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteUserProject.Click
        'TODO - delte user from project

        loadProjectUsers()
    End Sub
End Class