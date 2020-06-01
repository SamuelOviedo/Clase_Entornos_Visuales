Public Class AcumuladorContador
    Private Sub btnSolicitar_Click(sender As Object, e As EventArgs) Handles btnSolicitar.Click

        Try
            Dim precio, total, totalPagar, orden As Integer

            orden = mtbNoOrden.Text

            For i = 1 To orden Step 1
                precio = InputBox("Ingresa el precio del platillo No." & i, "Precio del platillo")
                totalPagar += precio

            Next

            total = totalPagar / orden
            txtTotal.Text = totalPagar
            txtIndividual.Text = total

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub mtbNoOrden_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles mtbNoOrden.MaskInputRejected

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        mtbNoOrden.Clear()
        txtTotal.Clear()
        txtIndividual.Clear()

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End

    End Sub
End Class
