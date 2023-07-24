Public Class Form1
    Private Sub Problema1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Problema1ToolStripMenuItem.Click
        Problema1.ShowDialog()
    End Sub

    Private Sub Problema2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Problema2ToolStripMenuItem.Click
        Problema2.ShowDialog()
    End Sub

    Private Sub Problema3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Problema3ToolStripMenuItem.Click
        Problema3.ShowDialog()
    End Sub

    Private Sub Problema4ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Problema4ToolStripMenuItem.Click
        Problema4.ShowDialog()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub TipsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipsToolStripMenuItem.Click
        Tips.ShowDialog()
    End Sub

    Private Sub NoVersionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NoVersionToolStripMenuItem.Click
        MsgBox("Version 1.0.1" & vbNewLine & vbNewLine & "Creadores: Nikolai Guerra - Jahir Castillo" & vbNewLine & vbNewLine & "Copyright © 2022", vbInformation, "Version")
    End Sub



    Private Sub EmpresaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EmpresaToolStripMenuItem1.Click
        Empresa.ShowDialog()
    End Sub


End Class
