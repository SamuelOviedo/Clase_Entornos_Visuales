Public Class Form1
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim valor1 As Integer
        Dim valor2 As Integer
        Dim suma As Integer
        Dim resta As Integer
        Dim multiplicacion As Integer
        Dim division As Double

        valor1 = Val(txtValor1.Text)
        valor2 = Val(txtValor2.Text)

        suma = valor1 + valor2
        resta = valor1 - valor2
        multiplicacion = valor1 * valor2
        division = valor1 / valor2

        txtSuma.Text = suma
        txtResta.Text = resta
        txtMultiplicacion.Text = multiplicacion

        If valor2 = 0 Then
            MsgBox("No se puede dividir entre 0")
        ElseIf valor2 > 0 Then
            txtDivision.Text = division
        End If
    End Sub

    Private Sub btnValidar_Click(sender As Object, e As EventArgs) Handles btnValidar.Click
        Dim valor1 As Int16
        Dim valor2 As Int16
        If txtValor1.Text = "" Then
            MsgBox("Escriba un numero en la primer casilla", vbExclamation + vbYes, "Advertencia")
        ElseIf Not IsNumeric(txtValor1.Text) Then
            MsgBox("Ingrese un valor numerico en la primer casilla", vbExclamation + vbYes, "Advertencia")
            txtValor1.Text = ""
        ElseIf IsNumeric(valor1) Then
            valor1 = Val(txtValor1.Text)
            If valor1 = 0 Then
                MsgBox("Numero cero en la primer casilla", vbInformation + vbYes, "Información")
            ElseIf valor1 > 0 Then
                MsgBox("Valor Positivo en la primer casilla", vbInformation + vbYes, "Información")
            ElseIf valor1 < 0 Then
                MsgBox("Valor Negativo en la primer casilla", vbInformation + vbYes, "Información")
            End If
        End If

        If txtValor2.Text = "" Then
            MsgBox("Escriba un numero en la segunda casilla", vbExclamation + vbYes, "Advertencia")
        ElseIf Not IsNumeric(txtValor1.Text) Then
            MsgBox("Ingrese un valor numerico en la segunda casilla", vbExclamation + vbYes, "Advertencia")
            txtValor1.Text = ""
        ElseIf IsNumeric(valor2) Then
            valor2 = Val(txtValor1.Text)
            If valor2 = 0 Then
                MsgBox("Numero cero en la segunda casilla", vbInformation + vbYes, "Información")
            ElseIf valor2 > 0 Then
                MsgBox("Valor Positivo en la segunda casilla", vbInformation + vbYes, "Información")
            ElseIf valor2 < 0 Then
                MsgBox("Valor Negativo en la segunda casilla", vbInformation + vbYes, "Información")
            End If
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtValor2.Clear()
        txtValor1.Clear()
        txtSuma.Clear()
        txtResta.Clear()
        txtMultiplicacion.Clear()
        txtDivision.Clear()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End

    End Sub
End Class
