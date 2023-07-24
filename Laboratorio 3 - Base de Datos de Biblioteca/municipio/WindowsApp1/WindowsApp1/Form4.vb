Imports System.Data.OleDb
Public Class Form4


    Dim numDocu As String
    Dim nom1 As String
    Dim nom2 As String
    Dim ape1 As String
    Dim ape2 As String
    Dim ced As String
    Dim dir As String
    Dim cel As Integer
    Dim mon As Double
    Dim obs As String
    Dim act As String
    Dim fec As String


    Private Function Buscar(num As String) As DataRow

        If (String.IsNullOrEmpty(num)) Then
            Throw New ArgumentNullException("id")
        End If
        Dim returnValue As DataRow = Nothing

        Dim da As New OleDb.OleDbDataAdapter
        Dim ds As New DataSet

        consulta = "SELECT * FROM CLIENTES WHERE NUM_DOCU = '" & num & "'"

        da = New OleDb.OleDbDataAdapter(consulta, conexion)
        da.Fill(ds)

        Using dt As New DataTable()
            da.Fill(dt)
            If (dt.Rows.Count > 0) Then
                returnValue = dt.Rows(0)
            End If
        End Using

        Return returnValue

    End Function

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.Hide()

    End Sub

    Private Sub Form4_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Form1.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        numDocu = txtNum.Text

        If txtNum.Text <> "" Then

            txtnom1.Enabled = True
            txtnom2.Enabled = True
            txtape1.Enabled = True
            txtape2.Enabled = True
            txtced.Enabled = True
            txtdir.Enabled = True
            txtMonto.Enabled = True
            txtObser.Enabled = True
            txtActa.Enabled = True
            dtp1.Enabled = True
            txtCel.Enabled = True
            Button1.Enabled = True

            Dim row As DataRow = Buscar(numDocu)
            If row Is Nothing Then
                MsgBox("No hay registros que coincidan con el valor especificado", vbExclamation + vbOKOnly, "ADVERTENCIA")
                txtnom1.Enabled = False
                txtnom2.Enabled = False
                txtape1.Enabled = False
                txtape2.Enabled = False
                txtced.Enabled = False
                txtdir.Enabled = False
                txtMonto.Enabled = False
                txtObser.Enabled = False
                txtActa.Enabled = False
                dtp1.Enabled = False
                txtCel.Enabled = False
                Button1.Enabled = False
                Return
            End If

            txtnom1.Text = Convert.ToString(row("NOM1"))
            txtnom2.Text = Convert.ToString(row("NOM2"))
            txtape1.Text = Convert.ToString(row("APE1"))
            txtape2.Text = Convert.ToString(row("APE2"))
            txtced.Text = Convert.ToString(row("CED"))
            txtdir.Text = Convert.ToString(row("DIR"))
            txtCel.Text = Convert.ToString(row("CEL"))
            txtMonto.Text = CDbl(Convert.ToString(row("MONTO")))
            txtObser.Text = Convert.ToString(row("OBSERVACION"))
            txtActa.Text = Convert.ToString(row("NUM_ACTA"))
            dtp1.Value = CDate(Convert.ToString(row("FECHA")))

        Else

            txtnom1.Enabled = False
            txtnom2.Enabled = False
            txtape1.Enabled = False
            txtape2.Enabled = False
            txtced.Enabled = False
            txtdir.Enabled = False
            txtMonto.Enabled = False
            txtObser.Enabled = False
            txtActa.Enabled = False
            dtp1.Enabled = False
            txtCel.Enabled = False
            Button1.Enabled = False

        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        txtNum.Clear()
        txtnom1.Clear()
        txtnom2.Clear()
        txtape1.Clear()
        txtape2.Clear()
        txtced.Clear()
        txtdir.Clear()
        txtMonto.Clear()
        txtObser.Clear()
        txtActa.Clear()
        dtp1.ResetText()
        txtCel.Clear()


        txtnom1.Enabled = False
        txtnom2.Enabled = False
        txtape1.Enabled = False
        txtape2.Enabled = False
        txtced.Enabled = False
        txtdir.Enabled = False
        txtMonto.Enabled = False
        txtObser.Enabled = False
        txtActa.Enabled = False
        dtp1.Enabled = False
        txtCel.Enabled = False
        Button1.Enabled = False


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim i As Integer = 0
        Dim comando As New OleDb.OleDbCommand

        numDocu = txtNum.Text
        nom1 = txtnom1.Text
        nom2 = txtnom2.Text
        ape1 = txtape1.Text
        ape2 = txtape2.Text
        ced = txtced.Text
        dir = txtdir.Text
        cel = Val(txtCel.Text)
        mon = CDbl(txtMonto.Text)
        obs = txtObser.Text
        act = txtActa.Text
        fec = FormatDateTime(dtp1.Value, DateFormat.ShortDate)

        consulta = "UPDATE CLIENTES SET NOM1 = '" & nom1 & "', NOM2 = '" & nom2 & "', APE1 = '" & ape1 & "', APE2 = '" & ape2 & "', CED = '" & ced & "',  DIR = '" & dir & "', CEL = " & cel & ", MONTO = " & mon & ", OBSERVACION = '" & obs & "', NUM_ACTA = '" & act & "', FECHA = '" & fec & "' WHERE NUM_DOCU = '" & numDocu & "'"

        Try
            comando = New OleDbCommand(consulta, conexion)
            i = comando.ExecuteNonQuery()
            If i > 0 Then
                MsgBox("Se han ingresado correctamente los datos", vbOKOnly + vbInformation, "INGRESAR")
                Button2_Click(sender, e)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "¡ERROR!")
            MsgBox("Estoy aca")
        End Try


    End Sub
End Class