Imports Clases

Public Class FrmRegistroCliente
    Private Sub BtnRegistrar_Click(sender As Object, e As EventArgs) Handles BtnRegistrar.Click
        Dim Cliente1 As Cliente = New Cliente
        Cliente1.Tipo = CboTipo.Text
        Cliente1.Nombres = TxtNombre.Text
        Cliente1.Apellidos = TxtApellido.Text
        Cliente1.Documento = TxtDocumento.Text
        Cliente1.Categoria = CboCategoria.Text
        Cliente1.GenerarCodigo()

        'esto lo agregue para que se vea en el textbox tambien ( no seria necesario)
        TxtCodigo.Text = Cliente1.Codigo

        GrdDatos.Rows.Insert(0,
         Cliente1.Tipo,
         Cliente1.Nombres,
         Cliente1.Apellidos,
         Cliente1.Documento,
         Cliente1.Categoria,
         Cliente1.Codigo)
    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        Menu.Show()
        Me.Hide()
    End Sub
End Class