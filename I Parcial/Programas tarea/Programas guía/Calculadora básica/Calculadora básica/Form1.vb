Public Class Form1

    Dim operacion As String
    Dim numeroResultado As Nullable(Of Double) = Nothing
    Dim segundoValor As Nullable(Of Double) = Nothing
    Dim sePresionaOperador As Boolean

    Private Sub btnIgual_Click(sender As Object, e As EventArgs) Handles btnIgual.Click
        EvaluaHaceOperacion()
        operacion = ""
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        EvaluaRestriccionConcatena()
        txtDatos.Text &= "1"

    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        EvaluaRestriccionConcatena()
        txtDatos.Text &= "2"
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        EvaluaRestriccionConcatena()
        txtDatos.Text &= "3"
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        EvaluaRestriccionConcatena()
        txtDatos.Text &= "4"
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        EvaluaRestriccionConcatena()
        txtDatos.Text &= "5"
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        EvaluaRestriccionConcatena()
        txtDatos.Text &= "6"
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        EvaluaRestriccionConcatena()
        txtDatos.Text &= "7"
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        EvaluaRestriccionConcatena()
        txtDatos.Text &= "8"
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        EvaluaRestriccionConcatena()
        txtDatos.Text &= "9"
    End Sub

    Private Sub btnCero_Click(sender As Object, e As EventArgs) Handles btnCero.Click
        EvaluaRestriccionConcatena()
        txtDatos.Text &= "0"
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
    End Sub

    Private Sub btnMenos_Click(sender As Object, e As EventArgs) Handles btnMenos.Click
        EvaluaHaceOperacion()
        operacion = "-"
    End Sub

    Private Sub btnPor_Click(sender As Object, e As EventArgs) Handles btnPor.Click
        EvaluaHaceOperacion()
        operacion = "*"
    End Sub

    Private Sub btnEntre_Click(sender As Object, e As EventArgs) Handles btnEntre.Click
        EvaluaHaceOperacion()
        operacion = "/"
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
    End Sub
End Class
