Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        'Inicio
        Dim Valor1 As Integer
        Dim Valor2 As Integer
        Dim suma As Integer
        Dim resta As Integer
        Dim division As Double
        Dim multiplicacion As Integer

        Valor1 = Val(txtValor1.Text)
        Valor2 = Val(txtValor2.Text)

        'Proceso

        suma = Valor1 + Valor2
        txtSuma.Text = suma

        resta = Valor1 - Valor2
        txtResta.Text = resta

        multiplicacion = Valor1 * Valor2
        txtMultiplicacion.Text = multiplicacion

        If Valor2 = 0 Then
            MsgBox("No ha sido posible realizar la división!", vbInformation)
            txtDivision.Clear()
        Else
            division = Valor1 / Valor2
            txtDivision.Text = division
        End If
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtDivision.Clear()
        txtMultiplicacion.Clear()
        txtResta.Clear()
        txtSuma.Clear()
        txtValor1.Clear()
        txtValor2.Clear()
    End Sub

    Private Sub btnValidar_Click(sender As Object, e As EventArgs) Handles btnValidar.Click
        Dim Valor1 As Int16
        If txtValor1.Text = "" Then
            MsgBox("Escriba un numero en la casilla del valor 1", vbYesNo + vbExclamation, "Advertencia")
        ElseIf Not IsNumeric(txtValor1.Text) Then
            MsgBox("Escriba un valor numerico en la casilla del valor 2", vbYesNo + vbExclamation, "Advertencia")
            txtValor1.Text = ""
        ElseIf IsNumeric(Valor1) Then
            Valor1 = Val(txtValor1.Text)
            If Valor1 = 0 Then
                MsgBox("El valor 1 es 0", vbInformation, "Información")
            ElseIf Valor1 > 0 Then
                MsgBox("El valor 1 es positivo", vbInformation, "Información")
            ElseIf Valor1 < 0 Then
                MsgBox("El valor 1 es negativo", vbInformation, "Información")
            End If
        End If

        Dim Valor2 As Int16
        If txtValor2.Text = "" Then
            MsgBox("Escriba un numero en la casilla del valor 2", vbYesNo + vbExclamation, "Advertencia")
        ElseIf Not IsNumeric(txtValor2.Text) Then
            MsgBox("Escriba un valor numerico en la casilla del valor 2", vbAbortRetryIgnore)
            txtValor2.Text = ""
        ElseIf IsNumeric(Valor1) Then
            Valor2 = Val(txtValor2.Text)
            If Valor2 = 0 Then
                MsgBox("El valor 2 numero 0", vbInformation, "Información")
            ElseIf Valor2 > 0 Then
                MsgBox("El valor 2 es positivo", vbInformation, "Información")
            ElseIf Valor2 < 0 Then
                MsgBox("El valor 2 es negativo", vbInformation, "Información")
            End If
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End

    End Sub
End Class
