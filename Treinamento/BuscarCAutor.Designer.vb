<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscarCAutor
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
        Me.codAutor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nomAutor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descAutor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvInformacoes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSelecionar
        '
        Me.btnSelecionar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSelecionar.BackColor = System.Drawing.Color.Silver
        Me.btnSelecionar.Location = New System.Drawing.Point(912, 221)
        Me.btnSelecionar.Name = "btnSelecionar"
        Me.btnSelecionar.Size = New System.Drawing.Size(119, 33)
        Me.btnSelecionar.TabIndex = 6
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
        Me.dgvInformacoes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codAutor, Me.nomAutor, Me.descAutor})
        Me.dgvInformacoes.Location = New System.Drawing.Point(12, 12)
        Me.dgvInformacoes.Name = "dgvInformacoes"
        Me.dgvInformacoes.ReadOnly = True
        Me.dgvInformacoes.Size = New System.Drawing.Size(1019, 203)
        Me.dgvInformacoes.TabIndex = 5
        '
        'codAutor
        '
        Me.codAutor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.codAutor.DataPropertyName = "codAutor"
        Me.codAutor.HeaderText = "Código do Autor"
        Me.codAutor.Name = "codAutor"
        Me.codAutor.ReadOnly = True
        '
        'nomAutor
        '
        Me.nomAutor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.nomAutor.DataPropertyName = "nomeAutor"
        Me.nomAutor.HeaderText = "Nome do Autor"
        Me.nomAutor.Name = "nomAutor"
        Me.nomAutor.ReadOnly = True
        '
        'descAutor
        '
        Me.descAutor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.descAutor.DataPropertyName = "descricao"
        Me.descAutor.HeaderText = "Descrição do Autor"
        Me.descAutor.Name = "descAutor"
        Me.descAutor.ReadOnly = True
        '
        'BuscarCAutor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1042, 261)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSelecionar)
        Me.Controls.Add(Me.dgvInformacoes)
        Me.Name = "BuscarCAutor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar Autor"
        CType(Me.dgvInformacoes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSelecionar As Button
    Friend WithEvents dgvInformacoes As DataGridView
    Friend WithEvents codAutor As DataGridViewTextBoxColumn
    Friend WithEvents nomAutor As DataGridViewTextBoxColumn
    Friend WithEvents descAutor As DataGridViewTextBoxColumn
End Class
