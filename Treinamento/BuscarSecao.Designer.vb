<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscarSecao
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
        Me.btnSelecionar = New System.Windows.Forms.Button()
        Me.dgvInformacoes = New System.Windows.Forms.DataGridView()
        Me.codEditora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descricaoSecao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvInformacoes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSelecionar
        '
        Me.btnSelecionar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSelecionar.BackColor = System.Drawing.Color.Silver
        Me.btnSelecionar.Location = New System.Drawing.Point(912, 218)
        Me.btnSelecionar.Name = "btnSelecionar"
        Me.btnSelecionar.Size = New System.Drawing.Size(119, 33)
        Me.btnSelecionar.TabIndex = 15
        Me.btnSelecionar.Text = "Selecionar"
        Me.btnSelecionar.UseVisualStyleBackColor = False
        '
        'dgvInformacoes
        '
        Me.dgvInformacoes.AllowUserToAddRows = False
        Me.dgvInformacoes.AllowUserToDeleteRows = False
        Me.dgvInformacoes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvInformacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInformacoes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codEditora, Me.descricaoSecao})
        Me.dgvInformacoes.Location = New System.Drawing.Point(12, 9)
        Me.dgvInformacoes.Name = "dgvInformacoes"
        Me.dgvInformacoes.ReadOnly = True
        Me.dgvInformacoes.Size = New System.Drawing.Size(1019, 203)
        Me.dgvInformacoes.TabIndex = 14
        '
        'codEditora
        '
        Me.codEditora.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.codEditora.DataPropertyName = "codSecao"
        Me.codEditora.HeaderText = "Código da Seção"
        Me.codEditora.Name = "codEditora"
        Me.codEditora.ReadOnly = True
        '
        'descricaoSecao
        '
        Me.descricaoSecao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.descricaoSecao.DataPropertyName = "descricaoSecao"
        Me.descricaoSecao.HeaderText = "Descrição da Seção"
        Me.descricaoSecao.Name = "descricaoSecao"
        Me.descricaoSecao.ReadOnly = True
        '
        'BuscarSecao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1043, 261)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSelecionar)
        Me.Controls.Add(Me.dgvInformacoes)
        Me.Name = "BuscarSecao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar Seção"
        CType(Me.dgvInformacoes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSelecionar As Button
    Friend WithEvents dgvInformacoes As DataGridView
    Friend WithEvents codEditora As DataGridViewTextBoxColumn
    Friend WithEvents descricaoSecao As DataGridViewTextBoxColumn
End Class
