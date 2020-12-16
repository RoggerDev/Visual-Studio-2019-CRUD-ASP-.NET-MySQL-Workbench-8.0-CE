Imports MySql.Data.MySqlClient
Public Class Login
    Dim conexion As New MySqlConnection
    Dim adaptador As New MySqlDataAdapter
    Dim datos As New DataSet
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conexion.ConnectionString = "server=localhost; user=root;password=atronachb24/*;database=medica"
            conexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim consulta As String
        Dim lista As Byte
        If TxtUsuario.Text <> "" And TxtContrasena.Text <> "" Then
            consulta = "SELECT * FROM Medico WHERE Doctor_id='" & TxtUsuario.Text & "'and Contraseña='" & TxtContrasena.Text & "'"
            adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "Medico")
            lista = datos.Tables("Medico").Rows.Count
        End If
        If lista <> 0 Then
            MsgBox("Bienvenido")
            opciones.Show()
            Hide()
        Else
            MsgBox("Intentelo de nuevo")
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
