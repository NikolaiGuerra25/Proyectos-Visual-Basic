Imports System.Data.SqlClient
Public Class Clientes
    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_Semestral___HerramientasDataSet2.datosCliente' table. You can move, or remove it, as needed.
        Me.DatosClienteTableAdapter2.Fill(Me._Semestral___HerramientasDataSet2.datosCliente)

#Region "Ocultar al Cargar"
        'Labels'
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Label7.Visible = False
        Label8.Visible = False
        Label9.Visible = False
        Label10.Visible = False

        'txtBox'
        txtID.Visible = False
        txtNombre.Visible = False
        txtApellido.Visible = False
        txtResidencia.Visible = False
        txtTrabajo.Visible = False
        txtTel1.Visible = False
        txtTel2.Visible = False
        txtEmail.Visible = False
        txtObservacion.Visible = False

        'Boton'
        actionBTN.Visible = False
        clearBTN.Visible = False
#End Region
    End Sub

#Region "Radio Buttons"
    'Borrar'
    Private Sub deleteRDBTN_CheckedChanged(sender As Object, e As EventArgs) Handles deleteRDBTN.CheckedChanged
        If deleteRDBTN.Checked = True Then
            'AutoClear'
            AutoClear()

            'Labels'
            Label2.Visible = True
            Label3.Visible = False
            Label4.Visible = False
            Label5.Visible = False
            Label6.Visible = False
            Label7.Visible = False
            Label8.Visible = False
            Label9.Visible = False
            Label10.Visible = False

            'txtBox'
            txtID.Visible = True
            txtNombre.Visible = False
            txtApellido.Visible = False
            txtResidencia.Visible = False
            txtTrabajo.Visible = False
            txtTel1.Visible = False
            txtTel2.Visible = False
            txtEmail.Visible = False
            txtObservacion.Visible = False

            'Boton'
            actionBTN.Visible = True
            clearBTN.Visible = False
            actionBTN.Text = "Borrar"
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
            Label5.Visible = True
            Label6.Visible = True
            Label7.Visible = True
            Label8.Visible = True
            Label9.Visible = True
            Label10.Visible = True

            'txtBox'
            txtID.Visible = True
            txtNombre.Visible = True
            txtApellido.Visible = True
            txtResidencia.Visible = True
            txtTrabajo.Visible = True
            txtTel1.Visible = True
            txtTel2.Visible = True
            txtEmail.Visible = True
            txtObservacion.Visible = True

            'Boton'
            actionBTN.Visible = True
            clearBTN.Visible = True
            actionBTN.Text = "Actualizar"
        End If
    End Sub

    'Insertar'
    Private Sub insertRDBTN_CheckedChanged(sender As Object, e As EventArgs) Handles insertRDBTN.CheckedChanged
        If insertRDBTN.Checked = True Then
            'AutoClear'
            AutoClear()

            'Labels'
            Label2.Visible = False
            Label3.Visible = True
            Label4.Visible = True
            Label5.Visible = True
            Label6.Visible = True
            Label7.Visible = True
            Label8.Visible = True
            Label9.Visible = True
            Label10.Visible = True

            'txtBox'
            txtID.Visible = False
            txtNombre.Visible = True
            txtApellido.Visible = True
            txtResidencia.Visible = True
            txtTrabajo.Visible = True
            txtTel1.Visible = True
            txtTel2.Visible = True
            txtEmail.Visible = True
            txtObservacion.Visible = True

            'Boton'
            actionBTN.Visible = True
            clearBTN.Visible = True
            actionBTN.Text = "Insertar"
        End If
    End Sub

    'Exportar'
    Private Sub exportRDBTN_CheckedChanged(sender As Object, e As EventArgs) Handles exportRDBTN.CheckedChanged
        If exportRDBTN.Checked = True Then
            'AutoClear'
            AutoClear()

            'Labels'
            Label2.Visible = False
            Label3.Visible = False
            Label4.Visible = False
            Label5.Visible = False
            Label6.Visible = False
            Label7.Visible = False
            Label8.Visible = False
            Label9.Visible = False
            Label10.Visible = False

            'txtBox'
            txtID.Visible = False
            txtNombre.Visible = False
            txtApellido.Visible = False
            txtResidencia.Visible = False
            txtTrabajo.Visible = False
            txtTel1.Visible = False
            txtTel2.Visible = False
            txtEmail.Visible = False
            txtObservacion.Visible = False

            'Boton'
            actionBTN.Visible = True
            clearBTN.Visible = False
            actionBTN.Text = "Exportar"
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
        txtApellido.Clear()
        txtResidencia.Clear()
        txtTrabajo.Clear()
        txtTel1.Clear()
        txtTel2.Clear()
        txtEmail.Clear()
        txtObservacion.Clear()
    End Sub

    'CRUD OPERATION'
    Private Sub actionBTN_Click(sender As Object, e As EventArgs) Handles actionBTN.Click
#Region "Insertar"
        If insertRDBTN.Checked = True Then
            Dim con As New SqlConnection("Data Source=DESKTOP-9GE5BJ5;Initial Catalog=Semestral - Herramientas;Integrated Security=True")
            con.Open()

            Dim control0 As Integer
            Dim nombre As String = txtNombre.Text
            Dim apellido As String = txtApellido.Text
            Dim residencia As String = txtResidencia.Text
            Dim lugarT As String = txtTrabajo.Text
            Dim tel1 As String = txtTel1.Text
            Dim tel2 As String = txtTel2.Text
            Dim email As String = txtEmail.Text
            Dim observacion As String = txtObservacion.Text
            Dim insertQ As String
            control0 = 0

            If nombre = "" Or apellido = "" Or residencia = "" Or lugarT = "" Or tel1 = "" Or observacion = "" Then
                MsgBox("ERROR: No se aceptan campos vacíos", vbCritical, "Alerta")

                'Error Provider'
                ErrorProvider1.SetError(txtNombre, "Debe ingresar un dato en este campo")
                ErrorProvider1.SetError(txtApellido, "Debe ingresar un dato en este campo")
                ErrorProvider1.SetError(txtResidencia, "Debe ingresar un dato en este campo")
                ErrorProvider1.SetError(txtTrabajo, "Debe ingresar un dato en este campo")
                ErrorProvider1.SetError(txtTel1, "Debe ingresar un dato en este campo")
                ErrorProvider1.SetError(txtObservacion, "Debe ingresar un dato en este campo")
            Else
                insertQ = "Insert into datosCliente(nombre,apellido,residencia,lugarTrabajo,telefono1,telefono2,email,observacion) Values('" & nombre & "', '" & apellido & "', '" & residencia & "', '" & lugarT & "', '" & tel1 & "', '" & tel2 & "', '" & email & "', '" & observacion & "')"

                Dim command0 As New SqlCommand(insertQ, con)

                control0 = command0.ExecuteNonQuery()

                If control0 > 0 Then
                    MsgBox("La inserción del cliente se ha realizado con éxito", vbInformation, "Alerta")
                    LoadDataInGrid()
                    AutoClear()

                    'Quitar Error Provider'
                    ErrorProvider1.SetError(txtNombre, "")
                    ErrorProvider1.SetError(txtApellido, "")
                    ErrorProvider1.SetError(txtResidencia, "")
                    ErrorProvider1.SetError(txtTrabajo, "")
                    ErrorProvider1.SetError(txtTel1, "")
                    ErrorProvider1.SetError(txtObservacion, "")
                End If
            End If
        End If
#End Region

#Region "Actualizar"
        If updateRDBTN.Checked = True Then
            Dim con As New SqlConnection("Data Source=DESKTOP-9GE5BJ5;Initial Catalog=Semestral - Herramientas;Integrated Security=True")
            con.Open()

            Dim control1 As Integer
            Dim id1 As String = txtID.Text
            Dim nombre1 As String = txtNombre.Text
            Dim apellido1 As String = txtApellido.Text
            Dim residencia1 As String = txtResidencia.Text
            Dim lugarT1 As String = txtTrabajo.Text
            Dim tel11 As String = txtTel1.Text
            Dim tel21 As String = txtTel2.Text
            Dim email1 As String = txtEmail.Text
            Dim observacion1 As String = txtObservacion.Text
            Dim updateQ As String
            control1 = 0

            If id1 = "" Or nombre1 = "" Or apellido1 = "" Or residencia1 = "" Or lugarT1 = "" Or tel11 = "" Or observacion1 = "" Then
                MsgBox("ERROR: No se aceptan campos vacíos", vbCritical, "Alerta")

                'Error Provider'
                ErrorProvider1.SetError(txtID, "Debe ingresar un dato en este campo")
                ErrorProvider1.SetError(txtNombre, "Debe ingresar un dato en este campo")
                ErrorProvider1.SetError(txtApellido, "Debe ingresar un dato en este campo")
                ErrorProvider1.SetError(txtResidencia, "Debe ingresar un dato en este campo")
                ErrorProvider1.SetError(txtTrabajo, "Debe ingresar un dato en este campo")
                ErrorProvider1.SetError(txtTel1, "Debe ingresar un dato en este campo")
                ErrorProvider1.SetError(txtObservacion, "Debe ingresar un dato en este campo")
            Else
                updateQ = "Update datosCliente set nombre = '" & nombre1 & "', apellido = '" & apellido1 & "', residencia = '" & residencia1 & "', lugarTrabajo = '" & lugarT1 & "', telefono1 = '" & tel11 & "', telefono2 = '" & tel21 & "', email = '" & email1 & "', observacion = '" & observacion1 & "' where ID = '" & id1 & "'"

                Dim command1 As New SqlCommand(updateQ, con)

                control1 = command1.ExecuteNonQuery()

                If control1 > 0 Then
                    MsgBox("La actualización del cliente se ha realizado con éxito", vbInformation, "Alerta")
                    LoadDataInGrid()
                    AutoClear()

                    'Quitar Error Provider'
                    ErrorProvider1.SetError(txtID, "")
                    ErrorProvider1.SetError(txtNombre, "")
                    ErrorProvider1.SetError(txtApellido, "")
                    ErrorProvider1.SetError(txtResidencia, "")
                    ErrorProvider1.SetError(txtTrabajo, "")
                    ErrorProvider1.SetError(txtTel1, "")
                    ErrorProvider1.SetError(txtObservacion, "")
                End If
            End If
        End If
#End Region

#Region "Borrar"
        If deleteRDBTN.Checked = True Then
            Dim con As New SqlConnection("Data Source=DESKTOP-9GE5BJ5;Initial Catalog=Semestral - Herramientas;Integrated Security=True")
            con.Open()

            Dim control2 As Integer
            Dim id2 As String = txtID.Text
            Dim deleteQ As String
            control2 = 0

            If id2 = "" Then
                MsgBox("ERROR: No se aceptan campos vacíos", vbCritical, "Alerta")

                'Error Provider'
                ErrorProvider1.SetError(txtID, "Debe ingresar un dato en este campo")
            Else
                deleteQ = "Delete from datosCliente where ID = '" & id2 & "'"

                Dim command2 As New SqlCommand(deleteQ, con)

                control2 = command2.ExecuteNonQuery()

                If control2 > 0 Then
                    MsgBox("El borrado del cliente se ha realizado con éxito", vbInformation, "Alerta")
                    LoadDataInGrid()
                    AutoClear()

                    'Quitar Error Provider'
                    ErrorProvider1.SetError(txtID, "")
                End If
            End If
        End If
#End Region

#Region "Exportar Excel"
        If exportRDBTN.Checked = True Then
            GridAExcel(DataGridView2)
        End If
#End Region
    End Sub
#End Region

#Region "Funciones de Control/Actualizacion"
    'Actualizar'
    Private Sub LoadDataInGrid()
        Dim con As New SqlConnection("Data Source=DESKTOP-9GE5BJ5;Initial Catalog=Semestral - Herramientas;Integrated Security=True")
        Dim comando As New SqlCommand("Select * from datosCliente", con)
        Dim sda As New SqlDataAdapter(comando)
        Dim dt As New DataTable
        sda.Fill(dt)
        DataGridView2.DataSource = dt
    End Sub

    'Solo letras Nombre'
    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        If Not Char.IsLetter(e.KeyChar) _
                     AndAlso Not Char.IsControl(e.KeyChar) _
                     AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    'Solo letras Apellido'
    Private Sub txtApellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtApellido.KeyPress
        If Not Char.IsLetter(e.KeyChar) _
                     AndAlso Not Char.IsControl(e.KeyChar) _
                     AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    'Solo letras Residencia'
    Private Sub txtResidencia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtResidencia.KeyPress
        If Not Char.IsLetter(e.KeyChar) _
                     AndAlso Not Char.IsControl(e.KeyChar) _
                     AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    'Solo numeros ID'
    Private Sub txtID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtID.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.keychar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    'Solo numeros Tel1'
    Private Sub txtTel1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTel1.KeyPress
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

    'Solo numeros Tel2'
    Private Sub txtTel2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTel2.KeyPress
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
    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        'Actualizar
        If updateRDBTN.Checked = True Then
            txtID.Text = DataGridView2.CurrentRow.Cells(0).Value.ToString
            txtNombre.Text = DataGridView2.CurrentRow.Cells(1).Value.ToString
            txtApellido.Text = DataGridView2.CurrentRow.Cells(2).Value.ToString
            txtResidencia.Text = DataGridView2.CurrentRow.Cells(3).Value.ToString
            txtTrabajo.Text = DataGridView2.CurrentRow.Cells(4).Value.ToString
            txtTel1.Text = DataGridView2.CurrentRow.Cells(5).Value.ToString
            txtTel2.Text = DataGridView2.CurrentRow.Cells(6).Value.ToString
            txtEmail.Text = DataGridView2.CurrentRow.Cells(7).Value.ToString
            txtObservacion.Text = DataGridView2.CurrentRow.Cells(8).Value.ToString
        End If

        'Borrar'
        If deleteRDBTN.Checked = True Then
            txtID.Text = DataGridView2.CurrentRow.Cells(0).Value.ToString
        End If
    End Sub

    'Limpiar Auto'
    Private Sub AutoClear()
        txtID.Clear()
        txtNombre.Clear()
        txtApellido.Clear()
        txtResidencia.Clear()
        txtTrabajo.Clear()
        txtTel1.Clear()
        txtTel2.Clear()
        txtEmail.Clear()
        txtObservacion.Clear()
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

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
#End Region
End Class