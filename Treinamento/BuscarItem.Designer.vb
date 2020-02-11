<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BuscarItem
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
        Me.btnSelecionar = New System.Windows.Forms.Button()
        Me.dgvInformacoes = New System.Windows.Forms.DataGridView()
        Me.cItemI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nomeItemI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numExemplarI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipoItemI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.localizacaoI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvInformacoes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSelecionar
        '
        Me.btnSelecionar.BackColor = System.Drawing.Color.Silver
        Me.btnSelecionar.Location = New System.Drawing.Point(1268, 221)
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
        Me.dgvInformacoes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cItemI, Me.nomeItemI, Me.numExemplarI, Me.tipoItemI, Me.localizacaoI})
        Me.dgvInformacoes.Location = New System.Drawing.Point(12, 12)
        Me.dgvInformacoes.Name = "dgvInformacoes"
        Me.dgvInformacoes.ReadOnly = True
        Me.dgvInformacoes.Size = New System.Drawing.Size(1375, 203)
        Me.dgvInformacoes.TabIndex = 9
        '
        'cItemI
        '
        Me.cItemI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.cItemI.DataPropertyName = "codItem"
        Me.cItemI.HeaderText = "Código Item"
        Me.cItemI.Name = "cItemI"
        Me.cItemI.ReadOnly = True
        Me.cItemI.Width = 81
        '
        'nomeItemI
        '
        Me.nomeItemI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.nomeItemI.DataPropertyName = "nomeItem"
        Me.nomeItemI.HeaderText = "Nome Item"
        Me.nomeItemI.Name = "nomeItemI"
        Me.nomeItemI.ReadOnly = True
        Me.nomeItemI.Width = 77
        '
        'numExemplarI
        '
        Me.numExemplarI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.numExemplarI.DataPropertyName = "numExemplar"
        Me.numExemplarI.HeaderText = "Número do Exemplar"
        Me.numExemplarI.Name = "numExemplarI"
        Me.numExemplarI.ReadOnly = True
        Me.numExemplarI.Width = 119
        '
        'tipoItemI
        '
        Me.tipoItemI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.tipoItemI.DataPropertyName = "tipoItem"
        Me.tipoItemI.HeaderText = "Tipo do Item"
        Me.tipoItemI.Name = "tipoItemI"
        Me.tipoItemI.ReadOnly = True
        Me.tipoItemI.Width = 84
        '
        'localizacaoI
        '
        Me.localizacaoI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.localizacaoI.DataPropertyName = "localizacao"
        Me.localizacaoI.HeaderText = "Localização"
        Me.localizacaoI.Name = "localizacaoI"
        Me.localizacaoI.ReadOnly = True
        Me.localizacaoI.Width = 89
        '
        'BuscarItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1399, 261)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSelecionar)
        Me.Controls.Add(Me.dgvInformacoes)
        Me.Name = "BuscarItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar Item"
        CType(Me.dgvInformacoes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSelecionar As Button
    Friend WithEvents dgvInformacoes As DataGridView
    Friend WithEvents cItemI As DataGridViewTextBoxColumn
    Friend WithEvents nomeItemI As DataGridViewTextBoxColumn
    Friend WithEvents numExemplarI As DataGridViewTextBoxColumn
    Friend WithEvents tipoItemI As DataGridViewTextBoxColumn
    Friend WithEvents localizacaoI As DataGridViewTextBoxColumn
End Class
