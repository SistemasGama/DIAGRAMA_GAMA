<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OT16
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
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtNroPresup1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtNroPresup1
        '
        Me.txtNroPresup1.BackColor = System.Drawing.Color.Lime
        Me.txtNroPresup1.Location = New System.Drawing.Point(12, 12)
        Me.txtNroPresup1.Name = "txtNroPresup1"
        Me.txtNroPresup1.Size = New System.Drawing.Size(25, 26)
        Me.txtNroPresup1.TabIndex = 204
        '
        'OT16
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtNroPresup1)
        Me.Name = "OT16"
        Me.Text = "OT16"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents txtNroPresup1 As TextBox
End Class
