<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CadastrarColecao
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCodg = New System.Windows.Forms.TextBox()
        Me.txtNomeColecao = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnVoltar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.dgvInformacoes = New System.Windows.Forms.DataGridView()
        Me.codColecao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nomeColecao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnLimpa = New System.Windows.Forms.Button()
        CType(Me.dgvInformacoes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(61, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código:"
        '
        'txtCodg
        '
        Me.txtCodg.BackColor = System.Drawing.Color.DarkGray
        Me.txtCodg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodg.Location = New System.Drawing.Point(64, 56)
        Me.txtCodg.Name = "txtCodg"
        Me.txtCodg.Size = New System.Drawing.Size(94, 20)
        Me.txtCodg.TabIndex = 11
        '
        'txtNomeColecao
        '
        Me.txtNomeColecao.BackColor = System.Drawing.Color.DarkGray
        Me.txtNomeColecao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomeColecao.Location = New System.Drawing.Point(64, 133)
        Me.txtNomeColecao.Name = "txtNomeColecao"
        Me.txtNomeColecao.Size = New System.Drawing.Size(424, 20)
        Me.txtNomeColecao.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(61, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Nome da coleção:"
        '
        'btnVoltar
        '
        Me.btnVoltar.BackColor = System.Drawing.Color.Silver
        Me.btnVoltar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVoltar.Location = New System.Drawing.Point(12, 206)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Size = New System.Drawing.Size(104, 34)
        Me.btnVoltar.TabIndex = 58
        Me.btnVoltar.Text = "Voltar"
        Me.btnVoltar.UseVisualStyleBackColor = False
        '
        'btnExcluir
        '
        Me.btnExcluir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluir.BackColor = System.Drawing.Color.Silver
        Me.btnExcluir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcluir.ForeColor = System.Drawing.Color.Red
        Me.btnExcluir.Location = New System.Drawing.Point(1454, 206)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(112, 34)
        Me.btnExcluir.TabIndex = 59
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = False
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvar.BackColor = System.Drawing.Color.Silver
        Me.btnSalvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalvar.ForeColor = System.Drawing.Color.Green
        Me.btnSalvar.Location = New System.Drawing.Point(1336, 206)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(112, 34)
        Me.btnSalvar.TabIndex = 60
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.UseVisualStyleBackColor = False
        '
        'dgvInformacoes
        '
        Me.dgvInformacoes.AllowUserToAddRows = False
        Me.dgvInformacoes.AllowUserToDeleteRows = False
        Me.dgvInformacoes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvInformacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInformacoes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codColecao, Me.nomeColecao})
        Me.dgvInformacoes.Location = New System.Drawing.Point(12, 260)
        Me.dgvInformacoes.Name = "dgvInformacoes"
        Me.dgvInformacoes.ReadOnly = True
        Me.dgvInformacoes.Size = New System.Drawing.Size(1554, 533)
        Me.dgvInformacoes.TabIndex = 61
        '
        'codColecao
        '
        Me.codColecao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.codColecao.DataPropertyName = "codColecao"
        Me.codColecao.HeaderText = "Código"
        Me.codColecao.Name = "codColecao"
        Me.codColecao.ReadOnly = True
        Me.codColecao.Width = 65
        '
        'nomeColecao
        '
        Me.nomeColecao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.nomeColecao.DataPropertyName = "nomeColecao"
        Me.nomeColecao.HeaderText = "Coleção"
        Me.nomeColecao.Name = "nomeColecao"
        Me.nomeColecao.ReadOnly = True
        Me.nomeColecao.Width = 71
        '
        'btnLimpa
        '
        Me.btnLimpa.BackColor = System.Drawing.Color.Silver
        Me.btnLimpa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpa.Location = New System.Drawing.Point(573, 206)
        Me.btnLimpa.Name = "btnLimpa"
        Me.btnLimpa.Size = New System.Drawing.Size(337, 34)
        Me.btnLimpa.TabIndex = 62
        Me.btnLimpa.Text = "Limpar infos"
        Me.btnLimpa.UseVisualStyleBackColor = False
        '
        'CadastrarColecao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1578, 805)
        Me.Controls.Add(Me.btnLimpa)
        Me.Controls.Add(Me.dgvInformacoes)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.btnVoltar)
        Me.Controls.Add(Me.txtNomeColecao)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCodg)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CadastrarColecao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastrar Coleção"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvInformacoes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtCodg As TextBox
    Friend WithEvents txtNomeColecao As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnVoltar As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btnSalvar As Button
    Friend WithEvents dgvInformacoes As DataGridView
    Friend WithEvents btnLimpa As Button
    Friend WithEvents codColecao As DataGridViewTextBoxColumn
    Friend WithEvents nomeColecao As DataGridViewTextBoxColumn
End Class
