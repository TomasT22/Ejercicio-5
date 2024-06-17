Public Class Form1
    Private Sub cmdEjecutar_Click(sender As Object, e As EventArgs) Handles cmdEjecutar.Click
        Dim numero, division, resultado As Integer
        numero = txtingresar.Text
        division = txtingresar.Text
        resultado = 1
        Do
            division = division - 1
            resultado = numero Mod division
        Loop Until resultado = 0 Or division = 2
        If division = 2 Then
            lblPrimo.Text = "El numero es primo"
        Else
            lblPrimo.Text = "El numero no es primo"
        End If
    End Sub
End Class
