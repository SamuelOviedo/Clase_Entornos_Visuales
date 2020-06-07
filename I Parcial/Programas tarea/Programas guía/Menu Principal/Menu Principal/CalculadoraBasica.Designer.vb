<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalculadoraBasica
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CalculadoraBasica))
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btnCero = New System.Windows.Forms.Button()
        Me.btnPunto = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btnIgual = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnEntre = New System.Windows.Forms.Button()
        Me.btnPor = New System.Windows.Forms.Button()
        Me.btnMenos = New System.Windows.Forms.Button()
        Me.btnMas = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.lbHistorial = New System.Windows.Forms.ListBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.txtDatos = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn7
        '
        Me.btn7.BackColor = System.Drawing.Color.Silver
        Me.btn7.Font = New System.Drawing.Font("Russo One", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn7.Location = New System.Drawing.Point(15, 125)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(82, 80)
        Me.btn7.TabIndex = 0
        Me.btn7.Text = "7"
        Me.btn7.UseVisualStyleBackColor = False
        '
        'btn4
        '
        Me.btn4.BackColor = System.Drawing.Color.Silver
        Me.btn4.Font = New System.Drawing.Font("Russo One", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn4.Location = New System.Drawing.Point(15, 228)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(82, 80)
        Me.btn4.TabIndex = 1
        Me.btn4.Text = "4"
        Me.btn4.UseVisualStyleBackColor = False
        '
        'btn1
        '
        Me.btn1.BackColor = System.Drawing.Color.Silver
        Me.btn1.Font = New System.Drawing.Font("Russo One", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1.Location = New System.Drawing.Point(15, 331)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(82, 80)
        Me.btn1.TabIndex = 2
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = False
        '
        'btnCero
        '
        Me.btnCero.BackColor = System.Drawing.Color.Silver
        Me.btnCero.Font = New System.Drawing.Font("Russo One", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCero.Location = New System.Drawing.Point(15, 433)
        Me.btnCero.Name = "btnCero"
        Me.btnCero.Size = New System.Drawing.Size(82, 80)
        Me.btnCero.TabIndex = 3
        Me.btnCero.Text = "0"
        Me.btnCero.UseVisualStyleBackColor = False
        '
        'btnPunto
        '
        Me.btnPunto.BackColor = System.Drawing.Color.Silver
        Me.btnPunto.Font = New System.Drawing.Font("Russo One", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPunto.Location = New System.Drawing.Point(122, 433)
        Me.btnPunto.Name = "btnPunto"
        Me.btnPunto.Size = New System.Drawing.Size(82, 80)
        Me.btnPunto.TabIndex = 7
        Me.btnPunto.Text = "."
        Me.btnPunto.UseVisualStyleBackColor = False
        '
        'btn2
        '
        Me.btn2.BackColor = System.Drawing.Color.Silver
        Me.btn2.Font = New System.Drawing.Font("Russo One", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn2.Location = New System.Drawing.Point(122, 331)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(82, 80)
        Me.btn2.TabIndex = 6
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = False
        '
        'btn5
        '
        Me.btn5.BackColor = System.Drawing.Color.Silver
        Me.btn5.Font = New System.Drawing.Font("Russo One", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn5.Location = New System.Drawing.Point(122, 228)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(82, 80)
        Me.btn5.TabIndex = 5
        Me.btn5.Text = "5"
        Me.btn5.UseVisualStyleBackColor = False
        '
        'btn8
        '
        Me.btn8.BackColor = System.Drawing.Color.Silver
        Me.btn8.Font = New System.Drawing.Font("Russo One", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn8.Location = New System.Drawing.Point(122, 125)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(82, 80)
        Me.btn8.TabIndex = 4
        Me.btn8.Text = "8"
        Me.btn8.UseVisualStyleBackColor = False
        '
        'btnIgual
        '
        Me.btnIgual.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.btnIgual.Font = New System.Drawing.Font("Russo One", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIgual.Location = New System.Drawing.Point(232, 433)
        Me.btnIgual.Name = "btnIgual"
        Me.btnIgual.Size = New System.Drawing.Size(82, 80)
        Me.btnIgual.TabIndex = 11
        Me.btnIgual.Text = "="
        Me.btnIgual.UseVisualStyleBackColor = False
        '
        'btn3
        '
        Me.btn3.BackColor = System.Drawing.Color.Silver
        Me.btn3.Font = New System.Drawing.Font("Russo One", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn3.Location = New System.Drawing.Point(232, 331)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(82, 80)
        Me.btn3.TabIndex = 10
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = False
        '
        'btn6
        '
        Me.btn6.BackColor = System.Drawing.Color.Silver
        Me.btn6.Font = New System.Drawing.Font("Russo One", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn6.Location = New System.Drawing.Point(232, 228)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(82, 80)
        Me.btn6.TabIndex = 9
        Me.btn6.Text = "6"
        Me.btn6.UseVisualStyleBackColor = False
        '
        'btn9
        '
        Me.btn9.BackColor = System.Drawing.Color.Silver
        Me.btn9.Font = New System.Drawing.Font("Russo One", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn9.Location = New System.Drawing.Point(232, 125)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(82, 80)
        Me.btn9.TabIndex = 8
        Me.btn9.Text = "9"
        Me.btn9.UseVisualStyleBackColor = False
        '
        'btnBorrar
        '
        Me.btnBorrar.BackColor = System.Drawing.Color.Brown
        Me.btnBorrar.Font = New System.Drawing.Font("Russo One", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrar.Location = New System.Drawing.Point(334, 125)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(87, 64)
        Me.btnBorrar.TabIndex = 12
        Me.btnBorrar.Text = "C"
        Me.btnBorrar.UseVisualStyleBackColor = False
        '
        'btnEntre
        '
        Me.btnEntre.BackColor = System.Drawing.Color.Silver
        Me.btnEntre.Font = New System.Drawing.Font("Russo One", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEntre.Location = New System.Drawing.Point(334, 211)
        Me.btnEntre.Name = "btnEntre"
        Me.btnEntre.Size = New System.Drawing.Size(87, 64)
        Me.btnEntre.TabIndex = 13
        Me.btnEntre.Text = "/"
        Me.btnEntre.UseVisualStyleBackColor = False
        '
        'btnPor
        '
        Me.btnPor.BackColor = System.Drawing.Color.Silver
        Me.btnPor.Font = New System.Drawing.Font("Russo One", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPor.Location = New System.Drawing.Point(334, 298)
        Me.btnPor.Name = "btnPor"
        Me.btnPor.Size = New System.Drawing.Size(87, 64)
        Me.btnPor.TabIndex = 14
        Me.btnPor.Text = "X"
        Me.btnPor.UseVisualStyleBackColor = False
        '
        'btnMenos
        '
        Me.btnMenos.BackColor = System.Drawing.Color.Silver
        Me.btnMenos.Font = New System.Drawing.Font("Russo One", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenos.Location = New System.Drawing.Point(334, 379)
        Me.btnMenos.Name = "btnMenos"
        Me.btnMenos.Size = New System.Drawing.Size(87, 64)
        Me.btnMenos.TabIndex = 15
        Me.btnMenos.Text = "-"
        Me.btnMenos.UseVisualStyleBackColor = False
        '
        'btnMas
        '
        Me.btnMas.BackColor = System.Drawing.Color.Silver
        Me.btnMas.Font = New System.Drawing.Font("Russo One", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMas.Location = New System.Drawing.Point(334, 462)
        Me.btnMas.Name = "btnMas"
        Me.btnMas.Size = New System.Drawing.Size(87, 64)
        Me.btnMas.TabIndex = 16
        Me.btnMas.Text = "+"
        Me.btnMas.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.btnMas)
        Me.GroupBox1.Controls.Add(Me.btnMenos)
        Me.GroupBox1.Controls.Add(Me.btnPor)
        Me.GroupBox1.Controls.Add(Me.btnEntre)
        Me.GroupBox1.Controls.Add(Me.btnBorrar)
        Me.GroupBox1.Controls.Add(Me.btnIgual)
        Me.GroupBox1.Controls.Add(Me.btn3)
        Me.GroupBox1.Controls.Add(Me.btn6)
        Me.GroupBox1.Controls.Add(Me.btn9)
        Me.GroupBox1.Controls.Add(Me.btnPunto)
        Me.GroupBox1.Controls.Add(Me.btn2)
        Me.GroupBox1.Controls.Add(Me.btn5)
        Me.GroupBox1.Controls.Add(Me.btn8)
        Me.GroupBox1.Controls.Add(Me.btnCero)
        Me.GroupBox1.Controls.Add(Me.btn1)
        Me.GroupBox1.Controls.Add(Me.btn4)
        Me.GroupBox1.Controls.Add(Me.btn7)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(703, 539)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnLimpiar)
        Me.GroupBox3.Controls.Add(Me.lbHistorial)
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Location = New System.Drawing.Point(446, 114)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(234, 412)
        Me.GroupBox3.TabIndex = 18
        Me.GroupBox3.TabStop = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.Teal
        Me.btnLimpiar.Font = New System.Drawing.Font("Russo One", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.Location = New System.Drawing.Point(15, 370)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(207, 28)
        Me.btnLimpiar.TabIndex = 3
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'lbHistorial
        '
        Me.lbHistorial.BackColor = System.Drawing.Color.Silver
        Me.lbHistorial.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbHistorial.FormattingEnabled = True
        Me.lbHistorial.ItemHeight = 22
        Me.lbHistorial.Location = New System.Drawing.Point(15, 86)
        Me.lbHistorial.Name = "lbHistorial"
        Me.lbHistorial.Size = New System.Drawing.Size(208, 268)
        Me.lbHistorial.TabIndex = 2
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Location = New System.Drawing.Point(15, 21)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(209, 53)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Sigmar One", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Historial"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnHome)
        Me.GroupBox2.Controls.Add(Me.txtDatos)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(666, 96)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        '
        'btnHome
        '
        Me.btnHome.BackgroundImage = Global.Menu_Principal.My.Resources.Resources.Home_font_awesome_svg
        Me.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnHome.Location = New System.Drawing.Point(20, 14)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(83, 76)
        Me.btnHome.TabIndex = 1
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'txtDatos
        '
        Me.txtDatos.Font = New System.Drawing.Font("Rockwell", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDatos.Location = New System.Drawing.Point(141, 30)
        Me.txtDatos.Name = "txtDatos"
        Me.txtDatos.Size = New System.Drawing.Size(470, 43)
        Me.txtDatos.TabIndex = 0
        Me.txtDatos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CalculadoraBasica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(731, 556)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CalculadoraBasica"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CalculadoraBasica"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn7 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents btnCero As Button
    Friend WithEvents btnPunto As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btnIgual As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents btnBorrar As Button
    Friend WithEvents btnEntre As Button
    Friend WithEvents btnPor As Button
    Friend WithEvents btnMenos As Button
    Friend WithEvents btnMas As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtDatos As TextBox
    Friend WithEvents lbHistorial As ListBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnHome As Button
    Friend WithEvents btnLimpiar As Button
End Class
