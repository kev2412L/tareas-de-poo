Public Class calculo
    Dim operacion As String
    Dim valorresultado As Nullable(Of Double) = Nothing
    Dim valor2 As Nullable(Of Double) = Nothing
    Dim precionaoperador As Boolean
    Public Sub one()
        txtresultado.Text &= "1"
    End Sub
    Public Sub two()
        txtresultado.Text &= "2"
    End Sub
    Public Sub tre()
        txtresultado.Text &= "3"
    End Sub
    Public Sub forT()
        txtresultado.Text &= "4"
    End Sub
    Public Sub five()
        txtresultado.Text &= "5"
    End Sub
    Public Sub six()
        txtresultado.Text &= "6"
    End Sub
    Public Sub seven()
        txtresultado.Text &= "7"
    End Sub
    Public Sub eng()
        txtresultado.Text &= "8"
    End Sub
    Public Sub nine()
        txtresultado.Text &= "9"
    End Sub
    Public Sub zero()
        txtresultado.Text &= "0"
    End Sub
    Public Sub puto()
        If InStr(txtresultado.Text, ".", CompareMethod.Text) = 0 Then
            txtresultado.Text &= "."
        End If
    End Sub
    Public Sub concatena()
        If precionaoperador = True Then
            txtresultado.Text = ""
            precionaoperador = False
        ElseIf txtresultado.Text = "0" Then
            txtresultado.Text = ""
        End If
    End Sub
    Public Sub evaluaoperacion()
        precionaoperador = True
        valor2 = Val(txtresultado.Text)
        If valorresultado IsNot Nothing Then
            Select Case operacion
                Case "+"
                    valorresultado = valorresultado + valor2
                Case "-"
                    valorresultado -= valor2
                Case "*"
                    valorresultado *= valor2
                Case "/"
                    valorresultado /= valor2
            End Select
            txtresultado.Text = valorresultado
        Else
            valorresultado = valor2
        End If
    End Sub
    Public Sub a()
        operacion = "+"
    End Sub
    Public Sub b()
        operacion = "-"
    End Sub
    Public Sub c()
        operacion = "*"
    End Sub
    Public Sub d()
        operacion = "/"
    End Sub
    Public Sub clea()
        txtresultado.Text = "0"
        valor2 = Nothing
        valorresultado = Nothing
    End Sub
    Public Sub igu()
        operacion = ""
    End Sub
End Class
