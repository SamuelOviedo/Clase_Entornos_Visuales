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
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.cmbSuma = New System.Windows.Forms.ComboBox()
        Me.cmbResta = New System.Windows.Forms.ComboBox()
        Me.cmbMultiplicacion = New System.Windows.Forms.ComboBox()
        Me.cmbDivision = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnIngresar
        '
        Me.btnIngresar.BackColor = System.Drawing.Color.Aqua
        Me.btnIngresar.Font = New System.Drawing.Font("Shrikhand", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngresar.Location = New System.Drawing.Point(368, 107)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(139, 33)
        Me.btnIngresar.TabIndex = 0
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = False
        '
        'btnCalcular
        '
        Me.btnCalcular.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCalcular.Font = New System.Drawing.Font("Shrikhand", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcular.Location = New System.Drawing.Point(377, 40)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(119, 61)
        Me.btnCalcular.TabIndex = 1
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.Firebrick
        Me.btnSalir.Font = New System.Drawing.Font("Shrikhand", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(387, 464)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(109, 37)
        Me.btnSalir.TabIndex = 2
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Russo One", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Ingrese un valor:"
        '
        'txtValor
        '
        Me.txtValor.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValor.Location = New System.Drawing.Point(128, 75)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(128, 31)
        Me.txtValor.TabIndex = 4
        '
        'cmbSuma
        '
        Me.cmbSuma.Font = New System.Drawing.Font("Rockwell", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSuma.FormattingEnabled = True
        Me.cmbSuma.Location = New System.Drawing.Point(20, 73)
        Me.cmbSuma.Name = "cmbSuma"
        Me.cmbSuma.Size = New System.Drawing.Size(187, 28)
        Me.cmbSuma.TabIndex = 5
        '
        'cmbResta
        '
        Me.cmbResta.Font = New System.Drawing.Font("Rockwell", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbResta.FormattingEnabled = True
        Me.cmbResta.Location = New System.Drawing.Point(252, 73)
        Me.cmbResta.Name = "cmbResta"
        Me.cmbResta.Size = New System.Drawing.Size(187, 28)
        Me.cmbResta.TabIndex = 6
        '
        'cmbMultiplicacion
        '
        Me.cmbMultiplicacion.Font = New System.Drawing.Font("Rockwell", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMultiplicacion.FormattingEnabled = True
        Me.cmbMultiplicacion.Location = New System.Drawing.Point(20, 177)
        Me.cmbMultiplicacion.Name = "cmbMultiplicacion"
        Me.cmbMultiplicacion.Size = New System.Drawing.Size(187, 28)
        Me.cmbMultiplicacion.TabIndex = 7
        '
        'cmbDivision
        '
        Me.cmbDivision.Font = New System.Drawing.Font("Rockwell", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDivision.FormattingEnabled = True
        Me.cmbDivision.Location = New System.Drawing.Point(252, 177)
        Me.cmbDivision.Name = "cmbDivision"
        Me.cmbDivision.Size = New System.Drawing.Size(187, 28)
        Me.cmbDivision.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Russo One", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(72, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 23)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Suma:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Russo One", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(304, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 23)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Resta:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Russo One", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(40, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(149, 23)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Multiplicación:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Russo One", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(304, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 23)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "División:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmbDivision)
        Me.GroupBox1.Controls.Add(Me.cmbMultiplicacion)
        Me.GroupBox1.Controls.Add(Me.cmbResta)
        Me.GroupBox1.Controls.Add(Me.cmbSuma)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 194)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(470, 244)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Resultados"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtValor)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(335, 159)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnLimpiar.Font = New System.Drawing.Font("Shrikhand", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.Location = New System.Drawing.Point(377, 148)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(119, 40)
        Me.btnLimpiar.TabIndex = 15
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 515)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.btnIngresar)
        Me.Name = "Form1"
        Me.Text = "Ventana Emergente"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnIngresar As Button
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtValor As TextBox
    Friend WithEvents cmbSuma As ComboBox
    Friend WithEvents cmbResta As ComboBox
    Friend WithEvents cmbMultiplicacion As ComboBox
    Friend WithEvents cmbDivision As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnLimpiar As Button
End Class
