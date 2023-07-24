Imports System.Data.OleDb

Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.Hide()
        'conexion.Open()
    End Sub

    Private Sub Form2_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Form1.Show()
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
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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

        Dim i As Integer = 0

        Dim comando As New OleDb.OleDbCommand

        If (txtNum.Text = "" And txtnom1.Text = "" And txtnom2.Text = "" And txtape1.Text = "" And txtape2.Text = "" And txtced.Text = "" And txtdir.Text = "" And txtCel.Text = "" And txtMonto.Text = "" And txtObser.Text = "" And txtActa.Text = "") Then
            MsgBox("Debe ingresar los datos", vbOKOnly + vbExclamation, "Advertencia")
        Else

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


            consulta = "INSERT INTO CLIENTES(NUM_DOCU, NOM1, NOM2, APE1, APE2, CED, DIR, CEL, MONTO, OBSERVACION, NUM_ACTA, FECHA) VALUES('" & numDocu & "', '" & nom1 & "', '" & nom2 & "', '" & ape1 & "', '" & ape2 & "', '" & ced & "', '" & dir & "', " & cel & ", " & mon & ", '" & obs & "', '" & act & "', '" & fec & "')"



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

        End If





    End Sub
End Class