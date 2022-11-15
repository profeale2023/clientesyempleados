Public Class Empleado
    Inherits Persona

    'Atributos
    Private _tipoContrato As String
    Private _sueldo As Double

    'Propiedades
    Public Property TipoContrato As String
        Get
            Return _tipoContrato
        End Get
        Set(value As String)
            _tipoContrato = value

        End Set
    End Property
    Public Property Sueldo As Double
        Get
            Return _sueldo
        End Get
        Set(value As Double)
            _sueldo = value
        End Set
    End Property

    'Metodos

    Public Sub calcularSueldo(sueldobase As Double)
        If (Me.TipoContrato = "C") Then
            Me._sueldo = sueldobase + 350
        ElseIf (Me.TipoContrato = "N") Then
            Me._sueldo = sueldobase + 750
        Else
            Me._sueldo = 0

        End If
    End Sub
End Class
