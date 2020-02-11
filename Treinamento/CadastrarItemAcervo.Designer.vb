<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CadastrarItemAcervo
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCarregaImagem = New System.Windows.Forms.Button()
        Me.txtCodg = New System.Windows.Forms.TextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtLocalizacao = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtAnoEdicao = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtCodLocal = New System.Windows.Forms.TextBox()
        Me.txtCodAutor = New System.Windows.Forms.TextBox()
        Me.txtCodEditora = New System.Windows.Forms.TextBox()
        Me.txtCodColecao = New System.Windows.Forms.TextBox()
        Me.txtNumExemplar = New System.Windows.Forms.TextBox()
        Me.txtIsbn = New System.Windows.Forms.TextBox()
        Me.txtVolume = New System.Windows.Forms.TextBox()
        Me.btnVoltar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.dgvInformacoes = New System.Windows.Forms.DataGridView()
        Me.codItemI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numExemplarI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descricaoLocalI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nomeI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nomeAutorI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nomeEditoraI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipoItemI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.isbnI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.volumeI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.anoEdiI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.localizacaoI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.secaoI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idiomaI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nomeColecaoI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.statusI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnBuscarCLocal = New System.Windows.Forms.Button()
        Me.btnBuscarCeditora = New System.Windows.Forms.Button()
        Me.btnBuscarCautor = New System.Windows.Forms.Button()
        Me.btnBuscarCcolecao = New System.Windows.Forms.Button()
        Me.cbIdioma = New System.Windows.Forms.ComboBox()
        Me.cbTipoItem = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtSecao = New System.Windows.Forms.TextBox()
        Me.cbStatus = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtLocal = New System.Windows.Forms.TextBox()
        Me.txtEditora = New System.Windows.Forms.TextBox()
        Me.txtAutor = New System.Windows.Forms.TextBox()
        Me.txtColecao = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.pbImagem = New System.Windows.Forms.PictureBox()
        CType(Me.dgvInformacoes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbImagem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(263, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código:"
        '
        'btnCarregaImagem
        '
        Me.btnCarregaImagem.BackColor = System.Drawing.Color.Silver
        Me.btnCarregaImagem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCarregaImagem.Location = New System.Drawing.Point(12, 223)
        Me.btnCarregaImagem.Name = "btnCarregaImagem"
        Me.btnCarregaImagem.Size = New System.Drawing.Size(219, 34)
        Me.btnCarregaImagem.TabIndex = 9
        Me.btnCarregaImagem.Text = "Carregar Imagem"
        Me.btnCarregaImagem.UseVisualStyleBackColor = False
        '
        'txtCodg
        '
        Me.txtCodg.BackColor = System.Drawing.Color.DarkGray
        Me.txtCodg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodg.Location = New System.Drawing.Point(266, 34)
        Me.txtCodg.Name = "txtCodg"
        Me.txtCodg.Size = New System.Drawing.Size(94, 20)
        Me.txtCodg.TabIndex = 10
        '
        'txtNome
        '
        Me.txtNome.BackColor = System.Drawing.Color.DarkGray
        Me.txtNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNome.Location = New System.Drawing.Point(447, 34)
        Me.txtNome.MaxLength = 200
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(335, 20)
        Me.txtNome.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(444, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Nome:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(263, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Código Local:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(263, 175)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Código Autor:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(263, 124)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Código Editora:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.Control
        Me.Label9.Location = New System.Drawing.Point(263, 223)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 13)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Código Coleção:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.Control
        Me.Label11.Location = New System.Drawing.Point(480, 331)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 13)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Tipo do Item:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.Control
        Me.Label12.Location = New System.Drawing.Point(19, 275)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(93, 13)
        Me.Label12.TabIndex = 31
        Me.Label12.Text = "Número Exemplar:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.Control
        Me.Label13.Location = New System.Drawing.Point(323, 331)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 13)
        Me.Label13.TabIndex = 33
        Me.Label13.Text = "Volume:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.Control
        Me.Label14.Location = New System.Drawing.Point(199, 275)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(35, 13)
        Me.Label14.TabIndex = 35
        Me.Label14.Text = "ISBN:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.Control
        Me.Label15.Location = New System.Drawing.Point(711, 330)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(41, 13)
        Me.Label15.TabIndex = 37
        Me.Label15.Text = "Seção:"
        '
        'txtLocalizacao
        '
        Me.txtLocalizacao.BackColor = System.Drawing.Color.DarkGray
        Me.txtLocalizacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLocalizacao.Location = New System.Drawing.Point(578, 298)
        Me.txtLocalizacao.MaxLength = 50
        Me.txtLocalizacao.Name = "txtLocalizacao"
        Me.txtLocalizacao.Size = New System.Drawing.Size(334, 20)
        Me.txtLocalizacao.TabIndex = 40
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.Control
        Me.Label16.Location = New System.Drawing.Point(574, 275)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(67, 13)
        Me.Label16.TabIndex = 39
        Me.Label16.Text = "Localização:"
        '
        'txtAnoEdicao
        '
        Me.txtAnoEdicao.BackColor = System.Drawing.Color.DarkGray
        Me.txtAnoEdicao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnoEdicao.Location = New System.Drawing.Point(386, 298)
        Me.txtAnoEdicao.Name = "txtAnoEdicao"
        Me.txtAnoEdicao.Size = New System.Drawing.Size(111, 20)
        Me.txtAnoEdicao.TabIndex = 42
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.Control
        Me.Label17.Location = New System.Drawing.Point(382, 275)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(80, 13)
        Me.Label17.TabIndex = 41
        Me.Label17.Text = "Ano de Edição:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.Control
        Me.Label18.Location = New System.Drawing.Point(19, 331)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(41, 13)
        Me.Label18.TabIndex = 43
        Me.Label18.Text = "Idioma:"
        '
        'txtCodLocal
        '
        Me.txtCodLocal.BackColor = System.Drawing.Color.DarkGray
        Me.txtCodLocal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodLocal.Location = New System.Drawing.Point(266, 90)
        Me.txtCodLocal.Name = "txtCodLocal"
        Me.txtCodLocal.ReadOnly = True
        Me.txtCodLocal.Size = New System.Drawing.Size(94, 20)
        Me.txtCodLocal.TabIndex = 48
        '
        'txtCodAutor
        '
        Me.txtCodAutor.BackColor = System.Drawing.Color.DarkGray
        Me.txtCodAutor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodAutor.Location = New System.Drawing.Point(266, 194)
        Me.txtCodAutor.Name = "txtCodAutor"
        Me.txtCodAutor.ReadOnly = True
        Me.txtCodAutor.Size = New System.Drawing.Size(94, 20)
        Me.txtCodAutor.TabIndex = 49
        '
        'txtCodEditora
        '
        Me.txtCodEditora.BackColor = System.Drawing.Color.DarkGray
        Me.txtCodEditora.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodEditora.Location = New System.Drawing.Point(266, 147)
        Me.txtCodEditora.Name = "txtCodEditora"
        Me.txtCodEditora.ReadOnly = True
        Me.txtCodEditora.Size = New System.Drawing.Size(94, 20)
        Me.txtCodEditora.TabIndex = 50
        '
        'txtCodColecao
        '
        Me.txtCodColecao.BackColor = System.Drawing.Color.DarkGray
        Me.txtCodColecao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodColecao.Location = New System.Drawing.Point(267, 246)
        Me.txtCodColecao.Name = "txtCodColecao"
        Me.txtCodColecao.ReadOnly = True
        Me.txtCodColecao.Size = New System.Drawing.Size(94, 20)
        Me.txtCodColecao.TabIndex = 51
        '
        'txtNumExemplar
        '
        Me.txtNumExemplar.BackColor = System.Drawing.Color.DarkGray
        Me.txtNumExemplar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumExemplar.Location = New System.Drawing.Point(22, 298)
        Me.txtNumExemplar.Name = "txtNumExemplar"
        Me.txtNumExemplar.Size = New System.Drawing.Size(94, 20)
        Me.txtNumExemplar.TabIndex = 52
        '
        'txtIsbn
        '
        Me.txtIsbn.BackColor = System.Drawing.Color.DarkGray
        Me.txtIsbn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIsbn.Location = New System.Drawing.Point(202, 298)
        Me.txtIsbn.Name = "txtIsbn"
        Me.txtIsbn.Size = New System.Drawing.Size(94, 20)
        Me.txtIsbn.TabIndex = 53
        '
        'txtVolume
        '
        Me.txtVolume.BackColor = System.Drawing.Color.DarkGray
        Me.txtVolume.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVolume.Location = New System.Drawing.Point(327, 353)
        Me.txtVolume.Name = "txtVolume"
        Me.txtVolume.Size = New System.Drawing.Size(94, 20)
        Me.txtVolume.TabIndex = 54
        '
        'btnVoltar
        '
        Me.btnVoltar.BackColor = System.Drawing.Color.Silver
        Me.btnVoltar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVoltar.Location = New System.Drawing.Point(12, 467)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Size = New System.Drawing.Size(104, 34)
        Me.btnVoltar.TabIndex = 57
        Me.btnVoltar.Text = "Voltar"
        Me.btnVoltar.UseVisualStyleBackColor = False
        '
        'btnExcluir
        '
        Me.btnExcluir.BackColor = System.Drawing.Color.Silver
        Me.btnExcluir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcluir.ForeColor = System.Drawing.Color.Red
        Me.btnExcluir.Location = New System.Drawing.Point(1018, 467)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(144, 34)
        Me.btnExcluir.TabIndex = 55
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = False
        '
        'btnSalvar
        '
        Me.btnSalvar.BackColor = System.Drawing.Color.Silver
        Me.btnSalvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalvar.ForeColor = System.Drawing.Color.Green
        Me.btnSalvar.Location = New System.Drawing.Point(845, 467)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(144, 34)
        Me.btnSalvar.TabIndex = 56
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
        Me.dgvInformacoes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvInformacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInformacoes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codItemI, Me.numExemplarI, Me.descricaoLocalI, Me.nomeI, Me.nomeAutorI, Me.nomeEditoraI, Me.tipoItemI, Me.isbnI, Me.volumeI, Me.anoEdiI, Me.localizacaoI, Me.secaoI, Me.idiomaI, Me.nomeColecaoI, Me.statusI})
        Me.dgvInformacoes.Location = New System.Drawing.Point(12, 507)
        Me.dgvInformacoes.Name = "dgvInformacoes"
        Me.dgvInformacoes.ReadOnly = True
        Me.dgvInformacoes.Size = New System.Drawing.Size(1346, 240)
        Me.dgvInformacoes.TabIndex = 58
        '
        'codItemI
        '
        Me.codItemI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.codItemI.DataPropertyName = "codItem"
        Me.codItemI.HeaderText = "Código do Item"
        Me.codItemI.Name = "codItemI"
        Me.codItemI.ReadOnly = True
        Me.codItemI.Width = 77
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
        'descricaoLocalI
        '
        Me.descricaoLocalI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.descricaoLocalI.DataPropertyName = "descricaoLocal"
        Me.descricaoLocalI.HeaderText = "Local"
        Me.descricaoLocalI.Name = "descricaoLocalI"
        Me.descricaoLocalI.ReadOnly = True
        Me.descricaoLocalI.Width = 58
        '
        'nomeI
        '
        Me.nomeI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.nomeI.DataPropertyName = "nome"
        Me.nomeI.HeaderText = "Nome do Item"
        Me.nomeI.Name = "nomeI"
        Me.nomeI.ReadOnly = True
        Me.nomeI.Width = 72
        '
        'nomeAutorI
        '
        Me.nomeAutorI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.nomeAutorI.DataPropertyName = "nomeAutor"
        Me.nomeAutorI.HeaderText = "Autor"
        Me.nomeAutorI.Name = "nomeAutorI"
        Me.nomeAutorI.ReadOnly = True
        Me.nomeAutorI.Width = 57
        '
        'nomeEditoraI
        '
        Me.nomeEditoraI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.nomeEditoraI.DataPropertyName = "nome"
        Me.nomeEditoraI.HeaderText = "Editora"
        Me.nomeEditoraI.Name = "nomeEditoraI"
        Me.nomeEditoraI.ReadOnly = True
        Me.nomeEditoraI.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.nomeEditoraI.Width = 46
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
        'isbnI
        '
        Me.isbnI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.isbnI.DataPropertyName = "isbn"
        Me.isbnI.HeaderText = "ISBN"
        Me.isbnI.Name = "isbnI"
        Me.isbnI.ReadOnly = True
        Me.isbnI.Width = 57
        '
        'volumeI
        '
        Me.volumeI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.volumeI.DataPropertyName = "volume"
        Me.volumeI.HeaderText = "Volume"
        Me.volumeI.Name = "volumeI"
        Me.volumeI.ReadOnly = True
        Me.volumeI.Width = 67
        '
        'anoEdiI
        '
        Me.anoEdiI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.anoEdiI.DataPropertyName = "anoEdicao"
        Me.anoEdiI.HeaderText = "Ano da Edição"
        Me.anoEdiI.Name = "anoEdiI"
        Me.anoEdiI.ReadOnly = True
        Me.anoEdiI.Width = 94
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
        'secaoI
        '
        Me.secaoI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.secaoI.DataPropertyName = "secao"
        Me.secaoI.HeaderText = "Seção"
        Me.secaoI.Name = "secaoI"
        Me.secaoI.ReadOnly = True
        Me.secaoI.Width = 63
        '
        'idiomaI
        '
        Me.idiomaI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.idiomaI.DataPropertyName = "idioma"
        Me.idiomaI.HeaderText = "Idioma"
        Me.idiomaI.Name = "idiomaI"
        Me.idiomaI.ReadOnly = True
        Me.idiomaI.Width = 63
        '
        'nomeColecaoI
        '
        Me.nomeColecaoI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.nomeColecaoI.DataPropertyName = "nomeColecao"
        Me.nomeColecaoI.HeaderText = "Coleção"
        Me.nomeColecaoI.Name = "nomeColecaoI"
        Me.nomeColecaoI.ReadOnly = True
        Me.nomeColecaoI.Width = 71
        '
        'statusI
        '
        Me.statusI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.statusI.DataPropertyName = "status"
        Me.statusI.HeaderText = "Status"
        Me.statusI.Name = "statusI"
        Me.statusI.ReadOnly = True
        Me.statusI.Width = 62
        '
        'btnBuscarCLocal
        '
        Me.btnBuscarCLocal.BackColor = System.Drawing.Color.Silver
        Me.btnBuscarCLocal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarCLocal.Location = New System.Drawing.Point(819, 85)
        Me.btnBuscarCLocal.Name = "btnBuscarCLocal"
        Me.btnBuscarCLocal.Size = New System.Drawing.Size(84, 31)
        Me.btnBuscarCLocal.TabIndex = 59
        Me.btnBuscarCLocal.Text = "Buscar"
        Me.btnBuscarCLocal.UseVisualStyleBackColor = False
        '
        'btnBuscarCeditora
        '
        Me.btnBuscarCeditora.BackColor = System.Drawing.Color.Silver
        Me.btnBuscarCeditora.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarCeditora.Location = New System.Drawing.Point(819, 143)
        Me.btnBuscarCeditora.Name = "btnBuscarCeditora"
        Me.btnBuscarCeditora.Size = New System.Drawing.Size(84, 30)
        Me.btnBuscarCeditora.TabIndex = 59
        Me.btnBuscarCeditora.Text = "Buscar"
        Me.btnBuscarCeditora.UseVisualStyleBackColor = False
        '
        'btnBuscarCautor
        '
        Me.btnBuscarCautor.BackColor = System.Drawing.Color.Silver
        Me.btnBuscarCautor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarCautor.Location = New System.Drawing.Point(819, 189)
        Me.btnBuscarCautor.Name = "btnBuscarCautor"
        Me.btnBuscarCautor.Size = New System.Drawing.Size(84, 31)
        Me.btnBuscarCautor.TabIndex = 59
        Me.btnBuscarCautor.Text = "Buscar"
        Me.btnBuscarCautor.UseVisualStyleBackColor = False
        '
        'btnBuscarCcolecao
        '
        Me.btnBuscarCcolecao.BackColor = System.Drawing.Color.Silver
        Me.btnBuscarCcolecao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarCcolecao.Location = New System.Drawing.Point(819, 242)
        Me.btnBuscarCcolecao.Name = "btnBuscarCcolecao"
        Me.btnBuscarCcolecao.Size = New System.Drawing.Size(84, 30)
        Me.btnBuscarCcolecao.TabIndex = 59
        Me.btnBuscarCcolecao.Text = "Buscar"
        Me.btnBuscarCcolecao.UseVisualStyleBackColor = False
        '
        'cbIdioma
        '
        Me.cbIdioma.BackColor = System.Drawing.Color.DarkGray
        Me.cbIdioma.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbIdioma.FormattingEnabled = True
        Me.cbIdioma.Items.AddRange(New Object() {"Afrikaans" & Global.Microsoft.VisualBasic.ChrW(9), "Inglês (Estados Unidos)", "Albanês" & Global.Microsoft.VisualBasic.ChrW(9), "Amárico" & Global.Microsoft.VisualBasic.ChrW(9), "Árabe" & Global.Microsoft.VisualBasic.ChrW(9), "Armênio" & Global.Microsoft.VisualBasic.ChrW(9), "Assamês" & Global.Microsoft.VisualBasic.ChrW(9), "Azerbaijano (latino)" & Global.Microsoft.VisualBasic.ChrW(9), "Bangla (Bangladesh)", "Bangla (Índia)", "Basco", "Bielorrusso", "Bósnio (latino)", "Búlgaro", "Catalão", "Curdo", "Cheroqu", "Chinês simplificado", "Chinês Tradicional", "Croata", "Tcheco", "Dinamarquês", "Dari", "Holandês", "Inglês", "Estoniano", "Filipino", "Finlandês", "Francês", "Galego", "Georgiano", "Alemão", "Grego", "Guzerate", "Hauçá (latino)", "Hebraico", "Hindi", "Húngaro", "Islandês", "Igbo", "Indonésio", "Irlandês", "isiXhosa", "isiZulu", "Italiano", "Japonês", "Canarim", "Cazaque", "Khmer", "Quiché", "Quiniaruanda", "Suaíli", "Concani", "Coreano" & Global.Microsoft.VisualBasic.ChrW(9), "Quirguiz", "Letão", "Lituano" & Global.Microsoft.VisualBasic.ChrW(9), "Luxemburguês", "Macedônio" & Global.Microsoft.VisualBasic.ChrW(9), "Malaio (Malásia, Brunei e Cingapura)", "Malaiala", "Maltês" & Global.Microsoft.VisualBasic.ChrW(9), "Maori" & Global.Microsoft.VisualBasic.ChrW(9), "Marati", "Mongol (cirílico)", "Nepalês", "Norueguês (Bokmål)", "Norueguês (Nynorsk)", "Odia", "Persa", "Polonês" & Global.Microsoft.VisualBasic.ChrW(9), "Português (Brasil)", "Português (Portugal)", "Punjabi" & Global.Microsoft.VisualBasic.ChrW(9), "Punjabi ", "Quíchua" & Global.Microsoft.VisualBasic.ChrW(9), "Romeno", "Russo", "Gaélico ", "Sérvio (cirílico, Bósnia e Herzegovina)" & Global.Microsoft.VisualBasic.ChrW(9), "Sérvio (cirílico, Sérvia)", "Sérvio (latino)", "Soto setentrional", "Tswana (África do Sul e Botsuana)", "Sindi (árabe)" & Global.Microsoft.VisualBasic.ChrW(9), "Cingalês", "Eslovaco" & Global.Microsoft.VisualBasic.ChrW(9), "Esloveno", "Espanhol" & Global.Microsoft.VisualBasic.ChrW(9), "Sueco" & Global.Microsoft.VisualBasic.ChrW(9), "Tadjique (cirílico)" & Global.Microsoft.VisualBasic.ChrW(9), "Tâmil (Índia e Sri Lanka)", "Tártaro", "Télugo" & Global.Microsoft.VisualBasic.ChrW(9), "Tailandês", "Tigrínia (Etiópia)", "Turco", "Turcomeno", "Ucraniano", "Urdu" & Global.Microsoft.VisualBasic.ChrW(9), "Uigur", "Uzbeque (latino)", "Valenciano", "Vietnamita", "Galês", "Uolofe", "Iorubá"})
        Me.cbIdioma.Location = New System.Drawing.Point(23, 354)
        Me.cbIdioma.Name = "cbIdioma"
        Me.cbIdioma.Size = New System.Drawing.Size(228, 21)
        Me.cbIdioma.TabIndex = 60
        '
        'cbTipoItem
        '
        Me.cbTipoItem.BackColor = System.Drawing.Color.DarkGray
        Me.cbTipoItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipoItem.FormattingEnabled = True
        Me.cbTipoItem.Items.AddRange(New Object() {"Livro", "Revista", "Jornal", "DVD/CD", "Folheto", "Artigo"})
        Me.cbTipoItem.Location = New System.Drawing.Point(484, 354)
        Me.cbTipoItem.Name = "cbTipoItem"
        Me.cbTipoItem.Size = New System.Drawing.Size(171, 21)
        Me.cbTipoItem.TabIndex = 61
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Silver
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(897, 345)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(79, 31)
        Me.Button1.TabIndex = 64
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtSecao
        '
        Me.txtSecao.BackColor = System.Drawing.Color.DarkGray
        Me.txtSecao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSecao.Location = New System.Drawing.Point(714, 350)
        Me.txtSecao.Name = "txtSecao"
        Me.txtSecao.ReadOnly = True
        Me.txtSecao.Size = New System.Drawing.Size(177, 20)
        Me.txtSecao.TabIndex = 63
        '
        'cbStatus
        '
        Me.cbStatus.BackColor = System.Drawing.Color.DarkGray
        Me.cbStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbStatus.FormattingEnabled = True
        Me.cbStatus.Items.AddRange(New Object() {"Disponível", "Emprestado", "Reservado"})
        Me.cbStatus.Location = New System.Drawing.Point(23, 413)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(171, 21)
        Me.cbStatus.TabIndex = 66
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.Control
        Me.Label19.Location = New System.Drawing.Point(20, 390)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(40, 13)
        Me.Label19.TabIndex = 65
        Me.Label19.Text = "Status:"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Silver
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.Location = New System.Drawing.Point(433, 467)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(206, 34)
        Me.Button2.TabIndex = 67
        Me.Button2.Text = "Limpar informações"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'txtLocal
        '
        Me.txtLocal.BackColor = System.Drawing.Color.DarkGray
        Me.txtLocal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLocal.Location = New System.Drawing.Point(448, 90)
        Me.txtLocal.MaxLength = 200
        Me.txtLocal.Name = "txtLocal"
        Me.txtLocal.ReadOnly = True
        Me.txtLocal.Size = New System.Drawing.Size(335, 20)
        Me.txtLocal.TabIndex = 68
        '
        'txtEditora
        '
        Me.txtEditora.BackColor = System.Drawing.Color.DarkGray
        Me.txtEditora.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEditora.Location = New System.Drawing.Point(447, 147)
        Me.txtEditora.MaxLength = 200
        Me.txtEditora.Name = "txtEditora"
        Me.txtEditora.ReadOnly = True
        Me.txtEditora.Size = New System.Drawing.Size(335, 20)
        Me.txtEditora.TabIndex = 68
        '
        'txtAutor
        '
        Me.txtAutor.BackColor = System.Drawing.Color.DarkGray
        Me.txtAutor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAutor.Location = New System.Drawing.Point(447, 194)
        Me.txtAutor.MaxLength = 200
        Me.txtAutor.Name = "txtAutor"
        Me.txtAutor.ReadOnly = True
        Me.txtAutor.Size = New System.Drawing.Size(335, 20)
        Me.txtAutor.TabIndex = 68
        '
        'txtColecao
        '
        Me.txtColecao.BackColor = System.Drawing.Color.DarkGray
        Me.txtColecao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtColecao.Location = New System.Drawing.Point(447, 246)
        Me.txtColecao.MaxLength = 200
        Me.txtColecao.Name = "txtColecao"
        Me.txtColecao.ReadOnly = True
        Me.txtColecao.Size = New System.Drawing.Size(335, 20)
        Me.txtColecao.TabIndex = 68
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(444, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 69
        Me.Label3.Text = "Local:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(444, 123)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 70
        Me.Label6.Text = "Editora:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.Control
        Me.Label8.Location = New System.Drawing.Point(444, 174)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 13)
        Me.Label8.TabIndex = 70
        Me.Label8.Text = "Autor:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.Control
        Me.Label10.Location = New System.Drawing.Point(444, 223)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 13)
        Me.Label10.TabIndex = 70
        Me.Label10.Text = "Coleção:"
        '
        'pbImagem
        '
        Me.pbImagem.InitialImage = Global.Treinamento.My.Resources.Resources.kisspng_user_interface_design_computer_icons_default_stephen_salazar_photography_5b1462e1b19d70_removebg_preview__2_
        Me.pbImagem.Location = New System.Drawing.Point(12, 18)
        Me.pbImagem.Name = "pbImagem"
        Me.pbImagem.Size = New System.Drawing.Size(219, 202)
        Me.pbImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbImagem.TabIndex = 71
        Me.pbImagem.TabStop = False
        Me.pbImagem.WaitOnLoad = True
        '
        'CadastrarItemAcervo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.pbImagem)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtColecao)
        Me.Controls.Add(Me.txtAutor)
        Me.Controls.Add(Me.txtEditora)
        Me.Controls.Add(Me.txtLocal)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.cbStatus)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtSecao)
        Me.Controls.Add(Me.cbTipoItem)
        Me.Controls.Add(Me.cbIdioma)
        Me.Controls.Add(Me.btnBuscarCcolecao)
        Me.Controls.Add(Me.btnBuscarCautor)
        Me.Controls.Add(Me.btnBuscarCeditora)
        Me.Controls.Add(Me.btnBuscarCLocal)
        Me.Controls.Add(Me.dgvInformacoes)
        Me.Controls.Add(Me.btnVoltar)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.txtVolume)
        Me.Controls.Add(Me.txtIsbn)
        Me.Controls.Add(Me.txtNumExemplar)
        Me.Controls.Add(Me.txtCodColecao)
        Me.Controls.Add(Me.txtCodEditora)
        Me.Controls.Add(Me.txtCodAutor)
        Me.Controls.Add(Me.txtCodLocal)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtAnoEdicao)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtLocalizacao)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCodg)
        Me.Controls.Add(Me.btnCarregaImagem)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CadastrarItemAcervo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastrar Item do Acervo"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvInformacoes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbImagem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnCarregaImagem As Button
    Friend WithEvents txtCodg As TextBox
    Friend WithEvents txtNome As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtLocalizacao As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtAnoEdicao As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents txtCodLocal As TextBox
    Friend WithEvents txtCodAutor As TextBox
    Friend WithEvents txtCodEditora As TextBox
    Friend WithEvents txtCodColecao As TextBox
    Friend WithEvents txtNumExemplar As TextBox
    Friend WithEvents txtIsbn As TextBox
    Friend WithEvents txtVolume As TextBox
    Friend WithEvents btnVoltar As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btnSalvar As Button
    Friend WithEvents dgvInformacoes As DataGridView
    Friend WithEvents btnBuscarCLocal As Button
    Friend WithEvents btnBuscarCeditora As Button
    Friend WithEvents btnBuscarCautor As Button
    Friend WithEvents btnBuscarCcolecao As Button
    Friend WithEvents cbIdioma As ComboBox
    Friend WithEvents cbTipoItem As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtSecao As TextBox
    Friend WithEvents cbStatus As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents txtLocal As TextBox
    Friend WithEvents txtEditora As TextBox
    Friend WithEvents txtAutor As TextBox
    Friend WithEvents txtColecao As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents codItemI As DataGridViewTextBoxColumn
    Friend WithEvents numExemplarI As DataGridViewTextBoxColumn
    Friend WithEvents descricaoLocalI As DataGridViewTextBoxColumn
    Friend WithEvents nomeI As DataGridViewTextBoxColumn
    Friend WithEvents nomeAutorI As DataGridViewTextBoxColumn
    Friend WithEvents nomeEditoraI As DataGridViewTextBoxColumn
    Friend WithEvents tipoItemI As DataGridViewTextBoxColumn
    Friend WithEvents isbnI As DataGridViewTextBoxColumn
    Friend WithEvents volumeI As DataGridViewTextBoxColumn
    Friend WithEvents anoEdiI As DataGridViewTextBoxColumn
    Friend WithEvents localizacaoI As DataGridViewTextBoxColumn
    Friend WithEvents secaoI As DataGridViewTextBoxColumn
    Friend WithEvents idiomaI As DataGridViewTextBoxColumn
    Friend WithEvents nomeColecaoI As DataGridViewTextBoxColumn
    Friend WithEvents statusI As DataGridViewTextBoxColumn
    Friend WithEvents pbImagem As PictureBox
End Class
