<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class medico
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
        Me.nommed = New System.Windows.Forms.Label()
        Me.patmed = New System.Windows.Forms.Label()
        Me.matmed = New System.Windows.Forms.Label()
        Me.rfcmed = New System.Windows.Forms.Label()
        Me.idmed = New System.Windows.Forms.Label()
        Me.curpmed = New System.Windows.Forms.Label()
        Me.cedulamed = New System.Windows.Forms.Label()
        Me.telmed = New System.Windows.Forms.Label()
        Me.txt_idmedico = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtapepat = New System.Windows.Forms.TextBox()
        Me.txtapemat = New System.Windows.Forms.TextBox()
        Me.txtrfc = New System.Windows.Forms.TextBox()
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.txtcurp = New System.Windows.Forms.TextBox()
        Me.txtcedula = New System.Windows.Forms.TextBox()
        Me.registrarmed = New System.Windows.Forms.Button()
        Me.modificarmed = New System.Windows.Forms.Button()
        Me.eliminarmed = New System.Windows.Forms.Button()
        Me.regresa = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CB_especialidad = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CB_Genero = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtcontrasena = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBusq = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'nommed
        '
        Me.nommed.AutoSize = True
        Me.nommed.Location = New System.Drawing.Point(12, 57)
        Me.nommed.Name = "nommed"
        Me.nommed.Size = New System.Drawing.Size(44, 13)
        Me.nommed.TabIndex = 0
        Me.nommed.Text = "Nombre"
        '
        'patmed
        '
        Me.patmed.AutoSize = True
        Me.patmed.Location = New System.Drawing.Point(12, 94)
        Me.patmed.Name = "patmed"
        Me.patmed.Size = New System.Drawing.Size(84, 13)
        Me.patmed.TabIndex = 1
        Me.patmed.Text = "Apellido Paterno"
        '
        'matmed
        '
        Me.matmed.AutoSize = True
        Me.matmed.Location = New System.Drawing.Point(12, 129)
        Me.matmed.Name = "matmed"
        Me.matmed.Size = New System.Drawing.Size(86, 13)
        Me.matmed.TabIndex = 1
        Me.matmed.Text = "Apellido Materno"
        '
        'rfcmed
        '
        Me.rfcmed.AutoSize = True
        Me.rfcmed.Location = New System.Drawing.Point(286, 129)
        Me.rfcmed.Name = "rfcmed"
        Me.rfcmed.Size = New System.Drawing.Size(28, 13)
        Me.rfcmed.TabIndex = 1
        Me.rfcmed.Text = "RFC"
        '
        'idmed
        '
        Me.idmed.AutoSize = True
        Me.idmed.Location = New System.Drawing.Point(45, 242)
        Me.idmed.Name = "idmed"
        Me.idmed.Size = New System.Drawing.Size(216, 13)
        Me.idmed.TabIndex = 1
        Me.idmed.Text = "Ingrese el ID del paciente que desea buscar"
        '
        'curpmed
        '
        Me.curpmed.AutoSize = True
        Me.curpmed.Location = New System.Drawing.Point(286, 94)
        Me.curpmed.Name = "curpmed"
        Me.curpmed.Size = New System.Drawing.Size(37, 13)
        Me.curpmed.TabIndex = 1
        Me.curpmed.Text = "CURP"
        '
        'cedulamed
        '
        Me.cedulamed.AutoSize = True
        Me.cedulamed.Location = New System.Drawing.Point(12, 165)
        Me.cedulamed.Name = "cedulamed"
        Me.cedulamed.Size = New System.Drawing.Size(40, 13)
        Me.cedulamed.TabIndex = 1
        Me.cedulamed.Text = "Cédula"
        '
        'telmed
        '
        Me.telmed.AutoSize = True
        Me.telmed.Location = New System.Drawing.Point(286, 57)
        Me.telmed.Name = "telmed"
        Me.telmed.Size = New System.Drawing.Size(49, 13)
        Me.telmed.TabIndex = 1
        Me.telmed.Text = "Teléfono"
        '
        'txt_idmedico
        '
        Me.txt_idmedico.Location = New System.Drawing.Point(270, 17)
        Me.txt_idmedico.Name = "txt_idmedico"
        Me.txt_idmedico.Size = New System.Drawing.Size(143, 20)
        Me.txt_idmedico.TabIndex = 2
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(118, 54)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(143, 20)
        Me.txtnombre.TabIndex = 2
        '
        'txtapepat
        '
        Me.txtapepat.Location = New System.Drawing.Point(118, 91)
        Me.txtapepat.Name = "txtapepat"
        Me.txtapepat.Size = New System.Drawing.Size(143, 20)
        Me.txtapepat.TabIndex = 2
        '
        'txtapemat
        '
        Me.txtapemat.Location = New System.Drawing.Point(118, 126)
        Me.txtapemat.Name = "txtapemat"
        Me.txtapemat.Size = New System.Drawing.Size(143, 20)
        Me.txtapemat.TabIndex = 2
        '
        'txtrfc
        '
        Me.txtrfc.Location = New System.Drawing.Point(350, 126)
        Me.txtrfc.Name = "txtrfc"
        Me.txtrfc.Size = New System.Drawing.Size(135, 20)
        Me.txtrfc.TabIndex = 2
        '
        'txttelefono
        '
        Me.txttelefono.Location = New System.Drawing.Point(350, 54)
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(135, 20)
        Me.txttelefono.TabIndex = 2
        '
        'txtcurp
        '
        Me.txtcurp.Location = New System.Drawing.Point(350, 91)
        Me.txtcurp.Name = "txtcurp"
        Me.txtcurp.Size = New System.Drawing.Size(135, 20)
        Me.txtcurp.TabIndex = 2
        '
        'txtcedula
        '
        Me.txtcedula.Location = New System.Drawing.Point(118, 162)
        Me.txtcedula.Name = "txtcedula"
        Me.txtcedula.Size = New System.Drawing.Size(143, 20)
        Me.txtcedula.TabIndex = 2
        '
        'registrarmed
        '
        Me.registrarmed.Location = New System.Drawing.Point(524, 54)
        Me.registrarmed.Name = "registrarmed"
        Me.registrarmed.Size = New System.Drawing.Size(112, 23)
        Me.registrarmed.TabIndex = 3
        Me.registrarmed.Text = "Registrar"
        Me.registrarmed.UseVisualStyleBackColor = True
        '
        'modificarmed
        '
        Me.modificarmed.Location = New System.Drawing.Point(524, 83)
        Me.modificarmed.Name = "modificarmed"
        Me.modificarmed.Size = New System.Drawing.Size(112, 23)
        Me.modificarmed.TabIndex = 3
        Me.modificarmed.Text = "Modificar"
        Me.modificarmed.UseVisualStyleBackColor = True
        '
        'eliminarmed
        '
        Me.eliminarmed.Location = New System.Drawing.Point(524, 111)
        Me.eliminarmed.Name = "eliminarmed"
        Me.eliminarmed.Size = New System.Drawing.Size(112, 23)
        Me.eliminarmed.TabIndex = 3
        Me.eliminarmed.Text = "Eliminar"
        Me.eliminarmed.UseVisualStyleBackColor = True
        '
        'regresa
        '
        Me.regresa.Location = New System.Drawing.Point(545, 160)
        Me.regresa.Name = "regresa"
        Me.regresa.Size = New System.Drawing.Size(75, 23)
        Me.regresa.TabIndex = 3
        Me.regresa.Text = "Regresar"
        Me.regresa.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(486, 237)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 23)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "Consultar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CB_especialidad
        '
        Me.CB_especialidad.FormattingEnabled = True
        Me.CB_especialidad.Items.AddRange(New Object() {"Nutriología", "Optometría", "Odontología"})
        Me.CB_especialidad.Location = New System.Drawing.Point(118, 199)
        Me.CB_especialidad.Name = "CB_especialidad"
        Me.CB_especialidad.Size = New System.Drawing.Size(143, 21)
        Me.CB_especialidad.TabIndex = 34
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 203)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Especialidad"
        '
        'CB_Genero
        '
        Me.CB_Genero.AutoCompleteCustomSource.AddRange(New String() {"Seleccionar", "Hombre", "Mujer"})
        Me.CB_Genero.FormattingEnabled = True
        Me.CB_Genero.Items.AddRange(New Object() {"Hombre", "Mujer"})
        Me.CB_Genero.Location = New System.Drawing.Point(350, 162)
        Me.CB_Genero.Name = "CB_Genero"
        Me.CB_Genero.Size = New System.Drawing.Size(135, 21)
        Me.CB_Genero.TabIndex = 36
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(286, 165)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Género"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(286, 203)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Contraseña"
        '
        'txtcontrasena
        '
        Me.txtcontrasena.Location = New System.Drawing.Point(350, 199)
        Me.txtcontrasena.Name = "txtcontrasena"
        Me.txtcontrasena.Size = New System.Drawing.Size(135, 20)
        Me.txtcontrasena.TabIndex = 38
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(165, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "ID Asignado"
        '
        'txtBusq
        '
        Me.txtBusq.Location = New System.Drawing.Point(301, 239)
        Me.txtBusq.Name = "txtBusq"
        Me.txtBusq.Size = New System.Drawing.Size(135, 20)
        Me.txtBusq.TabIndex = 40
        '
        'medico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(654, 271)
        Me.Controls.Add(Me.txtBusq)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtcontrasena)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CB_Genero)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CB_especialidad)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.regresa)
        Me.Controls.Add(Me.eliminarmed)
        Me.Controls.Add(Me.modificarmed)
        Me.Controls.Add(Me.registrarmed)
        Me.Controls.Add(Me.txtapemat)
        Me.Controls.Add(Me.txtapepat)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.txtcedula)
        Me.Controls.Add(Me.txtcurp)
        Me.Controls.Add(Me.txttelefono)
        Me.Controls.Add(Me.txtrfc)
        Me.Controls.Add(Me.txt_idmedico)
        Me.Controls.Add(Me.telmed)
        Me.Controls.Add(Me.cedulamed)
        Me.Controls.Add(Me.curpmed)
        Me.Controls.Add(Me.idmed)
        Me.Controls.Add(Me.rfcmed)
        Me.Controls.Add(Me.matmed)
        Me.Controls.Add(Me.patmed)
        Me.Controls.Add(Me.nommed)
        Me.Name = "medico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Medico"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents nommed As Label
    Friend WithEvents patmed As Label
    Friend WithEvents matmed As Label
    Friend WithEvents rfcmed As Label
    Friend WithEvents idmed As Label
    Friend WithEvents curpmed As Label
    Friend WithEvents cedulamed As Label
    Friend WithEvents telmed As Label
    Friend WithEvents txt_idmedico As TextBox
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents txtapepat As TextBox
    Friend WithEvents txtapemat As TextBox
    Friend WithEvents txtrfc As TextBox
    Friend WithEvents txttelefono As TextBox
    Friend WithEvents txtcurp As TextBox
    Friend WithEvents txtcedula As TextBox
    Friend WithEvents registrarmed As Button
    Friend WithEvents modificarmed As Button
    Friend WithEvents eliminarmed As Button
    Friend WithEvents regresa As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents CB_especialidad As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CB_Genero As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtcontrasena As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtBusq As TextBox
End Class
