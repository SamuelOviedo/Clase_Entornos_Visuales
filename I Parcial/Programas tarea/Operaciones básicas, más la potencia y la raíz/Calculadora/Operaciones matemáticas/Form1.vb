Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click

        'Inicio
        Dim Valor1 As Integer
        Dim Valor2 As Integer
        Dim suma As Integer
        Dim resta As Integer
        Dim division As String
        Dim multiplicacion As Integer
        Dim potencia As Long
        Dim raiz1 As Double
        Dim raiz2 As Double


        Valor1 = Val(txtValor1.Text)
        Valor2 = Val(txtValor2.Text)

        'Proceso
        If chkSuma.Checked = True Then
            suma = Valor1 + Valor2

            txtSuma.Text = suma

        End If

        If chkResta.Checked = True Then
            resta = Valor1 - Valor2

            txtResta.Text = resta

        End If

        If chkMultiplicacion.Checked = True Then
            multiplicacion = Valor1 * Valor2

            txtMultiplicacion.Text = multiplicacion

        End If

        If chkDivision.Checked = True Then
            If Valor2 = 0 Then
                division = "Math error"
            Else
                division = Valor1 / Valor2
            End If

            txtDivision.Text = division

        End If


        If chkPotencia.Checked = True Then

            potencia = Valor1 ^ Valor2

            txtPotencia.Text = potencia

        End If

        If chkRaiz.Checked = True Then
            raiz1 = Valor1 ^ (1 / 2)
            raiz2 = Valor2 ^ (1 / 2)

            txtRaiz1.Text = raiz1
            txtRaiz2.Text = raiz2

        End If

    End Sub

    Private Sub btnReintentar_Click(sender As Object, e As EventArgs) Handles btnReintentar.Click

        txtValor1.Clear()
        txtValor2.Clear()
        txtSuma.Clear()
        txtResta.Clear()
        txtMultiplicacion.Clear()
        txtDivision.Clear()
        txtPotencia.Clear()
        txtRaiz1.Clear()
        txtRaiz2.Clear()

        chkSuma.Checked = False
        chkResta.Checked = False
        chkMultiplicacion.Checked = False
        chkDivision.Checked = False
        chkPotencia.Checked = False
        chkRaiz.Checked = False

    End Sub

    Private Sub txtSuma_TextChanged(sender As Object, e As EventArgs) Handles txtSuma.TextChanged

    End Sub

    Private Sub chkSuma_CheckedChanged(sender As Object, e As EventArgs) Handles chkSuma.CheckedChanged

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub txtRaiz1_TextChanged(sender As Object, e As EventArgs) Handles txtRaiz1.TextChanged

    End Sub

    Private Sub btnValidar_Click(sender As Object, e As EventArgs) Handles btnValidar.Click

        Dim Valor1 As Int16

        If txtValor1.Text = "" Then
            MsgBox("Ingrese un NÚMERO en 
            la casilla #1", vbExclamation, "Advertencia")

        ElseIf Not IsNumeric(txtValor1.Text) Then
            MsgBox("Ingrese un VALOR NUMÉRICO en 
               la casilla #1", vbExclamation, "Advertencia")
            txtValor1.Text = ""

        ElseIf IsNumeric(Valor1) Then
            Valor1 = Val(txtValor1.Text)

            If Valor1 = 0 Then
                MsgBox("El valor en la casilla #1 es 
              CERO", vbInformation, "Información")

            ElseIf Valor1 > 0 Then
                MsgBox("El valor en la casilla #1 es 
              POSITIVO", vbInformation, "Información")

            ElseIf Valor1 < 0 Then
                MsgBox("El valor en la casilla #1 es 
              NEGATIVO", vbInformation, "Información")

            End If

        End If

        Dim Valor2 As Int16

        If txtValor2.Text = "" Then
            MsgBox("Ingrese un NÚMERO en 
            la casilla #2", vbExclamation, "Advertencia")

        ElseIf Not IsNumeric(txtValor2.Text) Then
            MsgBox("Ingrese un VALOR NUMÉRICO en 
               la casilla #2", vbExclamation, "Advertencia")
            txtValor2.Text = ""

        ElseIf IsNumeric(Valor1) Then
            Valor2 = Val(txtValor2.Text)

            If Valor2 = 0 Then
                MsgBox("El valor en la casilla #2 es 
              CERO", vbInformation, "Información")

            ElseIf Valor2 > 0 Then
                MsgBox("El valor en la casilla #2 es 
              POSITIVO", vbInformation, "Información")

            ElseIf Valor2 < 0 Then
                MsgBox("El valor en la casilla #2 es 
              NEGATIVO", vbInformation, "Información")

            End If

        End If

    End Sub

    Private Sub chkPotencia_CheckedChanged(sender As Object, e As EventArgs) Handles chkPotencia.CheckedChanged

        Dim Pregunta As String

        If chkPotencia.Checked = True Then

            Pregunta = MsgBox("Solo podra ingresar valores menores a 15, 
                 en ambas casillas", vbExclamation + vbYesNo, "Advertencia")

            If Pregunta = vbNo Then

                chkPotencia.Checked = False

                txtValor1.Clear()
                txtValor2.Clear()

            End If

        End If

    End Sub

    Private Sub btnMarcar_Click(sender As Object, e As EventArgs) Handles btnMarcar.Click
        chkSuma.Checked = True
        chkResta.Checked = True
        chkMultiplicacion.Checked = True
        chkDivision.Checked = True
        chkPotencia.Checked = True
        chkRaiz.Checked = True
    End Sub
End Class
