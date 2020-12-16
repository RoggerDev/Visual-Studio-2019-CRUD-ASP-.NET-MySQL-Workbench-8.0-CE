Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32

Public Class paciente

    Dim conexion As New MySqlConnection
    Dim adaptador As New MySqlDataAdapter
    Dim datos As New DataSet
    Dim comandos As MySqlCommand

    Private Sub txttelpac_TextChanged(sender As Object, e As EventArgs) Handles txttelefono.TextChanged

    End Sub

    Private Sub paciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            conexion.ConnectionString = "server=localhost; user=root;password=atronachb24/*;database=medica"
            conexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub regresa_Click(sender As Object, e As EventArgs) Handles regresa.Click
        opciones.Show()
        Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub consultar_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim lista As Byte
        Dim consulta As String
        If txtBusq.Text <> "" Then
            consulta = "SELECT * FROM Paciente WHERE Paciente_id='" & txtBusq.Text & "'"
            adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "Paciente")
            lista = datos.Tables("Paciente").Rows.Count
        End If

        If lista <> 0 Then
            txtapemat.Text = datos.Tables("Paciente").Rows(0).Item("Apellido_Materno")
            txtapepat.Text = datos.Tables("Paciente").Rows(0).Item("Apellido_Paterno")
            txtcurp.Text = datos.Tables("Paciente").Rows(0).Item("CURP")
            txtnombre.Text = datos.Tables("Paciente").Rows(0).Item("Nombres")
            txtnns.Text = datos.Tables("Paciente").Rows(0).Item("NNS")
            txtedadpac.Text = datos.Tables("Paciente").Rows(0).Item("Edad")
            txttelefono.Text = datos.Tables("Paciente").Rows(0).Item("Telefono")
            txt_idpaciente.Text = datos.Tables("Paciente").Rows(0).Item("Paciente_id")
            CB_tipo.Text = datos.Tables("Paciente").Rows(0).Item("Tipo_Paciente")
            CB_Genero.Text = datos.Tables("Paciente").Rows(0).Item("Género")
        Else
            MsgBox("No se ha encontrado al Paciente")
        End If
    End Sub

    Private Sub idpaciente_Click(sender As Object, e As EventArgs) Handles idpaciente.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_tipo.SelectedIndexChanged

    End Sub

    Private Sub registrarmed_Click(sender As Object, e As EventArgs) Handles registrarmed.Click
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
        valor2_cmb = CB_tipo.SelectedIndex + 1

        If valor2_cmb = "1" Then
            valor2_string = "Estudiante"
        ElseIf valor2_cmb = "2" Then
            valor2_string = "Profesor"
        ElseIf valor2_cmb = "3" Then
            valor2_string = "Personal de apoyo"
        End If

        Try
            Dim ENTRADA As String = "INSERT INTO Paciente (Paciente_id, Nombres, Apellido_Paterno, Apellido_Materno, Tipo_Paciente, Edad, Telefono, CURP, NNS, Género)
            VALUES('" & Integer.Parse(txt_idpaciente.Text) & "','" & txtnombre.Text & "','" & txtapepat.Text & "','" & txtapemat.Text & "','" & CB_tipo.Text & "','" & txtedadpac.Text & "','" & Integer.Parse(txttelefono.Text) & "','" & txtcurp.Text & "','" & txtnns.Text & "','" & CB_Genero.Text & "')"
            Dim ENT As New DataTable
            Dim ADAP As New MySqlDataAdapter(ENTRADA, conexion)

            ADAP.Fill(ENT)
            conexion.Close()

            MsgBox("Datos Ingresados")

            txtedadpac.Text = ""
            txtapemat.Text = ""
            txtapepat.Text = ""
            txtcurp.Text = ""
            txtnombre.Text = ""
            txtnns.Text = ""
            txttelefono.Text = ""
            txt_idpaciente.Text = ""
            CB_tipo.Text = ""
            CB_Genero.Text = ""

        Catch ex As Exception
            MsgBox("No se pueden ingresar datos: " & ex.Message.ToString())
        End Try
    End Sub

    Private Sub modificarmed_Click(sender As Object, e As EventArgs) Handles modificarmed.Click
        Dim actualizar As String
        actualizar = "UPDATE Paciente SET Paciente_id='" & Integer.Parse(txt_idpaciente.Text) & "',Nombres='" & txtnombre.Text & "', Apellido_Paterno='" & txtapepat.Text & "', Apellido_Materno='" & txtapemat.Text & "', Tipo_Paciente='" & CB_tipo.Text & "', Edad='" & txtedadpac.Text & "', Telefono='" & Integer.Parse(txttelefono.Text) & "', CURP='" & txtcurp.Text & "', NNS='" & txtnns.Text & "', Género='" & CB_Genero.Text & "' WHERE Paciente_id='" & Integer.Parse(txt_idpaciente.Text) & "'"
        comandos = New MySqlCommand(actualizar, conexion)
        comandos.ExecuteNonQuery()
        MsgBox("Registro actualizado")
    End Sub

    Private Sub eliminarmed_Click(sender As Object, e As EventArgs) Handles eliminarmed.Click
        Dim eliminar As String
        Dim resp As Byte
        resp = MsgBox("¿Desea Eliminiar?", vbYesNo, "Eliminar")
        If resp = 6 Then
            eliminar = "DELETE FROM Paciente WHERE Paciente_id='" & txtBusq.Text & "'"
            comandos = New MySqlCommand(eliminar, conexion)
            comandos.ExecuteNonQuery()
            MsgBox("Eliminado")
            txtBusq.Clear()
            txtapemat.Clear()
            txtedadpac.Clear()
            txtapepat.Clear()
            txtcurp.Clear()
            txtnombre.Clear()
            txtnns.Clear()
            txttelefono.Clear()
            txt_idpaciente.Clear()
        End If
    End Sub

    Private Sub txtBusq_TextChanged(sender As Object, e As EventArgs) Handles txtBusq.TextChanged

    End Sub
End Class