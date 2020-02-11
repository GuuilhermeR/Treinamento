<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ConsultaEmprestimo
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
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.btnVoltar = New System.Windows.Forms.Button()
        Me.dgvInformacoes = New System.Windows.Forms.DataGridView()
        Me.codEmprestimo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nomeItem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipoItem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descricaoLocal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nomeAutor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.secao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataEmprestimo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataDevolucao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtNomeLeitor = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPrazoDevolucao = New System.Windows.Forms.DateTimePicker()
        Me.txtNomeItm = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.dgvInformacoes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnConsultar
        '
        Me.btnConsultar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnConsultar.BackColor = System.Drawing.Color.Silver
        Me.btnConsultar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultar.ForeColor = System.Drawing.Color.Green
        Me.btnConsultar.Location = New System.Drawing.Point(1144, 104)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(144, 34)
        Me.btnConsultar.TabIndex = 64
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.UseVisualStyleBackColor = False
        '
        'btnVoltar
        '
        Me.btnVoltar.BackColor = System.Drawing.Color.Silver
        Me.btnVoltar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVoltar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnVoltar.Location = New System.Drawing.Point(12, 104)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Size = New System.Drawing.Size(144, 34)
        Me.btnVoltar.TabIndex = 65
        Me.btnVoltar.Text = "Voltar"
        Me.btnVoltar.UseVisualStyleBackColor = False
        '
        'dgvInformacoes
        '
        Me.dgvInformacoes.AllowUserToAddRows = False
        Me.dgvInformacoes.AllowUserToDeleteRows = False
        Me.dgvInformacoes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvInformacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInformacoes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codEmprestimo, Me.nomeItem, Me.tipoItem, Me.descricaoLocal, Me.nomeAutor, Me.nome, Me.secao, Me.dataEmprestimo, Me.dataDevolucao, Me.status})
        Me.dgvInformacoes.Location = New System.Drawing.Point(12, 144)
        Me.dgvInformacoes.Name = "dgvInformacoes"
        Me.dgvInformacoes.ReadOnly = True
        Me.dgvInformacoes.Size = New System.Drawing.Size(1276, 284)
        Me.dgvInformacoes.TabIndex = 70
        '
        'codEmprestimo
        '
        Me.codEmprestimo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.codEmprestimo.DataPropertyName = "codEmprestimo"
        Me.codEmprestimo.HeaderText = "Código do Empréstimo"
        Me.codEmprestimo.Name = "codEmprestimo"
        Me.codEmprestimo.ReadOnly = True
        Me.codEmprestimo.Width = 125
        '
        'nomeItem
        '
        Me.nomeItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.nomeItem.DataPropertyName = "nomeItem"
        Me.nomeItem.HeaderText = "Nome do Item"
        Me.nomeItem.Name = "nomeItem"
        Me.nomeItem.ReadOnly = True
        Me.nomeItem.Width = 72
        '
        'tipoItem
        '
        Me.tipoItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.tipoItem.DataPropertyName = "tipoItem"
        Me.tipoItem.HeaderText = "Tipo do Item"
        Me.tipoItem.Name = "tipoItem"
        Me.tipoItem.ReadOnly = True
        Me.tipoItem.Width = 84
        '
        'descricaoLocal
        '
        Me.descricaoLocal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.descricaoLocal.DataPropertyName = "descricaoLocal"
        Me.descricaoLocal.HeaderText = "Descrição do Local"
        Me.descricaoLocal.Name = "descricaoLocal"
        Me.descricaoLocal.ReadOnly = True
        Me.descricaoLocal.Width = 90
        '
        'nomeAutor
        '
        Me.nomeAutor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.nomeAutor.DataPropertyName = "nomeAutor"
        Me.nomeAutor.HeaderText = "Nome do autor"
        Me.nomeAutor.Name = "nomeAutor"
        Me.nomeAutor.ReadOnly = True
        Me.nomeAutor.Width = 72
        '
        'nome
        '
        Me.nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.nome.DataPropertyName = "nome"
        Me.nome.HeaderText = "Nome do Leitor"
        Me.nome.Name = "nome"
        Me.nome.ReadOnly = True
        Me.nome.Width = 96
        '
        'secao
        '
        Me.secao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.secao.DataPropertyName = "DescricaoSecao"
        Me.secao.HeaderText = "Seção"
        Me.secao.Name = "secao"
        Me.secao.ReadOnly = True
        Me.secao.Width = 63
        '
        'dataEmprestimo
        '
        Me.dataEmprestimo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dataEmprestimo.DataPropertyName = "dataEmprestimo"
        Me.dataEmprestimo.HeaderText = "Data do Empréstimo"
        Me.dataEmprestimo.Name = "dataEmprestimo"
        Me.dataEmprestimo.ReadOnly = True
        Me.dataEmprestimo.Width = 116
        '
        'dataDevolucao
        '
        Me.dataDevolucao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dataDevolucao.DataPropertyName = "dataDevolucao"
        Me.dataDevolucao.HeaderText = "Data de Devolução"
        Me.dataDevolucao.Name = "dataDevolucao"
        Me.dataDevolucao.ReadOnly = True
        Me.dataDevolucao.Width = 114
        '
        'status
        '
        Me.status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.status.DataPropertyName = "status"
        Me.status.HeaderText = "Status"
        Me.status.Name = "status"
        Me.status.ReadOnly = True
        Me.status.Width = 62
        '
        'txtNomeLeitor
        '
        Me.txtNomeLeitor.BackColor = System.Drawing.Color.DarkGray
        Me.txtNomeLeitor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomeLeitor.Location = New System.Drawing.Point(22, 45)
        Me.txtNomeLeitor.Name = "txtNomeLeitor"
        Me.txtNomeLeitor.Size = New System.Drawing.Size(194, 20)
        Me.txtNomeLeitor.TabIndex = 78
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(19, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 77
        Me.Label2.Text = "Nome do leitor:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(304, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 79
        Me.Label1.Text = "Prazo de Entrega:"
        '
        'txtPrazoDevolucao
        '
        Me.txtPrazoDevolucao.CalendarMonthBackground = System.Drawing.Color.DarkGray
        Me.txtPrazoDevolucao.CustomFormat = "yyyy-MM-dd"
        Me.txtPrazoDevolucao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrazoDevolucao.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtPrazoDevolucao.Location = New System.Drawing.Point(308, 45)
        Me.txtPrazoDevolucao.Name = "txtPrazoDevolucao"
        Me.txtPrazoDevolucao.Size = New System.Drawing.Size(120, 20)
        Me.txtPrazoDevolucao.TabIndex = 90
        Me.txtPrazoDevolucao.Value = New Date(2020, 2, 6, 0, 0, 0, 0)
        '
        'txtNomeItm
        '
        Me.txtNomeItm.BackColor = System.Drawing.Color.DarkGray
        Me.txtNomeItm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomeItm.Location = New System.Drawing.Point(515, 45)
        Me.txtNomeItm.Name = "txtNomeItm"
        Me.txtNomeItm.Size = New System.Drawing.Size(194, 20)
        Me.txtNomeItm.TabIndex = 92
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(512, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 91
        Me.Label3.Text = "Nome do item:"
        '
        'ConsultaEmprestimo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1300, 441)
        Me.Controls.Add(Me.txtNomeItm)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPrazoDevolucao)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNomeLeitor)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvInformacoes)
        Me.Controls.Add(Me.btnVoltar)
        Me.Controls.Add(Me.btnConsultar)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "ConsultaEmprestimo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Empréstimos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvInformacoes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnConsultar As Button
    Friend WithEvents btnVoltar As Button
    Friend WithEvents dgvInformacoes As DataGridView
    Friend WithEvents txtNomeLeitor As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents codEmprestimo As DataGridViewTextBoxColumn
    Friend WithEvents nomeItem As DataGridViewTextBoxColumn
    Friend WithEvents tipoItem As DataGridViewTextBoxColumn
    Friend WithEvents descricaoLocal As DataGridViewTextBoxColumn
    Friend WithEvents nomeAutor As DataGridViewTextBoxColumn
    Friend WithEvents nome As DataGridViewTextBoxColumn
    Friend WithEvents secao As DataGridViewTextBoxColumn
    Friend WithEvents dataEmprestimo As DataGridViewTextBoxColumn
    Friend WithEvents dataDevolucao As DataGridViewTextBoxColumn
    Friend WithEvents status As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPrazoDevolucao As DateTimePicker
    Friend WithEvents txtNomeItm As TextBox
    Friend WithEvents Label3 As Label
End Class
