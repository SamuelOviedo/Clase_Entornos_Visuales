Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End

    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click

        Dim pUnitario, cantidad As Integer
        Dim descuento, subtotal, total As Double
        Dim aplicaDescuento As Boolean

        pUnitario = Val(txtPUnitario.Text)
        cantidad = Val(txtCantidad.Text)

        aplicaDescuento = chkDescuento.Checked

        descuento = 0

        subtotal = pUnitario * cantidad

        If aplicaDescuento = True Then
            descuento = subtotal * 0.5
        End If
        total = subtotal - descuento

        txtSubtotal.Text = subtotal
        txtDescuento.Text = descuento
        txtTotal.Text = total
    End Sub
End Class
