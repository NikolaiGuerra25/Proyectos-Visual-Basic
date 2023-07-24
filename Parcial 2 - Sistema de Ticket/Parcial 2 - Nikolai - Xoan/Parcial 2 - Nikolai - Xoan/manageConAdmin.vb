Imports System.Data.SqlClient
Public Class manageConAdmin
    Private Sub VolverAlMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolverAlMenuToolStripMenuItem.Click
        Me.Hide()
        menuAdmin.Show()
    End Sub

    'Llenado de tabla'
    Private Sub manageConAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_Parcial_2___HerramientasDataSet2.Consulta' table. You can move, or remove it, as needed.
        Me.ConsultaTableAdapter.Fill(Me._Parcial_2___HerramientasDataSet2.Consulta)

        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False

        TextBox1.Visible = False
        TextBox3.Visible = False
        TextBox4.Visible = False

        ComboBox1.Visible = False
        ComboBox2.Visible = False

    End Sub

    'Borrar Bot'
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            Label1.Visible = True
            Label2.Visible = False
            Label3.Visible = False
            Label4.Visible = False
            Label5.Visible = False

            TextBox1.Visible = True
            TextBox3.Visible = False
            TextBox4.Visible = False

            ComboBox1.Visible = False
            ComboBox2.Visible = False

            Button2.Text = "Borrar"
            Button3.Visible = False
        End If
    End Sub

    'Actualizar Bot'
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            Label1.Visible = True
            Label2.Visible = True
            Label3.Visible = True
            Label4.Visible = True
            Label5.Visible = True

            TextBox1.Visible = True
            TextBox3.Visible = True
            TextBox4.Visible = True

            ComboBox1.Visible = True
            ComboBox2.Visible = True

            Button2.Text = "Actualizar"
            Button3.Visible = True
        End If
    End Sub

    'Limpiar'
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
    End Sub

    'Solo numeros'
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo Puede digitar numeros enteros")
        End If
    End Sub

    'Solo numeros'
    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        solonumeros(e)
    End Sub

    'Funcion Solo Numeros'
    Public Sub solonumeros(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        Dim punto As Boolean
        Select Case e.KeyChar
            Case "."
                If punto = False Then
                    punto = True
                    e.Handled = False
                Else
                    e.Handled = True
                End If
            Case "0"
                e.Handled = False
            Case "1"
                e.Handled = False
            Case "2"
                e.Handled = False
            Case "3"
                e.Handled = False
            Case "4"
                e.Handled = False
            Case "5"
                e.Handled = False
            Case "6"
                e.Handled = False
            Case "7"
                e.Handled = False
            Case "8"
                e.Handled = False
            Case "9"
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub

    'Actualizar/Borrar'
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        'Borrar'
        If RadioButton1.Checked = True Then
            Dim con As New SqlConnection("Data Source=DESKTOP-9GE5BJ5;Initial Catalog=Parcial 2 - Herramientas;Integrated Security=True")
            con.Open()

            Dim control1 As Integer
            Dim id As Integer = TextBox1.Text
            Dim borrarCon As String
            control1 = 0

            If id = 0 Then
                MsgBox("ERROR: No se aceptan campos vacios",, "Alerta")
            Else
                borrarCon = "Delete from Consulta where IDConsulta = '" & id & "'"

                Dim command1 As New SqlCommand(borrarCon, con)

                control1 = command1.ExecuteNonQuery()

                If control1 > 0 Then
                    MsgBox("El borrado de la consulta se ha realizado con exito",, "Alerta")
                    LoadDataInGrid()
                End If
            End If
        End If

        'Actualizar'
        If RadioButton2.Checked = True Then
            Dim con As New SqlConnection("Data Source=DESKTOP-9GE5BJ5;Initial Catalog=Parcial 2 - Herramientas;Integrated Security=True")
            con.Open()

            Dim control2 As Integer
            Dim id As Integer = TextBox1.Text
            Dim tipoS As String = ComboBox1.Text
            Dim estado As String = ComboBox2.Text
            Dim observacion As String = TextBox3.Text
            Dim costo As Decimal = TextBox4.Text
            Dim actualizarCon As String
            control2 = 0

            If id = 0 Or tipoS = "" Or estado = "" Or observacion = "" Or costo = 0 Then
                MsgBox("ERROR: No se aceptan campos vacios",, "Alerta")
            Else
                actualizarCon = "Update Consulta set TipoSoporte = '" & tipoS & "', Estado = '" & estado & "', Observacion = '" & observacion & "', Costo = '" & costo & "' where IDConsulta = '" & id & "'"

                Dim command2 As New SqlCommand(actualizarCon, con)

                control2 = command2.ExecuteNonQuery()

                If control2 > 0 Then
                    MsgBox("La actualizacion de la consulta se ha realizado con exito",, "Alerta")
                    LoadDataInGrid()
                End If
            End If
        End If
    End Sub

    'Actualizar'
    Private Sub LoadDataInGrid()
        Dim con As New SqlConnection("Data Source=DESKTOP-9GE5BJ5;Initial Catalog=Parcial 2 - Herramientas;Integrated Security=True")
        Dim comando As New SqlCommand("Select * from Consulta where Estado not like 'Finalizado'", con)
        Dim sda As New SqlDataAdapter(comando)
        Dim dt As New DataTable
        sda.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    'Limpiar costo'
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox4.Clear()
    End Sub

    'Filtrar'
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim con As New SqlConnection("Data Source=DESKTOP-9GE5BJ5;Initial Catalog=Parcial 2 - Herramientas;Integrated Security=True")
        con.Open()

        Dim filtro As String
        Dim urgencia As String = ComboBox3.Text

        filtro = "Select * from Consulta where Urgencia = '" & urgencia & "'"

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

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub
End Class