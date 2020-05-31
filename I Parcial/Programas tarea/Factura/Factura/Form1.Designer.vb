<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Facturación
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Facturación))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbbISV = New System.Windows.Forms.ComboBox()
        Me.cbbDescuento = New System.Windows.Forms.ComboBox()
        Me.chkISV = New System.Windows.Forms.CheckBox()
        Me.chkDescuento = New System.Windows.Forms.CheckBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.txtPrecioU = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtISV = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtDescuento = New System.Windows.Forms.TextBox()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.cbbISV)
        Me.Panel1.Controls.Add(Me.cbbDescuento)
        Me.Panel1.Controls.Add(Me.chkISV)
        Me.Panel1.Controls.Add(Me.chkDescuento)
        Me.Panel1.Controls.Add(Me.txtCantidad)
        Me.Panel1.Controls.Add(Me.txtPrecioU)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(36, 76)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(349, 282)
        Me.Panel1.TabIndex = 0
        '
        'cbbISV
        '
        Me.cbbISV.BackColor = System.Drawing.Color.Wheat
        Me.cbbISV.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbbISV.Enabled = False
        Me.cbbISV.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.cbbISV.FormattingEnabled = True
        Me.cbbISV.Items.AddRange(New Object() {"15%", "17%"})
        Me.cbbISV.Location = New System.Drawing.Point(14, 235)
        Me.cbbISV.Name = "cbbISV"
        Me.cbbISV.Size = New System.Drawing.Size(272, 30)
        Me.cbbISV.TabIndex = 7
        '
        'cbbDescuento
        '
        Me.cbbDescuento.BackColor = System.Drawing.Color.Wheat
        Me.cbbDescuento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbbDescuento.Enabled = False
        Me.cbbDescuento.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.cbbDescuento.FormattingEnabled = True
        Me.cbbDescuento.Items.AddRange(New Object() {"Tercera Edad", "Estudiante", "Discapacidad", "Mujeres Embarazadas", "Extranjeros", "Viudos(as)"})
        Me.cbbDescuento.Location = New System.Drawing.Point(14, 162)
        Me.cbbDescuento.Name = "cbbDescuento"
        Me.cbbDescuento.Size = New System.Drawing.Size(272, 30)
        Me.cbbDescuento.TabIndex = 6
        '
        'chkISV
        '
        Me.chkISV.AutoSize = True
        Me.chkISV.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.chkISV.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkISV.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Bold)
        Me.chkISV.Location = New System.Drawing.Point(14, 207)
        Me.chkISV.Name = "chkISV"
        Me.chkISV.Size = New System.Drawing.Size(111, 22)
        Me.chkISV.TabIndex = 5
        Me.chkISV.Text = "Aplicar ISV"
        Me.chkISV.UseVisualStyleBackColor = False
        '
        'chkDescuento
        '
        Me.chkDescuento.AutoSize = True
        Me.chkDescuento.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.chkDescuento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkDescuento.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Bold)
        Me.chkDescuento.Location = New System.Drawing.Point(14, 134)
        Me.chkDescuento.Name = "chkDescuento"
        Me.chkDescuento.Size = New System.Drawing.Size(162, 22)
        Me.chkDescuento.TabIndex = 4
        Me.chkDescuento.Text = "Aplicar descuento"
        Me.chkDescuento.UseVisualStyleBackColor = False
        '
        'txtCantidad
        '
        Me.txtCantidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtCantidad.Location = New System.Drawing.Point(175, 84)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(133, 30)
        Me.txtCantidad.TabIndex = 3
        '
        'txtPrecioU
        '
        Me.txtPrecioU.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPrecioU.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtPrecioU.Location = New System.Drawing.Point(175, 27)
        Me.txtPrecioU.Name = "txtPrecioU"
        Me.txtPrecioU.Size = New System.Drawing.Size(133, 30)
        Me.txtPrecioU.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Gainsboro
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Rockwell", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(28, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 25)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Cantidad:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Gainsboro
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(14, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 48)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Precio" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "       Unitario:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.txtISV)
        Me.Panel2.Controls.Add(Me.txtTotal)
        Me.Panel2.Controls.Add(Me.txtDescuento)
        Me.Panel2.Controls.Add(Me.txtSubtotal)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Location = New System.Drawing.Point(36, 446)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(474, 249)
        Me.Panel2.TabIndex = 1
        '
        'txtISV
        '
        Me.txtISV.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtISV.Enabled = False
        Me.txtISV.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtISV.Location = New System.Drawing.Point(276, 82)
        Me.txtISV.Name = "txtISV"
        Me.txtISV.Size = New System.Drawing.Size(151, 30)
        Me.txtISV.TabIndex = 7
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTotal.Enabled = False
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtTotal.Location = New System.Drawing.Point(276, 175)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(169, 30)
        Me.txtTotal.TabIndex = 6
        '
        'txtDescuento
        '
        Me.txtDescuento.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDescuento.Enabled = False
        Me.txtDescuento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtDescuento.Location = New System.Drawing.Point(36, 82)
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.Size = New System.Drawing.Size(151, 30)
        Me.txtDescuento.TabIndex = 5
        '
        'txtSubtotal
        '
        Me.txtSubtotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSubtotal.Enabled = False
        Me.txtSubtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtSubtotal.Location = New System.Drawing.Point(36, 175)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.Size = New System.Drawing.Size(169, 30)
        Me.txtSubtotal.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Gainsboro
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Rockwell", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(276, 43)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 25)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "ISV:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Gainsboro
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Rockwell", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(276, 138)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 25)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Total:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Gainsboro
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Rockwell", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(37, 43)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 25)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Descuento:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Gainsboro
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Rockwell", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(37, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 25)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Subtotal:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Russo One", 12.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.Window
        Me.Label1.Location = New System.Drawing.Point(36, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 52)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Datos " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "        Requeridos:"
        '
        'btnCalcular
        '
        Me.btnCalcular.BackColor = System.Drawing.Color.Chocolate
        Me.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCalcular.Font = New System.Drawing.Font("Shrikhand", 10.0!)
        Me.btnCalcular.ForeColor = System.Drawing.SystemColors.Window
        Me.btnCalcular.Location = New System.Drawing.Point(426, 90)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(133, 66)
        Me.btnCalcular.TabIndex = 3
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNuevo.Enabled = False
        Me.btnNuevo.Font = New System.Drawing.Font("Shrikhand", 10.0!)
        Me.btnNuevo.ForeColor = System.Drawing.SystemColors.Window
        Me.btnNuevo.Location = New System.Drawing.Point(440, 180)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(105, 34)
        Me.btnNuevo.TabIndex = 4
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.Brown
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.Font = New System.Drawing.Font("Shrikhand", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.SystemColors.Window
        Me.btnSalir.Location = New System.Drawing.Point(426, 234)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(133, 44)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Russo One", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Window
        Me.Label4.Location = New System.Drawing.Point(36, 382)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 52)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Detalles" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "        Factura:"
        '
        'Facturación
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(576, 707)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Facturación"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Facturación"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents cbbISV As ComboBox
    Friend WithEvents cbbDescuento As ComboBox
    Friend WithEvents chkISV As CheckBox
    Friend WithEvents chkDescuento As CheckBox
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents txtPrecioU As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtISV As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtDescuento As TextBox
    Friend WithEvents txtSubtotal As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
End Class
