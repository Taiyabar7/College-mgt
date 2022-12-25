Public Class Dashboard
    Private Sub DashBoardButton_Click(sender As Object, e As EventArgs) Handles DashBoardButton.Click
        While Me.MainPanal.Controls.Count > 0
            Me.MainPanal.Controls(0).Dispose()
        End While

        With Dashform
            .TopLevel = False
            .AutoSize = False
            .Dock = DockStyle.Fill
            MainPanal.Controls.Add(Dashform)
            .BringToFront()
            .Show()
        End With
        VarLabel1.Text = "Dashbord"
    End Sub
    Private Sub StudentButton_Click(sender As Object, e As EventArgs) Handles StudentButton.Click
        While Me.MainPanal.Controls.Count > 0
            Me.MainPanal.Controls(0).Dispose()
        End While

        With Student
            .TopLevel = False
            .AutoSize = False
            .Dock = DockStyle.Fill
            MainPanal.Controls.Add(Student)
            .BringToFront()
            .Show()
        End With
        VarLabel1.Text = "Students"
    End Sub

    Private Sub TeacherButton_Click(sender As Object, e As EventArgs) Handles TeacherButton.Click
        While Me.MainPanal.Controls.Count > 0
            Me.MainPanal.Controls(0).Dispose()
        End While

        With Teacher
            .TopLevel = False
            .AutoSize = False
            .Dock = DockStyle.Fill
            MainPanal.Controls.Add(Teacher)
            .BringToFront()
            .Show()
        End With
        VarLabel1.Text = "Faculties"
    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles CourseButton.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub VarLabel1_Click(sender As Object, e As EventArgs) Handles VarLabel1.Click

    End Sub

    Private Sub MainPanal_Paint(sender As Object, e As PaintEventArgs) Handles MainPanal.Paint

    End Sub
End Class