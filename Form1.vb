Public Class Form1
    Private Sub btbResults_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btbResults_Click_1(sender As Object, e As EventArgs) Handles btnResults.Click
        Dim Marks As Integer
        If IsNumeric(txtMarks) = True Then

        End If
        MsgBox("Fail")
        If Marks <= 50 Then

        End If
        MsgBox("Fail")

        MsgBox("Invalid! ENTER A NUMBER")
            If Marks < 0 Or Marks > 100 Then
                MsgBox("Invalid mark")
            ElseIf Marks > 50 Then
                MsgBox("Pass")
            End If


    End Sub
End Class
