Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Public Class colaboradorMenu
    Private Sub colaboradorMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Cerrar Forms'
        Clientes.Close()
        promAdmin.Close()
        promColaborador.Close()
        Proveedores.Close()
        servColaborador.Close()
        servAdmin.Close()
        inventarios.Close()

        'Indicar de Sesion User'
        If IDColaborador.colaborador = True And IDAdmin.admin = False Then
            Label2.Text = userTXT.colaboradorTXT
        End If

        'Indicar de Sesion Admin'
        If IDColaborador.colaborador = False And IDAdmin.admin = True Then
            Label2.Text = adminTXT.Finanzbuchhalter
        End If
    End Sub

#Region "Form Behaviors"
    'Cerrar Form'
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    'Minimizar Form'
    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
#End Region

#Region "Drag Form"
    'Importar librerias'
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
    Private Sub colaboradorMenu_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
#End Region

    'Abrir Forms Dentro del Panel'
    Private currentForm As Form = Nothing
    Private Sub openChildForm(childForm As Form)
        If currentForm IsNot Nothing Then currentForm.Close()
        currentForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelChildForm.Controls.Add(childForm)
        PanelChildForm.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub

#Region "Abrir/Cerrar Forms"
    'Clientes'
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        openChildForm(New Clientes())
    End Sub

    'Colaborador'
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Abrir Form Colaborador'
        If IDColaborador.colaborador = True And IDAdmin.admin = False Then
            openChildForm(New promColaborador())
        End If

        'Abrir Form Admin'
        If IDColaborador.colaborador = False And IDAdmin.admin = True Then
            openChildForm(New promAdmin())
        End If
    End Sub

    'Proveedores'
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        openChildForm(New Proveedores())
    End Sub

    'Servicios'
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'Abrir Form Colaborador'
        If IDColaborador.colaborador = True And IDAdmin.admin = False Then
            openChildForm(New servColaborador())
        End If

        'Abrir Form Admin'
        If IDColaborador.colaborador = False And IDAdmin.admin = True Then
            openChildForm(New servAdmin())
        End If
    End Sub

    'Inventarios'
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        openChildForm(New inventarios())
    End Sub

    'Cerrar Sesion'
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        'Cerrar Forms'
        Clientes.Close()
        promAdmin.Close()
        promColaborador.Close()
        Proveedores.Close()
        servColaborador.Close()
        servAdmin.Close()
        inventarios.Close()

        'Salir / Reset Condiciones'
        Me.Close()
        Login.Show()
        IDAdmin.admin = False
        IDColaborador.colaborador = False
    End Sub
#End Region
End Class