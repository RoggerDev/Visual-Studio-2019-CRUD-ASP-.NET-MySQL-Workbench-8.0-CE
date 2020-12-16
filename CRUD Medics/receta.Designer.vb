<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class receta
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
        Me.txtBusq = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CB_especialidad = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Consultar = New System.Windows.Forms.Button()
        Me.regresa = New System.Windows.Forms.Button()
        Me.eliminarmed = New System.Windows.Forms.Button()
        Me.modificarmed = New System.Windows.Forms.Button()
        Me.registrarmed = New System.Windows.Forms.Button()
        Me.txt_folio = New System.Windows.Forms.TextBox()
        Me.cedulamed = New System.Windows.Forms.Label()
        Me.idmed = New System.Windows.Forms.Label()
        Me.nommed = New System.Windows.Forms.Label()
        Me.txtcedula = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_observaciones = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtnombrem = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtapepatm = New System.Windows.Forms.TextBox()
        Me.txtapematm = New System.Windows.Forms.TextBox()
        Me.txtnombrep = New System.Windows.Forms.TextBox()
        Me.matmed = New System.Windows.Forms.Label()
        Me.txtapematp = New System.Windows.Forms.TextBox()
        Me.patmed = New System.Windows.Forms.Label()
        Me.txtapepatp = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtedadp = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_idpaciente = New System.Windows.Forms.TextBox()
        Me.txt_idmedico = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.confirma_id = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtBusq
        '
        Me.txtBusq.Location = New System.Drawing.Point(234, 470)
        Me.txtBusq.Name = "txtBusq"
        Me.txtBusq.Size = New System.Drawing.Size(170, 20)
        Me.txtBusq.TabIndex = 69
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(448, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 68
        Me.Label4.Text = "FOLIO"
        '
        'CB_especialidad
        '
        Me.CB_especialidad.FormattingEnabled = True
        Me.CB_especialidad.Items.AddRange(New Object() {"Nutriología", "Optometría", "Odontología"})
        Me.CB_especialidad.Location = New System.Drawing.Point(351, 167)
        Me.CB_especialidad.Name = "CB_especialidad"
        Me.CB_especialidad.Size = New System.Drawing.Size(143, 21)
        Me.CB_especialidad.TabIndex = 63
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(272, 170)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Especialidad"
        '
        'Consultar
        '
        Me.Consultar.Location = New System.Drawing.Point(509, 468)
        Me.Consultar.Name = "Consultar"
        Me.Consultar.Size = New System.Drawing.Size(112, 23)
        Me.Consultar.TabIndex = 61
        Me.Consultar.Text = "Consultar"
        Me.Consultar.UseVisualStyleBackColor = True
        '
        'regresa
        '
        Me.regresa.Location = New System.Drawing.Point(521, 170)
        Me.regresa.Name = "regresa"
        Me.regresa.Size = New System.Drawing.Size(112, 23)
        Me.regresa.TabIndex = 60
        Me.regresa.Text = "Regresar"
        Me.regresa.UseVisualStyleBackColor = True
        '
        'eliminarmed
        '
        Me.eliminarmed.Location = New System.Drawing.Point(521, 109)
        Me.eliminarmed.Name = "eliminarmed"
        Me.eliminarmed.Size = New System.Drawing.Size(112, 23)
        Me.eliminarmed.TabIndex = 59
        Me.eliminarmed.Text = "Eliminar"
        Me.eliminarmed.UseVisualStyleBackColor = True
        '
        'modificarmed
        '
        Me.modificarmed.Location = New System.Drawing.Point(521, 78)
        Me.modificarmed.Name = "modificarmed"
        Me.modificarmed.Size = New System.Drawing.Size(112, 25)
        Me.modificarmed.TabIndex = 58
        Me.modificarmed.Text = "Modificar"
        Me.modificarmed.UseVisualStyleBackColor = True
        '
        'registrarmed
        '
        Me.registrarmed.Location = New System.Drawing.Point(521, 49)
        Me.registrarmed.Name = "registrarmed"
        Me.registrarmed.Size = New System.Drawing.Size(112, 23)
        Me.registrarmed.TabIndex = 57
        Me.registrarmed.Text = "Registrar"
        Me.registrarmed.UseVisualStyleBackColor = True
        '
        'txt_folio
        '
        Me.txt_folio.Location = New System.Drawing.Point(490, 12)
        Me.txt_folio.Name = "txt_folio"
        Me.txt_folio.Size = New System.Drawing.Size(143, 20)
        Me.txt_folio.TabIndex = 49
        '
        'cedulamed
        '
        Me.cedulamed.AutoSize = True
        Me.cedulamed.Location = New System.Drawing.Point(15, 170)
        Me.cedulamed.Name = "cedulamed"
        Me.cedulamed.Size = New System.Drawing.Size(40, 13)
        Me.cedulamed.TabIndex = 46
        Me.cedulamed.Text = "Cédula"
        '
        'idmed
        '
        Me.idmed.AutoSize = True
        Me.idmed.Location = New System.Drawing.Point(12, 473)
        Me.idmed.Name = "idmed"
        Me.idmed.Size = New System.Drawing.Size(216, 13)
        Me.idmed.TabIndex = 44
        Me.idmed.Text = "Ingrese el ID del paciente que desea buscar"
        '
        'nommed
        '
        Me.nommed.AutoSize = True
        Me.nommed.Location = New System.Drawing.Point(53, 74)
        Me.nommed.Name = "nommed"
        Me.nommed.Size = New System.Drawing.Size(44, 13)
        Me.nommed.TabIndex = 41
        Me.nommed.Text = "Nombre"
        '
        'txtcedula
        '
        Me.txtcedula.Location = New System.Drawing.Point(61, 167)
        Me.txtcedula.Name = "txtcedula"
        Me.txtcedula.Size = New System.Drawing.Size(170, 20)
        Me.txtcedula.TabIndex = 56
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(14, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 20)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "Datos Paciente"
        '
        'txt_observaciones
        '
        Me.txt_observaciones.Location = New System.Drawing.Point(18, 199)
        Me.txt_observaciones.Name = "txt_observaciones"
        Me.txt_observaciones.Size = New System.Drawing.Size(615, 254)
        Me.txt_observaciones.TabIndex = 70
        Me.txt_observaciones.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(53, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Nombre"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(14, 99)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 20)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "Datos Médico"
        '
        'txtnombrem
        '
        Me.txtnombrem.Location = New System.Drawing.Point(18, 120)
        Me.txtnombrem.Name = "txtnombrem"
        Me.txtnombrem.Size = New System.Drawing.Size(143, 20)
        Me.txtnombrem.TabIndex = 54
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(222, 146)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 13)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "Apellido Paterno"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(380, 146)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 13)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "Apellido Materno"
        '
        'txtapepatm
        '
        Me.txtapepatm.Location = New System.Drawing.Point(196, 123)
        Me.txtapepatm.Name = "txtapepatm"
        Me.txtapepatm.Size = New System.Drawing.Size(143, 20)
        Me.txtapepatm.TabIndex = 55
        Me.txtapepatm.Text = " "
        '
        'txtapematm
        '
        Me.txtapematm.Location = New System.Drawing.Point(351, 123)
        Me.txtapematm.Name = "txtapematm"
        Me.txtapematm.Size = New System.Drawing.Size(143, 20)
        Me.txtapematm.TabIndex = 56
        '
        'txtnombrep
        '
        Me.txtnombrep.Location = New System.Drawing.Point(18, 49)
        Me.txtnombrep.Name = "txtnombrep"
        Me.txtnombrep.Size = New System.Drawing.Size(143, 20)
        Me.txtnombrep.TabIndex = 54
        '
        'matmed
        '
        Me.matmed.AutoSize = True
        Me.matmed.Location = New System.Drawing.Point(380, 73)
        Me.matmed.Name = "matmed"
        Me.matmed.Size = New System.Drawing.Size(86, 13)
        Me.matmed.TabIndex = 42
        Me.matmed.Text = "Apellido Materno"
        '
        'txtapematp
        '
        Me.txtapematp.Location = New System.Drawing.Point(351, 50)
        Me.txtapematp.Name = "txtapematp"
        Me.txtapematp.Size = New System.Drawing.Size(143, 20)
        Me.txtapematp.TabIndex = 56
        '
        'patmed
        '
        Me.patmed.AutoSize = True
        Me.patmed.Location = New System.Drawing.Point(222, 74)
        Me.patmed.Name = "patmed"
        Me.patmed.Size = New System.Drawing.Size(84, 13)
        Me.patmed.TabIndex = 48
        Me.patmed.Text = "Apellido Paterno"
        '
        'txtapepatp
        '
        Me.txtapepatp.Location = New System.Drawing.Point(196, 51)
        Me.txtapepatp.Name = "txtapepatp"
        Me.txtapepatp.Size = New System.Drawing.Size(143, 20)
        Me.txtapepatp.TabIndex = 55
        Me.txtapepatp.Text = " "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(311, 31)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(32, 13)
        Me.Label11.TabIndex = 41
        Me.Label11.Text = "Edad"
        '
        'txtedadp
        '
        Me.txtedadp.Location = New System.Drawing.Point(349, 28)
        Me.txtedadp.Name = "txtedadp"
        Me.txtedadp.Size = New System.Drawing.Size(51, 20)
        Me.txtedadp.TabIndex = 55
        Me.txtedadp.Text = " "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(138, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(18, 13)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "ID"
        '
        'txt_idpaciente
        '
        Me.txt_idpaciente.Location = New System.Drawing.Point(162, 28)
        Me.txt_idpaciente.Name = "txt_idpaciente"
        Me.txt_idpaciente.Size = New System.Drawing.Size(143, 20)
        Me.txt_idpaciente.TabIndex = 55
        Me.txt_idpaciente.Text = " "
        '
        'txt_idmedico
        '
        Me.txt_idmedico.Location = New System.Drawing.Point(163, 99)
        Me.txt_idmedico.Name = "txt_idmedico"
        Me.txt_idmedico.Size = New System.Drawing.Size(143, 20)
        Me.txt_idmedico.TabIndex = 55
        Me.txt_idmedico.Text = " "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(143, 104)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(18, 13)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "ID"
        '
        'confirma_id
        '
        Me.confirma_id.Location = New System.Drawing.Point(18, 5)
        Me.confirma_id.Name = "confirma_id"
        Me.confirma_id.Size = New System.Drawing.Size(103, 23)
        Me.confirma_id.TabIndex = 71
        Me.confirma_id.Text = "CONFIRMA ID"
        Me.confirma_id.UseVisualStyleBackColor = True
        '
        'receta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(645, 503)
        Me.Controls.Add(Me.confirma_id)
        Me.Controls.Add(Me.txt_observaciones)
        Me.Controls.Add(Me.txtBusq)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CB_especialidad)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Consultar)
        Me.Controls.Add(Me.regresa)
        Me.Controls.Add(Me.eliminarmed)
        Me.Controls.Add(Me.modificarmed)
        Me.Controls.Add(Me.registrarmed)
        Me.Controls.Add(Me.txtcedula)
        Me.Controls.Add(Me.txtapematm)
        Me.Controls.Add(Me.txtapematp)
        Me.Controls.Add(Me.txtapepatm)
        Me.Controls.Add(Me.txtnombrem)
        Me.Controls.Add(Me.txtedadp)
        Me.Controls.Add(Me.txt_idmedico)
        Me.Controls.Add(Me.txt_idpaciente)
        Me.Controls.Add(Me.txtapepatp)
        Me.Controls.Add(Me.txtnombrep)
        Me.Controls.Add(Me.txt_folio)
        Me.Controls.Add(Me.cedulamed)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.idmed)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.matmed)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.patmed)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.nommed)
        Me.Name = "receta"
        Me.Text = "receta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtBusq As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CB_especialidad As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Consultar As Button
    Friend WithEvents regresa As Button
    Friend WithEvents eliminarmed As Button
    Friend WithEvents modificarmed As Button
    Friend WithEvents registrarmed As Button
    Friend WithEvents txt_folio As TextBox
    Friend WithEvents cedulamed As Label
    Friend WithEvents idmed As Label
    Friend WithEvents nommed As Label
    Friend WithEvents txtcedula As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_observaciones As RichTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtnombrem As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtapepatm As TextBox
    Friend WithEvents txtapematm As TextBox
    Friend WithEvents txtnombrep As TextBox
    Friend WithEvents matmed As Label
    Friend WithEvents txtapematp As TextBox
    Friend WithEvents patmed As Label
    Friend WithEvents txtapepatp As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtedadp As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_idpaciente As TextBox
    Friend WithEvents txt_idmedico As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents confirma_id As Button
End Class
