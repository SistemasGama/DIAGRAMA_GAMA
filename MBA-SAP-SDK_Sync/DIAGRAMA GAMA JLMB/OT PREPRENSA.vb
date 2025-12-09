Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class PREPRENSA
    Private Sub Mensajes()
        ToolTip1.SetToolTip(txtNroPresup1, "Ingrese el número de presupuesto previamente creado en LITOPLAN.") 'jjfff'

    End Sub

    Private Sub PREPRENSA_Load(sender As Object, e As EventArgs) Handles Me.Load
        Mensajes()
    End Sub
End Class