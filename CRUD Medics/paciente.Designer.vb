<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class paciente
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
        Me.regresa = New System.Windows.Forms.Button()
        Me.eliminarmed = New System.Windows.Forms.Button()
        Me.modificarmed = New System.Windows.Forms.Button()
        Me.registrarmed = New System.Windows.Forms.Button()
        Me.txtapemat = New System.Windows.Forms.TextBox()
        Me.txtapepat = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtnns = New System.Windows.Forms.TextBox()
        Me.txtcurp = New System.Windows.Forms.TextBox()
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.txtedadpac = New System.Windows.Forms.TextBox()
        Me.txtBusq = New System.Windows.Forms.TextBox()
        Me.telmed = New System.Windows.Forms.Label()
        Me.cedulamed = New System.Windows.Forms.Label()
        Me.curpmed = New System.Windows.Forms.Label()
        Me.idpaciente = New System.Windows.Forms.Label()
        Me.edadmed = New System.Windows.Forms.Label()
        Me.matmed = New System.Windows.Forms.Label()
        Me.patmed = New System.Windows.Forms.Label()
        Me.nommed = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CB_tipo = New System.Windows.Forms.ComboBox()
        Me.CB_Genero = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_idpaciente = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'regresa
        '
        Me.regresa.Location = New System.Drawing.Point(534, 183)
        Me.regresa.Name = "regresa"
        Me.regresa.Size = New System.Drawing.Size(75, 23)
        Me.regresa.TabIndex = 25
        Me.regresa.Text = "Regresar"
        Me.regresa.UseVisualStyleBackColor = True
        '
        'eliminarmed
        '
        Me.eliminarmed.Location = New System.Drawing.Point(516, 124)
        Me.eliminarmed.Name = "eliminarmed"
        Me.eliminarmed.Size = New System.Drawing.Size(112, 23)
        Me.eliminarmed.TabIndex = 24
        Me.eliminarmed.Text = "Eliminar"
        Me.eliminarmed.UseVisualStyleBackColor = True
        '
        'modificarmed
        '
        Me.modificarmed.Location = New System.Drawing.Point(516, 92)
        Me.modificarmed.Name = "modificarmed"
        Me.modificarmed.Size = New System.Drawing.Size(112, 23)
        Me.modificarmed.TabIndex = 23
        Me.modificarmed.Text = "Modificar"
        Me.modificarmed.UseVisualStyleBackColor = True
        '
        'registrarmed
        '
        Me.registrarmed.Location = New System.Drawing.Point(516, 60)
        Me.registrarmed.Name = "registrarmed"
        Me.registrarmed.Size = New System.Drawing.Size(112, 23)
        Me.registrarmed.TabIndex = 22
        Me.registrarmed.Text = "Registrar"
        Me.registrarmed.UseVisualStyleBackColor = True
        '
        'txtapemat
        '
        Me.txtapemat.Location = New System.Drawing.Point(111, 129)
        Me.txtapemat.Name = "txtapemat"
        Me.txtapemat.Size = New System.Drawing.Size(143, 20)
        Me.txtapemat.TabIndex = 20
        '
        'txtapepat
        '
        Me.txtapepat.Location = New System.Drawing.Point(111, 93)
        Me.txtapepat.Name = "txtapepat"
        Me.txtapepat.Size = New System.Drawing.Size(143, 20)
        Me.txtapepat.TabIndex = 19
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(111, 58)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(143, 20)
        Me.txtnombre.TabIndex = 18
        '
        'txtnns
        '
        Me.txtnns.Location = New System.Drawing.Point(326, 129)
        Me.txtnns.Name = "txtnns"
        Me.txtnns.Size = New System.Drawing.Size(135, 20)
        Me.txtnns.TabIndex = 17
        '
        'txtcurp
        '
        Me.txtcurp.Location = New System.Drawing.Point(326, 93)
        Me.txtcurp.Name = "txtcurp"
        Me.txtcurp.Size = New System.Drawing.Size(135, 20)
        Me.txtcurp.TabIndex = 16
        '
        'txttelefono
        '
        Me.txttelefono.Location = New System.Drawing.Point(326, 58)
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(135, 20)
        Me.txttelefono.TabIndex = 21
        '
        'txtedadpac
        '
        Me.txtedadpac.Location = New System.Drawing.Point(111, 203)
        Me.txtedadpac.Name = "txtedadpac"
        Me.txtedadpac.Size = New System.Drawing.Size(143, 20)
        Me.txtedadpac.TabIndex = 14
        '
        'txtBusq
        '
        Me.txtBusq.Location = New System.Drawing.Point(291, 239)
        Me.txtBusq.Name = "txtBusq"
        Me.txtBusq.Size = New System.Drawing.Size(143, 20)
        Me.txtBusq.TabIndex = 13
        '
        'telmed
        '
        Me.telmed.AutoSize = True
        Me.telmed.Location = New System.Drawing.Point(271, 61)
        Me.telmed.Name = "telmed"
        Me.telmed.Size = New System.Drawing.Size(49, 13)
        Me.telmed.TabIndex = 11
        Me.telmed.Text = "Teléfono"
        '
        'cedulamed
        '
        Me.cedulamed.AutoSize = True
        Me.cedulamed.Location = New System.Drawing.Point(273, 132)
        Me.cedulamed.Name = "cedulamed"
        Me.cedulamed.Size = New System.Drawing.Size(30, 13)
        Me.cedulamed.TabIndex = 10
        Me.cedulamed.Text = "NNS"
        '
        'curpmed
        '
        Me.curpmed.AutoSize = True
        Me.curpmed.Location = New System.Drawing.Point(271, 97)
        Me.curpmed.Name = "curpmed"
        Me.curpmed.Size = New System.Drawing.Size(37, 13)
        Me.curpmed.TabIndex = 9
        Me.curpmed.Text = "CURP"
        '
        'idpaciente
        '
        Me.idpaciente.AutoSize = True
        Me.idpaciente.Location = New System.Drawing.Point(38, 242)
        Me.idpaciente.Name = "idpaciente"
        Me.idpaciente.Size = New System.Drawing.Size(216, 13)
        Me.idpaciente.TabIndex = 8
        Me.idpaciente.Text = "Ingrese el ID del paciente que desea buscar"
        '
        'edadmed
        '
        Me.edadmed.AutoSize = True
        Me.edadmed.Location = New System.Drawing.Point(12, 207)
        Me.edadmed.Name = "edadmed"
        Me.edadmed.Size = New System.Drawing.Size(32, 13)
        Me.edadmed.TabIndex = 6
        Me.edadmed.Text = "Edad"
        '
        'matmed
        '
        Me.matmed.AutoSize = True
        Me.matmed.Location = New System.Drawing.Point(12, 135)
        Me.matmed.Name = "matmed"
        Me.matmed.Size = New System.Drawing.Size(86, 13)
        Me.matmed.TabIndex = 5
        Me.matmed.Text = "Apellido Materno"
        '
        'patmed
        '
        Me.patmed.AutoSize = True
        Me.patmed.Location = New System.Drawing.Point(12, 99)
        Me.patmed.Name = "patmed"
        Me.patmed.Size = New System.Drawing.Size(84, 13)
        Me.patmed.TabIndex = 12
        Me.patmed.Text = "Apellido Paterno"
        '
        'nommed
        '
        Me.nommed.AutoSize = True
        Me.nommed.Location = New System.Drawing.Point(12, 61)
        Me.nommed.Name = "nommed"
        Me.nommed.Size = New System.Drawing.Size(44, 13)
        Me.nommed.TabIndex = 4
        Me.nommed.Text = "Nombre"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(475, 237)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 23)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "Consultar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 170)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Tipo de Paciente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(273, 165)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Género"
        '
        'CB_tipo
        '
        Me.CB_tipo.FormattingEnabled = True
        Me.CB_tipo.Items.AddRange(New Object() {"Seleccionar", "Estudiante", "Docente", "Personal de Apoyo"})
        Me.CB_tipo.Location = New System.Drawing.Point(111, 165)
        Me.CB_tipo.Name = "CB_tipo"
        Me.CB_tipo.Size = New System.Drawing.Size(143, 21)
        Me.CB_tipo.TabIndex = 32
        '
        'CB_Genero
        '
        Me.CB_Genero.AutoCompleteCustomSource.AddRange(New String() {"Seleccionar", "Hombre", "Mujer"})
        Me.CB_Genero.FormattingEnabled = True
        Me.CB_Genero.Items.AddRange(New Object() {"Seleccionar", "Hombre", "Mujer"})
        Me.CB_Genero.Location = New System.Drawing.Point(326, 165)
        Me.CB_Genero.Name = "CB_Genero"
        Me.CB_Genero.Size = New System.Drawing.Size(135, 21)
        Me.CB_Genero.TabIndex = 33
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(169, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "ID Asignado"
        '
        'txt_idpaciente
        '
        Me.txt_idpaciente.Location = New System.Drawing.Point(274, 17)
        Me.txt_idpaciente.Name = "txt_idpaciente"
        Me.txt_idpaciente.Size = New System.Drawing.Size(143, 20)
        Me.txt_idpaciente.TabIndex = 40
        '
        'paciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(654, 271)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_idpaciente)
        Me.Controls.Add(Me.CB_Genero)
        Me.Controls.Add(Me.CB_tipo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.regresa)
        Me.Controls.Add(Me.eliminarmed)
        Me.Controls.Add(Me.modificarmed)
        Me.Controls.Add(Me.registrarmed)
        Me.Controls.Add(Me.txtapemat)
        Me.Controls.Add(Me.txtapepat)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.txtnns)
        Me.Controls.Add(Me.txtcurp)
        Me.Controls.Add(Me.txttelefono)
        Me.Controls.Add(Me.txtedadpac)
        Me.Controls.Add(Me.txtBusq)
        Me.Controls.Add(Me.telmed)
        Me.Controls.Add(Me.cedulamed)
        Me.Controls.Add(Me.curpmed)
        Me.Controls.Add(Me.idpaciente)
        Me.Controls.Add(Me.edadmed)
        Me.Controls.Add(Me.matmed)
        Me.Controls.Add(Me.patmed)
        Me.Controls.Add(Me.nommed)
        Me.Name = "paciente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Paciente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents regresa As Button
    Friend WithEvents eliminarmed As Button
    Friend WithEvents modificarmed As Button
    Friend WithEvents registrarmed As Button
    Friend WithEvents txtapemat As TextBox
    Friend WithEvents txtapepat As TextBox
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents txtnns As TextBox
    Friend WithEvents txtcurp As TextBox
    Friend WithEvents txttelefono As TextBox
    Friend WithEvents txtedadpac As TextBox
    Friend WithEvents txtBusq As TextBox
    Friend WithEvents telmed As Label
    Friend WithEvents cedulamed As Label
    Friend WithEvents curpmed As Label
    Friend WithEvents idpaciente As Label
    Friend WithEvents edadmed As Label
    Friend WithEvents matmed As Label
    Friend WithEvents patmed As Label
    Friend WithEvents nommed As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CB_tipo As ComboBox
    Friend WithEvents CB_Genero As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_idpaciente As TextBox
End Class
