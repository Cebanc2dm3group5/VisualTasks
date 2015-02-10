Public Class usuario

    Private Sub UserBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserBindingNavigatorSaveItem.Click

        'TODO: Controlar que no exista el UserName
        Me.Validate()
        Me.UserBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ScrumDataSet)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ScrumDataSet.User' Puede moverla o quitarla según sea necesario.
        Me.UserTableAdapter.Fill(Me.ScrumDataSet.User)

    End Sub
End Class