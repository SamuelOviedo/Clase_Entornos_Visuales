Imports System.ComponentModel

Public Class FormulaGeneralCuadratica
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click

        Dim variableA, variableB, variableC, discriminante, primerResultado, segundoResultado As Double

        If Not IsNumeric(txtA.Text) Then
            MsgBox("Ingrese un valor numerico en la primer casilla", vbExclamation + vbOK, "Advertencia")
            txtA.Clear()

        End If

        If Not IsNumeric(txtB.Text) Then
            MsgBox("Ingrese un valor numerico en la segunda casilla", vbExclamation + vbOK, "Advertencia")
            txtB.Clear()

        End If

        If Not IsNumeric(txtC.Text) Then
            MsgBox("Ingrese un valor numerico en la tercer casilla", vbExclamation + vbOK, "Advertencia")
            txtC.Clear()

        End If

        variableA = Val(txtA.Text)
        variableB = Val(txtB.Text)
        variableC = Val(txtC.Text)

        discriminante = ((variableB ^ 2) - (4 * (variableA) * (variableC)))

        If discriminante < 0 Then
            MsgBox("Los valores ingresados formulan un resultado con valores imaginarios", vbOK + vbExclamation, "Advertencia")

        Else
            primerResultado = ((-1 * (variableB)) + ((discriminante) ^ (1 / 2))) / (2 * (variableA))
            segundoResultado = ((-1 * (variableB)) - ((discriminante) ^ (1 / 2))) / (2 * (variableA))
            txtResultadoX1.Text = primerResultado
            txtResultadoX2.Text = segundoResultado

        End If


    End Sub

    Private Sub txtA_TextChanged(sender As Object, e As EventArgs) Handles txtA.TextChanged

    End Sub

    Private Sub txtB_TextChanged(sender As Object, e As EventArgs) Handles txtB.TextChanged

    End Sub

    Private Sub txtC_TextChanged(sender As Object, e As EventArgs) Handles txtC.TextChanged

    End Sub

    Private Sub txtA_MouseHover(sender As Object, e As EventArgs) Handles txtA.MouseHover
        ToolTip.SetToolTip(txtA, "Ingrese un valor para (a)")
        ToolTip.ToolTipTitle = "Descripción"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtB_MouseHover(sender As Object, e As EventArgs) Handles txtB.MouseHover
        ToolTip.SetToolTip(txtB, "Ingrese un valor para (b)")
        ToolTip.ToolTipTitle = "Descripción"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtC_MouseHover(sender As Object, e As EventArgs) Handles txtC.MouseHover
        ToolTip.SetToolTip(txtC, "Ingrese un valor para (c)")
        ToolTip.ToolTipTitle = "Descripción"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtA_Validating(sender As Object, e As CancelEventArgs) Handles txtA.Validating

        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "Es un campo obligatorio")
        End If

    End Sub

    Private Sub txtB_Validating(sender As Object, e As CancelEventArgs) Handles txtB.Validating

        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtC_Validating(sender As Object, e As CancelEventArgs) Handles txtC.Validating

        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub btnCasa_Click(sender As Object, e As EventArgs) Handles btnCasa.Click
        MenuPrincipal.Show()
        Me.Hide()

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtA.Clear()
        txtB.Clear()
        txtC.Clear()
        txtResultadoX1.Clear()
        txtResultadoX2.Clear()

    End Sub
End Class