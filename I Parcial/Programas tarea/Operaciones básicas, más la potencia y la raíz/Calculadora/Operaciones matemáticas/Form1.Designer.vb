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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtValor1 = New System.Windows.Forms.TextBox()
        Me.txtValor2 = New System.Windows.Forms.TextBox()
        Me.txtSuma = New System.Windows.Forms.TextBox()
        Me.txtResta = New System.Windows.Forms.TextBox()
        Me.txtMultiplicacion = New System.Windows.Forms.TextBox()
        Me.txtDivision = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnReintentar = New System.Windows.Forms.Button()
        Me.chkSuma = New System.Windows.Forms.CheckBox()
        Me.chkResta = New System.Windows.Forms.CheckBox()
        Me.chkMultiplicacion = New System.Windows.Forms.CheckBox()
        Me.chkPotencia = New System.Windows.Forms.CheckBox()
        Me.chkDivision = New System.Windows.Forms.CheckBox()
        Me.chkRaiz = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtPotencia = New System.Windows.Forms.TextBox()
        Me.txtRaiz1 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtRaiz2 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnValidar = New System.Windows.Forms.Button()
        Me.btnMarcar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Coral
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Shrikhand", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(133, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Valor 1:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Coral
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Shrikhand", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(135, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Valor 2:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Russo One", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(121, 218)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 32)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Resultados:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Silver
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Shrikhand", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(47, 273)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 32)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Suma"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Silver
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Shrikhand", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(108, 334)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 32)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Resta"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Silver
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Shrikhand", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(334, 275)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(169, 32)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Multiplicación"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Silver
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Shrikhand", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(428, 336)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 32)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "División"
        '
        'txtValor1
        '
        Me.txtValor1.BackColor = System.Drawing.Color.Linen
        Me.txtValor1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtValor1.Location = New System.Drawing.Point(250, 79)
        Me.txtValor1.Name = "txtValor1"
        Me.txtValor1.Size = New System.Drawing.Size(119, 30)
        Me.txtValor1.TabIndex = 7
        '
        'txtValor2
        '
        Me.txtValor2.BackColor = System.Drawing.Color.Linen
        Me.txtValor2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtValor2.Location = New System.Drawing.Point(250, 147)
        Me.txtValor2.Name = "txtValor2"
        Me.txtValor2.Size = New System.Drawing.Size(119, 30)
        Me.txtValor2.TabIndex = 8
        '
        'txtSuma
        '
        Me.txtSuma.BackColor = System.Drawing.Color.Linen
        Me.txtSuma.Enabled = False
        Me.txtSuma.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtSuma.Location = New System.Drawing.Point(150, 273)
        Me.txtSuma.Name = "txtSuma"
        Me.txtSuma.Size = New System.Drawing.Size(119, 30)
        Me.txtSuma.TabIndex = 10
        '
        'txtResta
        '
        Me.txtResta.BackColor = System.Drawing.Color.Linen
        Me.txtResta.Enabled = False
        Me.txtResta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtResta.Location = New System.Drawing.Point(192, 334)
        Me.txtResta.Name = "txtResta"
        Me.txtResta.Size = New System.Drawing.Size(116, 30)
        Me.txtResta.TabIndex = 11
        '
        'txtMultiplicacion
        '
        Me.txtMultiplicacion.BackColor = System.Drawing.Color.Linen
        Me.txtMultiplicacion.Enabled = False
        Me.txtMultiplicacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtMultiplicacion.Location = New System.Drawing.Point(521, 277)
        Me.txtMultiplicacion.Name = "txtMultiplicacion"
        Me.txtMultiplicacion.Size = New System.Drawing.Size(97, 30)
        Me.txtMultiplicacion.TabIndex = 12
        '
        'txtDivision
        '
        Me.txtDivision.BackColor = System.Drawing.Color.Linen
        Me.txtDivision.Enabled = False
        Me.txtDivision.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtDivision.Location = New System.Drawing.Point(558, 338)
        Me.txtDivision.Name = "txtDivision"
        Me.txtDivision.Size = New System.Drawing.Size(164, 30)
        Me.txtDivision.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Russo One", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(47, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(404, 32)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Ingrese dos valores numéricos"
        '
        'btnCalcular
        '
        Me.btnCalcular.BackColor = System.Drawing.Color.SkyBlue
        Me.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCalcular.Font = New System.Drawing.Font("Shrikhand", 15.0!)
        Me.btnCalcular.Location = New System.Drawing.Point(428, 79)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(170, 60)
        Me.btnCalcular.TabIndex = 17
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.IndianRed
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.Font = New System.Drawing.Font("Shrikhand", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(741, 484)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(125, 51)
        Me.btnSalir.TabIndex = 18
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnReintentar
        '
        Me.btnReintentar.BackColor = System.Drawing.Color.DarkKhaki
        Me.btnReintentar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReintentar.Font = New System.Drawing.Font("Shrikhand", 10.0!)
        Me.btnReintentar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnReintentar.Location = New System.Drawing.Point(442, 147)
        Me.btnReintentar.Name = "btnReintentar"
        Me.btnReintentar.Size = New System.Drawing.Size(146, 38)
        Me.btnReintentar.TabIndex = 19
        Me.btnReintentar.Text = "Limpiar"
        Me.btnReintentar.UseVisualStyleBackColor = False
        '
        'chkSuma
        '
        Me.chkSuma.AutoSize = True
        Me.chkSuma.Font = New System.Drawing.Font("Modern No. 20", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSuma.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.chkSuma.Location = New System.Drawing.Point(652, 79)
        Me.chkSuma.Name = "chkSuma"
        Me.chkSuma.Size = New System.Drawing.Size(70, 24)
        Me.chkSuma.TabIndex = 20
        Me.chkSuma.Text = "Suma"
        Me.chkSuma.UseVisualStyleBackColor = True
        '
        'chkResta
        '
        Me.chkResta.AutoSize = True
        Me.chkResta.Font = New System.Drawing.Font("Modern No. 20", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkResta.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.chkResta.Location = New System.Drawing.Point(652, 115)
        Me.chkResta.Name = "chkResta"
        Me.chkResta.Size = New System.Drawing.Size(69, 24)
        Me.chkResta.TabIndex = 21
        Me.chkResta.Text = "Resta"
        Me.chkResta.UseVisualStyleBackColor = True
        '
        'chkMultiplicacion
        '
        Me.chkMultiplicacion.AutoSize = True
        Me.chkMultiplicacion.Font = New System.Drawing.Font("Modern No. 20", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMultiplicacion.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.chkMultiplicacion.Location = New System.Drawing.Point(682, 161)
        Me.chkMultiplicacion.Name = "chkMultiplicacion"
        Me.chkMultiplicacion.Size = New System.Drawing.Size(132, 24)
        Me.chkMultiplicacion.TabIndex = 22
        Me.chkMultiplicacion.Text = "Multiplicación"
        Me.chkMultiplicacion.UseVisualStyleBackColor = True
        '
        'chkPotencia
        '
        Me.chkPotencia.AutoSize = True
        Me.chkPotencia.Font = New System.Drawing.Font("Modern No. 20", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPotencia.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.chkPotencia.Location = New System.Drawing.Point(703, 205)
        Me.chkPotencia.Name = "chkPotencia"
        Me.chkPotencia.Size = New System.Drawing.Size(91, 24)
        Me.chkPotencia.TabIndex = 23
        Me.chkPotencia.Text = "Potencia"
        Me.chkPotencia.UseVisualStyleBackColor = True
        '
        'chkDivision
        '
        Me.chkDivision.AutoSize = True
        Me.chkDivision.Font = New System.Drawing.Font("Modern No. 20", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDivision.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.chkDivision.Location = New System.Drawing.Point(778, 79)
        Me.chkDivision.Name = "chkDivision"
        Me.chkDivision.Size = New System.Drawing.Size(88, 24)
        Me.chkDivision.TabIndex = 24
        Me.chkDivision.Text = "División"
        Me.chkDivision.UseVisualStyleBackColor = True
        '
        'chkRaiz
        '
        Me.chkRaiz.AutoSize = True
        Me.chkRaiz.Font = New System.Drawing.Font("Modern No. 20", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRaiz.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.chkRaiz.Location = New System.Drawing.Point(778, 115)
        Me.chkRaiz.Name = "chkRaiz"
        Me.chkRaiz.Size = New System.Drawing.Size(63, 24)
        Me.chkRaiz.TabIndex = 25
        Me.chkRaiz.Text = "Raíz"
        Me.chkRaiz.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Silver
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("Shrikhand", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(466, 414)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(107, 32)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Potencia"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Silver
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Font = New System.Drawing.Font("Shrikhand", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(165, 432)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 32)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Raiz"
        '
        'txtPotencia
        '
        Me.txtPotencia.BackColor = System.Drawing.Color.Linen
        Me.txtPotencia.Enabled = False
        Me.txtPotencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtPotencia.Location = New System.Drawing.Point(592, 416)
        Me.txtPotencia.Name = "txtPotencia"
        Me.txtPotencia.Size = New System.Drawing.Size(274, 30)
        Me.txtPotencia.TabIndex = 28
        '
        'txtRaiz1
        '
        Me.txtRaiz1.BackColor = System.Drawing.Color.Linen
        Me.txtRaiz1.Enabled = False
        Me.txtRaiz1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtRaiz1.Location = New System.Drawing.Point(275, 421)
        Me.txtRaiz1.Name = "txtRaiz1"
        Me.txtRaiz1.Size = New System.Drawing.Size(145, 30)
        Me.txtRaiz1.TabIndex = 29
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Font = New System.Drawing.Font("Russo One", 11.0!)
        Me.Label11.Location = New System.Drawing.Point(612, 15)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(270, 48)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Seleccione las operaciones" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "             a realizar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtRaiz2
        '
        Me.txtRaiz2.BackColor = System.Drawing.Color.Linen
        Me.txtRaiz2.Enabled = False
        Me.txtRaiz2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtRaiz2.Location = New System.Drawing.Point(275, 480)
        Me.txtRaiz2.Name = "txtRaiz2"
        Me.txtRaiz2.Size = New System.Drawing.Size(145, 30)
        Me.txtRaiz2.TabIndex = 31
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Silver
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.Font = New System.Drawing.Font("Shrikhand", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(237, 395)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 23)
        Me.Label12.TabIndex = 32
        Me.Label12.Text = "Valor 1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Silver
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.Font = New System.Drawing.Font("Shrikhand", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(237, 454)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(71, 23)
        Me.Label13.TabIndex = 33
        Me.Label13.Text = "Valor 2"
        '
        'btnValidar
        '
        Me.btnValidar.BackColor = System.Drawing.Color.Peru
        Me.btnValidar.Font = New System.Drawing.Font("Shrikhand", 10.0!)
        Me.btnValidar.Location = New System.Drawing.Point(466, 191)
        Me.btnValidar.Name = "btnValidar"
        Me.btnValidar.Size = New System.Drawing.Size(104, 41)
        Me.btnValidar.TabIndex = 34
        Me.btnValidar.Text = "Validar"
        Me.btnValidar.UseVisualStyleBackColor = False
        '
        'btnMarcar
        '
        Me.btnMarcar.BackColor = System.Drawing.Color.MediumPurple
        Me.btnMarcar.Font = New System.Drawing.Font("Shrikhand", 8.0!)
        Me.btnMarcar.Location = New System.Drawing.Point(703, 244)
        Me.btnMarcar.Name = "btnMarcar"
        Me.btnMarcar.Size = New System.Drawing.Size(92, 59)
        Me.btnMarcar.TabIndex = 35
        Me.btnMarcar.Text = "Marcar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " todas"
        Me.btnMarcar.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(894, 547)
        Me.Controls.Add(Me.btnMarcar)
        Me.Controls.Add(Me.btnValidar)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtRaiz2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtRaiz1)
        Me.Controls.Add(Me.txtPotencia)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.chkRaiz)
        Me.Controls.Add(Me.chkDivision)
        Me.Controls.Add(Me.chkPotencia)
        Me.Controls.Add(Me.chkMultiplicacion)
        Me.Controls.Add(Me.chkResta)
        Me.Controls.Add(Me.chkSuma)
        Me.Controls.Add(Me.btnReintentar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtDivision)
        Me.Controls.Add(Me.txtMultiplicacion)
        Me.Controls.Add(Me.txtResta)
        Me.Controls.Add(Me.txtSuma)
        Me.Controls.Add(Me.txtValor2)
        Me.Controls.Add(Me.txtValor1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Calculadora"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtValor1 As TextBox
    Friend WithEvents txtValor2 As TextBox
    Friend WithEvents txtSuma As TextBox
    Friend WithEvents txtResta As TextBox
    Friend WithEvents txtMultiplicacion As TextBox
    Friend WithEvents txtDivision As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnReintentar As Button
    Friend WithEvents chkSuma As CheckBox
    Friend WithEvents chkResta As CheckBox
    Friend WithEvents chkMultiplicacion As CheckBox
    Friend WithEvents chkPotencia As CheckBox
    Friend WithEvents chkDivision As CheckBox
    Friend WithEvents chkRaiz As CheckBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtPotencia As TextBox
    Friend WithEvents txtRaiz1 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtRaiz2 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents btnValidar As Button
    Friend WithEvents btnMarcar As Button
End Class
