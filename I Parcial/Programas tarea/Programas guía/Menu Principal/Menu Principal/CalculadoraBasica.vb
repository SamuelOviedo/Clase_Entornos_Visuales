Public Class CalculadoraBasica

    Dim operacion, signo As String
    Dim numeroResultado As Nullable(Of Double) = Nothing
    Dim segundoValor As Nullable(Of Double) = Nothing
    Dim sePresionaOperador As Boolean
    Dim contador As Integer
    Dim valor1, valor2, total As Double

    Private Sub btnIgual_Click(sender As Object, e As EventArgs) Handles btnIgual.Click
        EvaluaHaceOperacion()
        operacion = ""


        contador = 0
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        EvaluaRestriccionConcatena()
        txtDatos.Text &= "1"

        If contador = 0 Then
            valor1 = "1"
            contador = 1
        Else
            valor2 = "1"

        End If
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        EvaluaRestriccionConcatena()
        txtDatos.Text &= "2"

        If contador = 0 Then
            valor1 = "2"
            contador = 1
        Else
            valor2 = "2"

        End If
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        EvaluaRestriccionConcatena()
        txtDatos.Text &= "3"

        If contador = 0 Then
            valor1 = "3"
            contador = 1
        Else
            valor2 = "3"

        End If
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        EvaluaRestriccionConcatena()
        txtDatos.Text &= "4"

        If contador = 0 Then
            valor1 = "4"
            contador = 1
        Else
            valor2 = "4"

        End If
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        EvaluaRestriccionConcatena()
        txtDatos.Text &= "5"

        If contador = 0 Then
            valor1 = "5"
            contador = 1
        Else
            valor2 = "5"

        End If
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        EvaluaRestriccionConcatena()
        txtDatos.Text &= "6"

        If contador = 0 Then
            valor1 = "6"
            contador = 1
        Else
            valor2 = "6"

        End If
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        EvaluaRestriccionConcatena()
        txtDatos.Text &= "7"

        If contador = 0 Then
            valor1 = "7"
            contador = 1
        Else
            valor2 = "7"

        End If
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        EvaluaRestriccionConcatena()
        txtDatos.Text &= "8"

        If contador = 0 Then
            valor1 = "8"
            contador = 1
        Else
            valor2 = "8"

        End If
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        EvaluaRestriccionConcatena()
        txtDatos.Text &= "9"

        If contador = 0 Then
            valor1 = "9"
            contador = 1
        Else
            valor2 = "9"

        End If
    End Sub

    Private Sub btnCero_Click(sender As Object, e As EventArgs) Handles btnCero.Click
        EvaluaRestriccionConcatena()
        txtDatos.Text &= "0"

        If contador = 0 Then
            valor1 = "0"
            contador = 1
        Else
            valor2 = "0"

        End If
    End Sub

    Private Sub btnPunto_Click(sender As Object, e As EventArgs) Handles btnPunto.Click

        EvaluaRestriccionConcatena()

        If InStr(txtDatos.Text, ".", CompareMethod.Text) = 0 Then

            txtDatos.Text &= "."
        End If

    End Sub

    Public Sub EvaluaHaceOperacion()
        Dim total As Double

        sePresionaOperador = True
        segundoValor = Val(txtDatos.Text)

        If numeroResultado IsNot Nothing Then

            Select Case operacion

                Case "+"
                    total = numeroResultado + segundoValor
                    lbHistorial.Items.Add(numeroResultado & signo & segundoValor & " = " & total)
                Case "-"
                    total = numeroResultado - segundoValor
                    lbHistorial.Items.Add(numeroResultado & signo & segundoValor & " = " & total)

                Case "*"
                    total = numeroResultado * segundoValor
                    lbHistorial.Items.Add(numeroResultado & signo & segundoValor & " = " & total)

                Case "/"
                    total = numeroResultado / segundoValor
                    lbHistorial.Items.Add(numeroResultado & signo & segundoValor & " = " & total)

            End Select
            txtDatos.Text = total

        End If
        numeroResultado = segundoValor

    End Sub

    Private Sub btnMas_Click(sender As Object, e As EventArgs) Handles btnMas.Click
        EvaluaHaceOperacion()
        operacion = "+"
        signo = " + "
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnMenos_Click(sender As Object, e As EventArgs) Handles btnMenos.Click
        EvaluaHaceOperacion()
        operacion = "-"
        signo = " - "

    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btnCero.Click

    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        MenuPrincipal.Show()
        Me.Hide()

    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        txtDatos.Clear()

    End Sub

    Private Sub btnPor_Click(sender As Object, e As EventArgs) Handles btnPor.Click
        EvaluaHaceOperacion()
        operacion = "*"
        signo = " x "
    End Sub

    Private Sub btnEntre_Click(sender As Object, e As EventArgs) Handles btnEntre.Click
        EvaluaHaceOperacion()
        operacion = "/"
        signo = " / "
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

        valor1 = valor1 & valor1

        txtDatos.Text = "0"
        numeroResultado = Nothing

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        lbHistorial.Items.Clear()

    End Sub
End Class