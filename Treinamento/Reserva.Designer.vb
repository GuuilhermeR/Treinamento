<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Reserva
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCodReserva = New System.Windows.Forms.TextBox()
        Me.txtCodItem = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTipoItem = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNumExemplar = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtLocalizacao = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCodLeitor = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNomeItem = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbEncerrar = New System.Windows.Forms.CheckBox()
        Me.btnVoltar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnBuscarItem = New System.Windows.Forms.Button()
        Me.btnBuscarLeitor = New System.Windows.Forms.Button()
        Me.txtLeitor = New System.Windows.Forms.TextBox()
        Me.txtDataReserva = New System.Windows.Forms.DateTimePicker()
        Me.txtPrazo = New System.Windows.Forms.DateTimePicker()
        Me.dgvInformacoes = New System.Windows.Forms.DataGridView()
        Me.codReservaI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codItemI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nomeItemI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numExemplarI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipoItemI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.localizacaoI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codLeitorI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nomeLeitorI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataReservaI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prazoReservaI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.encerrarI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvInformacoes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(13, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código:"
        '
        'txtCodReserva
        '
        Me.txtCodReserva.BackColor = System.Drawing.Color.DarkGray
        Me.txtCodReserva.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodReserva.Location = New System.Drawing.Point(17, 40)
        Me.txtCodReserva.Name = "txtCodReserva"
        Me.txtCodReserva.Size = New System.Drawing.Size(100, 20)
        Me.txtCodReserva.TabIndex = 1
        '
        'txtCodItem
        '
        Me.txtCodItem.BackColor = System.Drawing.Color.DarkGray
        Me.txtCodItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodItem.Location = New System.Drawing.Point(15, 124)
        Me.txtCodItem.Name = "txtCodItem"
        Me.txtCodItem.ReadOnly = True
        Me.txtCodItem.Size = New System.Drawing.Size(100, 20)
        Me.txtCodItem.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(12, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Código do Item:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(230, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nome do Item:"
        '
        'txtTipoItem
        '
        Me.txtTipoItem.BackColor = System.Drawing.Color.DarkGray
        Me.txtTipoItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoItem.Location = New System.Drawing.Point(481, 124)
        Me.txtTipoItem.Name = "txtTipoItem"
        Me.txtTipoItem.ReadOnly = True
        Me.txtTipoItem.Size = New System.Drawing.Size(100, 20)
        Me.txtTipoItem.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(477, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Tipo do Item:"
        '
        'txtNumExemplar
        '
        Me.txtNumExemplar.BackColor = System.Drawing.Color.DarkGray
        Me.txtNumExemplar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumExemplar.Location = New System.Drawing.Point(937, 124)
        Me.txtNumExemplar.Name = "txtNumExemplar"
        Me.txtNumExemplar.ReadOnly = True
        Me.txtNumExemplar.Size = New System.Drawing.Size(100, 20)
        Me.txtNumExemplar.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(934, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Número Exemplar:"
        '
        'txtLocalizacao
        '
        Me.txtLocalizacao.BackColor = System.Drawing.Color.DarkGray
        Me.txtLocalizacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLocalizacao.Location = New System.Drawing.Point(718, 124)
        Me.txtLocalizacao.Name = "txtLocalizacao"
        Me.txtLocalizacao.ReadOnly = True
        Me.txtLocalizacao.Size = New System.Drawing.Size(100, 20)
        Me.txtLocalizacao.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.Location = New System.Drawing.Point(715, 101)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Localização:"
        '
        'txtCodLeitor
        '
        Me.txtCodLeitor.BackColor = System.Drawing.Color.DarkGray
        Me.txtCodLeitor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodLeitor.Location = New System.Drawing.Point(17, 203)
        Me.txtCodLeitor.Name = "txtCodLeitor"
        Me.txtCodLeitor.ReadOnly = True
        Me.txtCodLeitor.Size = New System.Drawing.Size(100, 20)
        Me.txtCodLeitor.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label7.Location = New System.Drawing.Point(14, 180)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Código Leitor:"
        '
        'txtNomeItem
        '
        Me.txtNomeItem.BackColor = System.Drawing.Color.DarkGray
        Me.txtNomeItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomeItem.Location = New System.Drawing.Point(234, 124)
        Me.txtNomeItem.Name = "txtNomeItem"
        Me.txtNomeItem.ReadOnly = True
        Me.txtNomeItem.Size = New System.Drawing.Size(100, 20)
        Me.txtNomeItem.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label8.Location = New System.Drawing.Point(234, 179)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Nome Leitor:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label9.Location = New System.Drawing.Point(628, 180)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Data da Reserva:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label10.Location = New System.Drawing.Point(847, 180)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(95, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Prazo da Reserva:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label11.Location = New System.Drawing.Point(1088, 180)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 13)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Encerrar?"
        '
        'cbEncerrar
        '
        Me.cbEncerrar.AutoSize = True
        Me.cbEncerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEncerrar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.cbEncerrar.Location = New System.Drawing.Point(1095, 205)
        Me.cbEncerrar.Name = "cbEncerrar"
        Me.cbEncerrar.Size = New System.Drawing.Size(43, 17)
        Me.cbEncerrar.TabIndex = 21
        Me.cbEncerrar.Text = "Sim"
        Me.cbEncerrar.UseVisualStyleBackColor = True
        '
        'btnVoltar
        '
        Me.btnVoltar.BackColor = System.Drawing.Color.Silver
        Me.btnVoltar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVoltar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnVoltar.Location = New System.Drawing.Point(17, 280)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Size = New System.Drawing.Size(111, 36)
        Me.btnVoltar.TabIndex = 40
        Me.btnVoltar.Text = "Voltar"
        Me.btnVoltar.UseVisualStyleBackColor = False
        '
        'btnExcluir
        '
        Me.btnExcluir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluir.BackColor = System.Drawing.Color.Silver
        Me.btnExcluir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcluir.ForeColor = System.Drawing.Color.Red
        Me.btnExcluir.Location = New System.Drawing.Point(1451, 280)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(115, 36)
        Me.btnExcluir.TabIndex = 38
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = False
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvar.BackColor = System.Drawing.Color.Silver
        Me.btnSalvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalvar.ForeColor = System.Drawing.Color.Green
        Me.btnSalvar.Location = New System.Drawing.Point(1301, 280)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(120, 36)
        Me.btnSalvar.TabIndex = 39
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.UseVisualStyleBackColor = False
        '
        'btnBuscarItem
        '
        Me.btnBuscarItem.BackColor = System.Drawing.Color.DarkGray
        Me.btnBuscarItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarItem.Location = New System.Drawing.Point(1098, 124)
        Me.btnBuscarItem.Name = "btnBuscarItem"
        Me.btnBuscarItem.Size = New System.Drawing.Size(96, 26)
        Me.btnBuscarItem.TabIndex = 41
        Me.btnBuscarItem.Text = "Buscar"
        Me.btnBuscarItem.UseVisualStyleBackColor = False
        '
        'btnBuscarLeitor
        '
        Me.btnBuscarLeitor.BackColor = System.Drawing.Color.DarkGray
        Me.btnBuscarLeitor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarLeitor.Location = New System.Drawing.Point(406, 196)
        Me.btnBuscarLeitor.Name = "btnBuscarLeitor"
        Me.btnBuscarLeitor.Size = New System.Drawing.Size(96, 27)
        Me.btnBuscarLeitor.TabIndex = 42
        Me.btnBuscarLeitor.Text = "Buscar"
        Me.btnBuscarLeitor.UseVisualStyleBackColor = False
        '
        'txtLeitor
        '
        Me.txtLeitor.BackColor = System.Drawing.Color.DarkGray
        Me.txtLeitor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLeitor.Location = New System.Drawing.Point(236, 202)
        Me.txtLeitor.Name = "txtLeitor"
        Me.txtLeitor.ReadOnly = True
        Me.txtLeitor.Size = New System.Drawing.Size(100, 20)
        Me.txtLeitor.TabIndex = 43
        '
        'txtDataReserva
        '
        Me.txtDataReserva.CalendarMonthBackground = System.Drawing.Color.DarkGray
        Me.txtDataReserva.CustomFormat = "yyyy-MM-dd"
        Me.txtDataReserva.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDataReserva.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtDataReserva.Location = New System.Drawing.Point(631, 203)
        Me.txtDataReserva.Name = "txtDataReserva"
        Me.txtDataReserva.Size = New System.Drawing.Size(103, 20)
        Me.txtDataReserva.TabIndex = 44
        Me.txtDataReserva.Value = New Date(2020, 2, 10, 0, 0, 0, 0)
        '
        'txtPrazo
        '
        Me.txtPrazo.CalendarMonthBackground = System.Drawing.Color.DarkGray
        Me.txtPrazo.CustomFormat = "yyyy-MM-dd"
        Me.txtPrazo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrazo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtPrazo.Location = New System.Drawing.Point(851, 203)
        Me.txtPrazo.Name = "txtPrazo"
        Me.txtPrazo.Size = New System.Drawing.Size(108, 20)
        Me.txtPrazo.TabIndex = 45
        Me.txtPrazo.Value = New Date(2020, 2, 10, 0, 0, 0, 0)
        '
        'dgvInformacoes
        '
        Me.dgvInformacoes.AllowUserToAddRows = False
        Me.dgvInformacoes.AllowUserToDeleteRows = False
        Me.dgvInformacoes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvInformacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInformacoes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codReservaI, Me.codItemI, Me.nomeItemI, Me.numExemplarI, Me.tipoItemI, Me.localizacaoI, Me.codLeitorI, Me.nomeLeitorI, Me.dataReservaI, Me.prazoReservaI, Me.encerrarI})
        Me.dgvInformacoes.Location = New System.Drawing.Point(17, 322)
        Me.dgvInformacoes.Name = "dgvInformacoes"
        Me.dgvInformacoes.ReadOnly = True
        Me.dgvInformacoes.Size = New System.Drawing.Size(1549, 471)
        Me.dgvInformacoes.TabIndex = 46
        '
        'codReservaI
        '
        Me.codReservaI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.codReservaI.DataPropertyName = "codReserva"
        Me.codReservaI.HeaderText = "Código da Reserva"
        Me.codReservaI.Name = "codReservaI"
        Me.codReservaI.ReadOnly = True
        Me.codReservaI.Width = 113
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
        'nomeItemI
        '
        Me.nomeItemI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.nomeItemI.DataPropertyName = "nomeItem"
        Me.nomeItemI.HeaderText = "Nome do Item"
        Me.nomeItemI.Name = "nomeItemI"
        Me.nomeItemI.ReadOnly = True
        Me.nomeItemI.Width = 72
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
        'codLeitorI
        '
        Me.codLeitorI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.codLeitorI.DataPropertyName = "codLeitor"
        Me.codLeitorI.HeaderText = "Código do Leitor"
        Me.codLeitorI.Name = "codLeitorI"
        Me.codLeitorI.ReadOnly = True
        Me.codLeitorI.Width = 77
        '
        'nomeLeitorI
        '
        Me.nomeLeitorI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.nomeLeitorI.DataPropertyName = "nomeLeitor"
        Me.nomeLeitorI.HeaderText = "Nome do Leitor"
        Me.nomeLeitorI.Name = "nomeLeitorI"
        Me.nomeLeitorI.ReadOnly = True
        Me.nomeLeitorI.Width = 96
        '
        'dataReservaI
        '
        Me.dataReservaI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dataReservaI.DataPropertyName = "dataReserva"
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.dataReservaI.DefaultCellStyle = DataGridViewCellStyle1
        Me.dataReservaI.HeaderText = "Data da Reserva"
        Me.dataReservaI.Name = "dataReservaI"
        Me.dataReservaI.ReadOnly = True
        Me.dataReservaI.Width = 104
        '
        'prazoReservaI
        '
        Me.prazoReservaI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.prazoReservaI.DataPropertyName = "prazoReserva"
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.prazoReservaI.DefaultCellStyle = DataGridViewCellStyle2
        Me.prazoReservaI.HeaderText = "Prazo da Reserva"
        Me.prazoReservaI.Name = "prazoReservaI"
        Me.prazoReservaI.ReadOnly = True
        Me.prazoReservaI.Width = 107
        '
        'encerrarI
        '
        Me.encerrarI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.encerrarI.DataPropertyName = "encerrar"
        Me.encerrarI.HeaderText = "Encerrado?"
        Me.encerrarI.Name = "encerrarI"
        Me.encerrarI.ReadOnly = True
        Me.encerrarI.Width = 87
        '
        'Reserva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1578, 805)
        Me.Controls.Add(Me.dgvInformacoes)
        Me.Controls.Add(Me.txtPrazo)
        Me.Controls.Add(Me.txtDataReserva)
        Me.Controls.Add(Me.txtLeitor)
        Me.Controls.Add(Me.btnBuscarLeitor)
        Me.Controls.Add(Me.btnBuscarItem)
        Me.Controls.Add(Me.btnVoltar)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.cbEncerrar)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtNomeItem)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtCodLeitor)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtLocalizacao)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtTipoItem)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNumExemplar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCodItem)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCodReserva)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Name = "Reserva"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reserva"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvInformacoes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtCodReserva As TextBox
    Friend WithEvents txtCodItem As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTipoItem As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNumExemplar As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtLocalizacao As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCodLeitor As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtNomeItem As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents cbEncerrar As CheckBox
    Friend WithEvents btnVoltar As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btnSalvar As Button
    Friend WithEvents btnBuscarItem As Button
    Friend WithEvents btnBuscarLeitor As Button
    Friend WithEvents txtLeitor As TextBox
    Friend WithEvents txtDataReserva As DateTimePicker
    Friend WithEvents txtPrazo As DateTimePicker
    Friend WithEvents dgvInformacoes As DataGridView
    Friend WithEvents codReservaI As DataGridViewTextBoxColumn
    Friend WithEvents codItemI As DataGridViewTextBoxColumn
    Friend WithEvents nomeItemI As DataGridViewTextBoxColumn
    Friend WithEvents numExemplarI As DataGridViewTextBoxColumn
    Friend WithEvents tipoItemI As DataGridViewTextBoxColumn
    Friend WithEvents localizacaoI As DataGridViewTextBoxColumn
    Friend WithEvents codLeitorI As DataGridViewTextBoxColumn
    Friend WithEvents nomeLeitorI As DataGridViewTextBoxColumn
    Friend WithEvents dataReservaI As DataGridViewTextBoxColumn
    Friend WithEvents prazoReservaI As DataGridViewTextBoxColumn
    Friend WithEvents encerrarI As DataGridViewTextBoxColumn
End Class
