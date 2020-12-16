Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32
Public Class receta

    Dim conexion As New MySqlConnection
    Dim adaptador As New MySqlDataAdapter
    Dim datos As New DataSet

    Dim comandos As MySqlCommand

    Private Sub receta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub registrarmed_Click(sender As Object, e As EventArgs) Handles registrarmed.Click

        Try
            Dim ENTRADA As String = "INSERT INTO Receta (Receta_id, Paciente_id, Nombre_pac, Apellido_pact, Apellido_pacm, Edad_pac, Medico_id, Nombre_doc, Apellido_doct, Apellido_docm, Cedula_Profesional, Especialidad, Observaciones)
            VALUES('" & Integer.Parse(txt_folio.Text) & "','" & Integer.Parse(txt_idpaciente.Text) & "','" & txtnombrep.Text & "','" & txtapepatp.Text & "','" & txtapematp.Text & "','" & Integer.Parse(txtedadp.Text) & "','" & Integer.Parse(txt_idmedico.Text) & "','" & txtnombrem.Text & "','" & txtapepatm.Text & "','" & txtapematm.Text & "','" & Integer.Parse(txtcedula.Text) & "','" & CB_especialidad.Text & "','" & txt_observaciones.Text & "')"
            Dim ENT As New DataTable
            Dim ADAP As New MySqlDataAdapter(ENTRADA, conexion)

            ADAP.Fill(ENT)
            conexion.Close()

            MsgBox("Datos Ingresados")

            txt_folio.Text = ""
            txt_idpaciente.Text = ""
            txtnombrep.Text = ""
            txtapepatp.Text = ""
            txtapematp.Text = ""
            txtedadp.Text = ""
            txt_idmedico.Text = ""
            txtnombrem.Text = ""
            txtapepatm.Text = ""
            txtapematm.Text = ""
            txtcedula.Text = ""
            CB_especialidad.Text = ""
            txt_observaciones.Text = ""
            txtBusq.Text = ""

        Catch ex As Exception
            MsgBox("No se pueden ingresar datos: " & ex.Message.ToString())
        End Try
    End Sub

    Private Sub modificarmed_Click(sender As Object, e As EventArgs) Handles modificarmed.Click
        Dim actualizar As String
        actualizar = "UPDATE Receta SET Receta_id='" & Integer.Parse(txt_folio.Text) & "', Paciente_id= '" & Integer.Parse(txt_idpaciente.Text) & "', Nombre_pac='" & txtnombrep.Text & "', Apellido_pact='" & txtapepatp.Text & "', Apellido_pacm='" & txtapematp.Text & "', Edad_pac='" & Integer.Parse(txtedadp.Text) & "', Medico_id='" & Integer.Parse(txt_idmedico.Text) & "', Nombre_doc='" & txtnombrem.Text & "', Apellido_doct='" & txtapepatm.Text & "', Apellido_docm='" & txtapematm.Text & "', Cedula_Profesional='" & Integer.Parse(txtcedula.Text) & "', Especialidad='" & CB_especialidad.Text & "', Observaciones= '" & txt_observaciones.Text & "' WHERE Receta_id='" & Integer.Parse(txt_folio.Text) & "'"
        comandos = New MySqlCommand(actualizar, conexion)
        comandos.ExecuteNonQuery()
        MsgBox("Registro actualizado")
    End Sub

    Private Sub eliminarmed_Click(sender As Object, e As EventArgs) Handles eliminarmed.Click
        Dim eliminar As String
        Dim resp As Byte
        resp = MsgBox("¿Desea Eliminiar?", vbYesNo, "Eliminar")
        If resp = 6 Then
            eliminar = "DELETE FROM Receta WHERE Receta_id='" & txtBusq.Text & "'"
            comandos = New MySqlCommand(eliminar, conexion)
            comandos.ExecuteNonQuery()
            MsgBox("Eliminado")
            txt_folio.Clear()
            txt_idpaciente.Clear()
            txtnombrep.Clear()
            txtapepatp.Clear()
            txtapematp.Clear()
            txtedadp.Clear()
            txt_idmedico.Clear()
            txtnombrem.Clear()
            txtapepatm.Clear()
            txtapematm.Clear()
            txtcedula.Clear()
            txt_observaciones.Clear()
            txtBusq.Clear()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Consultar.Click
        Dim lista As Byte
        Dim consulta As String
        If txtBusq.Text <> "" Then
            consulta = "SELECT * FROM Receta WHERE Receta_id='" & txtBusq.Text & "'"
            adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "Receta")
            lista = datos.Tables("Receta").Rows.Count
        End If

        If lista <> 0 Then

            txt_folio.Text = datos.Tables("Receta").Rows(0).Item("Receta_id")
            txt_idpaciente.Text = datos.Tables("Receta").Rows(0).Item("Paciente_id")
            txtnombrep.Text = datos.Tables("Receta").Rows(0).Item("Nombre_pac")
            txtapepatp.Text = datos.Tables("Receta").Rows(0).Item("Apellido_pact")
            txtapematp.Text = datos.Tables("Receta").Rows(0).Item("Apellido_pacm")
            txtedadp.Text = datos.Tables("Receta").Rows(0).Item("Edad_pac")
            txt_idmedico.Text = datos.Tables("Receta").Rows(0).Item("Medico_id")
            txtnombrem.Text = datos.Tables("Receta").Rows(0).Item("Nombre_doc")
            txtapepatm.Text = datos.Tables("Receta").Rows(0).Item("Apellido_doct")
            txtapematm.Text = datos.Tables("Receta").Rows(0).Item("Apellido_docm")
            txtcedula.Text = datos.Tables("Receta").Rows(0).Item("Cedula_Profesional")
            CB_especialidad.Text = datos.Tables("Receta").Rows(0).Item("Especialidad")
            txt_observaciones.Text = datos.Tables("Receta").Rows(0).Item("Observaciones")
        Else
            MsgBox("No se ha encontrado la Receta")
        End If
    End Sub

    Private Sub confirma_id_Click(sender As Object, e As EventArgs) Handles confirma_id.Click
        Dim lista As Byte
        Dim consulta As String
        If txt_idpaciente.Text <> "" Then
            consulta = "SELECT * FROM Paciente WHERE Paciente_id='" & txt_idpaciente.Text & "'"
            adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "Receta")
            lista = datos.Tables("Receta").Rows.Count
        End If

        If lista <> 0 Then
            txt_idpaciente.Text = datos.Tables("Receta").Rows(0).Item("Paciente_id")
            txtnombrep.Text = datos.Tables("Receta").Rows(0).Item("Nombres")
            txtapepatp.Text = datos.Tables("Receta").Rows(0).Item("Apellido_Paterno")
            txtapematp.Text = datos.Tables("Receta").Rows(0).Item("Apellido_Materno")
            txtedadp.Text = datos.Tables("Receta").Rows(0).Item("Edad")
        Else
            MsgBox("No se ha encontrado al paciente")
        End If

        Dim tablon As Byte
        Dim pregunta As String
        If txt_idpaciente.Text <> "" Then
            pregunta = "SELECT * FROM Medico WHERE Doctor_id='" & txt_idmedico.Text & "'"
            adaptador = New MySqlDataAdapter(pregunta, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "Receta")
            tablon = datos.Tables("Receta").Rows.Count
        End If

        If tablon <> 0 Then

            txt_idmedico.Text = datos.Tables("Receta").Rows(0).Item("Doctor_id")
            txtnombrem.Text = datos.Tables("Receta").Rows(0).Item("Nombres")
            txtapepatm.Text = datos.Tables("Receta").Rows(0).Item("Apellido_Paterno")
            txtapematm.Text = datos.Tables("Receta").Rows(0).Item("Apellido_Materno")
            txtcedula.Text = datos.Tables("Receta").Rows(0).Item("Cedula_Profesional")
            CB_especialidad.Text = datos.Tables("Receta").Rows(0).Item("Especialidad")

        Else
            MsgBox("No se ha encontrado al medico")
        End If

    End Sub
End Class