Public Class Main
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        acercaDe.Show()
    End Sub

    Private Sub UsoDelSistemaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsoDelSistemaToolStripMenuItem.Click
        guiaSyS.Show()
    End Sub

    Private Sub EmpresaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpresaToolStripMenuItem.Click
        empresaInfo.Show()
    End Sub
End Class