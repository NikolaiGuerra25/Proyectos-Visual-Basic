<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clientes
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Clientes))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DatosClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._Semestral___HerramientasDataSet = New Semestral___Xoan___Nikolai._Semestral___HerramientasDataSet()
        Me.DatosClienteTableAdapter = New Semestral___Xoan___Nikolai._Semestral___HerramientasDataSetTableAdapters.datosClienteTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.PictureBox()
        Me.exportRDBTN = New System.Windows.Forms.RadioButton()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ResidenciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LugarTrabajoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObservacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatosClienteBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me._Semestral___HerramientasDataSet2 = New Semestral___Xoan___Nikolai._Semestral___HerramientasDataSet2()
        Me.updateRDBTN = New System.Windows.Forms.RadioButton()
        Me.deleteRDBTN = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.insertRDBTN = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DatosClienteBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me._Semestral___HerramientasDataSet1 = New Semestral___Xoan___Nikolai._Semestral___HerramientasDataSet1()
        Me.DatosClienteBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatosClienteTableAdapter1 = New Semestral___Xoan___Nikolai._Semestral___HerramientasDataSet1TableAdapters.datosClienteTableAdapter()
        Me.DatosClienteTableAdapter2 = New Semestral___Xoan___Nikolai._Semestral___HerramientasDataSet2TableAdapters.datosClienteTableAdapter()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtResidencia = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTrabajo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTel1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTel2 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtObservacion = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.actionBTN = New System.Windows.Forms.Button()
        Me.clearBTN = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.DatosClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._Semestral___HerramientasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatosClienteBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._Semestral___HerramientasDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatosClienteBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._Semestral___HerramientasDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatosClienteBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DatosClienteBindingSource
        '
        Me.DatosClienteBindingSource.DataMember = "datosCliente"
        Me.DatosClienteBindingSource.DataSource = Me._Semestral___HerramientasDataSet
        '
        '_Semestral___HerramientasDataSet
        '
        Me._Semestral___HerramientasDataSet.DataSetName = "_Semestral___HerramientasDataSet"
        Me._Semestral___HerramientasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DatosClienteTableAdapter
        '
        Me.DatosClienteTableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.exportRDBTN)
        Me.Panel1.Controls.Add(Me.DataGridView2)
        Me.Panel1.Controls.Add(Me.updateRDBTN)
        Me.Panel1.Controls.Add(Me.deleteRDBTN)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.insertRDBTN)
        Me.Panel1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(2, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(658, 260)
        Me.Panel1.TabIndex = 1
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.Location = New System.Drawing.Point(614, 12)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(30, 26)
        Me.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnClose.TabIndex = 23
        Me.btnClose.TabStop = False
        '
        'exportRDBTN
        '
        Me.exportRDBTN.AutoSize = True
        Me.exportRDBTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.exportRDBTN.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exportRDBTN.ForeColor = System.Drawing.Color.Gainsboro
        Me.exportRDBTN.Location = New System.Drawing.Point(464, 232)
        Me.exportRDBTN.Name = "exportRDBTN"
        Me.exportRDBTN.Size = New System.Drawing.Size(94, 25)
        Me.exportRDBTN.TabIndex = 6
        Me.exportRDBTN.TabStop = True
        Me.exportRDBTN.Text = "Exportar"
        Me.exportRDBTN.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView2.ColumnHeadersHeight = 30
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.ApellidoDataGridViewTextBoxColumn, Me.ResidenciaDataGridViewTextBoxColumn, Me.LugarTrabajoDataGridViewTextBoxColumn, Me.Telefono1DataGridViewTextBoxColumn, Me.Telefono2DataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.ObservacionDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.DatosClienteBindingSource3
        Me.DataGridView2.EnableHeadersVisualStyles = False
        Me.DataGridView2.GridColor = System.Drawing.Color.SteelBlue
        Me.DataGridView2.Location = New System.Drawing.Point(14, 54)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Gainsboro
        Me.DataGridView2.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView2.Size = New System.Drawing.Size(630, 164)
        Me.DataGridView2.TabIndex = 3
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Width = 50
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.Width = 94
        '
        'ApellidoDataGridViewTextBoxColumn
        '
        Me.ApellidoDataGridViewTextBoxColumn.DataPropertyName = "apellido"
        Me.ApellidoDataGridViewTextBoxColumn.HeaderText = "apellido"
        Me.ApellidoDataGridViewTextBoxColumn.Name = "ApellidoDataGridViewTextBoxColumn"
        Me.ApellidoDataGridViewTextBoxColumn.Width = 95
        '
        'ResidenciaDataGridViewTextBoxColumn
        '
        Me.ResidenciaDataGridViewTextBoxColumn.DataPropertyName = "residencia"
        Me.ResidenciaDataGridViewTextBoxColumn.HeaderText = "residencia"
        Me.ResidenciaDataGridViewTextBoxColumn.Name = "ResidenciaDataGridViewTextBoxColumn"
        Me.ResidenciaDataGridViewTextBoxColumn.Width = 112
        '
        'LugarTrabajoDataGridViewTextBoxColumn
        '
        Me.LugarTrabajoDataGridViewTextBoxColumn.DataPropertyName = "lugarTrabajo"
        Me.LugarTrabajoDataGridViewTextBoxColumn.HeaderText = "lugarTrabajo"
        Me.LugarTrabajoDataGridViewTextBoxColumn.Name = "LugarTrabajoDataGridViewTextBoxColumn"
        Me.LugarTrabajoDataGridViewTextBoxColumn.Width = 132
        '
        'Telefono1DataGridViewTextBoxColumn
        '
        Me.Telefono1DataGridViewTextBoxColumn.DataPropertyName = "telefono1"
        Me.Telefono1DataGridViewTextBoxColumn.HeaderText = "telefono1"
        Me.Telefono1DataGridViewTextBoxColumn.Name = "Telefono1DataGridViewTextBoxColumn"
        Me.Telefono1DataGridViewTextBoxColumn.Width = 107
        '
        'Telefono2DataGridViewTextBoxColumn
        '
        Me.Telefono2DataGridViewTextBoxColumn.DataPropertyName = "telefono2"
        Me.Telefono2DataGridViewTextBoxColumn.HeaderText = "telefono2"
        Me.Telefono2DataGridViewTextBoxColumn.Name = "Telefono2DataGridViewTextBoxColumn"
        Me.Telefono2DataGridViewTextBoxColumn.Width = 107
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.Width = 75
        '
        'ObservacionDataGridViewTextBoxColumn
        '
        Me.ObservacionDataGridViewTextBoxColumn.DataPropertyName = "observacion"
        Me.ObservacionDataGridViewTextBoxColumn.HeaderText = "observacion"
        Me.ObservacionDataGridViewTextBoxColumn.Name = "ObservacionDataGridViewTextBoxColumn"
        Me.ObservacionDataGridViewTextBoxColumn.Width = 129
        '
        'DatosClienteBindingSource3
        '
        Me.DatosClienteBindingSource3.DataMember = "datosCliente"
        Me.DatosClienteBindingSource3.DataSource = Me._Semestral___HerramientasDataSet2
        '
        '_Semestral___HerramientasDataSet2
        '
        Me._Semestral___HerramientasDataSet2.DataSetName = "_Semestral___HerramientasDataSet2"
        Me._Semestral___HerramientasDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'updateRDBTN
        '
        Me.updateRDBTN.AutoSize = True
        Me.updateRDBTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.updateRDBTN.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateRDBTN.ForeColor = System.Drawing.Color.Gainsboro
        Me.updateRDBTN.Location = New System.Drawing.Point(218, 232)
        Me.updateRDBTN.Name = "updateRDBTN"
        Me.updateRDBTN.Size = New System.Drawing.Size(108, 25)
        Me.updateRDBTN.TabIndex = 5
        Me.updateRDBTN.TabStop = True
        Me.updateRDBTN.Text = "Actualizar"
        Me.updateRDBTN.UseVisualStyleBackColor = True
        '
        'deleteRDBTN
        '
        Me.deleteRDBTN.AutoSize = True
        Me.deleteRDBTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.deleteRDBTN.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deleteRDBTN.ForeColor = System.Drawing.Color.Gainsboro
        Me.deleteRDBTN.Location = New System.Drawing.Point(358, 232)
        Me.deleteRDBTN.Name = "deleteRDBTN"
        Me.deleteRDBTN.Size = New System.Drawing.Size(73, 25)
        Me.deleteRDBTN.TabIndex = 4
        Me.deleteRDBTN.TabStop = True
        Me.deleteRDBTN.Text = "Borrar"
        Me.deleteRDBTN.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label1.Location = New System.Drawing.Point(315, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Clientes"
        '
        'insertRDBTN
        '
        Me.insertRDBTN.AutoSize = True
        Me.insertRDBTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.insertRDBTN.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.insertRDBTN.ForeColor = System.Drawing.Color.Gainsboro
        Me.insertRDBTN.Location = New System.Drawing.Point(97, 232)
        Me.insertRDBTN.Name = "insertRDBTN"
        Me.insertRDBTN.Size = New System.Drawing.Size(87, 25)
        Me.insertRDBTN.TabIndex = 3
        Me.insertRDBTN.TabStop = True
        Me.insertRDBTN.Text = "Insertar"
        Me.insertRDBTN.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label2.Location = New System.Drawing.Point(16, 277)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ID:"
        '
        'DatosClienteBindingSource1
        '
        Me.DatosClienteBindingSource1.DataMember = "datosCliente"
        Me.DatosClienteBindingSource1.DataSource = Me._Semestral___HerramientasDataSet
        '
        '_Semestral___HerramientasDataSet1
        '
        Me._Semestral___HerramientasDataSet1.DataSetName = "_Semestral___HerramientasDataSet1"
        Me._Semestral___HerramientasDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DatosClienteBindingSource2
        '
        Me.DatosClienteBindingSource2.DataMember = "datosCliente"
        Me.DatosClienteBindingSource2.DataSource = Me._Semestral___HerramientasDataSet1
        '
        'DatosClienteTableAdapter1
        '
        Me.DatosClienteTableAdapter1.ClearBeforeFill = True
        '
        'DatosClienteTableAdapter2
        '
        Me.DatosClienteTableAdapter2.ClearBeforeFill = True
        '
        'txtID
        '
        Me.txtID.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtID.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.ForeColor = System.Drawing.Color.White
        Me.txtID.Location = New System.Drawing.Point(53, 278)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(49, 20)
        Me.txtID.TabIndex = 4
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombre.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.Color.White
        Me.txtNombre.Location = New System.Drawing.Point(99, 317)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(107, 20)
        Me.txtNombre.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label3.Location = New System.Drawing.Point(16, 317)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 21)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Nombre:"
        '
        'txtApellido
        '
        Me.txtApellido.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtApellido.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellido.ForeColor = System.Drawing.Color.White
        Me.txtApellido.Location = New System.Drawing.Point(311, 317)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(107, 20)
        Me.txtApellido.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label4.Location = New System.Drawing.Point(228, 317)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 21)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Apellido:"
        '
        'txtResidencia
        '
        Me.txtResidencia.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtResidencia.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtResidencia.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResidencia.ForeColor = System.Drawing.Color.White
        Me.txtResidencia.Location = New System.Drawing.Point(551, 317)
        Me.txtResidencia.Name = "txtResidencia"
        Me.txtResidencia.Size = New System.Drawing.Size(107, 20)
        Me.txtResidencia.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label5.Location = New System.Drawing.Point(447, 317)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 21)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Residencia:"
        '
        'txtTrabajo
        '
        Me.txtTrabajo.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtTrabajo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTrabajo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTrabajo.ForeColor = System.Drawing.Color.White
        Me.txtTrabajo.Location = New System.Drawing.Point(168, 358)
        Me.txtTrabajo.Name = "txtTrabajo"
        Me.txtTrabajo.Size = New System.Drawing.Size(211, 20)
        Me.txtTrabajo.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label8.Location = New System.Drawing.Point(16, 357)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(146, 21)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Lugar de Trabajo:"
        '
        'txtTel1
        '
        Me.txtTel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtTel1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTel1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTel1.ForeColor = System.Drawing.Color.White
        Me.txtTel1.Location = New System.Drawing.Point(504, 359)
        Me.txtTel1.Name = "txtTel1"
        Me.txtTel1.Size = New System.Drawing.Size(153, 20)
        Me.txtTel1.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label6.Location = New System.Drawing.Point(409, 359)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 21)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Teléfono1:"
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEmail.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.ForeColor = System.Drawing.Color.White
        Me.txtEmail.Location = New System.Drawing.Point(337, 401)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(320, 20)
        Me.txtEmail.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label7.Location = New System.Drawing.Point(276, 401)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 21)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Email:"
        '
        'txtTel2
        '
        Me.txtTel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtTel2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTel2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTel2.ForeColor = System.Drawing.Color.White
        Me.txtTel2.Location = New System.Drawing.Point(111, 401)
        Me.txtTel2.Name = "txtTel2"
        Me.txtTel2.Size = New System.Drawing.Size(137, 20)
        Me.txtTel2.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label9.Location = New System.Drawing.Point(16, 401)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 21)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Teléfono2:"
        '
        'txtObservacion
        '
        Me.txtObservacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtObservacion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtObservacion.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservacion.ForeColor = System.Drawing.Color.White
        Me.txtObservacion.Location = New System.Drawing.Point(136, 446)
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Size = New System.Drawing.Size(521, 20)
        Me.txtObservacion.TabIndex = 20
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label10.Location = New System.Drawing.Point(16, 446)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(114, 21)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Observación:"
        '
        'actionBTN
        '
        Me.actionBTN.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.actionBTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.actionBTN.FlatAppearance.BorderSize = 0
        Me.actionBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.actionBTN.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.actionBTN.ForeColor = System.Drawing.Color.Gainsboro
        Me.actionBTN.Location = New System.Drawing.Point(543, 482)
        Me.actionBTN.Name = "actionBTN"
        Me.actionBTN.Size = New System.Drawing.Size(114, 38)
        Me.actionBTN.TabIndex = 21
        Me.actionBTN.UseVisualStyleBackColor = False
        '
        'clearBTN
        '
        Me.clearBTN.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.clearBTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.clearBTN.FlatAppearance.BorderSize = 0
        Me.clearBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.clearBTN.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearBTN.ForeColor = System.Drawing.Color.Gainsboro
        Me.clearBTN.Location = New System.Drawing.Point(369, 482)
        Me.clearBTN.Name = "clearBTN"
        Me.clearBTN.Size = New System.Drawing.Size(147, 38)
        Me.clearBTN.TabIndex = 22
        Me.clearBTN.Text = "Limpiar Campos"
        Me.clearBTN.UseVisualStyleBackColor = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(881, 650)
        Me.Controls.Add(Me.clearBTN)
        Me.Controls.Add(Me.actionBTN)
        Me.Controls.Add(Me.txtObservacion)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtTel2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtTel1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtTrabajo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtResidencia)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Clientes"
        Me.Text = "Clientes"
        CType(Me.DatosClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._Semestral___HerramientasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatosClienteBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._Semestral___HerramientasDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatosClienteBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._Semestral___HerramientasDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatosClienteBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents _Semestral___HerramientasDataSet As _Semestral___HerramientasDataSet
    Friend WithEvents DatosClienteBindingSource As BindingSource
    Friend WithEvents DatosClienteTableAdapter As _Semestral___HerramientasDataSetTableAdapters.datosClienteTableAdapter
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents insertRDBTN As RadioButton
    Friend WithEvents deleteRDBTN As RadioButton
    Friend WithEvents updateRDBTN As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents DatosClienteBindingSource1 As BindingSource
    Friend WithEvents _Semestral___HerramientasDataSet1 As _Semestral___HerramientasDataSet1
    Friend WithEvents DatosClienteBindingSource2 As BindingSource
    Friend WithEvents DatosClienteTableAdapter1 As _Semestral___HerramientasDataSet1TableAdapters.datosClienteTableAdapter
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents _Semestral___HerramientasDataSet2 As _Semestral___HerramientasDataSet2
    Friend WithEvents DatosClienteBindingSource3 As BindingSource
    Friend WithEvents DatosClienteTableAdapter2 As _Semestral___HerramientasDataSet2TableAdapters.datosClienteTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApellidoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ResidenciaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LugarTrabajoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Telefono1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Telefono2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ObservacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtResidencia As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTrabajo As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtTel1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtTel2 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtObservacion As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents actionBTN As Button
    Friend WithEvents clearBTN As Button
    Friend WithEvents exportRDBTN As RadioButton
    Friend WithEvents btnClose As PictureBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
