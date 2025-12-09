Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class INSUMO


    Private Sub Mensajes()
        ToolTip1.SetToolTip(txtNroPresup, "Ingrese el número de presupuesto previamente creado en LITOPLAN.") 'jjfff'
        ToolTip1.SetToolTip(ComboBox141, "Ingrese el número de presupuesto previamente creado en LITOPLAN.")
        ToolTip1.SetToolTip(ComboBox2, "Ingrese el número de presupuesto previamente creado en LITOPLAN.")
        ToolTip1.SetToolTip(ComboBox8, "Ingrese el número de presupuesto previamente creado en LITOPLAN.")
    End Sub

    Private Sub INSUMO_Load(sender As Object, e As EventArgs) Handles Me.Load
        Mensajes()
    End Sub
End Class