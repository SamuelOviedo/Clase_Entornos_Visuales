Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click

        Dim num As Integer
        Dim mult As Integer

        num = Val(txtNumero.Text)

        'Proceso

        For i = 1 To 12 Step 1
            mult = num * i

            'Salida de información
            cboTabla.Items.Add(num & " * " & i & " = " & mult)
        Next

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        cboTabla.Items.Clear()
        txtNumero.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End

    End Sub
End Class
