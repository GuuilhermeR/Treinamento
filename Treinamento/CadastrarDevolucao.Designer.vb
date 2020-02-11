<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CadastrarDevolucao
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtCodg = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNomeItem = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNumExemplar = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtTipoItem = New System.Windows.Forms.TextBox()
        Me.txtLocalizacao = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtNomeLeitor = New System.Windows.Forms.TextBox()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbDevolvido = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtCodItem = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnVoltar = New System.Windows.Forms.Button()
        Me.txtPrazoDev = New System.Windows.Forms.DateTimePicker()
        Me.txtDataDevolucao = New System.Windows.Forms.DateTimePicker()
        Me.dgvInformacoes = New System.Windows.Forms.DataGridView()
        Me.codEmprestimoI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nomeItemI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numExemplarI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codItemI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipoItemI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.localizacaoI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nomeLeitorI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataEmprestimoI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prazoDevolucaoI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataDevolucaoI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.devolvidoI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtDataEmprest = New System.Windows.Forms.DateTimePicker()
        Me.txtCodLeitor = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.dgvInformacoes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCodg
        '
        Me.txtCodg.BackColor = System.Drawing.Color.Silver
        Me.txtCodg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodg.Location = New System.Drawing.Point(53, 59)
        Me.txtCodg.Name = "txtCodg"
        Me.txtCodg.Size = New System.Drawing.Size(81, 20)
        Me.txtCodg.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(49, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Código de Devolução:"
        '
        'txtNomeItem
        '
        Me.txtNomeItem.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtNomeItem.BackColor = System.Drawing.Color.Silver
        Me.txtNomeItem.Enabled = False
        Me.txtNomeItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomeItem.Location = New System.Drawing.Point(315, 153)
        Me.txtNomeItem.MaxLength = 200
        Me.txtNomeItem.Name = "txtNomeItem"
        Me.txtNomeItem.ReadOnly = True
        Me.txtNomeItem.Size = New System.Drawing.Size(163, 20)
        Me.txtNomeItem.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(312, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Nome do item:"
        '
        'txtNumExemplar
        '
        Me.txtNumExemplar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtNumExemplar.BackColor = System.Drawing.Color.Silver
        Me.txtNumExemplar.Enabled = False
        Me.txtNumExemplar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumExemplar.Location = New System.Drawing.Point(709, 153)
        Me.txtNumExemplar.Name = "txtNumExemplar"
        Me.txtNumExemplar.ReadOnly = True
        Me.txtNumExemplar.Size = New System.Drawing.Size(94, 20)
        Me.txtNumExemplar.TabIndex = 54
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.Control
        Me.Label12.Location = New System.Drawing.Point(705, 130)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(93, 13)
        Me.Label12.TabIndex = 53
        Me.Label12.Text = "Número Exemplar:"
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.Control
        Me.Label11.Location = New System.Drawing.Point(958, 130)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 13)
        Me.Label11.TabIndex = 55
        Me.Label11.Text = "Tipo do Item:"
        '
        'txtTipoItem
        '
        Me.txtTipoItem.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtTipoItem.BackColor = System.Drawing.Color.Silver
        Me.txtTipoItem.Enabled = False
        Me.txtTipoItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoItem.Location = New System.Drawing.Point(962, 153)
        Me.txtTipoItem.MaxLength = 50
        Me.txtTipoItem.Name = "txtTipoItem"
        Me.txtTipoItem.ReadOnly = True
        Me.txtTipoItem.Size = New System.Drawing.Size(228, 20)
        Me.txtTipoItem.TabIndex = 57
        '
        'txtLocalizacao
        '
        Me.txtLocalizacao.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtLocalizacao.BackColor = System.Drawing.Color.Silver
        Me.txtLocalizacao.Enabled = False
        Me.txtLocalizacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLocalizacao.Location = New System.Drawing.Point(314, 220)
        Me.txtLocalizacao.MaxLength = 50
        Me.txtLocalizacao.Name = "txtLocalizacao"
        Me.txtLocalizacao.ReadOnly = True
        Me.txtLocalizacao.Size = New System.Drawing.Size(264, 20)
        Me.txtLocalizacao.TabIndex = 59
        '
        'Label16
        '
        Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.Control
        Me.Label16.Location = New System.Drawing.Point(311, 197)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(67, 13)
        Me.Label16.TabIndex = 58
        Me.Label16.Text = "Localização:"
        '
        'txtNomeLeitor
        '
        Me.txtNomeLeitor.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtNomeLeitor.BackColor = System.Drawing.Color.Silver
        Me.txtNomeLeitor.Enabled = False
        Me.txtNomeLeitor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomeLeitor.Location = New System.Drawing.Point(962, 220)
        Me.txtNomeLeitor.MaxLength = 200
        Me.txtNomeLeitor.Name = "txtNomeLeitor"
        Me.txtNomeLeitor.ReadOnly = True
        Me.txtNomeLeitor.Size = New System.Drawing.Size(246, 20)
        Me.txtNomeLeitor.TabIndex = 63
        '
        'lblNome
        '
        Me.lblNome.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblNome.AutoSize = True
        Me.lblNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNome.ForeColor = System.Drawing.SystemColors.Control
        Me.lblNome.Location = New System.Drawing.Point(958, 197)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(78, 13)
        Me.lblNome.TabIndex = 62
        Me.lblNome.Text = "Nome do leitor:"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.Control
        Me.Label9.Location = New System.Drawing.Point(311, 268)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 13)
        Me.Label9.TabIndex = 64
        Me.Label9.Text = "Data do empréstimo:"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.Control
        Me.Label10.Location = New System.Drawing.Point(765, 268)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(101, 13)
        Me.Label10.TabIndex = 66
        Me.Label10.Text = "Data de devolução:"
        '
        'cbDevolvido
        '
        Me.cbDevolvido.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cbDevolvido.AutoSize = True
        Me.cbDevolvido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDevolvido.ForeColor = System.Drawing.SystemColors.Control
        Me.cbDevolvido.Location = New System.Drawing.Point(1056, 300)
        Me.cbDevolvido.Name = "cbDevolvido"
        Me.cbDevolvido.Size = New System.Drawing.Size(43, 17)
        Me.cbDevolvido.TabIndex = 69
        Me.cbDevolvido.Text = "Sim"
        Me.cbDevolvido.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(1053, 271)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 68
        Me.Label4.Text = "Devolvido?"
        '
        'btnExcluir
        '
        Me.btnExcluir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluir.BackColor = System.Drawing.Color.DarkGray
        Me.btnExcluir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcluir.ForeColor = System.Drawing.Color.Red
        Me.btnExcluir.Location = New System.Drawing.Point(1447, 364)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(119, 36)
        Me.btnExcluir.TabIndex = 70
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = False
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvar.BackColor = System.Drawing.Color.DarkGray
        Me.btnSalvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalvar.ForeColor = System.Drawing.Color.Green
        Me.btnSalvar.Location = New System.Drawing.Point(1306, 364)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(119, 36)
        Me.btnSalvar.TabIndex = 71
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(530, 268)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(130, 20)
        Me.Label5.TabIndex = 76
        Me.Label5.Text = "Prazo devolução:"
        '
        'btnBuscar
        '
        Me.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnBuscar.BackColor = System.Drawing.Color.DarkGray
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(401, 87)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(77, 21)
        Me.btnBuscar.TabIndex = 80
        Me.btnBuscar.Text = "Pesquisar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'txtCodItem
        '
        Me.txtCodItem.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtCodItem.BackColor = System.Drawing.Color.Silver
        Me.txtCodItem.Enabled = False
        Me.txtCodItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodItem.Location = New System.Drawing.Point(314, 88)
        Me.txtCodItem.Name = "txtCodItem"
        Me.txtCodItem.ReadOnly = True
        Me.txtCodItem.Size = New System.Drawing.Size(81, 20)
        Me.txtCodItem.TabIndex = 79
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(311, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "Código do item:"
        '
        'btnVoltar
        '
        Me.btnVoltar.BackColor = System.Drawing.Color.DarkGray
        Me.btnVoltar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVoltar.Location = New System.Drawing.Point(12, 364)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Size = New System.Drawing.Size(111, 36)
        Me.btnVoltar.TabIndex = 72
        Me.btnVoltar.Text = "Voltar"
        Me.btnVoltar.UseVisualStyleBackColor = False
        '
        'txtPrazoDev
        '
        Me.txtPrazoDev.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtPrazoDev.CalendarMonthBackground = System.Drawing.Color.DarkGray
        Me.txtPrazoDev.CustomFormat = "yyyy-MM-dd"
        Me.txtPrazoDev.Enabled = False
        Me.txtPrazoDev.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrazoDev.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtPrazoDev.Location = New System.Drawing.Point(534, 295)
        Me.txtPrazoDev.Name = "txtPrazoDev"
        Me.txtPrazoDev.Size = New System.Drawing.Size(94, 20)
        Me.txtPrazoDev.TabIndex = 86
        Me.txtPrazoDev.Value = New Date(2020, 2, 10, 0, 0, 0, 0)
        '
        'txtDataDevolucao
        '
        Me.txtDataDevolucao.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtDataDevolucao.CalendarMonthBackground = System.Drawing.Color.DarkGray
        Me.txtDataDevolucao.CustomFormat = "yyyy-MM-dd"
        Me.txtDataDevolucao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDataDevolucao.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtDataDevolucao.Location = New System.Drawing.Point(769, 295)
        Me.txtDataDevolucao.Name = "txtDataDevolucao"
        Me.txtDataDevolucao.Size = New System.Drawing.Size(97, 20)
        Me.txtDataDevolucao.TabIndex = 89
        Me.txtDataDevolucao.Value = New Date(2020, 2, 6, 0, 0, 0, 0)
        '
        'dgvInformacoes
        '
        Me.dgvInformacoes.AllowUserToAddRows = False
        Me.dgvInformacoes.AllowUserToDeleteRows = False
        Me.dgvInformacoes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvInformacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInformacoes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codEmprestimoI, Me.nomeItemI, Me.numExemplarI, Me.codItemI, Me.tipoItemI, Me.localizacaoI, Me.nomeLeitorI, Me.dataEmprestimoI, Me.prazoDevolucaoI, Me.dataDevolucaoI, Me.devolvidoI})
        Me.dgvInformacoes.Location = New System.Drawing.Point(12, 406)
        Me.dgvInformacoes.Name = "dgvInformacoes"
        Me.dgvInformacoes.ReadOnly = True
        Me.dgvInformacoes.Size = New System.Drawing.Size(1554, 387)
        Me.dgvInformacoes.TabIndex = 90
        '
        'codEmprestimoI
        '
        Me.codEmprestimoI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.codEmprestimoI.DataPropertyName = "codEmprestimo"
        Me.codEmprestimoI.HeaderText = "Código do Empréstimo"
        Me.codEmprestimoI.Name = "codEmprestimoI"
        Me.codEmprestimoI.ReadOnly = True
        Me.codEmprestimoI.Width = 125
        '
        'nomeItemI
        '
        Me.nomeItemI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.nomeItemI.DataPropertyName = "nomeItem"
        Me.nomeItemI.HeaderText = "Item"
        Me.nomeItemI.Name = "nomeItemI"
        Me.nomeItemI.ReadOnly = True
        Me.nomeItemI.Width = 52
        '
        'numExemplarI
        '
        Me.numExemplarI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.numExemplarI.DataPropertyName = "numExemplar"
        Me.numExemplarI.HeaderText = "Número Exemplar"
        Me.numExemplarI.Name = "numExemplarI"
        Me.numExemplarI.ReadOnly = True
        Me.numExemplarI.Width = 105
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
        'nomeLeitorI
        '
        Me.nomeLeitorI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.nomeLeitorI.DataPropertyName = "nomeLeitor"
        Me.nomeLeitorI.HeaderText = "Nome Leitor"
        Me.nomeLeitorI.Name = "nomeLeitorI"
        Me.nomeLeitorI.ReadOnly = True
        Me.nomeLeitorI.Width = 82
        '
        'dataEmprestimoI
        '
        Me.dataEmprestimoI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dataEmprestimoI.DataPropertyName = "dataEmprestimo"
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.dataEmprestimoI.DefaultCellStyle = DataGridViewCellStyle1
        Me.dataEmprestimoI.HeaderText = "Data Empréstimo"
        Me.dataEmprestimoI.Name = "dataEmprestimoI"
        Me.dataEmprestimoI.ReadOnly = True
        Me.dataEmprestimoI.Width = 103
        '
        'prazoDevolucaoI
        '
        Me.prazoDevolucaoI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.prazoDevolucaoI.DataPropertyName = "prazoDevolucao"
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.prazoDevolucaoI.DefaultCellStyle = DataGridViewCellStyle2
        Me.prazoDevolucaoI.HeaderText = "Prazo"
        Me.prazoDevolucaoI.Name = "prazoDevolucaoI"
        Me.prazoDevolucaoI.ReadOnly = True
        Me.prazoDevolucaoI.Width = 59
        '
        'dataDevolucaoI
        '
        Me.dataDevolucaoI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dataDevolucaoI.DataPropertyName = "dataDevolucao"
        DataGridViewCellStyle3.Format = "d"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.dataDevolucaoI.DefaultCellStyle = DataGridViewCellStyle3
        Me.dataDevolucaoI.HeaderText = "Data devolução"
        Me.dataDevolucaoI.Name = "dataDevolucaoI"
        Me.dataDevolucaoI.ReadOnly = True
        Me.dataDevolucaoI.Width = 99
        '
        'devolvidoI
        '
        Me.devolvidoI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.devolvidoI.DataPropertyName = "devolvido"
        Me.devolvidoI.HeaderText = "Devolvido"
        Me.devolvidoI.Name = "devolvidoI"
        Me.devolvidoI.ReadOnly = True
        Me.devolvidoI.Width = 80
        '
        'txtDataEmprest
        '
        Me.txtDataEmprest.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtDataEmprest.CalendarMonthBackground = System.Drawing.Color.DarkGray
        Me.txtDataEmprest.CustomFormat = "yyyy-MM-dd"
        Me.txtDataEmprest.Enabled = False
        Me.txtDataEmprest.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDataEmprest.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtDataEmprest.Location = New System.Drawing.Point(314, 295)
        Me.txtDataEmprest.Name = "txtDataEmprest"
        Me.txtDataEmprest.Size = New System.Drawing.Size(101, 20)
        Me.txtDataEmprest.TabIndex = 85
        Me.txtDataEmprest.Value = New Date(2020, 2, 10, 0, 0, 0, 0)
        '
        'txtCodLeitor
        '
        Me.txtCodLeitor.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtCodLeitor.BackColor = System.Drawing.Color.Silver
        Me.txtCodLeitor.Enabled = False
        Me.txtCodLeitor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodLeitor.Location = New System.Drawing.Point(710, 220)
        Me.txtCodLeitor.MaxLength = 200
        Me.txtCodLeitor.Name = "txtCodLeitor"
        Me.txtCodLeitor.ReadOnly = True
        Me.txtCodLeitor.Size = New System.Drawing.Size(93, 20)
        Me.txtCodLeitor.TabIndex = 92
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(706, 197)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 13)
        Me.Label6.TabIndex = 91
        Me.Label6.Text = "Código do leitor:"
        '
        'CadastrarDevolucao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1578, 805)
        Me.Controls.Add(Me.txtCodLeitor)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dgvInformacoes)
        Me.Controls.Add(Me.txtDataDevolucao)
        Me.Controls.Add(Me.txtPrazoDev)
        Me.Controls.Add(Me.txtDataEmprest)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtCodItem)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnVoltar)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.cbDevolvido)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtNomeLeitor)
        Me.Controls.Add(Me.lblNome)
        Me.Controls.Add(Me.txtLocalizacao)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtTipoItem)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtNumExemplar)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtNomeItem)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCodg)
        Me.Controls.Add(Me.Label2)
        Me.Name = "CadastrarDevolucao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastrar Devolução"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvInformacoes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCodg As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNomeItem As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNumExemplar As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtTipoItem As TextBox
    Friend WithEvents txtLocalizacao As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtNomeLeitor As TextBox
    Friend WithEvents lblNome As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents cbDevolvido As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btnSalvar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtCodItem As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnVoltar As Button
    Friend WithEvents txtPrazoDev As DateTimePicker
    Friend WithEvents txtDataDevolucao As DateTimePicker
    Friend WithEvents dgvInformacoes As DataGridView
    Friend WithEvents txtDataEmprest As DateTimePicker
    Friend WithEvents codEmprestimoI As DataGridViewTextBoxColumn
    Friend WithEvents nomeItemI As DataGridViewTextBoxColumn
    Friend WithEvents numExemplarI As DataGridViewTextBoxColumn
    Friend WithEvents codItemI As DataGridViewTextBoxColumn
    Friend WithEvents tipoItemI As DataGridViewTextBoxColumn
    Friend WithEvents localizacaoI As DataGridViewTextBoxColumn
    Friend WithEvents nomeLeitorI As DataGridViewTextBoxColumn
    Friend WithEvents dataEmprestimoI As DataGridViewTextBoxColumn
    Friend WithEvents prazoDevolucaoI As DataGridViewTextBoxColumn
    Friend WithEvents dataDevolucaoI As DataGridViewTextBoxColumn
    Friend WithEvents devolvidoI As DataGridViewTextBoxColumn
    Friend WithEvents txtCodLeitor As TextBox
    Friend WithEvents Label6 As Label
End Class
