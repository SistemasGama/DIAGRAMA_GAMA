Public Class OT_IMPRESION
    Private Sub Mensajes()
        ToolTip1.SetToolTip(TextBox2, "N° del CLIENTE.") 'Este N° es otorgado en la base de datos cliente de forma corrida'
        ToolTip1.SetToolTip(Label5, "Nombre del CLIENTE.") 'Nombre cargado base de datos cliente, nombre conque se factura'
    End Sub
    Private Sub OT_IMPRESION_Load(sender As Object, e As EventArgs) Handles Me.Load
        Mensajes()
    End Sub

    Private Sub Panel111_Paint(sender As Object, e As PaintEventArgs) Handles Panel111.Paint

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub
End Class