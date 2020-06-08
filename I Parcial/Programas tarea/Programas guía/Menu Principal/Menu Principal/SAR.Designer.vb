<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SAR
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SAR))
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.chkDeduccion = New System.Windows.Forms.CheckBox()
        Me.chkExcento = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.txtSueldo = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtImpResultado = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtSueldoNeto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDeduccion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.Firebrick
        Me.btnSalir.Font = New System.Drawing.Font("Shrikhand", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(634, 492)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(154, 42)
        Me.btnSalir.TabIndex = 0
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnHome
        '
        Me.btnHome.BackgroundImage = CType(resources.GetObject("btnHome.BackgroundImage"), System.Drawing.Image)
        Me.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnHome.Location = New System.Drawing.Point(708, 12)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(80, 81)
        Me.btnHome.TabIndex = 1
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'chkDeduccion
        '
        Me.chkDeduccion.AutoSize = True
        Me.chkDeduccion.Enabled = False
        Me.chkDeduccion.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.chkDeduccion.FlatAppearance.BorderSize = 5
        Me.chkDeduccion.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.chkDeduccion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.chkDeduccion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.chkDeduccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkDeduccion.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDeduccion.Location = New System.Drawing.Point(50, 51)
        Me.chkDeduccion.Name = "chkDeduccion"
        Me.chkDeduccion.Size = New System.Drawing.Size(134, 28)
        Me.chkDeduccion.TabIndex = 2
        Me.chkDeduccion.Text = "Deducción"
        Me.chkDeduccion.UseVisualStyleBackColor = True
        '
        'chkExcento
        '
        Me.chkExcento.AutoSize = True
        Me.chkExcento.Enabled = False
        Me.chkExcento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkExcento.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkExcento.Location = New System.Drawing.Point(50, 98)
        Me.chkExcento.Name = "chkExcento"
        Me.chkExcento.Size = New System.Drawing.Size(105, 28)
        Me.chkExcento.TabIndex = 3
        Me.chkExcento.Text = "Excento"
        Me.chkExcento.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Silver
        Me.GroupBox1.Controls.Add(Me.chkExcento)
        Me.GroupBox1.Controls.Add(Me.chkDeduccion)
        Me.GroupBox1.Font = New System.Drawing.Font("Shrikhand", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(442, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(238, 182)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Aplica"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Silver
        Me.GroupBox2.Controls.Add(Me.btnCalcular)
        Me.GroupBox2.Controls.Add(Me.txtSueldo)
        Me.GroupBox2.Font = New System.Drawing.Font("Shrikhand", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(25, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(363, 216)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ingresar sueldo"
        '
        'btnCalcular
        '
        Me.btnCalcular.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCalcular.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCalcular.Location = New System.Drawing.Point(131, 115)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(210, 54)
        Me.btnCalcular.TabIndex = 1
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = False
        '
        'txtSueldo
        '
        Me.txtSueldo.Font = New System.Drawing.Font("Rockwell", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSueldo.Location = New System.Drawing.Point(39, 64)
        Me.txtSueldo.Name = "txtSueldo"
        Me.txtSueldo.Size = New System.Drawing.Size(194, 35)
        Me.txtSueldo.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Silver
        Me.GroupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.txtDeduccion)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txtImpResultado)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.txtSueldoNeto)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Font = New System.Drawing.Font("Shrikhand", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(84, 235)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(641, 251)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Resultados"
        '
        'txtImpResultado
        '
        Me.txtImpResultado.Font = New System.Drawing.Font("Rockwell", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImpResultado.Location = New System.Drawing.Point(68, 104)
        Me.txtImpResultado.Name = "txtImpResultado"
        Me.txtImpResultado.Size = New System.Drawing.Size(186, 35)
        Me.txtImpResultado.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Russo One", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 29)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Sueldo:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SkyBlue
        Me.Button1.Font = New System.Drawing.Font("Shrikhand", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(199, 199)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(230, 36)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Limpiar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtSueldoNeto
        '
        Me.txtSueldoNeto.Font = New System.Drawing.Font("Rockwell", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSueldoNeto.Location = New System.Drawing.Point(348, 158)
        Me.txtSueldoNeto.Name = "txtSueldoNeto"
        Me.txtSueldoNeto.Size = New System.Drawing.Size(271, 35)
        Me.txtSueldoNeto.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Russo One", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(273, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sueldo neto:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Russo One", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(253, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(149, 27)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Deduccion:"
        '
        'txtDeduccion
        '
        Me.txtDeduccion.Font = New System.Drawing.Font("Rockwell", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDeduccion.Location = New System.Drawing.Point(348, 68)
        Me.txtDeduccion.Name = "txtDeduccion"
        Me.txtDeduccion.Size = New System.Drawing.Size(271, 35)
        Me.txtDeduccion.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(304, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 35)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "L."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(304, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 35)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "L."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 35)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "L."
        '
        'SAR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 546)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.btnSalir)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SAR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SAR"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSalir As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents chkDeduccion As CheckBox
    Friend WithEvents chkExcento As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents txtSueldo As TextBox
    Friend WithEvents txtSueldoNeto As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents txtImpResultado As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDeduccion As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
End Class
