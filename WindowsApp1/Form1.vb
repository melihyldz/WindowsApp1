Public Class Form1
    Public islem As String
    Public sayi1, sayi2, sonuc As Double
    Private Sub Num0_Click(sender As Object, e As EventArgs) Handles Num0.Click
        If processScreen.Text = "0" Then
            processScreen.Text = "0"
        Else
            processScreen.Text = processScreen.Text + "0"
        End If
    End Sub
    Private Sub Num1_Click(sender As Object, e As EventArgs) Handles Num1.Click
        If processScreen.Text = "0" Then
            processScreen.Text = "1"
        Else
            processScreen.Text = processScreen.Text + "1"
        End If

    End Sub
    Private Sub Num2_Click(sender As Object, e As EventArgs) Handles Num2.Click
        If processScreen.Text = "0" Then
            processScreen.Text = "2"
        Else
            processScreen.Text = processScreen.Text + "2"
        End If
    End Sub
    Private Sub Num3_Click(sender As Object, e As EventArgs) Handles Num3.Click
        If processScreen.Text = "0" Then
            processScreen.Text = "3"
        Else
            processScreen.Text = processScreen.Text + "3"
        End If
    End Sub
    Private Sub Num4_Click(sender As Object, e As EventArgs) Handles Num4.Click
        If processScreen.Text = "0" Then
            processScreen.Text = "4"
        Else
            processScreen.Text = processScreen.Text + "4"
        End If
    End Sub
    Private Sub Num5_Click(sender As Object, e As EventArgs) Handles Num5.Click
        If processScreen.Text = "0" Then
            processScreen.Text = "5"
        Else
            processScreen.Text = processScreen.Text + "5"
        End If
    End Sub
    Private Sub Num6_Click(sender As Object, e As EventArgs) Handles Num6.Click
        If processScreen.Text = "0" Then
            processScreen.Text = "6"
        Else
            processScreen.Text = processScreen.Text + "6"
        End If
    End Sub
    Private Sub Num7_Click(sender As Object, e As EventArgs) Handles Num7.Click
        If processScreen.Text = "0" Then
            processScreen.Text = "7"
        Else
            processScreen.Text = processScreen.Text + "7"
        End If
    End Sub
    Private Sub Num8_Click(sender As Object, e As EventArgs) Handles Num8.Click
        If processScreen.Text = "0" Then
            processScreen.Text = "8"
        Else
            processScreen.Text = processScreen.Text + "8"
        End If
    End Sub
    Private Sub Num9_Click(sender As Object, e As EventArgs) Handles Num9.Click
        If processScreen.Text = "0" Then
            processScreen.Text = "9"
        Else
            processScreen.Text = processScreen.Text + "9"
        End If
    End Sub

    Private Sub squareRoot_Click(sender As Object, e As EventArgs) Handles squareRoot.Click
        sayi1 = processScreen.Text
        sonuc = Math.Sqrt(sayi1)
        processScreen.Text = sonuc
    End Sub
    Private Sub square_Click(sender As Object, e As EventArgs) Handles square.Click
        sayi1 = processScreen.Text
        sonuc = Math.Pow(sayi1, 2)
        processScreen.Text = sonuc
    End Sub

    Private Sub plus_Click(sender As Object, e As EventArgs) Handles plus.Click
        islem = "+"
        sayi1 = processScreen.Text
        processScreen.Text = 0
    End Sub
    Private Sub minus_Click(sender As Object, e As EventArgs) Handles minus.Click
        islem = "-"
        sayi1 = processScreen.Text
        processScreen.Text = 0
    End Sub
    Private Sub multiplication_Click(sender As Object, e As EventArgs) Handles multiplication.Click
        islem = "x"
        sayi1 = processScreen.Text
        processScreen.Text = 0
    End Sub
    Private Sub division_Click(sender As Object, e As EventArgs) Handles division.Click
        islem = "/"
        sayi1 = processScreen.Text
        processScreen.Text = 0
    End Sub

    Private Sub percent_Click(sender As Object, e As EventArgs) Handles percent.Click
        islem = "%"
        sayi1 = processScreen.Text
        processScreen.Text = "0"
    End Sub

    Private Sub equal_Click(sender As Object, e As EventArgs) Handles equal.Click
        sayi2 = processScreen.Text
        If islem = "+" Then
            sonuc = sayi1 + sayi2
            RichTextBox1.AppendText(sayi1 & " " & islem & " " & sayi2 & "=" & sonuc & vbCrLf)
            processScreen.Text = sonuc
        ElseIf islem = "-" Then
            sonuc = sayi1 - sayi2
            RichTextBox1.AppendText(sayi1 & " " & islem & " " & sayi2 & "=" & sonuc & vbCrLf)
            processScreen.Text = sonuc
        ElseIf islem = "/" Then
            sonuc = sayi1 / sayi2
            If sayi2 = 0 Then
                processScreen.Text = "Geçersiz İşlem"
            Else
                RichTextBox1.AppendText(sayi1 & " " & islem & " " & sayi2 & "=" & sonuc & vbCrLf)
                processScreen.Text = sonuc
            End If
        ElseIf islem = "x" Then
            sonuc = sayi1 * sayi2
            RichTextBox1.AppendText(sayi1 & " " & islem & " " & sayi2 & "=" & sonuc & vbCrLf)
            processScreen.Text = sonuc
        ElseIf islem = "%" Then
            sonuc = (sayi1 * sayi2) / 100
            RichTextBox1.AppendText(sayi1 & " " & islem & " " & sayi2 & "=" & sonuc & vbCrLf)
            processScreen.Text = sonuc
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RichTextBox1.Text = ""
    End Sub
    Private Sub reset_Click(sender As Object, e As EventArgs) Handles reset.Click
        sonuc = 0
        processScreen.Text = sonuc
    End Sub
End Class