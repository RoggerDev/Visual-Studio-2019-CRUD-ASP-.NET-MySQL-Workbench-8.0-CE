<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class opciones
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
        Me.medicos = New System.Windows.Forms.Button()
        Me.btnpaciente = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'medicos
        '
        Me.medicos.Location = New System.Drawing.Point(139, 28)
        Me.medicos.Name = "medicos"
        Me.medicos.Size = New System.Drawing.Size(91, 23)
        Me.medicos.TabIndex = 0
        Me.medicos.Text = "Médicos"
        Me.medicos.UseVisualStyleBackColor = True
        '
        'btnpaciente
        '
        Me.btnpaciente.Location = New System.Drawing.Point(139, 77)
        Me.btnpaciente.Name = "btnpaciente"
        Me.btnpaciente.Size = New System.Drawing.Size(91, 23)
        Me.btnpaciente.TabIndex = 1
        Me.btnpaciente.Text = "Pacientes"
        Me.btnpaciente.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(139, 123)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(91, 23)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "Recetas"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'opciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(369, 181)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnpaciente)
        Me.Controls.Add(Me.medicos)
        Me.Name = "opciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Opciones"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents medicos As Button
    Friend WithEvents btnpaciente As Button
    Friend WithEvents Button3 As Button
End Class
