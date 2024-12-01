Public Class Form1
    Private Sub processBtn_Click(sender As Object, e As EventArgs) Handles processBtn.Click
        Dim loopedText As String
        Dim loopAmount As Integer

        loopedText = inputText.Text
        If (Integer.TryParse(inputAmount.Text, loopAmount)) Then
            loopAmount = Integer.Parse(inputAmount.Text)
            warning.Visible = False
        Else
            warning.Visible = True
        End If

        For i = 1 To loopAmount
            ListBox.Items.Add(loopedText)
        Next i

    End Sub

    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click
        ListBox.Items.Clear()
        inputAmount.Text = ""
        inputText.Text = ""
    End Sub

    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        End
    End Sub

    Private Sub inputAmount_TextChanged(sender As Object, e As EventArgs) Handles inputAmount.TextChanged
        warning.Visible = False
    End Sub
End Class
