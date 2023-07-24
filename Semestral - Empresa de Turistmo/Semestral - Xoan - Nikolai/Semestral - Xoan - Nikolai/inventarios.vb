Imports System.Data.SqlClient
Public Class inventarios
    Private Sub inventarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_Semestral___HerramientasDataSet6.inventario' table. You can move, or remove it, as needed.
        Me.InventarioTableAdapter.Fill(Me._Semestral___HerramientasDataSet6.inventario)

#Region "Ocultar al Cargar"
        'Labels'
        Label2.Visible = False
        Label3.Visible = False
        Label8.Visible = False
        Label9.Visible = False

        'txtBox'
        txtCOD.Visible = False
        txtProducto.Visible = False
        txtDescripcion.Visible = False
        txtStock.Visible = False

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
            Label2.Visible = True
            Label3.Visible = True
            Label8.Visible = True
            Label9.Visible = True

            'txtBox'
            txtCOD.Visible = True
            txtProducto.Visible = True
            txtDescripcion.Visible = True
            txtStock.Visible = True

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
            Label8.Visible = True
            Label9.Visible = True

            'txtBox'
            txtCOD.Visible = True
            txtProducto.Visible = True
            txtDescripcion.Visible = True
            txtStock.Visible = True

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
            Label8.Visible = False
            Label9.Visible = False

            'txtBox'
            txtCOD.Visible = True
            txtProducto.Visible = False
            txtDescripcion.Visible = False
            txtStock.Visible = False

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
        txtCOD.Clear()
        txtProducto.Clear()
        txtDescripcion.Clear()
        txtStock.Clear()
    End Sub

    'CRUD OPERATION'
    Private Sub actionBTN_Click(sender As Object, e As EventArgs) Handles actionBTN.Click
#Region "Insertar"
        If insertRDBTN.Checked = True Then
            Dim con As New SqlConnection("Data Source=DESKTOP-9GE5BJ5;Initial Catalog=Semestral - Herramientas;Integrated Security=True")
            con.Open()

            Dim control0 As Integer
            Dim cod As String = txtCOD.Text
            Dim producto As String = txtProducto.Text
            Dim descripcion As String = txtDescripcion.Text
            Dim stock As String = txtStock.Text
            Dim insertQ As String
            control0 = 0

            If cod = "" Or producto = "" Or descripcion = "" Or stock = "" Then
                MsgBox("ERROR: No se aceptan campos vacíos", vbCritical, "Alerta")

                'Error Provider'
                ErrorProvider1.SetError(txtCOD, "Debe ingresar un dato en este campo")
                ErrorProvider1.SetError(txtProducto, "Debe ingresar un dato en este campo")
                ErrorProvider1.SetError(txtDescripcion, "Debe ingresar un dato en este campo")
                ErrorProvider1.SetError(txtStock, "Debe ingresar un dato en este campo")
            Else
                insertQ = "Insert into inventario(cod,producto,descripcion,stock) Values('" & cod & "', '" & producto & "', '" & descripcion & "', '" & stock & "')"

                Dim command0 As New SqlCommand(insertQ, con)

                control0 = command0.ExecuteNonQuery()

                If control0 > 0 Then
                    MsgBox("La inserción del producto se ha realizado con éxito", vbInformation, "Alerta")
                    LoadDataInGrid()
                    AutoClear()

                    'Quitar Error Provider'
                    ErrorProvider1.SetError(txtCOD, "")
                    ErrorProvider1.SetError(txtProducto, "")
                    ErrorProvider1.SetError(txtDescripcion, "")
                    ErrorProvider1.SetError(txtStock, "")
                End If
            End If
        End If
#End Region

#Region "Actualizar"
        If updateRDBTN.Checked = True Then
            Dim con As New SqlConnection("Data Source=DESKTOP-9GE5BJ5;Initial Catalog=Semestral - Herramientas;Integrated Security=True")
            con.Open()

            Dim control1 As Integer
            Dim cod1 As String = txtCOD.Text
            Dim producto1 As String = txtProducto.Text
            Dim descripcion1 As String = txtDescripcion.Text
            Dim stock1 As String = txtStock.Text
            Dim updateQ As String
            control1 = 0

            If cod1 = "" Or producto1 = "" Or descripcion1 = "" Or stock1 = "" Then
                MsgBox("ERROR: No se aceptan campos vacíos", vbCritical, "Alerta")

                'Error Provider'
                ErrorProvider1.SetError(txtCOD, "Debe ingresar un dato en este campo")
                ErrorProvider1.SetError(txtProducto, "Debe ingresar un dato en este campo")
                ErrorProvider1.SetError(txtDescripcion, "Debe ingresar un dato en este campo")
                ErrorProvider1.SetError(txtStock, "Debe ingresar un dato en este campo")
            Else
                updateQ = "Update inventario set producto = '" & producto1 & "', descripcion = '" & descripcion1 & "', stock = '" & stock1 & "' where cod = '" & cod1 & "'"

                Dim command1 As New SqlCommand(updateQ, con)

                control1 = command1.ExecuteNonQuery()

                If control1 > 0 Then
                    MsgBox("La actualización del producto se ha realizado con éxito", vbInformation, "Alerta")
                    LoadDataInGrid()
                    AutoClear()

                    'Quitar Error Provider'
                    ErrorProvider1.SetError(txtCOD, "")
                    ErrorProvider1.SetError(txtProducto, "")
                    ErrorProvider1.SetError(txtDescripcion, "")
                    ErrorProvider1.SetError(txtStock, "")
                End If
            End If
        End If
#End Region

#Region "Borrar"
        If deleteRDBTN.Checked = True Then
            Dim con As New SqlConnection("Data Source=DESKTOP-9GE5BJ5;Initial Catalog=Semestral - Herramientas;Integrated Security=True")
            con.Open()

            Dim control2 As Integer
            Dim cod2 As String = txtCOD.Text
            Dim deleteQ As String
            control2 = 0

            If cod2 = "" Then
                MsgBox("ERROR: No se aceptan campos vacíos", vbCritical, "Alerta")

                'Error Provider'
                ErrorProvider1.SetError(txtCOD, "Debe ingresar un dato en este campo")
            Else
                deleteQ = "Delete from inventario where cod = '" & cod2 & "'"

                Dim command2 As New SqlCommand(deleteQ, con)

                control2 = command2.ExecuteNonQuery()

                If control2 > 0 Then
                    MsgBox("El borrado del proveedor se ha realizado con éxito", vbInformation, "Alerta")
                    LoadDataInGrid()
                    AutoClear()

                    'Quitar Error Provider'
                    ErrorProvider1.SetError(txtCOD, "")
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
        Dim comando As New SqlCommand("Select * from inventario", con)
        Dim sda As New SqlDataAdapter(comando)
        Dim dt As New DataTable
        sda.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    'Solo numeros Stock'
    Private Sub txtStock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStock.KeyPress
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

    'Pasar datos de DGV a TXTBX'
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        'Actualizar'
        If updateRDBTN.Checked = True Then
            txtCOD.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
            txtProducto.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
            txtDescripcion.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
            txtStock.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
        End If

        'Borrar'
        If deleteRDBTN.Checked = True Then
            txtCOD.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        End If
    End Sub

    'Limpiar Auto'
    Private Sub AutoClear()
        txtCOD.Clear()
        txtProducto.Clear()
        txtDescripcion.Clear()
        txtStock.Clear()
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