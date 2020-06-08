Public Class SAR
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End

    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        MenuPrincipal.Show()
        Me.Hide()

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chkDeduccion.CheckedChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click

        Dim sueldo, deduccion As Double

        sueldo = Val(txtSueldo.Text)


        If txtSueldo.Text = "" Then
            MsgBox("Escriba un valor en el sueldo", vbExclamation + vbOK, "Advertencia")

        ElseIf Not IsNumeric(txtSueldo.Text) Then
            MsgBox("Ingrese un valor numerico en el sueldo", vbExclamation + vbOK, "Advertencia")
            txtSueldo.Clear()

        ElseIf txtSueldo.Text < 0 Then
            MsgBox("Ingrese un valor positivo en el sueldo", vbExclamation + vbOK, "Advertencia")
            txtSueldo.Clear()
        End If

        Limpiar()

        If sueldo < 16582.92 Then
            chkExcento.Checked = True
            txtSueldoNeto.Text = 16582.92

        ElseIf (sueldo >= 16528.93 And sueldo <= 23536.61) Then
            chkDeduccion.Checked = True
            deduccion = sueldo * 0.15
            txtSueldoNeto.Text = sueldo - (sueldo * 0.15)
            txtDeduccion.Text = deduccion

        ElseIf (sueldo > 23536.62 And sueldo <= 50317.69) Then
            chkDeduccion.Checked = True
            deduccion = sueldo * 0.2
            txtSueldoNeto.Text = sueldo - (sueldo * 0.2)
            txtDeduccion.Text = deduccion

        ElseIf (sueldo > 50317.69) Then
            chkDeduccion.Checked = True
            deduccion = sueldo * 0.25
            txtSueldoNeto.Text = sueldo - (sueldo * 0.25)
            txtDeduccion.Text = deduccion
        End If

        txtImpResultado.Text = sueldo
    End Sub

    Private Sub txtSueldoNeto_TextChanged(sender As Object, e As EventArgs) Handles txtSueldoNeto.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Limpiar()
        txtSueldo.Clear()

    End Sub

    Private Sub Limpiar()
        chkDeduccion.Checked = False
        chkExcento.Checked = False
        txtSueldoNeto.Clear()
        txtImpResultado.Clear()
        txtDeduccion.Clear()

    End Sub
End Class