Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32

Public Class medico

    Dim conexion As New MySqlConnection
    Dim adaptador As New MySqlDataAdapter
    Dim datos As New DataSet
    Dim comandos As MySqlCommand

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles nommed.Click

    End Sub

    Private Sub regresa_Click(sender As Object, e As EventArgs) Handles regresa.Click
        opciones.Show()
        Close()
    End Sub

    Private Sub medico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conexion.ConnectionString = "server=localhost; user=root;password=atronachb24/*;database=medica"
            conexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub registrar_Click(sender As Object, e As EventArgs) Handles registrarmed.Click
        Dim valor_cmb As Integer
        Dim valor_string As String = ""
        valor_cmb = CB_Genero.SelectedIndex + 1

        If valor_cmb = "1" Then
            valor_string = "Hombre"
        ElseIf valor_cmb = "2" Then
            valor_string = "Mujer"
        End If

        Dim valor2_cmb As Integer
        Dim valor2_string As String = ""
        valor2_cmb = CB_especialidad.SelectedIndex + 1

        If valor2_cmb = "1" Then
            valor2_string = "Estudiante"
        ElseIf valor2_cmb = "2" Then
            valor2_string = "Profesor"
        ElseIf valor2_cmb = "3" Then
            valor2_string = "Personal de apoyo"
        End If

        Try
            Dim ENTRADA As String = "INSERT INTO Medico (Doctor_id, Nombres, Apellido_Paterno, Apellido_Materno, Cedula_Profesional, Especialidad, Telefono, CURP, RFC, Género, Contraseña)
            VALUES('" & Integer.Parse(txt_idmedico.Text) & "','" & txtnombre.Text & "','" & txtapepat.Text & "','" & txtapemat.Text & "','" & Integer.Parse(txtcedula.Text) & "','" & CB_especialidad.Text & "','" & Integer.Parse(txttelefono.Text) & "','" & txtcurp.Text & "','" & txtrfc.Text & "','" & CB_Genero.Text & "','" & txtcontrasena.Text & "')"
            Dim ENT As New DataTable
            Dim ADAP As New MySqlDataAdapter(ENTRADA, conexion)

            ADAP.Fill(ENT)
            conexion.Close()

            MsgBox("Datos Ingresados")

            txt_idmedico.Text = ""
            txtnombre.Text = ""
            txtapepat.Text = ""
            txtapemat.Text = ""
            txtcedula.Text = ""
            txttelefono.Text = ""
            txtcurp.Text = ""
            txtrfc.Text = ""
            txtcontrasena.Text = ""

        Catch ex As Exception
            MsgBox("No se pueden ingresar datos: " & ex.Message.ToString())
        End Try
    End Sub

    Private Sub modificar_Click(sender As Object, e As EventArgs) Handles modificarmed.Click
        Dim actualizar As String
        actualizar = "UPDATE Paciente SET Doctor_id='" & Integer.Parse(txt_idmedico.Text) & "', Nombres='" & txtnombre.Text & "', Apellido_Paterno='" & txtapepat.Text & "', Apellido_Materno='" & txtapemat.Text & "', Cedula_Profesional='" & Integer.Parse(txtcedula.Text) & "', Telefono='" & Integer.Parse(txttelefono.Text) & "', CURP='" & txtcurp.Text & "', RFC='" & txtrfc.Text & "', Contraseña='" & txtcontrasena.Text & "', Género='" & CB_Genero.Text & "', Especialidad='" & CB_especialidad.Text & "' WHERE Doctor_id='" & Integer.Parse(txt_idmedico.Text) & "'"
        comandos = New MySqlCommand(actualizar, conexion)
        comandos.ExecuteNonQuery()
        MsgBox("Registro actualizado")
    End Sub

    Private Sub eliminar_Click(sender As Object, e As EventArgs) Handles eliminarmed.Click
        Dim eliminar As String
        Dim resp As Byte
        resp = MsgBox("¿Desea Eliminiar?", vbYesNo, "Eliminar")
        If resp = 6 Then
            eliminar = "DELETE FROM Medico WHERE Doctor_id='" & txtBusq.Text & "'"
            comandos = New MySqlCommand(eliminar, conexion)
            comandos.ExecuteNonQuery()
            MsgBox("Eliminado")
            txtBusq.Clear()
            txtapemat.Clear()
            txtapepat.Clear()
            txtcedula.Clear()
            txtcontrasena.Clear()
            txtcurp.Clear()
            txtnombre.Clear()
            txtrfc.Clear()
            txttelefono.Clear()
            txt_idmedico.Clear()
        End If
    End Sub

    Private Sub consultar_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim lista As Byte
        Dim consulta As String
        If txtBusq.Text <> "" Then
            consulta = "SELECT * FROM Medico WHERE Doctor_id='" & txtBusq.Text & "'"
            adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "Medico")
            lista = datos.Tables("Medico").Rows.Count
        End If

        If lista <> 0 Then
            txtapemat.Text = datos.Tables("Medico").Rows(0).Item("Apellido_Materno")
            txtapepat.Text = datos.Tables("Medico").Rows(0).Item("Apellido_Paterno")
            txtcedula.Text = datos.Tables("Medico").Rows(0).Item("Cedula_Profesional")
            txtcontrasena.Text = datos.Tables("Medico").Rows(0).Item("Contraseña")
            txtcurp.Text = datos.Tables("Medico").Rows(0).Item("CURP")
            txtnombre.Text = datos.Tables("Medico").Rows(0).Item("Nombres")
            txtrfc.Text = datos.Tables("Medico").Rows(0).Item("RFC")
            txttelefono.Text = datos.Tables("Medico").Rows(0).Item("Telefono")
            txt_idmedico.Text = datos.Tables("Medico").Rows(0).Item("Doctor_id")
            CB_especialidad.Text = datos.Tables("Medico").Rows(0).Item("Especialidad")
            CB_Genero.Text = datos.Tables("Medico").Rows(0).Item("Género")
        Else
            MsgBox("No se ha encontrado al medico")
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_especialidad.SelectedIndexChanged

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Genero.SelectedIndexChanged

    End Sub
End Class