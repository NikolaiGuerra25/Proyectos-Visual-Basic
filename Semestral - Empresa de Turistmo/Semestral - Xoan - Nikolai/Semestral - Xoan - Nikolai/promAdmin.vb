Imports System.Data.SqlClient
Public Class promAdmin
    Private Sub promAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_Semestral___HerramientasDataSet8.promociones' table. You can move, or remove it, as needed.
        Me.PromocionesTableAdapter.Fill(Me._Semestral___HerramientasDataSet8.promociones)

#Region "Ocultar al Cargar"
        'Labels'
        Label2.Visible = False
        Label3.Visible = False
        Label7.Visible = False
        Label8.Visible = False
        Label9.Visible = False
        Label10.Visible = False

        'txtBox'
        txtID.Visible = False
        txtNombre.Visible = False
        txtDescripcion.Visible = False
        txtCantDias.Visible = False
        txtCantNoches.Visible = False
        txtPrecio.Visible = False

        'Boton'
        actionBTN.Visible = False
        clearBTN.Visible = False
#End Region
    End Sub

#Region "Radio Buttons"
    'Insertar'
    Private Sub insertRDBTN_CheckedChanged(sender As Object, e As EventArgs) Handles insertRDBTN.CheckedChanged
        If insertRDBTN.Checked = True Then
            'AutoClear'
            AutoClear()

            'Labels'
            Label2.Visible = False
            Label3.Visible = True
            Label7.Visible = True
            Label8.Visible = True
            Label9.Visible = True
            Label10.Visible = True

            'txtBox'
            txtID.Visible = False
            txtNombre.Visible = True
            txtDescripcion.Visible = True
            txtCantDias.Visible = True
            txtCantNoches.Visible = True
            txtPrecio.Visible = True

            'Boton'
            actionBTN.Visible = True
            clearBTN.Visible = True
            actionBTN.Text = "Insertar"
        End If
    End Sub

    'Actualizar'
    Private Sub updateRDBTN_CheckedChanged(sender As Object, e As EventArgs) Handles updateRDBTN.CheckedChanged
        If updateRDBTN.Checked = True Then
            'AutoClear'
            AutoClear()

            'Labels'
            Label2.Visible = True
            Label3.Visible = True
            Label7.Visible = True
            Label8.Visible = True
            Label9.Visible = True
            Label10.Visible = True

            'txtBox'
            txtID.Visible = True
            txtNombre.Visible = True
            txtDescripcion.Visible = True
            txtCantDias.Visible = True
            txtCantNoches.Visible = True
            txtPrecio.Visible = True

            'Boton'
            actionBTN.Visible = True
            clearBTN.Visible = True
            actionBTN.Text = "Actualizar"
        End If
    End Sub

    'Borrar'
    Private Sub deleteRDBTN_CheckedChanged(sender As Object, e As EventArgs) Handles deleteRDBTN.CheckedChanged
        If deleteRDBTN.Checked = True Then
            'AutoClear'
            AutoClear()

            'Labels'
            Label2.Visible = True
            Label3.Visible = False
            Label7.Visible = False
            Label8.Visible = False
            Label9.Visible = False
            Label10.Visible = False

            'txtBox'
            txtID.Visible = True
            txtNombre.Visible = False
            txtDescripcion.Visible = False
            txtCantDias.Visible = False
            txtCantNoches.Visible = False
            txtPrecio.Visible = False

            'Boton'
            actionBTN.Visible = True
            clearBTN.Visible = False
            actionBTN.Text = "Borrar"
        End If
    End Sub
#End Region

#Region "Botones"
    'Cerrar'
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    'Limpiar'
    Private Sub clearBTN_Click(sender As Object, e As EventArgs) Handles clearBTN.Click
        txtID.Clear()
        txtNombre.Clear()
        txtDescripcion.Clear()
        txtCantDias.Clear()
        txtCantNoches.Clear()
        txtPrecio.Clear()
    End Sub

    'CRUD OPERATION'
    Private Sub actionBTN_Click(sender As Object, e As EventArgs) Handles actionBTN.Click
#Region "Insertar"
        If insertRDBTN.Checked = True Then
            Dim con As New SqlConnection("Data Source=DESKTOP-9GE5BJ5;Initial Catalog=Semestral - Herramientas;Integrated Security=True")
            con.Open()

            Dim control0 As Integer
            Dim nombre As String = txtNombre.Text
            Dim descripcion As String = txtDescripcion.Text
            Dim cantDias As String = txtCantDias.Text
            Dim cantNoches As String = txtCantNoches.Text
            Dim precio As String = txtPrecio.Text
            Dim insertQ As String
            control0 = 0

            If nombre = "" Or descripcion = "" Or cantDias = "" Or cantNoches = "" Or precio = "" Then
                MsgBox("ERROR: No se aceptan campos vacíos", vbCritical, "Alerta")

                'Error Provider'
                ErrorProvider1.SetError(txtNombre, "Debe ingresar un dato en este campo")
                ErrorProvider1.SetError(txtDescripcion, "Debe ingresar un dato en este campo")
                ErrorProvider1.SetError(txtCantDias, "Debe ingresar un dato en este campo")
                ErrorProvider1.SetError(txtCantNoches, "Debe ingresar un dato en este campo")
                ErrorProvider1.SetError(txtPrecio, "Debe ingresar un dato en este campo")
            Else
                insertQ = "Insert into promociones(nombre,descripcion,cantDias,cantNoches,precio) Values('" & nombre & "', '" & descripcion & "', '" & cantDias & "', '" & cantNoches & "', '" & precio & "')"

                Dim command0 As New SqlCommand(insertQ, con)

                control0 = command0.ExecuteNonQuery()

                If control0 > 0 Then
                    MsgBox("La inserción de la promoción se ha realizado con éxito", vbInformation, "Alerta")
                    LoadDataInGrid()
                    AutoClear()

                    'Quitar Error Provider'
                    ErrorProvider1.SetError(txtNombre, "")
                    ErrorProvider1.SetError(txtDescripcion, "")
                    ErrorProvider1.SetError(txtCantDias, "")
                    ErrorProvider1.SetError(txtCantNoches, "")
                    ErrorProvider1.SetError(txtPrecio, "")
                End If
            End If
        End If
#End Region

#Region "Actualizar"
        If updateRDBTN.Checked = True Then
            Dim con As New SqlConnection("Data Source=DESKTOP-9GE5BJ5;Initial Catalog=Semestral - Herramientas;Integrated Security=True")
            con.Open()

            Dim control1 As Integer
            Dim id As String = txtID.Text
            Dim nombre1 As String = txtNombre.Text
            Dim descripcion1 As String = txtDescripcion.Text
            Dim cantDias1 As String = txtCantDias.Text
            Dim cantNoches1 As String = txtCantNoches.Text
            Dim precio1 As String = txtPrecio.Text
            Dim updateQ As String
            control1 = 0

            If id = "" Or nombre1 = "" Or descripcion1 = "" Or cantDias1 = "" Or cantNoches1 = "" Or precio1 = "" Then
                MsgBox("ERROR: No se aceptan campos vacíos", vbCritical, "Alerta")

                'Error Provider'
                ErrorProvider1.SetError(txtID, "Debe ingresar un dato en este campo")
                ErrorProvider1.SetError(txtNombre, "Debe ingresar un dato en este campo")
                ErrorProvider1.SetError(txtDescripcion, "Debe ingresar un dato en este campo")
                ErrorProvider1.SetError(txtCantDias, "Debe ingresar un dato en este campo")
                ErrorProvider1.SetError(txtCantNoches, "Debe ingresar un dato en este campo")
                ErrorProvider1.SetError(txtPrecio, "Debe ingresar un dato en este campo")
            Else
                updateQ = "Update promociones set nombre = '" & nombre1 & "', descripcion = '" & descripcion1 & "', cantDias = '" & cantDias1 & "', cantNoches = '" & cantNoches1 & "', precio = '" & precio1 & "' where ID = '" & id & "'"

                Dim command1 As New SqlCommand(updateQ, con)

                control1 = command1.ExecuteNonQuery()

                If control1 > 0 Then
                    MsgBox("La actualización de la promoción se ha realizado con éxito", vbInformation, "Alerta")
                    LoadDataInGrid()
                    AutoClear()

                    'Quitar Error Provider'
                    ErrorProvider1.SetError(txtID, "")
                    ErrorProvider1.SetError(txtNombre, "")
                    ErrorProvider1.SetError(txtDescripcion, "")
                    ErrorProvider1.SetError(txtCantDias, "")
                    ErrorProvider1.SetError(txtCantNoches, "")
                    ErrorProvider1.SetError(txtPrecio, "")
                End If
            End If
        End If
#End Region

#Region "Borrar"
        If deleteRDBTN.Checked = True Then
            Dim con As New SqlConnection("Data Source=DESKTOP-9GE5BJ5;Initial Catalog=Semestral - Herramientas;Integrated Security=True")
            con.Open()

            Dim control2 As Integer
            Dim id1 As String = txtID.Text
            Dim deleteQ As String
            control2 = 0

            If id1 = "" Then
                MsgBox("ERROR: No se aceptan campos vacíos", vbCritical, "Alerta")

                'Error Provider'
                ErrorProvider1.SetError(txtID, "Debe ingresar un dato en este campo")
            Else
                deleteQ = "Delete from promociones where ID = '" & id1 & "'"

                Dim command2 As New SqlCommand(deleteQ, con)

                control2 = command2.ExecuteNonQuery()

                If control2 > 0 Then
                    MsgBox("El borrado de la promoción se ha realizado con éxito", vbInformation, "Alerta")
                    LoadDataInGrid()
                    AutoClear()

                    'Quitar Error Provider'
                    ErrorProvider1.SetError(txtID, "")
                End If
            End If
        End If
#End Region
    End Sub
#End Region

#Region "Funciones de Control/Actualizacion"
    'Actualizar'
    Private Sub LoadDataInGrid()
        Dim con As New SqlConnection("Data Source=DESKTOP-9GE5BJ5;Initial Catalog=Semestral - Herramientas;Integrated Security=True")
        Dim comando As New SqlCommand("Select * from promociones", con)
        Dim sda As New SqlDataAdapter(comando)
        Dim dt As New DataTable
        sda.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    'Solo numeros CantDias'
    Private Sub txtCantDias_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantDias.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    'Solo numeros CantNoches'
    Private Sub txtCantNoches_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantNoches.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    'Solo numeros decimales Precio'
    Private Sub txtPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecio.KeyPress
        'Comprobar num/.'
        solonumeros(e)

        'Uso del BackSpace'
        If Char.IsControl(e.KeyChar) Then
            e.Handled = False
        End If
    End Sub

    'Pasar datos de DGV a TXTBX'
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        'Actualizar
        If updateRDBTN.Checked = True Then
            txtID.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
            txtNombre.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
            txtDescripcion.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
            txtCantDias.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
            txtCantNoches.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
            txtPrecio.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
        End If

        'Borrar'
        If deleteRDBTN.Checked = True Then
            txtID.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        End If
    End Sub

    'Limpiar Auto'
    Private Sub AutoClear()
        txtID.Clear()
        txtNombre.Clear()
        txtDescripcion.Clear()
        txtCantDias.Clear()
        txtCantNoches.Clear()
        txtPrecio.Clear()
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
#End Region

#Region "Diseño de Botones"
    'ActionBTN'
    Private Sub actionBTN_Paint(sender As Object, e As PaintEventArgs) Handles actionBTN.Paint
        Dim buttonPath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim myRectangle As Rectangle = actionBTN.ClientRectangle
        myRectangle.Inflate(0, 35)
        buttonPath.AddEllipse(myRectangle)
        actionBTN.Region = New Region(buttonPath)
    End Sub

    'ClearBTN'
    Private Sub clearBTN_Paint(sender As Object, e As PaintEventArgs) Handles clearBTN.Paint
        Dim buttonPath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim myRectangle As Rectangle = clearBTN.ClientRectangle
        myRectangle.Inflate(0, 35)
        buttonPath.AddEllipse(myRectangle)
        clearBTN.Region = New Region(buttonPath)
    End Sub
#End Region
End Class