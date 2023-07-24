Public Class promColaborador
    Private Sub promColaborador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_Semestral___HerramientasDataSet7.promociones' table. You can move, or remove it, as needed.
        Me.PromocionesTableAdapter1.Fill(Me._Semestral___HerramientasDataSet7.promociones)
        'TODO: This line of code loads data into the '_Semestral___HerramientasDataSet3.promociones' table. You can move, or remove it, as needed.
        Me.PromocionesTableAdapter.Fill(Me._Semestral___HerramientasDataSet3.promociones)

    End Sub

    'Cerrar'
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class