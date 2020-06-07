Public Class Impresiones_x_número
    Dim veces As Integer
    Dim numero As String
    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click

        Dim TotalNum, residuo, pares, impares, positivos, negativos As Integer
        Dim dato, sumaTotal As Double

        Try

            If (Val(txtDatos.Text)) - Int(Val(txtDatos.Text)) = 0 And Val(txtDatos.Text) >= 0 Then
                TotalNum = Val(txtDatos.Text)
                sumaTotal = 0

                For i = 1 To TotalNum Step 1

                    dato = InputBox("Ingrese el valor #" & i, "Ingreso de datos")

                    residuo = dato Mod 2
                    cbbValores.Items.Add(dato)

                    If residuo = 0 Then
                        pares += 1
                    Else
                        impares += 1
                    End If
                    sumaTotal += dato

                    If dato > 0 Then
                        positivos += 1

                    Else
                        negativos += 1
                    End If

                Next
                txtImpares.Text = impares
                txtPares.Text = pares
                txtPositivos.Text = positivos
                txtNegativos.Text = negativos
                txtTotal.Text = sumaTotal
                txtTotalNum.Text = TotalNum
            Else
                MsgBox("Debe ingresar un valor entero positivo", vbExclamation + vbOK, "Advertencia")
                txtDatos.Clear()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
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
        txtTotalNum.Clear()
        cbbValores.Items.Clear()

    End Sub

    Private Sub cbbValores_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbValores.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

        Dim positivos, negativos As Integer

        If numero > 0 Then
            positivos += 1

        End If

        If numero Then
            negativos += 1

        End If

        txtTotalNum.Text = veces
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MenuPrincipal.Show()
        Me.Hide()

    End Sub
End Class