<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OT_ImprOtTinta
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
        Me.Label488 = New System.Windows.Forms.Label()
        Me.Button89 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label488
        '
        Me.Label488.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label488.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label488.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label488.Location = New System.Drawing.Point(225, 175)
        Me.Label488.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label488.Name = "Label488"
        Me.Label488.Size = New System.Drawing.Size(656, 247)
        Me.Label488.TabIndex = 967
        Me.Label488.Text = "En esta ventana cargar programa que realisaste Ernesto con preparado de TINTA" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "IG" &
    "UAL COMO TENES HOY" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Sin cambios." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Se va activar con este boro emergente de OT"
        Me.Label488.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button89
        '
        Me.Button89.AutoSize = True
        Me.Button89.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button89.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button89.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button89.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Button89.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button89.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button89.ForeColor = System.Drawing.Color.Black
        Me.Button89.Location = New System.Drawing.Point(362, 112)
        Me.Button89.Name = "Button89"
        Me.Button89.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Button89.Size = New System.Drawing.Size(97, 38)
        Me.Button89.TabIndex = 983
        Me.Button89.Text = "Tinta"
        Me.Button89.UseVisualStyleBackColor = False
        '
        'OT_ImprOtTinta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1364, 749)
        Me.Controls.Add(Me.Button89)
        Me.Controls.Add(Me.Label488)
        Me.Name = "OT_ImprOtTinta"
        Me.Text = "TINTA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label488 As Label
    Friend WithEvents Button89 As Button
End Class
