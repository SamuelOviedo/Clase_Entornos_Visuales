<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtValor1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtValor2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.chkSuma = New System.Windows.Forms.CheckBox()
        Me.chkResta = New System.Windows.Forms.CheckBox()
        Me.chkMultiplicacion = New System.Windows.Forms.CheckBox()
        Me.chkDivision = New System.Windows.Forms.CheckBox()
        Me.chkPotencia = New System.Windows.Forms.CheckBox()
        Me.chkRaiz = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnValidar = New System.Windows.Forms.Button()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Shrikhand", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(282, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingrese dos valores:"
        '
        'txtValor1
        '
        Me.txtValor1.BackColor = System.Drawing.Color.LightGray
        Me.txtValor1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtValor1.Location = New System.Drawing.Point(110, 108)
        Me.txtValor1.Name = "txtValor1"
        Me.txtValor1.Size = New System.Drawing.Size(135, 30)
        Me.txtValor1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.LightGray
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Shrikhand", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(58, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 32)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Valor 1:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.LightGray
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Shrikhand", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(283, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 32)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Valor 2:"
        '
        'txtValor2
        '
        Me.txtValor2.BackColor = System.Drawing.Color.LightGray
        Me.txtValor2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtValor2.Location = New System.Drawing.Point(330, 108)
        Me.txtValor2.Name = "txtValor2"
        Me.txtValor2.Size = New System.Drawing.Size(135, 30)
        Me.txtValor2.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.LightGray
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Shrikhand", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(58, 342)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 37)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Resultado"
        '
        'txtResultado
        '
        Me.txtResultado.BackColor = System.Drawing.Color.LightGray
        Me.txtResultado.Enabled = False
        Me.txtResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtResultado.Location = New System.Drawing.Point(110, 395)
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.Size = New System.Drawing.Size(341, 30)
        Me.txtResultado.TabIndex = 6
        '
        'chkSuma
        '
        Me.chkSuma.AutoSize = True
        Me.chkSuma.Font = New System.Drawing.Font("Russo One", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSuma.Location = New System.Drawing.Point(43, 189)
        Me.chkSuma.Name = "chkSuma"
        Me.chkSuma.Size = New System.Drawing.Size(80, 25)
        Me.chkSuma.TabIndex = 7
        Me.chkSuma.Text = "Suma"
        Me.chkSuma.UseVisualStyleBackColor = True
        '
        'chkResta
        '
        Me.chkResta.AutoSize = True
        Me.chkResta.Font = New System.Drawing.Font("Russo One", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkResta.Location = New System.Drawing.Point(43, 230)
        Me.chkResta.Name = "chkResta"
        Me.chkResta.Size = New System.Drawing.Size(81, 25)
        Me.chkResta.TabIndex = 8
        Me.chkResta.Text = "Resta"
        Me.chkResta.UseVisualStyleBackColor = True
        '
        'chkMultiplicacion
        '
        Me.chkMultiplicacion.AutoSize = True
        Me.chkMultiplicacion.Font = New System.Drawing.Font("Russo One", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMultiplicacion.Location = New System.Drawing.Point(43, 279)
        Me.chkMultiplicacion.Name = "chkMultiplicacion"
        Me.chkMultiplicacion.Size = New System.Drawing.Size(153, 25)
        Me.chkMultiplicacion.TabIndex = 9
        Me.chkMultiplicacion.Text = "Multiplicación"
        Me.chkMultiplicacion.UseVisualStyleBackColor = True
        '
        'chkDivision
        '
        Me.chkDivision.AutoSize = True
        Me.chkDivision.Font = New System.Drawing.Font("Russo One", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDivision.Location = New System.Drawing.Point(383, 185)
        Me.chkDivision.Name = "chkDivision"
        Me.chkDivision.Size = New System.Drawing.Size(101, 25)
        Me.chkDivision.TabIndex = 10
        Me.chkDivision.Text = "División"
        Me.chkDivision.UseVisualStyleBackColor = True
        '
        'chkPotencia
        '
        Me.chkPotencia.AutoSize = True
        Me.chkPotencia.Font = New System.Drawing.Font("Russo One", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPotencia.Location = New System.Drawing.Point(383, 226)
        Me.chkPotencia.Name = "chkPotencia"
        Me.chkPotencia.Size = New System.Drawing.Size(107, 25)
        Me.chkPotencia.TabIndex = 11
        Me.chkPotencia.Text = "Potencia"
        Me.chkPotencia.UseVisualStyleBackColor = True
        '
        'chkRaiz
        '
        Me.chkRaiz.AutoSize = True
        Me.chkRaiz.Font = New System.Drawing.Font("Russo One", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRaiz.Location = New System.Drawing.Point(383, 275)
        Me.chkRaiz.Name = "chkRaiz"
        Me.chkRaiz.Size = New System.Drawing.Size(68, 25)
        Me.chkRaiz.TabIndex = 12
        Me.chkRaiz.Text = "Raíz"
        Me.chkRaiz.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Brown
        Me.Button1.Font = New System.Drawing.Font("Shrikhand", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(202, 469)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(136, 48)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnValidar
        '
        Me.btnValidar.BackColor = System.Drawing.Color.LimeGreen
        Me.btnValidar.Font = New System.Drawing.Font("Shrikhand", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnValidar.Location = New System.Drawing.Point(212, 178)
        Me.btnValidar.Name = "btnValidar"
        Me.btnValidar.Size = New System.Drawing.Size(117, 32)
        Me.btnValidar.TabIndex = 14
        Me.btnValidar.Text = "Validar"
        Me.btnValidar.UseVisualStyleBackColor = False
        '
        'btnCalcular
        '
        Me.btnCalcular.BackColor = System.Drawing.Color.DarkOrange
        Me.btnCalcular.Font = New System.Drawing.Font("Shrikhand", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcular.Location = New System.Drawing.Point(202, 216)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(136, 51)
        Me.btnCalcular.TabIndex = 15
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnLimpiar.Font = New System.Drawing.Font("Shrikhand", 9.0!)
        Me.btnLimpiar.Location = New System.Drawing.Point(224, 273)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(94, 41)
        Me.btnLimpiar.TabIndex = 17
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 546)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.btnValidar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.chkRaiz)
        Me.Controls.Add(Me.chkPotencia)
        Me.Controls.Add(Me.chkDivision)
        Me.Controls.Add(Me.chkMultiplicacion)
        Me.Controls.Add(Me.chkResta)
        Me.Controls.Add(Me.chkSuma)
        Me.Controls.Add(Me.txtResultado)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtValor2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtValor1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Calculadora"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtValor1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtValor2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtResultado As TextBox
    Friend WithEvents chkSuma As CheckBox
    Friend WithEvents chkResta As CheckBox
    Friend WithEvents chkMultiplicacion As CheckBox
    Friend WithEvents chkDivision As CheckBox
    Friend WithEvents chkPotencia As CheckBox
    Friend WithEvents chkRaiz As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btnValidar As Button
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnLimpiar As Button
End Class
