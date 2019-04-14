Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtresultado.Text &= "1"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtresultado.Text &= "2"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        txtresultado.Text &= "3"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        txtresultado.Text &= "4"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        txtresultado.Text &= "5"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        txtresultado.Text &= "6"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        txtresultado.Text &= "7"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        txtresultado.Text &= "8"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        txtresultado.Text &= "9"
    End Sub

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        txtresultado.Text &= "0"
    End Sub

    Private Sub punto_Click(sender As Object, e As EventArgs) Handles punto.Click
        If InStr(txtresultado.Text, ".", CompareMethod.Text) = 0 Then
            txtresultado.Text &= "."
        End If
    End Sub

    Private Sub mas_Click(sender As Object, e As EventArgs) Handles mas.Click

    End Sub

    Private Sub menos_Click(sender As Object, e As EventArgs) Handles menos.Click

    End Sub

    Private Sub por_Click(sender As Object, e As EventArgs) Handles por.Click

    End Sub

    Private Sub entre_Click(sender As Object, e As EventArgs) Handles entre.Click

    End Sub

    Private Sub borrar_Click(sender As Object, e As EventArgs) Handles borrar.Click

    End Sub

    Private Sub igual_Click(sender As Object, e As EventArgs) Handles igual.Click

    End Sub
End Class
