Public Class Form1
    Dim ope As Byte
    Dim resultado As Double
    Dim dato1 As Double
    Dim dato2 As Double

    Private Sub bt1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt1.Click
        txtPantalla.Text &= "1"
    End Sub

    Private Sub bt2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt2.Click
        txtPantalla.Text &= "2"
    End Sub

    Private Sub bt3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt3.Click
        txtPantalla.Text &= "3"
    End Sub

    Private Sub bt4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt4.Click
        txtPantalla.Text &= "4"
    End Sub

    Private Sub bt5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt5.Click
        txtPantalla.Text &= "5"
    End Sub

    Private Sub bt6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt6.Click
        txtPantalla.Text &= "6"
    End Sub

    Private Sub bt7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt7.Click
        txtPantalla.Text &= "7"
    End Sub

    Private Sub bt8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt8.Click
        txtPantalla.Text &= "8"
    End Sub

    Private Sub bt9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt9.Click
        txtPantalla.Text &= "9"
    End Sub

    Private Sub bt0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt0.Click
        txtPantalla.Text &= "0"
    End Sub

    Private Sub btpunto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btPunto.Click
        txtPantalla.Text &= "."
        btPunto.Enabled = False
    End Sub

    Private Sub btClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btClear.Click
        txtOperaciones.Clear()
        txtPantalla.Clear()
        btPunto.Enabled = True
    End Sub

    Private Sub btIgual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btIgual.Click
        dato2 = Val(txtPantalla.Text)
        Select Case ope
            Case 1
                resultado = dato1 + dato2
                txtOperaciones.Text = dato1 & " + " & dato2 & " = "

            Case 2
                resultado = dato1 - dato2
                txtOperaciones.Text = dato1 & " – " & dato2 & " = "

            Case 3
                resultado = dato1 * dato2
                txtOperaciones.Text = dato1 & " × " & dato2 & " = "

            Case 4
                resultado = dato1 / dato2
                txtOperaciones.Text = dato1 & " ÷ " & dato2 & " = "

        End Select
        txtPantalla.Text = resultado
    End Sub

    Private Sub btSuma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSuma.Click
        dato1 = Val(txtPantalla.Text)
        txtPantalla.Clear()
        txtOperaciones.Text = dato1 & " + "
        ope = 1
    End Sub

    Private Sub btResta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btResta.Click
        dato1 = Val(txtPantalla.Text)
        txtPantalla.Clear()
        txtOperaciones.Text = dato1 & " – "
        ope = 2
    End Sub

    Private Sub btMultiplicacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btMultiplicacion.Click
        dato1 = Val(txtPantalla.Text)
        txtPantalla.Clear()
        txtOperaciones.Text = dato1 & " × "
        ope = 3
    End Sub

    Private Sub btDivision_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btDivision.Click
        dato1 = Val(txtPantalla.Text)
        txtPantalla.Clear()
        txtOperaciones.Text = dato1 & " ÷ "
        ope = 4
    End Sub

    Private Sub btOff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btOff.Click
        Beep()
        End
    End Sub

    Private Sub btDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btDel.Click
        If txtPantalla.Text <> "" Then
            txtPantalla.Text = Mid(txtPantalla.Text, 1, txtPantalla.Text.Length - 1)
        End If
    End Sub
End Class