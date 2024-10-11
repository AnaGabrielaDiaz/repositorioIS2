Public Class calculos
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim sueldoBase As Decimal = 12500D
        Dim añosTrabajados As Integer
        Dim aumento As Decimal = 0D
        Dim sueldoFinal As Decimal
        Dim inputValido As Boolean
        Dim repetir As Boolean = True

        While repetir
            inputValido = False

            ' Bucle para asegurar que se ingrese un valor correcto
            While Not inputValido
                Dim input As String = InputBox("Ingrese la cantidad de años trabajados en la empresa:")
                If String.IsNullOrWhiteSpace(input) Then
                    If String.IsNullOrWhiteSpace(input) Then
                        ' Usuario presionó Cancelar o no ingresó valor
                        If MessageBox.Show("¿Está seguro que desea cancelar el cálculo?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                            Exit Sub
                        Else
                            MsgBox("Por favor, ingrese un valor numérico.", MsgBoxStyle.Exclamation, "Valor requerido")
                            Continue While
                        End If
                    End If
                End If

                Try
                    añosTrabajados = Convert.ToInt32(input)
                    inputValido = True
                Catch ex As Exception
                    MsgBox("Por favor, ingrese un valor numérico válido para los años trabajados.", MsgBoxStyle.Critical, "Error")
                End Try
            End While

            ' Determinar el aumento según los años trabajados
            If añosTrabajados > 10 Then
                aumento = sueldoBase * 0.1D
            ElseIf añosTrabajados > 5 Then
                aumento = sueldoBase * 0.07D
            ElseIf añosTrabajados > 3 Then
                aumento = sueldoBase * 0.05D
            ElseIf añosTrabajados > 0 Then
                aumento = sueldoBase * 0.03D
            End If

            ' Calcular el sueldo final con el aumento
            sueldoFinal = sueldoBase + aumento
            MsgBox("El sueldo final es: B/. " & sueldoFinal)

            ' Preguntar si el usuario quiere repetir el cálculo
            Dim respuesta As DialogResult = MessageBox.Show("¿Desea realizar otro cálculo?", "Repetir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If respuesta = DialogResult.No Then
                repetir = False
            End If
        End While
    End Sub

    Private Sub btnCalcularCosto_Click(sender As Object, e As EventArgs) Handles btnCalcularCosto.Click
        Dim kilometrosPorDia As Decimal
        Dim costoPorLitro As Decimal
        Dim kilometrosPorLitro As Decimal
        Dim cuotaEstacionamiento As Decimal
        Dim peajePorDia As Decimal
        Dim costoCombustible As Decimal
        Dim costoTotal As Decimal
        Dim inputValido As Boolean
        Dim repetir As Boolean = True

        While repetir
            inputValido = False

            ' Bucle para asegurar que se ingrese un valor correcto para kilometros por día
            While Not inputValido
                Dim input As String = InputBox("Ingrese el total de kilómetros conducidos por día:")
                If String.IsNullOrWhiteSpace(input) Then
                    If MessageBox.Show("¿Está seguro que desea cancelar el cálculo?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        Exit Sub
                    Else
                        MsgBox("Por favor, ingrese un valor numérico.", MsgBoxStyle.Exclamation, "Valor requerido")
                        Continue While
                    End If
                End If

                Try
                    kilometrosPorDia = Convert.ToDecimal(input)
                    inputValido = True
                Catch ex As Exception
                    MsgBox("Por favor, ingrese un valor numérico válido para los kilómetros por día.", MsgBoxStyle.Critical, "Error")
                End Try
            End While

            inputValido = False ' Resetear el indicador para la siguiente entrada
            While Not inputValido
                Dim input As String = InputBox("Ingrese el costo por litro de combustible:")
                If String.IsNullOrWhiteSpace(input) Then
                    If MessageBox.Show("¿Está seguro que desea cancelar el cálculo?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        Exit Sub
                    Else
                        MsgBox("Por favor, ingrese un valor numérico.", MsgBoxStyle.Exclamation, "Valor requerido")
                        Continue While
                    End If
                End If

                Try
                    costoPorLitro = Convert.ToDecimal(input)
                    inputValido = True
                Catch ex As Exception
                    MsgBox("Por favor, ingrese un valor numérico válido para el costo por litro de combustible.", MsgBoxStyle.Critical, "Error")
                End Try
            End While

            inputValido = False ' Resetear el indicador para la siguiente entrada
            While Not inputValido
                Dim input As String = InputBox("Ingrese el promedio de kilómetros por litro:")
                If String.IsNullOrWhiteSpace(input) Then
                    If MessageBox.Show("¿Está seguro que desea cancelar el cálculo?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        Exit Sub
                    Else
                        MsgBox("Por favor, ingrese un valor numérico.", MsgBoxStyle.Exclamation, "Valor requerido")
                        Continue While
                    End If
                End If

                Try
                    kilometrosPorLitro = Convert.ToDecimal(input)
                    inputValido = True
                Catch ex As Exception
                    MsgBox("Por favor, ingrese un valor numérico válido para el promedio de kilómetros por litro.", MsgBoxStyle.Critical, "Error")
                End Try
            End While

            inputValido = False ' Resetear el indicador para la siguiente entrada
            While Not inputValido
                Dim input As String = InputBox("Ingrese la cuota de estacionamiento por día:")
                If String.IsNullOrWhiteSpace(input) Then
                    If MessageBox.Show("¿Está seguro que desea cancelar el cálculo?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        Exit Sub
                    Else
                        MsgBox("Por favor, ingrese un valor numérico.", MsgBoxStyle.Exclamation, "Valor requerido")
                        Continue While
                    End If
                End If

                Try
                    cuotaEstacionamiento = Convert.ToDecimal(input)
                    inputValido = True
                Catch ex As Exception
                    MsgBox("Por favor, ingrese un valor numérico válido para la cuota de estacionamiento por día.", MsgBoxStyle.Critical, "Error")
                End Try
            End While

            inputValido = False ' Resetear el indicador para la siguiente entrada
            While Not inputValido
                Dim input As String = InputBox("Ingrese el peaje por día:")
                If String.IsNullOrWhiteSpace(input) Then
                    If MessageBox.Show("¿Está seguro que desea cancelar el cálculo?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        Exit Sub
                    Else
                        MsgBox("Por favor, ingrese un valor numérico.", MsgBoxStyle.Exclamation, "Valor requerido")
                        Continue While
                    End If
                End If

                Try
                    peajePorDia = Convert.ToDecimal(input)
                    inputValido = True
                Catch ex As Exception
                    MsgBox("Por favor, ingrese un valor numérico válido para el peaje por día.", MsgBoxStyle.Critical, "Error")
                End Try
            End While

            ' Calcular los costos
            costoCombustible = (kilometrosPorDia / kilometrosPorLitro) * costoPorLitro
            costoTotal = costoCombustible + cuotaEstacionamiento + peajePorDia

            MsgBox("El costo diario de conducir es: B/. " & costoTotal)

            ' Preguntar si el usuario quiere repetir el cálculo
            Dim respuesta As DialogResult = MessageBox.Show("¿Desea realizar otro cálculo?", "Repetir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If respuesta = DialogResult.No Then
                repetir = False
            End If
        End While
    End Sub

    Private Sub Atras_Click(sender As Object, e As EventArgs) Handles Atras.Click
        Me.Close()
        Form1.Show()
    End Sub

End Class

