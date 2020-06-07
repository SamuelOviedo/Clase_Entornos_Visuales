Public Class Impresiones_x_número
    Dim veces As Integer
    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click

        Dim numero, contPositivo, contNegativo As Integer

        numero = Val(txtDatos.Text)
        txtDatos.Text = numero
        txtDatos.Clear()
        cbbValores.Items.Add(numero)

        If veces = 0 Then
        ElseIf (numero > 0) Then
            contPositivo += 1

        End If

        txtPositivos.Text = contPositivo
        txtNegativos.Text = contNegativo

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        txtDatos.Clear()
        txtPares.Clear()
        txtImpares.Clear()
        txtPositivos.Clear()
        txtNegativos.Clear()
        txtTotal.Clear()
        cbbValores.Items.Clear()

    End Sub
End Class