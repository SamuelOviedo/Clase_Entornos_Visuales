Public Class MenuPrincipal

    Private Sub CalculadoraBásicaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CalculadoraBásicaToolStripMenuItem1.Click
        CalculadoraBasica.Show()
        Me.Hide()
    End Sub

    Private Sub FórmulaGeneralCuadráticaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FórmulaGeneralCuadráticaToolStripMenuItem.Click
        FormulaGeneralCuadratica.Show()
        Me.Hide()
    End Sub

    Private Sub ImpresionesXNúmerosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ImpresionesXNúmerosToolStripMenuItem1.Click
        Impresiones_x_número.Show()
        Me.Hide()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End

    End Sub

    Private Sub EmpresaVentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpresaVentasToolStripMenuItem.Click
        Empresa_ventas.Show()
        Me.Hide()

    End Sub

    Private Sub SARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SARToolStripMenuItem.Click
        SAR.Show()
        Me.Hide()

    End Sub
End Class
