Public Class Facturación
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        'Vacia los textbox de ingreso de datos
        txtPrecioU.Clear()
        txtCantidad.Clear()

        'Vacia los checkbox
        chkDescuento.Checked = False
        chkISV.Checked = False

        'Vacia los textbox de resultados
        txtSubtotal.Clear()
        txtTotal.Clear()
        txtDescuento.Clear()
        txtISV.Clear()

        'Reinicia todos los checkbox y combobox
        chkDescuento.Enabled = True
        chkISV.Enabled = True
        cbbDescuento.SelectedItem = Nothing
        cbbISV.SelectedItem = Nothing
        cbbDescuento.Enabled = True
        cbbISV.Enabled = True

        'Se bloquea el mismo xD
        btnNuevo.Enabled = False

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click

        Dim preUnitario, descuento, subtotal, totalISV, totalDescu, ISV As Double
        Dim cantidad As Integer
        Dim opcionDescuento, opcionISV As String

        preUnitario = Val(txtPrecioU.Text)
        cantidad = Val(txtCantidad.Text)


        'Validación de precio unitario

        Dim precioU As Int16

        If txtPrecioU.Text = "" Then
            MsgBox("Ingrese un NÚMERO en 
            la casilla #1", vbExclamation, "Información")
            txtPrecioU.Clear()

        ElseIf Not IsNumeric(txtPrecioU.Text) Then
            MsgBox("Ingrese un VALOR NUMÉRICO en 
               la casilla #1", vbExclamation, "Información")
            txtPrecioU.Clear()

        ElseIf IsNumeric(precioU) Then
            precioU = Val(txtPrecioU.Text)

            If precioU = 0 Then
                MsgBox("Por favor ingrese un valor distinto 
                a CERO en la casilla #1", vbInformation, "Información")
                txtPrecioU.Clear()

            ElseIf precioU < 0 Then
                MsgBox("Por favor ingrese un valor 
        POSITIVO, en la casilla #1", vbExclamation, "Información")
                txtPrecioU.Clear()

            End If

        End If


        'Validación de cantidad

        Dim canti As Int16

        If txtCantidad.Text = "" Then
            MsgBox("Ingrese un NÚMERO en 
            la casilla #2", vbExclamation, "Información")
            txtCantidad.Clear()

        ElseIf Not IsNumeric(txtCantidad.Text) Then
            MsgBox("Ingrese un VALOR NUMÉRICO en 
               la casilla #2", vbExclamation, "Información")
            txtCantidad.Clear()

        ElseIf IsNumeric(canti) Then
            canti = Val(txtCantidad.Text)

            If canti = 0 Then
                MsgBox("Por favor ingrese un valor distinto 
            a CERO en la casilla #2", vbInformation, "Información")
                txtCantidad.Clear()

            ElseIf canti < 0 Then
                MsgBox("Por favor ingrese un valor 
        POSITIVO, en la casilla #2", vbExclamation, "Información")
                txtCantidad.Clear()

            End If

        End If

        If chkDescuento.Checked = False And chkISV.Checked = False Then
            MsgBox("Por favor elija una de las dos opciones", vbExclamation, "Información")
            btnNuevo.Enabled = False
        End If


        'Descuento
        opcionDescuento = cbbDescuento.SelectedItem

        descuento = 0

        subtotal = preUnitario * cantidad

        If chkDescuento.Checked = True Then


            If opcionDescuento = "Tercera Edad" Then
                descuento = subtotal * 0.5

            End If

            If opcionDescuento = "Estudiante" Then
                descuento = subtotal * 0.1
            End If

            If opcionDescuento = "Discapacidad" Then
                descuento = subtotal * 0.3
            End If

            If opcionDescuento = "Mujeres Embarazadas" Then
                descuento = subtotal * 0.2
            End If

            If opcionDescuento = "Extranjeros" Then
                descuento = subtotal * 0.05
            End If

            If opcionDescuento = "Viudos(as)" Then
                descuento = subtotal * 0.15

            End If


            'Salida descuento

            If (preUnitario Or cantidad) > 0 Then

                txtSubtotal.Text = subtotal

                txtDescuento.Text = descuento

                totalDescu = subtotal - descuento

                txtTotal.Text = totalDescu

            End If
        End If



        'ISV
        If chkISV.Checked = True Then

            opcionISV = cbbISV.SelectedItem

            ISV = 0

            If opcionISV = "15%" Then
                ISV = subtotal * 0.15
            End If

            If opcionISV = "17%" Then
                ISV = subtotal * 0.17
            End If

            'Salida ISV

            If (preUnitario Or cantidad) > 0 Then

                txtSubtotal.Text = subtotal
                txtISV.Text = ISV

                totalISV = subtotal + ISV

                txtTotal.Text = totalISV

            End If
        End If


        'Vuelve a habilitar boton nuevo
        btnNuevo.Enabled = True

    End Sub

    Private Sub chkDescuento_CheckedChanged(sender As Object, e As EventArgs) Handles chkDescuento.CheckedChanged


        If chkDescuento.Checked = True Then
            cbbDescuento.Enabled = True
            chkISV.Enabled = False
            cbbISV.Enabled = False

        End If

        If chkDescuento.Checked = False Then
            chkISV.Enabled = True
            cbbISV.Enabled = True
            cbbDescuento.SelectedItem = Nothing

        End If

    End Sub

    Private Sub cbbDescuentos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbDescuento.SelectedIndexChanged

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub chkISV_CheckedChanged(sender As Object, e As EventArgs) Handles chkISV.CheckedChanged

        If chkISV.Checked = True Then

            cbbISV.Enabled = True
            chkDescuento.Enabled = False
            cbbDescuento.Enabled = False

        End If

        If chkISV.Checked = False Then

            chkDescuento.Enabled = True
            cbbDescuento.Enabled = True
            cbbISV.SelectedItem = Nothing

        End If


    End Sub
End Class
