Public Class main_menu

    Private userID As Integer

    Sub New(ByVal ID As Integer)
        MyBase.New()
        InitializeComponent()
        userID = ID
        If isAdmin(userID) Then
            btnAdmin.Enabled = True
        End If
    End Sub

    Private Sub main_menu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MsgBox(userID)
    End Sub

    Private Sub lstProjects_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstProjects.DoubleClick

    End Sub

    Private Sub loadProjects()
        lstProjects.Items.Clear()
        'TODO - load projects

    End Sub

    Function isAdmin(ByVal userID As Integer) As Boolean
        'TODO -check if user is admin

        Return True
    End Function

    Private Sub btnNewProject_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewProject.Click
        Dim newProject As new_project = New new_project()
        If newProject.ShowDialog() = Windows.Forms.DialogResult.OK Then
            loadProjects()
        End If

    End Sub
End Class