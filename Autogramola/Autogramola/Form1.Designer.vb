<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionarLista
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnanadir = New System.Windows.Forms.Button()
        Me.btnborrar = New System.Windows.Forms.Button()
        Me.btnlimpiar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnanadir
        '
        Me.btnanadir.Location = New System.Drawing.Point(25, 50)
        Me.btnanadir.Name = "btnanadir"
        Me.btnanadir.Size = New System.Drawing.Size(89, 40)
        Me.btnanadir.TabIndex = 0
        Me.btnanadir.Text = "Añadir"
        Me.btnanadir.UseVisualStyleBackColor = True
        '
        'btnborrar
        '
        Me.btnborrar.Location = New System.Drawing.Point(203, 50)
        Me.btnborrar.Name = "btnborrar"
        Me.btnborrar.Size = New System.Drawing.Size(89, 40)
        Me.btnborrar.TabIndex = 1
        Me.btnborrar.Text = "Borrar"
        Me.btnborrar.UseVisualStyleBackColor = True
        '
        'btnlimpiar
        '
        Me.btnlimpiar.Location = New System.Drawing.Point(120, 149)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.Size = New System.Drawing.Size(89, 40)
        Me.btnlimpiar.TabIndex = 2
        Me.btnlimpiar.Text = "Limpiar votos"
        Me.btnlimpiar.UseVisualStyleBackColor = True
        '
        'GestionarLista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(326, 244)
        Me.Controls.Add(Me.btnlimpiar)
        Me.Controls.Add(Me.btnborrar)
        Me.Controls.Add(Me.btnanadir)
        Me.Name = "GestionarLista"
        Me.Text = "Gestionar lista"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnanadir As System.Windows.Forms.Button
    Friend WithEvents btnborrar As System.Windows.Forms.Button
    Friend WithEvents btnlimpiar As System.Windows.Forms.Button

End Class
