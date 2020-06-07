Public Class Empresa_ventas
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnagregar.Click

        Dim almacenes As Integer
        Dim media, suma, ventas, ventas2, ventas3, ventas4, ventas5, ventas6, ventas7, ventas8, ventas9, ventas10 As Double

        Try
            almacenes = 10

            ventas = InputBox("Ingrese las ventas obtenidas por parte de la empresa #1 Dorado", "Ingresar")
            ventas2 = InputBox("Ingrese las ventas obtenidas por parte de la empresa #2 Blanco", "Ingresar")
            ventas3 = InputBox("Ingrese las ventas obtenidas por parte de la empresa #3 Verde", "Ingresar")
            ventas4 = InputBox("Ingrese las ventas obtenidas por parte de la empresa #4 Amarilla", "Ingresar")
            ventas5 = InputBox("Ingrese las ventas obtenidas por parte de la empresa #5 Rosada", "Ingresar")
            ventas6 = InputBox("Ingrese las ventas obtenidas por parte de la empresa #6 Rojo", "Ingresar")
            ventas7 = InputBox("Ingrese las ventas obtenidas por parte de la empresa #7 Azul", "Ingresar")
            ventas8 = InputBox("Ingrese las ventas obtenidas por parte de la empresa #8 Gris", "Ingresar")
            ventas9 = InputBox("Ingrese las ventas obtenidas por parte de la empresa #9 Negra", "Ingresar")
            ventas10 = InputBox("Ingrese las ventas obtenidas por parte de la empresa #10 Cafe", "Ingresar")

            suma = ventas + ventas2 + ventas3 + ventas4 + ventas5 + ventas6 + ventas7 + ventas8 + ventas9 + ventas10
            media = suma / almacenes

            If ventas > media Then
                lbListaEmpresas.Items.Add("Empresa #1 Dorado" & " = " & ventas)
            End If
            If ventas2 > media Then
                lbListaEmpresas.Items.Add("Empresa #2 Blanco" & " = " & ventas2)
            End If
            If ventas3 > media Then
                lbListaEmpresas.Items.Add("Empresa #3 Verde" & " = " & ventas3)
            End If
            If ventas4 > media Then
                lbListaEmpresas.Items.Add("Empresa #4 Amarilla" & " = " & ventas4)
            End If
            If ventas5 > media Then
                lbListaEmpresas.Items.Add("Empresa #5 Rosada" & " = " & ventas5)
            End If
            If ventas6 > media Then
                lbListaEmpresas.Items.Add("Empresa #6 Rojo" & " = " & ventas6)
            End If
            If ventas7 > media Then
                lbListaEmpresas.Items.Add("Empresa #7 Azul" & " = " & ventas7)
            End If
            If ventas8 > media Then
                lbListaEmpresas.Items.Add("Empresa #8 Gris" & " = " & ventas8)
            End If
            If ventas9 > media Then
                lbListaEmpresas.Items.Add("Empresa #9 Negra" & " = " & ventas9)
            End If
            If ventas10 > media Then
                lbListaEmpresas.Items.Add("Empresa #10 Café" & " = " & ventas10)
            End If
            txtMedia.Text = media

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnCalculoNuevo.Click
        txtMedia.Clear()
        lbListaEmpresas.Items.Clear()

    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        MenuPrincipal.Show()
        Me.Hide()

    End Sub
End Class