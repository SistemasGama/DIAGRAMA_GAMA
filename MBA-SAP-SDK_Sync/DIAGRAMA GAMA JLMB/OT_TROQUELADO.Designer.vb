<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OT_TROQUELADO
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
<<<<<<< HEAD:MBA-SAP-SDK_Sync/DIAGRAMA GAMA JLMB/OT_TROQUELADO.Designer.vb
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OT_TROQUELADO))
        Me.Label43 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(12, 67)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(1501, 203)
        Me.Label43.TabIndex = 21
        Me.Label43.Text = resources.GetString("Label43.Text")
        '
        'OT_TROQUELADO
=======
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtNroPresup1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtNroPresup1
        '
        Me.txtNroPresup1.BackColor = System.Drawing.Color.Lime
        Me.txtNroPresup1.Location = New System.Drawing.Point(23, 21)
        Me.txtNroPresup1.Name = "txtNroPresup1"
        Me.txtNroPresup1.Size = New System.Drawing.Size(25, 26)
        Me.txtNroPresup1.TabIndex = 204
        '
        'TROQUELADO
>>>>>>> pre-main:MBA-SAP-SDK_Sync/DIAGRAMA GAMA JLMB/OT TROQUELADO.Designer.vb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1349, 708)
<<<<<<< HEAD:MBA-SAP-SDK_Sync/DIAGRAMA GAMA JLMB/OT_TROQUELADO.Designer.vb
        Me.Controls.Add(Me.Label43)
        Me.Name = "OT_TROQUELADO"
=======
        Me.Controls.Add(Me.txtNroPresup1)
        Me.Name = "TROQUELADO"
>>>>>>> pre-main:MBA-SAP-SDK_Sync/DIAGRAMA GAMA JLMB/OT TROQUELADO.Designer.vb
        Me.Text = "OT TROQUELADO"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

<<<<<<< HEAD:MBA-SAP-SDK_Sync/DIAGRAMA GAMA JLMB/OT_TROQUELADO.Designer.vb
    Friend WithEvents Label43 As Label
=======
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents txtNroPresup1 As TextBox
>>>>>>> pre-main:MBA-SAP-SDK_Sync/DIAGRAMA GAMA JLMB/OT TROQUELADO.Designer.vb
End Class
