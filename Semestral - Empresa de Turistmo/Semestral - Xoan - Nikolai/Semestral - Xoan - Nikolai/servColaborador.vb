Public Class servColaborador
    Private Sub servColaborador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_Semestral___HerramientasDataSet5.servicios' table. You can move, or remove it, as needed.
        Me.ServiciosTableAdapter.Fill(Me._Semestral___HerramientasDataSet5.servicios)

    End Sub

    'Cerrar'
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    'Exportar'
    Private Sub actionBTN_Click(sender As Object, e As EventArgs) Handles actionBTN.Click
        GridAExcel(DataGridView1)
    End Sub

    'Diseño del Boton'
    Private Sub actionBTN_Paint(sender As Object, e As PaintEventArgs) Handles actionBTN.Paint
        Dim buttonPath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim myRectangle As Rectangle = actionBTN.ClientRectangle
        myRectangle.Inflate(0, 35)
        buttonPath.AddEllipse(myRectangle)
        actionBTN.Region = New Region(buttonPath)
    End Sub
End Class