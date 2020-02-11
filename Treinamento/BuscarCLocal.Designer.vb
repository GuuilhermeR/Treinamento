<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BuscarCLocal
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
        Me.dgvInformacoes = New System.Windows.Forms.DataGridView()
        Me.codLocal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descricaoLocal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSelecionar = New System.Windows.Forms.Button()
        CType(Me.dgvInformacoes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvInformacoes
        '
        Me.dgvInformacoes.AllowUserToAddRows = False
        Me.dgvInformacoes.AllowUserToDeleteRows = False
        Me.dgvInformacoes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvInformacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInformacoes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codLocal, Me.descricaoLocal})
        Me.dgvInformacoes.Location = New System.Drawing.Point(12, 12)
        Me.dgvInformacoes.Name = "dgvInformacoes"
        Me.dgvInformacoes.ReadOnly = True
        Me.dgvInformacoes.Size = New System.Drawing.Size(1030, 203)
        Me.dgvInformacoes.TabIndex = 2
        '
        'codLocal
        '
        Me.codLocal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.codLocal.DataPropertyName = "codLocal"
        Me.codLocal.HeaderText = "Código Local"
        Me.codLocal.Name = "codLocal"
        Me.codLocal.ReadOnly = True
        '
        'descricaoLocal
        '
        Me.descricaoLocal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.descricaoLocal.DataPropertyName = "descricaoLocal"
        Me.descricaoLocal.HeaderText = "Descrição do Local"
        Me.descricaoLocal.Name = "descricaoLocal"
        Me.descricaoLocal.ReadOnly = True
        '
        'btnSelecionar
        '
        Me.btnSelecionar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSelecionar.BackColor = System.Drawing.Color.Silver
        Me.btnSelecionar.Location = New System.Drawing.Point(923, 221)
        Me.btnSelecionar.Name = "btnSelecionar"
        Me.btnSelecionar.Size = New System.Drawing.Size(119, 33)
        Me.btnSelecionar.TabIndex = 4
        Me.btnSelecionar.Text = "Selecionar"
        Me.btnSelecionar.UseVisualStyleBackColor = False
        '
        'BuscarCLocal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1053, 261)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSelecionar)
        Me.Controls.Add(Me.dgvInformacoes)
        Me.Name = "BuscarCLocal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar Local"
        CType(Me.dgvInformacoes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvInformacoes As DataGridView
    Friend WithEvents btnSelecionar As Button
    Friend WithEvents codLocal As DataGridViewTextBoxColumn
    Friend WithEvents descricaoLocal As DataGridViewTextBoxColumn
End Class
