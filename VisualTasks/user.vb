Public Class user

    Private Sub UserBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UserBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ScrumDataSet)

    End Sub

    Private Sub user_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ScrumDataSet.User' Puede moverla o quitarla según sea necesario.
        Me.UserTableAdapter.Fill(Me.ScrumDataSet.User)

    End Sub

    Private Sub NameSurnameLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub UserBindingSource1BindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserBindingSource1BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UserBindingSource1.EndEdit()
        Me.TableAdapterManager1.UpdateAll(Me.ScrumDataSet1)

    End Sub

    Private Sub user_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ScrumDataSet1.User' Puede moverla o quitarla según sea necesario.
        Me.UserTableAdapter1.Fill(Me.ScrumDataSet1.User)

    End Sub
End Class