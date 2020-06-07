Public Class MenuPrincipal
    Private Sub CalculadoraBásicaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculadoraBásicaToolStripMenuItem.Click
        CalculadoraBasica.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End

    End Sub

    Private Sub FórmulaGeneralBásicaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FórmulaGeneralBásicaToolStripMenuItem.Click
        FormulaGeneralCuadratica.Show()
        Me.Hide()

    End Sub

    Private Sub ImpresionesXNúmerosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImpresionesXNúmerosToolStripMenuItem.Click
        Impresiones_x_número.Show()
        Me.Hide()

    End Sub
End Class
