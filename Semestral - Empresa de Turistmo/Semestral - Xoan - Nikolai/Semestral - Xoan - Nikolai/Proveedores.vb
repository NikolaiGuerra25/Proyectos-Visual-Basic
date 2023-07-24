Imports System.Data.SqlClient
Public Class Proveedores
    Private Sub Proveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_Semestral___HerramientasDataSet4.proveedores' table. You can move, or remove it, as needed.
        Me.ProveedoresTableAdapter.Fill(Me._Semestral___HerramientasDataSet4.proveedores)

#Region "Ocultar al Cargar"
        'Labels'
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label6.Visible = False
        Label7.Visible = False
        Label8.Visible = False
        Label9.Visible = False
        Label10.Visible = False

        'ComboBox'
        cbTProveedor.Visible = False

        'txtBox'
        txtCOD.Visible = False
        txtNombre.Visible = False
        txtDireccion.Visible = False
        txtPContacto.Visible = False
        txtTel.Visible = False
        txtEmail.Visible = False
        txtServicio.Visible = False

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
            Label4.Visible = True
            Label6.Visible = True
            Label7.Visible = True
            Label8.Visible = True
            Label9.Visible = True
            Label10.Visible = True

            'ComboBox'
            cbTProveedor.Visible = True

            'txtBox'
            txtCOD.Visible = True
            txtNombre.Visible = True
            txtDireccion.Visible = True
            txtPContacto.Visible = True
            txtTel.Visible = True
            txtEmail.Visible = True
            txtServicio.Visible = True

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
            Label4.Visible = True
            Label6.Visible = True
            Label7.Visible = True
            Label8.Visible = True
            Label9.Visible = True
            Label10.Visible = True

            'ComboBox'
            cbTProveedor.Visible = True

            'txtBox'
            txtCOD.Visible = True
            txtNombre.Visible = True
            txtDireccion.Visible = True
            txtPContacto.Visible = True
            txtTel.Visible = True
            txtEmail.Visible = True
            txtServicio.Visible = True

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
            Label4.Visible = False
            Label6.Visible = False
            Label7.Visible = False
            Label8.Visible = False
            Label9.Visible = False
            Label10.Visible = False

            'ComboBox'
            cbTProveedor.Visible = False

            'txtBox'
            txtCOD.Visible = True
            txtNombre.Visible = False
            txtDireccion.Visible = False
            txtPContacto.Visible = False
            txtTel.Visible = False
            txtEmail.Visible = False
            txtServicio.Visible = False

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
        txtNombre.Clear()
        txtDireccion.Clear()
        txtPContacto.Clear()
        txtTel.Clear()
        txtEmail.Clear()
        txtServicio.Clear()
    End Sub

    'CRUD OPERATION'
    Private Sub actionBTN_Click(sender As Object, e As EventArgs) Handles actionBTN.Click
#Region "Insertar"
        If insertRDBTN.Checked = True Then
            Dim con As New SqlConnection("Data Source=DESKTOP-9GE5BJ5;Initial Catalog=Semestral - Herramientas;Integrated Security=True")
            con.Open()

            Dim control0 As Integer
            Dim cod As String = txtCOD.Text
            Dim nombre As String = txtNombre.Text
            Dim direccion As String = txtDireccion.Text
            Dim pContacto As String = txtPContacto.Text
            Dim tel As String = txtTel.Text
            Dim tProveedor As String = cbTProveedor.Text
            Dim email As String = txtEmail.Text
            Dim servicio As String = txtServicio.Text
            Dim insertQ As String
            control0 = 0

            If cod = "" Or nombre = "" Or direccion = "" Or pContacto = "" Or tel = "" Or tProveedor = "" Or servicio = "" Then
                MsgBox("ERROR: No se aceptan campos vacíos", vbCritical, "Alerta")

                'Error Provider'
                ErrorProvider1.SetError(txtCOD, "Debe ingresar un dato en este campo")
                ErrorProvider1.SetError(txtNombre, "Debe ingresar un dato en este campo")
                ErrorProvider1.SetError(txtDireccion, "Debe ingresar un dato en este campo")
                ErrorProvider1.SetError(txtPContacto, "Debe ingresar un dato en este campo")
                ErrorProvider1.SetError(txtTel, "Debe ingresar un dato en este campo")
                ErrorProvider1.SetError(cbTProveedor, "Debe ingresar un dato en este campo")
                ErrorProvider1.SetError(txtServicio, "Debe ingresar un dato en este campo")
            Else
                insertQ = "Insert into proveedores(cod,nombre,direccion,personaContacto,email,telefono,tipoProveedor,servicio) Values('" & cod & "', '" & nombre & "', '" & direccion & "', '" & pContacto & "', '" & email & "', '" & tel & "', '" & tProveedor & "', '" & servicio & "')"

                Dim command0 As New SqlCommand(insertQ, con)

                control0 = command0.ExecuteNonQuery()

                If control0 > 0 Then
                    MsgBox("La inserción del proveedor se ha realizado con éxito", vbInformation, "Alerta")
                    LoadDataInGrid()
                    AutoClear()

                    'Quitar Error Provider'
                    ErrorProvider1.SetError(txtCOD, "")
                    ErrorProvider1.SetError(txtNombre, "")
                    ErrorProvider1.SetError(txtDireccion, "")
                    ErrorProvider1.SetError(txtPContacto, "")
                    ErrorProvider1.SetError(txtTel, "")
                    ErrorProvider1.SetError(cbTProveedor, "")
                    ErrorProvider1.SetError(txtServicio, "")
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
            Dim nombre1 As String = txtNombre.Text
            Dim direccion1 As String = txtDireccion.Text
            Dim pContacto1 As String = txtPContacto.Text
            Dim tel1 As String = txtTel.Text
            Dim tProveedor1 As String = cbTProveedor.Text
            Dim email1 As String = txtEmail.Text
            Dim servicio1 As String = txtServicio.Text
            Dim updateQ As String
            control1 = 0

            If cod1 = "" Or nombre1 = "" Or direccion1 = "" Or pContacto1 = "" Or tel1 = "" Or tProveedor1 = "" Or servicio1 = "" Then
                MsgBox("ERROR: No se aceptan campos vacíos", vbCritical, "Alerta")

                'Error Provider'
                ErrorProvider1.SetError(txtCOD, "Debe ingresar un dato en este campo")
                ErrorProvider1.SetError(txtNombre, "Debe ingresar un dato en este campo")
                ErrorProvider1.SetError(txtDireccion, "Debe ingresar un dato en este campo")
                ErrorProvider1.SetError(txtPContacto, "Debe ingresar un dato en este campo")
                ErrorProvider1.SetError(txtTel, "Debe ingresar un dato en este campo")
                ErrorProvider1.SetError(cbTProveedor, "Debe ingresar un dato en este campo")
                ErrorProvider1.SetError(txtServicio, "Debe ingresar un dato en este campo")
            Else
                updateQ = "Update proveedores set nombre = '" & nombre1 & "', direccion = '" & direccion1 & "', personaContacto = '" & pContacto1 & "', email = '" & email1 & "', telefono = '" & tel1 & "', tipoProveedor = '" & tProveedor1 & "', servicio = '" & servicio1 & "' where cod = '" & cod1 & "'"

                Dim command1 As New SqlCommand(updateQ, con)

                control1 = command1.ExecuteNonQuery()

                If control1 > 0 Then
                    MsgBox("La actualización del proveedor se ha realizado con éxito", vbInformation, "Alerta")
                    LoadDataInGrid()
                    AutoClear()

                    'Quitar Error Provider'
                    ErrorProvider1.SetError(txtCOD, "")
                    ErrorProvider1.SetError(txtNombre, "")
                    ErrorProvider1.SetError(txtDireccion, "")
                    ErrorProvider1.SetError(txtPContacto, "")
                    ErrorProvider1.SetError(txtTel, "")
                    ErrorProvider1.SetError(cbTProveedor, "")
                    ErrorProvider1.SetError(txtServicio, "")
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
                deleteQ = "Delete from proveedores where cod = '" & cod2 & "'"

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
        Dim comando As New SqlCommand("Select * from proveedores", con)
        Dim sda As New SqlDataAdapter(comando)
        Dim dt As New DataTable
        sda.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    'Solo letras Persona'
    Private Sub txtPContacto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPContacto.KeyPress
        If Not Char.IsLetter(e.KeyChar) _
                     AndAlso Not Char.IsControl(e.KeyChar) _
                     AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    'Solo numeros Tel'
    Private Sub txtTel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTel.KeyPress
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
        'Actualizar
        If updateRDBTN.Checked = True Then
            txtCOD.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
            txtNombre.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
            txtDireccion.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
            txtPContacto.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
            txtEmail.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
            txtTel.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
            cbTProveedor.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString
            txtServicio.Text = DataGridView1.CurrentRow.Cells(7).Value.ToString
        End If

        'Borrar'
        If deleteRDBTN.Checked = True Then
            txtCOD.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        End If
    End Sub

    'Limpiar Auto'
    Private Sub AutoClear()
        txtCOD.Clear()
        txtNombre.Clear()
        txtDireccion.Clear()
        txtPContacto.Clear()
        txtTel.Clear()
        txtEmail.Clear()
        txtServicio.Clear()
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