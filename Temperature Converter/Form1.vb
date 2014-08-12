Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then

            Label1.Text = MaskedTextBox1.Text & " Celsius = " & Math.Round((MaskedTextBox1.Text * 1.8) + 32) & " Fahrenheit"

        ElseIf RadioButton2.Checked = True Then

            Label1.Text = MaskedTextBox1.Text & " Fahrenheit = " & Math.Round((MaskedTextBox1.Text - 32) / 1.8) & " Celsius"

        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("Temperature Converter." & vbCrLf & vbCrLf & _
              "Programmed by Victoria" & vbCrLf & vbCrLf & _
              "September 2010")
    End Sub
End Class
