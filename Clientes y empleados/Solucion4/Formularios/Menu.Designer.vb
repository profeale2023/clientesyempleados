<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BtnClientes = New System.Windows.Forms.Button()
        Me.BtnEmpleados = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnClientes
        '
        Me.BtnClientes.Location = New System.Drawing.Point(139, 34)
        Me.BtnClientes.Name = "BtnClientes"
        Me.BtnClientes.Size = New System.Drawing.Size(261, 57)
        Me.BtnClientes.TabIndex = 0
        Me.BtnClientes.Text = "Registrar Nuevo Cliente"
        Me.BtnClientes.UseVisualStyleBackColor = True
        '
        'BtnEmpleados
        '
        Me.BtnEmpleados.Location = New System.Drawing.Point(139, 115)
        Me.BtnEmpleados.Name = "BtnEmpleados"
        Me.BtnEmpleados.Size = New System.Drawing.Size(261, 56)
        Me.BtnEmpleados.TabIndex = 1
        Me.BtnEmpleados.Text = "Registrar Nuevo  Empleado"
        Me.BtnEmpleados.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(139, 189)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(261, 54)
        Me.BtnSalir.TabIndex = 2
        Me.BtnSalir.Text = "Salir del Sistema"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(548, 319)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnEmpleados)
        Me.Controls.Add(Me.BtnClientes)
        Me.Name = "Menu"
        Me.Text = "Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnClientes As Button
    Friend WithEvents BtnEmpleados As Button
    Friend WithEvents BtnSalir As Button
End Class
