<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PestañaPrincipal
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PestañaPrincipal))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbLugarSalida = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmbLugarViajar = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnBuscarVuelo = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chkSoloIda = New System.Windows.Forms.CheckBox()
        Me.chkIdayVuelta = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cmbPasajNiños = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbPasajAdult = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.mtbRetorno = New System.Windows.Forms.MaskedTextBox()
        Me.mtbSalida = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.chkPrimeraClase = New System.Windows.Forms.CheckBox()
        Me.chkeconomica = New System.Windows.Forms.CheckBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.ErrorValidacion = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreciosViajesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViajesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PagosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PagarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.ErrorValidacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(275, 26)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(106, 88)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(295, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 88)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.GroupBox1.Controls.Add(Me.cmbLugarSalida)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Font = New System.Drawing.Font("Russo One", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(85, 278)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(420, 143)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Salida"
        '
        'cmbLugarSalida
        '
        Me.cmbLugarSalida.BackColor = System.Drawing.Color.Silver
        Me.cmbLugarSalida.Font = New System.Drawing.Font("Rockwell", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLugarSalida.FormattingEnabled = True
        Me.cmbLugarSalida.Items.AddRange(New Object() {"Tegucigalpa", "San Pedro Sula"})
        Me.cmbLugarSalida.Location = New System.Drawing.Point(68, 80)
        Me.cmbLugarSalida.Name = "cmbLugarSalida"
        Me.cmbLugarSalida.Size = New System.Drawing.Size(170, 28)
        Me.cmbLugarSalida.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Lugar de salida:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.GroupBox2.Controls.Add(Me.cmbLugarViajar)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.PictureBox2)
        Me.GroupBox2.Font = New System.Drawing.Font("Russo One", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(526, 278)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(404, 143)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Llegada"
        '
        'cmbLugarViajar
        '
        Me.cmbLugarViajar.BackColor = System.Drawing.Color.Silver
        Me.cmbLugarViajar.Font = New System.Drawing.Font("Rockwell", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLugarViajar.FormattingEnabled = True
        Me.cmbLugarViajar.Items.AddRange(New Object() {"España", "Costa Rica", "Panamá", "Estados Unidos"})
        Me.cmbLugarViajar.Location = New System.Drawing.Point(57, 80)
        Me.cmbLugarViajar.Name = "cmbLugarViajar"
        Me.cmbLugarViajar.Size = New System.Drawing.Size(170, 28)
        Me.cmbLugarViajar.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(178, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Donde desea viajar:"
        '
        'btnBuscarVuelo
        '
        Me.btnBuscarVuelo.BackColor = System.Drawing.Color.DimGray
        Me.btnBuscarVuelo.Font = New System.Drawing.Font("Shrikhand", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarVuelo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btnBuscarVuelo.Location = New System.Drawing.Point(657, 553)
        Me.btnBuscarVuelo.Name = "btnBuscarVuelo"
        Me.btnBuscarVuelo.Size = New System.Drawing.Size(137, 73)
        Me.btnBuscarVuelo.TabIndex = 4
        Me.btnBuscarVuelo.Text = "Comprar"
        Me.btnBuscarVuelo.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(85, 42)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(845, 135)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.GroupBox3.Controls.Add(Me.chkSoloIda)
        Me.GroupBox3.Controls.Add(Me.chkIdayVuelta)
        Me.GroupBox3.Font = New System.Drawing.Font("Russo One", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(244, 192)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(565, 70)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Vuelos"
        '
        'chkSoloIda
        '
        Me.chkSoloIda.AutoSize = True
        Me.chkSoloIda.Location = New System.Drawing.Point(327, 27)
        Me.chkSoloIda.Name = "chkSoloIda"
        Me.chkSoloIda.Size = New System.Drawing.Size(102, 25)
        Me.chkSoloIda.TabIndex = 1
        Me.chkSoloIda.Text = "Solo ida"
        Me.chkSoloIda.UseVisualStyleBackColor = True
        '
        'chkIdayVuelta
        '
        Me.chkIdayVuelta.AutoSize = True
        Me.chkIdayVuelta.Location = New System.Drawing.Point(102, 27)
        Me.chkIdayVuelta.Name = "chkIdayVuelta"
        Me.chkIdayVuelta.Size = New System.Drawing.Size(134, 25)
        Me.chkIdayVuelta.TabIndex = 0
        Me.chkIdayVuelta.Text = "Ida y vuelta"
        Me.chkIdayVuelta.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.GroupBox4.Controls.Add(Me.cmbPasajNiños)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.cmbPasajAdult)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.mtbRetorno)
        Me.GroupBox4.Controls.Add(Me.mtbSalida)
        Me.GroupBox4.Font = New System.Drawing.Font("Russo One", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(53, 440)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(894, 85)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Datos requeridos"
        '
        'cmbPasajNiños
        '
        Me.cmbPasajNiños.Font = New System.Drawing.Font("Rockwell", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPasajNiños.FormattingEnabled = True
        Me.cmbPasajNiños.Items.AddRange(New Object() {"0", "1", "2", "3"})
        Me.cmbPasajNiños.Location = New System.Drawing.Point(734, 48)
        Me.cmbPasajNiños.Name = "cmbPasajNiños"
        Me.cmbPasajNiños.Size = New System.Drawing.Size(69, 28)
        Me.cmbPasajNiños.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Russo One", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(689, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(153, 21)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Pasajeros niños:"
        '
        'cmbPasajAdult
        '
        Me.cmbPasajAdult.Font = New System.Drawing.Font("Rockwell", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPasajAdult.FormattingEnabled = True
        Me.cmbPasajAdult.Items.AddRange(New Object() {"1", "2", "3"})
        Me.cmbPasajAdult.Location = New System.Drawing.Point(551, 48)
        Me.cmbPasajAdult.Name = "cmbPasajAdult"
        Me.cmbPasajAdult.Size = New System.Drawing.Size(69, 28)
        Me.cmbPasajAdult.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Russo One", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(497, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(171, 21)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Pasajeros adultos:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Russo One", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(237, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 21)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Retorno:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Russo One", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Salida:"
        '
        'mtbRetorno
        '
        Me.mtbRetorno.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtbRetorno.Location = New System.Drawing.Point(327, 30)
        Me.mtbRetorno.Mask = "00/00/0000"
        Me.mtbRetorno.Name = "mtbRetorno"
        Me.mtbRetorno.Size = New System.Drawing.Size(125, 31)
        Me.mtbRetorno.TabIndex = 1
        Me.mtbRetorno.ValidatingType = GetType(Date)
        '
        'mtbSalida
        '
        Me.mtbSalida.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtbSalida.Location = New System.Drawing.Point(100, 30)
        Me.mtbSalida.Mask = "00/00/0000"
        Me.mtbSalida.Name = "mtbSalida"
        Me.mtbSalida.Size = New System.Drawing.Size(131, 31)
        Me.mtbSalida.TabIndex = 0
        Me.mtbSalida.ValidatingType = GetType(Date)
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.GroupBox5.Controls.Add(Me.chkPrimeraClase)
        Me.GroupBox5.Controls.Add(Me.chkeconomica)
        Me.GroupBox5.Font = New System.Drawing.Font("Russo One", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(390, 543)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(234, 100)
        Me.GroupBox5.TabIndex = 9
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Clases"
        '
        'chkPrimeraClase
        '
        Me.chkPrimeraClase.AutoSize = True
        Me.chkPrimeraClase.Location = New System.Drawing.Point(48, 58)
        Me.chkPrimeraClase.Name = "chkPrimeraClase"
        Me.chkPrimeraClase.Size = New System.Drawing.Size(150, 25)
        Me.chkPrimeraClase.TabIndex = 1
        Me.chkPrimeraClase.Text = "Primera clase"
        Me.chkPrimeraClase.UseVisualStyleBackColor = True
        '
        'chkeconomica
        '
        Me.chkeconomica.AutoSize = True
        Me.chkeconomica.Location = New System.Drawing.Point(48, 27)
        Me.chkeconomica.Name = "chkeconomica"
        Me.chkeconomica.Size = New System.Drawing.Size(125, 25)
        Me.chkeconomica.TabIndex = 0
        Me.chkeconomica.Text = "Económica"
        Me.chkeconomica.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.DarkRed
        Me.btnSalir.Font = New System.Drawing.Font("Shrikhand", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btnSalir.Location = New System.Drawing.Point(878, 628)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(118, 45)
        Me.btnSalir.TabIndex = 10
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'ErrorValidacion
        '
        Me.ErrorValidacion.ContainerControl = Me
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem, Me.PreciosViajesToolStripMenuItem, Me.PagosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1033, 28)
        Me.MenuStrip1.TabIndex = 12
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'InicioToolStripMenuItem
        '
        Me.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        Me.InicioToolStripMenuItem.Size = New System.Drawing.Size(59, 24)
        Me.InicioToolStripMenuItem.Text = "Inicio"
        '
        'PreciosViajesToolStripMenuItem
        '
        Me.PreciosViajesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViajesToolStripMenuItem})
        Me.PreciosViajesToolStripMenuItem.Name = "PreciosViajesToolStripMenuItem"
        Me.PreciosViajesToolStripMenuItem.Size = New System.Drawing.Size(70, 24)
        Me.PreciosViajesToolStripMenuItem.Text = "Precios"
        '
        'ViajesToolStripMenuItem
        '
        Me.ViajesToolStripMenuItem.Name = "ViajesToolStripMenuItem"
        Me.ViajesToolStripMenuItem.Size = New System.Drawing.Size(131, 26)
        Me.ViajesToolStripMenuItem.Text = "Viajes"
        '
        'PagosToolStripMenuItem
        '
        Me.PagosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PagarToolStripMenuItem})
        Me.PagosToolStripMenuItem.Name = "PagosToolStripMenuItem"
        Me.PagosToolStripMenuItem.Size = New System.Drawing.Size(62, 24)
        Me.PagosToolStripMenuItem.Text = "Pagos"
        '
        'PagarToolStripMenuItem
        '
        Me.PagarToolStripMenuItem.Name = "PagarToolStripMenuItem"
        Me.PagarToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.PagarToolStripMenuItem.Text = "Pagar"
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.Silver
        Me.txtTotal.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(22, 33)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(132, 31)
        Me.txtTotal.TabIndex = 13
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.Silver
        Me.GroupBox6.Controls.Add(Me.txtTotal)
        Me.GroupBox6.Font = New System.Drawing.Font("Russo One", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(826, 539)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(169, 75)
        Me.GroupBox6.TabIndex = 14
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Total"
        '
        'PestañaPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1033, 685)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.btnBuscarVuelo)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "PestañaPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aerolínea Oviedo's"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.ErrorValidacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnBuscarVuelo As Button
    Friend WithEvents PictureBox3 As PictureBox
    Public WithEvents cmbLugarSalida As ComboBox
    Public WithEvents cmbLugarViajar As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents chkSoloIda As CheckBox
    Friend WithEvents chkIdayVuelta As CheckBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents mtbRetorno As MaskedTextBox
    Friend WithEvents mtbSalida As MaskedTextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents ErrorValidacion As ErrorProvider
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InicioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PreciosViajesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViajesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PagosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PagarToolStripMenuItem As ToolStripMenuItem
    Public WithEvents cmbPasajNiños As ComboBox
    Public WithEvents cmbPasajAdult As ComboBox
    Public WithEvents chkPrimeraClase As CheckBox
    Public WithEvents chkeconomica As CheckBox
    Public WithEvents txtTotal As TextBox
    Friend WithEvents GroupBox6 As GroupBox
End Class
