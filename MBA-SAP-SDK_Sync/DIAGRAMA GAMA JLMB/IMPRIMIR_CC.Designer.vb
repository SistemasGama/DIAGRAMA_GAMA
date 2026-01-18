<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IMPRIMIR_CC
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
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel75 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtNroPresup1 = New System.Windows.Forms.TextBox()
        Me.Panel4.SuspendLayout()
        Me.Panel75.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Green
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.txtNroPresup1)
        Me.Panel4.Controls.Add(Me.Label22)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1397, 43)
        Me.Panel4.TabIndex = 10
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(951, 6)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(221, 33)
        Me.Label22.TabIndex = 6
        Me.Label22.Text = "IMPRESION CC"
        '
        'Panel1
        '
        Me.Panel1.AllowDrop = True
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1397, 884)
        Me.Panel1.TabIndex = 0
        '
        'Panel75
        '
        Me.Panel75.Controls.Add(Me.Panel1)
        Me.Panel75.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel75.Location = New System.Drawing.Point(0, 0)
        Me.Panel75.Name = "Panel75"
        Me.Panel75.Size = New System.Drawing.Size(1397, 884)
        Me.Panel75.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(834, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 33)
        Me.Label1.TabIndex = 12
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.Controls.Add(Me.Panel75)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1397, 884)
        Me.Panel2.TabIndex = 11
        '
        'txtNroPresup1
        '
        Me.txtNroPresup1.BackColor = System.Drawing.Color.Lime
        Me.txtNroPresup1.Location = New System.Drawing.Point(10, -1)
        Me.txtNroPresup1.Name = "txtNroPresup1"
        Me.txtNroPresup1.Size = New System.Drawing.Size(25, 26)
        Me.txtNroPresup1.TabIndex = 204
        '
        'IMPRIMIR_CC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1397, 884)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "IMPRIMIR_CC"
        Me.Text = "IMPRESION CC"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel75.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel75 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label22 As Label
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents txtNroPresup1 As TextBox
End Class
