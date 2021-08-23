Public Class Form1
    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles tipoazucena.CheckedChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Tipo de arreglo'
        If pequeño.Checked = True Then
            arreglo = 35
        ElseIf mediano.Checked = True Then
            arreglo = 50
        ElseIf grande.Checked = True Then
            arreglo = 65
        End If

        'verificando que al menos una checkbox esté seleccionada'
        If tiporosas.Checked = False And tipogerberas.Checked = False And tipoexoticas.Checked = False And tipoazucena.Checked = False Then
            MsgBox("NO SELECCIONÓ NINGÚN TIPO DE FLOR, POR FAVOR SELECCIONAR UNA")
        End If

        'Cantidad rosas'
        If tiporosas.Checked = True And Val(cantidadrosas.Text) > 0 Then
            rosas = Val(cantidadrosas.Text) * 2

        End If

        'cantidad gerberas'
        If tipogerberas.Checked = True And Val(cantidadgerberas.Text) > 0 Then
            gerberas = Val(cantidadgerberas.Text) * 3

        End If

        'cantidad exoticas'
        If tipoexoticas.Checked = True And Val(cantidadexoticas.Text) > 0 Then
            exoticas = Val(cantidadexoticas.Text) * 5

        End If

        'cantidad azucenas'
        If tipoazucena.Checked = True And Val(cantidadazucenas.Text) > 0 Then
            azucenas = Val(cantidadazucenas.Text) * 2

        End If

        ' calculo de subtotal'
        subtotal.Text = arreglo + rosas + gerberas + exoticas + azucenas

        'calculo descuento 1'
        If mediano.Checked = True And tipogerberas.Checked = True And tipoazucena.Checked = True Then
            descuento.Text = Val(subtotal.Text) * 2 / 100
        ElseIf grande.Checked = True And tiporosas.Checked = True And tipogerberas.Checked = True And tipoexoticas.Checked = True And tipoazucena.Checked = True Then
            descuento.Text = Val(subtotal.Text) * 10 / 100
        Else
            descuento.Text = 0
        End If

        'calculo total'
        total.Text = Val(subtotal.Text) - Val(descuento.Text)

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles cantidadazucenas.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        'limpiando el contenido'

        pequeño.Checked = False
        mediano.Checked = False
        grande.Checked = False

        tiporosas.Checked = False
        tipogerberas.Checked = False
        tipoexoticas.Checked = False
        tipoazucena.Checked = False


        Me.cantidadrosas.Clear()
        Me.cantidadgerberas.Clear()
        Me.cantidadexoticas.Clear()
        Me.cantidadazucenas.Clear()
        Me.subtotal.Clear()
        Me.descuento.Clear()
        Me.total.Clear()



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form2.Show()

    End Sub
End Class
