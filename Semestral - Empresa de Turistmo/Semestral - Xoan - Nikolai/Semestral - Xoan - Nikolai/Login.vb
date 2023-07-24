Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Public Class Login

#Region "Form Behaviors"
    'Cerrar'
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    'Minimizar'
    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
#End Region

#Region "Drag Form"
    'Importar Librerias'
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()

    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)

    End Sub

    'Mover Barra'
    Private Sub TitleBar_MouseMove(sender As Object, e As MouseEventArgs) Handles TitleBar.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    'Mover Cuerpo'
    Private Sub Login_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
#End Region

#Region "Customize Controls"

    'Tamaño del txtBox'
    Private Sub CustomizeComponents()
        'txtUser'
        txtUser.AutoSize = False
        txtUser.Size = New Size(276, 29)

        'txtPass'
        txtPass.AutoSize = False
        txtPass.Size = New Size(276, 29)
        txtPass.UseSystemPasswordChar = True
    End Sub

    'Forma Boton'
    Private Sub Button1_Paint(sender As Object, e As PaintEventArgs) Handles Button1.Paint
        Dim buttonPath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim myRectangle As Rectangle = Button1.ClientRectangle
        myRectangle.Inflate(0, 35)
        buttonPath.AddEllipse(myRectangle)
        Button1.Region = New Region(buttonPath)
    End Sub
#End Region

    'Iniciar los Controles Custom'
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        CustomizeComponents()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'Boton Login'
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dataR, dataR2 As SqlDataReader
        Dim con As New SqlConnection("Data Source=DESKTOP-9GE5BJ5;Initial Catalog=Semestral - Herramientas;Integrated Security=True")
        Dim consulta, consulta2 As String
        con.Open()

        If txtPass.Text = "" Or txtUser.Text = "" Then
            Label3.Text = "ERROR: No se aceptan campos vacíos"
        Else
            consulta = "Select * From loginColaborador where Usuario='" & txtUser.Text & "' And Contra='" & txtPass.Text & "'"
            consulta2 = "Select * From loginAdmin where Usuario='" & txtUser.Text & "' And Contra='" & txtPass.Text & "'"
            Dim comando As New SqlCommand(consulta, con)
            Dim comando2 As New SqlCommand(consulta2, con)
            dataR = comando.ExecuteReader

            If dataR.Read() Then
                'Abrir'
                Me.Hide()
                userTXT.colaboradorTXT = txtUser.Text
                IDColaborador.colaborador = True
                colaboradorMenu.Show()

                'Recordarme'
                If CheckBox1.Checked = True Then
                    txtPass.Clear()
                End If
                If CheckBox1.Checked = False Then
                    AutoClear()
                End If
            Else
                dataR.Close()
                dataR2 = comando2.ExecuteReader()
                If dataR2.Read() Then
                    'Abrir'
                    Me.Hide()
                    adminTXT.Finanzbuchhalter = txtUser.Text
                    IDAdmin.admin = True
                    colaboradorMenu.Show()

                    'Recordarme'
                    If CheckBox1.Checked = True Then
                        txtPass.Clear()
                    End If
                    If CheckBox1.Checked = False Then
                        AutoClear()
                    End If
                Else
                    dataR2.Close()
                    Label3.Text = "ERROR: Admin / Cliente no válido"
                End If
            End If
        End If
    End Sub

    'Limpiar Auto'
    Private Sub AutoClear()
        txtPass.Clear()
        txtUser.Clear()
    End Sub
End Class
