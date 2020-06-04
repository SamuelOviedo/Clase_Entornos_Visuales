<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PestañaPago
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
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.chkEstoy = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtViajaA = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtViajaEn = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtNumeroNiños = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtNumeroAdultos = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BienvenidaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreciosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViajesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PagosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.GroupBox6.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.DarkGray
        Me.GroupBox6.Controls.Add(Me.chkEstoy)
        Me.GroupBox6.Controls.Add(Me.Button1)
        Me.GroupBox6.Controls.Add(Me.txtViajaA)
        Me.GroupBox6.Controls.Add(Me.Label13)
        Me.GroupBox6.Controls.Add(Me.Label12)
        Me.GroupBox6.Controls.Add(Me.txtViajaEn)
        Me.GroupBox6.Controls.Add(Me.Label11)
        Me.GroupBox6.Controls.Add(Me.txtNumeroNiños)
        Me.GroupBox6.Controls.Add(Me.Label10)
        Me.GroupBox6.Controls.Add(Me.Label9)
        Me.GroupBox6.Controls.Add(Me.txtNumeroAdultos)
        Me.GroupBox6.Controls.Add(Me.Label8)
        Me.GroupBox6.Controls.Add(Me.txtTotal)
        Me.GroupBox6.Controls.Add(Me.Label7)
        Me.GroupBox6.Font = New System.Drawing.Font("Russo One", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(76, 58)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(345, 588)
        Me.GroupBox6.TabIndex = 12
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Facturación"
        '
        'chkEstoy
        '
        Me.chkEstoy.AutoSize = True
        Me.chkEstoy.Location = New System.Drawing.Point(75, 497)
        Me.chkEstoy.Name = "chkEstoy"
        Me.chkEstoy.Size = New System.Drawing.Size(182, 25)
        Me.chkEstoy.TabIndex = 13
        Me.chkEstoy.Text = "Estoy de acuerdo"
        Me.chkEstoy.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Firebrick
        Me.Button1.Font = New System.Drawing.Font("Shrikhand", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(92, 528)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(157, 41)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Pagar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtViajaA
        '
        Me.txtViajaA.BackColor = System.Drawing.Color.DarkGray
        Me.txtViajaA.Location = New System.Drawing.Point(38, 203)
        Me.txtViajaA.Name = "txtViajaA"
        Me.txtViajaA.Size = New System.Drawing.Size(248, 28)
        Me.txtViajaA.TabIndex = 11
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(118, 170)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(77, 21)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "Sale de:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(107, 280)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(131, 21)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Su destino es:"
        '
        'txtViajaEn
        '
        Me.txtViajaEn.BackColor = System.Drawing.Color.DarkGray
        Me.txtViajaEn.Location = New System.Drawing.Point(38, 316)
        Me.txtViajaEn.Name = "txtViajaEn"
        Me.txtViajaEn.Size = New System.Drawing.Size(248, 28)
        Me.txtViajaEn.TabIndex = 8
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(169, 89)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 21)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "niños."
        '
        'txtNumeroNiños
        '
        Me.txtNumeroNiños.BackColor = System.Drawing.Color.DarkGray
        Me.txtNumeroNiños.Location = New System.Drawing.Point(122, 86)
        Me.txtNumeroNiños.Name = "txtNumeroNiños"
        Me.txtNumeroNiños.Size = New System.Drawing.Size(41, 28)
        Me.txtNumeroNiños.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(88, 86)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(20, 21)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "y"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(169, 46)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 21)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "adultos."
        '
        'txtNumeroAdultos
        '
        Me.txtNumeroAdultos.BackColor = System.Drawing.Color.DarkGray
        Me.txtNumeroAdultos.Location = New System.Drawing.Point(122, 39)
        Me.txtNumeroAdultos.Name = "txtNumeroAdultos"
        Me.txtNumeroAdultos.Size = New System.Drawing.Size(41, 28)
        Me.txtNumeroAdultos.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(71, 46)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 21)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Son:"
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.DarkGray
        Me.txtTotal.Location = New System.Drawing.Point(92, 443)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(210, 28)
        Me.txtTotal.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(56, 407)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 21)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Su total es:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem, Me.PreciosToolStripMenuItem, Me.PagosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(493, 28)
        Me.MenuStrip1.TabIndex = 13
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'InicioToolStripMenuItem
        '
        Me.InicioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BienvenidaToolStripMenuItem})
        Me.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        Me.InicioToolStripMenuItem.Size = New System.Drawing.Size(59, 24)
        Me.InicioToolStripMenuItem.Text = "Inicio"
        '
        'BienvenidaToolStripMenuItem
        '
        Me.BienvenidaToolStripMenuItem.Name = "BienvenidaToolStripMenuItem"
        Me.BienvenidaToolStripMenuItem.Size = New System.Drawing.Size(165, 26)
        Me.BienvenidaToolStripMenuItem.Text = "Bienvenida"
        '
        'PreciosToolStripMenuItem
        '
        Me.PreciosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViajesToolStripMenuItem})
        Me.PreciosToolStripMenuItem.Name = "PreciosToolStripMenuItem"
        Me.PreciosToolStripMenuItem.Size = New System.Drawing.Size(70, 24)
        Me.PreciosToolStripMenuItem.Text = "Precios"
        '
        'ViajesToolStripMenuItem
        '
        Me.ViajesToolStripMenuItem.Name = "ViajesToolStripMenuItem"
        Me.ViajesToolStripMenuItem.Size = New System.Drawing.Size(131, 26)
        Me.ViajesToolStripMenuItem.Text = "Viajes"
        '
        'PagosToolStripMenuItem
        '
        Me.PagosToolStripMenuItem.Name = "PagosToolStripMenuItem"
        Me.PagosToolStripMenuItem.Size = New System.Drawing.Size(62, 24)
        Me.PagosToolStripMenuItem.Text = "Pagos"
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.DarkRed
        Me.btnSalir.Font = New System.Drawing.Font("Shrikhand", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.SystemColors.Window
        Me.btnSalir.Location = New System.Drawing.Point(363, 652)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(118, 45)
        Me.btnSalir.TabIndex = 14
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'PestañaPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.BackgroundImage = Global.Aerolínea.My.Resources.Resources._0d516fdae393c3d30d05eb1251609cc4
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(493, 709)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "PestañaPago"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pago"
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InicioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BienvenidaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PreciosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViajesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button1 As Button
    Friend WithEvents PagosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnSalir As Button
    Friend WithEvents chkEstoy As CheckBox
    Public WithEvents txtViajaA As TextBox
    Public WithEvents txtViajaEn As TextBox
    Public WithEvents txtNumeroNiños As TextBox
    Public WithEvents txtNumeroAdultos As TextBox
    Public WithEvents txtTotal As TextBox
End Class
