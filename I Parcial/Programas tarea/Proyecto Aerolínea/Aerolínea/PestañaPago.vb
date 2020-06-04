Public Class PestañaPago
    Private Sub BienvenidaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BienvenidaToolStripMenuItem.Click
        PestañaPrincipal.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If chkEstoy.Checked = True Then
            txtNumeroAdultos.Text = Module1.numeroAdultos
            txtNumeroNiños.Text = Module1.numeroNiños
            txtViajaA.Text = Module1.ViajaA
            txtViajaEn.Text = Module1.ViajaEn
            txtTotal.Text = Module1.Total

        End If

        MsgBox("Su pago se realizó correctamente,
            ¡Gracias por viajar con Aerolíneas Oviedo´s!", vbInformation, "Felicidades")

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chkEstoy.CheckedChanged

    End Sub
End Class