Imports System.Data.SqlClient
Public Class expExcel
    Private Sub VolverAlMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolverAlMenuToolStripMenuItem.Click
        Me.Hide()
        menuAdmin.Show()
    End Sub

    Private Sub expExcel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_Parcial_2___HerramientasDataSet.Consulta' table. You can move, or remove it, as needed.
        Me.ConsultaTableAdapter.Fill(Me._Parcial_2___HerramientasDataSet.Consulta)
    End Sub

    'Exportar a Excel'
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GridAExcel(DataGridView1)
    End Sub

    'Solo Numeros'
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo Puede digitar numeros enteros")
        End If
    End Sub

    'Filtrar ID'
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim con As New SqlConnection("Data Source=DESKTOP-9GE5BJ5;Initial Catalog=Parcial 2 - Herramientas;Integrated Security=True")
        con.Open()

        Dim filtro As String
        Dim id As String = TextBox1.Text

        filtro = "Select * from Consulta where IDConsulta = '" & id & "'"

        Dim command As New SqlCommand(filtro, con)

        Dim sda As New SqlDataAdapter(command)
        Dim dt As New DataTable

        sda.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    'Quitar Filtro'
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim con As New SqlConnection("Data Source=DESKTOP-9GE5BJ5;Initial Catalog=Parcial 2 - Herramientas;Integrated Security=True")
        con.Open()

        Dim efiltro As String

        efiltro = "Select * from Consulta"

        Dim command3 As New SqlCommand(efiltro, con)

        Dim sda As New SqlDataAdapter(command3)
        Dim dt As New DataTable

        sda.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub
End Class