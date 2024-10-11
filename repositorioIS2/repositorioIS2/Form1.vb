Imports repositorioIS2
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        TicTacToe.Show()
    End Sub

    Private Sub btnCalculos_Click(sender As Object, e As EventArgs) Handles btnCalculos.Click
        Dim calculos As New calculos
        calculos.ShowDialog()
    End Sub

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        Application.Exit()
    End Sub
    'hola
End Class
