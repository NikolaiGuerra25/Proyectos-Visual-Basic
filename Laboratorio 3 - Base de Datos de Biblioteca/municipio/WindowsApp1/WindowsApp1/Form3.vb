Public Class Form3
    Dim valor As String
    Dim seleccion As String



    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.Hide()

        Dim da As New OleDb.OleDbDataAdapter
        Dim dv As New DataView
        Dim ds As New DataSet

        consulta = "SELECT * FROM CLIENTES"

        Try
            da = New OleDb.OleDbDataAdapter(consulta, conexion)
            da.Fill(ds)
            dv.Table = ds.Tables(0)
            DataGridView1.DataSource = dv

        Catch ex As Exception

            MsgBox(ex.Message, vbOKOnly + vbCritical, "¡ERROR!")
        End Try

    End Sub

    Private Sub Form3_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Form1.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim da As New OleDb.OleDbDataAdapter
        Dim dv As New DataView
        Dim ds As New DataSet

        valor = txt1.Text

        If txt1.Text = "" Then
            consulta = "SELECT * FROM CLIENTES"
            Button3.Enabled = False
        Else

            If ComboBox1.Text = "Cédula" Then
                consulta = "SELECT * FROM CLIENTES WHERE CED = '" & valor & "'"
                Button3.Enabled = True
            ElseIf ComboBox1.Text = "Número de acta" Then
                consulta = "SELECT * FROM CLIENTES WHERE NUM_ACTA = '" & valor & "'"
                Button3.Enabled = True
            ElseIf ComboBox1.Text = "Número de documento" Then
                consulta = "SELECT * FROM CLIENTES WHERE NUM_DOCU = '" & valor & "'"
                Button3.Enabled = True
            End If
        End If


        Try
            da = New OleDb.OleDbDataAdapter(consulta, conexion)
            da.Fill(ds)
            dv.Table = ds.Tables(0)
            DataGridView1.DataSource = dv

        Catch ex As Exception

            MsgBox(ex.Message, vbOKOnly + vbCritical, "¡ERROR!")
        End Try


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        GridAExcel(DataGridView1)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim com As New OleDb.OleDbCommand
        Dim i As Integer = 0

        Dim da As New OleDb.OleDbDataAdapter
        Dim dv As New DataView
        Dim ds As New DataSet


        valor = txt1.Text





        If txt1.Text = "" Then

            If seleccion = "Cédula" Then
                MsgBox("Debe ingresar una cédula si desea eliminar a un cliente", vbOKOnly + vbInformation, "ELIMINAR")
            ElseIf seleccion = "Número de acta" Then
                MsgBox("Debe ingresar un número de acta si desea eliminar a un cliente", vbOKOnly + vbInformation, "ELIMINAR")
            ElseIf seleccion = "Número de documento" Then
                MsgBox("Debe ingresar un número de documento si desea eliminar a un cliente", vbOKOnly + vbInformation, "ELIMINAR")
            End If

        Else

            If seleccion = "Cédula" Then
                consulta = "DELETE FROM CLIENTES WHERE CED = '" & valor & "'"
            ElseIf seleccion = "Número de acta" Then
                consulta = "DELETE FROM CLIENTES WHERE NUM_ACTA = '" & valor & "'"
            ElseIf seleccion = "Número de documento" Then
                consulta = "DELETE FROM CLIENTES WHERE NUM_DOCU = '" & valor & "'"
            End If


            Try
                com = New OleDb.OleDbCommand(consulta, conexion)
                i = com.ExecuteNonQuery()

                If i > 0 Then
                    MsgBox("Se ha eliminado correctamente el registro", vbOKOnly + vbInformation, "ELIMINAR")
                    consulta = "SELECT * FROM CLIENTES"
                    da = New OleDb.OleDbDataAdapter(consulta, conexion)
                    da.Fill(ds)
                    dv.Table = ds.Tables(0)
                    DataGridView1.DataSource = dv
                End If
            Catch ex As Exception
                MsgBox(ex.Message, vbOKOnly + vbCritical, "Error")
            End Try


        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ComboBox1.Text = ""
        txt1.Text = ""
        txt1.Visible = False
        Label2.Visible = False
        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        Button4.Visible = False

        Dim da As New OleDb.OleDbDataAdapter
        Dim dv As New DataView
        Dim ds As New DataSet

        consulta = "SELECT * FROM CLIENTES"

        Try
            da = New OleDb.OleDbDataAdapter(consulta, conexion)
            da.Fill(ds)
            dv.Table = ds.Tables(0)
            DataGridView1.DataSource = dv

        Catch ex As Exception

            MsgBox(ex.Message, vbOKOnly + vbCritical, "¡ERROR!")
        End Try


    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        txt1.Text = ""
        txt1.Visible = True
        Label2.Visible = True
        Button1.Visible = True
        Button2.Visible = True
        Button4.Visible = True
        Button3.Visible = True

        seleccion = ComboBox1.Text

        If ComboBox1.Text = "Cédula" Then
            Label2.Text = "Ingrese la cédula: "
        ElseIf ComboBox1.Text = "Número de acta" Then
            Label2.Text = "Ingrese el número de acta: "
        ElseIf ComboBox1.Text = "Número de documento" Then
            Label2.Text = "Ingrese el número de documento: "

        End If

        Dim da As New OleDb.OleDbDataAdapter
        Dim dv As New DataView
        Dim ds As New DataSet

        consulta = "SELECT * FROM CLIENTES"

        Try
            da = New OleDb.OleDbDataAdapter(consulta, conexion)
            da.Fill(ds)
            dv.Table = ds.Tables(0)
            DataGridView1.DataSource = dv

        Catch ex As Exception

            MsgBox(ex.Message, vbOKOnly + vbCritical, "¡ERROR!")
        End Try




    End Sub

    Private Sub txt1_TextChanged(sender As Object, e As EventArgs) Handles txt1.TextChanged
        If txt1.Text <> "" Then
            Button4.Enabled = True
            Button3.Enabled = True
        Else
            Button4.Enabled = False
            Button3.Enabled = False
        End If
    End Sub
End Class