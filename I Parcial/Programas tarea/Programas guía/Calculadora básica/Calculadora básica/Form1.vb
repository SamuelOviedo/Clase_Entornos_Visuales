Public Class Form1

    Dim operacion, signo As String
    Dim numeroResultado As Nullable(Of Double) = Nothing
    Dim segundoValor As Nullable(Of Double) = Nothing
    Dim sePresionaOperador As Boolean
    Dim contador As Integer

    Private Sub btnIgual_Click(sender As Object, e As EventArgs) Handles btnIgual.Click
        EvaluaHaceOperacion()
        operacion = ""

        'txtDatos.Text &= " = "
        'txtDatos.Text &= 
        'contador = 0
        'txtHistorial.Text &= txtDatos.Text
        'txtHistorial.Text &= Environment.NewLine
        'txtHistorial.SelectionStart = txtHistorial.Text.Length

    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        EvaluaRestriccionConcatena()
        txtDatos.Text &= "1"

        If contador = 0 Then
            operacion = 1
            contador += 1

        Else
            operacion &= 1
        End If
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        EvaluaRestriccionConcatena()
        txtDatos.Text &= "2"

        If contador = 0 Then
            operacion = 2
            contador += 1

        Else
            operacion &= 2
        End If
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        EvaluaRestriccionConcatena()
        txtDatos.Text &= "3"

        If contador = 0 Then
            operacion = 3
            contador += 1

        Else
            operacion &= 3
        End If
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        EvaluaRestriccionConcatena()
        txtDatos.Text &= "4"

        If contador = 0 Then
            operacion = 4
            contador += 1

        Else
            operacion &= 4
        End If
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        EvaluaRestriccionConcatena()
        txtDatos.Text &= "5"

        If contador = 0 Then
            operacion = 5
            contador += 1

        Else
            operacion &= 5
        End If
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        EvaluaRestriccionConcatena()
        txtDatos.Text &= "6"

        If contador = 0 Then
            operacion = 6
            contador += 1

        Else
            operacion &= 6
        End If
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        EvaluaRestriccionConcatena()
        txtDatos.Text &= "7"

        If contador = 0 Then
            operacion = 7
            contador += 1

        Else
            operacion &= 7
        End If
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        EvaluaRestriccionConcatena()
        txtDatos.Text &= "8"

        If contador = 0 Then
            operacion = 8
            contador += 1

        Else
            operacion &= 8
        End If
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        EvaluaRestriccionConcatena()
        txtDatos.Text &= "9"

        If contador = 0 Then
            operacion = 9
            contador += 1

        Else
            operacion &= 9
        End If
    End Sub

    Private Sub btnCero_Click(sender As Object, e As EventArgs) Handles btnCero.Click
        EvaluaRestriccionConcatena()
        txtDatos.Text &= "0"

        If contador = 0 Then
            operacion = 0
            contador += 1

        Else
            operacion &= 0
        End If
    End Sub

    Private Sub btnPunto_Click(sender As Object, e As EventArgs) Handles btnPunto.Click

        EvaluaRestriccionConcatena()

        If InStr(txtDatos.Text, ".", CompareMethod.Text) = 0 Then

            txtDatos.Text &= "."
        End If

    End Sub

    Public Sub EvaluaHaceOperacion()

        sePresionaOperador = True
        segundoValor = Val(txtDatos.Text)

        If numeroResultado IsNot Nothing Then

            Select Case operacion

                Case "+"
                    numeroResultado += segundoValor

                Case "-"
                    numeroResultado -= segundoValor

                Case "*"
                    numeroResultado *= segundoValor

                Case "/"
                    numeroResultado /= segundoValor

            End Select
            txtDatos.Text = numeroResultado

        End If
        numeroResultado = segundoValor

    End Sub

    Private Sub btnMas_Click(sender As Object, e As EventArgs) Handles btnMas.Click
        EvaluaHaceOperacion()
        operacion = "+"
        signo = "+"
    End Sub

    Private Sub btnMenos_Click(sender As Object, e As EventArgs) Handles btnMenos.Click
        EvaluaHaceOperacion()
        operacion = "-"
        signo = "-"

    End Sub

    Private Sub btnPor_Click(sender As Object, e As EventArgs) Handles btnPor.Click
        EvaluaHaceOperacion()
        operacion = "*"
        signo = "*"
    End Sub

    Private Sub btnEntre_Click(sender As Object, e As EventArgs) Handles btnEntre.Click
        EvaluaHaceOperacion()
        operacion = "/"
        signo = "/"
    End Sub

    Public Sub EvaluaRestriccionConcatena()
        If sePresionaOperador = True Then
            txtDatos.Text = ""
            sePresionaOperador = False

        ElseIf txtDatos.Text = "0" Then
            txtDatos.Text = ""
        End If

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtDatos.Text = "0"
        numeroResultado = Nothing

    End Sub

End Class
