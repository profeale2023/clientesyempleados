Public Class Menu
    Private Sub BtnClientes_Click(sender As Object, e As EventArgs) Handles BtnClientes.Click
        FrmRegistroCliente.Show()
        frmRegistroNuevo.Hide()
    End Sub

    Private Sub BtnEmpleados_Click(sender As Object, e As EventArgs) Handles BtnEmpleados.Click
        frmRegistroNuevo.Show()
        FrmRegistroCliente.Hide()

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        End
    End Sub
End Class