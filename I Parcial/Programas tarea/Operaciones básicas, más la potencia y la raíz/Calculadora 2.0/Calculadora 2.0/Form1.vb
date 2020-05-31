Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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

            txtResultado.Text = suma

        End If

        If chkResta.Checked = True Then
            resta = Valor1 - Valor2

            txtResultado.Text = resta

        End If

        If chkMultiplicacion.Checked = True Then
            multiplicacion = Valor1 * Valor2

            txtResultado.Text = multiplicacion

        End If

        If chkDivision.Checked = True Then
            If Valor2 = 0 Then
                division = "Math error"
            Else
                division = Valor1 / Valor2
            End If

            txtResultado.Text = division

        End If


        If chkPotencia.Checked = True Then

            If Valor1 <= 9 And Valor2 <= 9 Then

                Valor1 = Val(txtValor1.Text)
                Valor2 = Val(txtValor2.Text)

                potencia = Valor1 ^ Valor2

                txtResultado.Text = potencia
            End If

            If Valor1 > 9 Or Valor2 > 9 Then
                MsgBox("No se puede realizar operación potencia 
                    con valores mayores a 9", vbExclamation)
            End If

        End If

        If chkRaiz.Checked = True Then

            raiz1 = Valor1 ^ (1 / 2)
            raiz2 = Valor2 ^ (1 / 2)

            txtResultado.Text = raiz1

            txtResultado.Text = raiz2

        End If

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

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtValor1.Clear()
        txtValor2.Clear()


        chkSuma.Checked = False
        chkResta.Checked = False
        chkMultiplicacion.Checked = False
        chkDivision.Checked = False
        chkPotencia.Checked = False
        chkRaiz.Checked = False

        txtResultado.Clear()

    End Sub

    Private Sub chkSuma_CheckedChanged(sender As Object, e As EventArgs) Handles chkSuma.CheckedChanged

        Dim suma As Integer
        Dim Valor1 As Integer
        Dim Valor2 As Integer

        txtResultado.Clear()
        chkResta.Checked = False
        chkMultiplicacion.Checked = False
        chkDivision.Checked = False
        chkPotencia.Checked = False
        chkRaiz.Checked = False

        Valor1 = Val(txtValor1.Text)
        Valor2 = Val(txtValor2.Text)

        suma = Valor1 + Valor2

        txtResultado.Text = suma

    End Sub

    Private Sub chkResta_CheckedChanged(sender As Object, e As EventArgs) Handles chkResta.CheckedChanged

        Dim resta As Integer
        Dim Valor1 As Integer
        Dim Valor2 As Integer

        txtResultado.Clear()
        chkSuma.Checked = False
        chkMultiplicacion.Checked = False
        chkDivision.Checked = False
        chkPotencia.Checked = False
        chkRaiz.Checked = False

        Valor1 = Val(txtValor1.Text)
        Valor2 = Val(txtValor2.Text)

        resta = Valor1 - Valor2

        txtResultado.Text = resta

    End Sub

    Private Sub chkMultiplicacion_CheckedChanged(sender As Object, e As EventArgs) Handles chkMultiplicacion.CheckedChanged

        Dim multiplicacion As Integer
        Dim Valor1 As Integer
        Dim Valor2 As Integer

        txtResultado.Clear()
        chkSuma.Checked = False
        chkResta.Checked = False
        chkDivision.Checked = False
        chkPotencia.Checked = False
        chkRaiz.Checked = False

        Valor1 = Val(txtValor1.Text)
        Valor2 = Val(txtValor2.Text)

        multiplicacion = Valor1 * Valor2

        txtResultado.Text = multiplicacion

    End Sub

    Private Sub chkDivision_CheckedChanged(sender As Object, e As EventArgs) Handles chkDivision.CheckedChanged

        Dim division As Double
        Dim Valor1 As Integer
        Dim Valor2 As Integer

        txtResultado.Clear()
        chkSuma.Checked = False
        chkResta.Checked = False
        chkMultiplicacion.Checked = False
        chkPotencia.Checked = False
        chkRaiz.Checked = False

        Valor1 = Val(txtValor1.Text)
        Valor2 = Val(txtValor2.Text)

        division = Valor1 / Valor2

        txtResultado.Text = division

    End Sub

    Private Sub chkPotencia_CheckedChanged(sender As Object, e As EventArgs) Handles chkPotencia.CheckedChanged

        Dim potencia As Integer
        Dim Valor1 As Integer
        Dim Valor2 As Integer

        txtResultado.Clear()
        chkSuma.Checked = False
        chkResta.Checked = False
        chkMultiplicacion.Checked = False
        chkDivision.Checked = False
        chkRaiz.Checked = False

        If Valor1 <= 9 Or Valor2 <= 9 Then

            Valor1 = Val(txtValor1.Text)
            Valor2 = Val(txtValor2.Text)

            potencia = Valor1 ^ Valor2

            txtResultado.Text = potencia
        End If

        If Valor1 > 9 And Valor2 > 9 Then
            MsgBox("No se puede realizar operación potencia 
                    con valores mayores a 9", vbExclamation)
        End If


    End Sub

    Private Sub chkRaiz_CheckedChanged(sender As Object, e As EventArgs) Handles chkRaiz.CheckedChanged

        Dim raiz As Double
        Dim Valor1 As Integer
        Dim Valor2 As Integer

        txtResultado.Clear()
        chkSuma.Checked = False
        chkResta.Checked = False
        chkMultiplicacion.Checked = False
        chkDivision.Checked = False
        chkPotencia.Checked = False

        Valor1 = Val(txtValor1.Text)
        Valor2 = Val(txtValor2.Text)

        raiz = Valor1 ^ (1 / 2)

        txtResultado.Text = raiz

    End Sub
End Class
