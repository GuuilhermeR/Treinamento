<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ConsultaItemAcervo
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCodg = New System.Windows.Forms.TextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.btnVoltar = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.dgvInformacoes = New System.Windows.Forms.DataGridView()
        Me.codItem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numExemplar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nomeLocal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nomeItem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nomeAutor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nomeEditora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipoItem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.isbn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.volume = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.anoEdicao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.localizacao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.secao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idioma = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nomeColecao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rbNome = New System.Windows.Forms.RadioButton()
        Me.rbCodigo = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCodLocal = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtCodAutor = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtCodColecao = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtISBN = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCodSecao = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtIdioma = New System.Windows.Forms.TextBox()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtTipoItem = New System.Windows.Forms.TextBox()
        Me.btnSalva = New System.Windows.Forms.Button()
        CType(Me.dgvInformacoes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(16, 159)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código do Item:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(203, 159)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nome do Item:"
        '
        'txtCodg
        '
        Me.txtCodg.BackColor = System.Drawing.Color.DarkGray
        Me.txtCodg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodg.Location = New System.Drawing.Point(19, 182)
        Me.txtCodg.Name = "txtCodg"
        Me.txtCodg.Size = New System.Drawing.Size(81, 20)
        Me.txtCodg.TabIndex = 15
        '
        'txtNome
        '
        Me.txtNome.BackColor = System.Drawing.Color.DarkGray
        Me.txtNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNome.Location = New System.Drawing.Point(206, 182)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(365, 20)
        Me.txtNome.TabIndex = 16
        '
        'btnVoltar
        '
        Me.btnVoltar.BackColor = System.Drawing.Color.Silver
        Me.btnVoltar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVoltar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnVoltar.Location = New System.Drawing.Point(12, 369)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Size = New System.Drawing.Size(144, 34)
        Me.btnVoltar.TabIndex = 78
        Me.btnVoltar.Text = "Voltar"
        Me.btnVoltar.UseVisualStyleBackColor = False
        '
        'btnSalvar
        '
        Me.btnSalvar.BackColor = System.Drawing.Color.Silver
        Me.btnSalvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalvar.ForeColor = System.Drawing.Color.Green
        Me.btnSalvar.Location = New System.Drawing.Point(1398, 369)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(144, 34)
        Me.btnSalvar.TabIndex = 77
        Me.btnSalvar.Text = "Consultar"
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
        Me.dgvInformacoes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codItem, Me.numExemplar, Me.nomeLocal, Me.nomeItem, Me.nomeAutor, Me.nomeEditora, Me.tipoItem, Me.isbn, Me.volume, Me.anoEdicao, Me.localizacao, Me.secao, Me.idioma, Me.nomeColecao, Me.status})
        Me.dgvInformacoes.Location = New System.Drawing.Point(12, 409)
        Me.dgvInformacoes.Name = "dgvInformacoes"
        Me.dgvInformacoes.ReadOnly = True
        Me.dgvInformacoes.Size = New System.Drawing.Size(1346, 328)
        Me.dgvInformacoes.TabIndex = 79
        '
        'codItem
        '
        Me.codItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.codItem.DataPropertyName = "codItem"
        Me.codItem.HeaderText = "Código do Item"
        Me.codItem.Name = "codItem"
        Me.codItem.ReadOnly = True
        Me.codItem.Width = 77
        '
        'numExemplar
        '
        Me.numExemplar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.numExemplar.DataPropertyName = "numExemplar"
        Me.numExemplar.HeaderText = "Número Exemplar"
        Me.numExemplar.Name = "numExemplar"
        Me.numExemplar.ReadOnly = True
        Me.numExemplar.Width = 105
        '
        'nomeLocal
        '
        Me.nomeLocal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.nomeLocal.DataPropertyName = "descricaoLocal"
        Me.nomeLocal.HeaderText = "Local"
        Me.nomeLocal.Name = "nomeLocal"
        Me.nomeLocal.ReadOnly = True
        Me.nomeLocal.Width = 58
        '
        'nomeItem
        '
        Me.nomeItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.nomeItem.DataPropertyName = "nome"
        Me.nomeItem.HeaderText = "Nome do Item"
        Me.nomeItem.Name = "nomeItem"
        Me.nomeItem.ReadOnly = True
        Me.nomeItem.Width = 72
        '
        'nomeAutor
        '
        Me.nomeAutor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.nomeAutor.DataPropertyName = "nomeAutor"
        Me.nomeAutor.HeaderText = "Autor"
        Me.nomeAutor.Name = "nomeAutor"
        Me.nomeAutor.ReadOnly = True
        Me.nomeAutor.Width = 57
        '
        'nomeEditora
        '
        Me.nomeEditora.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.nomeEditora.DataPropertyName = "nome"
        Me.nomeEditora.HeaderText = "Editora"
        Me.nomeEditora.Name = "nomeEditora"
        Me.nomeEditora.ReadOnly = True
        Me.nomeEditora.Width = 65
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
        'isbn
        '
        Me.isbn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.isbn.DataPropertyName = "isbn"
        Me.isbn.HeaderText = "ISBN"
        Me.isbn.Name = "isbn"
        Me.isbn.ReadOnly = True
        Me.isbn.Width = 57
        '
        'volume
        '
        Me.volume.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.volume.DataPropertyName = "volume"
        Me.volume.HeaderText = "Volume"
        Me.volume.Name = "volume"
        Me.volume.ReadOnly = True
        Me.volume.Width = 67
        '
        'anoEdicao
        '
        Me.anoEdicao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.anoEdicao.DataPropertyName = "anoEdicao"
        Me.anoEdicao.HeaderText = "Ano de Edição"
        Me.anoEdicao.Name = "anoEdicao"
        Me.anoEdicao.ReadOnly = True
        Me.anoEdicao.Width = 94
        '
        'localizacao
        '
        Me.localizacao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.localizacao.DataPropertyName = "localizacao"
        Me.localizacao.HeaderText = "Localização"
        Me.localizacao.Name = "localizacao"
        Me.localizacao.ReadOnly = True
        Me.localizacao.Width = 89
        '
        'secao
        '
        Me.secao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.secao.DataPropertyName = "secao"
        Me.secao.HeaderText = "Seção"
        Me.secao.Name = "secao"
        Me.secao.ReadOnly = True
        Me.secao.Width = 63
        '
        'idioma
        '
        Me.idioma.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.idioma.DataPropertyName = "idioma"
        Me.idioma.HeaderText = "Idioma"
        Me.idioma.Name = "idioma"
        Me.idioma.ReadOnly = True
        Me.idioma.Width = 63
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
        'status
        '
        Me.status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.status.DataPropertyName = "status"
        Me.status.HeaderText = "Status"
        Me.status.Name = "status"
        Me.status.ReadOnly = True
        Me.status.Width = 62
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Controls.Add(Me.rbNome)
        Me.Panel1.Controls.Add(Me.rbCodigo)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(15, 20)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(289, 122)
        Me.Panel1.TabIndex = 83
        '
        'rbNome
        '
        Me.rbNome.AutoSize = True
        Me.rbNome.Checked = True
        Me.rbNome.Location = New System.Drawing.Point(89, 84)
        Me.rbNome.Name = "rbNome"
        Me.rbNome.Size = New System.Drawing.Size(53, 17)
        Me.rbNome.TabIndex = 86
        Me.rbNome.TabStop = True
        Me.rbNome.Text = "Nome"
        Me.rbNome.UseVisualStyleBackColor = True
        '
        'rbCodigo
        '
        Me.rbCodigo.AutoSize = True
        Me.rbCodigo.Location = New System.Drawing.Point(89, 36)
        Me.rbCodigo.Name = "rbCodigo"
        Me.rbCodigo.Size = New System.Drawing.Size(58, 17)
        Me.rbCodigo.TabIndex = 86
        Me.rbCodigo.Text = "Código"
        Me.rbCodigo.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(145, 13)
        Me.Label5.TabIndex = 84
        Me.Label5.Text = "Selecionar método de busca:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(16, 229)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Código Local:"
        '
        'txtCodLocal
        '
        Me.txtCodLocal.BackColor = System.Drawing.Color.DarkGray
        Me.txtCodLocal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodLocal.Location = New System.Drawing.Point(19, 252)
        Me.txtCodLocal.Name = "txtCodLocal"
        Me.txtCodLocal.ReadOnly = True
        Me.txtCodLocal.Size = New System.Drawing.Size(81, 20)
        Me.txtCodLocal.TabIndex = 64
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.Control
        Me.Label12.Location = New System.Drawing.Point(231, 229)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(86, 13)
        Me.Label12.TabIndex = 65
        Me.Label12.Text = "Código do Autor:"
        '
        'txtCodAutor
        '
        Me.txtCodAutor.BackColor = System.Drawing.Color.DarkGray
        Me.txtCodAutor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodAutor.Location = New System.Drawing.Point(235, 252)
        Me.txtCodAutor.Name = "txtCodAutor"
        Me.txtCodAutor.ReadOnly = True
        Me.txtCodAutor.Size = New System.Drawing.Size(81, 20)
        Me.txtCodAutor.TabIndex = 66
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.Control
        Me.Label13.Location = New System.Drawing.Point(486, 229)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(100, 13)
        Me.Label13.TabIndex = 67
        Me.Label13.Text = "Código da Coleção:"
        '
        'txtCodColecao
        '
        Me.txtCodColecao.BackColor = System.Drawing.Color.DarkGray
        Me.txtCodColecao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodColecao.Location = New System.Drawing.Point(490, 252)
        Me.txtCodColecao.Name = "txtCodColecao"
        Me.txtCodColecao.ReadOnly = True
        Me.txtCodColecao.Size = New System.Drawing.Size(81, 20)
        Me.txtCodColecao.TabIndex = 68
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.Control
        Me.Label14.Location = New System.Drawing.Point(718, 229)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(35, 13)
        Me.Label14.TabIndex = 69
        Me.Label14.Text = "ISBN:"
        '
        'txtISBN
        '
        Me.txtISBN.BackColor = System.Drawing.Color.DarkGray
        Me.txtISBN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtISBN.Location = New System.Drawing.Point(722, 252)
        Me.txtISBN.Name = "txtISBN"
        Me.txtISBN.ReadOnly = True
        Me.txtISBN.Size = New System.Drawing.Size(81, 20)
        Me.txtISBN.TabIndex = 70
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(910, 229)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 71
        Me.Label4.Text = "Código da Seção:"
        '
        'txtCodSecao
        '
        Me.txtCodSecao.BackColor = System.Drawing.Color.DarkGray
        Me.txtCodSecao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodSecao.Location = New System.Drawing.Point(914, 252)
        Me.txtCodSecao.Name = "txtCodSecao"
        Me.txtCodSecao.ReadOnly = True
        Me.txtCodSecao.Size = New System.Drawing.Size(81, 20)
        Me.txtCodSecao.TabIndex = 72
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.Control
        Me.Label18.Location = New System.Drawing.Point(16, 295)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(41, 13)
        Me.Label18.TabIndex = 73
        Me.Label18.Text = "Idioma:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.Control
        Me.Label19.Location = New System.Drawing.Point(373, 295)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(40, 13)
        Me.Label19.TabIndex = 75
        Me.Label19.Text = "Status:"
        '
        'txtIdioma
        '
        Me.txtIdioma.BackColor = System.Drawing.Color.DarkGray
        Me.txtIdioma.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdioma.Location = New System.Drawing.Point(20, 318)
        Me.txtIdioma.Name = "txtIdioma"
        Me.txtIdioma.ReadOnly = True
        Me.txtIdioma.Size = New System.Drawing.Size(211, 20)
        Me.txtIdioma.TabIndex = 80
        '
        'txtStatus
        '
        Me.txtStatus.BackColor = System.Drawing.Color.DarkGray
        Me.txtStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStatus.Location = New System.Drawing.Point(377, 318)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.ReadOnly = True
        Me.txtStatus.Size = New System.Drawing.Size(148, 20)
        Me.txtStatus.TabIndex = 82
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.Control
        Me.Label11.Location = New System.Drawing.Point(687, 159)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 13)
        Me.Label11.TabIndex = 62
        Me.Label11.Text = "Tipo do Item:"
        '
        'txtTipoItem
        '
        Me.txtTipoItem.BackColor = System.Drawing.Color.DarkGray
        Me.txtTipoItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoItem.Location = New System.Drawing.Point(691, 182)
        Me.txtTipoItem.Name = "txtTipoItem"
        Me.txtTipoItem.ReadOnly = True
        Me.txtTipoItem.Size = New System.Drawing.Size(145, 20)
        Me.txtTipoItem.TabIndex = 81
        '
        'btnSalva
        '
        Me.btnSalva.BackColor = System.Drawing.Color.Silver
        Me.btnSalva.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalva.ForeColor = System.Drawing.Color.Green
        Me.btnSalva.Location = New System.Drawing.Point(1041, 369)
        Me.btnSalva.Name = "btnSalva"
        Me.btnSalva.Size = New System.Drawing.Size(144, 34)
        Me.btnSalva.TabIndex = 85
        Me.btnSalva.Text = "Consultar"
        Me.btnSalva.UseVisualStyleBackColor = False
        '
        'ConsultaItemAcervo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.btnSalva)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtStatus)
        Me.Controls.Add(Me.txtTipoItem)
        Me.Controls.Add(Me.txtIdioma)
        Me.Controls.Add(Me.dgvInformacoes)
        Me.Controls.Add(Me.btnVoltar)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtCodSecao)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtISBN)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtCodColecao)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtCodAutor)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtCodLocal)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.txtCodg)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "ConsultaItemAcervo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Item do Acervo"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvInformacoes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCodg As TextBox
    Friend WithEvents txtNome As TextBox
    Friend WithEvents btnVoltar As Button
    Friend WithEvents btnSalvar As Button
    Friend WithEvents dgvInformacoes As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents rbNome As RadioButton
    Friend WithEvents rbCodigo As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCodLocal As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtCodAutor As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtCodColecao As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtISBN As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCodSecao As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents txtIdioma As TextBox
    Friend WithEvents txtStatus As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtTipoItem As TextBox
    Friend WithEvents codItem As DataGridViewTextBoxColumn
    Friend WithEvents numExemplar As DataGridViewTextBoxColumn
    Friend WithEvents nomeLocal As DataGridViewTextBoxColumn
    Friend WithEvents nomeItem As DataGridViewTextBoxColumn
    Friend WithEvents nomeAutor As DataGridViewTextBoxColumn
    Friend WithEvents nomeEditora As DataGridViewTextBoxColumn
    Friend WithEvents tipoItem As DataGridViewTextBoxColumn
    Friend WithEvents isbn As DataGridViewTextBoxColumn
    Friend WithEvents volume As DataGridViewTextBoxColumn
    Friend WithEvents anoEdicao As DataGridViewTextBoxColumn
    Friend WithEvents localizacao As DataGridViewTextBoxColumn
    Friend WithEvents secao As DataGridViewTextBoxColumn
    Friend WithEvents idioma As DataGridViewTextBoxColumn
    Friend WithEvents nomeColecao As DataGridViewTextBoxColumn
    Friend WithEvents status As DataGridViewTextBoxColumn
    Friend WithEvents btnSalva As Button
End Class
