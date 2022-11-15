Imports Clases
Public Class frmRegistroNuevo
    Private Sub BtnRegistrar_Click(sender As Object, e As EventArgs) Handles BtnRegistrar.Click
        Dim empleado1 As Empleado = New Empleado()
        empleado1.Nombres = TxtNombre.Text
        empleado1.Apellidos = TxtApellido.Text
        empleado1.Tipo = CboTipo.Text
        empleado1.TipoContrato = CboContrato.Text
        empleado1.Documento = TxtDocumento.Text
        empleado1.calcularSueldo(750)

        GrdDatos.Rows.Insert(0,
            empleado1.Tipo,
            empleado1.Nombres,
            empleado1.Apellidos,
            empleado1.Documento,
            empleado1.TipoContrato,
            empleado1.Sueldo)
    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        Menu.Show()
        Me.Hide()
    End Sub
End Class

