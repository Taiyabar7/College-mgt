Public Class splash
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LoadingBar1.Increment(3)
        If LoadingBar1.Value = 100 Then
            Me.Hide()
            Dim log = New Login
            log.Show()
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub LoadingBar1_BackgroundImageChanged(sender As Object, e As EventArgs) Handles LoadingBar1.BackgroundImageChanged

    End Sub

    Private Sub s(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub LoadingBar1_ValueChanged(sender As Object, e As EventArgs) Handles LoadingBar1.ValueChanged

    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
