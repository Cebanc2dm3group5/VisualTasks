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
        'TODO - check user


        Return 1
    End Function

    Private Sub txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUsername.TextChanged, txtPassword.TextChanged
        If txtUsername.Text <> "" And txtPassword.Text <> "" Then
            btnLogin.Enabled = True
        Else
            btnLogin.Enabled = False
        End If
    End Sub
End Class
