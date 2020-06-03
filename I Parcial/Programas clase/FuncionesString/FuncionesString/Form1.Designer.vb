<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FuncionesString
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
        Me.Name1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCadena = New System.Windows.Forms.TextBox()
        Me.txtLongitud = New System.Windows.Forms.TextBox()
        Me.txtUltimoCaracter = New System.Windows.Forms.TextBox()
        Me.txtPrimerCaracter = New System.Windows.Forms.TextBox()
        Me.txtPosicionFIja = New System.Windows.Forms.TextBox()
        Me.txtPosicionB = New System.Windows.Forms.TextBox()
        Me.txtMayusculas = New System.Windows.Forms.TextBox()
        Me.txtMinusculas = New System.Windows.Forms.TextBox()
        Me.txtEspacios = New System.Windows.Forms.TextBox()
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Name1
        '
        Me.Name1.AutoSize = True
        Me.Name1.Font = New System.Drawing.Font("Russo One", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name1.Location = New System.Drawing.Point(58, 27)
        Me.Name1.Name = "Name1"
        Me.Name1.Size = New System.Drawing.Size(66, 18)
        Me.Name1.TabIndex = 0
        Me.Name1.Text = "Cadena:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Russo One", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(58, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Longitud:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Russo One", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(58, 177)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Ultimo caracter:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Russo One", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(58, 248)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Primer caracter:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Russo One", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(58, 321)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 18)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "3ro al 8vo:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Russo One", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(58, 399)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(172, 18)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Posición de la letra B:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Russo One", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(58, 474)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 18)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Mayusculas:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Russo One", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(58, 528)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 18)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Minusculas:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Russo One", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(58, 585)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(132, 18)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Borrar espacios:"
        '
        'txtCadena
        '
        Me.txtCadena.Font = New System.Drawing.Font("Rockwell", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCadena.Location = New System.Drawing.Point(175, 25)
        Me.txtCadena.Name = "txtCadena"
        Me.txtCadena.Size = New System.Drawing.Size(266, 29)
        Me.txtCadena.TabIndex = 9
        '
        'txtLongitud
        '
        Me.txtLongitud.Font = New System.Drawing.Font("Rockwell", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLongitud.Location = New System.Drawing.Point(175, 100)
        Me.txtLongitud.Name = "txtLongitud"
        Me.txtLongitud.Size = New System.Drawing.Size(266, 29)
        Me.txtLongitud.TabIndex = 10
        '
        'txtUltimoCaracter
        '
        Me.txtUltimoCaracter.Font = New System.Drawing.Font("Rockwell", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUltimoCaracter.Location = New System.Drawing.Point(228, 174)
        Me.txtUltimoCaracter.Name = "txtUltimoCaracter"
        Me.txtUltimoCaracter.Size = New System.Drawing.Size(266, 29)
        Me.txtUltimoCaracter.TabIndex = 11
        '
        'txtPrimerCaracter
        '
        Me.txtPrimerCaracter.Font = New System.Drawing.Font("Rockwell", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrimerCaracter.Location = New System.Drawing.Point(228, 245)
        Me.txtPrimerCaracter.Name = "txtPrimerCaracter"
        Me.txtPrimerCaracter.Size = New System.Drawing.Size(266, 29)
        Me.txtPrimerCaracter.TabIndex = 12
        '
        'txtPosicionFIja
        '
        Me.txtPosicionFIja.Font = New System.Drawing.Font("Rockwell", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPosicionFIja.Location = New System.Drawing.Point(186, 320)
        Me.txtPosicionFIja.Name = "txtPosicionFIja"
        Me.txtPosicionFIja.Size = New System.Drawing.Size(266, 29)
        Me.txtPosicionFIja.TabIndex = 13
        '
        'txtPosicionB
        '
        Me.txtPosicionB.Font = New System.Drawing.Font("Rockwell", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPosicionB.Location = New System.Drawing.Point(250, 398)
        Me.txtPosicionB.Name = "txtPosicionB"
        Me.txtPosicionB.Size = New System.Drawing.Size(266, 29)
        Me.txtPosicionB.TabIndex = 14
        '
        'txtMayusculas
        '
        Me.txtMayusculas.Font = New System.Drawing.Font("Rockwell", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMayusculas.Location = New System.Drawing.Point(175, 475)
        Me.txtMayusculas.Name = "txtMayusculas"
        Me.txtMayusculas.Size = New System.Drawing.Size(266, 29)
        Me.txtMayusculas.TabIndex = 15
        '
        'txtMinusculas
        '
        Me.txtMinusculas.Font = New System.Drawing.Font("Rockwell", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMinusculas.Location = New System.Drawing.Point(175, 529)
        Me.txtMinusculas.Name = "txtMinusculas"
        Me.txtMinusculas.Size = New System.Drawing.Size(266, 29)
        Me.txtMinusculas.TabIndex = 16
        '
        'txtEspacios
        '
        Me.txtEspacios.Font = New System.Drawing.Font("Rockwell", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEspacios.Location = New System.Drawing.Point(197, 586)
        Me.txtEspacios.Name = "txtEspacios"
        Me.txtEspacios.Size = New System.Drawing.Size(212, 29)
        Me.txtEspacios.TabIndex = 17
        '
        'btnMostrar
        '
        Me.btnMostrar.Font = New System.Drawing.Font("Shrikhand", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMostrar.Location = New System.Drawing.Point(459, 78)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(149, 41)
        Me.btnMostrar.TabIndex = 18
        Me.btnMostrar.Text = "Mostrar"
        Me.btnMostrar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Shrikhand", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(502, 585)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(106, 49)
        Me.btnSalir.TabIndex = 19
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'FuncionesString
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(620, 646)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnMostrar)
        Me.Controls.Add(Me.txtEspacios)
        Me.Controls.Add(Me.txtMinusculas)
        Me.Controls.Add(Me.txtMayusculas)
        Me.Controls.Add(Me.txtPosicionB)
        Me.Controls.Add(Me.txtPosicionFIja)
        Me.Controls.Add(Me.txtPrimerCaracter)
        Me.Controls.Add(Me.txtUltimoCaracter)
        Me.Controls.Add(Me.txtLongitud)
        Me.Controls.Add(Me.txtCadena)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Name1)
        Me.Name = "FuncionesString"
        Me.Text = "FuncionesString"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Name1 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtCadena As TextBox
    Friend WithEvents txtLongitud As TextBox
    Friend WithEvents txtUltimoCaracter As TextBox
    Friend WithEvents txtPrimerCaracter As TextBox
    Friend WithEvents txtPosicionFIja As TextBox
    Friend WithEvents txtPosicionB As TextBox
    Friend WithEvents txtMayusculas As TextBox
    Friend WithEvents txtMinusculas As TextBox
    Friend WithEvents txtEspacios As TextBox
    Friend WithEvents btnMostrar As Button
    Friend WithEvents btnSalir As Button
End Class
