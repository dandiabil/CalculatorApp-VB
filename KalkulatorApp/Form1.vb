Public Class Form1
    Dim operasiHitung As String
    Dim firstNumber, secondNumber As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbDisplay.Text = "0"
    End Sub

    Private Sub btnZero_Click(sender As Object, e As EventArgs) Handles btnZero.Click

        If tbDisplay.Text = "0" Then
            tbDisplay.Text = "0"
            firstNumber = tbDisplay.Text
        Else
            If operasiHitung = Nothing Then
                tbDisplay.Text = tbDisplay.Text & "0"
                firstNumber = tbDisplay.Text & firstNumber
            Else
                tbDisplay.Text = secondNumber & "0"
                secondNumber = tbDisplay.Text
            End If
        End If
    End Sub

    Private Sub btnOne_Click(sender As Object, e As EventArgs) Handles btnOne.Click

        If tbDisplay.Text = "0" Then
            tbDisplay.Text = "1"
            firstNumber = tbDisplay.Text
        Else
            If operasiHitung = Nothing Then
                tbDisplay.Text = tbDisplay.Text & "1"
                firstNumber = tbDisplay.Text & firstNumber
            Else
                tbDisplay.Text = secondNumber & "1"
                secondNumber = tbDisplay.Text
            End If
        End If
    End Sub

    Private Sub btnTwo_Click(sender As Object, e As EventArgs) Handles btnTwo.Click

        If tbDisplay.Text = "0" Then
            tbDisplay.Text = "2"
            firstNumber = tbDisplay.Text
        Else
            If operasiHitung = Nothing Then
                tbDisplay.Text = tbDisplay.Text & "2"
                firstNumber = tbDisplay.Text & firstNumber
            Else
                tbDisplay.Text = secondNumber & "2"
                secondNumber = tbDisplay.Text
            End If
        End If
    End Sub

    Private Sub btnThree_Click(sender As Object, e As EventArgs) Handles btnThree.Click

        If tbDisplay.Text = "0" Then
            tbDisplay.Text = "3"
            firstNumber = tbDisplay.Text
        Else
            If operasiHitung = Nothing Then
                tbDisplay.Text = tbDisplay.Text & "3"
                firstNumber = tbDisplay.Text & firstNumber
            Else
                tbDisplay.Text = secondNumber & "3"
                secondNumber = tbDisplay.Text
            End If
        End If
    End Sub

    Private Sub btnFour_Click(sender As Object, e As EventArgs) Handles btnFour.Click

        If tbDisplay.Text = "0" Then
            tbDisplay.Text = "4"
            firstNumber = tbDisplay.Text
        Else
            If operasiHitung = Nothing Then
                tbDisplay.Text = tbDisplay.Text & "4"
                firstNumber = tbDisplay.Text & firstNumber
            Else
                tbDisplay.Text = secondNumber & "4"
                secondNumber = tbDisplay.Text
            End If
        End If
    End Sub

    Private Sub btnFive_Click(sender As Object, e As EventArgs) Handles btnFive.Click

        If tbDisplay.Text = "0" Then
            tbDisplay.Text = "5"
            firstNumber = tbDisplay.Text
        Else
            If operasiHitung = Nothing Then
                tbDisplay.Text = tbDisplay.Text & "5"
                firstNumber = tbDisplay.Text & firstNumber
            Else
                tbDisplay.Text = secondNumber & "5"
                secondNumber = tbDisplay.Text
            End If
        End If
    End Sub

    Private Sub btnSix_Click(sender As Object, e As EventArgs) Handles btnSix.Click

        If tbDisplay.Text = "0" Then
            tbDisplay.Text = "6"
            firstNumber = tbDisplay.Text
        Else
            If operasiHitung = Nothing Then
                tbDisplay.Text = tbDisplay.Text & "6"
                firstNumber = tbDisplay.Text & firstNumber
            Else
                tbDisplay.Text = secondNumber & "6"
                secondNumber = tbDisplay.Text
            End If
        End If
    End Sub

    Private Sub btnSeven_Click(sender As Object, e As EventArgs) Handles btnSeven.Click

        If tbDisplay.Text = "0" Then
            tbDisplay.Text = "7"
            firstNumber = tbDisplay.Text
        Else
            If operasiHitung = Nothing Then
                tbDisplay.Text = tbDisplay.Text & "7"
                firstNumber = tbDisplay.Text & firstNumber
            Else
                tbDisplay.Text = secondNumber & "7"
                secondNumber = tbDisplay.Text
            End If
        End If
    End Sub

    Private Sub btnEight_Click(sender As Object, e As EventArgs) Handles btnEight.Click

        If tbDisplay.Text = "0" Then
            tbDisplay.Text = "8"
            firstNumber = tbDisplay.Text
        Else
            If operasiHitung = Nothing Then
                tbDisplay.Text = tbDisplay.Text & "8"
                firstNumber = tbDisplay.Text & firstNumber
            Else
                tbDisplay.Text = secondNumber & "8"
                secondNumber = tbDisplay.Text
            End If
        End If
    End Sub

    Private Sub btnNine_Click(sender As Object, e As EventArgs) Handles btnNine.Click

        If tbDisplay.Text = "0" Then
            tbDisplay.Text = "9"
            firstNumber = tbDisplay.Text
        Else
            If operasiHitung = Nothing Then
                tbDisplay.Text = tbDisplay.Text & "9"
                firstNumber = tbDisplay.Text & firstNumber
            Else
                tbDisplay.Text = secondNumber & "9"
                secondNumber = tbDisplay.Text
            End If
        End If
    End Sub

    Private Sub btnEqual_Click(sender As Object, e As EventArgs) Handles btnEqual.Click
        MsgBox("First Number : " & firstNumber & vbCrLf & "Operator : " & operasiHitung & vbCrLf _
            & "Second Number : " & secondNumber)
        Dim hasil As Integer = 0

        If operasiHitung = "+" Then
            hasil = Int(firstNumber) + Int(secondNumber)
        ElseIf operasiHitung = "-" Then
            hasil = Int(firstNumber) - Int(secondNumber)
        ElseIf operasiHitung = "x" Then
            hasil = Int(firstNumber) * Int(secondNumber)
        ElseIf operasiHitung = "/" Then
            hasil = Int(firstNumber) / Int(secondNumber)
        End If

        tbDisplay.Text = hasil
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        tbDisplay.Text = "0"
        firstNumber = Nothing
        secondNumber = Nothing
        operasiHitung = Nothing
    End Sub

    Private Sub btnSum_Click(sender As Object, e As EventArgs) Handles btnSum.Click
        If operasiHitung = "-" Or operasiHitung = "x" Or operasiHitung = "/" Then
            MsgBox("Operator Sudah Dipilih")
        Else
            tbDisplay.Text = "+"
            operasiHitung = "+"
        End If
    End Sub

    Private Sub btnMin_Click(sender As Object, e As EventArgs) Handles btnMin.Click
        If operasiHitung = "+" Or operasiHitung = "x" Or operasiHitung = "/" Then
            MsgBox("Operator Sudah Dipilih")
        Else
            tbDisplay.Text = "-"
            operasiHitung = "-"
        End If
    End Sub

    Private Sub btnTimes_Click(sender As Object, e As EventArgs) Handles btnTimes.Click
        If operasiHitung = "-" Or operasiHitung = "+" Or operasiHitung = "/" Then
            MsgBox("Operator Sudah Dipilih")
        Else
            tbDisplay.Text = "x"
            operasiHitung = "x"
        End If
    End Sub

    Private Sub btnDivision_Click(sender As Object, e As EventArgs) Handles btnDivision.Click
        If operasiHitung = "-" Or operasiHitung = "x" Or operasiHitung = "/" Then
            MsgBox("Operator Sudah Dipilih")
        Else
            tbDisplay.Text = "/"
            operasiHitung = "/"
        End If
    End Sub
End Class
