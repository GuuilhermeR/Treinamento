<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscarLeitor
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
        Me.codLeitor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nomeLeitor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sexo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataNascimento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cpf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefoneCelular = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.enderecoNome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.enderecoBairro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.enderecoCidade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.enderecoCEP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.enderecoUF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.enderecoNumero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvInformacoes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSelecionar
        '
        Me.btnSelecionar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSelecionar.BackColor = System.Drawing.Color.Silver
        Me.btnSelecionar.Location = New System.Drawing.Point(1148, 218)
        Me.btnSelecionar.Name = "btnSelecionar"
        Me.btnSelecionar.Size = New System.Drawing.Size(119, 33)
        Me.btnSelecionar.TabIndex = 12
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
        Me.dgvInformacoes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codLeitor, Me.nomeLeitor, Me.sexo, Me.dataNascimento, Me.cpf, Me.rg, Me.email, Me.telefone, Me.telefoneCelular, Me.enderecoNome, Me.enderecoBairro, Me.enderecoCidade, Me.enderecoCEP, Me.enderecoUF, Me.enderecoNumero})
        Me.dgvInformacoes.Location = New System.Drawing.Point(12, 9)
        Me.dgvInformacoes.Name = "dgvInformacoes"
        Me.dgvInformacoes.ReadOnly = True
        Me.dgvInformacoes.Size = New System.Drawing.Size(1255, 203)
        Me.dgvInformacoes.TabIndex = 11
        '
        'codLeitor
        '
        Me.codLeitor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.codLeitor.DataPropertyName = "codLeitor"
        Me.codLeitor.HeaderText = "Código do Leitor"
        Me.codLeitor.Name = "codLeitor"
        Me.codLeitor.ReadOnly = True
        Me.codLeitor.Width = 77
        '
        'nomeLeitor
        '
        Me.nomeLeitor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.nomeLeitor.DataPropertyName = "nome"
        Me.nomeLeitor.HeaderText = "Nome do Leitor"
        Me.nomeLeitor.Name = "nomeLeitor"
        Me.nomeLeitor.ReadOnly = True
        Me.nomeLeitor.Width = 96
        '
        'sexo
        '
        Me.sexo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.sexo.DataPropertyName = "sexo"
        Me.sexo.HeaderText = "Sexo"
        Me.sexo.Name = "sexo"
        Me.sexo.ReadOnly = True
        Me.sexo.Width = 56
        '
        'dataNascimento
        '
        Me.dataNascimento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dataNascimento.DataPropertyName = "dataNascimento"
        Me.dataNascimento.HeaderText = "Data de Nascimento"
        Me.dataNascimento.Name = "dataNascimento"
        Me.dataNascimento.ReadOnly = True
        Me.dataNascimento.Width = 118
        '
        'cpf
        '
        Me.cpf.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.cpf.DataPropertyName = "cpf"
        Me.cpf.HeaderText = "CPF"
        Me.cpf.Name = "cpf"
        Me.cpf.ReadOnly = True
        Me.cpf.Width = 52
        '
        'rg
        '
        Me.rg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.rg.DataPropertyName = "rg"
        Me.rg.HeaderText = "RG"
        Me.rg.Name = "rg"
        Me.rg.ReadOnly = True
        Me.rg.Width = 48
        '
        'email
        '
        Me.email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.email.DataPropertyName = "email"
        Me.email.HeaderText = "E-mail"
        Me.email.Name = "email"
        Me.email.ReadOnly = True
        Me.email.Width = 60
        '
        'telefone
        '
        Me.telefone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.telefone.DataPropertyName = "telefone"
        Me.telefone.HeaderText = "Telefone"
        Me.telefone.Name = "telefone"
        Me.telefone.ReadOnly = True
        Me.telefone.Width = 74
        '
        'telefoneCelular
        '
        Me.telefoneCelular.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.telefoneCelular.DataPropertyName = "telefoneCelular"
        Me.telefoneCelular.HeaderText = "Celular"
        Me.telefoneCelular.Name = "telefoneCelular"
        Me.telefoneCelular.ReadOnly = True
        Me.telefoneCelular.Width = 64
        '
        'enderecoNome
        '
        Me.enderecoNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.enderecoNome.DataPropertyName = "enderecoNome"
        Me.enderecoNome.HeaderText = "Nome da rua"
        Me.enderecoNome.Name = "enderecoNome"
        Me.enderecoNome.ReadOnly = True
        Me.enderecoNome.Width = 72
        '
        'enderecoBairro
        '
        Me.enderecoBairro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.enderecoBairro.DataPropertyName = "enderecoBairro"
        Me.enderecoBairro.HeaderText = "Bairro"
        Me.enderecoBairro.Name = "enderecoBairro"
        Me.enderecoBairro.ReadOnly = True
        Me.enderecoBairro.Width = 59
        '
        'enderecoCidade
        '
        Me.enderecoCidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.enderecoCidade.DataPropertyName = "enderecoCidade"
        Me.enderecoCidade.HeaderText = "Cidade"
        Me.enderecoCidade.Name = "enderecoCidade"
        Me.enderecoCidade.ReadOnly = True
        Me.enderecoCidade.Width = 65
        '
        'enderecoCEP
        '
        Me.enderecoCEP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.enderecoCEP.DataPropertyName = "enderecoCEP"
        Me.enderecoCEP.HeaderText = "CEP"
        Me.enderecoCEP.Name = "enderecoCEP"
        Me.enderecoCEP.ReadOnly = True
        Me.enderecoCEP.Width = 53
        '
        'enderecoUF
        '
        Me.enderecoUF.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.enderecoUF.DataPropertyName = "enderecoUF"
        Me.enderecoUF.HeaderText = "UF"
        Me.enderecoUF.Name = "enderecoUF"
        Me.enderecoUF.ReadOnly = True
        Me.enderecoUF.Width = 46
        '
        'enderecoNumero
        '
        Me.enderecoNumero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.enderecoNumero.DataPropertyName = "enderecoNumero"
        Me.enderecoNumero.HeaderText = "Número"
        Me.enderecoNumero.Name = "enderecoNumero"
        Me.enderecoNumero.ReadOnly = True
        Me.enderecoNumero.Width = 69
        '
        'BuscarLeitor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1279, 261)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSelecionar)
        Me.Controls.Add(Me.dgvInformacoes)
        Me.Name = "BuscarLeitor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar Leitor"
        CType(Me.dgvInformacoes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSelecionar As Button
    Friend WithEvents dgvInformacoes As DataGridView
    Friend WithEvents codLeitor As DataGridViewTextBoxColumn
    Friend WithEvents nomeLeitor As DataGridViewTextBoxColumn
    Friend WithEvents sexo As DataGridViewTextBoxColumn
    Friend WithEvents dataNascimento As DataGridViewTextBoxColumn
    Friend WithEvents cpf As DataGridViewTextBoxColumn
    Friend WithEvents rg As DataGridViewTextBoxColumn
    Friend WithEvents email As DataGridViewTextBoxColumn
    Friend WithEvents telefone As DataGridViewTextBoxColumn
    Friend WithEvents telefoneCelular As DataGridViewTextBoxColumn
    Friend WithEvents enderecoNome As DataGridViewTextBoxColumn
    Friend WithEvents enderecoBairro As DataGridViewTextBoxColumn
    Friend WithEvents enderecoCidade As DataGridViewTextBoxColumn
    Friend WithEvents enderecoCEP As DataGridViewTextBoxColumn
    Friend WithEvents enderecoUF As DataGridViewTextBoxColumn
    Friend WithEvents enderecoNumero As DataGridViewTextBoxColumn
End Class
