Public Class splash

    Private Sub splash_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Please Wait........................."

    End Sub


    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        ProgressBarX1.Value += 2
        If ProgressBarX1.Value = 100 Then
            Timer1.Enabled = False
            Me.Hide()
            FrmLogin.Show()
        End If
    End Sub

    Private Sub LabelX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelX2.Click


    End Sub
End Class