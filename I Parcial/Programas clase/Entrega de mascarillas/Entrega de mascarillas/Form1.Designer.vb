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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSolicitar = New System.Windows.Forms.Button()
        Me.cmbDepartamento = New System.Windows.Forms.ComboBox()
        Me.txtDepartamentos = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.btnEntregar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMunicipios = New System.Windows.Forms.TextBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Silver
        Me.GroupBox1.Controls.Add(Me.btnSolicitar)
        Me.GroupBox1.Controls.Add(Me.cmbDepartamento)
        Me.GroupBox1.Controls.Add(Me.txtDepartamentos)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Shrikhand", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(32, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(348, 365)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cantidad por departamento"
        '
        'btnSolicitar
        '
        Me.btnSolicitar.BackColor = System.Drawing.Color.DarkGray
        Me.btnSolicitar.Font = New System.Drawing.Font("Shrikhand", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSolicitar.Location = New System.Drawing.Point(105, 123)
        Me.btnSolicitar.Name = "btnSolicitar"
        Me.btnSolicitar.Size = New System.Drawing.Size(156, 48)
        Me.btnSolicitar.TabIndex = 6
        Me.btnSolicitar.Text = "Solicitar"
        Me.btnSolicitar.UseVisualStyleBackColor = False
        '
        'cmbDepartamento
        '
        Me.cmbDepartamento.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDepartamento.FormattingEnabled = True
        Me.cmbDepartamento.Location = New System.Drawing.Point(179, 289)
        Me.cmbDepartamento.Name = "cmbDepartamento"
        Me.cmbDepartamento.Size = New System.Drawing.Size(130, 30)
        Me.cmbDepartamento.TabIndex = 4
        '
        'txtDepartamentos
        '
        Me.txtDepartamentos.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDepartamentos.Location = New System.Drawing.Point(178, 68)
        Me.txtDepartamentos.Name = "txtDepartamentos"
        Me.txtDepartamentos.Size = New System.Drawing.Size(131, 31)
        Me.txtDepartamentos.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Russo One", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 255)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(230, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cant. Por departamentos:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Russo One", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cant. Departamentos:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Silver
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtStock)
        Me.GroupBox2.Controls.Add(Me.btnEntregar)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtMunicipios)
        Me.GroupBox2.Font = New System.Drawing.Font("Shrikhand", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(678, 47)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(374, 285)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Distribución"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Russo One", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(229, 253)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 21)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "mascarillas."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Russo One", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(28, 253)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 21)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Quedan:"
        '
        'txtStock
        '
        Me.txtStock.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStock.Location = New System.Drawing.Point(113, 248)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(110, 31)
        Me.txtStock.TabIndex = 2
        '
        'btnEntregar
        '
        Me.btnEntregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnEntregar.Font = New System.Drawing.Font("Shrikhand", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEntregar.Location = New System.Drawing.Point(98, 133)
        Me.btnEntregar.Name = "btnEntregar"
        Me.btnEntregar.Size = New System.Drawing.Size(156, 48)
        Me.btnEntregar.TabIndex = 5
        Me.btnEntregar.Text = "Entregar"
        Me.btnEntregar.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Russo One", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(155, 21)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Cant. Municipios:"
        '
        'txtMunicipios
        '
        Me.txtMunicipios.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMunicipios.Location = New System.Drawing.Point(171, 76)
        Me.txtMunicipios.Name = "txtMunicipios"
        Me.txtMunicipios.Size = New System.Drawing.Size(131, 31)
        Me.txtMunicipios.TabIndex = 3
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.Firebrick
        Me.btnSalir.Font = New System.Drawing.Font("Shrikhand", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(927, 397)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(125, 45)
        Me.btnSalir.TabIndex = 2
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.LightGray
        Me.ListBox1.Font = New System.Drawing.Font("Rockwell", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Items.AddRange(New Object() {"1)  Atlántida  (8 municipios)", "2)  Choluteca  (16 municipios)", "3)  Colón  (10 municipios)", "4)  Comayagua  (21 municipios)", "5)  Copán  (23 municipios)", "6)  Cortes  (12 municipios)", "7)  El Paraíso  (19 municipios)", "8)  Francisco Morazán  (28 municipios)", "9)  Gracias a Dios  (6 municipios)", "10)  Intibucá  (17 municipios)", "11)  Islas de la Bahía  (4 municipios)", "12)  La Paz  (19 municipios)", "13)  Lempira  (28 municipios)", "14)  Ocotepeque  (16 municipios)", "15)  Olancho  (23 municipios)", "16)  Santa Bárbara  (28 municipios)", "17)  Valle  (9 municipios)", "18)  Yoro  (11 municipios)"})
        Me.ListBox1.Location = New System.Drawing.Point(401, 47)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(247, 340)
        Me.ListBox1.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Silver
        Me.Label6.Font = New System.Drawing.Font("Shrikhand", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(429, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(158, 24)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Departamentos:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(1064, 454)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Entrega mascarillas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmbDepartamento As ComboBox
    Friend WithEvents txtDepartamentos As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnEntregar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMunicipios As TextBox
    Friend WithEvents txtStock As TextBox
    Friend WithEvents btnSolicitar As Button

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSolicitar.Click

        If txtDepartamentos.Text = "" Then
            MsgBox("Escriba un numero en la casilla", vbYesNo + vbExclamation, "Advertencia")
        ElseIf Not IsNumeric(txtDepartamentos.Text) Then
            MsgBox("Escriba un valor numerico en la casilla", vbYesNo + vbExclamation, "Advertencia")
            txtDepartamentos.Text = ""
        ElseIf txtDepartamentos.Text < 0 Then
            MsgBox("Escriba un valor positivo en la casilla", vbYesNo + vbExclamation, "Advertencia")
            txtDepartamentos.Text = ""
        ElseIf txtDepartamentos.Text > 18 Then
            MsgBox("Escriba un valor de 1 a 18 en la casilla", vbYesNo + vbExclamation, "Advertencia")
            txtDepartamentos.Text = ""
        End If

        'For, DoWhile
        Dim departamentos, mascarillas As Integer
        departamentos = Val(txtDepartamentos.Text)
        For i = 1 To departamentos Step 1
            Do
                mascarillas = InputBox("Ingrese la cantidad de mascarillas" & i, ", Ingresar")
            Loop While (mascarillas < 0 Or mascarillas > 10000)
            cmbDepartamento.Items.Add(mascarillas)
        Next
    End Sub

    Private Sub entregaMascarillas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbDepartamento.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnEntregar.Click

        Dim idDepartamento, municipios, cantEntrega As Integer
        Dim itemDepartamento As String

        idDepartamento = cmbDepartamento.SelectedIndex
        itemDepartamento = cmbDepartamento.SelectedItem.ToString

        If txtMunicipios.Text = "" Then
            MsgBox("escriba un cantidad de municipios", vbOK + vbExclamation, "Mensaje especial")
        ElseIf Not IsNumeric(txtMunicipios.Text) Then
            MsgBox("escriba una cantidad de municipios", vbOK + vbExclamation, "Mensaje especial")
            txtMunicipios.Text = ""
        ElseIf (Val(txtMunicipios.Text)) < 0 Then
            MsgBox("el valor es negativo, ingrese un valor positivo")
            txtMunicipios.Text = ""
        ElseIf IsNumeric(txtMunicipios.Text) Then
            municipios = Val(txtMunicipios.Text)
        End If

        Select Case idDepartamento

            Case 0

                If municipios > 8 Then
                    MsgBox("Hay un maximo de 8 municipios en Atlántida", vbOK + vbExclamation, "Mensaje especial")
                    txtMunicipios.Text = ""

                Else
                    For i = 1 To municipios Step 1
                        While (itemDepartamento > 0)
                            cantEntrega = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas para Atlántida")
                            If (itemDepartamento > cantEntrega) Then
                                municipios += 1
                                itemDepartamento -= cantEntrega
                                txtStock.Text = itemDepartamento
                            Else
                                MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End While
                    Next
                End If

            Case 1

                If municipios > 16 Then
                    MsgBox("Hay un maximo de 16 municipios en Choluteca", vbOK + vbExclamation, "Mensaje especial")
                    txtMunicipios.Text = ""

                Else
                    For i = 1 To municipios Step 1
                        While (itemDepartamento > 0)
                            cantEntrega = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas para Choluteca")
                            If (itemDepartamento > cantEntrega) Then
                                municipios += 1
                                itemDepartamento -= cantEntrega
                                txtStock.Text = itemDepartamento
                            Else
                                MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End While
                    Next
                End If

            Case 2

                If municipios > 10 Then
                    MsgBox("Hay un maximo de 10 municipios en Colón", vbOK + vbExclamation, "Mensaje especial")
                    txtMunicipios.Text = ""

                Else
                    For i = 1 To municipios Step 1
                        While (itemDepartamento > 0)
                            cantEntrega = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas para Colón")
                            If (itemDepartamento > cantEntrega) Then
                                municipios += 1
                                itemDepartamento -= cantEntrega
                                txtStock.Text = itemDepartamento
                            Else
                                MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End While
                    Next
                End If

            Case 3

                If municipios > 21 Then
                    MsgBox("Hay un maximo de 21 municipios en Comayagua", vbOK + vbExclamation, "Mensaje especial")
                    txtMunicipios.Text = ""

                Else
                    For i = 1 To municipios Step 1
                        While (itemDepartamento > 0)
                            cantEntrega = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas para Comayagua")
                            If (itemDepartamento > cantEntrega) Then
                                municipios += 1
                                itemDepartamento -= cantEntrega
                                txtStock.Text = itemDepartamento
                            Else
                                MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End While
                    Next
                End If

            Case 4

                If municipios > 23 Then
                    MsgBox("Hay un maximo de 23 municipios en Copán", vbOK + vbExclamation, "Mensaje especial")
                    txtMunicipios.Text = ""

                Else
                    For i = 1 To municipios Step 1
                        While (itemDepartamento > 0)
                            cantEntrega = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas para Copán")
                            If (itemDepartamento > cantEntrega) Then
                                municipios += 1
                                itemDepartamento -= cantEntrega
                                txtStock.Text = itemDepartamento
                            Else
                                MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End While
                    Next
                End If

            Case 5

                If municipios > 12 Then
                    MsgBox("Hay un maximo de 12 municipios en Cortes", vbOK + vbExclamation, "Mensaje especial")
                    txtMunicipios.Text = ""

                Else
                    For i = 1 To municipios Step 1
                        While (itemDepartamento > 0)
                            cantEntrega = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas para Cortes")
                            If (itemDepartamento > cantEntrega) Then
                                municipios += 1
                                itemDepartamento -= cantEntrega
                                txtStock.Text = itemDepartamento
                            Else
                                MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End While
                    Next
                End If

            Case 6

                If municipios > 19 Then
                    MsgBox("Hay un maximo de 19 municipios en El paraíso", vbOK + vbExclamation, "Mensaje especial")
                    txtMunicipios.Text = ""

                Else
                    For i = 1 To municipios Step 1
                        While (itemDepartamento > 0)
                            cantEntrega = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas para El paraíso")
                            If (itemDepartamento > cantEntrega) Then
                                municipios += 1
                                itemDepartamento -= cantEntrega
                                txtStock.Text = itemDepartamento
                            Else
                                MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End While
                    Next
                End If

            Case 7

                If municipios > 28 Then
                    MsgBox("Hay un maximo de 28 municipios en Francisco Morazán", vbOK + vbExclamation, "Mensaje especial")
                    txtMunicipios.Text = ""

                Else
                    For i = 1 To municipios Step 1
                        While (itemDepartamento > 0)
                            cantEntrega = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas para Francisco Morazán")
                            If (itemDepartamento > cantEntrega) Then
                                municipios += 1
                                itemDepartamento -= cantEntrega
                                txtStock.Text = itemDepartamento
                            Else
                                MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End While
                    Next
                End If

            Case 8

                If municipios > 6 Then
                    MsgBox("Hay un maximo de 6 municipios en Gracias a Dios", vbOK + vbExclamation, "Mensaje especial")
                    txtMunicipios.Text = ""

                Else
                    For i = 1 To municipios Step 1
                        While (itemDepartamento > 0)
                            cantEntrega = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas para Gracias a Dios")
                            If (itemDepartamento > cantEntrega) Then
                                municipios += 1
                                itemDepartamento -= cantEntrega
                                txtStock.Text = itemDepartamento
                            Else
                                MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End While
                    Next
                End If


            Case 9

                If municipios > 17 Then
                    MsgBox("Hay un maximo de 17 municipios en Íntibuca", vbOK + vbExclamation, "Mensaje especial")
                    txtMunicipios.Text = ""

                Else
                    For i = 1 To municipios Step 1
                        While (itemDepartamento > 0)
                            cantEntrega = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas para Íntibuca")
                            If (itemDepartamento > cantEntrega) Then
                                municipios += 1
                                itemDepartamento -= cantEntrega
                                txtStock.Text = itemDepartamento
                            Else
                                MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End While
                    Next
                End If

            Case 10

                If municipios > 4 Then
                    MsgBox("Hay un maximo de 4 municipios en Islas de la Bahía", vbOK + vbExclamation, "Mensaje especial")
                    txtMunicipios.Text = ""

                Else
                    For i = 1 To municipios Step 1
                        While (itemDepartamento > 0)
                            cantEntrega = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas para Islas de la Bahía")
                            If (itemDepartamento > cantEntrega) Then
                                municipios += 1
                                itemDepartamento -= cantEntrega
                                txtStock.Text = itemDepartamento
                            Else
                                MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End While
                    Next
                End If

            Case 11
                If municipios > 19 Then
                    MsgBox("Hay un maximo de 19 municipios en La Paz", vbOK + vbExclamation, "Mensaje especial")
                    txtMunicipios.Text = ""
                Else

                    For i = 1 To municipios Step 1
                        While (itemDepartamento > 0)
                            cantEntrega = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas para La Paz")
                            If (itemDepartamento > cantEntrega) Then
                                municipios += 1
                                itemDepartamento -= cantEntrega
                                txtStock.Text = itemDepartamento
                            Else
                                MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End While
                    Next
                End If

            Case 12

                If municipios > 28 Then
                    MsgBox("Hay un maximo de 28 municipios en Lempira", vbOK + vbExclamation, "Mensaje especial")
                    txtMunicipios.Text = ""

                Else
                    For i = 1 To municipios Step 1
                        While (itemDepartamento > 0)
                            cantEntrega = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas para Lempira")
                            If (itemDepartamento > cantEntrega) Then
                                municipios += 1
                                itemDepartamento -= cantEntrega
                                txtStock.Text = itemDepartamento
                            Else
                                MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End While
                    Next
                End If

            Case 13

                If municipios > 16 Then
                    MsgBox("Hay un maximo de 16 municipios en Ocotepeque", vbOK + vbExclamation, "Mensaje especial")
                    txtMunicipios.Text = ""

                Else
                    For i = 1 To municipios Step 1
                        While (itemDepartamento > 0)
                            cantEntrega = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarilla para Ocotepeque")
                            If (itemDepartamento > cantEntrega) Then
                                municipios += 1
                                itemDepartamento -= cantEntrega
                                txtStock.Text = itemDepartamento
                            Else
                                MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End While
                    Next
                End If

            Case 14
                If municipios > 23 Then
                    MsgBox("Hay un maximo de 23 municipios en Olancho", vbOK + vbExclamation, "Mensaje especial")
                    txtMunicipios.Text = ""
                Else

                    For i = 1 To municipios Step 1
                        While (itemDepartamento > 0)
                            cantEntrega = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas para Olancho")
                            If (itemDepartamento > cantEntrega) Then
                                municipios += 1
                                itemDepartamento -= cantEntrega
                                txtStock.Text = itemDepartamento
                            Else
                                MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End While
                    Next
                End If

            Case 15

                If municipios > 28 Then
                    MsgBox("Hay un maximo de 28 municipios en Santa Bárbara", vbOK + vbExclamation, "Mensaje especial")
                    txtMunicipios.Text = ""

                Else
                    For i = 1 To municipios Step 1
                        While (itemDepartamento > 0)
                            cantEntrega = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas para Santa Bárbara")
                            If (itemDepartamento > cantEntrega) Then
                                municipios += 1
                                itemDepartamento -= cantEntrega
                                txtStock.Text = itemDepartamento
                            Else
                                MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End While
                    Next
                End If

            Case 16

                If municipios > 9 Then
                    MsgBox("Hay un maximo de 9 municipios en Valle", vbOK + vbExclamation, "Mensaje especial")
                    txtMunicipios.Text = ""

                Else
                    For i = 1 To municipios Step 1
                        While (itemDepartamento > 0)
                            cantEntrega = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas para Valle")
                            If (itemDepartamento > cantEntrega) Then
                                municipios += 1
                                itemDepartamento -= cantEntrega
                                txtStock.Text = itemDepartamento
                            Else
                                MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End While
                    Next
                End If

            Case 17

                If municipios > 11 Then
                    MsgBox("Hay un maximo de 11 municipios en Yoro", vbOK + vbExclamation, "Mensaje especial")
                    txtMunicipios.Text = ""

                Else
                    For i = 1 To municipios Step 1
                        While (itemDepartamento > 0)
                            cantEntrega = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas para Yoro")
                            If (itemDepartamento > cantEntrega) Then
                                municipios += 1
                                itemDepartamento -= cantEntrega
                                txtStock.Text = itemDepartamento
                            Else
                                MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End While
                    Next
                End If
        End Select

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label6 As Label

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnSalir.Click
        End

    End Sub

    Private Sub cmbDepartamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDepartamento.SelectedIndexChanged

        Dim departamentos As Integer

        departamentos = Val(cmbDepartamento.SelectedItem)

        txtStock.Text = departamentos

    End Sub
End Class
