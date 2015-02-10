Public Class new_project
    Dim userIDs As Integer()
    Dim selectedUserID As Integer
    Dim title As String = ""
    Dim description As String = ""
    Private Sub new_project_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadUserCombo()
    End Sub

    Private Sub loadUserCombo()
        'TODO - load users from DDBB
    End Sub

    Private Sub btnAccept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAccept.Click
        title = txtTitle.Text
        description = txtDescripcion.Text

        'TODO - save project

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub cmbMaster_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMaster.SelectedIndexChanged

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
End Class