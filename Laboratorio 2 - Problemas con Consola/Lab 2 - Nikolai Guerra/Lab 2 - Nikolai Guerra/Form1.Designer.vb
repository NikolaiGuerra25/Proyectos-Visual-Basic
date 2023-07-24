<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Problema1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Problema2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Problema3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Problema4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VersionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NoVersionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpresaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpresaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.AyudaToolStripMenuItem, Me.VersionToolStripMenuItem, Me.EmpresaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(837, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Problema1ToolStripMenuItem, Me.Problema2ToolStripMenuItem, Me.Problema3ToolStripMenuItem, Me.Problema4ToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'Problema1ToolStripMenuItem
        '
        Me.Problema1ToolStripMenuItem.Image = CType(resources.GetObject("Problema1ToolStripMenuItem.Image"), System.Drawing.Image)
        Me.Problema1ToolStripMenuItem.Name = "Problema1ToolStripMenuItem"
        Me.Problema1ToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.Problema1ToolStripMenuItem.Text = "Problema 1"
        '
        'Problema2ToolStripMenuItem
        '
        Me.Problema2ToolStripMenuItem.Image = CType(resources.GetObject("Problema2ToolStripMenuItem.Image"), System.Drawing.Image)
        Me.Problema2ToolStripMenuItem.Name = "Problema2ToolStripMenuItem"
        Me.Problema2ToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.Problema2ToolStripMenuItem.Text = "Problema 2"
        '
        'Problema3ToolStripMenuItem
        '
        Me.Problema3ToolStripMenuItem.Image = CType(resources.GetObject("Problema3ToolStripMenuItem.Image"), System.Drawing.Image)
        Me.Problema3ToolStripMenuItem.Name = "Problema3ToolStripMenuItem"
        Me.Problema3ToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.Problema3ToolStripMenuItem.Text = "Problema 3"
        '
        'Problema4ToolStripMenuItem
        '
        Me.Problema4ToolStripMenuItem.Image = CType(resources.GetObject("Problema4ToolStripMenuItem.Image"), System.Drawing.Image)
        Me.Problema4ToolStripMenuItem.Name = "Problema4ToolStripMenuItem"
        Me.Problema4ToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.Problema4ToolStripMenuItem.Text = "Problema 4"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Image = CType(resources.GetObject("SalirToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TipsToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'TipsToolStripMenuItem
        '
        Me.TipsToolStripMenuItem.Image = CType(resources.GetObject("TipsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TipsToolStripMenuItem.Name = "TipsToolStripMenuItem"
        Me.TipsToolStripMenuItem.Size = New System.Drawing.Size(95, 22)
        Me.TipsToolStripMenuItem.Text = "Tips"
        '
        'VersionToolStripMenuItem
        '
        Me.VersionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NoVersionToolStripMenuItem})
        Me.VersionToolStripMenuItem.Name = "VersionToolStripMenuItem"
        Me.VersionToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.VersionToolStripMenuItem.Text = "Version"
        '
        'NoVersionToolStripMenuItem
        '
        Me.NoVersionToolStripMenuItem.Image = CType(resources.GetObject("NoVersionToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NoVersionToolStripMenuItem.Name = "NoVersionToolStripMenuItem"
        Me.NoVersionToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.NoVersionToolStripMenuItem.Text = "No. Version"
        '
        'EmpresaToolStripMenuItem
        '
        Me.EmpresaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmpresaToolStripMenuItem1})
        Me.EmpresaToolStripMenuItem.Name = "EmpresaToolStripMenuItem"
        Me.EmpresaToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.EmpresaToolStripMenuItem.Text = "Empresa"
        '
        'EmpresaToolStripMenuItem1
        '
        Me.EmpresaToolStripMenuItem1.Image = CType(resources.GetObject("EmpresaToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.EmpresaToolStripMenuItem1.Name = "EmpresaToolStripMenuItem1"
        Me.EmpresaToolStripMenuItem1.Size = New System.Drawing.Size(119, 22)
        Me.EmpresaToolStripMenuItem1.Text = "Empresa"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(837, 441)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(837, 443)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(837, 466)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Laboratorio Practico 2"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Problema1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Problema2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Problema3ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Problema4ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TipsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VersionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpresaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NoVersionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents EmpresaToolStripMenuItem1 As ToolStripMenuItem
End Class
