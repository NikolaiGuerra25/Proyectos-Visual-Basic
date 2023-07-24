Public Class menuAdmin
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub menuAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = Module2.admin
    End Sub

    Private Sub CerrarSesionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesionToolStripMenuItem.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub VerConsultasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerConsultasToolStripMenuItem.Click
        Me.Hide()
        manageConAdmin.Show()
    End Sub

    Private Sub VerConsultasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles VerConsultasToolStripMenuItem1.Click
        Me.Hide()
        verConAdmin.Show()
    End Sub

    Private Sub ExportarAExcelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportarAExcelToolStripMenuItem.Click
        Me.Hide()
        expExcel.Show()
    End Sub
End Class