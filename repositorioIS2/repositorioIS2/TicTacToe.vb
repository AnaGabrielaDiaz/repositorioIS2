Imports repositorioIS2.Form1
Imports System.Security.Policy
Public Class TicTacToe
    Private boton1 As Boolean = False
    Private boton2 As Boolean = False
    Private boton3 As Boolean = False
    Private boton4 As Boolean = False
    Private boton5 As Boolean = False
    Private boton6 As Boolean = False
    Private boton7 As Boolean = False
    Private boton8 As Boolean = False
    Private boton9 As Boolean = False

    Private turno_de_X As Boolean = True

    Dim contador_usuario As Integer = 0
    Dim contador_maquina As Integer = 0

    ' Registrar Movimiento del Jugador
    Public Sub movimiento_jugador()
        If boton1 AndAlso button1.Text = "" Then
            button1.Text = "X"
        ElseIf boton2 AndAlso button2.Text = "" Then
            button2.Text = "X"
        ElseIf boton3 AndAlso button3.Text = "" Then
            button3.Text = "X"
        ElseIf boton4 AndAlso button4.Text = "" Then
            button4.Text = "X"
        ElseIf boton5 AndAlso button5.Text = "" Then
            button5.Text = "X"
        ElseIf boton6 AndAlso button6.Text = "" Then
            button6.Text = "X"
        ElseIf boton7 AndAlso button7.Text = "" Then
            button7.Text = "X"
        ElseIf boton8 AndAlso button8.Text = "" Then
            button8.Text = "X"
        ElseIf boton9 AndAlso button9.Text = "" Then
            button9.Text = "X"
        Else
            MessageBox.Show(Me, "Movimiento no Disponible," & vbCrLf & "Prueba otra casilla", "Advertencia")
        End If

        turno_de_X = Not turno_de_X
        movimiento_maquina()
    End Sub

    ' Movimiento de la máquina
    Public Sub movimiento_maquina()
        Dim rnd As New Random()
        Dim random As Integer

        While True
            If estado_del_juego() = 2 Then Exit While
            random = rnd.Next(1, 10)

            Select Case random
                Case 1
                    If button1.Text = "" Then
                        button1.Text = "0"
                        Exit While
                    End If
                Case 2
                    If button2.Text = "" Then
                        button2.Text = "0"
                        Exit While
                    End If
                Case 3
                    If button3.Text = "" Then
                        button3.Text = "0"
                        Exit While
                    End If
                Case 4
                    If button4.Text = "" Then
                        button4.Text = "0"
                        Exit While
                    End If
                Case 5
                    If button5.Text = "" Then
                        button5.Text = "0"
                        Exit While
                    End If
                Case 6
                    If button6.Text = "" Then
                        button6.Text = "0"
                        Exit While
                    End If
                Case 7
                    If button7.Text = "" Then
                        button7.Text = "0"
                        Exit While
                    End If
                Case 8
                    If button8.Text = "" Then
                        button8.Text = "0"
                        Exit While
                    End If
                Case 9
                    If button9.Text = "" Then
                        button9.Text = "0"
                        Exit While
                    End If
            End Select
        End While

        turno_de_X = Not turno_de_X
    End Sub

    ' Revisar estado del juego
    Public Function estado_del_juego() As Integer
        ' Usuario ganador
        If (button1.Text = "X" AndAlso button2.Text = "X" AndAlso button3.Text = "X") OrElse
           (button1.Text = "X" AndAlso button4.Text = "X" AndAlso button7.Text = "X") OrElse
           (button1.Text = "X" AndAlso button5.Text = "X" AndAlso button9.Text = "X") OrElse
           (button3.Text = "X" AndAlso button6.Text = "X" AndAlso button9.Text = "X") OrElse
           (button7.Text = "X" AndAlso button8.Text = "X" AndAlso button9.Text = "X") OrElse
           (button4.Text = "X" AndAlso button5.Text = "X" AndAlso button6.Text = "X") OrElse
           (button2.Text = "X" AndAlso button5.Text = "X" AndAlso button8.Text = "X") OrElse
           (button3.Text = "X" AndAlso button5.Text = "X" AndAlso button7.Text = "X") Then
            Return 1
        End If

        ' Máquina ganadora
        If (button1.Text = "0" AndAlso button2.Text = "0" AndAlso button3.Text = "0") OrElse
           (button1.Text = "0" AndAlso button4.Text = "0" AndAlso button7.Text = "0") OrElse
           (button1.Text = "0" AndAlso button5.Text = "0" AndAlso button9.Text = "0") OrElse
           (button3.Text = "0" AndAlso button6.Text = "0" AndAlso button9.Text = "0") OrElse
           (button7.Text = "0" AndAlso button8.Text = "0" AndAlso button9.Text = "0") OrElse
           (button4.Text = "0" AndAlso button5.Text = "0" AndAlso button6.Text = "0") OrElse
           (button2.Text = "0" AndAlso button5.Text = "0" AndAlso button8.Text = "0") OrElse
           (button3.Text = "0" AndAlso button5.Text = "0" AndAlso button7.Text = "0") Then
            Return -1
        End If

        ' Tablero lleno, empate
        If button1.Text <> "" AndAlso button2.Text <> "" AndAlso button3.Text <> "" AndAlso
           button4.Text <> "" AndAlso button5.Text <> "" AndAlso button6.Text <> "" AndAlso
           button7.Text <> "" AndAlso button8.Text <> "" AndAlso button9.Text <> "" Then
            Return 2
        End If

        Return 0
    End Function

    ' Mostrar el estado del juego
    Public Sub display_estado()
        If estado_del_juego() = 1 Then
            MessageBox.Show(Me, "!Has Ganado el juego!", "!Felicidades!")
            limpiar_tablero()
            contador_usuario += 1
            label_contador_usuario.Text = contador_usuario.ToString()
        ElseIf estado_del_juego() = -1 Then
            MessageBox.Show(Me, "Has perdido..." & vbCrLf & "Suerte Para la próxima", "Buen Intento")
            limpiar_tablero()
            contador_maquina += 1
            label_contador_maquina.Text = contador_maquina.ToString()
        ElseIf estado_del_juego() = 2 Then
            MessageBox.Show(Me, "Es un empate, ¡inténtenlo de nuevo!", "Buen Intento")
            limpiar_tablero()
        End If
    End Sub

    Public Sub limpiar_tablero()
        button1.Text = ""
        button2.Text = ""
        button3.Text = ""
        button4.Text = ""
        button5.Text = ""
        button6.Text = ""
        button7.Text = ""
        button8.Text = ""
        button9.Text = ""
        turno_de_X = True
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        boton1 = True
        movimiento_jugador()
        display_estado()
        boton1 = False
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        boton2 = True
        movimiento_jugador()
        display_estado()
        boton2 = False
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        boton3 = True
        movimiento_jugador()
        display_estado()
        boton3 = False
    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles button4.Click
        boton4 = True
        movimiento_jugador()
        display_estado()
        boton4 = False
    End Sub

    Private Sub button5_Click(sender As Object, e As EventArgs) Handles button5.Click
        boton5 = True
        movimiento_jugador()
        display_estado()
        boton5 = False
    End Sub

    Private Sub button6_Click(sender As Object, e As EventArgs) Handles button6.Click
        boton6 = True
        movimiento_jugador()
        display_estado()
        boton6 = False
    End Sub

    Private Sub button7_Click(sender As Object, e As EventArgs) Handles button7.Click
        boton7 = True
        movimiento_jugador()
        display_estado()
        boton7 = False
    End Sub

    Private Sub button8_Click(sender As Object, e As EventArgs) Handles button8.Click
        boton8 = True
        movimiento_jugador()
        display_estado()
        boton8 = False
    End Sub

    Private Sub button9_Click(sender As Object, e As EventArgs) Handles button9.Click
        boton9 = True
        movimiento_jugador()
        display_estado()
        boton9 = False
    End Sub

    Private Sub button_reiniciar_Click(sender As Object, e As EventArgs) Handles button_reiniciar.Click
        limpiar_tablero()
        contador_usuario = 0
        contador_maquina = 0
        label_contador_usuario.Text = "" & contador_usuario
        label_contador_maquina.Text = "" & contador_maquina
        turno_de_X = True
    End Sub

    Private Sub button10_Click(sender As Object, e As EventArgs) Handles button10.Click
        Me.Close()
        Form1.Show()
    End Sub

End Class