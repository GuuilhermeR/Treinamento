<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PesquisarItemEmprestado
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnSelecionar = New System.Windows.Forms.Button()
        Me.dgvInformacoes = New System.Windows.Forms.DataGridView()
        Me.CItemI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nItemI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nExmplarI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tItemI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.localizI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codLeitorI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nLeitorI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataReseI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.praReservaI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvInformacoes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSelecionar
        '
        Me.btnSelecionar.BackColor = System.Drawing.Color.Silver
        Me.btnSelecionar.Location = New System.Drawing.Point(1089, 218)
        Me.btnSelecionar.Name = "btnSelecionar"
        Me.btnSelecionar.Size = New System.Drawing.Size(119, 33)
        Me.btnSelecionar.TabIndex = 10
        Me.btnSelecionar.Text = "Selecionar"
        Me.btnSelecionar.UseVisualStyleBackColor = False
        '
        'dgvInformacoes
        '
        Me.dgvInformacoes.AllowUserToAddRows = False
        Me.dgvInformacoes.AllowUserToDeleteRows = False
        Me.dgvInformacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInformacoes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CItemI, Me.nItemI, Me.nExmplarI, Me.tItemI, Me.localizI, Me.codLeitorI, Me.nLeitorI, Me.dataReseI, Me.praReservaI})
        Me.dgvInformacoes.Location = New System.Drawing.Point(12, 9)
        Me.dgvInformacoes.Name = "dgvInformacoes"
        Me.dgvInformacoes.ReadOnly = True
        Me.dgvInformacoes.Size = New System.Drawing.Size(1196, 203)
        Me.dgvInformacoes.TabIndex = 9
        '
        'CItemI
        '
        Me.CItemI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.CItemI.DataPropertyName = "codItem"
        Me.CItemI.HeaderText = "Código do Item"
        Me.CItemI.Name = "CItemI"
        Me.CItemI.ReadOnly = True
        Me.CItemI.Width = 77
        '
        'nItemI
        '
        Me.nItemI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.nItemI.DataPropertyName = "nomeItem"
        Me.nItemI.HeaderText = "Nome Item"
        Me.nItemI.Name = "nItemI"
        Me.nItemI.ReadOnly = True
        Me.nItemI.Width = 77
        '
        'nExmplarI
        '
        Me.nExmplarI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.nExmplarI.DataPropertyName = "numExemplar"
        Me.nExmplarI.HeaderText = "Número Exemplar"
        Me.nExmplarI.Name = "nExmplarI"
        Me.nExmplarI.ReadOnly = True
        Me.nExmplarI.Width = 105
        '
        'tItemI
        '
        Me.tItemI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.tItemI.DataPropertyName = "tipoItem"
        Me.tItemI.HeaderText = "Tipo Item"
        Me.tItemI.Name = "tItemI"
        Me.tItemI.ReadOnly = True
        Me.tItemI.Width = 70
        '
        'localizI
        '
        Me.localizI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.localizI.DataPropertyName = "localizacao"
        Me.localizI.HeaderText = "Localização"
        Me.localizI.Name = "localizI"
        Me.localizI.ReadOnly = True
        Me.localizI.Width = 89
        '
        'codLeitorI
        '
        Me.codLeitorI.DataPropertyName = "codLeitor"
        Me.codLeitorI.HeaderText = "Código do Leitor"
        Me.codLeitorI.Name = "codLeitorI"
        Me.codLeitorI.ReadOnly = True
        '
        'nLeitorI
        '
        Me.nLeitorI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.nLeitorI.DataPropertyName = "nomeLeitor"
        Me.nLeitorI.HeaderText = "Nome do Leitor"
        Me.nLeitorI.Name = "nLeitorI"
        Me.nLeitorI.ReadOnly = True
        Me.nLeitorI.Width = 96
        '
        'dataReseI
        '
        Me.dataReseI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dataReseI.DataPropertyName = "dataReserva"
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.dataReseI.DefaultCellStyle = DataGridViewCellStyle1
        Me.dataReseI.HeaderText = "Data reserva"
        Me.dataReseI.Name = "dataReseI"
        Me.dataReseI.ReadOnly = True
        Me.dataReseI.Width = 86
        '
        'praReservaI
        '
        Me.praReservaI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.praReservaI.DataPropertyName = "prazoReserva"
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.praReservaI.DefaultCellStyle = DataGridViewCellStyle2
        Me.praReservaI.HeaderText = "Prazo da Reserva"
        Me.praReservaI.Name = "praReservaI"
        Me.praReservaI.ReadOnly = True
        Me.praReservaI.Width = 107
        '
        'PesquisarItemEmprestado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1220, 261)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSelecionar)
        Me.Controls.Add(Me.dgvInformacoes)
        Me.Name = "PesquisarItemEmprestado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PesquisarItemEmprestado"
        CType(Me.dgvInformacoes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSelecionar As Button
    Friend WithEvents dgvInformacoes As DataGridView
    Friend WithEvents CItemI As DataGridViewTextBoxColumn
    Friend WithEvents nItemI As DataGridViewTextBoxColumn
    Friend WithEvents nExmplarI As DataGridViewTextBoxColumn
    Friend WithEvents tItemI As DataGridViewTextBoxColumn
    Friend WithEvents localizI As DataGridViewTextBoxColumn
    Friend WithEvents codLeitorI As DataGridViewTextBoxColumn
    Friend WithEvents nLeitorI As DataGridViewTextBoxColumn
    Friend WithEvents dataReseI As DataGridViewTextBoxColumn
    Friend WithEvents praReservaI As DataGridViewTextBoxColumn
End Class
