Public Class PestañaPrincipal
    Private Sub btnBuscarVuelo_Click(sender As Object, e As EventArgs) Handles btnBuscarVuelo.Click

        Dim salida, retorno, españa, costaRica, panama, estadosUnidos As Integer
        Dim total As Double

        salida = Val(mtbSalida.Text)
        retorno = Val(mtbRetorno.Text)

        If (retorno < salida) Then
            MsgBox("Debe ingresar una fecha correcta", vbExclamation, "Advertencia")
            mtbRetorno.Clear()

        ElseIf (chkIdayVuelta.Checked = False And chkSoloIda.Checked = False) Then
            MsgBox("Por favor seleccione una opción de Vuelos", vbExclamation, "Advertencia")

        ElseIf (chkPrimeraClase.Checked = False And chkeconomica.Checked = False) Then
            MsgBox("Por favor seleccione una opción de Clases", vbExclamation, "Advertencia")

        ElseIf (cmbLugarSalida.SelectedItem = Nothing) Then
            MsgBox("Por favor seleccione un lugar de salida", vbExclamation, "Advertencia")

        ElseIf (cmbLugarViajar.SelectedItem = Nothing) Then
            MsgBox("Por favor seleccione un destino", vbExclamation, "Advertencia")

        ElseIf (chkIdayVuelta.Checked = True And mtbSalida.MaskCompleted = True And mtbRetorno.MaskCompleted = True) Then
            MsgBox("Por favor ingrese una fecha de salida y retorno", vbExclamation, "Advertencia")

        ElseIf (chkSoloIda.Checked = True And mtbSalida.MaskCompleted = True) Then
            MsgBox("Por favor ingrese una fecha de salida", vbExclamation, "Advertencia")

        ElseIf (cmbPasajAdult.SelectedItem = Nothing) Then
            MsgBox("Por favor ingrese un numero de pasajeros adultos", vbExclamation, "Advertencia")

        ElseIf (cmbPasajNiños.SelectedItem = Nothing) Then
            MsgBox("Por favor ingrese un numero de pasajeros niños", vbExclamation, "Advertencia")
        Else
            MsgBox("Sus boletos han sido facturados correctamente,
                puede continuar con el pago", vbInformation, "Mensaje importante")
        End If


        'salida de total

        'destino = cmbLugarViajar.SelectedItem
        'lugarSalida = cmbLugarSalida.SelectedItem

        españa = 32075
        costaRica = 11125
        panama = 14025
        estadosUnidos = 12875

        'España
        If (chkIdayVuelta.Checked = True) And (cmbLugarSalida.SelectedIndex = 0) And (cmbLugarViajar.SelectedIndex = 0) And (chkPrimeraClase.Checked = True) Then
            total = españa * 1.2
            txtTotal.Text = total
        End If

        If (chkIdayVuelta.Checked = True) And (cmbLugarSalida.SelectedIndex = 1) And (cmbLugarViajar.SelectedIndex = 0) And (chkPrimeraClase.Checked = True) Then
            total = (españa - 1000) * 1.2
            txtTotal.Text = total
        End If

        'economica España
        If (chkIdayVuelta.Checked = True) And (cmbLugarSalida.SelectedIndex = 0) And (cmbLugarViajar.SelectedIndex = 0) And (chkeconomica.Checked = True) Then
            total = españa
            txtTotal.Text = total
        End If

        If (chkIdayVuelta.Checked = True) And (cmbLugarSalida.SelectedIndex = 1) And (cmbLugarViajar.SelectedIndex = 0) And (chkeconomica.Checked = True) Then
            total = (españa - 1000)
            txtTotal.Text = total
        End If

        'CostaRica
        If (chkIdayVuelta.Checked = True) And (cmbLugarSalida.SelectedIndex = 0) And (cmbLugarViajar.SelectedIndex = 1) And (chkPrimeraClase.Checked = True) Then
            total = costaRica * 1.2
            txtTotal.Text = total
        End If

        If (chkIdayVuelta.Checked = True) And (cmbLugarSalida.SelectedIndex = 1) And (cmbLugarViajar.SelectedIndex = 1) Then

        ElseIf (chkPrimeraClase.Checked = True) Then
            total = (costaRica - 1000) * 1.2
            txtTotal.Text = total
        End If

        'costaRica economica
        If (chkIdayVuelta.Checked = True) And (cmbLugarSalida.SelectedIndex = 0) And (cmbLugarViajar.SelectedIndex = 1) And (chkeconomica.Checked = True) Then
            total = costaRica
            txtTotal.Text = total
        End If

        If (chkIdayVuelta.Checked = True) And (cmbLugarSalida.SelectedIndex = 1) And (cmbLugarViajar.SelectedIndex = 1) And (chkPrimeraClase.Checked = True) Then
            total = (costaRica - 1000)
            txtTotal.Text = total
        End If

        'panama
        If (chkIdayVuelta.Checked = True) And (cmbLugarSalida.SelectedIndex = 0) And (cmbLugarViajar.SelectedIndex = 2) And (chkPrimeraClase.Checked = True) Then
            total = panama * 1.2
            txtTotal.Text = total
        End If

        If (chkIdayVuelta.Checked = True) And (cmbLugarSalida.SelectedIndex = 1) And (cmbLugarViajar.SelectedIndex = 2) And (chkPrimeraClase.Checked = True) Then
            total = panama * 1.2
            txtTotal.Text = total
        End If

        'panama economica
        If (chkIdayVuelta.Checked = True) And (cmbLugarSalida.SelectedIndex = 0) And (cmbLugarViajar.SelectedIndex = 2) And (chkeconomica.Checked = True) Then
            total = panama * 1.2
            txtTotal.Text = total
        End If

        If (chkIdayVuelta.Checked = True) And (cmbLugarSalida.SelectedIndex = 1) And (cmbLugarViajar.SelectedIndex = 2) And (chkeconomica.Checked = True) Then
            total = panama * 1.2
            txtTotal.Text = total
        End If

        'estadosUnidos
        If (chkIdayVuelta.Checked = True) And (cmbLugarSalida.SelectedIndex = 0) And (cmbLugarViajar.SelectedIndex = 3) And (chkPrimeraClase.Checked = True) Then
            total = estadosUnidos * 1.2
            txtTotal.Text = total
        End If

        If (chkIdayVuelta.Checked = True) And (cmbLugarSalida.SelectedIndex = 1) And (cmbLugarViajar.SelectedIndex = 3) And (chkPrimeraClase.Checked = True) Then
            total = (estadosUnidos - 1000) * 1.2
            txtTotal.Text = total
        End If

        'estadosUnidos economica
        If (chkIdayVuelta.Checked = True) And (cmbLugarSalida.SelectedIndex = 0) And (cmbLugarViajar.SelectedIndex = 3) And (chkeconomica.Checked = True) Then
            total = estadosUnidos * 1.2
            txtTotal.Text = total
        End If

        If (chkIdayVuelta.Checked = True) And (cmbLugarSalida.SelectedIndex = 1) And (cmbLugarViajar.SelectedIndex = 3) And (chkeconomica.Checked = True) Then
            total = (estadosUnidos - 1000) * 1.2
            txtTotal.Text = total
        End If

        '--------------------------------------------------------------------------------------------------------------------------------
        'España
        If (chkSoloIda.Checked = True) And (cmbLugarSalida.SelectedIndex = 0) And (cmbLugarViajar.SelectedIndex = 0) And (chkPrimeraClase.Checked = True) Then
            total = españa * 1.2
            txtTotal.Text = total
        End If

        If (chkSoloIda.Checked = True) And (cmbLugarSalida.SelectedIndex = 1) And (cmbLugarViajar.SelectedIndex = 0) And (chkPrimeraClase.Checked = True) Then
            total = (españa - 1000) * 1.2
            txtTotal.Text = total
        End If

        'economica España
        If (chkSoloIda.Checked = True) And (cmbLugarSalida.SelectedIndex = 0) And (cmbLugarViajar.SelectedIndex = 0) And (chkeconomica.Checked = True) Then
            total = españa
            txtTotal.Text = total
        End If

        If (chkSoloIda.Checked = True) And (cmbLugarSalida.SelectedIndex = 1) And (cmbLugarViajar.SelectedIndex = 0) And (chkeconomica.Checked = True) Then
            total = (españa - 1000)
            txtTotal.Text = total
        End If

        'CostaRica
        If (chkSoloIda.Checked = True) And (cmbLugarSalida.SelectedIndex = 0) And (cmbLugarViajar.SelectedIndex = 1) And (chkPrimeraClase.Checked = True) Then
            total = costaRica * 1.2
            txtTotal.Text = total
        End If

        If (chkSoloIda.Checked = True) And (cmbLugarSalida.SelectedIndex = 1) And (cmbLugarViajar.SelectedIndex = 1) Then

        ElseIf (chkPrimeraClase.Checked = True) Then
            total = (costaRica - 1000) * 1.2
            txtTotal.Text = total
        End If

        'costaRica economica
        If (chkSoloIda.Checked = True) And (cmbLugarSalida.SelectedIndex = 0) And (cmbLugarViajar.SelectedIndex = 1) And (chkeconomica.Checked = True) Then
            total = costaRica
            txtTotal.Text = total
        End If

        If (chkSoloIda.Checked = True) And (cmbLugarSalida.SelectedIndex = 1) And (cmbLugarViajar.SelectedIndex = 1) And (chkPrimeraClase.Checked = True) Then
            total = (costaRica - 1000)
            txtTotal.Text = total
        End If

        'panama
        If (chkSoloIda.Checked = True) And (cmbLugarSalida.SelectedIndex = 0) And (cmbLugarViajar.SelectedIndex = 2) And (chkPrimeraClase.Checked = True) Then
            total = panama * 1.2
            txtTotal.Text = total
        End If

        If (chkSoloIda.Checked = True) And (cmbLugarSalida.SelectedIndex = 1) And (cmbLugarViajar.SelectedIndex = 2) And (chkPrimeraClase.Checked = True) Then
            total = panama * 1.2
            txtTotal.Text = total
        End If

        'panama economica
        If (chkSoloIda.Checked = True) And (cmbLugarSalida.SelectedIndex = 0) And (cmbLugarViajar.SelectedIndex = 2) And (chkeconomica.Checked = True) Then
            total = panama * 1.2
            txtTotal.Text = total
        End If

        If (chkSoloIda.Checked = True) And (cmbLugarSalida.SelectedIndex = 1) And (cmbLugarViajar.SelectedIndex = 2) And (chkeconomica.Checked = True) Then
            total = panama * 1.2
            txtTotal.Text = total
        End If

        'estadosUnidos
        If (chkSoloIda.Checked = True) And (cmbLugarSalida.SelectedIndex = 0) And (cmbLugarViajar.SelectedIndex = 3) And (chkPrimeraClase.Checked = True) Then
            total = estadosUnidos * 1.2
            txtTotal.Text = total
        End If

        If (chkSoloIda.Checked = True) And (cmbLugarSalida.SelectedIndex = 1) And (cmbLugarViajar.SelectedIndex = 3) And (chkPrimeraClase.Checked = True) Then
            total = (estadosUnidos - 1000) * 1.2
            txtTotal.Text = total
        End If

        'estadosUnidos economica
        If (chkSoloIda.Checked = True) And (cmbLugarSalida.SelectedIndex = 0) And (cmbLugarViajar.SelectedIndex = 3) And (chkeconomica.Checked = True) Then
            total = estadosUnidos * 1.2
            txtTotal.Text = total
        End If

        If (chkSoloIda.Checked = True) And (cmbLugarSalida.SelectedIndex = 1) And (cmbLugarViajar.SelectedIndex = 3) And (chkeconomica.Checked = True) Then
            total = (estadosUnidos - 1000) * 1.2
            txtTotal.Text = total
        End If

    End Sub

    Private Sub chkIdayVuelta_CheckedChanged(sender As Object, e As EventArgs) Handles chkIdayVuelta.CheckedChanged

        If (chkIdayVuelta.Checked = True) Then

            chkSoloIda.Checked = False
            mtbRetorno.Enabled = True

        End If

    End Sub

    Private Sub chkSoloIda_CheckedChanged(sender As Object, e As EventArgs) Handles chkSoloIda.CheckedChanged

        If (chkSoloIda.Checked = True) Then

            chkIdayVuelta.Checked = False
            mtbRetorno.Enabled = False
        End If

    End Sub

    Private Sub chkeconómica_CheckedChanged(sender As Object, e As EventArgs) Handles chkeconomica.CheckedChanged

        If (chkeconomica.Checked = True) Then

            chkPrimeraClase.Checked = False
        End If

    End Sub

    Private Sub MaskedTextBox2_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles mtbRetorno.MaskInputRejected

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End

    End Sub

    Private Sub chkPrimeraClase_CheckedChanged(sender As Object, e As EventArgs) Handles chkPrimeraClase.CheckedChanged

        If (chkPrimeraClase.Checked = True) Then

            chkeconomica.Checked = False
        End If

    End Sub

    Private Sub cmbLugarSalida_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLugarSalida.SelectedIndexChanged

    End Sub

    Private Sub ViajesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViajesToolStripMenuItem.Click
        PreciosViajes.Show()

    End Sub

    Private Sub PagarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PagarToolStripMenuItem.Click

        Module1.numeroAdultos = cmbPasajAdult.SelectedItem
        Module1.numeroNiños = cmbPasajNiños.SelectedItem
        Module1.ViajaA = cmbLugarSalida.SelectedItem
        Module1.ViajaEn = cmbLugarViajar.SelectedItem
        Module1.Total = txtTotal.Text

        PestañaPago.Show()
        Me.Hide()

    End Sub




End Class
