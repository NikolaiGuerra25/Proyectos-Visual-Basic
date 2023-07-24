Public Class menuCliente
    Public Property StringPass As String
    Private Sub CerrarSesionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesionToolStripMenuItem.Click
        Me.Hide()
        Form1.Show()
        Module1.usuario = " "
        Label2.Text = " "
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub menuCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = Module1.usuario
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub IngresarConsultaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresarConsultaToolStripMenuItem.Click
        Me.Hide()
        conCliente.show()
    End Sub

    Private Sub VerConsultasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerConsultasToolStripMenuItem.Click
        Me.Hide()
        verConCliente.Show()
    End Sub
End Class