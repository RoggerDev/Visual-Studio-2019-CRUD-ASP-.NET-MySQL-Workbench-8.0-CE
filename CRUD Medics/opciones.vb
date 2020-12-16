Public Class opciones
    Private Sub medico_Click(sender As Object, e As EventArgs) Handles medicos.Click
        medico.Show()
        Close()
    End Sub

    Private Sub opciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub paciente_Click(sender As Object, e As EventArgs) Handles btnpaciente.Click
        paciente.Show()
        Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        receta.Show()
        Close()
    End Sub
End Class