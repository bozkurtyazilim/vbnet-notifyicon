Public Class Form1
    Dim tepsi As Boolean = True

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If tepsi = True Then
            NotifyIcon1.Visible = False
            tepsi = False
            Button1.Text = "Sistem tepsisinde göster"
        Else
            NotifyIcon1.Visible = True
            tepsi = True
            Button1.Text = "Sistem tepsisinde gizle"
        End If


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        NotifyIcon1.Visible = True


        NotifyIcon1.BalloonTipIcon = ToolTipIcon.Error

        NotifyIcon1.BalloonTipTitle = "Bozkurt Yazılım"
        NotifyIcon1.BalloonTipText = "Programın güncel versiyonu mevcut lütfen programı şimdi güncelleyin!"
        NotifyIcon1.ShowBalloonTip(3000)
    End Sub

    Private Sub SistemTepsisindeSaklaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SistemTepsisindeSaklaToolStripMenuItem.Click
        NotifyIcon1.Visible = False
        tepsi = False
        Button1.Text = "Sistem tepsisinde göster"
    End Sub

    Private Sub ProgramıGösterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProgramıGösterToolStripMenuItem.Click
        Me.Show()
    End Sub

    Private Sub ProgramıGizleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProgramıGizleToolStripMenuItem.Click
        Me.Hide()

    End Sub

    Private Sub AyarlarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AyarlarToolStripMenuItem.Click
        MsgBox("Geçici olarak ayarlar kapatılmıştır")

    End Sub

    Private Sub ÇıkışToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÇıkışToolStripMenuItem.Click
        Me.Close()

    End Sub
End Class
