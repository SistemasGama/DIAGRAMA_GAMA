Public Class IMPRIMIR_CC
    Private Sub Mensajes()
        ToolTip1.SetToolTip(txtNroPresup1, "Ingrese el número de presupuesto previamente creado en LITOPLAN.") 'jjfff'

    End Sub

    Private Sub IMPRIMIR_CC_Load(sender As Object, e As EventArgs) Handles Me.Load
        Mensajes()
    End Sub
End Class