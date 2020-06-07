<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuPrincipal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculadoraBásicaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculadoraBásicaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FórmulaGeneralCuadráticaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImpresionesXNúmerosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpresaVentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.DimGray
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem, Me.CalculadoraBásicaToolStripMenuItem, Me.EmpresaVentasToolStripMenuItem, Me.SARToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(1061, 49)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'InicioToolStripMenuItem
        '
        Me.InicioToolStripMenuItem.BackColor = System.Drawing.Color.Gray
        Me.InicioToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.InicioToolStripMenuItem.Font = New System.Drawing.Font("Shrikhand", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InicioToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window
        Me.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        Me.InicioToolStripMenuItem.Size = New System.Drawing.Size(116, 45)
        Me.InicioToolStripMenuItem.Text = "Inicio"
        '
        'CalculadoraBásicaToolStripMenuItem
        '
        Me.CalculadoraBásicaToolStripMenuItem.BackColor = System.Drawing.Color.Gray
        Me.CalculadoraBásicaToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CalculadoraBásicaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculadoraBásicaToolStripMenuItem1, Me.FórmulaGeneralCuadráticaToolStripMenuItem, Me.ImpresionesXNúmerosToolStripMenuItem1})
        Me.CalculadoraBásicaToolStripMenuItem.Font = New System.Drawing.Font("Shrikhand", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalculadoraBásicaToolStripMenuItem.ForeColor = System.Drawing.Color.Gold
        Me.CalculadoraBásicaToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Silver
        Me.CalculadoraBásicaToolStripMenuItem.Name = "CalculadoraBásicaToolStripMenuItem"
        Me.CalculadoraBásicaToolStripMenuItem.Size = New System.Drawing.Size(157, 45)
        Me.CalculadoraBásicaToolStripMenuItem.Text = "Calcular"
        Me.CalculadoraBásicaToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        Me.CalculadoraBásicaToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        '
        'CalculadoraBásicaToolStripMenuItem1
        '
        Me.CalculadoraBásicaToolStripMenuItem1.BackColor = System.Drawing.Color.DarkGray
        Me.CalculadoraBásicaToolStripMenuItem1.Font = New System.Drawing.Font("Shrikhand", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalculadoraBásicaToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.MenuText
        Me.CalculadoraBásicaToolStripMenuItem1.Name = "CalculadoraBásicaToolStripMenuItem1"
        Me.CalculadoraBásicaToolStripMenuItem1.Size = New System.Drawing.Size(402, 34)
        Me.CalculadoraBásicaToolStripMenuItem1.Text = "Calculadora básica"
        '
        'FórmulaGeneralCuadráticaToolStripMenuItem
        '
        Me.FórmulaGeneralCuadráticaToolStripMenuItem.BackColor = System.Drawing.Color.DarkGray
        Me.FórmulaGeneralCuadráticaToolStripMenuItem.Font = New System.Drawing.Font("Shrikhand", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FórmulaGeneralCuadráticaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.MenuText
        Me.FórmulaGeneralCuadráticaToolStripMenuItem.Name = "FórmulaGeneralCuadráticaToolStripMenuItem"
        Me.FórmulaGeneralCuadráticaToolStripMenuItem.Size = New System.Drawing.Size(402, 34)
        Me.FórmulaGeneralCuadráticaToolStripMenuItem.Text = "Fórmula general cuadrática"
        '
        'ImpresionesXNúmerosToolStripMenuItem1
        '
        Me.ImpresionesXNúmerosToolStripMenuItem1.BackColor = System.Drawing.Color.DarkGray
        Me.ImpresionesXNúmerosToolStripMenuItem1.Font = New System.Drawing.Font("Shrikhand", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ImpresionesXNúmerosToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.MenuText
        Me.ImpresionesXNúmerosToolStripMenuItem1.Name = "ImpresionesXNúmerosToolStripMenuItem1"
        Me.ImpresionesXNúmerosToolStripMenuItem1.Size = New System.Drawing.Size(402, 34)
        Me.ImpresionesXNúmerosToolStripMenuItem1.Text = "Impresiones X números"
        '
        'EmpresaVentasToolStripMenuItem
        '
        Me.EmpresaVentasToolStripMenuItem.BackColor = System.Drawing.Color.Gray
        Me.EmpresaVentasToolStripMenuItem.Font = New System.Drawing.Font("Shrikhand", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpresaVentasToolStripMenuItem.ForeColor = System.Drawing.Color.OrangeRed
        Me.EmpresaVentasToolStripMenuItem.Name = "EmpresaVentasToolStripMenuItem"
        Me.EmpresaVentasToolStripMenuItem.Size = New System.Drawing.Size(276, 45)
        Me.EmpresaVentasToolStripMenuItem.Text = "Empresa Ventas"
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.Firebrick
        Me.btnSalir.Font = New System.Drawing.Font("Shrikhand", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(858, 374)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(191, 43)
        Me.btnSalir.TabIndex = 1
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Sigmar One", 28.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Window
        Me.Label1.Location = New System.Drawing.Point(107, 149)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(854, 158)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Bienvenido(a) al menu" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                                             principal"
        '
        'SARToolStripMenuItem
        '
        Me.SARToolStripMenuItem.BackColor = System.Drawing.Color.Gray
        Me.SARToolStripMenuItem.Font = New System.Drawing.Font("Shrikhand", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SARToolStripMenuItem.ForeColor = System.Drawing.Color.MidnightBlue
        Me.SARToolStripMenuItem.Name = "SARToolStripMenuItem"
        Me.SARToolStripMenuItem.Size = New System.Drawing.Size(88, 45)
        Me.SARToolStripMenuItem.Text = "SAR"
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1061, 429)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MenuPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InicioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalculadoraBásicaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalculadoraBásicaToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents FórmulaGeneralCuadráticaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImpresionesXNúmerosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents btnSalir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents EmpresaVentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SARToolStripMenuItem As ToolStripMenuItem
End Class
