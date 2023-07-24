<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Problema4
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Problema4))
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.limpiar = New System.Windows.Forms.Button()
        Me.calcular = New System.Windows.Forms.Button()
        Me.totalB = New System.Windows.Forms.TextBox()
        Me.cargo = New System.Windows.Forms.TextBox()
        Me.distancia = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.horario = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.minutos = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tipo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.errorIc = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.errorIc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(160, 296)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Cerrar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.limpiar)
        Me.GroupBox2.Controls.Add(Me.calcular)
        Me.GroupBox2.Controls.Add(Me.totalB)
        Me.GroupBox2.Controls.Add(Me.cargo)
        Me.GroupBox2.Controls.Add(Me.distancia)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(2, 134)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(392, 155)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cargos"
        '
        'limpiar
        '
        Me.limpiar.Location = New System.Drawing.Point(226, 116)
        Me.limpiar.Name = "limpiar"
        Me.limpiar.Size = New System.Drawing.Size(75, 23)
        Me.limpiar.TabIndex = 9
        Me.limpiar.Text = "Limpiar"
        Me.limpiar.UseVisualStyleBackColor = True
        '
        'calcular
        '
        Me.calcular.Location = New System.Drawing.Point(94, 116)
        Me.calcular.Name = "calcular"
        Me.calcular.Size = New System.Drawing.Size(75, 23)
        Me.calcular.TabIndex = 8
        Me.calcular.Text = "Calcular"
        Me.calcular.UseVisualStyleBackColor = True
        '
        'totalB
        '
        Me.totalB.Location = New System.Drawing.Point(186, 75)
        Me.totalB.Name = "totalB"
        Me.totalB.ReadOnly = True
        Me.totalB.Size = New System.Drawing.Size(121, 20)
        Me.totalB.TabIndex = 7
        '
        'cargo
        '
        Me.cargo.Location = New System.Drawing.Point(186, 49)
        Me.cargo.Name = "cargo"
        Me.cargo.ReadOnly = True
        Me.cargo.Size = New System.Drawing.Size(121, 20)
        Me.cargo.TabIndex = 6
        '
        'distancia
        '
        Me.distancia.Location = New System.Drawing.Point(186, 24)
        Me.distancia.Name = "distancia"
        Me.distancia.ReadOnly = True
        Me.distancia.Size = New System.Drawing.Size(121, 20)
        Me.distancia.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Cargo por horario"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(138, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Minutos gratis por distancia "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Total"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.horario)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.minutos)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.tipo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(392, 116)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información"
        '
        'horario
        '
        Me.horario.FormattingEnabled = True
        Me.horario.Items.AddRange(New Object() {"Mañana (6:00 AM - 11.59 AM)", "Tarde (12:00 PM - 5:59 PM)", "Noche (6:00 PM - 5:59 AM)"})
        Me.horario.Location = New System.Drawing.Point(186, 76)
        Me.horario.Name = "horario"
        Me.horario.Size = New System.Drawing.Size(168, 21)
        Me.horario.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(174, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Horario en que se realizó la llamada"
        '
        'minutos
        '
        Me.minutos.Location = New System.Drawing.Point(186, 51)
        Me.minutos.Name = "minutos"
        Me.minutos.Size = New System.Drawing.Size(168, 20)
        Me.minutos.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Minutos llamados (Mes)"
        '
        'tipo
        '
        Me.tipo.AllowDrop = True
        Me.tipo.FormattingEnabled = True
        Me.tipo.Items.AddRange(New Object() {"Nacional Local", "Larga Distancia Nacional", "Larga Distancia Internacional"})
        Me.tipo.Location = New System.Drawing.Point(186, 22)
        Me.tipo.Name = "tipo"
        Me.tipo.Size = New System.Drawing.Size(168, 21)
        Me.tipo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tipos de Llamadas"
        '
        'errorIc
        '
        Me.errorIc.ContainerControl = Me
        '
        'Problema4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(405, 325)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Problema4"
        Me.Text = "Problema4"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.errorIc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button3 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents limpiar As Button
    Friend WithEvents calcular As Button
    Friend WithEvents totalB As TextBox
    Friend WithEvents cargo As TextBox
    Friend WithEvents distancia As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents horario As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents minutos As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tipo As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents errorIc As ErrorProvider
End Class
